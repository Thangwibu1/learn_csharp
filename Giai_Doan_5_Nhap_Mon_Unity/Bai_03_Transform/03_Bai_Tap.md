# Bài tập Bài 3: Transform

## Mục tiêu bài tập

- Nắm chắc `position`, `rotation`, `scale`.
- Phân biệt `local` và `world`.
- Thực hành điều khiển object bằng `Transform` trong scene và bằng code.
- Tập nhận diện các lỗi transform rất hay gặp ở người mới học Unity.

## Phần 1: Quan sát trực quan

### Bài 1

Tạo một object đơn giản trong scene.

Yêu cầu:

- Chọn object đó và quan sát `Transform` trong `Inspector`.
- Ghi lại 3 nhóm giá trị chính bạn nhìn thấy.

### Bài 2

Thay đổi từng giá trị trong `Position`.

Yêu cầu:

- Tăng X và quan sát object đi theo hướng nào.
- Tăng Y và quan sát object đi theo hướng nào.
- Nếu đang ở 3D, thay đổi Z và mô tả điều gì xảy ra.

### Bài 3

Đưa toàn bộ `Position`, `Rotation`, `Scale` về mặc định.

Yêu cầu:

- Ghi lại giá trị mặc định thường thấy.
- Giải thích vì sao biết reset transform rất quan trọng.

## Phần 2: Di chuyển object bằng tay

### Bài 4

Dùng `Move Tool` để kéo object trong `Scene`.

Yêu cầu:

- So sánh cảm giác thao tác bằng chuột với nhập số trong `Inspector`.
- Ghi trường hợp nào nên dùng mỗi cách.

### Bài 5

Di chuyển 3 object đến 3 vị trí khác nhau.

Yêu cầu:

- Đặt tên 3 object rõ ràng.
- Không để chồng lên nhau.
- Viết ra tọa độ cuối cùng của từng object.

### Bài 6

Đặt một object thật xa camera.

Yêu cầu:

- Chứng minh object vẫn còn tồn tại.
- Giải thích vì sao trong `Game` có thể không nhìn thấy nó.

## Phần 3: Xoay object

### Bài 7

Dùng `Rotate Tool` để xoay object.

Yêu cầu:

- Nếu là game 2D, tập trung vào trục Z.
- Nếu là game 3D, thử cả X, Y, Z.
- Ghi lại ảnh hưởng của từng trục.

### Bài 8

Tạo một object giống mũi tên hoặc object dễ thấy hướng.

Yêu cầu:

- Xoay object để thấy rõ hướng mặt.
- Giải thích vì sao rotation quan trọng với đạn, camera, nhân vật.

### Bài 9

Viết script cho object xoay liên tục.

Yêu cầu:

- Dùng `transform.Rotate` hoặc đặt `rotation`.
- Có dùng `Time.deltaTime`.
- Quan sát tốc độ xoay.

## Phần 4: Scale

### Bài 10

Thay đổi `Scale` của object.

Yêu cầu:

- Phóng to gấp đôi.
- Thu nhỏ còn một nửa.
- Quan sát hình ảnh và va chạm nếu có.

### Bài 11

Thử scale không đồng đều.

Ví dụ:

- X = 2, Y = 1, Z = 1
- X = 1, Y = 3, Z = 1

Yêu cầu:

- Mô tả hình dạng bị kéo dãn theo trục nào.
- Nêu ít nhất 2 rủi ro khi scale quá cực đoan.

### Bài 12

Nếu làm game 2D, thử lật object bằng scale âm theo X.

Yêu cầu:

- Mô tả lợi ích của cách này.
- Ghi lại ít nhất 1 tình huống có thể phát sinh lỗi khi object có con.

## Phần 5: Local và world

### Bài 13

Tạo một object cha tên `Player` và một object con tên `Sword`.

Yêu cầu:

- Đặt `Sword` làm con của `Player`.
- Ghi lại `localPosition` của `Sword`.
- Ghi lại `position` thế giới của `Sword`.

### Bài 14

Di chuyển `Player`.

Yêu cầu:

- Quan sát `Sword`.
- Giải thích vì sao `Sword` thay đổi vị trí thế giới nhưng local position có thể vẫn giữ nguyên.

### Bài 15

Xoay `Player`.

Yêu cầu:

- Quan sát hướng của `Sword`.
- Giải thích vì sao object con bị ảnh hưởng.

### Bài 16

Tạo object cha `EnemyGroup` và 3 object con.

Yêu cầu:

- Di chuyển cha.
- Scale cha.
- Xoay cha.
- Ghi lại ảnh hưởng lên toàn bộ object con.

## Phần 6: Di chuyển bằng code

### Bài 17

Cho object di chuyển sang phải bằng cách cộng vào `transform.position`.

Yêu cầu:

- Có dùng `Time.deltaTime`.
- Có biến tốc độ chỉnh được.

### Bài 18

Cho object di chuyển bằng input trái phải.

Yêu cầu:

- Dùng `Input.GetAxisRaw("Horizontal")`.
- Giải thích vì sao `deltaTime` giúp chuyển động ổn định.

