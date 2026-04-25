# Bài tập Bài 2: Object Pooling

## Mục tiêu thực hành

- Hiểu khi nào nên dùng object pooling.
- Biết tạo pool cho đạn hoặc hiệu ứng ngắn.
- Biết reset object trước khi tái sử dụng.
- Biết debug tình huống pool hết object hoặc object trả về sai lúc.
- Biết mô tả lợi ích hiệu năng của pooling bằng ngôn ngữ đơn giản.

## Quy ước làm bài

- Ưu tiên tạo một scene demo riêng cho bài này.
- Nếu chưa có model đạn, dùng sphere hoặc cube nhỏ.
- Nếu chưa có enemy thật, dùng target tĩnh để thử va chạm.
- Mỗi khi hoàn thành một phần, ghi lại kết quả quan sát được.

## Điều kiện đạt tối thiểu

- Có một pool tạo sẵn nhiều object.
- Khi bắn, object lấy từ pool thay vì `Instantiate` mới liên tục.
- Khi hết thời gian hoặc va chạm, object được trả lại pool.
- Không phát sinh lỗi object giữ trạng thái cũ một cách rõ ràng.

## Phần A: Phân tích vấn đề

### Bài 1

Viết 5 đến 8 dòng giải thích vì sao `Instantiate` và `Destroy` liên tục có thể gây vấn đề cho game.

### Bài 2

Liệt kê ít nhất 10 loại object trong game có khả năng phù hợp với pooling.

Gợi ý:

- đạn
- vụ nổ
- popup sát thương
- enemy spawn theo đợt
- dấu chân
- shell văng ra
- pickup tái sinh
- hit effect
- particle ngắn
- icon cảnh báo tạm thời

### Bài 3

Liệt kê 5 loại object thường không bắt buộc phải dùng pooling ngay.

### Bài 4

Trả lời:

- pooling có phải luôn luôn tốt hơn không
- khi nào pooling có thể làm code phức tạp không đáng

## Phần B: Tạo pool cơ bản

### Bài 5

Tạo class pool với các phần sau:

- prefab
- số lượng khởi tạo ban đầu
- danh sách hoặc queue object sẵn sàng
- hàm lấy object
- hàm trả object

### Bài 6

Tạo sẵn ít nhất 10 object trong `Awake()`.

Sau đó ghi lại:

- object được tạo khi nào
- scene hierarchy thay đổi ra sao

### Bài 7

Khi lấy object ra khỏi pool, đảm bảo:

- object được bật active
- object được đặt vị trí đúng
- object được xoay đúng

### Bài 8

Khi trả object về pool, đảm bảo:

- object được tắt active
- object được reset velocity hoặc timer nếu có
- object quay về cha quản lý nếu cần

## Phần C: Demo bắn đạn

### Bài 9

Tạo một `firePoint` và một script bắn đơn giản.

Yêu cầu:

- nhấn phím để bắn
- mỗi phát bắn dùng object từ pool
- có cooldown đơn giản

### Bài 10

Tạo script cho đạn có:

- hướng bay
- tốc độ bay
- thời gian sống
- logic tự trả về pool khi hết thời gian

### Bài 11

Nếu đạn dùng `Rigidbody`, hãy reset những gì khi tái sử dụng.

Viết thành checklist ngắn.

### Bài 12

Nếu đạn dùng `TrailRenderer`, hãy mô tả tại sao cần xóa trail khi object được dùng lại.

## Phần D: Mở rộng pool

### Bài 13

Thêm tùy chọn `canGrow` cho pool.

Mô tả hành vi khi:

- pool còn object
- pool hết object và `canGrow = false`
- pool hết object và `canGrow = true`

### Bài 14

Thêm hàm tạo báo cáo debug như:

- tổng object
- số đang hoạt động
- số đang rảnh

### Bài 15

Hiển thị báo cáo debug đó bằng:

- `Debug.Log`
- hoặc text UI trong scene

### Bài 16

Viết 5 đến 8 dòng giải thích vì sao việc biết số object active và available giúp debug tốt hơn.

## Phần E: Reset trạng thái đúng cách

### Bài 17

Lập danh sách tất cả trạng thái có thể phải reset với một object pooled.

Ví dụ:

- vị trí
- xoay
- vận tốc
- thời gian sống
- máu hiện tại
- màu sắc
- animation state
- particle còn sót

### Bài 18

Tạo một object mục tiêu có thể đổi màu khi bị đạn bắn trúng.

Yêu cầu:

- đổi sang màu hit ngắn hạn
- sau đó trở lại màu bình thường

### Bài 19

Mô tả điều gì xảy ra nếu object pooled không reset màu hoặc timer đúng cách.

### Bài 20

Trả lời:

- pooling giúp giảm tạo hủy object
- nhưng bug phổ biến nhất của pooling là gì

