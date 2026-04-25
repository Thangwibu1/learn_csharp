# Bài 1: Stack và Heap

## Mục tiêu

- Hiểu bộ nhớ là nơi dữ liệu sống tạm trong lúc chương trình chạy
- Hiểu khác nhau giữa `stack` và `heap`
- Biết vì sao điều này quan trọng với C# và Unity

## Bộ nhớ là gì?

Khi chương trình chạy, nó cần chỗ để cất dữ liệu. Chỗ đó gọi là bộ nhớ.

Trong C#, người mới thường nghe hai vùng quan trọng:

- `stack`
- `heap`

## Hình dung đơn giản

### Stack

Hãy tưởng tượng một chồng đĩa.

- đặt đĩa mới lên trên cùng
- lấy đĩa cũng lấy từ trên cùng xuống

Stack nhanh, gọn, phù hợp cho dữ liệu nhỏ và ngắn hạn.

### Heap

Hãy tưởng tượng một kho hàng lớn.

- đồ có thể nằm ở nhiều chỗ khác nhau
- linh hoạt hơn
- quản lý phức tạp hơn

Heap thường chứa object, dữ liệu lớn hơn hoặc sống lâu hơn.

## Tại sao phải dùng cái này?

Vì khi học sâu hơn về `class`, `struct`, truyền tham số, tối ưu game, bạn cần biết dữ liệu đang được cất ở đâu và hành vi của nó ra sao.

Trong Unity, hiểu điều này giúp bạn:

- tránh tạo rác bộ nhớ quá nhiều
- hiểu vì sao một số object bị chia sẻ dữ liệu
- hiểu vì sao performance có thể tụt khi tạo hủy object liên tục

## Quy tắc nhớ nhanh

- `value type` thường đi với stack nhiều hơn
- `reference type` thường trỏ tới dữ liệu ở heap

Ví dụ thường gặp:

- `int`, `float`, `bool`, `struct` thường là value type
- `class`, `string`, array thường là reference type

## Ví dụ ý tưởng

```csharp
int hp = 100;
Player player = new Player();
```

- `hp` là dữ liệu giá trị đơn giản
- `player` là biến tham chiếu tới một object

## Garbage Collector

Với heap, C# có bộ dọn rác gọi là Garbage Collector.

Bạn có thể hiểu nó như người dọn kho:

- món nào không còn ai dùng thì dọn đi

Điều này tiện, nhưng nếu tạo rác quá nhiều trong game, đôi khi có thể gây giật khung hình.

## Lỗi sai thường gặp của người mới

### 1. Nghĩ mọi thứ đều hoạt động giống nhau

`int` và `class` không có hành vi sao chép giống nhau.

### 2. Không hiểu vì sao sửa object ở một nơi lại ảnh hưởng nơi khác

Lý do thường đến từ tham chiếu cùng trỏ đến một object trên heap.

### 3. Tối ưu quá sớm

Hiểu stack/heap là tốt, nhưng đừng ám ảnh tối ưu từ ngày đầu.

## Ghi nhớ nhanh

- Stack: nhanh, ngắn hạn, gọn
- Heap: linh hoạt, chứa object, cần dọn rác
- Kiến thức này là nền móng cho OOP và tối ưu Unity

## Hiểu sâu hơn: vì sao người mới hay sợ bài này?

`Stack` và `heap` là chủ đề dễ làm người mới thấy trừu tượng.

Lý do là vì bạn không nhìn thấy bộ nhớ bằng mắt thường.

Nhưng bạn không cần học theo kiểu quá học thuật ngay từ đầu.

Chỉ cần nắm được những ý thực dụng sau:

- dữ liệu khi chương trình chạy phải nằm ở đâu đó trong bộ nhớ
- có loại dữ liệu được xử lý như giá trị trực tiếp
- có loại dữ liệu được xử lý như tham chiếu tới object
- hiểu điều này giúp bạn lý giải được rất nhiều hành vi "tại sao lại thế"

## Cách hình dung đơn giản nhưng đúng hướng

