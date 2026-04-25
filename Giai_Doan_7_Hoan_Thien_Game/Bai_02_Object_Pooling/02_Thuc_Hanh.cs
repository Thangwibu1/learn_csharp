using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Lesson02PoolSettings
{
    public GameObject prefab;
    public int initialSize = 10;
    public bool canGrow = true;
    public Transform parent;
}

public interface ILesson02Poolable
{
    void OnSpawnedFromPool();
    void OnReturnedToPool();
}

public class Lesson02BulletPool : MonoBehaviour
{
    [SerializeField] private Lesson02PoolSettings settings = new Lesson02PoolSettings();

    private readonly Queue<GameObject> availableObjects = new Queue<GameObject>();
    private readonly List<GameObject> allObjects = new List<GameObject>();

    public int ActiveCount { get; private set; }
    public int TotalCount => allObjects.Count;

    private void Awake()
    {
        WarmPool();
    }

    public void WarmPool()
    {
        if (settings.prefab == null)
        {
            Debug.LogWarning("Pool chua duoc gan prefab.");
            return;
        }

        for (int i = allObjects.Count; i < settings.initialSize; i++)
        {
            CreateNewInstance();
        }
    }

    public GameObject Get(Vector3 position, Quaternion rotation)
    {
        GameObject instance = GetOrCreate();

        if (instance == null)
        {
            return null;
        }

        instance.transform.SetPositionAndRotation(position, rotation);
        instance.SetActive(true);
        ActiveCount++;

        ILesson02Poolable poolable = instance.GetComponent<ILesson02Poolable>();
        poolable?.OnSpawnedFromPool();

        return instance;
    }

    public T Get<T>(Vector3 position, Quaternion rotation) where T : Component
    {
        GameObject instance = Get(position, rotation);
        return instance == null ? null : instance.GetComponent<T>();
    }

    public void Return(GameObject instance)
    {
        if (instance == null)
        {
            return;
        }

        ILesson02Poolable poolable = instance.GetComponent<ILesson02Poolable>();
        poolable?.OnReturnedToPool();

        instance.SetActive(false);
        instance.transform.SetParent(settings.parent);
        availableObjects.Enqueue(instance);
        ActiveCount = Mathf.Max(0, ActiveCount - 1);
    }

    public void ReturnAllActive()
    {
        for (int i = 0; i < allObjects.Count; i++)
        {
            GameObject instance = allObjects[i];
            if (instance != null && instance.activeSelf)
            {
                Return(instance);
            }
        }
    }

    public string BuildDebugReport()
    {
        return $"Tong: {TotalCount} | Dang hoat dong: {ActiveCount} | San sang: {availableObjects.Count}";
    }

    private GameObject GetOrCreate()
    {
        while (availableObjects.Count > 0)
        {
            GameObject candidate = availableObjects.Dequeue();
            if (candidate != null)
            {
                return candidate;
            }
        }

        if (!settings.canGrow)
        {
            Debug.LogWarning("Pool da het object va khong cho phep mo rong.");
            return null;
        }

        return CreateNewInstance();
    }

    private GameObject CreateNewInstance()
    {
        GameObject instance = Instantiate(settings.prefab, settings.parent);
        instance.SetActive(false);

        Lesson02PooledIdentity identity = instance.GetComponent<Lesson02PooledIdentity>();
        if (identity == null)
        {
            identity = instance.AddComponent<Lesson02PooledIdentity>();
        }

        identity.Bind(this);
        allObjects.Add(instance);
        availableObjects.Enqueue(instance);
        return instance;
    }
}

public class Lesson02PooledIdentity : MonoBehaviour
{
    private Lesson02BulletPool owner;

    public void Bind(Lesson02BulletPool pool)
    {
        owner = pool;
    }

