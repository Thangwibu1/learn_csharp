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

## Hiểu sâu hơn: biến không chỉ là "cái hộp"

Ẩn dụ "cái hộp" rất tốt cho người mới bắt đầu.

Nhưng khi học nghiêm túc hơn, bạn nên hiểu thêm 3 ý:

- Biến có tên để bạn gọi lại dữ liệu về sau
- Biến có kiểu để trình biên dịch kiểm tra tính hợp lệ
- Biến có giá trị hiện tại, và giá trị này có thể thay đổi trong lúc chương trình chạy

Ví dụ:

```csharp
int playerHealth = 100;
playerHealth = playerHealth - 20;
```

Sau dòng đầu tiên, `playerHealth` là `100`.

Sau dòng thứ hai, `playerHealth` là `80`.

Điều quan trọng ở đây là:

- tên biến không đổi
- kiểu dữ liệu không đổi
- giá trị bên trong có thể đổi

Đây chính là nền tảng của hầu hết mọi hệ thống trong game.

## Biến giúp chương trình "nhớ" trạng thái

Người mới thường nhìn code như một danh sách câu lệnh tách rời.

Thực tế, biến là thứ giúp các câu lệnh liên kết với nhau.

Ví dụ game bắn súng đơn giản:

```csharp
int ammo = 30;
ammo = ammo - 1;
Console.WriteLine(ammo);
```

Nếu không có biến `ammo`, chương trình không biết:

- bạn còn bao nhiêu đạn
- lần bắn trước đã trừ đạn chưa
- có đủ đạn để bắn tiếp không

Nói cách khác:

- biến lưu trạng thái hiện tại
- toán tử thay đổi trạng thái đó
- `if` kiểm tra trạng thái đó
- vòng lặp cập nhật trạng thái đó nhiều lần

Vì vậy bài học về biến là nền móng cho toàn bộ phần sau.

## Phân biệt khai báo, khởi tạo và gán lại

Đây là ba khái niệm rất hay bị trộn lẫn.

### 1. Khai báo

Là nói cho C# biết bạn sắp dùng một biến có tên và kiểu gì.

```csharp
int score;
```

### 2. Khởi tạo

Là gán giá trị ban đầu cho biến.

```csharp
score = 0;
```

### 3. Viết gọn cả hai bước

```csharp
int score = 0;
```

### 4. Gán lại

Là đổi giá trị sau khi biến đã tồn tại.

```csharp
score = 10;
score = 25;
```

Khi đọc code, hãy tự hỏi:

- dòng này đang tạo biến mới
- hay chỉ đang cập nhật biến cũ

Phân biệt rõ điều đó sẽ giúp bạn bớt nhầm lẫn rất nhiều.

## Khi nào nên dùng từng kiểu dữ liệu?

### Dùng `int` khi nào?

Hãy dùng `int` khi dữ liệu là số nguyên, không cần phần lẻ.

Ví dụ game:

- số mạng còn lại
- số xu
- cấp độ hiện tại
- số lượng quái còn sống

Ví dụ:

```csharp
int lives = 3;
int gold = 150;
int currentLevel = 2;
```

Sai lầm phổ biến:

- dùng `int` cho tốc độ di chuyển có số lẻ
- dùng `int` cho thời gian có phần thập phân

### Dùng `float` khi nào?

Hãy dùng `float` khi dữ liệu có thể có phần lẻ.

Ví dụ game:

- tốc độ chạy `4.5`
- thời gian hồi chiêu `1.25`
- khoảng cách `7.8`
- lực nhảy `6.3`

```csharp
float moveSpeed = 4.5f;
float cooldown = 1.25f;
```

Vì game thường làm việc với vị trí, chuyển động và thời gian, `float` xuất hiện rất thường xuyên.

### Dùng `string` khi nào?

Hãy dùng `string` cho văn bản.

Ví dụ game:

- tên người chơi
- tên kỹ năng
- nội dung hội thoại
- thông báo hệ thống

```csharp
string npcName = "Guard";
string questText = "Hãy tìm 3 viên đá phép.";
```

Lưu ý:

- `"A"` là `string`
- `'A'` là `char`

### Dùng `bool` khi nào?

`bool` rất quan trọng vì code thường xuyên cần trả lời câu hỏi có hoặc không.

Ví dụ game:

- người chơi còn sống không
- cửa đã mở chưa
- boss đã xuất hiện chưa
- người chơi có chìa khóa không

```csharp
bool isAlive = true;
bool hasKey = false;
```

Nếu một biến đại diện cho trạng thái bật hoặc tắt, rất có thể `bool` là lựa chọn đúng.

### Dùng `char` khi nào?

`char` chỉ chứa đúng một ký tự.

Ví dụ:

- hạng đánh giá `A`, `B`, `C`
- ký hiệu phím `W`, `A`, `S`, `D`

```csharp
char rank = 'S';
char moveKey = 'W';
```

Trong thực tế làm game, `char` ít phổ biến hơn `string`, nhưng bạn vẫn nên hiểu rõ để tránh nhầm.

## Tại sao chọn đúng kiểu dữ liệu lại quan trọng?

Chọn đúng kiểu dữ liệu giúp bạn:

- viết code dễ đọc hơn
- tránh lỗi logic
- tránh lỗi biên dịch
- diễn đạt đúng ý nghĩa dữ liệu

Ví dụ:

```csharp
bool isDead = false;
```

