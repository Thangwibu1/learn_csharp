# Mo rong chi tiet: Input System

## 1. Input la cau noi giua nguoi choi va game

- Game logic co hay den dau cung vo nghia neu nguoi choi khong dieu khien duoc.
- Input la cach game nhan lenh tu ban phim, chuot, tay cam, man hinh cam ung.
- Trong giai doan dau, muc tieu la hieu dong du lieu input vao gameplay.

## 2. Input khong chi la doc phim

- Input bao gom y dinh cua nguoi choi.
- Bam phim sang trai nghia la muon di chuyen trai.
- Bam Space nghia la muon nhay.
- Bam chuot trai co the la tan cong.
- Dung can chuyen tu muc do "bam phim" sang muc do "hanh dong".

## 3. Input truc tiep va action

- Input truc tiep la doc phim cu the.
- Action la nghiep vu gameplay nhu `Move`, `Jump`, `Attack`, `Pause`.
- Neu tach duoc hai lop nay, du an de mo rong hon.
- Sau nay doi phim hoac ho tro tay cam se de hon nhieu.

## 4. Kieu input co ban nguoi moi hay dung

- `GetKey`
- `GetKeyDown`
- `GetKeyUp`
- `GetAxis`
- `GetAxisRaw`
- Chuot, vi tri con tro, nut chuot

## 5. GetKey, GetKeyDown, GetKeyUp khac nhau ra sao

- `GetKey` dung khi phim dang duoc giu.
- `GetKeyDown` chi dung o frame phim vua duoc bam xuong.
- `GetKeyUp` chi dung o frame phim vua duoc tha ra.
- Nhay thuong dung `GetKeyDown`.
- Di chuyen giu phim thuong dung `GetKey` hoac axis.

## 6. Axis co y nghia gi

- Axis cho gia tri lien tuc theo mot truc.
- Vi du ngang trai phai, doc len xuong.
- `GetAxisRaw` thuong tra ve gia tri sac net hon nhu -1, 0, 1.
- `GetAxis` co the mem hon do co noi suy.
- Game di chuyen don gian thuong bat dau bang axis ngang doc.

## 7. Update la noi doc input phu hop

- Input can duoc doc theo frame.
- `Update` la noi phu hop nhat cho viec nay.
- Neu dung vat ly, ban doc input trong `Update` roi ap dung vao rigidbody trong `FixedUpdate`.
- Day la quy tac thuc dung rat nen nho.

## 8. Tach doc input va thuc hien hanh dong

- Script A doc input.
- Script B nhan gia tri va dieu khien movement.
- Script C nhan lenh tan cong.
- Cach nay giup logic sach hon.
- Khi chuyen qua input moi, phan gameplay it bi anh huong.

## 9. Vi du doc input don gian

```csharp
using UnityEngine;

public class SimpleInputReader : MonoBehaviour
{
    public float Horizontal { get; private set; }
    public bool JumpPressed { get; private set; }

    private void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        JumpPressed = Input.GetKeyDown(KeyCode.Space);
    }

    private void LateUpdate()
    {
        JumpPressed = false;
    }
}
```

- Script nay gom input thanh du lieu de he thong khac dung.

## 10. Input va movement

- Input khong nhat thiet tu di chuyen object.
- Input chi can noi: nguoi choi muon di trai hay phai.
- Script movement moi quyet dinh di chuyen bang transform hay rigidbody.
- Day la cach tach trach nhiem de hieu va de sua.

## 11. Input va animation

- Animation co the can biet nhan vat dang chay hay dung yen.
- Gia tri input hoac van toc co the duoc gui sang animator.
- Nhung script input khong nen tu biet chi tiet animation qua muc.
- Hay giu moi phan o dung vai tro cua no.

## 12. Input va UI

- Khi mo pause menu, input gameplay thuong can bi khoa hoac giam tac dung.
- UI co input rieng nhu bam nut, chon menu.
- Nguoi moi hay gap loi vua mo menu vua van di chuyen nhan vat.
- Dieu nay xay ra khi khong phan tach trang thai input.

## 13. Input va state game

- Game co the o trang thai choi, pause, cutscene, game over.
- Moi trang thai co tap input hop le khac nhau.
- Khi hieu state machine, ban se de kiem soat input hon.
- Day la ly do input va state machine lien ket rat tot voi nhau.

