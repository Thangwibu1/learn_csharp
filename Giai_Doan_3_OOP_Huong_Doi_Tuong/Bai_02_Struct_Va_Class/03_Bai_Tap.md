# Bai tap Bai 2: Struct va Class

## Muc tieu bai hoc

- Hieu struct sao chep theo gia tri.
- Hieu class sao chep theo tham chieu.
- Biet khi nao nen chon struct.
- Biet khi nao nen chon class.
- Tap quan sat hanh vi cua bien sau khi gan.

## Cau hoi dan nhap

1. Neu sao chep mot diem toa do, ban muon ban sao doc lap hay dung chung?
2. Neu sao chep mot nhan vat game, ban muon la mot nhan vat moi hay chi la them mot bien tro cung doi tuong?
3. Du lieu nay nho gon hay phuc tap?
4. Du lieu nay co can danh tinh rieng khong?
5. Du lieu nay co bi thay doi thuong xuyen khong?

## Bai 1

Yeu cau:
Tao `struct Position2D` gom `X` va `Y`.

Goi y:
Them method `Show()` hoac override `ToString()`.

Tu kiem tra:
Ban co in duoc `(10, 20)` khong?

Loi thuong gap:
Quen gan gia tri cho field truoc khi doc.

## Bai 2

Yeu cau:
Tao 2 bien `a` va `b`, gan `b = a`, sau do sua `b`.

Goi y:
In ca `a` va `b` truoc va sau khi sua.

Tu kiem tra:
`a` co giu nguyen khong?

Loi thuong gap:
Chi in 1 bien nen khong thay su khac nhau.

## Bai 3

Yeu cau:
Tao `class NPC` co `Name` va `Level`.

Goi y:
Them method `ShowInfo()`.

Tu kiem tra:
Ban da khoi tao object bang `new NPC()` chua?

Loi thuong gap:
Quen `new` nen bien chua tro den object nao.

## Bai 4

Yeu cau:
Gan `npcB = npcA`, sau do sua `npcB.Name`.

Goi y:
In thong tin cua ca hai bien.

Tu kiem tra:
`npcA.Name` co doi theo khong?

Loi thuong gap:
Ky vong class hoat dong giong struct.

## Bai 5

Yeu cau:
Viet doan giai thich bang loi van: vi sao `struct` va `class` cho ket qua khac nhau khi gan?

Goi y:
Dung cum tu `gia tri` va `tham chieu`.

Tu kiem tra:
Ban co the giai thich cho nguoi moi hoc khong?

Loi thuong gap:
Nho may moc ma khong hieu ban chat.

## Bai 6

Yeu cau:
Tao `struct DamageInfo` gom `Amount` va `Critical`.

Goi y:
Thu gan bien moi roi doi `Amount`.

Tu kiem tra:
Bien cu co thay doi khong?

Loi thuong gap:
Quen in gia tri truoc khi sua.

## Bai 7

Yeu cau:
Tao `class Inventory` co `ItemCount`.

Goi y:
Gan 2 bien tro cung mot object inventory.

Tu kiem tra:
Sua `ItemCount` qua bien nay co anh huong bien kia khong?

Loi thuong gap:
Khong nhan ra ca hai bien dang tro cung object.

## Bai 8

Yeu cau:
Tao ham nhan `Position2D` theo gia tri va sua ben trong ham.

Goi y:
In gia tri ngoai ham truoc va sau khi goi.

Tu kiem tra:
Tai sao ngoai ham khong doi?

Loi thuong gap:
Khong tach ro ket qua trong ham va ngoai ham.

## Bai 9

Yeu cau:
Tao ham nhan `ref Position2D` va sua ben trong ham.

Goi y:
Dung tu khoa `ref` ca luc khai bao va khi goi.

Tu kiem tra:
Ngoai ham co doi chua?

Loi thuong gap:
Quen viet `ref` o mot trong hai noi.

## Bai 10

Yeu cau:
Tao ham nhan `NPC npc` va doi `npc.Name` ben trong ham.

Goi y:
Sau khi goi ham, in object ben ngoai.

Tu kiem tra:
Tai sao object doi duoc du ten ham khong co `ref`?

