# Mo rong chi tiet: Vat ly 2D va 3D

## 1. Vat ly trong Unity dung de lam gi

- Vat ly giup object co the roi, va cham, bi day, bi can, trung dan.
- Day la he thong mo phong tuong tac chuyen dong.
- Game khong bat buoc phai dung vat ly moi noi.
- Nhung rat nhieu co che gameplay se can no.

## 2. 2D va 3D la hai he thong tach rieng

- Unity co he vat ly 2D va he vat ly 3D rieng.
- `Rigidbody2D` di cung `Collider2D`.
- `Rigidbody` di cung `Collider` 3D.
- Khong nen tron lan 2D va 3D tren cung mot co che neu ban chua biet ro minh dang lam gi.
- Day la loi nguoi moi gap rat nhieu.

## 3. Hai manh co ban: Rigidbody va Collider

- `Collider` xac dinh hinh dang va cham.
- `Rigidbody` cho biet object co tham gia mo phong vat ly hay khong.
- Thuong can ca hai de co va cham dong.
- Tuy truong hop, object tinh co the chi can collider.

## 4. Collider la gi

- Collider la vung ma engine dung de tinh va cham.
- No khong nhat thiet giong chinh xac hinh anh 100 phan tram.
- Thuong ta dung dang don gian de de tinh va on dinh hon.
- Vi du `BoxCollider2D`, `CircleCollider2D`, `CapsuleCollider2D`.
- Trong 3D co `BoxCollider`, `SphereCollider`, `CapsuleCollider`, `MeshCollider`.

## 5. Rigidbody la gi

- Rigidbody giup object co khoi luong, van toc va phan ung voi luc.
- Khi co rigidbody, object co the bi trong luc tac dong.
- Object co the duoc day, nem, roi.
- Neu khong co rigidbody, object thuong duoc xem la tinh hon trong he vat ly.

## 6. Static, Dynamic, Kinematic

- `Dynamic` la vat the chiu mo phong vat ly day du.
- `Kinematic` thuong duoc dieu khien bang code, khong bi luc vat ly day theo cach thong thuong.
- `Static` thuong la moi truong co dinh nhu tuong, san.
- Hieu ba vai tro nay se giup ban chon dung loai object.

## 7. Trigger va Collision khac nhau

- `Collision` la va cham vat ly that, object bi chan, day nhau.
- `Trigger` la vung phat hien cham vao nhung khong can chan vat ly.
- Trigger rat hop cho pickup, checkpoint, vung bao dong AI, cua vao khu vuc.

## 8. Vi du trigger de nhat coin

- Coin co `Collider2D` bat `Is Trigger`.
- Player di vao vung do.
- `OnTriggerEnter2D` duoc goi.
- Script cong diem roi tat coin hoac tra ve pool.
- Day la vi du co ban va rat de hieu cho nguoi moi.

## 9. Vi du collision voi san

- Player co `Rigidbody2D` va `Collider2D`.
- San co `Collider2D`.
- Khi player roi xuong san, va cham xay ra.
- He vat ly giup player dung tren san thay vi roi xuyen qua.

## 10. Luc, van toc va di chuyen

- Ban co the di chuyen bang cach gan `velocity`.
- Ban co the them luc bang `AddForce`.
- Ban co the di chuyen kinematic bang cach phu hop voi rigidbody.
- Moi cach cho cam giac game khac nhau.
- Game platformer, top down va puzzle co the chon cach khac nhau.

## 11. FixedUpdate va vat ly

- Vat ly duoc cap nhat theo buoc co dinh.
- Vi vay logic lien quan rigidbody thuong dat trong `FixedUpdate`.
- Neu ban thao tac vat ly trong `Update`, ket qua co the khong deu.
- Day la quy tac nen hoc som.

## 12. Vi sao khong nen keo rigidbody bang transform tuy tien

- Rigidbody dang duoc he vat ly quan ly.
- Neu ban sua `transform.position` moi frame mot cach tuy y, ban dang chen ngang mo phong vat ly.
- Ket qua co the gay giat, hut vao tuong, bo lo va cham.
- Neu object la vat ly, hay uu tien cach di chuyen phu hop voi rigidbody.

