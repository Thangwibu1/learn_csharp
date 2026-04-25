# Mo rong chi tiet: Observer Pattern thuc chien

## 1. Van de observer giai quyet

- Trong game co rat nhieu noi can biet khi mot du lieu thay doi.
- Player mat mau thi UI can cap nhat.
- Player diet enemy thi score can tang.
- Dat moc achievement thi popup can hien.
- Neu moi he thong tu di hoi moi frame, code se roi va phu thuoc cao.

## 2. Y tuong cot loi

- Co mot noi phat su kien khi du lieu thay doi.
- Co nhieu noi dang ky nghe su kien do.
- Khi su kien xay ra, moi noi nghe se phan ung theo viec cua minh.
- Nguon phat khong can biet cu the ai dang nghe.

## 3. Tai sao goi la observer

- Cac he thong nghe duoc xem nhu nguoi quan sat.
- Chu the chinh khong phai tu tim tung nguoi de bao.
- No chi phat thong bao.
- Ai dang quan sat se tu nhan duoc.

## 4. Loi ich lon nhat

- Giam phu thuoc giua cac he thong.
- UI khong can nam chat ben trong `PlayerHealth`.
- Achievement khong can duoc goi thu cong o moi noi.
- Them listener moi de hon.
- Giam polling trong `Update`.

## 5. Vi du rat thuc te

- `PlayerHealth` doi tu 80 xuong 60.
- No phat `OnHealthChanged(60, 100)`.
- `HealthBarUI` nghe su kien va doi thanh mau.
- `LowHealthWarning` nghe su kien va bat canh bao neu duoi nguong.
- `AchievementSystem` co the nghe neu co thanh tuu lien quan song sot.

## 6. Observer va event trong C#

- Trong C#, ta thuong gap `delegate`, `Action`, `event`.
- Voi beginner, co the bat dau bang `Action` va `event`.
- `event` giup gioi han cach ben ngoai tac dong vao su kien.
- Day la cach rat hop cho code game co nhieu listener.

## 7. Vi du class phat event

```csharp
using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public event Action<int, int> OnHealthChanged;

    [SerializeField] private int maxHealth = 100;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth = Mathf.Max(0, currentHealth - damage);
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }
}
```

## 8. Vi du class nghe event

