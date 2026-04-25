# Bài 5: Observer Pattern cho Achievement và UI Máu

## Mục tiêu

- Hiểu Observer Pattern trong ngữ cảnh game
- Biết dùng `Action`, `Delegate`, `Event` để làm UI máu và achievement không cần `Update()`

## Ý tưởng chính

Khi dữ liệu đổi, hệ thống phát tín hiệu.

Những nơi quan tâm sẽ tự nghe và phản ứng.

Ví dụ:

- Player mất máu
- UI máu cập nhật ngay
- Achievement system kiểm tra thành tựu ngay

Không cần mỗi frame phải hỏi: máu có đổi chưa?

## Tại sao phải dùng cái này?

- giảm phụ thuộc
- giảm logic polling vô ích
- code sạch hơn

## Lỗi sai thường gặp của người mới

- Quên hủy đăng ký event trong Unity
- UI biết quá nhiều về class gameplay cụ thể
