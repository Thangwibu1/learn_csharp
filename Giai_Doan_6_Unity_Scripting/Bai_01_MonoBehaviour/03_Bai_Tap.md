# Bài tập Bài 1: MonoBehaviour

## Mục tiêu bài tập

- Hiểu script `MonoBehaviour` là component có vòng đời do Unity quản lý.
- Quan sát được các hàm như `Awake`, `Start`, `Update`, `FixedUpdate`, `LateUpdate` trong thực tế.
- Tập đặt logic đúng chỗ thay vì dồn mọi thứ vào `Update`.

## Phần 1: Quan sát vòng đời cơ bản

### Bài 1

Tạo script có các hàm:

- `Awake`
- `OnEnable`
- `Start`
- `Update`
- `OnDisable`

Yêu cầu:

- Trong mỗi hàm in ra một log khác nhau.
- Gắn script vào một object.
- Nhấn `Play` và quan sát thứ tự trong `Console`.

### Bài 2

Ghi lại thứ tự hàm bạn đã quan sát được.

Yêu cầu:

- Không đoán.
- Phải dựa trên log thật trong `Console`.

### Bài 3

Tắt object rồi bật lại trong lúc chạy game.

Yêu cầu:

- Quan sát hàm nào chạy lại.
- Giải thích vì sao `OnEnable` và `OnDisable` quan trọng.

## Phần 2: Awake và Start

### Bài 4

Viết một script lấy `SpriteRenderer` hoặc component khác trong `Awake`.

Yêu cầu:

- In ra log xác nhận đã lấy được component.
- Nếu không có component, in cảnh báo.

### Bài 5

Đặt một giá trị hiển thị hoặc log trong `Start`.

Yêu cầu:

- Viết lại bằng lời: `Awake` và `Start` khác nhau như thế nào.
- Nêu một ví dụ phù hợp với từng hàm.

### Bài 6

Tạo 2 script trên 2 object khác nhau và cho cả hai cùng in `Awake` và `Start`.

Yêu cầu:

- Quan sát log.
- Rút ra kết luận: có nên phụ thuộc mù mờ vào thứ tự khởi tạo giữa nhiều object không?

## Phần 3: Update và deltaTime

### Bài 7

Cho object di chuyển sang phải trong `Update`.

Yêu cầu:

- Có dùng `Time.deltaTime`.
- Có biến tốc độ chỉnh được.

### Bài 8

Thử bỏ `Time.deltaTime`.

Yêu cầu:

- Viết ngắn điều gì có thể xảy ra trên máy nhanh và máy chậm.
- Giải thích vì sao chuyển động nên theo thời gian chứ không theo số frame.

### Bài 9

Cho object đổi màu khi nhấn một phím trong `Update`.

Yêu cầu:

- Dùng `GetKeyDown` hoặc `GetKey` phù hợp.
- Giải thích vì sao input thường được đọc trong `Update`.

## Phần 4: FixedUpdate và LateUpdate

### Bài 10

Tạo object có `Rigidbody2D` hoặc `Rigidbody`.

Yêu cầu:

- Thử tác động lực trong `FixedUpdate`.
- Viết ra vì sao vật lý thường hợp với `FixedUpdate` hơn `Update`.

### Bài 11

Tạo một camera hoặc object follower theo player trong `LateUpdate`.

Yêu cầu:

- Mô tả sự khác nhau khi follower chạy trong `Update` và `LateUpdate`.

### Bài 12

Tự giải thích bằng 3 ví dụ:

- Việc gì hợp với `Update`
- Việc gì hợp với `FixedUpdate`
- Việc gì hợp với `LateUpdate`

## Phần 5: OnEnable, OnDisable, OnDestroy

### Bài 13

Tạo script đăng ký một event giả lập trong `OnEnable` và hủy trong `OnDisable`.

Yêu cầu:

- Không cần hệ thống event quá phức tạp.
- Mục tiêu là hiểu mô hình đăng ký và hủy đăng ký.

### Bài 14

Tắt component rồi bật lại.

Yêu cầu:

- Quan sát log.
- Trả lời: `Awake` có chạy lại không? `OnEnable` có chạy lại không?

### Bài 15

Hủy object trong lúc runtime nếu bạn đã biết cách.

Yêu cầu:

- Quan sát `OnDestroy`.
- Ghi lại khi nào nên dùng cleanup ở đây.

## Phần 6: Coroutine

### Bài 16

Viết một coroutine cho object nhấp nháy.

Yêu cầu:

- Dùng `yield return new WaitForSeconds(...)`.
- Có thể bật tắt renderer theo nhịp.

### Bài 17

Khởi động coroutine trong `Start`.

Yêu cầu:

- Mô tả vì sao coroutine phù hợp với logic theo thời gian.
- So sánh ngắn với việc tự đếm thời gian trong `Update`.

