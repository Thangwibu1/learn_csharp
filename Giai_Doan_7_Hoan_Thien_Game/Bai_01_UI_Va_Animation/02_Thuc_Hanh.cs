using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Lesson01UiSnapshot
{
    public int currentHealth;
    public int maxHealth;
    public int currentEnergy;
    public int maxEnergy;
    public int coins;
    public bool isPaused;
}

public class Lesson01PlayerStats : MonoBehaviour
{
    public event Action<Lesson01UiSnapshot> OnStatsChanged;
    public event Action<string> OnHintRequested;
    public event Action OnPlayerDied;

    [Header("Chi so co ban")]
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int maxEnergy = 50;
    [SerializeField] private int startCoins = 0;

    [Header("Toc do hoi phuc")]
    [SerializeField] private float energyRegenPerSecond = 8f;
    [SerializeField] private float healthRegenDelay = 5f;
    [SerializeField] private float healthRegenPerSecond = 2f;

    private int currentHealth;
    private int currentEnergy;
    private int currentCoins;
    private bool isPaused;
    private float lastDamageTime;

    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;
    public int CurrentEnergy => currentEnergy;
    public int MaxEnergy => maxEnergy;
    public int CurrentCoins => currentCoins;
    public bool IsPaused => isPaused;

    private void Awake()
    {
        currentHealth = maxHealth;
        currentEnergy = maxEnergy;
        currentCoins = startCoins;
        lastDamageTime = -healthRegenDelay;
    }

    private void Start()
    {
        BroadcastSnapshot();
        OnHintRequested?.Invoke("Nhan 1 de mat mau, 2 de hoi mau, 3 de tieu hao nang luong, 4 de nhat coin.");
    }

    private void Update()
    {
        if (isPaused)
        {
            return;
        }

        RegenerateEnergy();
        RegenerateHealth();
    }

    public void TakeDamage(int amount)
    {
        if (amount <= 0 || currentHealth <= 0)
        {
            return;
        }

        currentHealth = Mathf.Max(0, currentHealth - amount);
        lastDamageTime = Time.time;
        BroadcastSnapshot();
        OnHintRequested?.Invoke($"Nhan vat vua mat {amount} mau.");

        if (currentHealth == 0)
        {
            OnPlayerDied?.Invoke();
            OnHintRequested?.Invoke("Nhan vat da het mau. Thu hoi lai bang phim 2.");
        }
    }

    public void Heal(int amount)
    {
        if (amount <= 0 || currentHealth <= 0)
        {
            return;
        }

        int oldHealth = currentHealth;
        currentHealth = Mathf.Min(maxHealth, currentHealth + amount);

        if (oldHealth != currentHealth)
        {
            BroadcastSnapshot();
            OnHintRequested?.Invoke($"Nhan vat duoc hoi {currentHealth - oldHealth} mau.");
        }
    }

    public bool TrySpendEnergy(int amount)
    {
        if (amount <= 0)
        {
            return true;
        }

        if (currentEnergy < amount)
        {
            OnHintRequested?.Invoke("Khong du nang luong de thuc hien hanh dong.");
            return false;
        }

        currentEnergy -= amount;
        BroadcastSnapshot();
        return true;
    }

    public void AddEnergy(int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        int oldEnergy = currentEnergy;
        currentEnergy = Mathf.Min(maxEnergy, currentEnergy + amount);

        if (oldEnergy != currentEnergy)
        {
            BroadcastSnapshot();
        }
    }

    public void AddCoins(int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        currentCoins += amount;
        BroadcastSnapshot();
        OnHintRequested?.Invoke($"Nhan duoc {amount} coin.");
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;
        BroadcastSnapshot();
        OnHintRequested?.Invoke(isPaused ? "Game dang tam dung." : "Game tiep tuc.");
    }

    public void ReviveFull()
    {
        currentHealth = maxHealth;
        currentEnergy = maxEnergy;
        BroadcastSnapshot();
        OnHintRequested?.Invoke("Nhan vat hoi sinh voi chi so day du.");
    }

    private void RegenerateEnergy()
    {
        if (currentHealth <= 0 || currentEnergy >= maxEnergy)
        {
            return;
        }

        float delta = energyRegenPerSecond * Time.deltaTime;
        int addAmount = Mathf.FloorToInt(delta);

        if (addAmount <= 0)
        {
            return;
        }

        currentEnergy = Mathf.Min(maxEnergy, currentEnergy + addAmount);
        BroadcastSnapshot();
    }

