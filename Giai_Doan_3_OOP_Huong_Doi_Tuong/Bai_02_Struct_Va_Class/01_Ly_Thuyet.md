# Bài 2: Struct và Class

## Mục tiêu

- Hiểu điểm khác nhau giữa `struct` và `class`
- Biết khi nào dùng từng loại

## Điểm giống nhau

Cả `struct` và `class` đều có thể chứa:

- dữ liệu
- method
- constructor

## Điểm khác nhau quan trọng

### `class`

- là reference type
- phù hợp cho object phức tạp
- thường dùng rất nhiều trong OOP và Unity

### `struct`

- là value type
- thường dùng cho dữ liệu nhỏ, đơn giản
- sao chép theo giá trị

## Tại sao phải dùng cái này?

Vì trong game có những dữ liệu nhỏ như:

- tọa độ
- màu sắc
- thống kê nhỏ

Những thứ này có thể phù hợp với `struct`.

Nhưng các thực thể lớn như Player, Enemy, Inventory thường hợp với `class` hơn.

## Ví dụ đời thường

- `class` giống một nhân vật thật trong game, có đời sống riêng
- `struct` giống một mẩu thông tin nhỏ như vị trí hoặc chỉ số

## Lỗi sai thường gặp của người mới

### 1. Dùng `struct` cho object lớn, nhiều trạng thái

### 2. Không biết `struct` sao chép theo giá trị

### 3. Mong `struct` cư xử như `class`

## Ghi nhớ nhanh

- `class` cho object phức tạp
- `struct` cho dữ liệu nhỏ, gọn, giá trị
