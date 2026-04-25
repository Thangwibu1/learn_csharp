using System;
using UnityEngine;
using UnityEngine.UI;

public class Lesson05PlayerHealthPublisher : MonoBehaviour
{
    public event Action<int, int> OnHealthChanged;
    public event Action<int> OnDamaged;
    public event Action<int> OnHealed;
    public event Action OnPlayerDied;
    public event Action<bool> OnLowHealthStateChanged;

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int lowHealthThreshold = 30;

    private int currentHealth;
    private bool lowHealthState;

    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
        lowHealthState = currentHealth <= lowHealthThreshold;
    }

    private void Start()
    {
        BroadcastHealth();
        BroadcastLowHealthIfChanged(force: true);
    }

    public void TakeDamage(int amount)
    {
        if (amount <= 0 || currentHealth <= 0)
        {
            return;
        }

        int oldHealth = currentHealth;
        currentHealth = Mathf.Max(0, currentHealth - amount);

        if (oldHealth == currentHealth)
        {
            return;
        }

        OnDamaged?.Invoke(oldHealth - currentHealth);
        BroadcastHealth();
        BroadcastLowHealthIfChanged(force: false);

        if (currentHealth == 0)
        {
            OnPlayerDied?.Invoke();
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

        if (oldHealth == currentHealth)
        {
            return;
        }

        OnHealed?.Invoke(currentHealth - oldHealth);
        BroadcastHealth();
        BroadcastLowHealthIfChanged(force: false);
    }

    public void FullRestore()
    {
        currentHealth = maxHealth;
        BroadcastHealth();
        BroadcastLowHealthIfChanged(force: false);
    }

    private void BroadcastHealth()
    {
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }

    private void BroadcastLowHealthIfChanged(bool force)
    {
        bool newState = currentHealth <= lowHealthThreshold && currentHealth > 0;
        if (!force && newState == lowHealthState)
        {
            return;
        }

        lowHealthState = newState;
        OnLowHealthStateChanged?.Invoke(lowHealthState);
    }
}

public class Lesson05HealthBarListener : MonoBehaviour
{
    [SerializeField] private Lesson05PlayerHealthPublisher publisher;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Text healthText;
    [SerializeField] private Image fillImage;
    [SerializeField] private Color normalColor = new Color(0.2f, 0.8f, 0.3f);
    [SerializeField] private Color dangerColor = new Color(0.9f, 0.2f, 0.2f);

    private void OnEnable()
    {
        if (publisher != null)
        {
            publisher.OnHealthChanged += Refresh;
        }
    }

    private void OnDisable()
    {
        if (publisher != null)
        {
            publisher.OnHealthChanged -= Refresh;
        }
    }

    private void Start()
    {
        if (publisher != null)
        {
            Refresh(publisher.CurrentHealth, publisher.MaxHealth);
        }
    }

    private void Refresh(int currentHealth, int maxHealth)
    {
        float percent = maxHealth <= 0 ? 0f : (float)currentHealth / maxHealth;

        if (healthSlider != null)
        {
            healthSlider.value = percent;
        }

        if (healthText != null)
        {
            healthText.text = $"HP: {currentHealth}/{maxHealth}";
        }

        if (fillImage != null)
        {
            fillImage.color = Color.Lerp(dangerColor, normalColor, percent);
        }
    }
}

public class Lesson05LowHealthWarningListener : MonoBehaviour
{
    [SerializeField] private Lesson05PlayerHealthPublisher publisher;
    [SerializeField] private CanvasGroup warningGroup;
    [SerializeField] private float pulseSpeed = 4f;

    private bool activeWarning;

    private void OnEnable()
    {
        if (publisher != null)
        {
            publisher.OnLowHealthStateChanged += SetWarningState;
        }
    }

    private void OnDisable()
    {
        if (publisher != null)
        {
            publisher.OnLowHealthStateChanged -= SetWarningState;
        }
    }

    private void Update()
    {
        if (warningGroup == null)
        {
            return;
        }

        if (!activeWarning)
        {
            warningGroup.alpha = Mathf.MoveTowards(warningGroup.alpha, 0f, Time.deltaTime * 4f);
            return;
        }

        warningGroup.alpha = 0.35f + Mathf.PingPong(Time.time * pulseSpeed, 0.65f);
    }

    private void SetWarningState(bool isActive)
    {
        activeWarning = isActive;
        Debug.Log(isActive ? "Bat canh bao mau thap." : "Tat canh bao mau thap.");
    }
}

public class Lesson05AchievementListener : MonoBehaviour
{
    [SerializeField] private Lesson05PlayerHealthPublisher publisher;
    [SerializeField] private Text achievementText;

    private bool unlockedFirstDamage;
    private bool unlockedFirstHeal;
    private bool unlockedFirstDeath;

    private void OnEnable()
    {
        if (publisher == null)
        {
            return;
        }

        publisher.OnDamaged += HandleDamaged;
        publisher.OnHealed += HandleHealed;
        publisher.OnPlayerDied += HandleDeath;
    }

