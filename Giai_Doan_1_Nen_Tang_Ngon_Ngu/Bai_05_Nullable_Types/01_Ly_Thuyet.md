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

## Hiểu sâu hơn: `null` không có nghĩa là `0`

Đây là điểm quan trọng nhất của bài này.

Người mới thường nghĩ:

- không có gì thì dùng `0` là được

Nhưng trong rất nhiều tình huống, `0` và `null` mang ý nghĩa khác nhau hoàn toàn.

Ví dụ game:

- `gold = 0`: người chơi có dữ liệu vàng, và hiện tại vàng đang bằng 0
- `gold = null`: dữ liệu vàng chưa được tải, hoặc chưa có giá trị hợp lệ

Hai trường hợp này nhìn qua có vẻ giống nhau, nhưng cách xử lý trong game sẽ khác.

## Vì sao kiểu số bình thường không chứa `null`?

Với các kiểu như `int`, `float`, `bool`, C# mong đợi rằng biến phải luôn có một giá trị hợp lệ.

Ví dụ:

```csharp
int score = 0;
```

Ở đây `score` chắc chắn là một số nguyên.

Bạn không thể gán:

```csharp
int score = null;
```

vì `int` bình thường không cho phép điều đó.

Để nói rằng:

- biến này là số nguyên
- nhưng đôi khi chưa có giá trị

ta dùng kiểu nullable:

```csharp
int? score = null;
```

## Dấu `?` nghĩa là gì?

Khi viết:

```csharp
int?
```

Bạn đang nói với C# rằng:

- đây là `int`
- nhưng được phép có thêm trạng thái `null`

Tương tự:

```csharp
float?
bool?
```

Điều này rất hữu ích khi dữ liệu có thể ở trạng thái "chưa biết".

## Những tình huống game nên cân nhắc dùng nullable

### 1. Dữ liệu chưa được chọn

Ví dụ:

- người chơi chưa chọn nhân vật
- chưa chọn vũ khí chính
- chưa chọn độ khó

```csharp
int? selectedCharacterId = null;
```

### 2. Dữ liệu chưa tải xong

Ví dụ:

- đang đọc file save
- chưa nhận phản hồi từ server
- chưa lấy xong thông tin nhiệm vụ

```csharp
int? loadedGold = null;
```

### 3. Trạng thái chưa được xác nhận

Ví dụ:

- người chơi đã nhận nhiệm vụ chưa
- NPC đã đồng ý giao dịch chưa

Nếu dùng `bool`, bạn chỉ có `true` hoặc `false`.

Nhưng thực tế đôi khi bạn cần cả trạng thái:

- chưa biết

```csharp
bool? acceptedQuest = null;
```

Khi đó:

- `true`: đã chấp nhận
- `false`: đã từ chối
- `null`: chưa quyết định

## Cách kiểm tra nullable

Có vài cách phổ biến.

### Cách 1: so sánh trực tiếp với `null`

```csharp
int? reward = null;

if (reward == null)
{
    Console.WriteLine("Chua co phan thuong");
}
```

Đây là cách dễ hiểu với người mới.

### Cách 2: dùng `HasValue`

```csharp
int? reward = 100;

if (reward.HasValue)
{
    Console.WriteLine("Da co phan thuong");
}
```

`HasValue` trả về:

- `true` nếu biến có giá trị thật
- `false` nếu biến đang là `null`

### Cách 3: dùng `.Value` sau khi đã chắc chắn có dữ liệu

```csharp
int? reward = 100;

if (reward.HasValue)
{
    Console.WriteLine(reward.Value);
}
```

Rất quan trọng:

- chỉ dùng `.Value` khi bạn đã chắc chắn biến không phải `null`

Nếu không, chương trình có thể lỗi khi chạy.

## Toán tử `??` cực kỳ hữu ích

Toán tử `??` nghĩa là:

- nếu bên trái có giá trị thì lấy bên trái
- nếu bên trái là `null` thì lấy bên phải

Ví dụ:

```csharp
int? savedLives = null;
int livesToUse = savedLives ?? 3;
```

Nếu `savedLives` chưa có dữ liệu, game sẽ dùng `3` làm giá trị mặc định.

Đây là cách viết rất gọn và hay dùng trong thực tế.

## So sánh `0`, `false` và `null`

Đây là phần người mới rất hay nhầm.

### `0`

Là một giá trị số hợp lệ.

Ví dụ:

- người chơi có `0` vàng
- boss còn `0` máu

### `false`

Là một giá trị logic hợp lệ.

Ví dụ:

- người chơi chưa có chìa khóa
- nhiệm vụ chưa hoàn thành

