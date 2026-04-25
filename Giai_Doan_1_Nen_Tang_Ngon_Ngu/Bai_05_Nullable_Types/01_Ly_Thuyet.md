# Bài 5: Nullable Types

## Mục tiêu

- Hiểu `null` là gì
- Hiểu tại sao có lúc biến có thể chưa có giá trị
- Biết dùng `int?`, `float?`, `bool?`

## `null` là gì?

`null` có thể hiểu là: chưa có gì cả.

Ví dụ đời thường:

- ô nhập tên chưa điền gì
- người chơi chưa chọn vũ khí
- NPC chưa có nhiệm vụ

## Vì sao cần Nullable?

Một số kiểu dữ liệu như `int`, `float`, `bool` bình thường luôn phải có giá trị.

Nhưng có lúc bạn muốn nói rõ rằng:

- chưa biết tuổi
- chưa có điểm
- chưa xác định trạng thái

Khi đó, ta dùng kiểu nullable.

```csharp
int? score = null;
float? playerSpeed = null;
bool? acceptedQuest = null;
```

## Tại sao phải dùng cái này?

Vì trong game và ứng dụng thực tế, "chưa có dữ liệu" khác với "dữ liệu bằng 0".

Ví dụ:

- `0` xu nghĩa là có dữ liệu và số xu đang bằng 0
- `null` nghĩa là chưa tải dữ liệu xu từ file save

Đây là hai ý nghĩa hoàn toàn khác nhau.

## Cách kiểm tra nullable

```csharp
int? questReward = null;

if (questReward.HasValue)
{
    Console.WriteLine(questReward.Value);
}
else
{
    Console.WriteLine("Chua co thuong");
}
```

## Toán tử `??`

Toán tử này nghĩa là: nếu bên trái là `null`, dùng giá trị bên phải.

```csharp
int? score = null;
int safeScore = score ?? 0;
```

## Lỗi sai thường gặp của người mới

### 1. Không phân biệt `0` và `null`

### 2. Dùng `.Value` khi biến đang là `null`

### 3. Dùng nullable ở mọi nơi dù không cần

Nếu dữ liệu chắc chắn luôn tồn tại, không cần nullable.

## Ví dụ game

```csharp
int? selectedWeaponId = null;

if (selectedWeaponId == null)
{
    Console.WriteLine("Nguoi choi chua chon vu khi");
}
```