### Bài 19

Cho object di chuyển theo hình vuông hoặc qua lại giữa 2 điểm.

Yêu cầu:

- Viết ra logic bạn chọn.
- Quan sát object trong scene.

### Bài 20

Cho object đi qua danh sách waypoint.

Yêu cầu:

- Tạo ít nhất 3 waypoint.
- Object phải đi lần lượt qua các điểm.
- Nếu muốn, cho object quay mặt theo hướng đi.

## Phần 7: Rotation và hướng

### Bài 21

Vẽ `Debug.DrawRay` theo `transform.right`, `transform.up`, `transform.forward`.

Yêu cầu:

- Quan sát trong `Scene`.
- Xoay object và xem các tia thay đổi thế nào.

### Bài 22

Viết câu trả lời cho câu hỏi:

- `transform.right` có luôn là `(1, 0, 0)` không?

Giải thích bằng ví dụ cụ thể.

### Bài 23

Cho object luôn nhìn về một mục tiêu khác.

Yêu cầu:

- Nếu 2D, có thể dùng scale hoặc rotate quanh Z.
- Nếu 3D, có thể dùng `LookAt`.
- Mô tả sự khác nhau giữa hai cách tiếp cận.

## Phần 8: Bài tập debug

### Bài 24

Giả sử object con có vị trí lạ dù local position rất nhỏ.

Hãy giải thích ít nhất 3 khả năng.

Gợi ý:

- Cha đang ở rất xa.
- Cha đã scale hoặc xoay.
- Bạn đang nhìn nhầm local và world.

### Bài 25

Giả sử object dùng `Rigidbody` nhưng bạn lại kéo bằng `transform.position` trong mỗi frame.

Yêu cầu:

- Dự đoán hiện tượng có thể xảy ra.
- Giải thích vì sao bài vật lý sẽ xử lý khác.

### Bài 26

Viết checklist debug khi object không nằm đúng nơi bạn muốn.

Checklist nên có:

- Kiểm tra parent.
- Kiểm tra local hay world.
- Kiểm tra animation.
- Kiểm tra script khác đang ghi đè.
- Kiểm tra camera.

## Phần 9: Mini scene task

### Bài 27

Tạo mini scene sau:

- `Player`
- `Sword` là con của `Player`
- `Camera`
- `Target`

Yêu cầu:

- Di chuyển `Player` bằng transform.
- `Sword` phải đi theo.
- `Target` đứng yên để làm mốc quan sát.

### Bài 28

Tạo một object trang trí nhấp nhô theo trục Y bằng code.

Yêu cầu:

- Có dùng `Mathf.Sin` hoặc cách tương đương.
- Ghi lại vì sao đây vẫn là thay đổi transform theo thời gian.

### Bài 29

Tạo một object phóng to thu nhỏ liên tục.

Yêu cầu:

- Không để scale xuống 0 hoặc âm nếu chưa chủ đích.
- Mô tả cảm giác khác nhau giữa chuyển động vị trí, xoay, scale.

## Phần 10: Câu hỏi tự luận

### Bài 30

Phân biệt:

- `position` và `localPosition`
- `rotation` và `eulerAngles`
- `scale` và `localScale`

### Bài 31

Vì sao `Transform` là component cơ bản nhất trong Unity?

### Bài 32

Nếu phải giải thích `Transform` cho một bạn chưa học Unity, bạn sẽ ví nó như thế nào?

## Phần 11: Checklist hoàn thành

- Tôi đã đổi `Position`, `Rotation`, `Scale` bằng tay.
- Tôi đã di chuyển object bằng code.
- Tôi đã dùng `Time.deltaTime`.
- Tôi đã thử quan hệ cha con.
- Tôi đã phân biệt local và world.
- Tôi đã thấy hướng của object đổi theo rotation.
- Tôi đã hiểu transform liên quan trực tiếp tới cách object tồn tại trong scene.

## Phần 12: Debug prompt cuối bài

- Nếu object sai vị trí, tôi có kiểm tra cha trước không?
- Nếu object sai hướng, tôi có đang xoay đúng trục không?
- Nếu object biến dạng, tôi có scale lệch không?
- Nếu object chuyển động giật, có phải tôi đang dùng transform sai chỗ với rigidbody không?

## Phần 13: Thử thách mở rộng

### Thử thách 1

Tạo một hệ mặt trời đơn giản:

- Mặt trời là cha
- Hành tinh là con
- Vệ tinh là con của hành tinh

Yêu cầu:

- Xoay các object để thấy hiệu ứng phân cấp.

### Thử thách 2

Tạo một camera theo player bằng script đơn giản và mô tả vì sao camera nên cập nhật sau player.

### Thử thách 3

Tạo một bài trình diễn local/world cho người học mới khác xem trong 2 phút.

## Phần 14: Kết luận

Khi nắm chắc `Transform`, bạn sẽ dễ hiểu hơn rất nhiều phần còn lại của Unity, vì gần như mọi hành vi nhìn thấy được trong scene cuối cùng đều quay về việc object đang ở đâu, hướng nào, to nhỏ ra sao.