```csharp
using UnityEngine;
using UnityEngine.UI;

## 9. Vi sao event khien code sach hon

- Source khong can giu danh sach class cu the can goi.
- Moi listener chi lo viec cua minh.
- Them listener moi khong can sua source qua nhieu.

## 10. Observer pattern va architecture game

- Trong game, nhieu he thong cung nghe mot su kien.
- Day la kieu bai toan rat tu nhien cho observer.
- Vi du `OnEnemyKilled` co the duoc nghe boi:
- score system
- quest system
- achievement system
- analytics system

## 11. Tai sao khong polling moi frame

- Polling la cu moi frame lai hoi du lieu co doi khong.
- Viec nay thuong vua thua vua lam code bi tan man.
- Neu du lieu chi doi o mot so su kien ro rang, event hop hon nhieu.

## 12. Event la thong bao, khong phai logic tong hop

- Source nen phat thong bao ngan gon.
- Khong nen nhan dip event ma nhat them qua nhieu logic khong lien quan vao cung mot noi.

## 13. Listener nen nho, ro trach nhiem

- `HealthBarUI` chi lo UI.
- `AchievementOnDeath` chi lo thanh tuu.
- `DeathSoundPlayer` chi lo am thanh.

Day la cach chia nho trach nhiem dep hon.

## 14. Event va decoupling

- Decoupling la giam phu thuoc cứng.
- Event giup source khong biet cu the ai dang nghe.
- Day lam he thong de mo rong hon.

## 15. Event va test

- Listener nho thuong de test hon.
- Ban co the gia lap su kien va xem listener phan ung ra sao.

## 16. Dung event o dau la hop ly

- Health changed
- Gold changed
- Quest completed
- Enemy killed
- Player died
- Scene loaded

## 17. Khong nen event hoa moi thu

- Day cung la mot cuc do sai.
- Neu logic chi rat cuc bo va khong can listener ngoai, khong nhat thiet phai dung event.

## 18. Event static can than trong

- Event static tien cho he thong toan cuc.
- Nhung no de gay phu thuoc am va kho debug hon.
- Voi beginner, nen can than.

## 19. Dang ky va huy dang ky

- Trong Unity, `OnEnable`/`OnDisable` la mau rat pho bien.
- Dang ky khi object bat dau hoat dong.
- Huy dang ky khi object khong con hoat dong.

## 20. Vi sao quen huy dang ky nguy hiem

- Listener bi pha huy nhung event van giu tham chieu.
- Co the gay log loi, goi vao object khong hop le, hoac gay hanh vi ky la.

## 21. Event order

- Khi nhieu listener nghe cung mot event, ban can nghi den thu tu hop ly cua he thong.
- Tuy nhien, thuong listener nen duoc thiet ke sao cho it phu thuoc vao thu tu nay cang tot.

## 22. Event payload

- Payload la du lieu di kem event.
- Vi du `OnHealthChanged(current, max)`.
- Payload du thong tin se giup listener tu xu ly ma khong phai hoi them source.

## 23. Dat ten event de hieu

- Dat ten theo y nghia thay doi.
- `OnHealthChanged`
- `OnPlayerDied`
- `OnItemAdded`

Tranh ten mo ho nhu `OnUpdateData`.

## 24. Event va UI

- UI la listener ly tuong.
- Vi UI thuong chi can cap nhat khi du lieu doi.
- Event giup UI nhan du lieu dung luc.

## 25. Event va achievement

- Achievement system thuong rat hop voi observer.
- No nghe nhieu su kien khac nhau va cap nhat tien do.

## 26. Event va audio

- Audio system thuong khong nen bi goi truc tiep tung noi.
- Event giup phat am thanh theo su kien gameplay mot cach sach hon.

## 27. Event va save trigger

- Sau nay co the dung event cho auto save.
- Vi du `OnCheckpointReached`.
- Save system nghe su kien do va luu tien trinh.

## 28. Event va network

- Trong game online, event van huu ich trong client architecture.
- Nhung can hieu no khong tu dong thay cho networking logic.

## 29. Loi sai pho bien

- Event phat nhieu lan khong can thiet.
- Source vua phat event vua goi truc tiep UI.
- Listener qua lon, lam qua nhieu viec.
- Quen huy dang ky.

## 30. Tu duy rat quan trong

- Event la cach thong bao.
- Listener la noi phan ung.
- Source khong can biet ben ngoai co bao nhieu listener.
- Day chinh la cai dep cua observer pattern.

## 31. Tu kiem tra

1. Vi sao observer pattern hop cho UI?
2. Vi sao observer pattern hop cho achievement?
3. Khi nao khong can event?
4. Vi sao phai huy dang ky?
5. Vi sao event giup giam phu thuoc?
public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Image fillImage;

    private void OnEnable()
    {
        playerHealth.OnHealthChanged += HandleHealthChanged;
    }

    private void OnDisable()
    {
        playerHealth.OnHealthChanged -= HandleHealthChanged;
    }

    private void HandleHealthChanged(int current, int max)
    {
        fillImage.fillAmount = (float)current / max;
    }
}
```

## 9. OnEnable va OnDisable quan trong o dau

- Trong Unity, object co the bi tat bat nhieu lan.
- Neu dang ky event ma khong huy, ban de bi nghe trung hoac loi reference da mat.
- Day la loi kinh dien cua observer trong Unity.

## 10. Observer va UI

- UI la noi huong loi nhat khi dung observer.
- Diem, mau, vang, dan, kinh nghiem, level deu la du lieu doi theo su kien.
- UI chi nen phan ung khi co thay doi thuc su.
- Cach nay sach hon viec moi frame di doc tat ca gia tri.

## 11. Observer va achievement

- Achievement system thuong la listener tu nhien.
- No nghe su kien diet quai, nhat vat pham, song sot, hoan thanh man.
- Nhu vay gameplay code khong can biet tung achievement cu the.
- Chi can phat su kien dung cho.

## 12. Observer va audio

- Khi enemy chet, audio system co the phat am thanh.
- Khi nhan vat tang cap, audio system co the phat tieng chuong.
- He thong audio nghe event giup gameplay sach hon.

## 13. Observer va save system

- Khi coin thay doi, UI cap nhat ngay.
- Save system co the danh dau rang du lieu da doi.
- Den thoi diem phu hop thi save.
- Nguon gameplay khong can biet ai se luu, ai se ve UI.

## 14. Observer va state machine AI

