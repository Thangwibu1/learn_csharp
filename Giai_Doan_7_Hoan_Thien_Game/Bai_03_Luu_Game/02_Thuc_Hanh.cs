using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Lesson03InventoryEntry
{
    public string itemId;
    public int quantity;
}

[Serializable]
public class Lesson03SaveData
{
    public string playerName = "Hero";
    public int gold;
    public int level = 1;
    public int currentHealth = 100;
    public int maxHealth = 100;
    public float checkpointX;
    public float checkpointY;
    public float checkpointZ;
    public float musicVolume = 0.8f;
    public float sfxVolume = 0.8f;
    public bool tutorialFinished;
    public List<Lesson03InventoryEntry> inventory = new List<Lesson03InventoryEntry>();
}

public class Lesson03PlayerProfile : MonoBehaviour
{
    [Header("Thong tin runtime")]
    [SerializeField] private string playerName = "Hero";
    [SerializeField] private int gold;
    [SerializeField] private int level = 1;
    [SerializeField] private int currentHealth = 100;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private Transform checkpointTransform;

    [Header("Kho do demo")]
    [SerializeField] private List<Lesson03InventoryEntry> inventory = new List<Lesson03InventoryEntry>();

    public Lesson03SaveData BuildSaveData()
    {
        Lesson03SaveData data = new Lesson03SaveData
        {
            playerName = playerName,
            gold = gold,
            level = level,
            currentHealth = currentHealth,
            maxHealth = maxHealth,
            tutorialFinished = level > 1
        };

        if (checkpointTransform != null)
        {
            Vector3 position = checkpointTransform.position;
            data.checkpointX = position.x;
            data.checkpointY = position.y;
            data.checkpointZ = position.z;
        }

        for (int i = 0; i < inventory.Count; i++)
        {
            Lesson03InventoryEntry source = inventory[i];
            data.inventory.Add(new Lesson03InventoryEntry
            {
                itemId = source.itemId,
                quantity = source.quantity
            });
        }

        return data;
    }

    public void ApplySaveData(Lesson03SaveData data)
    {
        if (data == null)
        {
            return;
        }

        playerName = data.playerName;
        gold = data.gold;
        level = data.level;
        currentHealth = data.currentHealth;
        maxHealth = data.maxHealth;

        if (checkpointTransform != null)
        {
            checkpointTransform.position = new Vector3(data.checkpointX, data.checkpointY, data.checkpointZ);
        }

        inventory.Clear();
        for (int i = 0; i < data.inventory.Count; i++)
        {
            Lesson03InventoryEntry source = data.inventory[i];
            inventory.Add(new Lesson03InventoryEntry
            {
                itemId = source.itemId,
                quantity = source.quantity
            });
        }
    }

    public void AddGold(int amount)
    {
        gold += Mathf.Max(0, amount);
    }

    public void AddItem(string itemId, int quantity)
    {
        if (string.IsNullOrEmpty(itemId) || quantity <= 0)
        {
            return;
        }

        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemId == itemId)
            {
                inventory[i].quantity += quantity;
                return;
            }
        }

        inventory.Add(new Lesson03InventoryEntry
        {
            itemId = itemId,
            quantity = quantity
        });
    }

    public string BuildInventoryText()
    {
        if (inventory.Count == 0)
        {
            return "Kho do trong";
        }

        List<string> lines = new List<string>();
        for (int i = 0; i < inventory.Count; i++)
        {
            lines.Add($"- {inventory[i].itemId}: {inventory[i].quantity}");
        }

        return string.Join("\n", lines);
    }
}

public class Lesson03SaveSystem : MonoBehaviour
{
    public const string SaveKey = "LESSON03_SAVE_DATA";

    [SerializeField] private Lesson03PlayerProfile playerProfile;
    [SerializeField] private Lesson03SettingsBinder settingsBinder;
    [SerializeField] private bool autoLoadOnStart = true;
    [SerializeField] private bool autoSaveOnApplicationPause = true;

    public Lesson03SaveData CurrentData { get; private set; }

    private void Start()
    {
        if (autoLoadOnStart)
        {
            Load();
        }
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus && autoSaveOnApplicationPause)
        {
            Save();
        }
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    public void Save()
    {
        Lesson03SaveData data = playerProfile != null ? playerProfile.BuildSaveData() : new Lesson03SaveData();

        if (settingsBinder != null)
        {
            settingsBinder.WriteToSaveData(data);
        }

        string json = JsonUtility.ToJson(data, true);
        PlayerPrefs.SetString(SaveKey, json);
        PlayerPrefs.Save();
        CurrentData = data;

        Debug.Log("Da luu du lieu demo bai 03.\n" + json);
    }

