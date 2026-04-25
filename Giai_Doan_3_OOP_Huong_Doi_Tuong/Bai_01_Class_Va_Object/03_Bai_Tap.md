# Bai tap Bai 1: Class va Object

## Muc tieu bai tap

- On lai khai niem class.
- Phan biet class va object.
- Thuc hanh tao field va method.
- Tap doc code va mo ta hanh vi cua object.
- Lam quen voi cach chia bai tap tu de den kho.

## Cach hoc de hieu nhanh

- Doc ten class va tu do doan vai tro cua no.
- Nhin vao field de biet object dang luu trang thai gi.
- Nhin vao method de biet object co the lam gi.
- Thu tao nhieu object khac nhau tu cung mot class.
- Tu hoi: moi object co du lieu rieng hay dung chung?

## Mau tu duy truoc khi code

1. Doi tuong nay la ai?
2. Doi tuong nay can nho nhung gi?
3. Doi tuong nay lam duoc nhung gi?
4. Du lieu nao la field?
5. Hanh dong nao la method?

## Bai 1

Yeu cau:
Tao class `Enemy` co cac field `Name`, `Health`, `Damage`.

Goi y:
Them method `ShowInfo()` de in ra thong tin.

Tu kiem tra:
Ban da tao duoc object `Enemy goblin = new Enemy();` chua?

Loi thuong gap:
Quen dau cham phay sau moi khai bao field.

## Bai 2

Yeu cau:
Tao 2 object tu class `Enemy` va gan gia tri khac nhau.

Goi y:
Dung `goblin.Name = "Goblin";` va `orc.Name = "Orc";`.

Tu kiem tra:
Khi in ra, 2 object co thong tin khac nhau khong?

Loi thuong gap:
Gan du lieu cho nham object.

## Bai 3

Yeu cau:
Them method `Attack()` cho class `Enemy`.

Goi y:
Chi can `Console.WriteLine(Name + " tan cong");`.

Tu kiem tra:
Ban da goi `goblin.Attack();` duoc chua?

Loi thuong gap:
Khai bao method ngoai class.

## Bai 4

Yeu cau:
Them method `TakeDamage(int amount)` de tru mau.

Goi y:
Dung `Health -= amount;`.

Tu kiem tra:
Sau khi goi method, gia tri `Health` co giam khong?

Loi thuong gap:
Viet sai ten bien `amount`.

## Bai 5

Yeu cau:
Khong cho `Health` nho hon 0.

Goi y:
Sau khi tru mau, kiem tra `if (Health < 0)`.

Tu kiem tra:
Neu enemy co 10 mau va nhan 50 sat thuong, ket qua co bang 0 khong?

Loi thuong gap:
Dat dieu kien nguoc, lam gia tri khong duoc chinh lai.

## Bai 6

Yeu cau:
Tao class `Player` co `Name`, `Health`, `Mana` va method `CastSpell()`.

Goi y:
`CastSpell()` co the in ten phep va mana con lai.

Tu kiem tra:
Ban co the tao nhieu object `Player` tu cung mot class khong?

Loi thuong gap:
Nhap sai kieu du lieu cho `Mana`.

## Bai 7

Yeu cau:
Tao class `Weapon` co `Name`, `Damage`, `Price`.

Goi y:
Sau do tao 3 object vu khi khac nhau.

Tu kiem tra:
Ban co in duoc thong tin tung vu khi theo tung dong khong?

Loi thuong gap:
Quen khoi tao object truoc khi gan field.

## Bai 8

Yeu cau:
Tao class `Potion` co method `Use()`.

Goi y:
Method co the chi in `Su dung binh mau`.

Tu kiem tra:
Ban da thay object co the vua luu du lieu vua co hanh vi chua?

Loi thuong gap:
Nham lan giua field va method.

## Bai 9

Yeu cau:
Tao class `Quest` co `Title`, `Description`, `RewardGold`.

Goi y:
Them method `ShowQuest()`.

Tu kiem tra:
Ban co the tao 2 quest co noi dung khac nhau khong?

Loi thuong gap:
Dat ten field qua mo ho.

## Bai 10

Yeu cau:
Tao class `Chest` co `IsOpened` va method `Open()`.

Goi y:
Neu da mo roi thi in thong bao khac.

