# Bài 1: Generic Class

## Mục tiêu

- Hiểu generic là gì
- Biết vì sao `<T>` mạnh và an toàn
- Phân tích sâu generic class trong code game

## Generic là gì?

Generic cho phép bạn viết code tổng quát để làm việc với nhiều kiểu dữ liệu khác nhau mà vẫn giữ an toàn kiểu.

Ví dụ:

```csharp
class Box<T>
{
    public T Value;
}
```

`T` là một chỗ trống cho kiểu dữ liệu.

## Tại sao phải dùng cái này?

Nếu không dùng generic, bạn sẽ thường rơi vào:

- viết lại cùng một logic nhiều lần cho `int`, `string`, `Player`
- dùng `object` rồi phải ép kiểu tay
- dễ boxing/unboxing
- dễ lỗi runtime

Generic giải quyết việc đó.

## Ví dụ đời thường

Hãy tưởng tượng bạn có một mẫu hộp thông minh.

- hôm nay chứa táo
- mai chứa sách
- ngày kia chứa đồ chơi

Hộp vẫn là một mẫu chung, chỉ khác loại đồ bên trong.

## Generic class trong game

Ví dụ một kho dữ liệu:

```csharp
class Repository<T>
{
    private List<T> items = new List<T>();
}
```

Bạn có thể dùng cho:

- item
- enemy data
- quest data

## Tại sao `<T>` rất quan trọng trong architecture?

- tái sử dụng code
- giảm lặp logic
- tăng type safety
- dễ đọc hơn so với `object`

## So sánh với `object`

### Dùng `object`

- linh hoạt nhưng nguy hiểm
- phải ép kiểu
- dễ lỗi runtime

### Dùng generic

- rõ kiểu ngay từ đầu
- IDE hỗ trợ tốt hơn
- ít lỗi hơn

## Lỗi sai thường gặp của người mới

### 1. Thấy `<T>` là sợ vì trông lạ

Thực ra nó chỉ là một chỗ giữ chỗ cho kiểu dữ liệu.

### 2. Dùng generic khi bài toán chưa cần

### 3. Dùng `object` quá nhiều thay vì generic

## Ghi nhớ nhanh

- Generic = viết một lần, dùng cho nhiều kiểu
- `<T>` không đáng sợ, nó chỉ là ký hiệu đại diện kiểu dữ liệu
