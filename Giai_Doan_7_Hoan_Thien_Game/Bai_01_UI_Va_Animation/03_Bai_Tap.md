# Bài tập Bài 1: UI và Animation

## Mục tiêu thực hành

- Biết dựng HUD cơ bản cho game hành động đơn giản.
- Biết nối dữ liệu gameplay với UI thay vì cập nhật mù quáng mỗi frame.
- Biết tạo animation phản hồi cho nhân vật và cho chính UI.
- Biết tự kiểm tra lỗi khi thanh máu, text, panel, animator hoạt động sai.
- Biết viết mô tả thiết kế ngắn cho một màn chơi có UI rõ ràng.

## Cách làm đề nghị

- Làm theo thứ tự từ phần A đến phần H.
- Mỗi bài nên tự ghi lại ảnh chụp kết quả hoặc mô tả kết quả.
- Nếu chưa có art, dùng hình khối, text mặc định và màu đơn giản.
- Ưu tiên làm đúng luồng dữ liệu hơn là làm giao diện đẹp ngay.

## Tiêu chí hoàn thành tối thiểu

- Có thanh máu hiển thị đúng.
- Có ít nhất một text điểm hoặc coin cập nhật đúng.
- Có ít nhất một animation cho nhân vật hoặc UI.
- Không cập nhật toàn bộ UI vô tội vạ trong `Update()` nếu dữ liệu không đổi.
- Có ghi chú nêu rõ file nào quản lý gameplay, file nào quản lý hiển thị.

## Phần A: Quan sát và phân tích

### Bài 1

Viết ngắn 5 đến 8 dòng trả lời câu hỏi:

- UI trong game của bạn đang truyền thông tin gì?
- Người chơi cần thấy thông tin nào mọi lúc?
- Thông tin nào chỉ nên hiện khi cần?

### Bài 2

Liệt kê ít nhất 10 thành phần UI có thể xuất hiện trong một game hành động 2D hoặc 3D.

Gợi ý:

- máu
- năng lượng
- coin
- kinh nghiệm
- nút pause
- bản đồ nhỏ
- kỹ năng hồi chiêu
- thông báo nhiệm vụ
- cảnh báo nguy hiểm
- màn hình thua

### Bài 3

Viết một đoạn ngắn giải thích:

- vì sao UI không chỉ là phần trang trí
- vì sao animation không chỉ để đẹp

### Bài 4

Phân loại các thành phần sau vào nhóm HUD, Menu, Popup, Feedback hoặc Animation:

- thanh máu
- nút cài đặt
- chữ `Quest Completed`
- hiệu ứng rung khi bị đánh
- panel pause
- icon kỹ năng đang hồi chiêu
- cửa mở dần
- popup nhặt được vật phẩm

## Phần B: Dựng HUD cơ bản

### Bài 5

Tạo một `Canvas` và dựng các thành phần sau:

- thanh máu
- thanh năng lượng
- text coin
- nút pause hoặc chữ pause

Yêu cầu:

- đặt anchor hợp lý
- HUD không bị lệch mạnh khi đổi độ phân giải
- có tiêu đề hoặc nhãn dễ hiểu

### Bài 6

Tạo 2 phiên bản layout:

- layout cho màn hình ngang
- layout cho màn hình dọc hoặc cửa sổ hẹp

Viết 5 dòng giải thích bạn đã xử lý anchor và khoảng cách như thế nào.

### Bài 7

Thử đổi `Canvas Scaler` sang các cấu hình khác nhau rồi ghi nhận:

- cấu hình nào làm UI ổn hơn
- cấu hình nào dễ vỡ bố cục
- nguyên nhân có thể là gì

### Bài 8

Tạo một panel thông báo nhỏ ở góc trên.

Panel này sẽ dùng để hiện các câu như:

- nhặt được coin
- không đủ năng lượng
- đã tạm dừng game

## Phần C: Nối dữ liệu gameplay với UI

### Bài 9

Viết hoặc dùng script có dữ liệu sau:

- `currentHealth`
- `maxHealth`
- `currentEnergy`
- `maxEnergy`
- `coins`

Yêu cầu:

- dữ liệu thay đổi được bằng phím bấm hoặc button debug
- UI đọc đúng các dữ liệu đó