## 13. Layer collision matrix

- Unity cho phep quy dinh layer nao va cham voi layer nao.
- Day giup toi uu va giam su co logic.
- Vi du dan cua player khong can va cham voi player.
- Vi du UI khong can tham gia vat ly.
- Dat layer som se lam du an gon hon.

## 14. Material vat ly

- Trong 2D va 3D co vat lieu vat ly de dieu chinh ma sat va do nay.
- Vi du bong co the nay nhieu.
- Vi du nhan vat can ma sat cao hon de khong truot.
- Nguoi moi nen biet ton tai khai niem nay du chua can dao sau.

## 15. Raycast la gi

- Raycast la ban mot tia ao de kiem tra co gi tren duong di cua no.
- Rat huu ich cho phat hien mat dat, ban sung, AI nhin thay muc tieu.
- Raycast khong thay the moi va cham, nhung la cong cu cuc manh.

## 16. Ground check trong game nhay

- Nhieu game can biet nhan vat co dang dung tren mat dat khong.
- Mot cach la dung trigger nho duoi chan.
- Mot cach khac la dung raycast xuong duoi.
- Hieu cach nay se giup tao co che nhay on dinh.

## 17. Continuous va Discrete collision

- Vat di qua nhanh co the xuyen qua vat khac neu kiem tra qua thua.
- Unity co che do phat hien va cham de giam van de nay.
- Day thuong gap voi dan bay nhanh.
- Neu gap loi xuyen muc tieu, day la diem can nghi toi.

## 18. 2D va 3D khong goi cung callback

- 2D dung `OnCollisionEnter2D`, `OnTriggerEnter2D`.
- 3D dung `OnCollisionEnter`, `OnTriggerEnter`.
- Nguoi moi thuong viet nham ten ham va thac mac vi sao no khong chay.
- Day la loi rat pho bien.

## 19. Vi du script trigger 2D

```csharp
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        Debug.Log("Player picked coin");
        gameObject.SetActive(false);
    }
}
```

## 20. Vi du day rigidbody 2D

```csharp
using UnityEngine;

public class PushBody : MonoBehaviour
{
    [SerializeField] private float moveForce = 5f;

    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        body.AddForce(Vector2.right * horizontal * moveForce);
    }
}
```

## 21. Rigidbody khong phai luc nao cung can

- Nhieu object trang tri khong can rigidbody.
- Nhieu UI object khong can rigidbody.
- Spawn point, manager, marker logic cung khong can.
- Dung dung cho dung no se project gon va ro hon.

## 22. Collider khong can phai chinh xac toi tung pixel

- Collider qua phuc tap co the gay ton chi phi va kho on dinh.
- Thuong uu tien hinh don gian va hop ly theo gameplay.
- Trong game, cam giac choi quan trong hon viec va cham phai y hinh 100 phan tram.

## 23. Physics va animation

- Nhan vat co the co animation chay nhay.
- Nhung vi tri va cham van can theo he vat ly hoac theo script movement.
- Neu animation chi la hinh anh, co the khong can de no truc tiep quyet dinh va cham.
- Can tach phan nhin thay va phan tinh toan khi can.

## 24. Physics va input

- Input thuong doc trong `Update`.
- Gia tri input co the luu tam.
- Sau do `FixedUpdate` dung gia tri do de tac dong rigidbody.
- Day la cau truc pho bien va de hieu cho nguoi moi.

## 25. Physics va object pooling

- Vien dan, hieu ung, enemy co the dung pool.
- Khi tra object ve pool, can reset van toc, trang thai trigger, bo dem neu can.
- Neu khong, object tai su dung co the mang du lieu cu.
- Day la moi lien he quan trong giua vat ly va pooling.

## 26. Loi thuong gap cua nguoi moi

- Tron `Rigidbody` voi `Rigidbody2D`.
- Viet nham `OnTriggerEnter` thay vi `OnTriggerEnter2D`.
- Quen collider nen khong co va cham.
- Kéo rigidbody bang transform moi frame.
- Khong dung `FixedUpdate` cho vat ly.
- Khong dat layer hop ly nen object va cham lung tung.

