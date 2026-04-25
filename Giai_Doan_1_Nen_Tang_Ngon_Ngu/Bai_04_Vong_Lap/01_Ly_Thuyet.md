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