### Bài 10

Tạo nút debug hoặc phím tắt để:

- trừ máu
- hồi máu
- trừ năng lượng
- cộng năng lượng
- cộng coin

### Bài 11

Giải thích bằng 6 đến 10 dòng vì sao cập nhật UI khi dữ liệu đổi thường tốt hơn gọi `SetText` và `SetValue` ở mọi frame.

### Bài 12

Nếu bạn đang dùng `Slider` cho máu, hãy thử thêm một text hiển thị dạng:

- `75/100`
- `20/50`

Sau đó nêu ưu và nhược điểm của:

- chỉ dùng thanh bar
- chỉ dùng text
- dùng cả hai

## Phần D: Animation cho gameplay

### Bài 13

Tạo một animator cho nhân vật với tối thiểu các state:

- Idle
- Run
- Hurt hoặc Attack

### Bài 14

Tạo các parameter phù hợp trong `Animator`.

Ví dụ:

- `Speed`
- `Damaged`
- `Dead`

### Bài 15

Nối script với animator để:

- khi nhân vật di chuyển thì chuyển sang chạy
- khi mất máu thì phát animation bị đánh
- khi hết máu thì phát animation chết hoặc ngã xuống

### Bài 16

Viết 5 đến 8 dòng trả lời:

- gameplay logic nào nên nằm ở script
- animation nên làm phần biểu diễn nào
- vì sao không nên giấu toàn bộ logic trong animation event

## Phần E: Animation cho UI

### Bài 17

Tạo animation hoặc chuyển động đơn giản cho panel pause:

- trượt từ trên xuống
- fade in
- scale từ nhỏ lên

### Bài 18

Tạo hiệu ứng cho thanh máu khi thấp:

- đổi màu sang đỏ
- nhấp nháy nhẹ
- text cảnh báo xuất hiện

### Bài 19

Tạo hiệu ứng cho text coin khi coin tăng:

- phóng to nhanh rồi trở lại bình thường
- đổi màu vàng ngắn hạn

### Bài 20

So sánh 2 cách làm animation UI:

- dùng `Animator`
- dùng script nội suy như `Lerp`

Viết bảng ngắn gồm:

- khi nào nên dùng cách 1
- khi nào nên dùng cách 2
- điểm mạnh
- điểm yếu

## Phần F: Bài tập nâng dần

### Bài 21

Tạo một màn chơi demo có các đối tượng sau:

- player giả lập chỉ số
- 3 item coin trong scene
- 1 nút pause
- 1 panel cảnh báo năng lượng thấp

### Bài 22

Yêu cầu người chơi nhấn các phím:

- `1` để mất máu
- `2` để hồi máu
- `3` để dùng năng lượng
- `4` để nhận coin
- `Esc` để pause

Sau đó mô tả HUD thay đổi ra sao sau từng thao tác.

### Bài 23

Thêm một thông báo nhiệm vụ nhỏ có 3 trạng thái:

- chưa bắt đầu
- đang thực hiện
- hoàn thành

Mỗi trạng thái nên có biểu diễn UI khác nhau.

### Bài 24

Tạo một hệ thống icon kỹ năng đơn giản:

- icon đang sẵn sàng
- icon đang hồi chiêu
- text đếm ngược hoặc hình phủ radial

### Bài 25

Viết mô tả kiến trúc ngắn cho hệ thống UI demo của bạn, trả lời:

- script nào giữ dữ liệu
- script nào lắng nghe dữ liệu
- script nào điều khiển animation UI
- script nào chỉ dùng để test input

## Phần G: Tình huống sửa lỗi

### Bài 26

Thanh máu không cập nhật dù giá trị máu thật đã đổi.

Hãy liệt kê ít nhất 8 nguyên nhân có thể.

Gợi ý:

- quên gán reference
- gán sai object
- chưa subscribe event
- UI bị vô hiệu hóa
- chia số nguyên sai
- `maxHealth` bằng 0
- slider min max sai
- script bị lỗi null reference

### Bài 27

Panel pause hiện ra nhưng game không dừng.

Hãy nêu:

- cách bạn kiểm tra `Time.timeScale`
- script nào đang nhận input
- object nào điều khiển panel

