# Bài 4: Vòng Lặp

## Mục tiêu

- Hiểu vòng lặp là gì
- Biết dùng `for`, `while`
- Biết khi nào nên lặp và khi nào nên dừng

## Vòng lặp là gì?

Vòng lặp là cách bảo máy tính làm đi làm lại một việc nhiều lần.

Ví dụ đời thường:

- đếm từ 1 đến 10
- phát 5 viên đạn
- tạo 10 con quái giống nhau

## Tại sao phải dùng cái này?

Nếu không có vòng lặp, bạn sẽ phải viết cùng một đoạn code rất nhiều lần.

Trong game, vòng lặp dùng cho:

- tạo nhiều vật thể
- duyệt danh sách đồ
- xử lý nhiều quái
- đếm ngược thời gian

## `for`

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

Ý nghĩa:

- bắt đầu từ `0`
- còn nhỏ hơn `5` thì còn chạy
- mỗi vòng tăng `1`

## `while`

```csharp
int count = 0;

while (count < 3)
{
    Console.WriteLine(count);
    count++;
}
```

`while` phù hợp khi bạn chưa biết chính xác lặp bao nhiêu lần, chỉ biết điều kiện dừng.

## `break` và `continue`

- `break`: dừng cả vòng lặp ngay lập tức
- `continue`: bỏ qua lần lặp hiện tại và sang lần kế tiếp

## Lỗi sai thường gặp của người mới

### 1. Quên tăng biến đếm trong `while`

Điều này dễ gây vòng lặp vô hạn.

### 2. Sai điều kiện dừng

Ví dụ muốn chạy 5 lần nhưng lại viết `i <= 5`, kết quả sẽ chạy 6 lần.

### 3. Dùng vòng lặp khi không cần

Nếu công việc chỉ làm 1 lần, không cần vòng lặp.

## Ví dụ game

```csharp
for (int bullet = 1; bullet <= 3; bullet++)
{
    Console.WriteLine("Ban ra vien dan thu " + bullet);
}
```

## Hiểu sâu hơn: vòng lặp giúp tránh lặp code

Hãy tưởng tượng bạn muốn in 10 dòng giống nhau.

Không dùng vòng lặp, bạn có thể phải viết:

```csharp
Console.WriteLine("Spawn enemy");
Console.WriteLine("Spawn enemy");
Console.WriteLine("Spawn enemy");
```

Viết như vậy có 3 vấn đề lớn:

- dài dòng
- khó sửa
- dễ sai khi số lần lặp thay đổi

Vòng lặp giải quyết điều đó bằng cách nói với máy tính:

- hãy làm việc này nhiều lần theo một quy tắc

Đây là một trong những công cụ tiết kiệm công sức nhất trong lập trình.

## Khi nào nên nghĩ tới vòng lặp?

Hãy tự hỏi:

- mình đang viết cùng một kiểu hành động nhiều lần phải không?
- mình có cần duyệt qua nhiều phần tử không?
- mình có cần đếm từ đầu đến cuối không?

Nếu câu trả lời là có, rất có thể bạn cần vòng lặp.

Ví dụ game:

- tạo 10 viên đạn
- duyệt 20 con quái
- đếm ngược từ 3 về 1 trước khi bắt đầu trận
- in ra danh sách vật phẩm trong kho đồ

## Phân tích kỹ vòng lặp `for`

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

Vòng `for` có 3 phần quan trọng:

### 1. Giá trị bắt đầu

```csharp
int i = 0;
```

Biến đếm bắt đầu từ `0`.

### 2. Điều kiện tiếp tục

```csharp
i < 5
```

Chỉ khi điều kiện còn đúng, vòng lặp mới chạy tiếp.

### 3. Bước thay đổi sau mỗi lần lặp

```csharp
i++
```

Mỗi lần chạy xong, `i` tăng thêm `1`.

Nếu đọc bằng lời, đoạn `for` trên nghĩa là:

- bắt đầu từ `0`
- còn nhỏ hơn `5` thì tiếp tục
- mỗi vòng tăng thêm `1`

## Vì sao nhiều ví dụ bắt đầu từ `0`?

Trong lập trình, rất nhiều thứ được đánh số từ `0`.

Ví dụ sau này bạn sẽ học mảng và danh sách.

Phần tử đầu tiên thường ở vị trí `0`, không phải `1`.

Vì vậy, làm quen với việc đếm từ `0` là rất quan trọng.

Tuy nhiên, không phải lúc nào cũng phải bắt đầu từ `0`.

Ví dụ đếm ngược trước trận đấu:

```csharp
for (int countdown = 3; countdown > 0; countdown--)
{
    Console.WriteLine(countdown);
}
```

## `for` phù hợp khi nào?

`for` rất hợp khi bạn biết khá rõ số lần lặp.

Ví dụ:

- bắn 3 viên đạn liên tiếp
- tạo 5 quái nhỏ
- in 10 dòng hướng dẫn

Nếu bạn đã biết gần như chắc chắn số lần cần lặp, hãy nghĩ tới `for` đầu tiên.

## Phân tích kỹ vòng lặp `while`

```csharp
int energy = 3;

while (energy > 0)
{
    Console.WriteLine("Dang dao mo");
    energy--;
}
```

`while` có nghĩa là:

- còn đúng điều kiện thì còn lặp

Khác với `for`, `while` phù hợp hơn khi bạn chưa biết chính xác số lần lặp từ đầu.

Ví dụ game:

- còn máu thì boss còn chiến đấu
- còn đạn thì súng còn bắn
- còn nhiệm vụ chưa xong thì còn tiếp tục xử lý

## So sánh nhanh `for` và `while`

### Dùng `for` khi:

- biết số lần lặp khá rõ
- có biến đếm tăng giảm đều
- muốn gom đủ 3 phần khởi tạo, điều kiện, cập nhật trên một dòng

### Dùng `while` khi:

- chỉ biết điều kiện dừng
- số lần lặp phụ thuộc trạng thái trong lúc chạy
- muốn kiểm soát việc cập nhật biến ở bên trong khối lặp

Không có loại nào "xịn hơn" loại nào.

Quan trọng là dùng đúng ngữ cảnh.

## Vòng lặp vô hạn là gì?

Đây là lỗi rất phổ biến của người mới.

Ví dụ:

```csharp
int count = 0;

while (count < 5)
{
    Console.WriteLine(count);
}
```

Lỗi ở đây là `count` không bao giờ thay đổi.

Nó luôn là `0`, nên điều kiện `count < 5` luôn đúng.

Kết quả:

- vòng lặp không dừng
- chương trình có thể treo hoặc spam vô tận

Sửa đúng:

```csharp
int count = 0;

while (count < 5)
{
    Console.WriteLine(count);
    count++;
}
```

## `break` và `continue` trong thực tế

### `break`

Dùng khi bạn muốn thoát hẳn khỏi vòng lặp ngay lập tức.

Ví dụ game:

- tìm thấy boss rồi thì dừng tìm tiếp
- nhấn nút hủy thì thoát khỏi quá trình dò tìm

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }

    Console.WriteLine(i);
}
```

### `continue`

Dùng khi bạn muốn bỏ qua vòng hiện tại nhưng vẫn chạy các vòng sau.

Ví dụ game:

- bỏ qua quái đã chết
- bỏ qua ô trống trong inventory

```csharp
for (int i = 0; i < 5; i++)
{
    if (i == 2)
    {
        continue;
    }

    Console.WriteLine(i);
}
```

## Ví dụ game: bắn nhiều viên đạn

```csharp
for (int bullet = 1; bullet <= 5; bullet++)
{
    Console.WriteLine("Ban vien dan thu " + bullet);
}
```

Ý nghĩa:

- vòng đầu là viên 1
- vòng cuối là viên 5
- mỗi vòng đại diện cho một lần bắn

Bạn đã biến một hành động lặp lại thành một khuôn mẫu có thể tái sử dụng.

## Ví dụ game: đếm ngược bắt đầu trận đấu

```csharp
for (int timeLeft = 3; timeLeft >= 1; timeLeft--)
{
    Console.WriteLine("Tran dau bat dau sau: " + timeLeft);
}