- Khi enemy chet, `EnemyBrain` co the phat su kien `OnEnemyDied`.
- Score system nghe va cong diem.
- Loot spawner nghe va tha vat pham.
- Quest system nghe va dem so quai da diet.
- Day la ung dung thuc chien rat manh.

## 15. Observer va object pooling

- Khi hit effect can hien, mot listener co the lay effect tu pool.
- Nguon su kien chi thong bao vi tri va loai va cham.
- Listener xu ly pooling rieng.
- Ket qua la logic va hieu ung duoc tach ra dep hon.

## 16. Event argument nen co y nghia

- Khong nen phat event mo ho neu can du lieu cu the.
- Vi du `OnHealthChanged(int current, int max)` tot hon event khong thong tin.
- Vi du `OnEnemyDied(Enemy enemy)` co the huu ich hon chi la mot bool.
- Muc tieu la listener nhan du du lieu de tu xu ly.

## 17. Khong nen lam observer qua mo ho ngay tu dau

- Beginner nen bat dau voi event cu the va de doc.
- Khong can tao mot event bus tong quat qua som neu chua can.
- Muc tieu la giam ket dinh, khong phai tao kien truc phuc tap vo ich.

## 18. Polling va event

- Polling: moi frame hoi "mau co doi chua?"
- Event: chi khi mau doi moi thong bao.
- Event thuong hieu qua va de dien dat y dinh hon cho nhieu bai toan.
- Tuy nhien polling van co cho dung trong mot so tinh huong lien tuc.

## 19. Quan he giua observer va MonoBehaviour lifecycle

- Dang ky event trong `OnEnable`.
- Huy dang ky trong `OnDisable`.
- Lay reference trong `Awake` hoac Inspector.
- Day la mau cuc pho bien can thuoc long khi lam Unity.

## 20. Tranh phu thuoc nguoc sai huong

- `PlayerHealth` khong nen goi truc tiep `HealthBarUI.SetValue` neu co the tranh.
- Vi khi do gameplay dang biet qua nhieu ve UI.
- Observer giup dao chieu su phu thuoc: UI chu dong nghe gameplay.

## 21. Nhieu listener cho mot su kien

- Day la diem rat dep cua observer.
- Mot su kien co the phuc vu nhieu he thong.
- UI, audio, achievement, quest, analytics deu co the cung nghe.
- Nguon phat khong can them code moi cho tung listener.

## 22. Event chain can duoc giu ro rang

- Su kien co the kich tiep su kien khac.
- Neu dung qua da, luong du lieu co the kho theo doi.
- Beginner nen giu event chain ngan va dat ten ro nghia.
- Khi debug, in log tai diem phat event la rat huu ich.

## 23. Loi thuong gap cua nguoi moi

- Quen huy dang ky event.
- Dang ky nhieu lan tren cung listener.
- De UI biet qua nhieu ve gameplay class.
- Tao event qua tong quat khien kho doc.
- Dung event cho van de ma goi ham truc tiep de hieu hon.

## 24. Checklist khi event khong chay

- Listener co dang bat khong?
- Da dang ky event chua?
- Su kien co duoc phat that khong?
- Reference nguon event co dung object khong?
- Listener co huy dang ky som qua khong?
- Co loi Console nao chan flow khong?

## 25. Bai tap tu hoc

- Tao `PlayerHealth` phat `OnHealthChanged`.
- Tao `HealthBarUI` nghe va cap nhat thanh mau.
- Tao `AchievementSystem` nghe su kien nhat coin.
- Tao `EnemyDeathNotifier` phat su kien khi enemy chet.
- Tao `ScoreSystem` nghe su kien do de cong diem.

## 26. Cau hoi tu kiem tra

- Observer pattern giam ket dinh nhu the nao?
- Vi sao UI rat hop voi event?
- Vi sao can huy dang ky trong `OnDisable`?
- Khi nao goi ham truc tiep de hieu hon event?
- Observer co the ket hop voi pooling, save, AI ra sao?

## 27. Ket noi tong ket giai doan

- Observer pattern giup game phan ung theo su kien.
- State machine giup AI co cau truc.
- Save system giu tien trinh.
- Pooling giu hieu nang on dinh.
- UI va animation giup game de hieu va song dong.
- Tat ca ket hop lai thanh nen tang cua mot game Unity sach va de mo rong.