Dòng này rõ nghĩa hơn rất nhiều so với:

```csharp
int deadStatus = 0;
```

Với người mới, lời khuyên rất đơn giản:

- nếu là số đếm, nghĩ tới `int`
- nếu là số có lẻ, nghĩ tới `float`
- nếu là chữ, nghĩ tới `string`
- nếu là đúng sai, nghĩ tới `bool`
- nếu là đúng một ký tự, nghĩ tới `char`

## Ví dụ theo dõi trạng thái nhân vật

Hãy nhìn một nhóm biến đơn giản nhưng rất giống game thật:

```csharp
string playerName = "Archer";
int health = 100;
float speed = 5.2f;
bool hasBow = true;
char rank = 'B';
```

Ta có thể đọc ý nghĩa như sau:

- `playerName`: nhân vật tên gì
- `health`: còn bao nhiêu máu
- `speed`: di chuyển nhanh cỡ nào
- `hasBow`: có mang cung hay không
- `rank`: xếp hạng hiện tại

Chỉ từ vài biến, chương trình đã có thể mô tả một phần trạng thái của nhân vật.

Đó là lý do biến là nền tảng của mọi hệ thống game.

## Cách đọc một dòng khai báo biến

Ví dụ:

```csharp
float attackRange = 2.5f;
```

Hãy tập đọc thành lời:

- `float`: biến này chứa số thập phân
- `attackRange`: tên biến là tầm đánh
- `=`: gán giá trị
- `2.5f`: giá trị ban đầu là `2.5`

Người mới tiến bộ nhanh hơn khi tập "đọc nghĩa" của code thay vì chỉ nhìn ký hiệu.

## Những lỗi đặt tên làm code khó hiểu

Ví dụ khó hiểu:

```csharp
int a = 100;
float x = 4.5f;
bool ok = true;
```

Người đọc sẽ phải đoán:

- `a` là gì
- `x` là gì
- `ok` nghĩa là trạng thái nào

Ví dụ dễ hiểu hơn:

```csharp
int playerHealth = 100;
float moveSpeed = 4.5f;
bool canOpenDoor = true;
```

Nguyên tắc thực tế:

- tên nói lên ý nghĩa
- tên càng gần bài toán càng tốt
- ưu tiên tên mà 1 tuần sau đọc lại vẫn hiểu

## Các nhầm lẫn rất thường gặp ở người mới

### Nhầm giữa "tên biến" và "giá trị"

Ví dụ:

```csharp
int health = 100;
```

Ở đây:

- `health` là tên
- `100` là giá trị

### Nhầm giữa `char` và `string`

```csharp
char firstLetter = 'K';
string fullName = "Knight";
```

### Nhầm giữa số và chữ số

```csharp
int score = 50;
string scoreText = "50";
```

Hai thứ này trông giống nhau khi in ra, nhưng bản chất khác nhau hoàn toàn.

### Quên rằng giá trị có thể thay đổi theo thời gian

Trong game, hiếm có biến nào đứng yên mãi.

Ví dụ:

- máu tăng giảm
- tiền cộng trừ
- trạng thái nhiệm vụ đổi từ chưa nhận sang đã nhận

## Tư duy quan trọng: kiểu dữ liệu mô tả ý nghĩa

Khi chọn kiểu dữ liệu, đừng chỉ hỏi:

- C# cho phép kiểu nào?

Hãy hỏi thêm:

- dữ liệu này đại diện cho cái gì?
- dữ liệu này có thể có phần lẻ không?
- dữ liệu này là tên, trạng thái hay số đếm?

Nếu bạn chọn kiểu dữ liệu theo ý nghĩa, code sẽ rõ ràng hơn rất nhiều.

## Tóm tắt bài học

- Biến là nơi lưu dữ liệu để dùng lại
- Kiểu dữ liệu quy định biến được chứa loại giá trị nào
- `int` dùng cho số nguyên
- `float` dùng cho số thập phân
- `string` dùng cho văn bản
- `bool` dùng cho trạng thái đúng sai
- `char` dùng cho một ký tự duy nhất
- Đặt tên tốt giúp code dễ hiểu hơn
- Chọn đúng kiểu dữ liệu giúp tránh lỗi ngay từ đầu

## Tự kiểm tra

Hãy tự trả lời mà không nhìn lại phần trên:

1. Biến khác gì với giá trị?
2. Vì sao `5.5` không phù hợp với `int`?
3. Khi nào nên dùng `bool` thay vì `int`?
4. `"A"` và `'A'` khác nhau thế nào?
5. Trong game, biến nào phù hợp cho số mạng còn lại?
6. Trong game, biến nào phù hợp cho tên vũ khí?
7. Trong game, biến nào phù hợp cho trạng thái còn sống hay đã chết?

## Gợi ý luyện tập

1. Tạo các biến cho một nhân vật game gồm tên, máu, tốc độ, có khiên hay không, hạng hiện tại.
2. Thử đổi giá trị máu 3 lần để mô phỏng nhân vật bị tấn công liên tục.
3. Tạo 5 biến đặt tên xấu, sau đó đổi lại thành tên rõ nghĩa hơn.
4. Viết một đoạn code in ra thông tin nhân vật dưới dạng nhiều dòng `Console.WriteLine`.
5. Tự nghĩ thêm 10 dữ liệu trong game và chọn kiểu dữ liệu phù hợp cho từng dữ liệu.