### `null`

Là trạng thái không có giá trị, chưa có dữ liệu, hoặc chưa xác định.

Ví dụ:

- chưa biết người chơi có chìa khóa hay không vì dữ liệu chưa tải xong
- chưa biết nhiệm vụ đã nhận hay chưa vì chưa đọc save

## Ví dụ game: phần thưởng nhiệm vụ

```csharp
int? questReward = null;

if (questReward == null)
{
    Console.WriteLine("Nhiem vu chua co thuong");
}
else
{
    Console.WriteLine("Phan thuong la: " + questReward.Value);
}
```

Ở đây, `null` giúp bạn biểu diễn đúng ý nghĩa:

- chưa có phần thưởng nào được gán

Nếu chỉ dùng `0`, bạn sẽ khó phân biệt giữa:

- phần thưởng thật sự là `0`
- và chưa gán phần thưởng

## Ví dụ game: trạng thái chấp nhận nhiệm vụ

```csharp
bool? acceptedQuest = null;

if (acceptedQuest == null)
{
    Console.WriteLine("Nguoi choi chua tra loi");
}
else if (acceptedQuest == true)
{
    Console.WriteLine("Nguoi choi da nhan nhiem vu");
}
else
{
    Console.WriteLine("Nguoi choi da tu choi nhiem vu");
}
```

Đây là ví dụ rất hay để thấy nullable không chỉ áp dụng cho số, mà còn áp dụng cho trạng thái.

## Khi nào không nên dùng nullable?

Không phải cứ học được nullable là dùng ở mọi nơi.

Bạn không nên dùng nullable nếu dữ liệu luôn chắc chắn phải tồn tại.

Ví dụ:

- máu hiện tại của nhân vật trong lúc đang chơi thường luôn có giá trị
- tốc độ di chuyển của nhân vật thường luôn có giá trị
- số lượng mạng còn lại thường luôn có giá trị

Trong những trường hợp đó, dùng nullable chỉ làm code rối hơn.

## Các lỗi phổ biến

### 1. Dùng `.Value` quá sớm

Ví dụ nguy hiểm:

```csharp
int? score = null;
Console.WriteLine(score.Value);
```

Đoạn này có thể lỗi vì `score` chưa có giá trị thật.

### 2. Lấy `0` để thay cho `null` mà không nghĩ tới ý nghĩa

Điều này làm mất đi khả năng biểu diễn trạng thái "chưa có dữ liệu".

### 3. Dùng nullable ở khắp nơi

Nullable hữu ích, nhưng chỉ nên dùng khi bài toán thực sự cần trạng thái "chưa có giá trị".

## Tư duy quan trọng của bài này

Khi thiết kế dữ liệu, hãy tự hỏi:

- biến này có thể chưa có giá trị không?
- trạng thái "chưa biết" có quan trọng không?
- `0` hay `false` có đủ diễn đạt ý nghĩa thật của bài toán không?

Nếu câu trả lời là không, nullable có thể là lựa chọn đúng.

## Tóm tắt bài học

- `null` nghĩa là chưa có giá trị hoặc chưa có dữ liệu
- `int?`, `float?`, `bool?` là các kiểu nullable
- `0`, `false` và `null` không giống nhau
- `HasValue` dùng để kiểm tra có dữ liệu hay chưa
- `.Value` chỉ nên dùng sau khi chắc chắn biến không phải `null`
- `??` giúp gán giá trị mặc định khi biến đang là `null`

## Tự kiểm tra

1. `0` và `null` khác nhau thế nào?
2. Vì sao `int` thường không nhận `null`?
3. `int?` có ý nghĩa gì?
4. Khi nào nên dùng `bool?` thay vì `bool`?
5. Vì sao dùng `.Value` bừa bãi lại nguy hiểm?
6. Toán tử `??` giúp ích gì?
7. Hãy nêu một ví dụ game mà `null` thể hiện đúng ý nghĩa hơn `0`.

## Gợi ý luyện tập

1. Tạo biến `int? selectedMapId = null` và viết logic kiểm tra người chơi đã chọn bản đồ chưa.
2. Tạo biến `bool? acceptedQuest` và viết 3 nhánh xử lý cho `null`, `true`, `false`.
3. Tạo biến `float? savedVolume = null` rồi dùng `??` để lấy giá trị mặc định `0.8f`.
4. Nghĩ ra 5 dữ liệu trong game và quyết định dữ liệu nào nên dùng nullable, dữ liệu nào không nên.
5. Viết một đoạn mô tả bằng lời sự khác nhau giữa `reward = 0` và `reward = null`.
