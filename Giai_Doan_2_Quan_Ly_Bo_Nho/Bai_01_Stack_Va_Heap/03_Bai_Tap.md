# Bai tap Bai 1: Stack va Heap

## Muc tieu bai hoc

- Phan biet duoc value type va reference type trong tinh huong don gian.
- Quan sat duoc hanh vi sao chep du lieu va sao chep tham chieu.
- Biet cach doc output de tu rut ra ket luan thay vi hoc thuoc may moc.
- Hinh thanh thoi quen dat cau hoi ve bo nho khi debug loi.
- Luyen ky nang giai thich bang loi cua chinh minh.

## Cach hoc de dat hieu qua cao

- Chay tung doan code ngan va du doan ket qua truoc khi bam run.
- Ghi lai du doan cua ban vao vo hoac file note.
- Sau khi chay, doi chieu ket qua that voi du doan.
- Neu sai, dung sua code ngay. Hay viet ly do vi sao ban doan sai.
- Moi bai tap nen co phan ket luan bang 2 den 4 cau ngan.

## Bai 1: Sao chep bien int

Yeu cau:

- Tao bien `score = 100`.
- Tao bien `copiedScore = score`.
- Doi `copiedScore` thanh `200`.
- In ra ca hai bien.

Cau hoi goi y:

- Bien nao thay doi?
- Bien nao khong thay doi?
- Dieu nay noi len dieu gi ve value type?

Muc tieu quan sat:

- Ban nhan ra rang `int` duoc sao chep theo gia tri.

## Bai 2: Sao chep bien double

Yeu cau:

- Tao `double mana = 75.5`.
- Gan `double copiedMana = mana`.
- Tang `copiedMana` len `100.5`.
- In ket qua.

Tu danh gia:

- Neu `mana` khong doi, ban da hieu quy tac co ban.

## Bai 3: Dung struct de thu nghiem

Yeu cau:

- Tao `struct Position` gom `X` va `Y`.
- Tao `positionA` va sao chep sang `positionB`.
- Sua `positionB.X` va `positionB.Y`.
- In ca hai bien.

Goi y:

- Struct thuong la value type.
- Hay tu viet `ToString()` de output ro rang.

## Bai 4: Tao class don gian

Yeu cau:

- Tao `class Enemy` co `Name` va `Health`.
- Tao mot object `enemyA`.
- Gan `enemyB = enemyA`.
- Sua `enemyB.Health`.
- In ca hai bien.

Cau hoi goi y:

- Vi sao `enemyA` cung doi?
- Ban dang copy object hay copy tham chieu?

## Bai 5: Thu doi ten object

Yeu cau:

- Tu bai 4, doi them `enemyB.Name`.
- In lai du lieu.
- Viet ket luan ngan ve viec hai bien dang cung nhin vao mot object.

## Bai 6: Sua object va doi bien tro toi object moi

Yeu cau:

- Tao `enemyA` va `enemyB = enemyA`.
- Dau tien, sua `enemyB.Health`.
- Sau do, gan `enemyB = new Enemy()` va dat gia tri moi.
- In ra `enemyA` va `enemyB` sau moi buoc.

Muc tieu:

- Phan biet duoc hai hanh dong khac nhau:
- Sua du lieu ben trong object.
- Doi bien tro toi object khac.

## Bai 7: Mang int

Yeu cau:

- Tao mang `int[] scores = { 10, 20, 30 }`.
- Tao `copyScores = scores`.
- Sua `copyScores[0]`.
- In ra hai bien.

Cau hoi:

- Mang la value type hay reference type?
- Phan tu `int` ben trong mang la gi?

## Bai 8: Mang object class

Yeu cau:

- Tao mang chua 2 object `Enemy`.
- Gan sang mot bien mang thu hai.
- Sua mot phan tu thong qua bien mang thu hai.
- In toan bo mang.

Muc tieu:

- Nhan ra reference co the xuat hien o nhieu tang.

## Bai 9: Truyen int vao ham

Yeu cau:

- Viet ham nhan `int score`.
- Ben trong ham, tang score len 50.
- In score trong ham va ngoai ham.

Ket luan mong doi:

- Bien ngoai ham giu nguyen neu ban chi truyen value type theo mac dinh.

## Bai 10: Truyen object vao ham

Yeu cau:

- Viet ham nhan `Enemy enemy`.
- Trong ham, giam `Health`.
- In ket qua trong va ngoai ham.

Cau hoi:

- Tai sao object ben ngoai doi?

## Bai 11: Kiem tra null co ban

Yeu cau:

