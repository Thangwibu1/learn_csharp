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

## Hiểu sâu hơn: toán tử là công cụ xử lý dữ liệu

Nếu biến là nơi lưu dữ liệu, thì toán tử là công cụ để làm việc với dữ liệu đó.

Bạn có thể hình dung như sau:

- biến là nguyên liệu
- toán tử là thao tác
- kết quả là trạng thái mới của game

Ví dụ:

```csharp
int health = 100;
health = health - 20;
```

Ở đây:

- `health` là dữ liệu hiện có
- `-` là toán tử trừ
- kết quả cuối cùng là máu mới của nhân vật

Trong game, những phép tính như vậy diễn ra liên tục.

## Toán tử số học và ý nghĩa thật trong game

### Cộng `+`

Dùng khi bạn muốn tăng giá trị.

Ví dụ game:

- cộng điểm khi hạ quái
- cộng vàng khi nhặt vật phẩm
- cộng kinh nghiệm khi hoàn thành nhiệm vụ

```csharp
int score = 100;
score = score + 50;
```

### Trừ `-`

Dùng khi giá trị giảm đi.

Ví dụ game:

- trừ máu khi trúng đòn
- trừ mana khi dùng kỹ năng
- trừ vàng khi mua vật phẩm

```csharp
int mana = 80;
mana = mana - 20;
```

### Nhân `*`

Dùng khi cần tăng theo tỉ lệ hoặc công thức.

Ví dụ game:

- nhân sát thương chí mạng
- tính thưởng gấp đôi
- tính tổng số đạn sau nhiều băng

```csharp
int baseDamage = 30;
int critDamage = baseDamage * 2;
```

### Chia `/`

Dùng khi cần chia đều hoặc tính trung bình.

Ví dụ game:

- chia phần thưởng cho nhiều người chơi
- tính máu còn lại theo phần trăm đơn giản

```csharp
int coins = 100;
int eachPlayerGets = coins / 4;
```

### Phần dư `%`

Toán tử này cực kỳ hữu ích nhưng người mới thường bỏ qua.

Ví dụ ứng dụng:

- kiểm tra lượt chẵn hay lẻ
- cứ mỗi 3 quái hạ được thì rơi 1 vật phẩm
- mỗi 5 đợt thì xuất hiện boss nhỏ

```csharp
int wave = 6;
bool isBossWave = wave % 3 == 0;
```

Nếu `wave % 3` bằng `0`, tức là `wave` chia hết cho `3`.

## Toán tử gán giúp cập nhật trạng thái nhanh hơn

Người mới thường viết dài như sau:

```csharp
gold = gold + 10;
```

Viết ngắn hơn:

```csharp
gold += 10;
```

Tương tự:

- `x -= 5`
- `x *= 2`
- `x /= 3`

Chúng không phải là cú pháp khác hoàn toàn.

Chúng chỉ là cách viết gọn của phép gán có tính toán.

## Toán tử so sánh tạo ra câu trả lời đúng hoặc sai

Đây là phần cực kỳ quan trọng vì `if` và `while` đều cần kết quả `true` hoặc `false`.

Ví dụ:

```csharp
int gold = 40;
bool canBuyPotion = gold >= 30;
```

Các toán tử so sánh phổ biến:

- `>` lớn hơn
- `<` nhỏ hơn
- `>=` lớn hơn hoặc bằng
- `<=` nhỏ hơn hoặc bằng
- `==` bằng nhau
- `!=` khác nhau

Ý nghĩa thật trong game:

- `health <= 0`: nhân vật chết chưa
- `gold >= itemPrice`: đủ tiền chưa
- `enemyCount > 0`: còn quái không
- `weaponLevel == 5`: vũ khí đã đạt cấp 5 chưa

## Toán tử logic giúp kết hợp nhiều điều kiện

Đây là phần giúp code ra quyết định giống đời thực hơn.

### `&&` nghĩa là "và"

Hai điều kiện đều phải đúng.

```csharp
bool hasKey = true;
bool isNearDoor = true;
bool canOpenDoor = hasKey && isNearDoor;
```

Chỉ cần một điều kiện sai, kết quả là sai.

### `||` nghĩa là "hoặc"

Chỉ cần một điều kiện đúng.

```csharp
bool hasMana = false;
bool hasManaPotion = true;
bool canCastSkill = hasMana || hasManaPotion;
```

### `!` nghĩa là phủ định

Đổi `true` thành `false`, và ngược lại.