## 27. Checklist khi va cham khong chay

- Hai object co collider chua?
- Dung 2D hay 3D co dong bo khong?
- Co it nhat mot ben co rigidbody khong?
- Trigger da bat dung chua?
- Layer co cho phep tuong tac khong?
- Callback ten dung chua?

## 28. Bai tap tu hoc

- Tao player co `Rigidbody2D` va `BoxCollider2D`.
- Tao san co `BoxCollider2D`.
- Cho player roi xuong san.
- Them coin trigger de nhat.
- Them raycast kiem tra mat dat.
- Thu doi layer de dan khong trung player.

## 29. Cau hoi tu kiem tra

- Khac nhau giua collider va rigidbody?
- Trigger va collision khac nhau o dau?
- Vi sao vat ly thuong dat trong `FixedUpdate`?
- Vi sao 2D va 3D khong nen tron lan?
- Khi nao nen dung raycast thay vi cho va cham tu nhien?

## 30. Ket noi voi bai input

- Sau khi hieu vat ly, ban se thay input khong chi la doc phim.
- Input can duoc dua vao dung cho de dieu khien transform, rigidbody va animation mot cach on dinh.

## 31. Vat ly khong phai luc nao cung can choi that

- Co game dieu khien bang transform van on.
- Co game can vat ly day du de co cam giac day, roi, nay.
- Chon dung muc vat ly la mot quyet dinh thiet ke gameplay, khong chi la ky thuat.

## 32. Collider la mo hinh gameplay, khong phai mo hinh my thuat

- Nguoi moi hay co gang cho collider khop tung chi tiet.
- Nhung game can su on dinh va de kiem soat.
- Collider don gian thuong tot hon cho gameplay.
- Day la bai hoc thuc dung rat quan trong.

## 33. Rigidbody la cach giao quyen cho engine vat ly

- Khi gan rigidbody, ban noi voi Unity rang object nay duoc mo phong.
- Tu luc do, ban nen ton trong quy tac cua he vat ly.
- Neu vua giao engine, vua tu keo bang transform lien tuc, no se roi vao xung dot.

## 34. Trigger la cong cu gameplay cuc manh

- Trigger khong can chan van de van co gia tri lon.
- Rat nhieu co che game hay nhat dung trigger.
- Nhat vat pham, mo cua, doi nhac nen, bat cutscene, tinh diem checkpoint.
- Day la cach nghi vuot ra ngoai va cham vat ly thuần.

## 35. Layer giup game it ro hon

- Khong phai object nao cung nen va cham voi nhau.
- Layer giup ta khai bao y dinh mot cach tap trung.
- Khi project lon, day la vat bat ly than gian de tranh bug kho chiu.

## 36. Raycast la mat cua gameplay

- Ban co the xem raycast nhu cach game "nhin" ra phia truoc, phia duoi, theo huong sung.
- No don gian nhung rat manh.
- Nguoi moi nen tap raycast som vi no xuat hien o rat nhieu bai toan.

## 37. Ground check la bai hoc debug rat hay

- Neu nhan vat nhay khong dung, nhiem vu dau tien la xem ground check co tin cay khong.
- Day la bai toan ket hop physics, callback, raycast va state.
- Hoc ky diem nay se giup ban do vat ly tot hon.

## 38. Continuous collision la nhac ban ve gioi han mo phong

- Engine vat ly khong phai vo han chi tiet.
- Vat qua nhanh co the xuyen.
- Day nhac ban rang mo phong luon co gioi han va can cau hinh hop ly.

## 39. Scene vat ly tot thuong rat de doan

- Ground la ground.
- Trigger duoc dat ten ro.
- Layer duoc tach ro.
- Collider khong qua ky la.
- Physics material duoc dung co chu dich.
- Cang ro rang, cang de debug.

## 40. Tong ket bo sung

- Vat ly Unity la su ket hop cua hinh dang, khoi luong, luc va quy tac tuong tac.
- Hoc vat ly tot la hoc cach dat object vao he thong nay mot cach dung muc dich.
