using System;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsLesson2DDemo : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private PhysicsGroundProbe groundProbe;
    [SerializeField] private Transform respawnPoint;

    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private float airControlMultiplier = 0.6f;

    [Header("Debug")]
    [SerializeField] private bool logCollisions = true;
    [SerializeField] private bool clampHorizontalSpeed = true;
    [SerializeField] private float maxHorizontalSpeed = 8f;

    private float horizontalInput;
    private bool jumpQueued;

    private void Awake()
    {
        if (body == null)
        {
            body = GetComponent<Rigidbody2D>();
        }

        if (groundProbe == null)
        {
            groundProbe = GetComponentInChildren<PhysicsGroundProbe>();
        }
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpQueued = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }
    }

    private void FixedUpdate()
    {
        if (body == null)
        {
            return;
        }

        ApplyHorizontalMovement();
        ApplyJump();
        ClampSpeed();
    }

    private void ApplyHorizontalMovement()
    {
        float control = IsGrounded() ? 1f : airControlMultiplier;
        Vector2 velocity = body.velocity;
        velocity.x = horizontalInput * moveSpeed * control;
        body.velocity = velocity;
    }

    private void ApplyJump()
    {
        if (!jumpQueued)
        {
            return;
        }

        jumpQueued = false;

        if (!IsGrounded())
        {
            return;
        }

        body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        Debug.Log("[PhysicsLesson2DDemo] Jump applied.", this);
    }

    private void ClampSpeed()
    {
        if (!clampHorizontalSpeed)
        {
            return;
        }

        Vector2 velocity = body.velocity;
        velocity.x = Mathf.Clamp(velocity.x, -maxHorizontalSpeed, maxHorizontalSpeed);
        body.velocity = velocity;
    }

    private bool IsGrounded()
    {
        return groundProbe != null && groundProbe.IsGrounded;
    }

    private void Respawn()
    {
        if (body == null)
        {
            return;
        }

        Transform point = respawnPoint != null ? respawnPoint : transform;
        body.position = point.position;
        body.velocity = Vector2.zero;
        body.angularVelocity = 0f;
        Debug.Log("[PhysicsLesson2DDemo] Respawned.", this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!logCollisions)
        {
            return;
        }

        Debug.Log("[PhysicsLesson2DDemo] Collision with: " + collision.collider.name, this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            Respawn();
        }
    }
}

public class PhysicsGroundProbe : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask = ~0;
    [SerializeField] private float rayDistance = 0.2f;
    [SerializeField] private bool drawRay = true;

    public bool IsGrounded { get; private set; }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayDistance, groundMask);
        IsGrounded = hit.collider != null;

        if (drawRay)
        {
            Color color = IsGrounded ? Color.green : Color.red;
            Debug.DrawRay(transform.position, Vector3.down * rayDistance, color);
        }
    }
}

public class PhysicsPickupCoin : MonoBehaviour
{
    [SerializeField] private int points = 1;
    [SerializeField] private bool deactivateOnPickup = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        Debug.Log("[PhysicsPickupCoin] Player picked coin worth " + points, this);

        if (deactivateOnPickup)
        {
            gameObject.SetActive(false);
        }
    }
}

public class PhysicsLessonSpawner : MonoBehaviour
{
    [SerializeField] private Rigidbody2D prefab;
    [SerializeField] private float launchForce = 3f;
    [SerializeField] private KeyCode spawnKey = KeyCode.B;

    private readonly List<Rigidbody2D> spawnedBodies = new List<Rigidbody2D>();

    private void Update()
    {
        if (!Input.GetKeyDown(spawnKey) || prefab == null)
        {
            return;
        }

        Rigidbody2D instance = Instantiate(prefab, transform.position, Quaternion.identity);
        instance.AddForce(Vector2.up * launchForce, ForceMode2D.Impulse);
        spawnedBodies.Add(instance);
        Debug.Log("[PhysicsLessonSpawner] Spawned body count=" + spawnedBodies.Count, this);
    }
}

[Serializable]
public struct PhysicsCollisionNote
{
    public string layerName;
    public string note;
}

public class PhysicsLayerReminder : MonoBehaviour
{
    [SerializeField] private PhysicsCollisionNote[] notes = Array.Empty<PhysicsCollisionNote>();

    private void Start()
    {
        foreach (PhysicsCollisionNote note in notes)
        {
            Debug.Log("[PhysicsLayerReminder] layer=" + note.layerName + " note=" + note.note, this);
        }
    }
}

public class PhysicsBouncePad : MonoBehaviour
{
    [SerializeField] private float bounceForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D otherBody = collision.rigidbody;
        if (otherBody == null)
        {
            return;
        }

        Vector2 velocity = otherBody.velocity;
        velocity.y = 0f;
        otherBody.velocity = velocity;
        otherBody.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        Debug.Log("[PhysicsBouncePad] Bounce applied to " + collision.collider.name, this);
    }
}

public class PhysicsTriggerZone : MonoBehaviour
{
    [SerializeField] private string requiredTag = "Player";
    [SerializeField] private Color zoneColor = new Color(1f, 0.5f, 0f, 0.35f);
    [SerializeField] private Vector3 gizmoSize = new Vector3(2f, 2f, 1f);

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(requiredTag))
        {
            return;
        }

        Debug.Log("[PhysicsTriggerZone] Entered by " + other.name, this);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag(requiredTag))
        {
            return;
        }

        Debug.Log("[PhysicsTriggerZone] Exited by " + other.name, this);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = zoneColor;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(Vector3.zero, gizmoSize);
    }
}

public class PhysicsVelocityReporter : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private float reportInterval = 1f;

    private float nextReportTime;

    private void Awake()
    {
        if (body == null)
        {
            body = GetComponent<Rigidbody2D>();
        }
    }

    private void Update()
    {
        if (body == null || Time.time < nextReportTime)
        {
            return;
        }

        nextReportTime = Time.time + reportInterval;
        Debug.Log("[PhysicsVelocityReporter] velocity=" + body.velocity + " angular=" + body.angularVelocity, this);
    }
}
