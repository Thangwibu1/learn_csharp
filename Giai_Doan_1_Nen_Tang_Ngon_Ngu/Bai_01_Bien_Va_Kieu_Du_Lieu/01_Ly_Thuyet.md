# Bài 1: Biến và Kiểu Dữ Liệu

## Mục tiêu

- Hiểu biến là gì
- Hiểu kiểu dữ liệu là gì
- Biết khi nào dùng `int`, `float`, `string`, `bool`, `char`
- Biết khai báo, gán và in biến ra màn hình

## Biến là gì?

Hãy xem biến như một chiếc hộp có nhãn.

- Nhãn là tên biến
- Đồ bên trong là giá trị
- Loại hộp là kiểu dữ liệu

Ví dụ đời thực:

- Hộp ghi chữ `soTien` thì bên trong nên là số
- Hộp ghi chữ `tenNguoiChoi` thì bên trong nên là tên

Trong C#, biến là nơi chương trình cất thông tin để dùng lại.

```csharp
int age = 20;
string playerName = "An";
```

## Kiểu dữ liệu là gì?

Kiểu dữ liệu là luật cho biết biến được chứa loại gì.

- `int`: số nguyên
- `float`: số có phần thập phân
- `string`: chữ
- `bool`: đúng hoặc sai
- `char`: một ký tự duy nhất

Nếu bạn bỏ sai loại dữ liệu vào biến, chương trình sẽ báo lỗi.

## Tại sao phải dùng cái này?

Vì mọi chương trình đều cần nhớ dữ liệu.

Trong game, bạn phải lưu:

- máu nhân vật
- tốc độ chạy
- số vàng
- tên vũ khí
- trạng thái thắng thua

Không có biến, game không biết người chơi đang ở trạng thái nào.

## Cú pháp khai báo

```csharp
kieuDuLieu tenBien = giaTri;
```

Ví dụ:

```csharp
int playerHealth = 100;
float moveSpeed = 5.5f;
string weaponName = "Sword";
bool isAlive = true;
char rank = 'A';
```

## Các kiểu dữ liệu cơ bản

### `int`

```csharp
int score = 100;
```

Dùng cho:

- điểm số
- số mạng
- số quái

### `float`

```csharp
float jumpForce = 7.2f;
```

Dùng cho:

- tốc độ
- khoảng cách
- thời gian

Lưu ý: `float` thường cần chữ `f` ở cuối.

### `string`

```csharp
string playerName = "Knight";
```

Dùng cho:

- tên người chơi
- tên vật phẩm
- thông báo

### `bool`

```csharp
bool hasKey = false;
```

Chỉ có 2 giá trị:

- `true`
- `false`

### `char`

```csharp
char grade = 'A';
```

`char` là 1 ký tự, còn `string` là nhiều ký tự hoặc cả câu.

## Gán lại giá trị

Biến có thể đổi giá trị theo thời gian.

```csharp
int health = 100;
health = 80;
health = 50;
```

Điều này rất giống game: nhân vật bị đánh thì máu giảm.

## In dữ liệu

```csharp
Console.WriteLine("Hello");
Console.WriteLine(playerName);
Console.WriteLine("Mau: " + health);
```

## Quy tắc đặt tên biến

- Tên phải rõ nghĩa
- Không bắt đầu bằng số
- Không có khoảng trắng
- Nên dùng tiếng Anh đơn giản

Tên tốt:

```csharp
int playerHealth;
float moveSpeed;
bool isDead;
```

Tên xấu:

```csharp
int a;
float x;
bool q;
```

## Lỗi sai thường gặp của người mới

### 1. Quên dấu `;`

```csharp
int age = 20;
```

### 2. Gán sai kiểu

```csharp
int age = "20"; // Sai
```

### 3. Quên chữ `f` ở `float`

```csharp
float speed = 5.5f;
```

### 4. Nhầm `char` với `string`

```csharp
char grade = 'A';
string text = "A";
```

## Ghi nhớ nhanh

- Biến là nơi lưu dữ liệu
- Kiểu dữ liệu là luật của dữ liệu
- `int` cho số nguyên
- `float` cho số thập phân
- `string` cho chữ
- `bool` cho đúng sai
- `char` cho một ký tự
