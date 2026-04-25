# Bài 3: Boxing và Unboxing

## Mục tiêu

- Hiểu boxing là gì
- Hiểu unboxing là gì
- Biết vì sao nên cẩn thận với chúng trong code C# cũ hoặc code tối ưu

## Boxing là gì?

Boxing là đưa một value type vào một nơi chờ kiểu tham chiếu như `object`.

```csharp
int score = 10;
object boxedScore = score;
```

Bạn có thể hình dung:

- dữ liệu nhỏ gọn ban đầu là số nguyên
- sau đó nó bị bọc vào một chiếc hộp lớn hơn là `object`

## Unboxing là gì?

Lấy dữ liệu value type từ `object` ra lại.

```csharp
object boxedScore = 10;
int score = (int)boxedScore;
```

## Tại sao phải dùng cái này?

Ngày nay C# có Generics giúp tránh boxing trong nhiều trường hợp, nhưng bạn vẫn cần hiểu nó vì:

- đọc code cũ
- hiểu hiệu năng
- hiểu vì sao generics tốt hơn trong collections

## Tác hại nếu lạm dụng

- tốn thêm chi phí
- có thể tạo thêm áp lực bộ nhớ
- dễ gây lỗi ép kiểu khi unboxing sai

## Ví dụ đời thường

Bạn có một quả bóng nhỏ vừa tay.

- Boxing: nhét nó vào một thùng lớn có nhãn chung là "đồ vật"
- Unboxing: mở thùng ra và lấy quả bóng đúng loại

Nếu trong thùng không phải quả bóng mà bạn vẫn tưởng là bóng, bạn sẽ gặp lỗi.

## Lỗi sai thường gặp của người mới

### 1. Không hiểu vì sao ép kiểu sai bị lỗi runtime

### 2. Dùng `ArrayList` hay `object` quá nhiều thay vì Generic collection

### 3. Không thấy chi phí ẩn của boxing

## Ghi nhớ nhanh

- Boxing: value type -> object
- Unboxing: object -> value type
- Generics thường giúp tránh vấn đề này tốt hơn

## Hiểu sâu hơn: vì sao bài này tồn tại?

Người mới thường nhìn bài `boxing` và tự hỏi:

- em đâu có chủ động dùng cái này nhiều
- tại sao phải học một khái niệm nghe có vẻ xa lạ như vậy

Câu trả lời là vì bài này giúp bạn hiểu 3 chuyện rất thực tế:

- vì sao `object` không phải lúc nào cũng vô hại
- vì sao code kiểu cũ có thể chậm hoặc tốn bộ nhớ hơn
- vì sao Generic collection như `List<int>` thường tốt hơn cách dùng `object`

## Boxing thực chất đang làm gì?

Khi một value type như `int` bị đưa vào nơi mong đợi `object`, dữ liệu đó phải được "bọc" lại.

Ví dụ:

```csharp
int score = 10;
object data = score;
```

Bạn có thể hiểu ở mức đơn giản:

- ban đầu `score` là dữ liệu giá trị
- khi gán vào `object`, C# tạo một dạng đại diện kiểu tham chiếu cho giá trị đó

Điều này tạo ra chi phí mà người mới thường không nhìn thấy ngay.

## Unboxing thực chất đang làm gì?

Khi lấy dữ liệu trở lại từ `object`, bạn phải nói rõ kiểu thật.

```csharp
object data = 10;
int score = (int)data;
```

Bạn đang nói với C# rằng:

- tôi tin object này thực ra chứa một `int`
- hãy lấy `int` đó ra cho tôi

Nếu bạn đoán sai kiểu, chương trình có thể lỗi khi chạy.

## Ví dụ đời thực dễ nhớ

Hãy tưởng tượng bạn có một viên ngọc nhỏ.

- Boxing: bỏ viên ngọc vào một chiếc hộp chung có nhãn "đồ vật"
- Unboxing: mở hộp ra và lấy lại đúng viên ngọc đó

Vấn đề là nếu bạn tưởng trong hộp là ngọc nhưng thực tế là chìa khóa, bạn sẽ lấy sai thứ.

Đó là hình ảnh gần giống với lỗi ép kiểu sai khi unboxing.

## Tại sao boxing có chi phí?

Vì đây không chỉ là đổi tên kiểu dữ liệu.

Nó có thể kéo theo:

- thêm thao tác bọc dữ liệu
- thêm chi phí bộ nhớ
- thêm áp lực cho Garbage Collector nếu xảy ra nhiều

Với một lần thì không đáng kể.

Nhưng nếu diễn ra liên tục trong game hoặc trong vòng lặp lớn, nó có thể trở thành vấn đề.

## Ví dụ game: bảng điểm tạm chứa `object`

Giả sử bạn có hệ thống cũ lưu nhiều kiểu dữ liệu bằng `object`.

```csharp
object scoreData = 150;
int score = (int)scoreData;
```

Đoạn code này chạy được, nhưng:

- giá trị `150` đã bị boxing khi vào `object`
- rồi bị unboxing khi lấy ra thành `int`

Nếu việc này lặp lại hàng nghìn lần, chi phí sẽ tăng lên.

## Lỗi nguy hiểm khi unboxing sai kiểu

Ví dụ:

```csharp
object data = 10;
float speed = (float)data;
```

Người mới có thể nghĩ:

- `10` là số mà, ép sang `float` chắc được

Nhưng ở đây object đang chứa một `int` đã boxed, không phải một `float` boxed.

Vì vậy unboxing sai kiểu có thể gây lỗi runtime.

Đây là điểm rất quan trọng:

- unboxing yêu cầu đúng kiểu gốc đã được boxed

## Vì sao Generics giúp tốt hơn?

Hãy so sánh ý tưởng:

- lưu số nguyên trong cấu trúc chỉ biết `object`
- lưu số nguyên trong cấu trúc biết rõ kiểu `int`

Khi dùng Generics như `List<int>`:

- chương trình biết rõ phần tử là `int`
- không cần bọc qua `object` trong nhiều trường hợp
- an toàn kiểu tốt hơn
- tránh bớt boxing/unboxing không cần thiết

Đó là lý do C# hiện đại rất chuộng Generic collection.

## Dấu hiệu trong code cho thấy có thể có boxing

Bạn nên cảnh giác khi thấy:

- gán value type vào `object`
- dùng API cũ nhận `object`
- dùng collection kiểu cũ như `ArrayList`

Ví dụ:

```csharp
int hp = 100;
object obj = hp;
```

Đây là mẫu boxing điển hình.

## Dấu hiệu trong code cho thấy có thể có unboxing

Hãy chú ý các chỗ ép kiểu từ `object` về value type:

```csharp
object obj = 100;
int hp = (int)obj;
```

Đây là mẫu unboxing điển hình.

Khi đọc loại code này, hãy tự hỏi:

- object này chứa kiểu gì thật sự?
- kiểu ép xuống có khớp không?

## Liên hệ với hiệu năng trong game

Game thường có nhiều đoạn code chạy liên tục:

- mỗi frame
- trong vòng lặp xử lý nhiều enemy
- trong hệ thống UI cập nhật liên tục

Nếu boxing xảy ra lặp đi lặp lại ở những chỗ nóng này, hiệu năng có thể bị ảnh hưởng.

Bạn không cần sợ hãi quá mức.

Nhưng bạn nên có nhận thức rằng:

- có những chi phí ẩn trong code tưởng như vô hại

## Khi nào người mới cần thật sự quan tâm?

Ở giai đoạn đầu, bạn không cần soi từng dòng để săn boxing.

Nhưng bạn nên nhớ bài này để khi:

- đọc code cũ
- học tối ưu
- thấy người khác nhắc tới `boxing allocation`

thì bạn hiểu họ đang nói gì.

## Sai lầm phổ biến

### 1. Nghĩ boxing chỉ là đổi kiểu bình thường

Không hẳn.

Nó có thể mang theo chi phí bộ nhớ và hiệu năng.

### 2. Ép kiểu lại từ `object` mà không chắc kiểu gốc

Đây là cách rất dễ gây lỗi runtime.

### 3. Dùng `object` ở mọi nơi vì thấy "linh hoạt"

Linh hoạt quá mức có thể đổi lấy:

- mất an toàn kiểu
- khó đọc code
- thêm boxing/unboxing

## Tư duy thực dụng nên mang theo

Bạn không cần thuộc lòng mọi chi tiết kỹ thuật.

Chỉ cần nhớ:

1. Value type vào `object` có thể gây boxing.
2. Lấy ra lại cần unboxing đúng kiểu.
3. Boxing/unboxing có chi phí.
4. Generics thường là giải pháp hiện đại và an toàn hơn.

## Tóm tắt bài học

- Boxing là đưa value type vào `object` hoặc nơi cần kiểu tham chiếu
- Unboxing là lấy giá trị ra lại từ `object` với đúng kiểu
- Unboxing sai kiểu có thể gây lỗi runtime
- Boxing có thể tạo thêm chi phí bộ nhớ và hiệu năng
- Generic collection thường giúp tránh nhiều trường hợp boxing/unboxing không cần thiết

## Tự kiểm tra

1. Boxing là gì?
2. Unboxing là gì?
3. Vì sao unboxing sai kiểu lại nguy hiểm?
4. Vì sao boxing có thể ảnh hưởng hiệu năng?
5. Dấu hiệu nào trong code cho thấy có thể đang boxing?
6. Vì sao `List<int>` thường tốt hơn cấu trúc chỉ nhận `object` cho dữ liệu số nguyên?
7. Trong game, vì sao những chi phí nhỏ lặp lại nhiều lần lại trở nên đáng chú ý?

## Gợi ý luyện tập

1. Viết một ví dụ đơn giản gán `int` vào `object`, sau đó ép ngược về `int` và giải thích đâu là boxing, đâu là unboxing.
2. Tự viết một ví dụ unboxing sai kiểu và mô tả vì sao nó nguy hiểm dù chưa cần chạy thật.
3. Liệt kê 3 lý do vì sao Generic collection tốt hơn cách dùng `object` cho dữ liệu cùng kiểu.
4. Tự giải thích bằng lời sự khác nhau giữa "linh hoạt kiểu `object`" và "an toàn kiểu của Generic".
5. Nghĩ ra một hệ thống game cũ dùng `object` nhiều nơi và mô tả rủi ro có thể xuất hiện.
