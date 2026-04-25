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