Tu kiem tra:
Goi `Open()` 2 lan co cho ket qua khac nhau khong?

Loi thuong gap:
Khong cap nhat `IsOpened` sau khi mo ruong.

## Bai 11

Yeu cau:
Tao class `Pet` co `Name`, `Level`, `Hunger` va method `Feed()`.

Goi y:
`Feed()` lam giam `Hunger`.

Tu kiem tra:
Trang thai pet co thay doi sau moi lan goi method khong?

Loi thuong gap:
Khong in ra gia tri sau khi thay doi.

## Bai 12

Yeu cau:
Tao class `BankAccount` co `Owner`, `Balance`, `Deposit()`, `Withdraw()`.

Goi y:
Kiem tra neu rut qua so du thi thong bao loi.

Tu kiem tra:
Ban da dung class de dong goi mot doi tuong ngoai game chua?

Loi thuong gap:
Tru tien truoc khi kiem tra so du.

## Bai 13

Yeu cau:
Tao class `Student` co `Name`, `Age`, `Score` va method `ShowResult()`.

Goi y:
In them xep loai dua tren `Score`.

Tu kiem tra:
Ban co the tao 5 hoc sinh va in ket qua tung nguoi khong?

Loi thuong gap:
Dung nham toan tu so sanh trong xep loai.

## Bai 14

Yeu cau:
Tao class `Car` co `Brand`, `Speed` va method `Accelerate()`.

Goi y:
Moi lan goi method, tang toc do len 10.

Tu kiem tra:
Du lieu object co duoc giu lai sau nhieu lan goi method khong?

Loi thuong gap:
Khai bao bien cuc bo thay vi field.

## Bai 15

Yeu cau:
Tao class `Book` co `Title`, `Author`, `PageCount`.

Goi y:
Them method `Describe()`.

Tu kiem tra:
Ban co the mo ta tai sao sach la object khong?

Loi thuong gap:
Quen tao object truoc khi goi method.

## Bai 16

Yeu cau:
Tao class `Skill` co `Name`, `ManaCost`, `Cooldown`.

Goi y:
Them method `Use()` chi in thong tin su dung.

Tu kiem tra:
Ban da thay class la ban thiet ke, object la ban the cu the chua?

Loi thuong gap:
Dat trung ten class va ten bien gay kho doc.

## Bai 17

Yeu cau:
Tao class `MonsterSpawner` co `SpawnCount` va method `Spawn()`.

Goi y:
Moi lan spawn thi tang `SpawnCount`.

Tu kiem tra:
Sau 3 lan goi `Spawn()`, gia tri co bang 3 khong?

Loi thuong gap:
Gan `SpawnCount = 1` moi lan goi method.

## Bai 18

Yeu cau:
Tao class `LightSwitch` co `IsOn`, `TurnOn()`, `TurnOff()`.

Goi y:
In thong bao ro trang thai hien tai.

Tu kiem tra:
Ban co hieu trang thai object duoc luu trong field khong?

Loi thuong gap:
Khong cap nhat `IsOn` dung luc.

## Bai 19

Yeu cau:
Tao class `ShopItem` co `Name`, `Price`, `Stock`.

Goi y:
Them method `SellOne()` de giam ton kho.

Tu kiem tra:
Neu stock bang 0 thi co ban tiep khong?

Loi thuong gap:
Khong kiem tra du lieu truoc khi giam.

## Bai 20

Yeu cau:
Tao class `Door` co `IsLocked`, `Open()`, `Lock()`, `Unlock()`.

Goi y:
Neu cua dang khoa thi `Open()` khong thanh cong.

Tu kiem tra:
Ban da ket hop du lieu va logic trong cung mot object chua?

Loi thuong gap:
Bo qua mot trong cac trang thai cua doi tuong.

## Bai 21

Yeu cau:
Tao class `Timer` co `CurrentTime` va method `Tick()`.

Goi y:
Moi lan tick tang them 1.

Tu kiem tra:
Sau 10 lan tick, object co luu duoc 10 khong?

Loi thuong gap:
Dung bien tam thay vi field.

## Bai 22

Yeu cau:
Tao class `Recipe` co `Name`, `IngredientCount`, `Cook()`.

Goi y:
In thong bao mon an dang duoc nau.

Tu kiem tra:
Ban co phan biet object trong lap trinh va vat the that khong?

