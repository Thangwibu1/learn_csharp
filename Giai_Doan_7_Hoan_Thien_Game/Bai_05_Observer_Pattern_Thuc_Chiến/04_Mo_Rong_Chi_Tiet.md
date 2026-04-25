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
