using UnityEngine;

public interface ILesson04EnemyState
{
    void Enter();
    void Tick();
    void Exit();
}

public class Lesson04EnemyAI : MonoBehaviour
{
    [Header("Muc tieu")]
    [SerializeField] private Transform player;

    [Header("Di chuyen")]
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private Transform[] patrolPoints;
    [SerializeField] private float patrolWaitTime = 1f;

    [Header("Tam phat hien")]
    [SerializeField] private float sightRange = 6f;
    [SerializeField] private float loseSightRange = 8f;
    [SerializeField] private float attackRange = 1.5f;

    [Header("Trang thai chien dau")]
    [SerializeField] private int maxHealth = 60;
    [SerializeField] private float attackCooldown = 1.25f;
    [SerializeField] private float stunDuration = 1f;

    [Header("Bieu dien")]
    [SerializeField] private Renderer bodyRenderer;
    [SerializeField] private Color idleColor = Color.white;
    [SerializeField] private Color patrolColor = Color.cyan;
    [SerializeField] private Color chaseColor = Color.yellow;
    [SerializeField] private Color attackColor = Color.red;
    [SerializeField] private Color stunColor = Color.magenta;
    [SerializeField] private Color deadColor = Color.gray;

    private ILesson04EnemyState currentState;
    private float attackCooldownTimer;
    private float stunTimer;
    private float patrolWaitTimer;
    private int currentHealth;
    private int patrolIndex;

    public Lesson04IdleState IdleState { get; private set; }
    public Lesson04PatrolState PatrolState { get; private set; }
    public Lesson04ChaseState ChaseState { get; private set; }
    public Lesson04AttackState AttackState { get; private set; }
    public Lesson04StunnedState StunnedState { get; private set; }
    public Lesson04DeadState DeadState { get; private set; }

    public Transform Player => player;
    public float MoveSpeed => moveSpeed;
    public float PatrolWaitTime => patrolWaitTime;
    public float SightRange => sightRange;
    public float LoseSightRange => loseSightRange;
    public float AttackRange => attackRange;
    public bool IsDead => currentHealth <= 0;
    public bool CanAttack => attackCooldownTimer <= 0f;
    public bool HasPatrolPoints => patrolPoints != null && patrolPoints.Length > 0;

    private void Awake()
    {
        currentHealth = maxHealth;
        IdleState = new Lesson04IdleState(this);
        PatrolState = new Lesson04PatrolState(this);
        ChaseState = new Lesson04ChaseState(this);
        AttackState = new Lesson04AttackState(this);
        StunnedState = new Lesson04StunnedState(this);
        DeadState = new Lesson04DeadState(this);
    }

    private void Start()
    {
        ChangeState(HasPatrolPoints ? (ILesson04EnemyState)PatrolState : IdleState);
    }

    private void Update()
    {
        attackCooldownTimer -= Time.deltaTime;
        currentState?.Tick();
    }

    public void ChangeState(ILesson04EnemyState nextState)
    {
        if (nextState == null)
        {
            return;
        }

        currentState?.Exit();
        currentState = nextState;
        currentState.Enter();
    }

    public float DistanceToPlayer()
    {
        if (player == null)
        {
            return float.MaxValue;
        }

        return Vector3.Distance(transform.position, player.position);
    }

    public Vector3 GetCurrentPatrolPoint()
    {
        if (!HasPatrolPoints)
        {
            return transform.position;
        }

        return patrolPoints[patrolIndex].position;
    }

    public void AdvancePatrolIndex()
    {
        if (!HasPatrolPoints)
        {
            return;
        }

        patrolIndex = (patrolIndex + 1) % patrolPoints.Length;
    }

    public bool MoveTowards(Vector3 target)
    {
        Vector3 offset = target - transform.position;
        offset.y = 0f;

        if (offset.sqrMagnitude <= 0.0001f)
        {
            return true;
        }

        Vector3 direction = offset.normalized;
        transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
        transform.forward = Vector3.Lerp(transform.forward, direction, 12f * Time.deltaTime);
        return Vector3.Distance(transform.position, target) <= 0.1f;
    }

    public void LookAtPlayer()
    {
        if (player == null)
        {
            return;
        }

        Vector3 direction = player.position - transform.position;
        direction.y = 0f;

        if (direction.sqrMagnitude > 0.001f)
        {
            transform.forward = Vector3.Lerp(transform.forward, direction.normalized, 15f * Time.deltaTime);
        }
    }

    public void ApplyStateColor(Color color)
    {
        if (bodyRenderer != null && bodyRenderer.material != null)
        {
            bodyRenderer.material.color = color;
        }
    }

    public void ApplyIdleVisuals()
    {
        ApplyStateColor(idleColor);
    }

    public void ApplyPatrolVisuals()
    {
        ApplyStateColor(patrolColor);
    }

    public void ApplyChaseVisuals()
    {
        ApplyStateColor(chaseColor);
    }

    public void ApplyAttackVisuals()
    {
        ApplyStateColor(attackColor);
    }

    public void ApplyStunVisuals()
    {
        ApplyStateColor(stunColor);
    }

    public void ApplyDeadVisuals()
    {
        ApplyStateColor(deadColor);
    }

    public bool CanSeePlayer()
    {
        return player != null && DistanceToPlayer() <= sightRange;
    }

    public bool LostPlayer()
    {
        return player == null || DistanceToPlayer() > loseSightRange;
    }

    public bool InAttackRange()
    {
        return player != null && DistanceToPlayer() <= attackRange;
    }

