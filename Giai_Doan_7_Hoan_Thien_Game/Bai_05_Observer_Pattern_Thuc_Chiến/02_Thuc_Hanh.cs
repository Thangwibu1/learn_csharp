using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthEvents : MonoBehaviour
{
    public event Action<int, int> OnHealthChanged;
    public event Action OnPlayerDied;

    public int maxHealth = 100;
    private int currentHealth;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        OnHealthChanged?.Invoke(currentHealth, maxHealth);

        if (currentHealth == 0)
        {
            OnPlayerDied?.Invoke();
        }
    }
}

public class PlayerHealthUI : MonoBehaviour
{
    public PlayerHealthEvents playerHealth;
    public Slider healthSlider;

    void OnEnable()
    {
        playerHealth.OnHealthChanged += UpdateHealthBar;
    }

    void OnDisable()
    {
        playerHealth.OnHealthChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar(int currentHealth, int maxHealth)
    {
        healthSlider.value = (float)currentHealth / maxHealth;
    }
}

public class AchievementOnDeath : MonoBehaviour
{
    public PlayerHealthEvents playerHealth;

    void OnEnable()
    {
        playerHealth.OnPlayerDied += UnlockAchievement;
    }

    void OnDisable()
    {
        playerHealth.OnPlayerDied -= UnlockAchievement;
    }

    private void UnlockAchievement()
    {
        Debug.Log("Unlocked achievement: First Death");
    }
}
