# Bai tap Bai 3: Boxing va Unboxing

## Muc tieu

- Hieu boxing la dua value type vao `object` hoac interface.
- Hieu unboxing la ep object tro lai value type dung kieu.
- Biet phan biet cast reference type voi unboxing value type.
- Nhan ra ly do `generics` giup giam boxing trong nhieu truong hop.

## Cach hoc bai nay

- Chay tung vi du ngan.
- In ra `GetType().Name` de nhin kieu that.
- Thu du doan loi truoc khi co tinh cast sai.
- Ghi lai bai hoc sau moi bai.

## Bai 1: Boxing int vao object

Yeu cau:

- Tao `int score = 99`.
- Gan `object boxedScore = score`.
- In ra gia tri va kieu thuc te.

Cau hoi:

- Tai sao dong lenh nay duoc goi la boxing?

## Bai 2: Unboxing object ve int

Yeu cau:

- Tao `object boxedLevel = 7`.
- Ep ve `int level = (int)boxedLevel`.
- In ket qua.

## Bai 3: Boxing bool

Yeu cau:

- Tao `bool isAlive = true`.
- Boxing vao `object`.
- In gia tri, kieu va ket qua sau khi unboxing.

## Bai 4: Boxing struct tu tao

Yeu cau:

- Tao `struct ScoreRecord` co `Value`.
- Boxing no vao `object`.
- In `GetType().Name`.
- Unboxing dung kieu va in ket qua.

## Bai 5: Cast sai kieu khi unboxing

Yeu cau:

- Tao `object value = 12.5`.
- Co y ep `(int)value`.
- Bat `InvalidCastException`.
- In thong diep loi.

Muc tieu:

- Nho rang unboxing phai dung kieu that su da duoc boxing.

## Bai 6: object chua string khong phai unboxing

Yeu cau:

- Tao `object text = "xin chao"`.
- Ep ve `string` va in ra.
- Viet ket luan vi sao day khong phai unboxing.

## Bai 7: Pattern matching an toan

Yeu cau:

- Tao `object maybeNumber = 123`.
- Dung `is int number` de lay gia tri.
- Tao `object maybeText = "hello"` va dung `is string text`.

## Bai 8: ArrayList va boxing

Yeu cau:

- Tao `ArrayList`.
- Them 3 so nguyen vao.
- Duyet va ep tung phan tu sang `int` de tinh tong.

Cau hoi:

- Boxing xuat hien o dau?
- Unboxing xuat hien o dau?

## Bai 9: List<int> tranh boxing thong thuong

Yeu cau:

- Tao `List<int>` chua 3 so.
- Tinh tong.
- Viet so sanh voi bai `ArrayList`.

## Bai 10: Interface va value type

Yeu cau:

- Tao `struct Temperature`.
- Cho no tham gia mot interface phu hop nhu `IFormattable` hoac `IComparable`.
- Gan value type nay cho bien interface.
- In ket qua.

Muc tieu:

- Nhan ra boxing co the xay ra khi value type di qua interface.

## Bai 11: Dien output 1

```csharp
int x = 5;
object obj = x;
Console.WriteLine(obj);
```

Yeu cau:

- Dien output.
- Giai thich tai sao `obj` in ra duoc 5.

## Bai 12: Dien output 2

```csharp
object obj = 8;
int value = (int)obj;
Console.WriteLine(value + 2);
```

Yeu cau:

- Dien output.
- Giai thich tung buoc.

## Bai 13: Dien output 3 voi string

```csharp
object obj = "abc";
string text = (string)obj;
Console.WriteLine(text.Length);
```

Yeu cau:

- Dien output.
- Giai thich vi sao day khong phai unboxing.

## Bai 14: Bai dung sai

Danh dau dung hoac sai:

- Boxing chi xay ra voi value type.
- Cast `string` tu `object` luon la unboxing.
- `ArrayList` co the dan den boxing khi luu `int`.
- `List<int>` thuong giup tranh boxing trong nhieu tinh huong.
- Unboxing sai kieu co the nem exception.
- Moi cast deu la boxing.

## Bai 15: Viet bang so sanh

Yeu cau:

- Tao bang 3 cot:
- Tinh huong
- Co boxing khong
- Giai thich

Can it nhat 12 dong.

Vi du tinh huong:

- `object a = 5`
- `int b = (int)a`
- `object c = "hello"`
- `string d = (string)c`
- Them `int` vao `ArrayList`
- Lay `int` tu `ArrayList`
- Duyet `List<int>`
- Gan struct vao interface

## Bai 16: Tim vi tri boxing trong code

Yeu cau:

- Tu viet mot doan code co `ArrayList`, `object`, `List<int>`, `string`.
- Danh dau tung dong co boxing, unboxing, cast thuong hay khong co gi dac biet.

## Bai 17: Debug loi InvalidCastException

Tinh huong:

- Co mot ham tra ve `object`.
- Luc thi no tra `int`, luc thi no tra `double`.
- Ben ngoai luon ep `(int)` nen doi luc bi loi.

Yeu cau:

- Tao vi du toi thieu de tai hien loi.
- Sua bang `is`, `switch`, hoac cach khac an toan.

## Bai 18: Mini project nho 1

Ten de tai:

- Bang diem hoc vien.

Yeu cau:

- Tao chuong trinh luu diem trong `ArrayList`.
- Tinh tong va trung binh.
- Sau do viet phien ban dung `List<int>`.
- So sanh 2 cach bang 5 dong nhan xet.

## Bai 19: Mini project nho 2

Ten de tai:

- He thong luu gia tri tong quat.

Yeu cau:

- Viet ham `PrintObjectInfo(object value)`.
- Ham in gia tri va kieu.
- Truyen vao `int`, `double`, `bool`, `string`, `struct`.
- Chi ra truong hop nao lien quan boxing.

## Bai 20: Mini project nho 3

Ten de tai:

- Kho du lieu cu va moi.

Yeu cau:

- Tao mot demo dung `ArrayList` lam he thong cu.
- Tao mot demo dung `List<int>` hoac `List<ScoreRecord>` lam he thong moi.
- Giai thich vi sao he thong moi de bao tri hon.

## Bai 21: Bai tu luan ngan

1. Boxing la gi?
2. Unboxing la gi?
3. Tai sao boxing co the ton them chi phi?
4. Tai sao generic thuong tot hon trong bai toan luu nhieu value type?
5. Tai sao cast `string` khong phai unboxing?

## Bai 22: Hoan thanh cau

Dien phan con thieu:

- Khi mot `int` duoc gan vao `object`, qua trinh do goi la `...`
- Khi ep `object` chua `int` tro lai `int`, qua trinh do goi la `...`
- Neu unboxing sai kieu, chuong trinh co the nem `...`
- `List<int>` thuong tot hon `ArrayList` vi `...`

## Bai 23: Bai phan tich code cu

Yeu cau:

- Tim mot doan code C# cu co dung `ArrayList` hoac `object` qua nhieu.
- Chi ra nguy co boxing/unboxing.
- De xuat huong viet generic tot hon.

## Bai 24: Bai viet output va giai thich

Doan code:

```csharp
ArrayList list = new ArrayList();
list.Add(1);
list.Add(2);
int sum = 0;
foreach (object item in list)
{
    sum += (int)item;
}
Console.WriteLine(sum);
```

Yeu cau:

- Dien output.
- Chi ra dong nao boxing.
- Chi ra dong nao unboxing.

## Bai 25: Bai viet code phong ve

Yeu cau:

- Viet ham nhan `object value`.
- Neu la `int` thi in binh phuong.
- Neu la `double` thi in lam tron 2 chu so.
- Neu la `string` thi in do dai.
- Neu kieu khac thi in thong bao khong ho tro.

## Bai 26: Troubleshooting checklist

- Kieu that su cua `object` la gi?
- Ban da kiem tra bang `GetType()` hoac `is` chua?
- Day la unboxing hay cast reference type?
- Co dung collection khong generic khong?
- Co the thay bang generic khong?
- Loi xay ra luc them vao hay luc lay ra?

## Bai 27: Loi thuong gap

- Nham cast `string` voi unboxing.
- Ep sai kieu thuc te cua object.
- Dung `ArrayList` khi thuc su chi can `List<int>`.
- Khong bat exception khi dang hoc thu nghiem cast sai.
- Giai thich qua mo ho ma khong noi ro boxing xay ra o dong nao.

## Bai 28: Tu danh gia muc do hieu bai

Cham tu 1 den 5:

- Toi giai thich duoc boxing.
- Toi giai thich duoc unboxing.
- Toi phan biet duoc cast string va unboxing int.
- Toi biet vi sao generic giup giam boxing.
- Toi biet cach debug `InvalidCastException`.

## Bai 29: Ghi nho nhanh 6 dong

Viet 6 dong bat dau bang:

- `Boxing la...`
- `Unboxing la...`
- `Mot dau hieu boxing la...`
- `Mot loi de gap la...`
- `Khi code moi, toi uu tien...`
- `Khi debug, toi se...`

## Bai 30: Tong ket cuoi bai

Yeu cau:

- Viet it nhat 10 dong tong ket.
- Trong do phai co:
- 3 vi du boxing.
- 2 vi du khong phai boxing.
- 2 loi thuong gap.
- 2 cach tranh boxing khong can thiet.

## Goi y giai nhanh

- Kiem tra `GetType().Name` khi nghi ngo.
- Dung `List<int>` thay cho `ArrayList` neu du lieu dong nhat.
- Dung pattern matching de ep kieu an toan.
- Ghi ro trong ket luan: day la boxing, unboxing, hay chi la cast reference.

## Muc mo rong

- Tim hieu them ve `IEnumerable`, `IComparable`, `IFormattable` voi struct.
- Thu viet benchmark nho de cam nhan chi phi boxing trong loop lon.
- Thu doc code .NET cu de thay vi sao `ArrayList` dan duoc thay bang generic collection.

## Ket thuc bai tap

Neu ban lam vung file nay, ban se co kha nang doc va viet code C# sach hon, an toan hon va it boxing khong can thiet hon.
