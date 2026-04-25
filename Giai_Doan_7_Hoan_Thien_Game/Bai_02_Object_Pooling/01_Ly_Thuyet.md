# Bài 2: Object Pooling

## Mục tiêu

- Hiểu object pooling là gì
- Biết vì sao pooling quan trọng với game

## Object Pooling là gì?

Thay vì tạo mới và hủy object liên tục, ta tạo sẵn một nhóm object rồi tái sử dụng.

## Tại sao phải dùng cái này?

Trong game có những object xuất hiện liên tục:

- đạn
- hiệu ứng nổ
- quái nhỏ

Tạo hủy liên tục có thể gây tốn chi phí và tạo rác bộ nhớ.

## Vì sao `Queue<T>` hợp ở đây?

Vì pool thường có luồng lấy ra và trả về theo thứ tự dễ quản lý.

## Lỗi sai thường gặp của người mới

- Tạo pool nhưng vẫn `Instantiate` lung tung
- Không trả object về pool
