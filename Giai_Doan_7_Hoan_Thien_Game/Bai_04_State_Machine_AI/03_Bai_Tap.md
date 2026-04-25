# Bài tập Bài 4

## Bài 1

Thêm state `Patrol` vào state machine của quái.

## Bài 2

Cho quái chuyển từ `Patrol` sang `Chase` khi thấy player.

## Bài 3

Tự giải thích: vì sao state machine dễ bảo trì hơn một `Update()` dài?

## Muc tieu cua bo bai tap

- Hieu state machine bang tay, khong chi doc ly thuyet.
- Biet tach logic tung state thanh don vi ro rang.
- Biet dat dieu kien chuyen state.
- Biet doc log de xem AI dang o state nao.
- Biet mo rong AI ma khong pha logic cu.

## Cach lam bai tap hieu qua

- Lam bai de nhat truoc.
- Moi lan them state, viet log ro rang.
- Tu ve so do state tren giay neu can.
- Sau moi bai, tu tra loi: AI dang o state nao va tai sao?

## Bai 4: Viet enum state machine ban dau

Yeu cau:

- Tao enum gom `Idle`, `Patrol`, `Chase`, `Attack`, `Dead`.
- Tao bien `currentState`.
- Trong `Update`, dung `switch` theo `currentState`.

Muc tieu:

- Nhin bang mat thay duoc khung state machine co ban.

## Bai 5: Log state hien tai

Yeu cau:

- Moi khi state doi, in log state cu va state moi.
- Khong spam log moi frame neu state khong doi.

Goi y:

- Chi log trong ham `ChangeState()`.

## Bai 6: Tao state Patrol

Yeu cau:

- Tao 2 diem patrol.
- Quai di qua lai giua 2 diem.
- Khi den gan diem dich, doi sang diem con lai.

Muc tieu:

- Hieu rang moi state co hanh vi rieng.

## Bai 7: Patrol sang Chase

Yeu cau:

- Neu player vao tam phat hien, quai roi Patrol va sang Chase.
- In log ro rang `Patrol -> Chase`.

## Bai 8: Chase sang Attack

Yeu cau:

- Neu player vao attack range, quai sang Attack.
- Neu player con xa, tiep tuc Chase.

## Bai 9: Attack sang Chase

Yeu cau:

- Neu player lui ra khoi tam danh, quai quay lai Chase.

Muc tieu:

- Hieu state machine la su chuyen doi lien tuc dua tren dieu kien.

## Bai 10: Chase sang Idle

Yeu cau:

- Neu player bo di qua xa, quai bo duoi va quay ve Idle hoac Patrol.

Tu chon:

- quay ve Idle
- hoac quay ve Patrol

Sau do tu giai thich vi sao ban chon cach do.

## Bai 11: Dead state

Yeu cau:

- Khi health <= 0, quai vao `Dead`.
- Khi da vao `Dead`, khong duoc quay lai cac state khac.

## Bai 12: Viet `IEnemyState`

Yeu cau:

- Tao interface gom `Enter()`, `Tick()`, `Exit()`.
- Sau do viet lai state machine theo kieu moi state la mot class.

Muc tieu:

- Hieu su khac nhau giua enum state machine va class-based state machine.

## Bai 13: So sanh 2 cach lam

Hay tu so sanh:

- enum + switch
- class rieng cho moi state

Theo tieu chi:

- de bat dau
- de mo rong
- de doc
- de debug

## Bai 14: Them state Hit

Tinh huong:

- Quai bi trung don manh va bi khung lai mot chut.

Yeu cau:

- Tao state `Hit`.
- O state nay quai tam dung di chuyen trong mot khoang ngan.
- Sau do quay lai `Chase` neu player van trong tam.

## Bai 15: Them state ReturnHome

Tinh huong:

- Quai duoi player mot doan nhung sau do mat muc tieu.

Yeu cau:

- Tao state `ReturnHome`.
- Quai quay ve vi tri goc.
- Khi da ve den vi tri goc, sang `Idle` hoac `Patrol`.

## Bai 16: Patrol point list

Yeu cau:

- Khong chi 2 diem, hay tao danh sach nhieu patrol point.
- Quai duyet lan luot cac diem.