Console.WriteLine("Chien dau!");
```

Đây là dạng vòng lặp giảm dần, rất hay gặp trong game.

## Ví dụ game: hồi máu theo thời gian

```csharp
int healTimes = 3;
int health = 40;

while (healTimes > 0)
{
    health += 10;
    healTimes--;
    Console.WriteLine("Mau hien tai: " + health);
}
```

Ở đây:

- điều kiện lặp là còn lượt hồi máu
- mỗi vòng máu tăng thêm `10`
- biến đếm giảm dần cho tới khi hết lượt

## Sai lầm về điều kiện dừng

Người mới rất hay nhầm giữa:

- `< 5`
- `<= 5`

Ví dụ:

```csharp
for (int i = 0; i < 5; i++)
```

Đoạn này chạy với `i = 0, 1, 2, 3, 4`.

Tổng cộng là 5 lần.

Trong khi đó:

```csharp
for (int i = 0; i <= 5; i++)
```

Đoạn này chạy với `i = 0, 1, 2, 3, 4, 5`.

Tổng cộng là 6 lần.

Chỉ khác một dấu, nhưng kết quả khác hẳn.

## Tư duy kiểm tra vòng lặp bằng tay

Khi chưa quen, hãy tự mô phỏng vài vòng đầu tiên trên giấy.

Ví dụ với:

```csharp
for (int i = 1; i <= 3; i++)
```

Hãy lần lượt viết:

- bắt đầu `i = 1`
- kiểm tra `1 <= 3`, đúng
- chạy thân vòng lặp
- tăng `i` thành `2`
- kiểm tra `2 <= 3`, đúng
- chạy tiếp
- tăng `i` thành `3`
- kiểm tra `3 <= 3`, đúng
- chạy tiếp
- tăng `i` thành `4`
- kiểm tra `4 <= 3`, sai
- dừng

Nếu bạn tập mô phỏng như vậy 10 lần, bạn sẽ hiểu vòng lặp chắc hơn rất nhiều.

## Tóm tắt bài học

- Vòng lặp giúp lặp lại hành động mà không phải viết code trùng lặp
- `for` phù hợp khi biết khá rõ số lần lặp
- `while` phù hợp khi chủ yếu biết điều kiện dừng
- `break` dùng để thoát hẳn vòng lặp
- `continue` dùng để bỏ qua vòng hiện tại
- Cần đặc biệt cẩn thận với điều kiện dừng để tránh lặp vô hạn

## Tự kiểm tra

1. Khi nào bạn nên dùng `for` thay vì `while`?
2. Vì sao quên cập nhật biến trong `while` dễ gây lỗi nghiêm trọng?
3. `i < 5` và `i <= 5` khác nhau thế nào?
4. `break` khác `continue` ở đâu?
5. Vì sao vòng lặp rất quan trọng trong game?
6. Hãy giải thích bằng lời vòng lặp `for (int i = 0; i < 3; i++)`.
7. Vòng lặp nào phù hợp hơn cho đếm ngược từ 10 về 1?

## Gợi ý luyện tập

1. Viết vòng `for` in ra số từ `1` đến `10`.
2. Viết vòng `for` mô phỏng bắn ra 7 viên đạn.
3. Viết vòng `while` làm nhân vật hồi máu cho tới khi đủ `100` máu.
4. Viết vòng lặp đếm ngược từ `5` về `1`, sau đó in ra `Bat dau!`.
5. Viết vòng lặp bỏ qua các số chẵn và chỉ in số lẻ từ `1` đến `10` bằng `continue`.
