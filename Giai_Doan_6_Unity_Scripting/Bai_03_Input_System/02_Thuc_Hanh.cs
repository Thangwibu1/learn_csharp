using System;
using UnityEngine;

public class InputLessonDemo : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private InputLessonReader inputReader;
    [SerializeField] private InputLessonAvatarMotor avatarMotor;
    [SerializeField] private InputLessonPauseGate pauseGate;

    [Header("Debug")]
    [SerializeField] private bool logActions = true;
    [SerializeField] private bool allowTransformMovement = true;

    private void Awake()
    {
        if (inputReader == null)
        {
            inputReader = GetComponent<InputLessonReader>();
        }

        if (avatarMotor == null)
        {
            avatarMotor = GetComponent<InputLessonAvatarMotor>();
        }

        if (pauseGate == null)
        {
            pauseGate = GetComponent<InputLessonPauseGate>();
        }
    }

    private void Update()
    {
        if (inputReader == null || avatarMotor == null)
        {
            return;
        }

        if (pauseGate != null && pauseGate.IsPaused)
        {
            avatarMotor.StopMotion();
            return;
        }

        if (allowTransformMovement)
        {
            avatarMotor.Move(inputReader.MoveInput);
        }

        if (inputReader.JumpPressed)
        {
            avatarMotor.JumpPulse();
            WriteLog("Jump action received");
        }

        if (inputReader.AttackPressed)
        {
            WriteLog("Attack action received");
        }

        if (inputReader.TogglePausePressed && pauseGate != null)
        {
            pauseGate.TogglePause();
            WriteLog("Pause toggled => " + pauseGate.IsPaused);
        }
    }

    private void WriteLog(string message)
    {
        if (logActions)
        {
            Debug.Log("[InputLessonDemo] " + message, this);
        }
    }
}

public class InputLessonReader : MonoBehaviour
{
    [SerializeField] private bool normalizeMoveInput = true;

    public Vector2 MoveInput { get; private set; }
    public bool JumpPressed { get; private set; }
    public bool AttackPressed { get; private set; }
    public bool TogglePausePressed { get; private set; }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        MoveInput = new Vector2(horizontal, vertical);

        if (normalizeMoveInput && MoveInput.sqrMagnitude > 1f)
        {
            MoveInput = MoveInput.normalized;
        }

        JumpPressed = Input.GetKeyDown(KeyCode.Space);
        AttackPressed = Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.LeftControl);
        TogglePausePressed = Input.GetKeyDown(KeyCode.Escape);
    }

    private void LateUpdate()
    {
        JumpPressed = false;
        AttackPressed = false;
        TogglePausePressed = false;
    }
}

public class InputLessonAvatarMotor : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpHeight = 0.25f;
    [SerializeField] private float jumpDuration = 0.2f;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private Vector3 basePosition;
    private float jumpTimer;
    private bool isJumping;

    private void Awake()
    {
        basePosition = transform.position;

        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    public void Move(Vector2 input)
    {
        Vector3 delta = new Vector3(input.x, input.y, 0f) * moveSpeed * Time.deltaTime;
        basePosition += delta;
        ApplyPosition();

        if (spriteRenderer != null && !Mathf.Approximately(input.x, 0f))
        {
            spriteRenderer.flipX = input.x < 0f;
        }
    }

    public void JumpPulse()
    {
        isJumping = true;
        jumpTimer = 0f;
    }

    public void StopMotion()
    {
        ApplyPosition();
    }

    private void Update()
    {
        ApplyPosition();
    }

    private void ApplyPosition()
    {
        Vector3 final = basePosition;

        if (isJumping)
        {
            jumpTimer += Time.deltaTime;
            float normalized = Mathf.Clamp01(jumpTimer / jumpDuration);
            float arc = Mathf.Sin(normalized * Mathf.PI) * jumpHeight;
            final.y += arc;

            if (normalized >= 1f)
            {
                isJumping = false;
            }
        }

        transform.position = final;
    }
}

public class InputLessonPauseGate : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    public bool IsPaused { get; private set; }

    public void TogglePause()
    {
        IsPaused = !IsPaused;

        if (pausePanel != null)
        {
            pausePanel.SetActive(IsPaused);
        }

        Time.timeScale = IsPaused ? 0f : 1f;
    }

    private void OnDisable()
    {
        if (IsPaused)
        {
            Time.timeScale = 1f;
        }
    }
}

public class InputLessonActionReporter : MonoBehaviour
{
    [SerializeField] private InputLessonReader inputReader;
    [SerializeField] private float reportInterval = 1f;

    private float nextReportTime;

    private void Awake()
    {
        if (inputReader == null)
        {
            inputReader = GetComponent<InputLessonReader>();
        }
    }

    private void Update()
    {
        if (inputReader == null || Time.unscaledTime < nextReportTime)
        {
            return;
        }

        nextReportTime = Time.unscaledTime + reportInterval;
        Debug.Log("[InputLessonActionReporter] Move=" + inputReader.MoveInput, this);
    }
}

public class InputLessonMouseTracker : MonoBehaviour
{
    [SerializeField] private Camera worldCamera;
    [SerializeField] private Transform marker;

    private void Start()
    {
        if (worldCamera == null)
        {
            worldCamera = Camera.main;
        }
    }

    private void Update()
    {
        if (worldCamera == null || marker == null)
        {
            return;
        }

        Vector3 mouse = Input.mousePosition;
        mouse.z = Mathf.Abs(worldCamera.transform.position.z - marker.position.z);
        Vector3 world = worldCamera.ScreenToWorldPoint(mouse);
        marker.position = new Vector3(world.x, world.y, marker.position.z);
    }
}

public class InputLessonBufferedJump : MonoBehaviour
{
    [SerializeField] private float bufferDuration = 0.15f;

    public bool ConsumeBufferedJump()
    {
        if (Time.time > lastJumpPressedTime + bufferDuration)
        {
            return false;
        }

        lastJumpPressedTime = float.NegativeInfinity;
        return true;
    }

    private float lastJumpPressedTime = float.NegativeInfinity;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lastJumpPressedTime = Time.time;
        }
    }
}

public class InputLessonDeviceHint : MonoBehaviour
{
    [SerializeField] private string keyboardHint = "WASD de di chuyen, Space de nhay, Esc de pause.";
    [SerializeField] private string mouseHint = "Chuột trái để tấn công hoặc chọn mục tiêu.";
    [SerializeField] private string designHint = "Hay nghi input theo action nhu Move, Jump, Attack, Pause.";

    private void Start()
    {
        Debug.Log("[InputLessonDeviceHint] " + keyboardHint, this);
        Debug.Log("[InputLessonDeviceHint] " + mouseHint, this);
        Debug.Log("[InputLessonDeviceHint] " + designHint, this);
    }
}
