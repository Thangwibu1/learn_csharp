# Bài tập Bài 3: Input System

## Mục tiêu bài tập

- Hiểu input là cầu nối giữa ý định người chơi và hành động trong game.
- Tập đọc input đúng chỗ.
- Tập tách input reader khỏi logic di chuyển hoặc gameplay khi có thể.

## Phần 1: Đọc input cơ bản

### Bài 1

Tạo script đọc các phím trái phải.

Yêu cầu:

- Dùng `GetAxisRaw("Horizontal")` hoặc `GetKey`.
- In log khi có input.

### Bài 2

Đọc phím `Space` bằng `GetKeyDown`.

Yêu cầu:

- In log "Jump" đúng lúc nhấn.
- Giải thích vì sao `GetKeyDown` hợp với nhảy hơn `GetKey` trong nhiều tình huống.

### Bài 3

Đọc `Escape` để bật tắt trạng thái pause giả lập.

Yêu cầu:

- Có biến bool lưu trạng thái pause.
- In log mỗi lần chuyển trạng thái.

## Phần 2: GetKey, GetKeyDown, GetKeyUp

### Bài 4

Viết ví dụ minh họa 3 API sau:

- `GetKey`
- `GetKeyDown`
- `GetKeyUp`

Yêu cầu:

- Mỗi API phải có một ví dụ dùng hợp lý.

### Bài 5

Tự mô tả khác nhau giữa:

- Giữ phím chạy
- Nhấn phím nhảy một lần
- Nhả phím để kết thúc một hành động sạc lực

Yêu cầu:

- Ghép mỗi tình huống với API phù hợp.

## Phần 3: Axis và chuyển động

### Bài 6

Cho object di chuyển bằng `Horizontal`.

Yêu cầu:

- Có tốc độ chỉnh được.
- Có dùng `Time.deltaTime`.

### Bài 7

Cho object di chuyển cả 4 hướng bằng `Horizontal` và `Vertical`.

Yêu cầu:

- Nếu vector vượt quá độ dài 1, hãy cân nhắc normalize.
- Giải thích vì sao đi chéo có thể nhanh hơn nếu không normalize.

### Bài 8

Thử `GetAxis` và `GetAxisRaw`.

Yêu cầu:

- Ghi lại cảm giác khác nhau.
- Nêu trường hợp bạn thích cái nào hơn trong game hành động đơn giản.

## Phần 4: Tách input và movement

### Bài 9

Viết một script chỉ đọc input và lưu ra biến `MoveInput`.

Yêu cầu:

- Script này không trực tiếp di chuyển object.

### Bài 10

Viết script khác nhận `MoveInput` và thực hiện di chuyển.

Yêu cầu:

- So sánh với cách gom mọi thứ vào một script duy nhất.
- Nêu ít nhất 3 lợi ích của việc tách này.

### Bài 11

Viết ngắn khái niệm:

- Input là ý định
- Movement là phản hồi gameplay

## Phần 5: Input và vật lý

### Bài 12

Đọc input trong `Update`, lưu giá trị vào biến.

Yêu cầu:

- Trong `FixedUpdate`, dùng giá trị đó để điều khiển rigidbody.
- Viết ra vì sao cấu trúc này thường được dùng.

### Bài 13

Tạo player có thể nhảy bằng rigidbody.

Yêu cầu:

- Input jump đọc bằng `GetKeyDown` trong `Update`.
- Lệnh nhảy áp vào vật lý ở chỗ phù hợp.

### Bài 14

Giải thích vì sao đọc input trực tiếp trong `FixedUpdate` có thể không phải lựa chọn tốt nhất cho người mới trong nhiều trường hợp.

## Phần 6: Input và state game

### Bài 15

Tạo trạng thái `isPaused`.

Yêu cầu:

- Khi pause, player không di chuyển nữa.
- Có thể bật một panel UI giả lập hoặc chỉ in log.

### Bài 16

Tạo trạng thái `isStunned` hoặc `isDead` giả lập.

Yêu cầu:

- Khi trạng thái bật, khóa input movement.
- Giải thích vì sao input cần phụ thuộc trạng thái game.

### Bài 17

Tự nêu 5 trạng thái gameplay mà input hợp lệ sẽ khác nhau.

Ví dụ:

- Chơi bình thường
- Pause
- Cutscene
- Game over
- Mở inventory

## Phần 7: Input và UI

### Bài 18

Viết tình huống: mở menu nhưng nhân vật vẫn chạy.

