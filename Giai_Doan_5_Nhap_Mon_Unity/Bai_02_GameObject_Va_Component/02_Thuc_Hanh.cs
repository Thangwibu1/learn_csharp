using System;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectComponentLessonDemo : MonoBehaviour
{
    [Header("Required References")]
    [SerializeField] private SpriteRenderer bodyRenderer;
    [SerializeField] private LessonHealth lessonHealth;
    [SerializeField] private LessonRotator lessonRotator;
    [SerializeField] private LessonComponentReporter reporter;

    [Header("Config")]
    [SerializeField] private Color idleColor = Color.white;
    [SerializeField] private Color selectedColor = Color.cyan;
    [SerializeField] private float pulseSpeed = 2f;
    [SerializeField] private bool gatherComponentsOnStart = true;
    [SerializeField] private bool showComponentList = true;

    private readonly List<Component> cachedComponents = new List<Component>();
    private bool selected;
    private float pulseTime;

    private void Awake()
    {
        if (bodyRenderer == null)
        {
            bodyRenderer = GetComponent<SpriteRenderer>();
        }

        if (lessonHealth == null)
        {
            lessonHealth = GetComponent<LessonHealth>();
        }

        if (lessonRotator == null)
        {
            lessonRotator = GetComponent<LessonRotator>();
        }

        if (reporter == null)
        {
            reporter = GetComponent<LessonComponentReporter>();
        }

        if (gatherComponentsOnStart)
        {
            RefreshComponentCache();
        }
    }

    private void Start()
    {
        ApplyVisualState();

        if (showComponentList)
        {
            PrintComponentSummary();
        }
    }

    private void Update()
    {
        HandleInput();
        AnimatePulse();
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            selected = !selected;
            ApplyVisualState();
        }

        if (Input.GetKeyDown(KeyCode.H) && lessonHealth != null)
        {
            lessonHealth.ApplyDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.J) && lessonHealth != null)
        {
            lessonHealth.Heal(5);
        }

        if (Input.GetKeyDown(KeyCode.R) && lessonRotator != null)
        {
            lessonRotator.enabled = !lessonRotator.enabled;
            Debug.Log("[GameObjectComponentLessonDemo] Rotator enabled: " + lessonRotator.enabled, this);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            RefreshComponentCache();
            PrintComponentSummary();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            PrintParentChildInfo();
        }
    }

    private void AnimatePulse()
    {
        if (!selected || bodyRenderer == null)
        {
            return;
        }

        pulseTime += Time.deltaTime * pulseSpeed;
        float factor = (Mathf.Sin(pulseTime) + 1f) * 0.5f;
        bodyRenderer.color = Color.Lerp(idleColor, selectedColor, factor);
    }

    private void ApplyVisualState()
    {
        if (bodyRenderer == null)
        {
            return;
        }

        bodyRenderer.color = selected ? selectedColor : idleColor;
    }

    private void RefreshComponentCache()
    {
        cachedComponents.Clear();
        cachedComponents.AddRange(GetComponents<Component>());

        if (reporter != null)
        {
            reporter.ReceiveSnapshot(gameObject.name, cachedComponents);
        }
    }

    private void PrintComponentSummary()
    {
        List<string> names = new List<string>();
        foreach (Component component in cachedComponents)
        {
            if (component != null)
            {
                names.Add(component.GetType().Name);
            }
        }

        Debug.Log("[GameObjectComponentLessonDemo] Components: " + string.Join(", ", names), this);
    }

    private void PrintParentChildInfo()
    {
        string parentName = transform.parent != null ? transform.parent.name : "None";
        Debug.Log(
            string.Format(
                "[GameObjectComponentLessonDemo] name={0}, parent={1}, childCount={2}, activeSelf={3}, activeInHierarchy={4}",
                gameObject.name,
                parentName,
                transform.childCount,
                gameObject.activeSelf,
                gameObject.activeInHierarchy),
            this);
    }
}

public class LessonHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth = 100;
    [SerializeField] private bool destroyOnZero;

    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;

    private void Awake()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void ApplyDamage(int value)
    {
        currentHealth = Mathf.Max(0, currentHealth - Mathf.Abs(value));
        Debug.Log("[LessonHealth] Damage applied. Current: " + currentHealth, this);

        if (currentHealth == 0 && destroyOnZero)
        {
            gameObject.SetActive(false);
        }
    }

    public void Heal(int value)
    {
        currentHealth = Mathf.Min(maxHealth, currentHealth + Mathf.Abs(value));
        Debug.Log("[LessonHealth] Heal applied. Current: " + currentHealth, this);
    }
}

public class LessonRotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAxis = new Vector3(0f, 0f, 1f);
    [SerializeField] private float rotationSpeed = 45f;
    [SerializeField] private Space rotationSpace = Space.Self;

    private void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime, rotationSpace);
    }
}

public class LessonComponentReporter : MonoBehaviour
{
    [SerializeField] private bool logOnReceive = true;
    [SerializeField] private Color gizmoColor = Color.magenta;

    private string ownerName = string.Empty;
    private readonly List<string> componentNames = new List<string>();

    public void ReceiveSnapshot(string sourceName, List<Component> components)
    {
        ownerName = sourceName;
        componentNames.Clear();

        foreach (Component component in components)
        {
            if (component != null)
            {
                componentNames.Add(component.GetType().Name);
            }
        }

        if (logOnReceive)
        {
            Debug.Log("[LessonComponentReporter] " + ownerName + " => " + string.Join(", ", componentNames), this);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, 0.35f);
    }
}

public class LessonChildActivator : MonoBehaviour
{
    [SerializeField] private KeyCode toggleKey = KeyCode.T;
    [SerializeField] private bool includeInactiveChildren = true;

    private Transform[] cachedChildren = Array.Empty<Transform>();

    private void Start()
    {
        cachedChildren = GetComponentsInChildren<Transform>(includeInactiveChildren);
    }

    private void Update()
    {
        if (!Input.GetKeyDown(toggleKey))
        {
            return;
        }

        for (int index = 0; index < cachedChildren.Length; index++)
        {
            Transform child = cachedChildren[index];
            if (child == null || child == transform)
            {
                continue;
            }

            child.gameObject.SetActive(!child.gameObject.activeSelf);
        }

        Debug.Log("[LessonChildActivator] Toggled child active state.", this);
    }
}

[Serializable]
public struct LessonComponentDescriptor
{
    public string label;
    public bool required;
    public string note;
}

public class LessonComponentChecklist : MonoBehaviour
{
    [SerializeField] private LessonComponentDescriptor[] descriptors = Array.Empty<LessonComponentDescriptor>();

    private void Start()
    {
        foreach (LessonComponentDescriptor descriptor in descriptors)
        {
            Component component = GetComponent(descriptor.label);
            bool exists = component != null;

            Debug.Log(
                string.Format(
                    "[LessonComponentChecklist] {0} required={1} exists={2} note={3}",
                    descriptor.label,
                    descriptor.required,
                    exists,
                    descriptor.note),
                this);
        }
    }
}