## Phần F: Bài tập tình huống

### Bài 21

Đạn bắn lần đầu bình thường, lần thứ hai xuất hiện sai vị trí.

Hãy nêu ít nhất 6 nguyên nhân có thể.

### Bài 22

Pool vẫn còn object nhưng `Get()` trả về `null`.

Bạn sẽ kiểm tra:

- điều kiện dequeue
- object null bị destroy
- prefab có hợp lệ không
- logic tăng pool có chạy không

### Bài 23

Đạn vừa bắn ra đã biến mất ngay.

Các nguyên nhân có thể gồm:

- timer chưa reset
- collider chạm chính người bắn
- vị trí spawn sai
- object bị trả về ngay trong `OnEnable`

### Bài 24

Đạn bắn ra nhưng vẫn mang trail của lần trước.

Viết quy trình debug ngắn.

### Bài 25

Enemy pooled sau khi hồi sinh vẫn còn HP cũ.

Viết đoạn giải thích vì sao pooling cho enemy thường cần reset nhiều dữ liệu hơn pooling cho đạn.

## Phần G: Bài tập thiết kế kiến trúc

### Bài 26

Vẽ hoặc mô tả sơ đồ luồng cho hệ thống bắn dùng pooling:

- Input
- Gun
- Pool
- Bullet
- Target
- Return to Pool

### Bài 27

Mô tả vai trò của các lớp sau nếu bạn triển khai:

- `PoolManager`
- `PooledBullet`
- `PooledIdentity`
- `GunController`
- `TargetDummy`

### Bài 28

Nêu ưu và nhược điểm của hai cách:

- mỗi pool chỉ quản lý một loại prefab
- một manager quản lý nhiều loại prefab bằng key

### Bài 29

Nếu game có đạn, enemy nhỏ và hit effect đều cần pooling, bạn sẽ đặt thư mục và script thế nào cho dễ tìm?

### Bài 30

Viết 8 đến 12 dòng trả lời:

"Tại sao pooling là bài học tốt để hiểu sự khác nhau giữa tối ưu đúng chỗ và tối ưu sớm không cần thiết?"

## Phần H: Mini project

### Bài 31

Làm mini project `Shooting Range Pool Demo`.

Yêu cầu:

- súng bắn liên tục
- pool cho đạn
- ít nhất 3 mục tiêu đứng yên
- text debug số object
- phím thu hồi toàn bộ object active

### Bài 32

Mở rộng mini project:

- cho phép pool tăng kích thước
- màu mục tiêu đổi khi bị bắn
- đạn có thời gian sống
- reset trail đúng cách

### Bài 33

Ghi tài liệu sử dụng gồm:

- phím bắn
- phím reset
- script nào gắn vào đâu
- prefab nào phải có component gì

### Bài 34

Viết 3 cải tiến bạn sẽ làm tiếp nếu biến demo thành game thật.

Ví dụ:

- pool theo loại đạn khác nhau
- prewarm theo từng màn
- telemetry hiệu năng

### Bài 35

Viết đoạn tổng kết ngắn về điều bạn học được từ việc reset trạng thái khi tái sử dụng object.

## Câu hỏi review nhanh

### Câu 1

Object pooling giải quyết vấn đề gì?

### Câu 2

Vì sao đạn là ví dụ rất hợp với pooling?

### Câu 3

Tại sao trả object về pool không chỉ đơn giản là `SetActive(false)`?

### Câu 4

Khi nào nên cho pool tự mở rộng?

### Câu 5

Tại sao báo cáo debug active và available hữu ích?

### Câu 6

Vì sao pooled object có thể mang bug từ lần sử dụng trước?

### Câu 7

Enemy pooled cần reset gì nhiều hơn bullet?

### Câu 8

Tại sao pooling không thay thế cho mọi tối ưu khác?

### Câu 9

Nếu object pooled chứa particle, bạn cần chú ý gì?

### Câu 10

Điểm khác nhau giữa bug logic của pool và bug hiệu năng của pool là gì?

## Rubric chấm nhanh

### Mức đạt cơ bản

- Pool hoạt động.
- Đạn lấy từ pool.
- Đạn trả về đúng lúc.

### Mức khá

- Có reset trạng thái đầy đủ.
- Có báo cáo debug.
- Có xử lý pool mở rộng.

### Mức tốt

- Có kiến trúc rõ ràng.
- Có mini project hoàn chỉnh.
- Có phân tích trade-off và lỗi thực tế.

## Bài viết cuối buổi

Viết từ 12 đến 20 dòng trả lời:

- Lúc đầu bạn nghĩ pooling đơn giản ở điểm nào?
- Sau khi làm, bug nào làm bạn thấy nó không hề đơn giản?
- Bạn hiểu thêm gì về vòng đời của object trong Unity?