Loi thuong gap:
Nham lan giua doi noi dung object va doi bien tham chieu.

## Bai 11

Yeu cau:
Tao ham nhan `NPC npc`, ben trong ham gan `npc = new NPC()`.

Goi y:
Xem object ngoai ham co doi khong.

Tu kiem tra:
Ban co giai thich duoc vi sao bien ngoai ham van cu khong?

Loi thuong gap:
Khong phan biet bien tham chieu va object.

## Bai 12

Yeu cau:
Lap lai bai 11 nhung dung `ref NPC npc`.

Goi y:
Luc nay cho phep doi chinh bien tham chieu ben ngoai.

Tu kiem tra:
Object ngoai ham co bi doi sang object moi khong?

Loi thuong gap:
Van quen `ref` o luc goi ham.

## Bai 13

Yeu cau:
Tao `struct ColorRGB` co `R`, `G`, `B`.

Goi y:
Thu tao 3 mau va so sanh sau khi sao chep.

Tu kiem tra:
Vi sao struct phu hop cho mau sac?

Loi thuong gap:
Dung class du chi can 3 gia tri nho.

## Bai 14

Yeu cau:
Tao `class Guild` co `Name` va `MemberCount`.

Goi y:
Thu tao them bien thu hai tro cung guild.

Tu kiem tra:
Khi doi member count co anh huong ca hai bien khong?

Loi thuong gap:
Khong in ket qua sau moi thay doi.

## Bai 15

Yeu cau:
Tao bang so sanh `struct` va `class` bang chinh loi cua ban.

Goi y:
Co the so sanh theo 5 tieu chi:
Kich thuoc du lieu.
Kieu sao chep.
Muc dich dung.
Danh tinh doi tuong.
Tinh doc lap sau khi gan.

Tu kiem tra:
Ban co the dua vi du thuc te cho tung dong trong bang khong?

Loi thuong gap:
Viet dinh nghia qua ngan va thieu vi du.

## Bai 16

Yeu cau:
Tao `struct Rect` co `Width`, `Height` va method `Area()`.

Goi y:
Sao chep sang bien khac va doi `Width`.

Tu kiem tra:
Dien tich cua bien goc co doi khong?

Loi thuong gap:
Khong goi method de kiem chung ket qua.

## Bai 17

Yeu cau:
Tao `class Mission` co `Title` va `IsDone`.

Goi y:
Gan 2 bien cung tro den mot mission.

Tu kiem tra:
Danh dau xong qua mot bien thi bien kia co thay doi khong?

Loi thuong gap:
Bo qua viec in ra de xac nhan.

## Bai 18

Yeu cau:
Tao `struct Point3D` co `X`, `Y`, `Z`.

Goi y:
Thu truyen vao ham `MoveUp(Point3D p)`.

Tu kiem tra:
Vi sao diem ngoai ham khong doi neu khong dung `ref`?

Loi thuong gap:
Nham ket qua khi doc console qua nhanh.

## Bai 19

Yeu cau:
Tao `class Boss` co `Name`, `Phase`.

Goi y:
Them method `NextPhase()`.

Tu kiem tra:
Gan 2 bien cung boss, goi `NextPhase()` qua mot bien thi bien kia hien gi?

Loi thuong gap:
Khong hieu 2 bien dang chia se cung trang thai.

## Bai 20

Yeu cau:
Tao 1 danh sach `List<Position2D>` va thu lay mot phan tu ra bien tam de sua.

Goi y:
Sau do in lai list.

Tu kiem tra:
Phan tu trong list co doi khong?

Loi thuong gap:
Cho rang sua bien tam se sua truc tiep phan tu trong list.

## Bai 21

Yeu cau:
Tao 1 danh sach `List<NPC>` va lay mot phan tu ra bien tam de sua ten.

Goi y:
In lai list sau khi sua.

Tu kiem tra:
Tai sao truong hop nay list lai doi?

Loi thuong gap:
Ap dung may moc quy tac cua struct cho class.

## Bai 22

Yeu cau:
Viet mot doan ket luan: `Position`, `Color`, `Rect` nen la struct hay class?

Goi y:
Giai thich bang tinh gon nho va tinh gia tri.