### Bài 28

Animation chạy nhưng sai thời điểm.

Viết quy trình debug từng bước:

- kiểm tra input
- kiểm tra condition transition
- kiểm tra parameter animator
- kiểm tra exit time
- kiểm tra script gọi đúng chưa

### Bài 29

UI bị lệch trên màn hình khác độ phân giải.

Viết checklist xử lý:

- anchor
- pivot
- canvas scaler
- safe area
- khoảng cách theo pixel
- layout group nếu có

### Bài 30

Viết một đoạn phản biện ngắn:

"Nếu UI demo nhỏ, cứ dùng `Update()` cho nhanh có sao không?"

Bạn có thể đồng ý một phần, nhưng phải chỉ ra khi nào cách đó bắt đầu gây hại.

## Phần H: Mini project

### Bài 31

Làm mini project `Combat HUD Demo`.

Yêu cầu tối thiểu:

- HUD có máu, năng lượng, coin
- có panel pause
- có text thông báo ngắn
- có animation cho nhân vật hoặc UI
- có ít nhất 5 input debug

### Bài 32

Thêm phần hoàn thiện cho mini project:

- cảnh báo máu thấp
- hồi năng lượng theo thời gian
- coin text đổi màu khi tăng
- panel pause trượt vào màn hình

### Bài 33

Viết tài liệu sử dụng ngắn cho project gồm:

- phím điều khiển
- mục đích từng script
- thứ tự kéo thả component trong inspector

### Bài 34

Ghi lại 3 quyết định thiết kế bạn đã chọn.

Ví dụ:

- dùng event thay vì polling
- dùng slider cho máu và năng lượng
- dùng text riêng cho hint thay vì popup phức tạp

### Bài 35

Viết 5 điều bạn sẽ làm tiếp nếu muốn biến demo thành hệ thống UI dùng được cho game thật.

## Câu hỏi review nhanh

### Câu 1

Vì sao `RectTransform` quan trọng với UI?

### Câu 2

Anchor ảnh hưởng gì khi đổi độ phân giải?

### Câu 3

Khi nào nên cập nhật UI theo sự kiện?

### Câu 4

Khi nào animation UI bằng script lại hợp lý?

### Câu 5

Vì sao animation giúp gameplay dễ đọc hơn?

### Câu 6

HUD và menu khác nhau ở điểm nào?

### Câu 7

Vì sao không nên để mọi thứ trong một script UI khổng lồ?

### Câu 8

Một hệ thống pause cơ bản nên có những phần nào?

### Câu 9

Tại sao text cảnh báo tạm thời nên có cách ẩn đi rõ ràng?

### Câu 10

Nếu thanh máu dùng màu, vì sao vẫn nên cân nhắc thêm số?

## Gợi ý tự đánh giá

Cho điểm từ 1 đến 5 cho từng tiêu chí sau:

- Tôi hiểu rõ dữ liệu nào đang nuôi UI.
- Tôi không còn phụ thuộc hoàn toàn vào `Update()` cho mọi nhãn text.
- Tôi biết tạo ít nhất một animation UI.
- Tôi biết kết nối script gameplay với animator.
- Tôi biết debug lỗi UI null reference.
- Tôi biết tổ chức script theo trách nhiệm.

## Rubric chấm nhanh

### Mức đạt cơ bản

- UI hiển thị đúng dữ liệu.
- Có ít nhất một animation hoạt động.
- Có thể debug bằng phím hoặc button.

### Mức khá

- Có cảnh báo máu thấp.
- Có pause panel hoạt động.
- Có giải thích kiến trúc tách dữ liệu và hiển thị.

### Mức tốt

- UI ổn ở nhiều độ phân giải.
- Có logic cập nhật theo sự kiện.
- Có mini project hoàn chỉnh và mô tả rõ ràng.

## Bài viết tổng kết cuối buổi

Viết từ 12 đến 20 dòng trả lời các câu sau:

- Hôm nay bạn đã làm được UI nào?
- Animation nào dễ nhất với bạn?
- Phần nào gây lỗi nhiều nhất?
- Bạn hiểu thêm gì về tách gameplay và presentation?
- Nếu làm lại, bạn sẽ đổi điều gì đầu tiên?