    public void ReturnToPool()
    {
        if (owner != null)
        {
            owner.Return(gameObject);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

public class Lesson02PooledBullet : MonoBehaviour, ILesson02Poolable
{
    [Header("Du lieu bay")]
    [SerializeField] private float speed = 18f;
    [SerializeField] private float lifeTime = 2.5f;
    [SerializeField] private int damage = 10;

    [Header("Reset trang thai")]
    [SerializeField] private TrailRenderer trail;
    [SerializeField] private Rigidbody cachedRigidbody;

    private float lifeTimer;
    private bool isFlying;
    private Vector3 direction;
    private Lesson02PooledIdentity identity;

    private void Awake()
    {
        identity = GetComponent<Lesson02PooledIdentity>();
        if (cachedRigidbody == null)
        {
            cachedRigidbody = GetComponent<Rigidbody>();
        }
    }

    private void Update()
    {
        if (!isFlying)
        {
            return;
        }

        lifeTimer += Time.deltaTime;

        if (cachedRigidbody == null)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        if (lifeTimer >= lifeTime)
        {
            ReturnSelf();
        }
    }

    private void FixedUpdate()
    {
        if (!isFlying || cachedRigidbody == null)
        {
            return;
        }

        cachedRigidbody.MovePosition(cachedRigidbody.position + direction * speed * Time.fixedDeltaTime);
    }

    public void Launch(Vector3 launchDirection)
    {
        direction = launchDirection.normalized;
        lifeTimer = 0f;
        isFlying = true;

        if (cachedRigidbody != null)
        {
            cachedRigidbody.velocity = Vector3.zero;
            cachedRigidbody.angularVelocity = Vector3.zero;
        }
    }

    public void OnSpawnedFromPool()
    {
        lifeTimer = 0f;
        isFlying = false;

        if (trail != null)
        {
            trail.Clear();
        }
    }

    public void OnReturnedToPool()
    {
        isFlying = false;
        direction = Vector3.zero;

        if (cachedRigidbody != null)
        {
            cachedRigidbody.velocity = Vector3.zero;
            cachedRigidbody.angularVelocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isFlying)
        {
            return;
        }

        Lesson02DamageableTarget target = other.GetComponent<Lesson02DamageableTarget>();
        if (target != null)
        {
            target.TakeDamage(damage);
        }

        ReturnSelf();
    }

    private void ReturnSelf()
    {
        if (identity != null)
        {
            identity.ReturnToPool();
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

public class Lesson02DamageableTarget : MonoBehaviour
{
    [SerializeField] private int maxHealth = 50;
    [SerializeField] private Renderer targetRenderer;
    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color hitColor = Color.red;
    [SerializeField] private float flashDuration = 0.1f;

    private int currentHealth;
    private float flashTimer;

    private void Awake()
    {
        currentHealth = maxHealth;
        ApplyColor(normalColor);
    }

    private void Update()
    {
        if (flashTimer <= 0f)
        {
            return;
        }

        flashTimer -= Time.deltaTime;
        if (flashTimer <= 0f)
        {
            ApplyColor(normalColor);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth = Mathf.Max(0, currentHealth - Mathf.Max(0, amount));
        flashTimer = flashDuration;
        ApplyColor(hitColor);

        if (currentHealth == 0)
        {
            Debug.Log($"{name} da bi pha huy trong demo pooling.");
            currentHealth = maxHealth;
        }
    }

    private void ApplyColor(Color color)
    {
        if (targetRenderer != null && targetRenderer.material != null)
        {
            targetRenderer.material.color = color;
        }
    }
}

public class Lesson02PoolGun : MonoBehaviour
{
    [SerializeField] private Lesson02BulletPool bulletPool;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireCooldown = 0.15f;
    [SerializeField] private KeyCode fireKey = KeyCode.Space;
    [SerializeField] private bool shootForwardFromTransform = true;

    private float cooldownTimer;

    private void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetKey(fireKey))
        {
            TryShoot();
        }

        if (Input.GetKeyDown(KeyCode.R) && bulletPool != null)
        {
            bulletPool.ReturnAllActive();
        }
    }

    public void TryShoot()
    {
        if (bulletPool == null || firePoint == null || cooldownTimer > 0f)
        {
            return;
        }

        Lesson02PooledBullet bullet = bulletPool.Get<Lesson02PooledBullet>(firePoint.position, firePoint.rotation);
        if (bullet == null)
        {
            return;
        }

        Vector3 direction = shootForwardFromTransform ? firePoint.forward : Vector3.forward;
        bullet.Launch(direction);
        cooldownTimer = fireCooldown;
    }
}

public class Lesson02PoolDebugPanel : MonoBehaviour
{
    [SerializeField] private Lesson02BulletPool bulletPool;
    [SerializeField] private string debugPrefix = "Pooling";
    [SerializeField] private float logInterval = 1f;

    private float timer;

    private void Update()
    {
        if (bulletPool == null)
        {
            return;
        }

        timer += Time.deltaTime;
        if (timer < logInterval)
        {
            return;
        }

        timer = 0f;
        Debug.Log($"{debugPrefix}: {bulletPool.BuildDebugReport()}");
    }
}