    public void PerformAttack()
    {
        attackCooldownTimer = attackCooldown;
        Debug.Log("Enemy tan cong player trong demo state machine.");
    }

    public void TakeDamage(int damage, bool stun)
    {
        if (IsDead)
        {
            return;
        }

        currentHealth = Mathf.Max(0, currentHealth - Mathf.Max(0, damage));

        if (currentHealth == 0)
        {
            ChangeState(DeadState);
            return;
        }

        if (stun)
        {
            stunTimer = stunDuration;
            ChangeState(StunnedState);
        }
    }

    public bool TickStunTimer()
    {
        stunTimer -= Time.deltaTime;
        return stunTimer <= 0f;
    }

    public void ResetPatrolWait()
    {
        patrolWaitTimer = patrolWaitTime;
    }

    public bool TickPatrolWait()
    {
        patrolWaitTimer -= Time.deltaTime;
        return patrolWaitTimer <= 0f;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.gray;
        Gizmos.DrawWireSphere(transform.position, loseSightRange);
    }
}

public class Lesson04IdleState : ILesson04EnemyState
{
    private readonly Lesson04EnemyAI enemy;

    public Lesson04IdleState(Lesson04EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        enemy.ApplyIdleVisuals();
        Debug.Log("Enemy vao state Idle.");
    }

    public void Tick()
    {
        if (enemy.IsDead)
        {
            enemy.ChangeState(enemy.DeadState);
            return;
        }

        if (enemy.CanSeePlayer())
        {
            enemy.ChangeState(enemy.ChaseState);
            return;
        }

        if (enemy.HasPatrolPoints)
        {
            enemy.ChangeState(enemy.PatrolState);
        }
    }

    public void Exit()
    {
    }
}

public class Lesson04PatrolState : ILesson04EnemyState
{
    private readonly Lesson04EnemyAI enemy;

    public Lesson04PatrolState(Lesson04EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        enemy.ApplyPatrolVisuals();
        enemy.ResetPatrolWait();
        Debug.Log("Enemy vao state Patrol.");
    }

    public void Tick()
    {
        if (enemy.IsDead)
        {
            enemy.ChangeState(enemy.DeadState);
            return;
        }

        if (enemy.CanSeePlayer())
        {
            enemy.ChangeState(enemy.ChaseState);
            return;
        }

        if (enemy.MoveTowards(enemy.GetCurrentPatrolPoint()))
        {
            if (enemy.TickPatrolWait())
            {
                enemy.AdvancePatrolIndex();
                enemy.ResetPatrolWait();
            }
        }
    }

    public void Exit()
    {
    }
}

public class Lesson04ChaseState : ILesson04EnemyState
{
    private readonly Lesson04EnemyAI enemy;

    public Lesson04ChaseState(Lesson04EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        enemy.ApplyChaseVisuals();
        Debug.Log("Enemy vao state Chase.");
    }

    public void Tick()
    {
        if (enemy.IsDead)
        {
            enemy.ChangeState(enemy.DeadState);
            return;
        }

        if (enemy.LostPlayer())
        {
            enemy.ChangeState(enemy.HasPatrolPoints ? (ILesson04EnemyState)enemy.PatrolState : enemy.IdleState);
            return;
        }

        if (enemy.InAttackRange())
        {
            enemy.ChangeState(enemy.AttackState);
            return;
        }

        if (enemy.Player != null)
        {
            enemy.MoveTowards(enemy.Player.position);
        }
    }

    public void Exit()
    {
    }
}

public class Lesson04AttackState : ILesson04EnemyState
{
    private readonly Lesson04EnemyAI enemy;

    public Lesson04AttackState(Lesson04EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        enemy.ApplyAttackVisuals();
        Debug.Log("Enemy vao state Attack.");
    }

    public void Tick()
    {
        if (enemy.IsDead)
        {
            enemy.ChangeState(enemy.DeadState);
            return;
        }

        if (!enemy.InAttackRange())
        {
            enemy.ChangeState(enemy.ChaseState);
            return;
        }

        enemy.LookAtPlayer();

        if (enemy.CanAttack)
        {
            enemy.PerformAttack();
        }
    }

    public void Exit()
    {
    }
}

public class Lesson04StunnedState : ILesson04EnemyState
{
    private readonly Lesson04EnemyAI enemy;

    public Lesson04StunnedState(Lesson04EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        enemy.ApplyStunVisuals();
        Debug.Log("Enemy vao state Stunned.");
    }

    public void Tick()
    {
        if (enemy.IsDead)
        {
            enemy.ChangeState(enemy.DeadState);
            return;
        }

        if (enemy.TickStunTimer())
        {
            if (enemy.CanSeePlayer())
            {
                enemy.ChangeState(enemy.ChaseState);
            }
            else
            {
                enemy.ChangeState(enemy.HasPatrolPoints ? (ILesson04EnemyState)enemy.PatrolState : enemy.IdleState);
            }
        }
    }

    public void Exit()
    {
    }
}

public class Lesson04DeadState : ILesson04EnemyState
{
    private readonly Lesson04EnemyAI enemy;

    public Lesson04DeadState(Lesson04EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        enemy.ApplyDeadVisuals();
        Debug.Log("Enemy vao state Dead.");
    }

    public void Tick()
    {
    }

    public void Exit()
    {
    }
}

public class Lesson04EnemyDebugInput : MonoBehaviour
{
    [SerializeField] private Lesson04EnemyAI enemy;

    private void Update()
    {
        if (enemy == null)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            enemy.TakeDamage(10, false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            enemy.TakeDamage(5, true);
        }
    }
}