Yêu cầu:

- Giải thích nguyên nhân có thể có.
- Nêu 3 cách suy nghĩ để sửa.

### Bài 19

Tạo nút `Escape` để mở và đóng pause menu giả lập.

Yêu cầu:

- Khi menu mở, log movement nên bị bỏ qua.
- Khi menu đóng, movement hoạt động lại.

## Phần 8: Input nâng dần

### Bài 20

Đọc chuột trái để kích hoạt hành động `Attack`.

Yêu cầu:

- Không cần làm combat thật.
- Chỉ cần in log hoặc đổi màu object.

### Bài 21

Theo dõi vị trí chuột trong world nếu bạn đã biết camera chuyển đổi tọa độ.

Yêu cầu:

- Dùng một marker di chuyển theo chuột.
- Mô tả vì sao input chuột khác input phím.

### Bài 22

Tìm hiểu khái niệm `input buffer`.

Yêu cầu:

- Tự giải thích bằng ví dụ game nhảy hoặc game hành động.
- Không cần code phức tạp nếu chưa sẵn sàng.

## Phần 9: Debug input

### Bài 23

Viết checklist khi input không hoạt động.

Checklist nên có:

- Script có chạy không?
- `Update` có đang được gọi không?
- Object có active không?
- Có pause hoặc state nào đang khóa input không?
- Tên axis có đúng không?

### Bài 24

Viết checklist khi nhân vật di chuyển nhưng input nhảy không ăn.

Gợi ý:

- Dùng sai `GetKey` hay `GetKeyDown`?
- Có điều kiện ground check chặn nhảy không?
- Có reset cờ nhảy quá sớm không?

### Bài 25

Viết checklist khi mở menu mà gameplay vẫn phản hồi input.

## Phần 10: Mini scene task

### Bài 26

Tạo mini scene có:

- Player di chuyển 4 hướng
- Space để nhảy hoặc tạo hiệu ứng nhảy giả lập
- Chuột trái để attack giả lập
- Escape để pause

Yêu cầu:

- Có script đọc input.
- Có script xử lý movement riêng nếu có thể.
- Có log rõ ràng cho từng action.

### Bài 27

Thử khóa movement khi pause.

Yêu cầu:

- Player không được tiếp tục trôi do logic input thường.
- Ghi rõ bạn khóa ở lớp input hay lớp movement.

### Bài 28

Nếu project có rigidbody, thử kết nối input với movement vật lý.

Yêu cầu:

- Giữ cấu trúc input trong `Update`, vật lý trong `FixedUpdate`.

## Phần 11: Câu hỏi tự luận

### Bài 29

Vì sao input tốt nên được nghĩ ở mức hành động như `Move`, `Jump`, `Attack` thay vì chỉ nghĩ ở mức phím cụ thể?

### Bài 30

Nếu sau này đổi từ bàn phím sang tay cầm, code của bạn sẽ khó hay dễ sửa hơn nếu đã tách input reader?

### Bài 31

Input có nên dính chặt với movement mãi không? Khi nào nên tách?

## Phần 12: Checklist hoàn thành

- Tôi đã đọc được input cơ bản bằng phím.
- Tôi hiểu khác nhau giữa `GetKey`, `GetKeyDown`, `GetKeyUp`.
- Tôi đã dùng axis để di chuyển.
- Tôi đã biết nên đọc input trong `Update`.
- Tôi đã tập tách input reader khỏi movement.
- Tôi đã biết pause có thể khóa input gameplay.

## Phần 13: Debug prompt cuối bài

- Input này là giữ, nhấn xuống, hay nhả ra?
- Input này có nên thành action riêng không?
- Logic này nên ở input reader, movement, hay state controller?
- Có trạng thái nào đang vô hiệu hóa input không?

## Phần 14: Thử thách mở rộng

### Thử thách 1

Viết một lớp `InputReader` gọn hơn, có thuộc tính công khai cho `Move`, `JumpPressed`, `AttackPressed`, `PausePressed`.

### Thử thách 2

Tạo một mini demo nơi UI panel mở ra và gameplay input dừng hoàn toàn.

### Thử thách 3

Giải thích cho người mới khác vì sao input không phải chỉ là "đọc phím", mà là cách chuyển ý định người chơi vào game.

## Phần 15: Kết luận

Khi học tốt bài này, bạn sẽ bắt đầu viết input có cấu trúc hơn, ít rối hơn, và dễ nối với movement, vật lý, UI, animation và state machine ở các bài sau.
