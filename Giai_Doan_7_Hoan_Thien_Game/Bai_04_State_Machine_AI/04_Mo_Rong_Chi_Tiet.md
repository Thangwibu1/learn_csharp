# Mo rong chi tiet: State Machine AI

## 1. Vi sao AI can state machine

- AI game hiem khi chi co mot hanh vi duy nhat.
- Quai co luc dung yen, co luc tuan tra, co luc duoi theo, co luc tan cong, co luc bi choang, co luc chet.
- Neu nhet moi dieu kien vao mot `Update()` dai, code se nhanh chong tro nen kho doc.
- State machine giup chia hanh vi theo tung trang thai ro rang.

## 2. Y tuong cot loi

- Tai mot thoi diem, AI thuong o mot state chinh.
- Moi state co logic rieng.
- Co dieu kien de chuyen tu state nay sang state khac.
- Day la cach mo ta hanh vi de doc, de ve, de test.

## 3. Vi du quái co ban

- `Idle`: dung yen quan sat.
- `Patrol`: di qua lai giua cac diem.
- `Chase`: thay player thi duoi theo.
- `Attack`: den gan thi tan cong.
- `Dead`: khong lam gi nua.

## 4. Chuyen state la gi

- AI dang `Idle` ma thay player trong tam nhin thi sang `Chase`.
- AI dang `Chase` ma den tam danh thi sang `Attack`.
- AI dang `Attack` ma player chay xa thi quay ve `Chase`.
- AI het mau thi sang `Dead` tu bat ky state nao.

## 5. Loi ich lon nhat

- Code ro y dinh.
- De tim bug.
- De them state moi.
- De tach trach nhiem.
- De giai thich cho nguoi khac trong team.

## 6. Hai cach thong dung

- Dung `enum` va `switch` trong mot script.
- Dung moi state la mot class rieng.
- Cach enum de bat dau nhanh.
- Cach class rieng sach hon khi AI lon dan.

## 7. Enum state machine cho beginner

- Day la cach de hieu som.
- Ban co `EnemyState.Idle`, `EnemyState.Chase`, `EnemyState.Attack`.
- Trong `Update`, dua vao state hien tai ma goi logic tuong ung.
- Sau do xet dieu kien de doi state.

## 8. Vi du enum don gian

