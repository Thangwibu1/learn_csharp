# Mo rong chi tiet: Transform

## 1. Vi sao Transform rat quan trong

- Moi GameObject deu co `Transform`.
- Day la component co ban nhat trong Unity.
- Neu khong hieu transform, ban rat kho dieu khien object.
- Di chuyen, xoay, phong to thu nho deu bat dau tu day.

## 2. Ba gia tri cot loi

- `Position` la vi tri.
- `Rotation` la goc xoay.
- `Scale` la kich thuoc.
- Day la ba manh thong tin co mat gan nhu moi luc khi lam game.

## 3. Position nghia don gian la object dang o dau

- Trong game 2D, thuong quan tam X va Y nhieu nhat.
- Trong game 3D, ca X, Y, Z deu quan trong.
- X thuong la trai phai.
- Y thuong la len xuong.
- Z thuong la truoc sau trong khong gian 3D.

## 4. Rotation cho biet object dang quay huong nao

- Trong 2D, ta hay xoay quanh truc Z.
- Trong 3D, xoay co the xay ra quanh X, Y, Z.
- Xoay giup nhan vat quay mat, sung huong ve muc tieu, camera doi goc nhin.
- Rotation trong Unity thuong hien bang Euler trong Inspector.
- Ben duoi, Unity quan ly theo dang khac de tranh mot so van de tinh toan.

## 5. Scale la kich thuoc tuong doi

- `Scale` 1,1,1 thuong la kich thuoc goc.
- Scale 2,2,2 thuong co nghia gap doi.
- Scale am co the dung de lat hinh trong 2D.
- Tuy nhien scale am cung co the gay nham huong va va cham neu dung bat can.
- Nguoi moi nen can than voi scale khong dong deu.

## 6. Local va world khac nhau nhu the nao

- `World position` la vi tri trong toan bo the gioi.
- `Local position` la vi tri tuong doi voi object cha.
- Neu object khong co cha, local va world thuong giong nhau.
- Neu object la con cua object khac, hai gia tri co the khac rat nhieu.

## 7. Vi du ve parent child

- Nhan vat la object cha.
- Thanh kiem la object con.
- Khi nhan vat di chuyen, thanh kiem di theo.
- Khi nhan vat xoay, thanh kiem xoay theo.
- Day la suc manh cua local transform.

## 8. Vi sao nguoi moi hay nham local position

- Thay object con co toa do nho nhung lai nam xa goc the gioi.
- Ly do la vi tri do la tuong doi voi object cha.
- Khi debug, hay hoi: minh dang nhin local hay world?
- Day la cau hoi cuc ky quan trong.

## 9. Transform trong Inspector

- Inspector cho sua so truc tiep X, Y, Z.
- Cach nay de dung khi can dat chinh xac.
- Trong `Scene`, ban co the keo gizmo truc quan hon.
- Hai cach nay bo sung cho nhau.

## 10. Cong cu Move Rotate Scale

- `Move Tool` giup keo object theo truc.
- `Rotate Tool` giup xoay object bang tay cam tron.
- `Scale Tool` giup doi kich thuoc.
- Ban nen tap vua keo tren scene, vua xem gia tri trong Inspector.
- Cach nay giup gan ket thao tac va con so.

## 11. Huong cua object

- `transform.right` la huong phai cua object.
- `transform.up` la huong len cua object.
- `transform.forward` la huong truoc cua object trong 3D.
- Khi object xoay, cac huong nay thay doi theo.
- Day rat huu ich de ban dan, di chuyen, raycast theo huong mat.

## 12. Di chuyen object bang code

- Ban co the gan truc tiep `transform.position`.
- Ban co the cong them vao position de tao chuyen dong.
- Ban co the dung `Translate` de dich chuyen.
- Moi cach co ngu canh phu hop rieng.
- Neu object dung vat ly, can can nhac dung API vat ly thay vi chinh transform truc tiep.

## 13. Xoay object bang code

- Ban co the dat `transform.rotation`.
- Ban co the dung `Rotate` de quay them mot goc.
- Trong 2D, lat nhan vat bang scale X am la cach pho bien.
- Trong 3D, thuong se xoay huong mat theo truc phu hop.

## 14. Scale co anh huong gi

- Scale thay doi hinh anh hien thi.
- Scale co the anh huong den collider theo cach khac nhau tuy loai.
- Scale cuc lon hoac cuc nho co the lam vat ly kho on dinh.
- Nguoi moi nen giu scale hop ly va nhat quan.

## 15. Tam quan trong cua he truc

- Unity dung he truc X, Y, Z.
- Trong 2D, game van ton tai trong khong gian 3 chieu cua engine.
- Chi la ban thuong co dinh nhieu gia tri hon.
- Hieu he truc giup ban doc scene khong bi roi.

## 16. Pivot va center

