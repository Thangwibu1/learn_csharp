using UnityEngine;

public interface IEnemyState
{
    void Enter();
    void Tick();
    void Exit();
}

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float chaseRange = 5f;
    public float attackRange = 1.5f;

    private IEnemyState currentState;

    public IdleState IdleState { get; private set; }
    public ChaseState ChaseState { get; private set; }
    public AttackState AttackState { get; private set; }

    void Awake()
    {
        IdleState = new IdleState(this);
        ChaseState = new ChaseState(this);
        AttackState = new AttackState(this);
    }

    void Start()
    {
        ChangeState(IdleState);
    }

    void Update()
    {
        currentState.Tick();
    }

    public void ChangeState(IEnemyState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public float DistanceToPlayer()
    {
        return Vector3.Distance(transform.position, player.position);
    }
}

public class IdleState : IEnemyState
{
    private readonly EnemyAI enemy;

    public IdleState(EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        Debug.Log("Enemy vao Idle");
    }

    public void Tick()
    {
        if (enemy.DistanceToPlayer() <= enemy.chaseRange)
        {
            enemy.ChangeState(enemy.ChaseState);
        }
    }

    public void Exit()
    {
    }
}

public class ChaseState : IEnemyState
{
    private readonly EnemyAI enemy;

    public ChaseState(EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        Debug.Log("Enemy vao Chase");
    }

    public void Tick()
    {
        float distance = enemy.DistanceToPlayer();

        if (distance > enemy.chaseRange)
        {
            enemy.ChangeState(enemy.IdleState);
            return;
        }

        if (distance <= enemy.attackRange)
        {
            enemy.ChangeState(enemy.AttackState);
        }
    }

    public void Exit()
    {
    }
}

public class AttackState : IEnemyState
{
    private readonly EnemyAI enemy;

    public AttackState(EnemyAI enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        Debug.Log("Enemy vao Attack");
    }

    public void Tick()
    {
        float distance = enemy.DistanceToPlayer();

        if (distance > enemy.attackRange)
        {
            enemy.ChangeState(enemy.ChaseState);
            return;
        }

        Debug.Log("Enemy dang tan cong player");
    }

    public void Exit()
    {
    }
}
