using System;

class PlayerHealth
{
    // Event phat ra khi mau thay doi.
    public event Action<int> OnHealthChanged;

    // Event phat ra khi nguoi choi chet.
    public event Action OnDied;

    // Mau hien tai.
    public int Health { get; private set; } = 100;

    // Ham nhan sat thuong.
    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }

        // Bao cho moi nguoi nghe biet mau da doi.
        OnHealthChanged?.Invoke(Health);

        // Neu chet thi phat su kien chet.
        if (Health == 0)
        {
            OnDied?.Invoke();
        }
    }
}

class HealthUI
{
    // Ham nay se duoc goi khi mau thay doi.
    public void UpdateBar(int currentHealth)
    {
        Console.WriteLine("UI cap nhat mau: " + currentHealth);
    }
}

class AchievementSystem
{
    // Ham nay duoc goi khi player chet.
    public void OnPlayerDied()
    {
        Console.WriteLine("Achievement check: Player da chet");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao cac he thong.
        PlayerHealth playerHealth = new PlayerHealth();
        HealthUI healthUI = new HealthUI();
        AchievementSystem achievementSystem = new AchievementSystem();

        // Dang ky nghe event.
        playerHealth.OnHealthChanged += healthUI.UpdateBar;
        playerHealth.OnDied += achievementSystem.OnPlayerDied;

        // Gay sat thuong de kich hoat event.
        playerHealth.TakeDamage(30);
        playerHealth.TakeDamage(70);
    }
}