- Tao bien `Enemy? enemy = null`.
- Kiem tra null truoc khi dung.
- Neu null thi tao object moi.
- In ket qua.

Muc tieu:

- Hieu rang bien reference co the khong tro toi object nao.

## Bai 12: Tao nhieu object trong vong lap

Yeu cau:

- Dung vong lap tao 20 object `Enemy`.
- Them vao `List<Enemy>`.
- In ten va mau.

Thao luan:

- Tai sao viec nay hop ly trong bai hoc?
- Khi nao viec tao object lien tuc trong game loop co the can can nhac?

## Bai 13: Theo doi dia chi tham chieu bang mot cach gian tiep

Yeu cau:

- Tao hai bien class cung tro toi mot object.
- Dung `ReferenceEquals` de kiem tra.
- In ket qua `true` hoac `false`.

Goi y:

- Bai nay giup ban nhin ro "cung object" mot cach truc tiep hon.

## Bai 14: So sanh bang va so sanh cung object

Yeu cau:

- Tao hai object `Enemy` co cung du lieu nhung tao rieng biet.
- Dung `ReferenceEquals` de kiem tra.
- In ket qua.

Cau hoi:

- Cung du lieu co dong nghia la cung object khong?

## Bai 15: Struct long trong class

Yeu cau:

- Tao `struct Stats` gom `Attack` va `Defense`.
- Tao `class Hero` co `Stats`.
- Tao object hero, gan sang alias, sua `alias.Stats`.
- In ket qua.

Muc tieu:

- Hieu tac dong khi value type nam ben trong reference type.

## Bai 16: Class long trong class

Yeu cau:

- Tao `class Inventory` va `class Hero` co thuoc tinh `Inventory`.
- Tao alias, sua `Inventory.Capacity` qua alias.
- In ket qua.

Cau hoi:

- Tai sao khi object long ben trong cung la class thi du lieu lai cung bi chia se?

## Bai 17: Viet bang so sanh stack va heap

Yeu cau:

- Lap bang 2 cot: `Stack` va `Heap`.
- Dien it nhat 8 dong so sanh.

Goi y cac dong co the dung:

- Toc do truy cap thuong thay the nao.
- Du lieu thuong nam o dau.
- Bien cuc bo thuong lien quan the nao.
- Object tao bang `new` thuong di ve dau.
- Loai du lieu nao thuong gan voi noi nao.

## Bai 18: Giai thich bang vi du doi thuong

Yeu cau:

- Viet 1 doan ngan so sanh stack voi mot ban ghi chu tam thoi.
- Viet 1 doan ngan so sanh heap voi nha kho chua do vat.
- Khong can dung dung 100 phan tram ky thuat, chi can de hieu.

## Bai 19: Debug mot bug chia se du lieu

Tinh huong:

- Ban tao `playerTemplate`.
- Sau do gan `player1 = playerTemplate` va `player2 = playerTemplate`.
- Sua `player1.Health` thi `player2.Health` cung doi.

Nhiem vu:

- Giai thich nguyen nhan.
- Dua ra 2 cach xu ly.
- Viet code minh hoa cho moi cach.

## Bai 20: Viet ham clone thu cong

Yeu cau:

- Tao `class Enemy` co `Name`, `Health`, `Damage`.
- Viet ham `CloneEnemy` tra ve object moi.
- Sua ban sao va kiem tra ban goc con nguyen.

Muc tieu:

- Hieu rang muon doc lap thi phai tao object moi.

## Bai 21: Bai tap dien output

Doan code:

```csharp
int a = 5;
int b = a;
b = 9;
Console.WriteLine(a);
Console.WriteLine(b);
```

Yeu cau:

- Viet output.
- Giai thich tung dong bang loi ngan gon.

## Bai 22: Bai tap dien output voi class

Doan code:

```csharp
Enemy a = new Enemy();
a.Health = 100;
Enemy b = a;
b.Health = 1;
Console.WriteLine(a.Health);
Console.WriteLine(b.Health);
```

Yeu cau:

- Viet output.
- Giai thich vi sao ket qua nhu vay.

## Bai 23: Bai tap dung sai

Danh dau dung hoac sai:

- `int` la reference type.
- `class` thuong tao object tren heap.
- Sao chep mot bien class luon tao object moi.
- `struct` thuong sao chep theo gia tri.
- Hai bien cung tro mot object co the sua chung du lieu.
- Mang luon la value type.

## Bai 24: Viet 5 cau tu khoa

Yeu cau:

- Tu viet 5 cau, moi cau phai co 1 tu khoa sau:
- `stack`
- `heap`
- `value type`
- `reference type`
- `null`

