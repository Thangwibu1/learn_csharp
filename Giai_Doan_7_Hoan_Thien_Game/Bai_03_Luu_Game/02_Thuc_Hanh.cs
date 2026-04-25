using System;
using UnityEngine;

[Serializable]
public class SaveData
{
    // Vang hien tai cua nguoi choi.
    public int Gold;

    // Level hien tai.
    public int Level;
}

public class SaveSystem : MonoBehaviour
{
    // Du lieu save mau.
    public SaveData currentData = new SaveData();

    public void Save()
    {
        // Chuyen object thanh chuoi JSON.
        string json = JsonUtility.ToJson(currentData);

        // Luu vao PlayerPrefs de demo don gian.
        PlayerPrefs.SetString("SAVE_DATA", json);
        PlayerPrefs.Save();
    }

    public void Load()
    {
        // Neu ton tai du lieu save thi tai len.
        if (PlayerPrefs.HasKey("SAVE_DATA"))
        {
            string json = PlayerPrefs.GetString("SAVE_DATA");
            currentData = JsonUtility.FromJson<SaveData>(json);
        }
    }
}
