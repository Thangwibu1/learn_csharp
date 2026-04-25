# Bài tập Bài 2: Vật lý 2D và 3D

## Mục tiêu bài tập

- Phân biệt rõ hệ vật lý 2D và 3D trong Unity.
- Biết vai trò của `Rigidbody`, `Collider`, `Trigger`, `Raycast`.
- Tập đặt logic vật lý vào đúng nơi và debug va chạm có hệ thống.

## Phần 1: Nhận diện hệ vật lý

### Bài 1

Viết lại bằng lời của bạn:

- `Collider` là gì?
- `Rigidbody` là gì?
- `Trigger` là gì?

Yêu cầu:

- Mỗi khái niệm tối thiểu 3 dòng.
- Có ví dụ gameplay cụ thể.

### Bài 2

Lập bảng so sánh:

- `Rigidbody2D` với `Rigidbody`
- `Collider2D` với `Collider`
- `OnTriggerEnter2D` với `OnTriggerEnter`

Yêu cầu:

- Chỉ ra rõ hệ nào dành cho 2D, hệ nào dành cho 3D.

### Bài 3

Tự giải thích vì sao không nên trộn `Rigidbody` 3D với `Collider2D` trong cùng một cơ chế cơ bản dành cho người mới.

## Phần 2: Va chạm cơ bản

### Bài 4

Tạo một `Player` có:

- `Rigidbody2D`
- `BoxCollider2D`

Yêu cầu:

- Tạo một `Ground` có `BoxCollider2D`.
- Cho player rơi xuống ground.
- Quan sát hiện tượng dừng trên mặt đất.

### Bài 5

Thay đổi trọng lực hoặc mass nếu có thể.

Yêu cầu:

- Ghi lại cảm giác khác nhau khi object nhẹ và nặng hơn.
- Dự đoán gameplay nào cần cảm giác rơi nặng.

### Bài 6

Tạo một tường bên trái hoặc bên phải.

Yêu cầu:

- Đẩy player vào tường.
- Quan sát va chạm.
- Ghi lại điều gì xác nhận collider đang làm việc.

## Phần 3: Trigger

### Bài 7

Tạo object `Coin` có `Collider2D` bật `Is Trigger`.

Yêu cầu:

- Khi player chạm coin, in log.
- Coin có thể biến mất hoặc bị tắt.

### Bài 8

So sánh trigger với collision chặn vật lý thật.

Yêu cầu:

- Viết ít nhất 4 điểm khác nhau.

### Bài 9

Nêu 5 ví dụ gameplay nên dùng trigger:

- Coin
- Checkpoint
- Vùng cảnh báo AI
- Cửa khu vực
- Hồi máu hoặc vùng gây sát thương

## Phần 4: Di chuyển bằng vật lý

### Bài 10

Cho player di chuyển ngang bằng cách thay đổi vận tốc hoặc thêm lực.

Yêu cầu:

- Đọc input trong `Update`.
- Áp dụng lên rigidbody trong `FixedUpdate`.

### Bài 11

Cho player nhảy bằng lực.

Yêu cầu:

- Chỉ cho nhảy khi đang đứng đất.
- Có thể dùng raycast hoặc ground check đơn giản.

### Bài 12

Giải thích vì sao tác động vật lý thường đặt trong `FixedUpdate`.

## Phần 5: Ground check và raycast

### Bài 13

Tạo một `ground check` bằng raycast hướng xuống dưới.

Yêu cầu:

- Vẽ ray debug để nhìn trong scene.
- In ra log hoặc boolean khi player chạm đất.

### Bài 14

Tạo một ground check bằng trigger nhỏ dưới chân.

Yêu cầu:

- So sánh cách này với raycast.
- Nêu ưu điểm và nhược điểm sơ bộ.

### Bài 15

Viết ngắn 3 tình huống ngoài ground check mà raycast rất hữu ích.

## Phần 6: Debug va chạm

### Bài 16

Viết checklist khi va chạm không xảy ra.

Checklist nên có:

- Hai object có collider chưa?
- Có ít nhất một object có rigidbody chưa?
- Có đúng cùng hệ 2D hoặc 3D không?
- Trigger đã bật hay tắt đúng mục đích chưa?
- Layer collision matrix có cho phép không?

