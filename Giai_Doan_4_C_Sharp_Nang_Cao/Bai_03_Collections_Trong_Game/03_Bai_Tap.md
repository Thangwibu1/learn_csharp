# Bài tập Bài 3

## Bài 1

Dùng `List<string>` làm inventory có ít nhất 4 item.

## Bài 2

Dùng `Dictionary<string, int>` để lưu tên item và giá bán.

## Bài 3

Dùng `Queue<string>` để mô phỏng pool của 3 viên đạn.

## Bài 4

Dùng `Stack<string>` để mô phỏng mở 3 menu chồng lên nhau rồi đóng dần.

## Bài 5

Tự giải thích vì sao `Dictionary` hợp cho crafting lookup hơn `List` trong nhiều trường hợp.

## Phần A - Mục tiêu ôn tập

- Chọn đúng collection theo bài toán.
- Không dùng `List<T>` cho mọi tình huống theo thói quen.
- Hiểu rõ khi nào nên dùng `Dictionary`, `Queue`, `Stack`.
- Liên hệ collections với inventory, crafting, pooling, UI menu và quest.

## Phần B - Khởi động với List

### Bài 6

Tạo `List<string>` làm inventory có ít nhất 6 item.

Yêu cầu:

- In toàn bộ item.
- Xóa item ở vị trí số 2.
- In lại danh sách.

Tự kiểm tra:

- Sau khi xóa, vị trí các phần tử phía sau thay đổi như thế nào?

### Bài 7

Tạo `List<int>` lưu điểm qua 5 màn.

Yêu cầu:

- Tính tổng điểm.
- Tìm điểm cao nhất.
- Tìm điểm thấp nhất.

### Bài 8

Tạo `List<Player>` với class `Player` có tên và level.

Yêu cầu:

- Thêm ít nhất 4 người chơi.
- In theo thứ tự đã thêm.

### Bài 9

Mô phỏng quest log bằng `List<string>`.

Yêu cầu:

- Có quest đang hoạt động.
- Có thao tác thêm quest mới.
- Có thao tác xóa quest đã hoàn thành.

### Bài 10

Giải thích vì sao inventory theo slot thường dễ bắt đầu với `List<T>`.

## Phần C - Dictionary cho tra cứu nhanh

### Bài 11

Tạo `Dictionary<string, int>` lưu giá bán item.

Yêu cầu:

- Có ít nhất 5 item.
- Tra cứu giá của 2 item cụ thể.
- In toàn bộ bảng giá.

### Bài 12

Tạo `Dictionary<string, string>` cho crafting recipe.

Yêu cầu:

- Khóa là công thức như `"Wood+Stone"`.
- Giá trị là item tạo ra.

### Bài 13

Tạo `Dictionary<string, float>` cho cooldown kỹ năng.

Yêu cầu:

- `dash`
- `heal`
- `fireball`
- `shield`

### Bài 14

Tạo `Dictionary<int, string>` map level sang rank.

Yêu cầu:

- Level 1 -> Bronze
- Level 10 -> Silver
- Level 20 -> Gold
- Level 30 -> Platinum

### Bài 15

Giải thích vì sao `Dictionary` hợp cho item database hơn `List` trong bài toán tra theo ID.

## Phần D - Queue cho hàng chờ

### Bài 16

Tạo `Queue<string>` mô phỏng hàng chờ spawn enemy.

Yêu cầu:

- Enqueue 5 enemy.
- Dequeue lần lượt.
- In ra thứ tự spawn.

### Bài 17

Tạo `Queue<string>` làm bullet pool đơn giản.

Yêu cầu:

- Có 3 viên đạn ban đầu.
- Lấy ra một viên để bắn.
- Trả lại viên đạn vào queue sau khi dùng.

### Bài 18

Tạo `Queue<string>` cho danh sách nhiệm vụ nền cần xử lý.

Ví dụ:

- Load map.
- Spawn NPC.
- Play intro.

### Bài 19

Giải thích bằng lời: vì sao wave spawn thường hợp với `Queue<T>`.

## Phần E - Stack cho menu và lịch sử

### Bài 20

Tạo `Stack<string>` mô phỏng menu chồng lớp.

Yêu cầu:

- Push `PauseMenu`.
- Push `SettingsMenu`.
- Push `AudioMenu`.
- Pop dần từng menu.

### Bài 21

Tạo `Stack<string>` lưu lịch sử màn hình.

Yêu cầu:

- Mở `Inventory`.
- Mở `ItemDetail`.
- Mở `ComparePanel`.
- In màn hình hiện tại bằng `Peek()`.

### Bài 22

Tạo `Stack<string>` mô phỏng undo thao tác chế tạo.

Yêu cầu:

- Push ít nhất 4 hành động.
- Pop 2 hành động để undo.

### Bài 23

Giải thích vì sao menu mở sau thường đóng trước.

## Phần F - Kết hợp nhiều collections

### Bài 24

Tạo một mini inventory system dùng cả `List<Item>` và `Dictionary<string, Item>`.

Yêu cầu:

- `List` dùng cho hiển thị theo slot.
- `Dictionary` dùng cho tra cứu theo id.

### Bài 25

Tạo một mini battle system dùng:

