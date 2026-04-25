# Bài 2: Toán Tử

## Mục tiêu

- Biết dùng các phép toán cơ bản
- Hiểu toán tử gán, so sánh và logic
- Thấy được vai trò của toán tử trong game

## Toán tử là gì?

Toán tử là ký hiệu giúp chúng ta xử lý dữ liệu.

Ví dụ đời thường:

- cộng tiền
- trừ tiền
- so sánh hai số
- kiểm tra hai điều kiện cùng đúng hay không

Trong lập trình, các dấu như `+`, `-`, `*`, `/`, `==`, `&&` chính là công cụ làm việc đó.

## Tại sao phải dùng cái này?

Vì game luôn phải tính toán:

- máu giảm bao nhiêu
- điểm tăng bao nhiêu
- người chơi có đủ vàng mua đồ không
- quái có đang ở trong tầm đánh không

## Nhóm 1: Toán tử số học

```csharp
int a = 10 + 5;
int b = 10 - 5;
int c = 10 * 5;
int d = 10 / 5;
int e = 10 % 3;
```

- `+` cộng
- `-` trừ
- `*` nhân
- `/` chia
- `%` lấy phần dư

`%` rất hữu ích khi bạn muốn biết một số là chẵn hay lẻ.

## Nhóm 2: Toán tử gán

```csharp
int score = 0;
score = score + 10;
score += 5;
score -= 3;
```

`score += 5` là cách viết ngắn của `score = score + 5`.

## Nhóm 3: Toán tử so sánh

```csharp
bool result1 = 5 > 3;
bool result2 = 5 < 3;
bool result3 = 5 == 5;
bool result4 = 5 != 4;
```

Kết quả của so sánh luôn là `true` hoặc `false`.

## Nhóm 4: Toán tử logic

```csharp
bool hasKey = true;
bool isNearDoor = false;

bool canOpen = hasKey && isNearDoor;
```

- `&&`: và
- `||`: hoặc
- `!`: phủ định

Ví dụ:

- Có chìa khóa **và** đứng gần cửa mới mở được
- Có mana **hoặc** có bình mana thì vẫn dùng skill được

## Tăng giảm nhanh

```csharp
int level = 1;
level++;
level--;
```

- `++` tăng 1
- `--` giảm 1

## Lỗi sai thường gặp của người mới

### 1. Nhầm `=` và `==`

- `=` là gán giá trị
- `==` là so sánh bằng nhau

### 2. Chia số nguyên không ra thập phân

```csharp
int result = 5 / 2; // Ket qua la 2
```

Nếu cần số lẻ, hãy dùng `float` hoặc `double`.

### 3. Quên ưu tiên phép toán

Giống toán học bình thường, nhân chia thường được tính trước cộng trừ.

## Ví dụ game

```csharp
int health = 100;
health -= 25;

int gold = 50;
bool canBuySword = gold >= 30;
```