Loi thuong gap:
Tao qua nhieu class voi it y nghia.

## Bai 23

Yeu cau:
Tao class `Team` co `Name`, `MemberCount`, `AddMember()`.

Goi y:
Moi lan them thanh vien thi tang `MemberCount`.

Tu kiem tra:
Ban co nhan ra class la khuon mau de tao nhieu doi tuong giong cau truc chua?

Loi thuong gap:
Khong gom hanh vi lien quan vao cung class.

## Bai 24

Yeu cau:
Tao class `Counter` co field `Value` va method `Increase()`, `Reset()`.

Goi y:
Thu tao 2 object counter de thay chung doc lap nhau.

Tu kiem tra:
Tang object A co lam doi object B khong?

Loi thuong gap:
Kien thuc object chua vung nen nham voi bien thong thuong.

## Bai 25

Yeu cau:
Tao class `MusicPlayer` co `SongName`, `IsPlaying`, `Play()`, `Stop()`.

Goi y:
In thong bao khi bat dau va dung phat nhac.

Tu kiem tra:
Ban co the mo ta trang thai va hanh vi cua object nay bang loi van khong?

Loi thuong gap:
Method khong lam thay doi field nao nen object it y nghia.

## Goi y giai nhanh

- Chon danh tu de dat ten class.
- Chon thong tin can nho de dat field.
- Chon dong tu de dat ten method.
- Khoi tao object bang tu khoa `new`.
- Dung dau cham de truy cap field va method.

## Tu kiem tra tong hop

- Ban co giai thich duoc class la khuon mau khong?
- Ban co giai thich duoc object la mot the hien cu the khong?
- Ban co biet khi nao nen tao field?
- Ban co biet khi nao nen tao method?
- Ban co biet mot class co the tao ra nhieu object khong?
- Ban co biet moi object co du lieu rieng khong?

## Troubleshooting

Van de:
Bao loi `; expected`.
Huong xu ly:
Kiem tra cuoi moi dong khai bao field va cau lenh.

Van de:
Bao loi `does not contain a definition`.
Huong xu ly:
Kiem tra ten field hoac method co viet dung chinh ta khong.

Van de:
Bao loi object null.
Huong xu ly:
Xac nhan ban da khoi tao object bang `new` truoc khi dung.

Van de:
Code chay nhung ket qua khong doi.
Huong xu ly:
Kiem tra ban co dang sua dung object hay dang tao object moi.

## Mini project 1

De bai:
Tao mo phong nhan vat game co ten, mau, nang luong va 3 hanh dong.

Yeu cau:
- Co class `Player`.
- Co method `Attack()`.
- Co method `Heal()`.
- Co method `ShowStatus()`.

Goi y:
Hay tao 2 object player va so sanh trang thai sau vai hanh dong.

## Mini project 2

De bai:
Tao he thong quan ly sach don gian.

Yeu cau:
- Co class `Book`.
- Co class `Reader`.
- `Reader` co method `BorrowBook()`.
- In ra thong tin ai dang muon sach nao.

Goi y:
Chua can dung danh sach, chi can 1 vai object la du.

## Mini project 3

De bai:
Tao mo phong cua hang game.

Yeu cau:
- Co class `ShopItem`.
- Co class `ShopKeeper`.
- Co method ban hang.
- Co method hien thi gia.

Goi y:
Thu tao 5 vat pham de thay su loi ich cua class.

## Cau hoi tu luan

1. Tai sao class duoc goi la khuon mau?
2. Tai sao object duoc goi la the hien?
3. Vi sao cung mot class lai tao duoc nhieu object?
4. Tai sao field va method nen o cung mot class khi chung phuc vu cung doi tuong?
5. Trong game, ban se tao nhung class nao truoc tien?

## Thu thach mo rong

- Them constructor cho mot class bat ky.
- Them method nhan tham so.
- Them method thay doi nhieu field mot luc.
- Tao 10 object tu cung mot class.
- Tu viet 1 bai giai thich class va object bang ngon ngu cua ban.

## Checklist hoan thanh

- Da tao class.
- Da tao object.
- Da gan du lieu cho object.
- Da goi method.
- Da thay duoc moi object co du lieu rieng.
- Da lam it nhat 10 bai.
- Da thu 1 mini project.
- Da tu kiem tra va sua loi.