- `List<string>` cho enemy đang sống.
- `Queue<string>` cho enemy chờ spawn.
- `Dictionary<string, int>` cho máu theo id enemy.

### Bài 26

Tạo một mini UI flow dùng:

- `Stack<string>` cho menu.
- `List<string>` cho tab trong menu hiện tại.

### Bài 27

Tạo một mini save data summary dùng:

- `Dictionary<string, int>` cho số liệu.
- `List<string>` cho checkpoint đã mở.

## Phần G - Bài tập phân tích lựa chọn

### Bài 28

Với mỗi bài toán sau, chọn collection phù hợp nhất và giải thích vì sao:

- Danh sách item trong túi đồ.
- Bảng tra cứu item theo ID.
- Danh sách spawn enemy theo thứ tự wave.
- Lịch sử menu đang mở.
- Danh sách quest đang hoạt động.

### Bài 29

Viết bảng so sánh 4 collection:

- `List<T>`
- `Dictionary<TKey, TValue>`
- `Queue<T>`
- `Stack<T>`

Các cột gợi ý:

- Mô hình dữ liệu.
- Thao tác chính.
- Ví dụ game.
- Khi không nên dùng.

### Bài 30

Cho đoạn mô tả sau và sửa lựa chọn collection nếu thấy chưa hợp lý:

- Dùng `List` để lookup item theo id mỗi frame.
- Dùng `Stack` cho wave spawn FIFO.
- Dùng `Queue` cho undo hệ thống chỉnh sửa.

## Phần H - Tự kiểm tra nhanh

### Câu 1

Collection nào hợp nhất cho truy cập theo index?

### Câu 2

Collection nào hợp nhất cho tra cứu theo khóa?

### Câu 3

FIFO là gì?

### Câu 4

LIFO là gì?

### Câu 5

`Peek()` thường gắn với collection nào?

### Câu 6

`Enqueue()` và `Dequeue()` thuộc collection nào?

### Câu 7

`Push()` và `Pop()` thuộc collection nào?

### Câu 8

Nếu cần item theo `itemId`, bạn nghĩ ngay đến collection nào?

### Câu 9

Nếu cần mô phỏng hàng chờ, bạn nghĩ ngay đến collection nào?

### Câu 10

Nếu cần lịch sử menu gần nhất, bạn nghĩ ngay đến collection nào?

## Phần I - Lỗi thường gặp

### Lỗi 1

Dùng `List<T>` cho mọi thứ vì quen tay.

### Lỗi 2

Dùng `Dictionary` dù không có khóa rõ ràng.

### Lỗi 3

Nhầm `Queue` và `Stack`.

### Lỗi 4

Không đặt tên biến thể hiện ý nghĩa collection.

### Lỗi 5

Không kiểm tra key tồn tại trước khi lấy từ `Dictionary`.

### Lỗi 6

Pop hoặc Dequeue khi collection rỗng.

### Lỗi 7

Không nghĩ về bài toán truy cập chính trước khi chọn collection.

## Phần J - Common mistakes trong game

### Tình huống 1

Inventory lớn nhưng luôn duyệt toàn bộ để tìm item theo id.

Hỏi:

- Có thể cải thiện bằng collection nào?

### Tình huống 2

Wave spawn bị đảo thứ tự vì dùng sai cấu trúc.

Hỏi:

- Queue hay Stack hợp hơn?

### Tình huống 3

Menu back hoạt động sai vì không lưu lịch sử đúng kiểu.

Hỏi:

- Vì sao Stack hợp lý hơn?

## Phần K - Mini project

### Mini project 1

Xây inventory cơ bản.

Yêu cầu:

- Danh sách item bằng `List`.
- Bảng tra cứu giá bằng `Dictionary`.
- In giao diện console.

### Mini project 2

Xây wave spawner cơ bản.

Yêu cầu:

- `Queue` chứa enemy chờ spawn.
- `List` chứa enemy đang sống.
- In log khi spawn.

### Mini project 3

Xây UI navigation cơ bản.

Yêu cầu:

- `Stack` quản lý menu mở.
- Có thao tác mở, xem menu hiện tại, và quay lại.

### Mini project 4

Xây item database cơ bản.

Yêu cầu:

- `Dictionary<string, ItemData>`.
- Có method thêm item.
- Có method tìm item theo id.
- Có method in toàn bộ.

## Phần L - Reflection

Tự trả lời:

1. Trước bài này bạn dùng collection nào nhiều nhất?
2. Sau bài này bạn thấy bài toán nào rõ ràng nên dùng `Dictionary` hơn?
3. Bạn từng gặp hệ thống UI nào rất hợp với `Stack`?
4. Bạn thấy ví dụ nào giúp hiểu `Queue` rõ nhất?
5. Bạn còn hay nhầm giữa collection nào?

## Phần M - Checklist hoàn thành

- Tôi đã viết ví dụ với cả 4 collection.
- Tôi đã làm ít nhất 1 ví dụ game cho mỗi collection.
- Tôi đã giải thích được vì sao chọn collection đó.
- Tôi đã thử kết hợp nhiều collection trong cùng một bài toán.
- Tôi đã viết ít nhất 1 mini project nhỏ.
- Tôi đã tự review lỗi thường gặp của mình.