### Bài 17

Viết checklist khi callback `OnTriggerEnter2D` không chạy.

Gợi ý:

- Tên hàm có viết đúng không?
- Đang dùng 2D hay 3D?
- Object có active không?
- Script có enabled không?

### Bài 18

Viết checklist khi object xuyên qua tường.

Gợi ý:

- Vật đang đi quá nhanh?
- Collider có phù hợp không?
- Chế độ va chạm có cần đổi không?
- Có đang kéo object bằng transform sai cách không?

## Phần 7: Layer và lọc va chạm

### Bài 19

Tạo một số layer như:

- Player
- Enemy
- PlayerBullet
- Pickup
- Environment

Yêu cầu:

- Gán layer cho ít nhất 3 object trong scene.
- Mô tả object nào nên va chạm với object nào.

### Bài 20

Đề xuất cấu hình đơn giản sao cho:

- Dan của player không trúng player.
- Dan của player trúng enemy.
- Coin không chặn đường đi.

## Phần 8: Mini scene task

### Bài 21

Tạo mini scene gồm:

- Player có rigidbody và collider
- Ground
- Một coin trigger
- Một vùng chết hoặc respawn trigger

Yêu cầu:

- Player rơi xuống đất ổn định.
- Có thể nhặt coin.
- Khi chạm vùng chết thì reset hoặc in log.

### Bài 22

Tạo một bounce pad hoặc object nảy.

Yêu cầu:

- Khi player chạm vào, player bật lên cao hơn bình thường.
- Ghi lại component và script cần dùng.

### Bài 23

Tạo một spawner sinh ra rigidbody nhỏ bằng phím.

Yêu cầu:

- Mỗi object mới sinh ra phải có lực ban đầu.
- Quan sát nhiều object tương tác vật lý trong scene.

## Phần 9: Câu hỏi phân tích

### Bài 24

Vì sao không nên kéo object có rigidbody bằng `transform.position` mỗi frame trong các tình huống vật lý chuẩn?

### Bài 25

Khi nào trigger tốt hơn collision, và khi nào collision thật tốt hơn trigger?

### Bài 26

Vì sao collider không cần phải khớp 100 phần trăm từng pixel hay từng cạnh nhỏ của hình ảnh?

## Phần 10: Bài tập bảng phân tích

### Bài 27

Lập bảng cho các object sau:

- Player
- Ground
- Coin
- Bullet
- Door zone
- Checkpoint

Mỗi object hãy tự điền:

- Có collider không
- Có rigidbody không
- Trigger hay collision
- Thuộc layer nào
- Callback có thể cần

## Phần 11: Checklist hoàn thành

- Tôi hiểu 2D và 3D là hai hệ tách nhau.
- Tôi phân biệt được collider và rigidbody.
- Tôi biết trigger không nhất thiết chặn vật lý.
- Tôi biết đọc input trong `Update` và tác động rigidbody trong `FixedUpdate`.
- Tôi biết dùng raycast cơ bản.
- Tôi có checklist khi va chạm không hoạt động.

## Phần 12: Debug prompt cuối bài

- Object này đang dùng hệ 2D hay 3D?
- Nó có collider chưa?
- Nó có rigidbody chưa?
- Trigger đã bật đúng chưa?
- Có đang bị layer ngăn tương tác không?
- Tôi có đang di chuyển nó bằng transform sai chỗ không?

## Phần 13: Thử thách mở rộng

### Thử thách 1

Tạo một platformer mini có nhảy, coin, vùng chết và bounce pad.

### Thử thách 2

Tạo một scene thử nghiệm riêng chỉ để kiểm tra vật lý, không cần art đẹp.

### Thử thách 3

Viết một tài liệu debug ngắn cho chính bạn: "Khi va chạm hỏng, mình sẽ kiểm tra theo thứ tự nào?"

## Phần 14: Kết luận

Học vật lý Unity không chỉ là nhớ API, mà là học cách nghĩ về tương tác giữa object trong thế giới game. Khi biết object nào nên chặn, object nào chỉ nên phát hiện, và object nào cần lực hay vận tốc, bạn sẽ thiết kế gameplay chắc tay hơn rất nhiều.
