# Bài 3: If Else

## Mục tiêu

- Hiểu điều kiện là gì
- Biết dùng `if`, `else if`, `else`
- Biết ra quyết định trong code

## `if` là gì?

`if` nghĩa là: nếu điều kiện đúng thì làm gì đó.

Ví dụ đời thường:

- Nếu trời mưa thì mang áo mưa
- Nếu đói thì đi ăn

Trong code cũng giống như vậy.

```csharp
if (health <= 0)
{
    Console.WriteLine("Game Over");
}
```

## Tại sao phải dùng cái này?

Game là một chuỗi quyết định liên tục.

- Nếu máu về 0 thì chết
- Nếu đủ vàng thì mua được đồ
- Nếu đến gần quái thì quái đuổi theo
- Nếu hoàn thành nhiệm vụ thì mở khóa màn tiếp theo

Không có điều kiện, game không thể phản ứng với tình huống.

## Cấu trúc cơ bản

```csharp
if (dieuKien)
{
    // viec can lam
}
```

Nếu điều kiện sai, đoạn trong ngoặc nhọn sẽ bị bỏ qua.

## `if` và `else`

```csharp
if (gold >= 50)
{
    Console.WriteLine("Du tien mua kiem");
}
else
{
    Console.WriteLine("Khong du tien");
}
```

## `else if`

Khi có nhiều trường hợp khác nhau.

```csharp
if (score >= 90)
{
    Console.WriteLine("Hang S");
}
else if (score >= 75)
{
    Console.WriteLine("Hang A");
}
else
{
    Console.WriteLine("Can co gang them");
}
```

## Điều kiện thường là gì?

Điều kiện thường là biểu thức cho ra `true` hoặc `false`.

Ví dụ:

- `health <= 0`
- `gold >= 100`
- `hasKey == true`
- `enemyCount > 0`

## Lỗi sai thường gặp của người mới

### 1. Dùng `=` thay vì `==`

Trong điều kiện, bạn thường cần so sánh.

### 2. Quên ngoặc nhọn

Người mới nên luôn viết ngoặc nhọn cho rõ ràng.

### 3. Điều kiện quá rối

Nếu điều kiện dài, hãy tách ra biến `bool` riêng để dễ đọc.

## Ví dụ game

```csharp
if (playerHealth <= 0)
{
    Console.WriteLine("Nhan vat da chet");
}
else
{
    Console.WriteLine("Nhan vat van con song");
}
```

## Hiểu sâu hơn: `if` là công cụ ra quyết định

Máy tính không tự "hiểu tình huống" như con người.

Nó chỉ biết đọc điều kiện và làm theo nhánh phù hợp.

`if` chính là cách bạn dạy chương trình ra quyết định.

Ví dụ đời thực:

- nếu có tiền thì mua đồ
- nếu trời mưa thì mang áo mưa
- nếu hết pin thì sạc điện thoại

Trong game cũng vậy:

- nếu máu bằng 0 thì thua
- nếu đủ kinh nghiệm thì lên cấp
- nếu đứng gần NPC thì hiện nút đối thoại

## Chương trình kiểm tra điều kiện như thế nào?

Khi gặp `if`, chương trình sẽ làm 3 bước rất đơn giản:

1. Tính biểu thức trong ngoặc `()`
2. Nếu kết quả là `true`, chạy khối lệnh trong `if`
3. Nếu kết quả là `false`, bỏ qua khối đó và xét nhánh tiếp theo nếu có

Ví dụ:

```csharp
int health = 0;

if (health <= 0)
{
    Console.WriteLine("Game Over");
}
```

Biểu thức `health <= 0` cho ra `true`, nên dòng `Game Over` được in ra.

## `if` không chỉ để kiểm tra số

Người mới hay nghĩ `if` chỉ dùng với số.

Thực ra `if` dùng với mọi biểu thức cho ra `true` hoặc `false`.

Ví dụ với `bool`:

```csharp
bool hasKey = true;

if (hasKey)
{
    Console.WriteLine("Mo cua");
}
```

Ví dụ với so sánh chuỗi đơn giản:

```csharp
string playerClass = "Mage";

if (playerClass == "Mage")
{
    Console.WriteLine("Nhan vat nay dung phep");
}
```

## Khi nào dùng `if`, khi nào dùng `if-else`?

### Dùng `if`

Khi bạn chỉ cần xử lý nếu điều kiện đúng.

Nếu điều kiện sai thì không cần làm gì.

```csharp
if (enemyCount > 0)
{
    Console.WriteLine("Con quai trong khu vuc");
}
```

### Dùng `if-else`

Khi bạn muốn có hai hướng xử lý rõ ràng.

```csharp
if (gold >= 100)
{
    Console.WriteLine("Du vang mua giap");
}
else
{
    Console.WriteLine("Can kiem them vang");
}
```

### Dùng `if-else if-else`

Khi có nhiều trường hợp khác nhau.

Ví dụ xếp hạng:

```csharp
if (score >= 90)
{
    Console.WriteLine("Hang S");
}
else if (score >= 80)
{
    Console.WriteLine("Hang A");
}
else if (score >= 70)
{
    Console.WriteLine("Hang B");
}
else
{
    Console.WriteLine("Can luyen them");
}
```

## Thứ tự các nhánh rất quan trọng

Chương trình sẽ kiểm tra từ trên xuống dưới.

Nó gặp nhánh đúng đầu tiên thì sẽ chạy nhánh đó và bỏ qua phần còn lại.

Ví dụ sai:

```csharp
if (score >= 70)
{
    Console.WriteLine("Hang B tro len");
}
else if (score >= 90)
{
    Console.WriteLine("Hang S");
}
```

