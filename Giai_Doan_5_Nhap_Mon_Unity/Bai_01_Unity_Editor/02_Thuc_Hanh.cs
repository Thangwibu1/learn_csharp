using System;
using System.Collections.Generic;
using UnityEngine;

public class UnityEditorLessonDemo : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] private Camera lessonCamera;
    [SerializeField] private Transform playerPreview;
    [SerializeField] private Transform[] focusTargets = Array.Empty<Transform>();
    [SerializeField] private UnityEditorLessonReporter reporter;

    [Header("Movement Preview")]
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float rotateSpeed = 60f;
    [SerializeField] private float bobHeight = 0.25f;
    [SerializeField] private float bobFrequency = 2f;

    [Header("Lesson Options")]
    [SerializeField] private bool logLifecycle = true;
    [SerializeField] private bool autoCollectChildren = true;
    [SerializeField] private bool highlightCameraForward = true;

    private readonly List<Transform> cachedTargets = new List<Transform>();
    private Vector3 previewStartPosition;
    private int currentTargetIndex;
    private float nextStatusTime;
    private bool lessonStarted;

    private void Awake()
    {
        previewStartPosition = playerPreview != null ? playerPreview.position : transform.position;

        if (autoCollectChildren)
        {
            CacheChildTargets();
        }

        if (reporter == null)
        {
            reporter = GetComponent<UnityEditorLessonReporter>();
        }

        if (logLifecycle)
        {
            Debug.Log("[UnityEditorLessonDemo] Awake called.");
        }
    }

    private void OnEnable()
    {
        if (logLifecycle)
        {
            Debug.Log("[UnityEditorLessonDemo] OnEnable called.");
        }
    }

    private void Start()
    {
        lessonStarted = true;
        nextStatusTime = Time.time + 1f;

        if (lessonCamera == null)
        {
            lessonCamera = Camera.main;
        }

        ReportCurrentSetup();

        if (logLifecycle)
        {
            Debug.Log("[UnityEditorLessonDemo] Start called.");
        }
    }

    private void Update()
    {
        HandleKeyboardShortcuts();
        AnimatePreviewObject();
        ReportStatusPeriodically();
    }

    private void LateUpdate()
    {
        if (!highlightCameraForward || lessonCamera == null)
        {
            return;
        }

        Debug.DrawRay(lessonCamera.transform.position, lessonCamera.transform.forward * 4f, Color.cyan);
    }

    private void OnDisable()
    {
        if (logLifecycle)
        {
            Debug.Log("[UnityEditorLessonDemo] OnDisable called.");
        }
    }

    private void OnValidate()
    {
        moveSpeed = Mathf.Max(0f, moveSpeed);
        rotateSpeed = Mathf.Max(0f, rotateSpeed);
        bobHeight = Mathf.Max(0f, bobHeight);
        bobFrequency = Mathf.Max(0.1f, bobFrequency);
    }

    private void CacheChildTargets()
    {
        cachedTargets.Clear();

        foreach (Transform child in transform)
        {
            cachedTargets.Add(child);
        }

        if (focusTargets.Length > 0)
        {
            foreach (Transform target in focusTargets)
            {
                if (target != null && !cachedTargets.Contains(target))
                {
                    cachedTargets.Add(target);
                }
            }
        }
    }

    private void HandleKeyboardShortcuts()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ReportCurrentSetup();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FocusNextTarget();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ResetPreview();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            TogglePreviewObject();
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            PrintHierarchyPath();
        }
    }

    private void AnimatePreviewObject()
    {
        if (playerPreview == null || !lessonStarted)
        {
            return;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
        playerPreview.position += move;

        if (move.sqrMagnitude > 0f)
        {
            playerPreview.rotation = Quaternion.RotateTowards(
                playerPreview.rotation,
                Quaternion.LookRotation(move.normalized, Vector3.up),
                rotateSpeed * Time.deltaTime);
        }

        Vector3 bobbed = playerPreview.position;
        bobbed.y = previewStartPosition.y + Mathf.Sin(Time.time * bobFrequency) * bobHeight;
        playerPreview.position = bobbed;
    }

    private void ReportStatusPeriodically()
    {
        if (Time.time < nextStatusTime)
        {
            return;
        }

        nextStatusTime = Time.time + 2f;

        if (reporter != null)
        {
            reporter.LogStatus(BuildStatusSnapshot());
        }
    }

    private UnityEditorLessonSnapshot BuildStatusSnapshot()
    {
        UnityEditorLessonSnapshot snapshot = new UnityEditorLessonSnapshot();
        snapshot.objectName = gameObject.name;
        snapshot.scenePath = gameObject.scene.path;
        snapshot.childCount = transform.childCount;
        snapshot.componentCount = GetComponents<Component>().Length;
        snapshot.isActive = gameObject.activeInHierarchy;
        snapshot.cameraName = lessonCamera != null ? lessonCamera.name : "None";
        snapshot.previewName = playerPreview != null ? playerPreview.name : "None";
        snapshot.currentTargetName = GetCurrentTargetName();
        return snapshot;
    }

    private void ReportCurrentSetup()
    {
        UnityEditorLessonSnapshot snapshot = BuildStatusSnapshot();
        string message = string.Format(
            "[UnityEditorLessonDemo] Scene={0}, Object={1}, Children={2}, Components={3}, Camera={4}, Preview={5}, Focus={6}",
            snapshot.scenePath,
            snapshot.objectName,
            snapshot.childCount,
            snapshot.componentCount,
            snapshot.cameraName,
            snapshot.previewName,
            snapshot.currentTargetName);

        Debug.Log(message, this);

        if (reporter != null)
        {
            reporter.LogStatus(snapshot);
        }
    }

    private void FocusNextTarget()
    {
        if (cachedTargets.Count == 0)
        {
            Debug.LogWarning("[UnityEditorLessonDemo] No focus targets found.", this);
            return;
        }

        currentTargetIndex++;
        if (currentTargetIndex >= cachedTargets.Count)
        {
            currentTargetIndex = 0;
        }

        Transform target = cachedTargets[currentTargetIndex];
        if (target == null)
        {
            Debug.LogWarning("[UnityEditorLessonDemo] Current target is missing.", this);
            return;
        }

        Debug.Log("[UnityEditorLessonDemo] Focus target changed to: " + target.name, target);
    }

    private void ResetPreview()
    {
        if (playerPreview == null)
        {
            return;
        }

        playerPreview.position = previewStartPosition;
        playerPreview.rotation = Quaternion.identity;
        playerPreview.localScale = Vector3.one;
        Debug.Log("[UnityEditorLessonDemo] Preview object reset.", playerPreview);
    }

    private void TogglePreviewObject()
    {
        if (playerPreview == null)
        {
            return;
        }

        playerPreview.gameObject.SetActive(!playerPreview.gameObject.activeSelf);
        Debug.Log("[UnityEditorLessonDemo] Preview active: " + playerPreview.gameObject.activeSelf, playerPreview);
    }

    private void PrintHierarchyPath()
    {
        Debug.Log("[UnityEditorLessonDemo] Hierarchy path: " + UnityEditorLessonUtility.GetHierarchyPath(transform), this);
    }

    private string GetCurrentTargetName()
    {
        if (cachedTargets.Count == 0)
        {
            return "None";
        }

        Transform target = cachedTargets[Mathf.Clamp(currentTargetIndex, 0, cachedTargets.Count - 1)];
        return target != null ? target.name : "Missing";
    }
}

