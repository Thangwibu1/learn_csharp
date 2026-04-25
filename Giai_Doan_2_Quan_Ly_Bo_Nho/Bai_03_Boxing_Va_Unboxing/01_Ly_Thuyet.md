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
