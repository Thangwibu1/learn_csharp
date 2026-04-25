# Bài 2: Delegate, Action, Event

## Mục tiêu

- Hiểu delegate là gì
- Hiểu `Action`
- Hiểu `event`
- Thấy cách áp dụng vào game architecture kiểu Observer Pattern

## Delegate là gì?

Delegate là biến nhưng không lưu số hay chữ, mà lưu một hàm.

Nghe lạ, nhưng hãy hình dung nó như một remote điều khiển.

- remote không phải cái TV
- remote chỉ giữ cách để bấm gọi TV làm việc

Delegate giữ tham chiếu tới hàm để gọi sau.

## `Action` là gì?

`Action` là một dạng delegate viết gọn có sẵn trong C#.

```csharp
Action onPlayerDead;
```

## `event` là gì?

`event` là cơ chế phát tín hiệu để bên khác đăng ký nghe.

Ví dụ:

- Player mất máu
- UI máu cần cập nhật
- Achievement cần kiểm tra

Thay vì mỗi frame dùng `Update()`, ta phát sự kiện khi dữ liệu thật sự đổi.

## Tại sao phải dùng cái này?

Vì đây là nền móng của Observer Pattern.

Observer Pattern nghĩa là:

- một đối tượng phát thông báo khi có thay đổi
- các đối tượng quan tâm sẽ nghe và phản ứng

Rất hợp cho game:

- UI
- achievement
- quest
- audio
- analytics

## Observer Pattern với Event

Ví dụ:

- `PlayerHealth` có event `OnHealthChanged`
- `HealthUI` đăng ký nghe event
- `AchievementSystem` cũng có thể đăng ký nghe

Khi máu đổi:

- Player không cần biết UI cụ thể là ai
- chỉ phát event

Đây chính là decoupling.

## Không dùng `Update()` nếu không cần

Nhiều người mới hay kiểm tra máu liên tục trong `Update()`. Điều này vừa thừa vừa làm code rối.

Nếu máu chỉ đổi khi bị đánh hoặc hồi máu, tốt hơn là phát sự kiện đúng lúc đó.

## Lỗi sai thường gặp của người mới

### 1. Không hủy đăng ký event khi object bị hủy trong Unity

### 2. Dùng event cho mọi thứ kể cả logic rất cục bộ

### 3. Không hiểu delegate chỉ là cách gọi hàm gián tiếp

## Ghi nhớ nhanh

- Delegate: lưu tham chiếu tới hàm
- Action: delegate viết gọn
- Event: phát tín hiệu cho nơi khác lắng nghe
- Đây là nền móng để làm Observer Pattern sạch hơn
