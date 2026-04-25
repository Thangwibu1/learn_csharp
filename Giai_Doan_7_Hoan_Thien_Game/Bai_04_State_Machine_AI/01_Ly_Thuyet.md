# Bài 4: State Machine cho AI Quái

## Mục tiêu

- Hiểu state machine là gì
- Biết vì sao state machine quan trọng trong AI game

## State Machine là gì?

State machine là cách tổ chức hành vi theo từng trạng thái rõ ràng.

Ví dụ quái có thể ở các trạng thái:

- `Idle`
- `Chase`
- `Attack`

Tại một thời điểm, quái chỉ nên ở một trạng thái chính.

## Tại sao phải dùng cái này?

Nếu nhồi hết logic AI vào một `Update()` dài, code sẽ rất khó đọc và khó mở rộng.

State machine giúp:

- rõ ràng hơn
- dễ bảo trì hơn
- dễ thêm trạng thái mới hơn

## Vì sao đây là OOP tốt?

Mỗi state là một class riêng, có trách nhiệm riêng.

Đây là cách tách logic sạch hơn rất nhiều.

## Lỗi sai thường gặp của người mới

- Không tách state thành class riêng
- Cho state truy cập lung tung mọi dữ liệu