Với `score = 95`, nhánh đầu đã đúng rồi, nên nhánh `Hang S` không bao giờ chạy.

Vì vậy:

- điều kiện đặc biệt hơn nên đặt trước
- điều kiện rộng hơn nên đặt sau

## Kết hợp nhiều điều kiện trong `if`

Bạn có thể dùng toán tử logic để viết điều kiện sát với tình huống thật hơn.

Ví dụ mở cửa kho báu:

```csharp
bool hasKey = true;
bool defeatedBoss = true;

if (hasKey && defeatedBoss)
{
    Console.WriteLine("Mo cua kho bau");
}
```

Ví dụ dùng kỹ năng:

```csharp
bool hasMana = false;
bool hasManaPotion = true;

if (hasMana || hasManaPotion)
{
    Console.WriteLine("Co the dung ky nang");
}
```

## Dùng biến `bool` để làm điều kiện dễ đọc hơn

Khi điều kiện dài, người mới rất dễ bị rối.

Thay vì viết một dòng quá dài, hãy tách thành biến `bool` có tên rõ nghĩa.

```csharp
bool isLowHealth = playerHealth < 20;
bool hasPotion = potionCount > 0;

if (isLowHealth && hasPotion)
{
    Console.WriteLine("Nen hoi mau ngay");
}
```

Ưu điểm:

- dễ đọc
- dễ kiểm tra lỗi
- dễ sửa sau này

## `if` lồng nhau

Bạn có thể đặt `if` bên trong một `if` khác.

```csharp
if (isAlive)
{
    if (enemyNear)
    {
        Console.WriteLine("San sang chien dau");
    }
}
```

Tuy nhiên, đừng lạm dụng quá sớm.

Nếu lồng quá sâu:

- code khó đọc
- khó tìm lỗi
- khó mở rộng

Với người mới, ưu tiên viết rõ ràng trước, ngắn gọn sau.

## Ví dụ game: hệ thống cửa

```csharp
bool hasKey = true;
bool isNearDoor = true;
bool doorLocked = true;

if (doorLocked)
{
    if (hasKey && isNearDoor)
    {
        Console.WriteLine("Cua da mo");
    }
    else
    {
        Console.WriteLine("Chua the mo cua");
    }
}
else
{
    Console.WriteLine("Cua da mo san");
}
```

Khi đọc đoạn này, hãy tự diễn giải bằng lời:

- nếu cửa đang khóa
- thì kiểm tra xem có chìa và đứng gần cửa không
- nếu đủ điều kiện thì mở
- nếu không đủ thì báo chưa mở được
- còn nếu cửa vốn đã không khóa thì báo cửa mở sẵn

Kỹ năng diễn giải bằng lời sẽ giúp bạn hiểu `if-else` rất nhanh.

## Các lỗi phổ biến khi viết điều kiện

### 1. Điều kiện không đúng ý nghĩa thật

Ví dụ bạn muốn kiểm tra nhân vật chết:

```csharp
if (health < 0)
```

Điều này có thể bỏ sót trường hợp `health == 0`.

Phù hợp hơn thường là:

```csharp
if (health <= 0)
```

### 2. Nhầm `=` với `==`

Đây là lỗi kinh điển của người mới.

### 3. Quá nhiều điều kiện trong một dòng

Nếu một dòng làm bạn đọc lại 3 lần vẫn chưa chắc nghĩa, hãy tách ra.

### 4. Không nghĩ tới nhánh `else`

Người mới hay chỉ nghĩ về trường hợp đúng.

Nhưng khi làm game, bạn phải luôn hỏi thêm:

- nếu điều kiện sai thì chuyện gì xảy ra?

## Cách tự kiểm tra một khối `if-else`

Khi viết xong, hãy thử thay các giá trị khác nhau và tự đoán kết quả trước khi chạy.

Ví dụ với điều kiện:

```csharp
if (gold >= 50)
```

Hãy tự hỏi:

- nếu `gold = 60` thì sao
- nếu `gold = 50` thì sao
- nếu `gold = 49` thì sao

Nếu bạn trả lời được trơn tru, nghĩa là bạn đã bắt đầu hiểu thật.

## Tóm tắt bài học

- `if` dùng để ra quyết định trong chương trình
- Điều kiện phải cho ra `true` hoặc `false`
- `else` xử lý trường hợp ngược lại
- `else if` dùng khi có nhiều nhánh lựa chọn
- Thứ tự nhánh ảnh hưởng trực tiếp tới kết quả
- Điều kiện nên rõ nghĩa và gần với bài toán thực tế

## Tự kiểm tra

1. `if` khác `if-else` ở điểm nào?
2. Vì sao thứ tự `else if` lại quan trọng?
3. Khi nào nên dùng `&&` trong điều kiện?
4. Khi nào nên dùng `||` trong điều kiện?
5. Vì sao `health <= 0` thường tốt hơn `health < 0` khi kiểm tra nhân vật chết?
6. Nếu điều kiện quá dài, bạn nên làm gì để code dễ đọc hơn?
7. Một biến `bool` có thể được dùng trực tiếp trong `if` không?

## Gợi ý luyện tập

1. Viết điều kiện kiểm tra người chơi có đủ vàng để mua kiếm hay không.
2. Viết hệ thống xếp hạng `S`, `A`, `B`, `C` dựa trên điểm.
3. Viết logic cho một cánh cửa: chỉ mở khi người chơi có chìa khóa và đứng gần cửa.
4. Viết logic hiển thị `Game Over` khi máu nhỏ hơn hoặc bằng `0`.
5. Tự nghĩ một tình huống game có ít nhất 3 nhánh `if-else if-else` và mô tả kết quả của từng nhánh.