    private void RegenerateHealth()
    {
        if (currentHealth <= 0 || currentHealth >= maxHealth)
        {
            return;
        }

        if (Time.time - lastDamageTime < healthRegenDelay)
        {
            return;
        }

        float delta = healthRegenPerSecond * Time.deltaTime;
        int addAmount = Mathf.FloorToInt(delta);

        if (addAmount <= 0)
        {
            return;
        }

        currentHealth = Mathf.Min(maxHealth, currentHealth + addAmount);
        BroadcastSnapshot();
    }

    private void BroadcastSnapshot()
    {
        Lesson01UiSnapshot snapshot = new Lesson01UiSnapshot
        {
            currentHealth = currentHealth,
            maxHealth = maxHealth,
            currentEnergy = currentEnergy,
            maxEnergy = maxEnergy,
            coins = currentCoins,
            isPaused = isPaused
        };

        OnStatsChanged?.Invoke(snapshot);
    }
}

public class Lesson01HudController : MonoBehaviour
{
    [Header("Nguon du lieu")]
    [SerializeField] private Lesson01PlayerStats playerStats;

    [Header("Thanh trang thai")]
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider energySlider;
    [SerializeField] private Image healthFill;
    [SerializeField] private Image energyFill;

    [Header("Text hien thi")]
    [SerializeField] private Text healthText;
    [SerializeField] private Text energyText;
    [SerializeField] private Text coinText;
    [SerializeField] private Text pauseText;
    [SerializeField] private Text hintText;

    [Header("Mau sac")]
    [SerializeField] private Color safeHealthColor = new Color(0.2f, 0.8f, 0.3f);
    [SerializeField] private Color dangerHealthColor = new Color(0.9f, 0.2f, 0.2f);
    [SerializeField] private Color fullEnergyColor = new Color(0.2f, 0.7f, 1f);
    [SerializeField] private Color lowEnergyColor = new Color(0.9f, 0.6f, 0.2f);

    private void OnEnable()
    {
        if (playerStats == null)
        {
            return;
        }

        playerStats.OnStatsChanged += Refresh;
        playerStats.OnHintRequested += ShowHint;
        playerStats.OnPlayerDied += ShowDeathHint;
    }

    private void OnDisable()
    {
        if (playerStats == null)
        {
            return;
        }

        playerStats.OnStatsChanged -= Refresh;
        playerStats.OnHintRequested -= ShowHint;
        playerStats.OnPlayerDied -= ShowDeathHint;
    }

    private void Start()
    {
        if (playerStats != null)
        {
            Refresh(new Lesson01UiSnapshot
            {
                currentHealth = playerStats.CurrentHealth,
                maxHealth = playerStats.MaxHealth,
                currentEnergy = playerStats.CurrentEnergy,
                maxEnergy = playerStats.MaxEnergy,
                coins = playerStats.CurrentCoins,
                isPaused = playerStats.IsPaused
            });
        }
    }

    private void Refresh(Lesson01UiSnapshot snapshot)
    {
        float healthPercent = snapshot.maxHealth <= 0 ? 0f : (float)snapshot.currentHealth / snapshot.maxHealth;
        float energyPercent = snapshot.maxEnergy <= 0 ? 0f : (float)snapshot.currentEnergy / snapshot.maxEnergy;

        if (healthSlider != null)
        {
            healthSlider.value = healthPercent;
        }

        if (energySlider != null)
        {
            energySlider.value = energyPercent;
        }

        if (healthFill != null)
        {
            healthFill.color = Color.Lerp(dangerHealthColor, safeHealthColor, healthPercent);
        }

        if (energyFill != null)
        {
            energyFill.color = Color.Lerp(lowEnergyColor, fullEnergyColor, energyPercent);
        }

        if (healthText != null)
        {
            healthText.text = $"Mau: {snapshot.currentHealth}/{snapshot.maxHealth}";
        }

        if (energyText != null)
        {
            energyText.text = $"Nang luong: {snapshot.currentEnergy}/{snapshot.maxEnergy}";
        }

        if (coinText != null)
        {
            coinText.text = $"Coin: {snapshot.coins}";
        }

        if (pauseText != null)
        {
            pauseText.text = snapshot.isPaused ? "PAUSED" : string.Empty;
        }
    }