### Stack giống khu làm việc nhỏ và rất nhanh

Bạn có thể tưởng tượng stack như một bàn làm việc nhỏ ngay cạnh tay.

- lấy ra nhanh
- đặt vào nhanh
- dùng cho các thứ nhỏ và tạm thời

### Heap giống một kho lớn

Bạn có thể tưởng tượng heap như kho chứa đồ phía sau.

- chứa được nhiều thứ phức tạp hơn
- linh hoạt hơn
- quản lý chậm và nặng hơn một chút

Điều quan trọng không phải là học thuộc ẩn dụ, mà là hiểu hậu quả của nó:

- thao tác với dữ liệu đơn giản thường gọn hơn
- object phức tạp thường cần cơ chế quản lý khác

## Value type và reference type liên quan thế nào?

Bài này gần như là phần chuẩn bị cho bài kế tiếp.

Bạn nên nhớ mối liên hệ rất thực tế:

- value type thường mang theo dữ liệu của chính nó
- reference type thường giữ tham chiếu tới object

Ví dụ:

```csharp
int hp = 100;
string playerName = "Knight";
Player player = new Player();
```

Trong tư duy người mới:

- `hp` giống như giữ con số trực tiếp
- `player` giống như giữ một đường dẫn tới object người chơi

Đừng quá ám ảnh phải phân tích chi tiết mức máy ảo ở giai đoạn này.

Điều cần nhớ là hành vi của chúng khác nhau.

## Vì sao điều này quan trọng trong Unity và game?

Làm game là làm việc với rất nhiều object:

- người chơi
- quái
- viên đạn
- hiệu ứng
- UI
- vật phẩm

Nếu bạn liên tục tạo object mới rồi bỏ đi, heap có thể tích nhiều rác hơn.

Khi Garbage Collector chạy để dọn, game có thể bị khựng.

Không phải dự án nhỏ nào cũng gặp vấn đề lớn ngay, nhưng đây là lý do người làm Unity sớm hay nghe về GC.

## Ví dụ tư duy với dữ liệu đơn giản và object

```csharp
int damage = 25;
Enemy enemy = new Enemy();
```

Ta nên hiểu ở mức cơ bản như sau:

- `damage` là dữ liệu đơn giản, đại diện cho một con số
- `enemy` là một biến tham chiếu tới một object phức tạp hơn

Object `enemy` có thể chứa rất nhiều dữ liệu bên trong:

- máu
- tên
- vị trí
- trạng thái còn sống hay không

Đây là lý do các object thường được gắn với cách quản lý kiểu reference.

## Hàm gọi xong thì chuyện gì xảy ra?

Một cách hiểu gần đúng và hữu ích là:

- khi bạn vào một hàm, một vùng làm việc tạm thời được dùng cho lần gọi đó
- khi hàm kết thúc, vùng tạm thời này kết thúc theo

Ví dụ:

```csharp
void ShowDamage()
{
    int damage = 10;
    Console.WriteLine(damage);
}
```

Biến `damage` ở đây chỉ phục vụ trong phạm vi lời gọi hàm đó.

Điều này giúp người mới hiểu vì sao có những dữ liệu "sống ngắn" và có những dữ liệu gắn với object "sống lâu hơn".

## Garbage Collector là bạn tốt, nhưng không miễn phí

C# giúp bạn đỡ phải tự giải phóng bộ nhớ như một số ngôn ngữ khác.

Đó là ưu điểm rất lớn.

Nhưng điều này không có nghĩa là:

- tạo object bao nhiêu cũng được
- boxing bao nhiêu cũng không sao
- cấp phát liên tục mỗi frame là ổn

Trong game, đặc biệt là Unity, nếu tạo rác bộ nhớ liên tục:

- Garbage Collector sẽ phải dọn nhiều hơn
- có thể gây giật hình ở thời điểm dọn

## Ví dụ game: tạo đạn liên tục

Nếu mỗi lần bắn bạn tạo object mới liên tục, rồi hủy nó ngay sau đó, điều này có thể tạo áp lực lên heap.