```csharp
bool isDead = false;
bool isAlive = !isDead;
```

## Thứ tự ưu tiên phép toán

Máy tính không đọc từ trái sang phải một cách ngây thơ.

Nó có thứ tự ưu tiên.

Thông thường:

- ngoặc `()` ưu tiên cao
- nhân chia ưu tiên trước cộng trừ
- so sánh thường xảy ra sau phép tính số học
- logic thường ghép kết quả sau cùng

Ví dụ:

```csharp
int result = 2 + 3 * 4;
```

Kết quả là `14`, không phải `20`.

Nếu bạn muốn rõ ràng hơn, hãy dùng ngoặc.

```csharp
int result = (2 + 3) * 4;
```

Viết ngoặc nhiều hơn một chút thường tốt hơn để người mới đọc không bị hiểu sai.

## Chia số nguyên là bẫy rất phổ biến

Ví dụ:

```csharp
int result = 5 / 2;
```

Kết quả là `2`, không phải `2.5`.

Lý do:

- cả hai toán hạng đều là `int`
- nên kết quả cũng là `int`

Nếu cần phần lẻ, hãy dùng `float`.

```csharp
float result = 5f / 2f;
```

Kết quả bây giờ là `2.5`.

## Ví dụ công thức game đơn giản

```csharp
int baseDamage = 20;
int weaponBonus = 5;
int totalDamage = baseDamage + weaponBonus;

bool isCritical = true;

if (isCritical)
{
    totalDamage *= 2;
}
```

Hãy đọc từng bước:

- sát thương gốc là `20`
- thưởng vũ khí là `5`
- tổng tạm thời là `25`
- nếu chí mạng, nhân đôi thành `50`

Toán tử làm cho các quy tắc game trở thành công thức cụ thể.

## Các lỗi người mới gặp rất nhiều

### 1. Dùng `=` thay vì `==`

- `=` là gán
- `==` là so sánh

Trong đầu người mới, hai dấu này trông rất giống nhau.

Nhưng ý nghĩa khác hoàn toàn.

### 2. Viết điều kiện logic không đúng ý

Ví dụ muốn kiểm tra người chơi sống và còn mana:

```csharp
bool canCast = isAlive && mana > 0;
```

Nếu lỡ dùng `||`, ý nghĩa sẽ đổi hoàn toàn.

### 3. Không để ý giá trị sau khi tính

Ví dụ:

```csharp
int health = 100;
health - 20;
```

Đoạn này không đổi `health` vì bạn chỉ tính, nhưng không gán kết quả lại.

Phải viết:

```csharp
health = health - 20;
```

hoặc:

```csharp
health -= 20;
```

### 4. Dùng số nguyên khi bài toán cần số lẻ

Đây là lỗi rất hay gặp trong game vì tốc độ, thời gian, khoảng cách thường không phải số nguyên.

## Tóm tắt bài học

- Toán tử là công cụ để xử lý dữ liệu
- Toán tử số học dùng để tính toán
- Toán tử gán dùng để cập nhật giá trị
- Toán tử so sánh cho kết quả `true` hoặc `false`
- Toán tử logic kết hợp nhiều điều kiện
- Thứ tự ưu tiên phép toán ảnh hưởng trực tiếp tới kết quả
- Chia số nguyên có thể làm mất phần thập phân

## Tự kiểm tra

1. Khác nhau giữa `=` và `==` là gì?
2. Khi nào bạn nên dùng `%` trong game?
3. Vì sao `5 / 2` có thể ra `2`?
4. `&&` và `||` khác nhau ở điểm nào?
5. `health -= 10` nghĩa là gì?
6. Trong game, điều kiện nào phù hợp cho `gold >= price`?
7. Nếu muốn kiểm tra người chơi còn sống và có chìa khóa, bạn sẽ dùng toán tử nào?

## Gợi ý luyện tập

1. Tạo biến `gold`, `itemPrice` và viết biểu thức kiểm tra người chơi có mua được vật phẩm hay không.
2. Tạo biến `health` rồi mô phỏng 3 lần nhận sát thương bằng các toán tử gán rút gọn.
3. Viết biểu thức kiểm tra một `wave` có phải wave boss hay không bằng `%`.
4. Tạo hai biến `hasMana` và `hasPotion`, sau đó viết điều kiện để quyết định có dùng kỹ năng được không.
5. Tự viết một công thức tính sát thương gồm sát thương gốc, thưởng vũ khí và chí mạng.