- Trong scene, cong cu co the thao tac theo `Pivot` hoac `Center`.
- `Pivot` la diem goc cua object.
- `Center` la tam cua nhom duoc chon.
- Khac biet nay quan trong khi xoay nhieu object cung luc.

## 17. Global va local handle

- Cong cu co the hien truc theo huong the gioi hoac theo huong object.
- `Global` giu truc co dinh theo the gioi.
- `Local` quay theo object.
- Khi object da xoay, hai che do nay cho cam giac thao tac rat khac.

## 18. Transform va animation

- Animation thuong thay doi position, rotation, scale theo thoi gian.
- Dieu nay co nghia transform la noi giao nhau giua logic va bieu dien.
- Neu logic code va animation cung sua mot gia tri, can biet cai nao uu tien.
- Day la nguon loi pho bien.

## 19. Transform va vat ly

- Object co `Rigidbody` khong nen bi keo position tuy tien moi frame.
- Vi vat ly can tu mo phong chuyen dong.
- Neu ban vua dung vat ly vua sua transform truc tiep, ket qua co the giat cuc.
- Bai vat ly sau se giai thich ky hon diem nay.

## 20. Transform va UI

- UI dung `RectTransform`, la bien the phu hop voi bo cuc giao dien.
- No van mang y tuong vi tri, xoay, kich thuoc.
- Nhung UI con co anchor, pivot va kich thuoc theo man hinh.
- Day la ly do UI can hoc them mot tang nua.

## 21. Vi du di chuyen don gian

```csharp
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 delta = new Vector3(horizontal, 0f, 0f);
        transform.position += delta * speed * Time.deltaTime;
    }
}
```

- Doan tren dich object theo truc X.
- `Time.deltaTime` giup toc do on dinh theo thoi gian.
- Cac bai sau se tach input va movement ro hon.

## 22. Vi du huong mat

- Nhan vat co the di sang phai va scale X = 1.
- Khi di sang trai, scale X = -1.
- Cach nay de va pho bien trong 2D side scrolling.
- Tuy nhien neu object co con phuc tap, can test ky de tranh lat sai.

## 23. Reset transform khi can

- Nguoi moi thuong keo object lung tung roi kho tra ve mac dinh.
- `Reset` transform dua vi tri ve 0, xoay 0, scale 1.
- Day la thao tac nen biet de don dep object.

## 24. Dat object theo nhom

- Ban co the tao object cha rong de gom mot cum object.
- Vi du mot `EnemyGroup` chua nhieu quai con.
- Khi do di chuyen object cha, ca nhom di theo.
- Cach nay giup scene gon hon va de quan ly hon.

## 25. Loi thuong gap

- Nham local va world.
- Sua sai truc Y khi dang muon sua Z.
- Scale am gay lat ngoai y muon.
- Keo object co rigidbody bang transform gay giat.
- Xoay sai trục trong 3D.

## 26. Cach tu debug van de transform

- Kiem tra object co dang la con cua ai khong.
- Xem gia tri local hay world.
- Xem object co animation dang ghi de position khong.
- Xem object co rigidbody dang dieu khien khong.
- Xem camera co nhin thay object khong.

## 27. Tu duy thiet ke tot

- Transform chi nen chua thong tin khong gian.
- Logic di chuyen o script movement.
- Logic mau o health.
- Logic tan cong o attack.
- Tach nhu vay de moi script de hieu hon.

## 28. Bai tap tu hoc

- Tao mot object `Player` va di chuyen no sang trai phai.
- Tao mot object `Sword` la con cua `Player`.
- Xoay `Player` va quan sat `Sword`.
- Chuyen doi giua local va global handle de thay su khac biet.
- Thu reset transform va quan sat ket qua.

## 29. Cau hoi tu kiem tra

- Vi sao moi object deu co transform?
- Khac biet giua local position va world position?
- Khi nao scale am co ich?
- Vi sao object dung vat ly khong nen sua transform tuy y?
- `transform.right` khac gi truc X the gioi?

## 30. Ket noi voi bai scripting

- Sau khi hieu transform, ban se de hieu hon khi script thay doi vi tri trong `Update`.
- Bai `MonoBehaviour` se noi cach Unity goi cac ham vong doi song de tac dong len transform va object.

## 31. Meo quan sat trong scene

- Chon object roi thay doi tung truc mot cach co y thuc.
- Vua doi gia tri, vua nhin hinh trong `Scene` va `Game`.
- Thu gan object vao parent roi tach ra de cam nhan local va world.
- Day la cach hoc transform nhanh nhat vi no rat truc quan.

## 32. Tong ket nhanh

- `Position` tra loi object o dau.
- `Rotation` tra loi object huong nao.
- `Scale` tra loi object to nho ra sao.
- `Local` lien quan den cha.
- `World` lien quan den ca the gioi.
- Nam vung 5 diem nay, ban da co nen tang transform rat chac.