[Serializable]
public class UnityEditorLessonSnapshot
{
    public string objectName = string.Empty;
    public string scenePath = string.Empty;
    public int childCount;
    public int componentCount;
    public bool isActive;
    public string cameraName = string.Empty;
    public string previewName = string.Empty;
    public string currentTargetName = string.Empty;
}

public class UnityEditorLessonReporter : MonoBehaviour
{
    [SerializeField] private bool writeToConsole = true;
    [SerializeField] private bool drawSceneLabel = true;
    [SerializeField] private Color gizmoColor = Color.yellow;

    private readonly Queue<UnityEditorLessonSnapshot> recentSnapshots = new Queue<UnityEditorLessonSnapshot>();

    public void LogStatus(UnityEditorLessonSnapshot snapshot)
    {
        if (snapshot == null)
        {
            return;
        }

        recentSnapshots.Enqueue(snapshot);

        while (recentSnapshots.Count > 5)
        {
            recentSnapshots.Dequeue();
        }

        if (writeToConsole)
        {
            Debug.Log(
                string.Format(
                    "[UnityEditorLessonReporter] {0} | active={1} | components={2} | focus={3}",
                    snapshot.objectName,
                    snapshot.isActive,
                    snapshot.componentCount,
                    snapshot.currentTargetName),
                this);
        }
    }

    private void OnDrawGizmos()
    {
        if (!drawSceneLabel)
        {
            return;
        }

        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
        Gizmos.DrawLine(transform.position, transform.position + transform.up * 1.5f);
    }

    public string GetRecentSummary()
    {
        List<string> names = new List<string>();
        foreach (UnityEditorLessonSnapshot snapshot in recentSnapshots)
        {
            names.Add(snapshot.objectName + ":" + snapshot.currentTargetName);
        }

        return string.Join(", ", names);
    }
}

public class UnityEditorLessonTarget : MonoBehaviour
{
    [SerializeField] private string note = "Use this object to practice selecting in Hierarchy and Inspector.";
    [SerializeField] private Color wireColor = Color.green;
    [SerializeField] private Vector3 wireSize = new Vector3(1f, 1f, 1f);

    private void Start()
    {
        Debug.Log("[UnityEditorLessonTarget] Ready: " + note, this);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = wireColor;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, wireSize);
    }
}

public static class UnityEditorLessonUtility
{
    public static string GetHierarchyPath(Transform current)
    {
        if (current == null)
        {
            return "None";
        }

        List<string> parts = new List<string>();
        Transform walker = current;

        while (walker != null)
        {
            parts.Add(walker.name);
            walker = walker.parent;
        }

        parts.Reverse();
        return string.Join("/", parts);
    }
}
