# Bài 2: GameObject và Component

## Mục tiêu

- Hiểu GameObject là gì
- Hiểu Component là gì
- Thấy rõ vì sao Unity thiên về Composition

## GameObject là gì?

GameObject là thực thể cơ bản trong Unity.

Nó giống như một chiếc khung rỗng.

## Component là gì?

Component là những mảnh chức năng gắn lên GameObject.

Ví dụ:

- `Transform`
- `SpriteRenderer`
- `Rigidbody`
- script của bạn

## Tại sao Unity làm vậy?

Vì composition giúp ghép tính năng linh hoạt hơn kế thừa sâu.

Một object có thể:

- vừa có hình ảnh
- vừa có va chạm
- vừa có âm thanh
- vừa có script điều khiển

## Lỗi sai thường gặp của người mới

- Nghĩ GameObject tự có mọi chức năng
- Không hiểu script cũng là một component