    private void ShowHint(string message)
    {
        if (hintText != null)
        {
            hintText.text = message;
        }
    }

    private void ShowDeathHint()
    {
        ShowHint("Nhan vat da bi ha guc. Bam phim 2 de hoi sinh nhanh trong demo.");
    }
}

public class Lesson01FloatingPanelAnimator : MonoBehaviour
{
    [SerializeField] private RectTransform targetPanel;
    [SerializeField] private Vector2 hiddenPosition = new Vector2(0f, -240f);
    [SerializeField] private Vector2 visiblePosition = new Vector2(0f, 0f);
    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private bool playOnStart = true;

    private bool isVisible;

    private void Start()
    {
        if (targetPanel == null)
        {
            return;
        }

        targetPanel.anchoredPosition = playOnStart ? visiblePosition : hiddenPosition;
        isVisible = playOnStart;
    }

    private void Update()
    {
        if (targetPanel == null)
        {
            return;
        }

        Vector2 target = isVisible ? visiblePosition : hiddenPosition;
        targetPanel.anchoredPosition = Vector2.Lerp(targetPanel.anchoredPosition, target, moveSpeed * Time.unscaledDeltaTime);
    }

    public void ShowPanel()
    {
        isVisible = true;
    }

    public void HidePanel()
    {
        isVisible = false;
    }

    public void TogglePanel()
    {
        isVisible = !isVisible;
    }
}

public class Lesson01CharacterAnimatorBridge : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Lesson01PlayerStats playerStats;
    [SerializeField] private float fakeMoveSpeed;
    [SerializeField] private float maxFakeMoveSpeed = 6f;

    private int speedHash;
    private int damagedHash;
    private int deadHash;
    private int reviveHash;

    private void Awake()
    {
        speedHash = Animator.StringToHash("Speed");
        damagedHash = Animator.StringToHash("Damaged");
        deadHash = Animator.StringToHash("Dead");
        reviveHash = Animator.StringToHash("Revive");
    }

    private void OnEnable()
    {
        if (playerStats != null)
        {
            playerStats.OnPlayerDied += PlayDeath;
        }
    }

    private void OnDisable()
    {
        if (playerStats != null)
        {
            playerStats.OnPlayerDied -= PlayDeath;
        }
    }

    private void Update()
    {
        if (animator == null)
        {
            return;
        }

        float input = Mathf.Abs(Input.GetAxisRaw("Horizontal")) + Mathf.Abs(Input.GetAxisRaw("Vertical"));
        fakeMoveSpeed = Mathf.Clamp(input * maxFakeMoveSpeed, 0f, maxFakeMoveSpeed);
        animator.SetFloat(speedHash, fakeMoveSpeed);
    }

    public void PlayDamaged()
    {
        if (animator != null)
        {
            animator.SetTrigger(damagedHash);
        }
    }

    public void PlayDeath()
    {
        if (animator != null)
        {
            animator.SetBool(deadHash, true);
        }
    }

    public void PlayRevive()
    {
        if (animator != null)
        {
            animator.SetBool(deadHash, false);
            animator.SetTrigger(reviveHash);
        }
    }
}

public class Lesson01DemoInput : MonoBehaviour
{
    [SerializeField] private Lesson01PlayerStats playerStats;
    [SerializeField] private Lesson01CharacterAnimatorBridge animatorBridge;
    [SerializeField] private Lesson01FloatingPanelAnimator pausePanelAnimator;

    private void Update()
    {
        if (playerStats == null)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerStats.TakeDamage(15);
            if (animatorBridge != null)
            {
                animatorBridge.PlayDamaged();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (playerStats.CurrentHealth <= 0)
            {
                playerStats.ReviveFull();
                if (animatorBridge != null)
                {
                    animatorBridge.PlayRevive();
                }
            }
            else
            {
                playerStats.Heal(10);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerStats.TrySpendEnergy(12);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            playerStats.AddCoins(5);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            playerStats.AddEnergy(10);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playerStats.TogglePause();

            if (pausePanelAnimator != null)
            {
                pausePanelAnimator.TogglePanel();
            }
        }
    }
}