```csharp
using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    private enum EnemyState
    {
        Idle,
        Chase,
        Attack,
        Dead
    }

    [SerializeField] private Transform player;
    [SerializeField] private float chaseRange = 5f;
    [SerializeField] private float attackRange = 1.5f;

    private EnemyState currentState = EnemyState.Idle;

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Idle:
                UpdateIdle();

## 9. Diem yeu cua enum state machine

- Nhanh de bat dau.
- Nhung de bi phinh to khi state tang len.
- `switch` co the rat dai.
- Logic tung state de bi tron lan vao nhau.

## 10. Uu diem cua state class rieng

- Moi state mot file hoac mot class rieng.
- Tranh `switch` qua lon.
- De test tung state.
- De thay doi hanh vi ma khong anh huong nhieu toi state khac.

## 11. Enter Tick Exit co y nghia gi

- `Enter`: chay mot lan khi vao state.
- `Tick`: chay lien tuc trong luc dang o state.
- `Exit`: chay mot lan khi roi state.

Day la bo khung rat de suy nghi.

## 12. Vi sao can Enter

- Co nhieu hanh vi chi can lam mot lan.
- Vi du bat animation chase.
- Vi du reset attack timer.
- Vi du in log.

Neu dat het vao `Tick`, ban de bi lap lai viec khong can thiet moi frame.

## 13. Vi sao can Exit

- Co nhieu state can don dep truoc khi roi di.
- Vi du tat hieu ung canh bao.
- Vi du reset du lieu tam.
- Vi du ngat mot coroutine cu.

## 14. State machine va trach nhiem ro rang

- State machine quyet dinh "dang o hanh vi nao".
- Movement system quyet dinh "di nhu the nao".
- Animation system quyet dinh "hien ra sao".
- Weapon system quyet dinh "gay sat thuong ra sao".

Khong nen de state machine lam het moi thu.

## 15. State machine khong thay the moi he thong khac

- Day la diem nguoi moi hay nham.
- State machine la mot lop dieu phoi hanh vi.
- No khong phai ca AI day du.

## 16. Dieu kien chuyen state nen dat o dau

- Thuong dat trong state hien tai.
- Hoac dat mot phan o state machine trung tam.
- Dieu quan trong la co quy tac ro rang va nhat quan.

## 17. Priority cua state

- Neu vua du range attack, vua het mau thi state nao uu tien?
- Thuong `Dead` phai uu tien cao nhat.
- Sau do den state can khan cap nhu stun.

## 18. Cach tranh chuyen state loạn

- Khong goi `ChangeState` lien tuc o nhieu noi vo toi va.
- Dat rang buoc ro.
- Sau khi doi state, neu can thi `return` ngay.

## 19. State transition graph

- Day la so do luong chuyen state.
- Ve duoc graph thi code se de hon.

Vi du:

- Idle -> Patrol
- Patrol -> Chase
- Chase -> Attack
- Attack -> Chase
- Chase -> ReturnHome
- ReturnHome -> Patrol
- Any -> Dead

## 20. `Any -> Dead` la gi

- Nghia la tu bat ky state nao, neu dieu kien chet xay ra, AI vao `Dead`.
- Day la mot quy tac rat thuong gap.

## 21. State machine va animation event

- Co the state doi truoc.
- Animation theo sau.
- Hoac animation event thong bao luc gay sat thuong trong Attack state.

Can phan biet:

- animation la bieu hien
- state la logic

## 22. State machine va cooldown

- Attack state rat hay can cooldown.
- Neu khong, quai co the tan cong moi frame.
- Cooldown la mot du lieu phu tro cho state.

## 23. State machine va pathfinding

- Chase state thuong goi he thong pathfinding hoac movement.
- State khong can tu tinh toan duong di phuc tap neu da co he thong rieng.

## 24. State machine va sensing

- AI can biet khi nao thay player.
- Viec nay co the tach thanh sensing system.
- State machine chi doc ket qua sensing.

## 25. Loi hay gap khi moi hoc

- Moi frame goi `ChangeState(currentState)`.
- Quen `Exit`.
- Quen `Enter`.
- State truy cap qua nhieu thu khong lien quan.
- Condition chong cheo lam AI nhay state lien tuc.

## 26. Giai phap giam phu thuoc

- Truyen vao state chi nhung gi no can.
- Khong de state tu tim moi thu qua `FindObjectOfType`.
- Dung reference ro rang.

## 27. Cach dat ten state de doc de hieu

- Dat ten theo hanh vi.
- `PatrolState`, `ChaseState`, `AttackState`, `DeadState`.
- Tranh ten mo ho.

## 28. Khi nao khong can state machine phuc tap

- Enemy rat don gian.
- Chi co 2 hanh vi nho.
- Du an prototype cuc nho.

Nhung ngay ca khi do, state machine don gian van thuong de doc hon `if else` lung tung.

## 29. Bai hoc kien truc

- State machine la mot cach dong goi hanh vi.
- Day la mot buoc rat tot de di tu code vo to chuc sang code co kien truc.

## 30. Tu kiem tra

1. Vi sao `Dead` thuong uu tien cao nhat?
2. Vi sao `Enter`, `Tick`, `Exit` de suy nghi?
3. Khi nao nen tach state thanh class rieng?
4. Vi sao state machine giam do roi cua `Update()`?
5. Vi sao state machine rat hop cho AI game?
                break;
            case EnemyState.Chase:
                UpdateChase();
                break;
            case EnemyState.Attack:
                UpdateAttack();
                break;
            case EnemyState.Dead:
                break;
        }
    }

    private void UpdateIdle()
    {
        if (DistanceToPlayer() <= chaseRange)
        {
            currentState = EnemyState.Chase;
        }
    }

    private void UpdateChase()
    {
        if (DistanceToPlayer() <= attackRange)
        {
            currentState = EnemyState.Attack;
            return;
        }
    }

    private void UpdateAttack()
    {
        if (DistanceToPlayer() > attackRange)
        {
            currentState = EnemyState.Chase;
        }
    }

    private float DistanceToPlayer()
    {
        return Vector2.Distance(transform.position, player.position);
    }
}
```

## 9. Moi state la mot class rieng

- Cach nay dep hon khi AI co nhieu state va logic phuc tap.
- Moi state co the co `Enter`, `Tick`, `Exit`.
- `Enter` dung de chuan bi.
- `Tick` la logic dang chay.
- `Exit` dung de don dep truoc khi roi state.
- Day rat giong cach nghi ve lifecycle nho ben trong AI.

## 10. Loi ich cua Enter Tick Exit

- `Enter`: bat animation, reset timer, dat muc tieu.
- `Tick`: xu ly hanh vi lien tuc.
- `Exit`: tat animation, huy event, xoa du lieu tam.
- Co ba khoang nay, logic de sap xep hon nhieu.

## 11. State machine va animation

- State gameplay AI va state animation khong nhat thiet la cung mot thu.
- Nhung chung lien quan rat chat.
- Khi vao `Chase`, AI co the dat animator sang chay.
- Khi vao `Attack`, dat trigger tan cong.
- Khi vao `Dead`, bat animation chet.
- Can tach ro logic quyet dinh va bieu dien.