Tu kiem tra:
Ban co biet dua tren ngu canh thay vi hoc thuoc khong?

Loi thuong gap:
Chon theo cam tinh ma khong noi ly do.

## Bai 23

Yeu cau:
Viet mot doan ket luan: `Player`, `Enemy`, `Quest`, `Shop` nen la struct hay class?

Goi y:
Giai thich bang tinh phuc tap, hanh vi, va danh tinh.

Tu kiem tra:
Ban co thay nhung doi tuong nay can duoc chia se tham chieu khong?

Loi thuong gap:
Danh dong struct vi nghi nhe hon ma khong phu hop logic.

## Bai 24

Yeu cau:
Tao vi du tu do ban tu nghi ra de chung minh `struct` doc lap sau khi gan.

Goi y:
Co the dung nhiet do, toa do, diem so, kich thuoc.

Tu kiem tra:
Vi du cua ban co de hieu cho nguoi khac khong?

Loi thuong gap:
Chon vi du qua phuc tap ngay tu dau.

## Bai 25

Yeu cau:
Tao vi du tu do ban tu nghi ra de chung minh `class` chia se object sau khi gan.

Goi y:
Co the dung tai khoan, cua, nhan vat, nhiem vu.

Tu kiem tra:
Ban co biet phan biet `2 bien` va `2 object` khong?

Loi thuong gap:
Khong mo ta ro ban dang tao object moi hay chi tao bien moi.

## Goi y troubleshooting

Van de:
Bao loi `Use of unassigned local variable` voi struct.
Huong xu ly:
Gan gia tri day du cho cac field truoc khi doc.

Van de:
Object class bi null.
Huong xu ly:
Khoi tao bang `new` truoc khi truy cap field hay method.

Van de:
Khong thay su khac nhau giua class va struct.
Huong xu ly:
Hay in gia tri truoc va sau moi thao tac gan, truyen ham, sua field.

Van de:
Quen `ref`.
Huong xu ly:
Them `ref` ca khi khai bao ham va khi goi ham.

## Tu kiem tra tong hop

- Ban co mo ta duoc `value type` bang loi van khong?
- Ban co mo ta duoc `reference type` bang loi van khong?
- Ban co phan biet viec sua noi dung object va doi bien tham chieu khong?
- Ban co biet vi sao `struct` phu hop cho du lieu nho gon khong?
- Ban co biet vi sao `class` phu hop cho doi tuong phuc tap khong?

## Mini project 1

Ten du an:
Ban do mini 2D.

Yeu cau:
- Dung `struct Position2D` cho toa do.
- Dung `class Player` cho nhan vat.
- Dung `class MapObject` cho vat can.
- In ra vi tri sau moi lan di chuyen.

Muc tieu:
Cam nhan ro cai nao nen la struct, cai nao nen la class.

## Mini project 2

Ten du an:
He thong sat thuong.

Yeu cau:
- Dung `struct DamageInfo` de chua sat thuong.
- Dung `class Enemy` de chua mau va ten.
- Viet ham tan cong.
- In ket qua truoc va sau tan cong.

Muc tieu:
Tap tach du lieu gia tri khoi doi tuong lon hon.

## Mini project 3

Ten du an:
Quan ly diem checkpoint.

Yeu cau:
- Dung `struct Checkpoint` cho vi tri.
- Dung `class SaveSlot` cho thong tin luu game.
- Thu sao chep checkpoint va save slot.
- Giai thich su khac nhau.

Muc tieu:
Truc quan hoa hanh vi sao chep.

## Cau hoi tu luan

1. Tai sao khong phai du lieu nao cung nen la class?
2. Tai sao khong phai du lieu nao cung nen la struct?
3. Khi nao nen can nhac `ref`?
4. Dieu gi de gay nham lan nhat cho nguoi moi hoc?
5. Ban se giai thich chu de nay cho ban hoc nhu the nao?

## Checklist hoan thanh

- Da tao it nhat 3 struct.
- Da tao it nhat 3 class.
- Da thu sao chep struct.
- Da thu sao chep class.
- Da thu truyen struct vao ham.
- Da thu truyen class vao ham.
- Da lam it nhat 1 mini project.
- Da tu viet phan tong ket bang loi cua minh.
