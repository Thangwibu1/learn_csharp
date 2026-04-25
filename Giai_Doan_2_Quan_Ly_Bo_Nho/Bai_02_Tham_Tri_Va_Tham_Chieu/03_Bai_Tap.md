# Bai tap Bai 2: Tham tri va Tham chieu

## Muc tieu

- Hieu ro hai khai niem tham tri va tham chieu qua thuc hanh co chu dich.
- Biet phan tich hanh vi truyen tham so vao ham.
- Nhan ra bug chia se du lieu trong class va collection.
- Biet cach tao ban sao doc lap thay vi vo tinh dung chung object.

## Cach lam bai

- Moi bai nen ghi du doan output truoc.
- Sau khi chay, ghi output that.
- So sanh 2 ket qua va viet mot cau ket luan.
- Dung ten bien ro rang: `original`, `copy`, `alias`, `clone`, `shared`.

## Bai 1: float la tham tri

Yeu cau:

- Tao `float speed = 3.5f`.
- Gan `float copiedSpeed = speed`.
- Sua `copiedSpeed`.
- In ca hai bien.

Tu danh gia:

- Ban co thay bien goc giu nguyen khong?

## Bai 2: decimal la tham tri

Yeu cau:

- Tao `decimal price = 120.000m`.
- Sao chep va sua ban sao.
- In ket qua.

Muc tieu:

- Cuong co quy tac cho nhieu value type khac nhau.

## Bai 3: struct CurrencyPack

Yeu cau:

- Tao `struct CurrencyPack` co `Gold`, `Gem`.
- Tao bien goc va ban sao.
- Sua ban sao.
- In ket qua.

## Bai 4: class Item co Name

Yeu cau:

- Tao `class Item` co `Name`.
- Tao `itemA` va `itemB = itemA`.
- Sua `itemB.Name`.
- In ca hai bien.

## Bai 5: class Enemy co object long ben trong

Yeu cau:

- Tao `class Reward` co `Gold`.
- Tao `class Enemy` co `Name` va `Reward`.
- Tao alias va sua `Reward.Gold` thong qua alias.
- In ca hai bien.

Muc tieu:

- Hieu tham chieu co the long nhau.

## Bai 6: Truyen int vao ham

Yeu cau:

- Viet ham nhan `int amount`.
- Trong ham cong them 100.
- In trong va ngoai ham.

Ket luan mong doi:

- Gia tri ben ngoai khong doi.

## Bai 7: Truyen struct vao ham

Yeu cau:

- Viet ham nhan `CurrencyPack wallet`.
- Sua `wallet.Gold` trong ham.
- In trong va ngoai ham.

## Bai 8: Truyen class vao ham

Yeu cau:

- Viet ham nhan `Item item`.
- Doi `item.Name` trong ham.
- In truoc va sau khi goi ham.

## Bai 9: Doi tham chieu cuc bo trong ham

Yeu cau:

- Viet ham nhan `Item item`.
- Trong ham, gan `item = new Item()` roi dat ten moi.
- In trong va ngoai ham.

Cau hoi:

- Tai sao item ben ngoai khong doi thanh object moi?

## Bai 10: So sanh sua object va doi bien

Yeu cau:

- Tao 1 object `Item`.
- Truyen vao 2 ham:
- Ham 1 sua `Name`.
- Ham 2 gan tham chieu moi.
- So sanh output.

## Bai 11: Danh sach chua cung mot object

Yeu cau:

- Tao 1 object `Item sharedItem`.
- Them no 2 lan vao `List<Item>`.
- Sua ten thong qua phan tu thu hai.
- In danh sach.

## Bai 12: Tao hai object giong nhau nhung doc lap

Yeu cau:

- Tao 2 object `Item` voi cung `Name`.
- Sua object thu hai.
- In ket qua.

Ket luan:

- Giong du lieu khong dong nghia dung chung object.

## Bai 13: Viet ham clone Item

Yeu cau:

- Viet `CloneItem(Item source)`.
- Tra ve object moi co du lieu giong source.
- Sua clone va in clone cung source.

## Bai 14: Clone class long class

Yeu cau:

- Tao `class ItemInfo` co `Description`.
- Tao `class Item` co `Name` va `ItemInfo`.
- Viet clone day du sao chep ca `ItemInfo`.
- Kiem tra clone co doc lap that khong.

## Bai 15: Dien output 1

```csharp
int a = 10;
int b = a;
b = 5;
Console.WriteLine(a);
Console.WriteLine(b);
```

Yeu cau:

- Dien output.
- Giai thich bang 2 cau.

## Bai 16: Dien output 2

```csharp
Item a = new Item();
a.Name = "Kiem";
Item b = a;
b.Name = "Riu";
Console.WriteLine(a.Name);
Console.WriteLine(b.Name);
```

Yeu cau:

- Dien output.
- Giai thich bang 2 cau.

## Bai 17: Dien output 3

```csharp
void Change(Item item)
{
    item = new Item();
    item.Name = "Ao giap";
}
```

Yeu cau:

- Du doan `item` ben ngoai co doi khong.
- Giai thich vi sao.

## Bai 18: Bai dung sai

Danh dau dung hoac sai:

- Tham tri la copy du lieu.
- Tham chieu la copy ca object.
- Truyen class vao ham co the sua object goc.
- Truyen struct vao ham theo mac dinh co the sua bien goc ngay lap tuc.
- Clone nong va clone sau luon giong nhau.
- Alias la ten goi tot de nhac rang dang dung chung object.

## Bai 19: Viet bang so sanh

Yeu cau:

- Tao bang 3 cot:
- Tinh huong
- Hanh vi
- Ket luan

Can it nhat 10 dong.

Vi du tinh huong:

- Gan int sang bien moi.
- Gan class sang bien moi.
- Truyen struct vao ham.
- Truyen class vao ham.
- Doi thuoc tinh object.
- Doi bien tham chieu thanh object moi.

## Bai 20: Giai quyet bug khoi mau bi doi hang loat

Tinh huong:

- Ban co `enemyTemplate`.
- Trong vong lap ban gan `enemies[i] = enemyTemplate`.
- Sau do sua tung quai va thay tat ca thay doi giong nhau.

Yeu cau:

- Giai thich nguyen nhan.
- Viet code sai.
- Viet code dung.
- Viet bai hoc rut ra.

## Bai 21: Bug reward bi lan sang object khac

Tinh huong:

- 2 object `Enemy` khac nhau nhung cung dung chung `Reward`.
- Sua `Reward.Gold` cua object 1 thi object 2 cung doi.

Yeu cau:

- Giai thich.
- Dua ra cach clone sau.

## Bai 22: Mini project nho 1

Ten de tai:

- Quan ly vat pham trong cua hang.

Yeu cau:

- Tao `class Product`, `class ProductInfo`.
- Tao `struct PriceTag`.
- Minh hoa duoc 3 tinh huong:
- Copy `PriceTag`.
- Alias `Product`.
- Clone `Product` day du.

Can nop:

- Code.
- Output.
- 6 dong giai thich.

## Bai 23: Mini project nho 2

Ten de tai:

- Quan ly nhiem vu va phan thuong.

Yeu cau:

- Tao `class Quest`, `class Reward`.
- Tao `struct ProgressState`.
- Viet chuong trinh demo su khac nhau giua copy struct va alias class.

## Bai 24: Mini project nho 3

Ten de tai:

- Ho so nguoi choi.

Yeu cau:

- Tao `class PlayerProfile` co `Name`, `Inventory`, `Stats`.
- `Inventory` la class, `Stats` la struct.
- Tao alias va clone.
- In ket qua de so sanh phan nao bi chia se, phan nao doc lap.

## Bai 25: Goi y tu xay dung test bang tay

- Dat ten test theo kieu `Test_Copy_Int`, `Test_Alias_Class`.
- Moi test chi minh hoa 1 quy tac.
- Moi test phai co phan du doan output.
- Moi test phai co phan ket luan.

## Bai 26: Cau hoi tu luan ngan

1. Tai sao nguoi moi hoc hay noi "class la tham chieu" nhung van de bi nham?
2. Ban sao cua tham chieu la gi?
3. Tai sao clone nong co the chua du?
4. Trong ung dung thuc te, dau la dau hieu cho thay dang dung chung object ngoai y muon?
5. Ban se doi ten bien nhu the nao de tu bao ve minh khoi bug nay?

## Bai 27: Bai tap tim loi

Cho doan mo ta:

- Co 2 bien `questA` va `questB`.
- `questB = questA`.
- Sau do `questB.Reward.Gold += 100`.
- Nguoi hoc mong `questA` khong doi.

Nhiem vu:

- Chi ra ky vong sai nam o dau.
- Viet lai cach dung.

## Bai 28: Bai tap viet ghi nho 5 dong

Viet 5 dong, moi dong phai bat dau bang mot cum sau:

- `Toi biet rang tham tri...`
- `Toi biet rang tham chieu...`
- `Khi debug, toi se...`
- `Neu can doc lap, toi se...`
- `Mot bug de gap la...`

## Bai 29: Troubleshooting checklist

- Object co bi dung chung o nhieu noi khong?
- Ham nay sua thuoc tinh hay doi tham chieu?
- Class long class da duoc clone day du chua?
- Output da du ro de nhin object nao dang doi chua?
- Ban da kiem tra `ReferenceEquals` neu can chua?
- Ban da tao object moi hay chi gan alias?

## Bai 30: Tu cham muc do hieu bai

Cham tu 1 den 5:

- Toi hieu tham tri.
- Toi hieu tham chieu.
- Toi biet truyen class vao ham se xay ra gi.
- Toi biet truyen struct vao ham se xay ra gi.
- Toi biet clone object long object.
- Toi biet doc output de tim bug chia se du lieu.

## Goi y giai nhanh

- Dung `ToString()` cho class va struct.
- In output truoc va sau khi goi ham.
- Dung `ReferenceEquals` khi can xac minh 2 bien co cung tro mot object hay khong.
- Neu phai clone, nho clone luon object ben trong.

## Loi thuong gap

- Viet clone nhung quen clone `Reward` hoac `Info` ben trong.
- Doi bien tham chieu trong ham roi nghi rang bien ngoai se doi theo.
- Dung tu "copy" cho ca 2 tinh huong ma khong noi ro copy gia tri hay copy tham chieu.
- Dat ten bien mo ho nhan nhu `a`, `b`, `x`, `y`.
- Quen viet output truoc khi dua ra ket luan.

## Tu kiem tra truoc khi qua bai tiep theo

- Ban co 1 vi du value type va 1 vi du reference type khong?
- Ban co 1 vi du truyen vao ham khong?
- Ban co 1 vi du doi tham chieu trong ham khong?
- Ban co 1 vi du clone sau object long object khong?
- Ban co giai thich bang loi cua minh thay vi chi dua code khong?

## Muc mo rong

- Tim hieu tu khoa `ref`, `out`, `in` sau khi hoc xong bai nay.
- Thu so sanh `record class` va `record struct`.
- Thu viet 1 bai co `Dictionary<string, Item>`.
- Thu viet 1 demo cho `List<Quest>` va chia se `Reward` giua cac quest.

## Tong ket bai tap

Neu ban lam ky file nay, ban se hieu tot nen tang de hoc bai boxing, unboxing va toi uu bo nho sau nay.