## 12. State machine va physics

- State `Chase` co the di chuyen bang rigidbody.
- State `Attack` co the dung di va chuan bi danh.
- State `Stunned` co the tam thoi khoa input AI.
- Day la vi du state tac dong den movement va vat ly.

## 13. State machine va input

- AI khong doc input nguoi choi, nhung no van doc "input tu moi truong".
- Vi du khoang cach den player, co thay player khong, het mau chua, dang bi choang khong.
- Co the xem day la dau vao de state machine dua quyet dinh.

## 14. State machine va observer

- AI co the lang nghe event nhu `OnPlayerDied`, `OnAlarmTriggered`.
- Hoac AI co the phat event nhu `OnEnemyDied`.
- Observer giup state machine khong can polling qua nhieu chuyen ngoai he.
- Hai pattern nay bo tro nhau rat tot.

## 15. State machine va save system

- Khong phai luc nao can luu state tam thoi cua AI.
- Tuy game, co the chi can luu rang enemy da chet hay chua.
- Hoac luu vi tri va trang thai canh gio.
- Can can nhac muc do chi tiet can phuc hoi.

## 16. Cooldown trong state tan cong

- State `Attack` thuong khong danh lien tuc moi frame.
- No can cooldown.
- Ban co the dung timer trong state.
- Khi cooldown xong va player van trong tam, AI danh tiep.
- Day la vi du cho thay moi state co du lieu rieng.

## 17. Patrol va waypoint

- State `Patrol` co the giu danh sach diem.
- AI di tu diem nay sang diem khac.
- Den noi thi doi muc tieu.
- Khi thay player, state chuyen sang `Chase`.
- Day la mo hinh rat hay gap trong game hanh dong.

## 18. Tranh dieu kien chong cheo

- Khi khong co state machine, ban hay viet nhieu `if` doc lap.
- Co the xay ra `attack = true`, `chase = true`, `idle = true` cung luc.
- State machine ep AI vao mot trang thai chinh, giam xung dot.

## 19. Dinh nghia chuyen state ro rang

- Moi state nen co ly do vao.
- Moi state nen co ly do ra.
- Neu chuyen state qua tuy tien, AI se kho du doan va kho debug.
- Hoi "tai sao no doi state luc nay" la cau hoi trung tam khi test AI.

## 20. Ghi log state de debug

- Khi hoc, rat nen in log luc doi state.
- Vi du `Idle -> Chase`, `Chase -> Attack`.
- Dieu nay giup ban nhin ro luong suy nghi cua AI.
- Sau khi on dinh, co the giam log di.

## 21. Dieu kien cam nhan player

- Khoang cach den player.
- Player co trong tam nhin raycast khong.
- Player co tao tieng dong khong.
- Enemy co dang bi choang khong.
- Mau con bao nhieu.

## 22. State machine va component thinking

- `EnemyBrain` quan ly chuyen state.
- `EnemyMovement` lo di chuyen.
- `EnemyHealth` lo mau.
- `EnemyAnimator` lo animation.
- `EnemySensor` lo cam bien.
- State machine co the phoi hop cac component thay vi om tat ca vao mot script.

## 23. Loi thuong gap cua nguoi moi

- Nhét het AI vao mot `Update` dai.
- Khong tach state ro rang.
- De nhieu boolean mau thuan nhau.
- State biet qua nhieu chi tiet khong can thiet.
- Quen xu ly state `Dead` tu moi noi.

## 24. Checklist khi AI hanh vi ky la

- Hien tai AI dang o state nao?
- Dieu kien vao state co dung khong?
- Dieu kien ra state co dung khong?
- Animation co dang lam ban nghi AI sai khong?
- Khoang cach va raycast co do dung khong?
- Co event nao vua kich hoat state ngoai y muon khong?

## 25. Bai tap tu hoc

- Tao enemy co `Idle`, `Chase`, `Attack`.
- Them `Dead` khi mau ve 0.
- In log moi lan doi state.
- Them animation parameter theo state.
- Them cooldown tan cong 1 giay.

## 26. Cau hoi tu kiem tra

- Vi sao state machine de mo rong hon mot script `Update` khong lo?
- Khi nao enum du, khi nao nen tach state thanh class?
- `Enter`, `Tick`, `Exit` giup gi?
- Vi sao gameplay state va animation state khong nen bi xem la mot?
- Observer co the ho tro AI nhu the nao?

## 27. Ket noi voi observer pattern

- Khi AI chet, UI, score, loot, achievement deu co the can biet.
- Observer pattern se giup chung nhan thong tin ma khong bi dan chat vao `EnemyBrain`.
- Day la ly do state machine va observer thuong di chung trong game sach kien truc.