Muc tieu:

- Hieu cach mo rong hanh vi ma khong pha state machine cu.

## Bai 17: Dieu kien chuyen state dep hon

Hay refactor:

- tach ham `CanSeePlayer()`
- tach ham `IsInAttackRange()`
- tach ham `IsDead()`

Muc tieu:

- Dieu kien doc de hieu hon.

## Bai 18: Log debug thong minh

Yeu cau:

- Moi state co log `Enter` va `Exit`.
- Khi chuyen state, log ly do.

Vi du:

- `Idle -> Chase because player entered detection range`

## Bai 19: Giai quyet bug lap state lien tuc

Tinh huong:

- AI doi qua doi lai giua `Chase` va `Attack` qua nhanh.

Hay de xuat cach sua:

- dung nguong range ro hon
- dung cooldown ngan
- dung hysteresis

## Bai 20: Giai thich hysteresis

Tu tim hieu va viet ngan gon:

- hysteresis la gi
- vi sao no huu ich trong state machine

## Bai 21: Boss state machine

Hay thiet ke state machine cho boss gom:

- Idle
- Phase1Attack
- SummonMinions
- DashAttack
- RageMode
- Dead

Khong can code het.

Chi can viet ro:

- state nao chuyen sang state nao
- dieu kien chuyen la gi

## Bai 22: State machine cho NPC

Hay thiet ke state machine cho NPC gom:

- Idle
- Talk
- WalkToTarget
- Wait

Muc tieu:

- thay state machine khong chi dung cho quai.

## Bai 23: State machine va animation

Hay tu giai thich:

- logic state machine co nen dính chat vao animation khong?
- lam sao de state doi thi animation cung doi, nhung code van gon?

## Bai 24: State machine va pathfinding

Hay tu mo ta:

- state machine quan ly cai gi
- pathfinding quan ly cai gi

Muc tieu:

- phan biet ro trach nhiem cua he thong.

## Bai 25: Tinh huong thuc chien

Tinh huong:

- Quai vua tan cong vua bi player ra khoi tam.
- Cung luc do quai sap het mau.

Hay tra loi:

- uu tien chuyen state nao truoc?
- vi sao?

## Bai 26: Thu nghiem bang cach pha logic

Hay co y tao bug:

- bo quên `return` sau khi `ChangeState`
- khong goi `Exit`
- khong goi `Enter`

Sau do quan sat bug xay ra nhu the nao.

## Bai 27: Mini project 1

Tao mot quai don gian co:

- Idle
- Patrol
- Chase
- Attack
- Dead

Yeu cau:

- co phat hien player
- co tan cong trong range
- co log doi state

## Bai 28: Mini project 2

Mo rong mini project 1 bang cach them:

- Hit
- ReturnHome

Yeu cau:

- code van gon
- khong nham lan trach nhiem giua cac state

## Bai 29: Mini project 3

Tao mot boss state machine chi tren giay hoac markdown.

Phai co:

- so do state
- dieu kien chuyen
- phase change theo % health

## Cau hoi tu kiem tra

1. State machine giai quyet van de gi?
2. Tai sao nhét het vao `Update()` lai kho bao tri?
3. Khi nao nen dung enum?
4. Khi nao nen tach state thanh class rieng?
5. Vi sao can `Enter`, `Tick`, `Exit`?
6. Vi sao state machine hop voi AI game?

## Loi sai thuong gap cua nguoi moi

### 1. Cho qua nhieu logic vao mot state

### 2. Chuyen state o nhieu noi, khong co diem trung tam

### 3. Khong log ly do chuyen state

### 4. Khong xac dinh state uu tien cao nhat

### 5. Khong chan state sau khi chet

## Thu thach nang cao 1

Them cooldown tan cong vao Attack state.

## Thu thach nang cao 2

Them he thong nhin thay player bang raycast.

## Thu thach nang cao 3

Cho 2 loai quai dung chung interface state nhung hanh vi khac nhau.

## Ket luan bai tap

Neu lam duoc bo bai tap nay, ban da vuot qua muc "biet code AI bang if else".

Ban dang bat dau co tu duy kien truc hanh vi.