## Bai 25: Phan tich code nguoi khac

Yeu cau:

- Tim mot doan code cu cua ban co dung class.
- Chi ra 1 cho co nguy co chia se du lieu ngoai y muon.
- Viet lai cach dat ten bien de nhin ro hon.

## Bai 26: Mini project nho 1

Ten de tai:

- Quan ly nhan vat va tui do.

Yeu cau:

- Tao `class Character` co `Name`, `Health`, `Inventory`.
- Tao `class Inventory` co `Capacity`.
- Tao 2 bien cung tro toi mot nhan vat.
- Tao 1 bien tro toi ban sao doc lap cua nhan vat.
- In ra de phan biet 2 truong hop.

Can nop:

- Code.
- 5 dong giai thich.

## Bai 27: Mini project nho 2

Ten de tai:

- Luu snapshot tran dau.

Yeu cau:

- Tao `struct BattleSnapshot` gom `Time`, `Damage`, `Combo`.
- Tao bien goc va 2 bien sao chep.
- Sua tung bien va in ket qua.

Muc tieu:

- Nhan manh hanh vi sao chep value type.

## Bai 28: Mini project nho 3

Ten de tai:

- Danh sach quai vat trong man choi.

Yeu cau:

- Tao `List<Enemy>`.
- Them 5 object.
- Gan mot phan tu trong danh sach cho bien tam.
- Sua bien tam va in lai danh sach.

Thao luan:

- Tai sao danh sach thay doi?

## Bai 29: Tu danh gia muc do hieu bai

Tu cham theo thang 1 den 5:

- Toi phan biet duoc `int` va `class` khi sao chep.
- Toi giai thich duoc vi sao alias lam doi object goc.
- Toi hieu duoc can than voi `null`.
- Toi biet khi nao can clone object.
- Toi nhan ra viec tao object qua nhieu co the la van de.

## Bai 30: Viet tong ket cuoi bai

Yeu cau:

- Viet it nhat 10 dong tong ket.
- Trong do phai co:
- 3 dieu ban da hieu ro hon.
- 2 dieu ban con thay mo ho.
- 2 vi du thuc te trong lap trinh game hoac app.
- 1 ke hoach on lai bai vao ngay mai.

## Goi y giai nhanh

- Hay doi ten bien thanh `original`, `copy`, `alias`, `clone` de de nhin.
- Luon in gia tri truoc va sau khi sua.
- Voi class, them `ToString()` se giup output ro hon.
- Neu thay ket qua la ca hai bien cung doi, nghi ngay den reference.
- Neu thay chi mot bien doi, nghi ngay den value copy hoac object doc lap.

## Loi thuong gap

- Quen dung `new` khi tao object class.
- In object ma khong ghi de `ToString()` nen output kho doc.
- Nham giua viec sua thuoc tinh va doi bien sang object moi.
- Quen kiem tra `null`.
- Cho rang mang int la value type vi ben trong la int.
- Viet ket luan qua mo ho, khong noi ro vi sao.
- Chi nhin output ma khong doi chieu voi du doan ban dau.
- Copy object long object nhung chi copy lop ngoai.

## Cach tu kiem tra truoc khi chuyen bai

- Ban da chay tat ca bai co code chua?
- Moi bai co output ro rang chua?
- Ban co viet ket luan ngan sau moi bai quan trong khong?
- Ban co it nhat 2 bai dung `struct` va 2 bai dung `class` khong?
- Ban co 1 bai minh hoa `null` khong?
- Ban co 1 bai minh hoa clone object khong?
- Ban co 1 bai minh hoa mang hoac list khong?

## Cau hoi tu van dap

1. Vi sao nguoi moi hoc thuong nham giua stack va heap?
2. Vi sao khong nen hoc theo kieu "class luon o heap" mot cach qua cung nhac?
3. Khi debug bug chia se du lieu, dau tien ban can kiem tra dieu gi?
4. Vi sao dat ten bien theo vai tro giup hieu bo nho de hon?
5. Trong mot game, object nao thuong duoc chia se va object nao nen tach rieng?

## Muc mo rong neu ban hoc nhanh

- Tim hieu them ve `record struct` va `record class`.
- Thu so sanh `ArrayList` voi `List<int>`.
- Thu viet them vi du co `Dictionary<string, Enemy>`.
- Thu doc ve shallow copy va deep copy.
- Thu viet demo co object long nhau 2 hoac 3 tang.

## Ket thuc bai tap

Neu ban lam duoc phan lon bai trong file nay, ban da co nen tang rat tot de hoc tiep bai `tham tri va tham chieu` va `boxing/unboxing`.
