using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourLessonDemo : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private MonoBehaviourLessonLogger logger;
    [SerializeField] private Renderer targetRenderer;

    [Header("Config")]
    [SerializeField] private bool startCoroutineOnLaunch = true;
    [SerializeField] private float blinkInterval = 0.3f;
    [SerializeField] private float moveAmplitude = 0.5f;
    [SerializeField] private float moveFrequency = 1.5f;

    private Vector3 startPosition;
    private Coroutine blinkRoutine;
    private bool paused;

    private void Awake()
    {
        startPosition = transform.position;

        if (logger == null)
        {
            logger = GetComponent<MonoBehaviourLessonLogger>();
        }

        if (targetRenderer == null)
        {
            targetRenderer = GetComponent<Renderer>();
        }

        WriteLog("Awake");
    }

    private void OnEnable()
    {
        WriteLog("OnEnable");
        MonoBehaviourLessonEvents.PauseChanged += HandlePauseChanged;
    }

    private void Start()
    {
        WriteLog("Start");

        if (startCoroutineOnLaunch)
        {
            blinkRoutine = StartCoroutine(BlinkRoutine());
        }
    }

    private void Update()
    {
        WriteLogOncePerKey();

        if (paused)
        {
            return;
        }

        float offset = Mathf.Sin(Time.time * moveFrequency) * moveAmplitude;
        transform.position = startPosition + Vector3.up * offset;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            WriteLog("FixedUpdate observed input state.");
        }
    }

    private void LateUpdate()
    {
        if (paused)
        {
            return;
        }

        Debug.DrawLine(transform.position, transform.position + Vector3.up, Color.green);
    }

    private void OnDisable()
    {
        MonoBehaviourLessonEvents.PauseChanged -= HandlePauseChanged;
        WriteLog("OnDisable");
    }

    private void OnDestroy()
    {
        WriteLog("OnDestroy");
    }

    private IEnumerator BlinkRoutine()
    {
        WriteLog("Coroutine started");

        while (true)
        {
            if (targetRenderer != null)
            {
                targetRenderer.enabled = !targetRenderer.enabled;
            }

            yield return new WaitForSeconds(blinkInterval);
        }
    }

    private void WriteLog(string message)
    {
        if (logger != null)
        {
            logger.Record(message);
        }
        else
        {
            Debug.Log("[MonoBehaviourLessonDemo] " + message, this);
        }
    }

    private void WriteLogOncePerKey()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            WriteLog("Alpha1 pressed during Update");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MonoBehaviourLessonEvents.RaisePauseChanged(!paused);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (blinkRoutine == null)
            {
                blinkRoutine = StartCoroutine(BlinkRoutine());
                WriteLog("Blink coroutine restarted");
            }
            else
            {
                StopCoroutine(blinkRoutine);
                blinkRoutine = null;
                WriteLog("Blink coroutine stopped");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            enabled = false;
        }
    }

    private void HandlePauseChanged(bool isPaused)
    {
        paused = isPaused;
        WriteLog("Pause changed => " + paused);
    }
}

public class MonoBehaviourLessonLogger : MonoBehaviour
{
    [SerializeField] private bool writeToConsole = true;
    [SerializeField] private int maxEntries = 25;

    private readonly Queue<string> entries = new Queue<string>();

    public void Record(string message)
    {
        string finalMessage = "[MonoBehaviourLessonLogger] " + Time.frameCount + " | " + message;
        entries.Enqueue(finalMessage);

        while (entries.Count > maxEntries)
        {
            entries.Dequeue();
        }

        if (writeToConsole)
        {
            Debug.Log(finalMessage, this);
        }
    }

    public string GetSummary()
    {
        return string.Join("\n", entries.ToArray());
    }
}

public class MonoBehaviourLessonFollower : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -5f);
    [SerializeField] private float followSpeed = 5f;

    private void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        Vector3 desired = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desired, followSpeed * Time.deltaTime);
    }
}

public class MonoBehaviourLessonPhysicsProbe : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private float impulseForce = 4f;

    private void Awake()
    {
        if (body == null)
        {
            body = GetComponent<Rigidbody2D>();
        }
    }

    private void FixedUpdate()
    {
        if (body == null)
        {
            return;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            body.AddForce(Vector2.up * impulseForce);
        }
    }
}

public class MonoBehaviourLessonToggleTarget : MonoBehaviour
{
    [SerializeField] private KeyCode toggleKey = KeyCode.Y;

    private void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            gameObject.SetActive(false);
        }
    }
}

public static class MonoBehaviourLessonEvents
{
    public static event Action<bool> PauseChanged;

    public static void RaisePauseChanged(bool paused)
    {
        if (PauseChanged != null)
        {
            PauseChanged(paused);
        }
    }
}

public class MonoBehaviourLessonTimer : MonoBehaviour
{
    [SerializeField] private float duration = 5f;
    [SerializeField] private bool restartWhenFinished = true;

    private float remaining;

    private void OnEnable()
    {
        remaining = duration;
    }

    private void Update()
    {
        if (remaining <= 0f)
        {
            return;
        }

        remaining -= Time.deltaTime;

        if (remaining <= 0f)
        {
            Debug.Log("[MonoBehaviourLessonTimer] Timer finished.", this);

            if (restartWhenFinished)
            {
                remaining = duration;
            }
        }
    }
}

public class MonoBehaviourLessonStatePrinter : MonoBehaviour
{
    [SerializeField] private KeyCode printKey = KeyCode.L;
    [SerializeField] private MonoBehaviourLessonLogger logger;

    private void Start()
    {
        if (logger == null)
        {
            logger = GetComponent<MonoBehaviourLessonLogger>();
        }
    }

    private void Update()
    {
        if (!Input.GetKeyDown(printKey))
        {
            return;
        }

        string summary = logger != null ? logger.GetSummary() : "Logger missing";
        Debug.Log("[MonoBehaviourLessonStatePrinter]\n" + summary, this);
    }
}

public class MonoBehaviourLessonEnableDisableDemo : MonoBehaviour
{
    [SerializeField] private Behaviour targetBehaviour;
    [SerializeField] private KeyCode disableKey = KeyCode.U;
    [SerializeField] private KeyCode enableKey = KeyCode.I;

    private void Update()
    {
        if (targetBehaviour == null)
        {
            return;
        }

        if (Input.GetKeyDown(disableKey))
        {
            targetBehaviour.enabled = false;
            Debug.Log("[MonoBehaviourLessonEnableDisableDemo] Target disabled.", this);
        }

        if (Input.GetKeyDown(enableKey))
        {
            targetBehaviour.enabled = true;
            Debug.Log("[MonoBehaviourLessonEnableDisableDemo] Target enabled.", this);
        }
    }
}