    public void Load()
    {
        if (!PlayerPrefs.HasKey(SaveKey))
        {
            CurrentData = CreateDefaultData();
            ApplyLoadedData(CurrentData);
            return;
        }

        string json = PlayerPrefs.GetString(SaveKey);
        CurrentData = JsonUtility.FromJson<Lesson03SaveData>(json);

        if (CurrentData == null)
        {
            CurrentData = CreateDefaultData();
        }

        ApplyLoadedData(CurrentData);
        Debug.Log("Da tai du lieu demo bai 03.\n" + json);
    }

    public void DeleteSave()
    {
        PlayerPrefs.DeleteKey(SaveKey);
        PlayerPrefs.Save();
        CurrentData = CreateDefaultData();
        ApplyLoadedData(CurrentData);
        Debug.Log("Da xoa file save demo.");
    }

    public string BuildDebugSummary()
    {
        Lesson03SaveData data = CurrentData ?? CreateDefaultData();
        return $"Ten: {data.playerName}\nGold: {data.gold}\nLevel: {data.level}\nMau: {data.currentHealth}/{data.maxHealth}\nInventory: {data.inventory.Count} item";
    }

    private void ApplyLoadedData(Lesson03SaveData data)
    {
        if (playerProfile != null)
        {
            playerProfile.ApplySaveData(data);
        }

        if (settingsBinder != null)
        {
            settingsBinder.ApplyFromSaveData(data);
        }
    }

    private Lesson03SaveData CreateDefaultData()
    {
        Lesson03SaveData data = new Lesson03SaveData();
        data.inventory.Add(new Lesson03InventoryEntry
        {
            itemId = "Potion",
            quantity = 2
        });
        return data;
    }
}

public class Lesson03SettingsBinder : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private Text settingsText;

    public void WriteToSaveData(Lesson03SaveData data)
    {
        if (data == null)
        {
            return;
        }

        data.musicVolume = musicSlider != null ? musicSlider.value : data.musicVolume;
        data.sfxVolume = sfxSlider != null ? sfxSlider.value : data.sfxVolume;
    }

    public void ApplyFromSaveData(Lesson03SaveData data)
    {
        if (data == null)
        {
            return;
        }

        if (musicSlider != null)
        {
            musicSlider.value = data.musicVolume;
        }

        if (sfxSlider != null)
        {
            sfxSlider.value = data.sfxVolume;
        }

        RefreshText(data);
    }

    public void RefreshText(Lesson03SaveData data)
    {
        if (settingsText != null && data != null)
        {
            settingsText.text = $"Music: {data.musicVolume:F2}\nSFX: {data.sfxVolume:F2}";
        }
    }
}

public class Lesson03SaveDebugUI : MonoBehaviour
{
    [SerializeField] private Lesson03SaveSystem saveSystem;
    [SerializeField] private Lesson03PlayerProfile playerProfile;
    [SerializeField] private Text summaryText;
    [SerializeField] private Text inventoryText;

    private void Start()
    {
        RefreshLabels();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5) && saveSystem != null)
        {
            saveSystem.Save();
            RefreshLabels();
        }

        if (Input.GetKeyDown(KeyCode.F9) && saveSystem != null)
        {
            saveSystem.Load();
            RefreshLabels();
        }

        if (Input.GetKeyDown(KeyCode.Delete) && saveSystem != null)
        {
            saveSystem.DeleteSave();
            RefreshLabels();
        }

        if (Input.GetKeyDown(KeyCode.G) && playerProfile != null)
        {
            playerProfile.AddGold(25);
            RefreshLabels();
        }

        if (Input.GetKeyDown(KeyCode.I) && playerProfile != null)
        {
            playerProfile.AddItem("Gem", 1);
            RefreshLabels();
        }
    }

    public void RefreshLabels()
    {
        if (summaryText != null && saveSystem != null)
        {
            summaryText.text = saveSystem.BuildDebugSummary();
        }

        if (inventoryText != null && playerProfile != null)
        {
            inventoryText.text = playerProfile.BuildInventoryText();
        }
    }
}