Về lâu dài, bạn sẽ học các kỹ thuật như object pooling.

Nhưng để hiểu vì sao pooling tồn tại, bạn cần hiểu trước rằng:

- object trên heap có chi phí quản lý
- tạo rồi bỏ đi quá nhiều không phải lúc nào cũng tốt

## Sai lầm thường gặp khi học bài này

### 1. Nghĩ `stack = tốt`, `heap = xấu`

Không đúng.

Cả hai đều cần thiết.

Không có heap, bạn khó làm việc với object linh hoạt.

Không có stack, việc xử lý dữ liệu ngắn hạn sẽ kém hiệu quả hơn.

### 2. Học thuộc máy móc mà không gắn với hành vi code

Điều quan trọng không phải là đọc thuộc định nghĩa.

Điều quan trọng là khi gặp hiện tượng như:

- sửa object ở một nơi, nơi khác cũng đổi
- tạo nhiều object làm game khựng

thì bạn biết bài `stack/heap` có liên quan.

### 3. Tối ưu quá sớm

Đừng vừa học xong `stack/heap` là đi tối ưu mọi biến.

Trước tiên hãy:

- hiểu đúng
- viết code rõ ràng
- sau đó mới học tối ưu có đo đạc

## Điều nên nhớ ở mức người mới

Nếu bạn chưa làm dự án lớn, hãy nhớ 4 ý đủ dùng:

1. Chương trình cần bộ nhớ để chứa dữ liệu khi chạy.
2. Dữ liệu đơn giản và object không hoạt động y hệt nhau.
3. Heap thường liên quan tới object và Garbage Collector.
4. Hiểu điều này sẽ giúp bạn học tốt hơn các bài về class, reference, boxing và tối ưu Unity.

## Ví dụ game: thông tin người chơi

```csharp
int playerLevel = 5;
float moveSpeed = 4.5f;
Player player = new Player();
```

Hãy diễn giải:

- `playerLevel` là dữ liệu mức đơn giản
- `moveSpeed` là dữ liệu mức đơn giản
- `player` là một object có thể chứa nhiều dữ liệu và hành vi hơn

Khi dự án lớn dần, sự khác biệt này càng quan trọng.

## Tóm tắt bài học

- Bộ nhớ là nơi dữ liệu sống trong lúc chương trình chạy
- `stack` thường gắn với dữ liệu nhỏ, ngắn hạn, thao tác nhanh
- `heap` thường gắn với object và dữ liệu phức tạp hơn
- C# có Garbage Collector để dọn dữ liệu trên heap không còn dùng nữa
- Trong game, tạo rác bộ nhớ quá nhiều có thể ảnh hưởng hiệu năng
- Bài này là nền tảng để hiểu `class`, `reference`, `boxing`, và tối ưu Unity về sau

## Tự kiểm tra

1. Vì sao chương trình cần bộ nhớ khi chạy?
2. Bạn hình dung `stack` và `heap` khác nhau ra sao?
3. Vì sao object thường gắn với heap trong cách học cơ bản?
4. Garbage Collector làm nhiệm vụ gì?
5. Vì sao tạo nhiều object liên tục trong game có thể gây vấn đề?
6. Bài `stack/heap` liên quan gì tới việc học OOP sau này?
7. Vì sao không nên tối ưu quá sớm chỉ vì vừa học xong bài này?

## Gợi ý luyện tập

1. Viết ra 10 dữ liệu trong game và thử phân loại dữ liệu nào là đơn giản, dữ liệu nào là object.
2. Tự giải thích bằng lời vì sao `Player player = new Player();` khác cảm giác với `int hp = 100;`.
3. Tìm 3 tình huống trong game có thể tạo nhiều rác bộ nhớ nếu viết bất cẩn.
4. Viết một đoạn tóm tắt 5 câu về vai trò của Garbage Collector.
5. Tự đặt câu hỏi: nếu game tạo và hủy hàng nghìn viên đạn liên tục, bài học này gợi ý điều gì cần chú ý?
