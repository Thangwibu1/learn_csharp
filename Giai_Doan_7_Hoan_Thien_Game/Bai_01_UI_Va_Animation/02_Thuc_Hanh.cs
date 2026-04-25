using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    // Thanh mau UI.
    public Slider healthSlider;

    // Ham cap nhat UI khi co du lieu moi.
    public void SetHealth(int currentHealth, int maxHealth)
    {
        healthSlider.value = (float)currentHealth / maxHealth;
    }
}