### Bài 18

Thử dừng và chạy lại coroutine bằng phím.

Yêu cầu:

- Ghi ra những gì bạn quan sát được.

## Phần 7: Null reference và debug

### Bài 19

Cố tình tạo một biến tham chiếu chưa gán rồi gọi nó.

Yêu cầu:

- Đọc lỗi trong `Console`.
- Ghi lại file và dòng.
- Sửa lỗi bằng cách gán reference đúng hoặc `GetComponent`.

### Bài 20

Viết checklist debug khi script không chạy.

Checklist nên có:

- Có lỗi compile không?
- Object có active không?
- Script có enabled không?
- Tên file và tên class có khớp không?
- Script có kế thừa `MonoBehaviour` không?

### Bài 21

Viết checklist debug khi log không xuất hiện như mong đợi.

Gợi ý:

- Hàm đó có được Unity tự gọi không?
- Điều kiện `if` có đang ngăn log không?
- Object có đang active không?

## Phần 8: Bài tập thiết kế tốt hơn

### Bài 22

Phân tích vì sao không nên đặt mọi logic của player trong `Update`.

Yêu cầu:

- Nêu ít nhất 6 lý do.

### Bài 23

Tách logic một object thành các vai trò sau:

- Input
- Movement
- Health
- Animation
- UI

Yêu cầu:

- Mô tả mỗi vai trò nên nằm ở đâu.
- Chỉ ra vai trò nào cần `MonoBehaviour`, vai trò nào có thể là class thường.

### Bài 24

Viết ngắn khi nào bạn **không** cần `MonoBehaviour`.

Ví dụ gợi ý:

- Class dữ liệu
- Helper utility
- Save data model

## Phần 9: Mini scene task

### Bài 25

Tạo một mini scene có object trình diễn lifecycle.

Yêu cầu:

- Có script in log từ nhiều hàm lifecycle.
- Có object follower hoặc object di chuyển.
- Có ít nhất một thao tác tắt bật object trong runtime.

### Bài 26

Tạo một object nhảy lên xuống trong `Update`, một follower trong `LateUpdate`, và một rigidbody được tác động trong `FixedUpdate`.

Yêu cầu:

- Ghi vai trò của từng object.
- Chỉ ra vì sao mỗi logic được đặt đúng chỗ.

### Bài 27

Thử bật/tắt một component bằng phím.

Yêu cầu:

- Quan sát `OnEnable`, `OnDisable`.
- Mô tả tác động thực tế lên hành vi object.

## Phần 10: Câu hỏi tự luận

### Bài 28

Vì sao `MonoBehaviour` là cánh cửa để class của bạn đi vào hệ thống scene của Unity?

### Bài 29

Nếu phải ghi nhớ 5 quy tắc ngắn về lifecycle, bạn sẽ ghi gì?

### Bài 30

Phân biệt `Awake`, `Start`, `Update`, `FixedUpdate`, `LateUpdate` bằng ví dụ đời thường hoặc ví dụ gameplay.

## Phần 11: Checklist hoàn thành

- Tôi đã nhìn thấy thứ tự lifecycle cơ bản.
- Tôi biết dùng `Awake` để lấy reference.
- Tôi biết `Start` là thời điểm bắt đầu thuận tiện.
- Tôi biết đọc input trong `Update`.
- Tôi biết vật lý thường ở `FixedUpdate`.
- Tôi biết follower camera thường hợp với `LateUpdate`.
- Tôi biết `OnEnable` và `OnDisable` quan trọng cho event.
- Tôi biết không phải class nào cũng phải là `MonoBehaviour`.

## Phần 12: Debug prompt cuối bài

- Logic này có thật sự cần chạy mỗi frame không?
- Tôi có đang đặt vật lý trong `Update` không?
- Tôi có đang phụ thuộc vào thứ tự khởi tạo không an toàn không?
- Tôi có quên hủy đăng ký event khi object bị tắt không?

## Phần 13: Thử thách mở rộng

### Thử thách 1

Tạo một script logger gọn gàng để theo dõi toàn bộ lifecycle của một object và mô tả nó như timeline.

### Thử thách 2

Tạo một hệ pause nhỏ bằng event và quan sát các object phản ứng khi pause bật/tắt.

### Thử thách 3

Giải thích cho một người mới khác vì sao hiểu lifecycle giúp debug nhanh hơn rất nhiều.

## Phần 14: Kết luận

Nếu học chắc bài này, bạn sẽ bớt viết code theo kiểu "thử xem có chạy không" và bắt đầu đặt câu hỏi đúng hơn:

- Logic này thuộc hàm nào trong vòng đời?
- Unity sẽ gọi nó khi nào?
- Mình có đang để sai trách nhiệm vào sai chỗ không?
