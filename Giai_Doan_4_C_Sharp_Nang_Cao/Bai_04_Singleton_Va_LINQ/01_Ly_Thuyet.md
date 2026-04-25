# Bài 4: Singleton và LINQ Cơ Bản

## Mục tiêu

- Hiểu Singleton Pattern là gì
- Biết khi nào nên và không nên dùng Singleton
- Biết LINQ cơ bản để lọc dữ liệu

## Singleton là gì?

Singleton là mẫu thiết kế đảm bảo chỉ có đúng một instance của một class.

Ví dụ trong game:

- `GameManager`
- `AudioManager`
- `SaveManager`

## Tại sao người ta thích Singleton?

- tiện truy cập toàn cục
- dễ bắt đầu với dự án nhỏ

## Nhưng vì sao phải dùng cẩn thận?

Vì Singleton rất dễ biến thành "biến toàn cục mặc vest".

Hậu quả:

- code phụ thuộc lẫn nhau khó kiểm soát
- khó test
- khó thay thế
- dự án lớn dần sẽ dễ rối

## Khi nào nên dùng?

- hệ thống thật sự chỉ nên có 1 bản
- vòng đời rõ ràng
- trách nhiệm rõ ràng

## Khi nào không nên dùng?

- chỉ vì tiện truy cập từ mọi nơi
- class chưa thật sự cần duy nhất
- logic gameplay cốt lõi phụ thuộc quá nhiều vào singleton

## Cách dùng an toàn hơn

- giới hạn trách nhiệm của singleton
- không nhồi mọi thứ vào `GameManager`
- nếu dự án lớn, cân nhắc dependency injection hoặc service architecture sau này

## LINQ là gì?

LINQ là bộ công cụ giúp truy vấn dữ liệu gọn hơn.

Ví dụ:

```csharp
var highScores = scores.Where(score => score >= 100);
```

## Tại sao phải dùng LINQ?

Vì khi có danh sách item, enemy, quest, bạn thường cần:

- lọc
- sắp xếp
- tìm phần tử

LINQ giúp code gọn và dễ đọc hơn trong nhiều trường hợp.

## Lỗi sai thường gặp của người mới

### 1. Lạm dụng Singleton cho mọi hệ thống

### 2. Dùng LINQ mọi nơi mà không hiểu nó đang làm gì

### 3. Viết code ngắn quá mức thành khó đọc

## Ghi nhớ nhanh

- Singleton tiện nhưng phải dùng có kỷ luật
- LINQ giúp truy vấn dữ liệu gọn hơn
