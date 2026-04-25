using System;
using System.Collections.Generic;
using UnityEngine;

public class TransformLessonDemo : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float rotateSpeed = 90f;
    [SerializeField] private float scaleSpeed = 1f;
    [SerializeField] private bool useLocalSpace = false;

    [Header("References")]
    [SerializeField] private Transform targetTransform;
    [SerializeField] private TransformWaypoint[] waypoints = Array.Empty<TransformWaypoint>();
    [SerializeField] private TransformPathPreview pathPreview;

    [Header("Flags")]
    [SerializeField] private bool loopWaypoints = true;
    [SerializeField] private bool drawDebugAxes = true;
    [SerializeField] private bool autoTravel = false;

    private int currentWaypointIndex;
    private Vector3 initialScale;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private void Awake()
    {
        if (targetTransform == null)
        {
            targetTransform = transform;
        }

        initialPosition = targetTransform.position;
        initialRotation = targetTransform.rotation;
        initialScale = targetTransform.localScale;
    }

    private void Start()
    {
        if (pathPreview != null)
        {
            pathPreview.SetWaypoints(waypoints);
        }
    }

    private void Update()
    {
        HandleManualMovement();
        HandleRotation();
        HandleScale();
        HandleUtilityKeys();

        if (autoTravel)
        {
            TravelAlongWaypoints();
        }
    }

    private void LateUpdate()
    {
        if (!drawDebugAxes || targetTransform == null)
        {
            return;
        }

        Debug.DrawRay(targetTransform.position, targetTransform.right, Color.red);
        Debug.DrawRay(targetTransform.position, targetTransform.up, Color.green);
        Debug.DrawRay(targetTransform.position, targetTransform.forward, Color.blue);
    }

    private void HandleManualMovement()
    {
        if (targetTransform == null)
        {
            return;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(horizontal, vertical, 0f) * moveSpeed * Time.deltaTime;

        if (useLocalSpace)
        {
            targetTransform.Translate(move, Space.Self);
        }
        else
        {
            targetTransform.Translate(move, Space.World);
        }
    }

    private void HandleRotation()
    {
        if (targetTransform == null)
        {
            return;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            targetTransform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.E))
        {
            targetTransform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime, Space.Self);
        }
    }

    private void HandleScale()
    {
        if (targetTransform == null)
        {
            return;
        }

        float scaleDelta = 0f;

        if (Input.GetKey(KeyCode.Z))
        {
            scaleDelta -= scaleSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.X))
        {
            scaleDelta += scaleSpeed * Time.deltaTime;
        }

        if (Mathf.Approximately(scaleDelta, 0f))
        {
            return;
        }

        Vector3 nextScale = targetTransform.localScale + Vector3.one * scaleDelta;
        nextScale.x = Mathf.Max(0.1f, nextScale.x);
        nextScale.y = Mathf.Max(0.1f, nextScale.y);
        nextScale.z = Mathf.Max(0.1f, nextScale.z);
        targetTransform.localScale = nextScale;
    }

    private void HandleUtilityKeys()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PrintWorldAndLocalInfo();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SnapToNextWaypoint();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ResetTransformState();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            useLocalSpace = !useLocalSpace;
            Debug.Log("[TransformLessonDemo] useLocalSpace=" + useLocalSpace, this);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            autoTravel = !autoTravel;
            Debug.Log("[TransformLessonDemo] autoTravel=" + autoTravel, this);
        }
    }

    private void PrintWorldAndLocalInfo()
    {
        if (targetTransform == null)
        {
            return;
        }

        Debug.Log(
            string.Format(
                "[TransformLessonDemo] world={0}, local={1}, euler={2}, scale={3}",
                targetTransform.position,
                targetTransform.localPosition,
                targetTransform.eulerAngles,
                targetTransform.localScale),
            targetTransform);
    }

    private void SnapToNextWaypoint()
    {
        if (waypoints.Length == 0 || targetTransform == null)
        {
            Debug.LogWarning("[TransformLessonDemo] No waypoint available.", this);
            return;
        }

        if (currentWaypointIndex >= waypoints.Length)
        {
            currentWaypointIndex = 0;
        }

        TransformWaypoint waypoint = waypoints[currentWaypointIndex];
        if (waypoint != null)
        {
            targetTransform.position = waypoint.transform.position;
            targetTransform.rotation = waypoint.transform.rotation;
            Debug.Log("[TransformLessonDemo] Snapped to waypoint: " + waypoint.name, waypoint);
        }

        currentWaypointIndex++;
    }

    private void TravelAlongWaypoints()
    {
        if (waypoints.Length == 0 || targetTransform == null)
        {
            return;
        }

        if (currentWaypointIndex >= waypoints.Length)
        {
            if (!loopWaypoints)
            {
                autoTravel = false;
                return;
            }

            currentWaypointIndex = 0;
        }

        TransformWaypoint waypoint = waypoints[currentWaypointIndex];
        if (waypoint == null)
        {
            currentWaypointIndex++;
            return;
        }

        targetTransform.position = Vector3.MoveTowards(
            targetTransform.position,
            waypoint.transform.position,
            waypoint.MoveSpeed * Time.deltaTime);

        targetTransform.rotation = Quaternion.RotateTowards(
            targetTransform.rotation,
            waypoint.transform.rotation,
            rotateSpeed * Time.deltaTime);

        if (Vector3.Distance(targetTransform.position, waypoint.transform.position) < 0.05f)
        {
            currentWaypointIndex++;
        }
    }

    private void ResetTransformState()
    {
        if (targetTransform == null)
        {
            return;
        }

        targetTransform.position = initialPosition;
        targetTransform.rotation = initialRotation;
        targetTransform.localScale = initialScale;
        currentWaypointIndex = 0;
        Debug.Log("[TransformLessonDemo] Transform reset.", targetTransform);
    }
}

public class TransformWaypoint : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private Color gizmoColor = Color.yellow;
    [SerializeField] private float gizmoRadius = 0.25f;

    public float MoveSpeed => moveSpeed;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoRadius);
        Gizmos.DrawRay(transform.position, transform.right * 0.6f);
    }
}

public class TransformPathPreview : MonoBehaviour
{
    [SerializeField] private Color lineColor = Color.cyan;
    [SerializeField] private bool closeLoop;

    private readonly List<TransformWaypoint> cachedWaypoints = new List<TransformWaypoint>();

    public void SetWaypoints(TransformWaypoint[] waypoints)
    {
        cachedWaypoints.Clear();
        if (waypoints == null)
        {
            return;
        }

        foreach (TransformWaypoint waypoint in waypoints)
        {
            if (waypoint != null)
            {
                cachedWaypoints.Add(waypoint);
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (cachedWaypoints.Count < 2)
        {
            return;
        }

        Gizmos.color = lineColor;

        for (int index = 0; index < cachedWaypoints.Count - 1; index++)
        {
            Gizmos.DrawLine(cachedWaypoints[index].transform.position, cachedWaypoints[index + 1].transform.position);
        }

        if (closeLoop)
        {
            Gizmos.DrawLine(cachedWaypoints[cachedWaypoints.Count - 1].transform.position, cachedWaypoints[0].transform.position);
        }
    }
}

public class TransformPulseScale : MonoBehaviour
{
    [SerializeField] private Vector3 minScale = Vector3.one * 0.8f;
    [SerializeField] private Vector3 maxScale = Vector3.one * 1.2f;
    [SerializeField] private float pulseDuration = 1f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        float normalized = Mathf.PingPong(timer / pulseDuration, 1f);
        transform.localScale = Vector3.Lerp(minScale, maxScale, normalized);
    }
}