## 14. Input cu va Input System moi

- Unity co he thong input cu va he thong Input System moi.
- O muc beginner, hieu nguyen ly quan trong hon viec thuoc ten API.
- Dung he nao, ban van can tach `intent` khoi `gameplay response`.
- Do la tu duy co gia tri lau dai.

## 15. Vi du di chuyen bang input va transform

```csharp
using UnityEngine;

public class TransformMover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical, 0f).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
```

## 16. Vi du doc input cho vat ly

```csharp
using UnityEngine;

public class PhysicsMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D body;
    private float horizontalInput;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        body.linearVelocity = new Vector2(horizontalInput * moveSpeed, body.linearVelocity.y);
    }
}
```

- Muc dich cua vi du la cho thay input doc trong `Update`, vat ly xu ly trong `FixedUpdate`.

## 17. Input buffer va beginner thinking

- Co luc nguoi choi bam nhay rat sat luc tiep dat.
- Neu he thong kho, lenh co the bi bo lo.
- Input buffer la cach giu lenh trong mot khoang rat ngan.
- Day la khai niem nang cao hon, nhung nen biet ton tai trong game hanh dong.

## 18. Input va frame rate

- Vi input duoc doc theo frame, frame rate anh huong toi cam giac bam phim.
- Neu game giat, input cung cam thay tre.
- Day la ly do toi uu va gian logic cung quan trong.

## 19. Input va object pooling

- Input ban dan co the goi he thong ban.
- He thong ban co the lay dan tu pool thay vi instantiate moi lan.
- Day la moi lien he hay gap trong game shoot em up, action va tower defense.

## 20. Input va save system

- Input co the mo menu save, load, pause.
- Tuy nhien script doc input khong nen tu no luu game truc tiep neu co the tach lop.
- No nen goi hanh dong cap cao hon hoac phat su kien.

## 21. Input va observer pattern

- Khi bam nut tang cap, he thong gameplay doi so lieu.
- Sau do UI co the duoc cap nhat bang event thay vi polling.
- Input la dau vao, event la co che thong bao dau ra.
- Hai thu nay thuong ket hop rat dep.

## 22. Doi phim va ho tro nhieu thiet bi

- Neu code logic gan chat voi `KeyCode.Space`, viec doi phim se kho hon.
- Neu logic dung action `Jump`, ban co the map Space, nut A tay cam, nut tren man hinh cung mot y nghia.
- Day la ly do tu duy action rat quan trong.

## 23. Khoa input tam thoi

- Khi nhan vat bi choang, input movement co the bi khoa.
- Khi dang xem cutscene, input tan cong co the bi bo qua.
- Khi mo menu, input gameplay co the bi tat.
- Dat quy tac ro rang cho viec nay se tranh bug kho chiu.

## 24. Loi thuong gap cua nguoi moi

- Doc input trong `FixedUpdate` mot cach tuy y.
- Ghep chat input voi tat ca logic gameplay.
- Vua mo menu vua van di chuyen nhan vat.
- Dung `GetKey` khi dang can `GetKeyDown`.
- Khong tach input va vat ly.

## 25. Checklist khi input khong dung

- Script co dang bat khong?
- Ham `Update` co dang chay khong?
- Co dung ten axis khong?
- Co dung API down hay hold khong?
- Co menu hay state nao dang khoa input khong?
- Co loi Console nao dang ngan script chay khong?

## 26. Bai tap tu hoc

- Tao script cho nhan vat di chuyen trai phai.
- Them nhay bang `GetKeyDown`.
- Them nut `Escape` de mo pause menu.
- Khi pause, khoa movement.
- Tach script input va script movement thanh hai file.

## 27. Cau hoi tu kiem tra

- Khac nhau giua `GetKey` va `GetKeyDown`?
- Vi sao doc input trong `Update`?
- Vi sao nen tach input thanh action?
- Vi sao pause menu co the gay xung dot input?
- Input reader va movement script nen chia trach nhiem the nao?

## 28. Ket noi voi giai doan hoan thien game

- Khi len giai doan sau, input se lien quan manh toi UI, animation, pooling, save system va state machine.
- Neu nen tang input duoc tach ro tu bay gio, cac bai sau se de hieu hon rat nhieu.