    private void OnDisable()
    {
        if (publisher == null)
        {
            return;
        }

        publisher.OnDamaged -= HandleDamaged;
        publisher.OnHealed -= HandleHealed;
        publisher.OnPlayerDied -= HandleDeath;
    }

    private void HandleDamaged(int amount)
    {
        if (unlockedFirstDamage)
        {
            return;
        }

        unlockedFirstDamage = true;
        ShowAchievement($"Achievement mo khoa: Lan dau mat mau ({amount}).");
    }

    private void HandleHealed(int amount)
    {
        if (unlockedFirstHeal)
        {
            return;
        }

        unlockedFirstHeal = true;
        ShowAchievement($"Achievement mo khoa: Lan dau hoi mau ({amount}).");
    }

    private void HandleDeath()
    {
        if (unlockedFirstDeath)
        {
            return;
        }

        unlockedFirstDeath = true;
        ShowAchievement("Achievement mo khoa: First Death.");
    }

    private void ShowAchievement(string message)
    {
        Debug.Log(message);
        if (achievementText != null)
        {
            achievementText.text = message;
        }
    }
}

public class Lesson05BattleLogListener : MonoBehaviour
{
    [SerializeField] private Lesson05PlayerHealthPublisher publisher;
    [SerializeField] private Text logText;
    [SerializeField] private int maxLines = 8;

    private readonly string[] lines = new string[8];
    private int lineCount;

    private void OnEnable()
    {
        if (publisher == null)
        {
            return;
        }

        publisher.OnDamaged += OnDamaged;
        publisher.OnHealed += OnHealed;
        publisher.OnPlayerDied += OnDeath;
        publisher.OnLowHealthStateChanged += OnLowHealthChanged;
    }

    private void OnDisable()
    {
        if (publisher == null)
        {
            return;
        }

        publisher.OnDamaged -= OnDamaged;
        publisher.OnHealed -= OnHealed;
        publisher.OnPlayerDied -= OnDeath;
        publisher.OnLowHealthStateChanged -= OnLowHealthChanged;
    }

    private void OnDamaged(int amount)
    {
        PushLine($"Nhan vat mat {amount} HP.");
    }

    private void OnHealed(int amount)
    {
        PushLine($"Nhan vat hoi {amount} HP.");
    }

    private void OnDeath()
    {
        PushLine("Nhan vat da guc nga.");
    }

    private void OnLowHealthChanged(bool state)
    {
        PushLine(state ? "Canh bao: HP dang thap." : "HP da tro lai nguong an toan.");
    }

    private void PushLine(string message)
    {
        if (maxLines <= 0)
        {
            maxLines = 1;
        }

        int length = Mathf.Min(maxLines, lines.Length);
        for (int i = length - 1; i > 0; i--)
        {
            lines[i] = lines[i - 1];
        }

        lines[0] = message;
        lineCount = Mathf.Min(lineCount + 1, length);
        RefreshLabel(length);
    }

    private void RefreshLabel(int length)
    {
        if (logText == null)
        {
            return;
        }

        string result = string.Empty;
        for (int i = 0; i < lineCount && i < length; i++)
        {
            result += lines[i] + "\n";
        }

        logText.text = result.TrimEnd();
    }
}

public class Lesson05AudioListener : MonoBehaviour
{
    [SerializeField] private Lesson05PlayerHealthPublisher publisher;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip damagedClip;
    [SerializeField] private AudioClip healedClip;
    [SerializeField] private AudioClip deathClip;

    private void OnEnable()
    {
        if (publisher == null)
        {
            return;
        }

        publisher.OnDamaged += PlayDamaged;
        publisher.OnHealed += PlayHealed;
        publisher.OnPlayerDied += PlayDeath;
    }

    private void OnDisable()
    {
        if (publisher == null)
        {
            return;
        }

        publisher.OnDamaged -= PlayDamaged;
        publisher.OnHealed -= PlayHealed;
        publisher.OnPlayerDied -= PlayDeath;
    }

    private void PlayDamaged(int amount)
    {
        PlayClip(damagedClip, $"Phat am thanh mat mau: {amount}");
    }

    private void PlayHealed(int amount)
    {
        PlayClip(healedClip, $"Phat am thanh hoi mau: {amount}");
    }

    private void PlayDeath()
    {
        PlayClip(deathClip, "Phat am thanh chet.");
    }

    private void PlayClip(AudioClip clip, string fallbackLog)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
            return;
        }

        Debug.Log(fallbackLog);
    }
}

public class Lesson05DamageTester : MonoBehaviour
{
    [SerializeField] private Lesson05PlayerHealthPublisher publisher;

    private void Update()
    {
        if (publisher == null)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            publisher.TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            publisher.TakeDamage(25);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            publisher.Heal(15);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            publisher.FullRestore();
        }
    }
}
