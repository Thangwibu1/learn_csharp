# Bài tập Bài 2

## Bài 1

Tạo class `CoinWallet` có event `OnGoldChanged`.

## Bài 2

Tạo class `GoldUI` đăng ký nghe event đó và in số vàng mới.

## Bài 3

Tự giải thích: vì sao event giúp tránh phải kiểm tra trong `Update()` liên tục?

## Phần A - Ôn lại ý chính

- Delegate là kiểu dữ liệu đại diện cho method.
- `Action` là delegate có sẵn, viết gọn.
- `event` là cách công khai cơ chế phát tín hiệu an toàn hơn.
- Event rất hợp khi một nơi phát và nhiều nơi cùng nghe.
- Trong game, event đặc biệt mạnh với UI, audio, quest, achievement và analytics.

## Phần B - Bài tập khởi động

### Bài 4

Tạo delegate `SimpleLog` nhận vào một chuỗi.

Yêu cầu:

- Viết 2 method phù hợp chữ ký.
- Gán cả 2 method vào cùng một delegate.
- Gọi delegate một lần và quan sát cả 2 method chạy.

Gợi ý:

- Đây là cách tốt để hiểu delegate có thể giữ nhiều method.

### Bài 5

Tạo `Action<string>` dùng để in thông báo.

Yêu cầu:

- Một method in nguyên văn.
- Một method in chữ hoa.
- Một method in độ dài chuỗi.

Tự kiểm tra:

- Điều gì giống và khác giữa delegate tự định nghĩa với `Action<string>`?

### Bài 6

Tạo class `CoinWallet` có `event Action<int> OnGoldChanged`.

Yêu cầu:

- Có method `AddGold`.
- Có method `SpendGold`.
- Mỗi lần vàng đổi, phát event.

### Bài 7

Tạo class `GoldUI` đăng ký nghe `OnGoldChanged`.

Yêu cầu:

- In số vàng mới.
- Thử cộng vàng 3 lần.
- Thử trừ vàng 2 lần.

### Bài 8

Tạo class `AudioFeedback` cũng nghe `OnGoldChanged`.

Yêu cầu:

- Khi vàng tăng, in log âm thanh nhận vật phẩm.

Tự kiểm tra:

- Một event có thể có bao nhiêu listener?

## Phần C - Event trong bối cảnh game

### Bài 9

Tạo class `PlayerMana` có `event Action<int> OnManaChanged`.

Yêu cầu:

- Dùng mana.
- Hồi mana.
- UI mana tự cập nhật khi event chạy.

### Bài 10

Tạo class `AmmoCounter` có `event Action<int> OnAmmoChanged`.

Yêu cầu:

- Bắn làm giảm đạn.
- Nạp đạn làm tăng lại.
- `AmmoUI` hiển thị giá trị mới.

### Bài 11

Tạo class `QuestSystem` có `event Action<string> OnQuestCompleted`.

Yêu cầu:

- Khi hoàn thành quest, phát id quest.
- UI thông báo quest hoàn thành.
- Achievement system cũng nghe event này.

### Bài 12

Tạo class `EnemySpawner` có `event Action<string> OnEnemySpawned`.

Yêu cầu:

- Spawn 3 enemy khác nhau.
- `MiniMapSystem` và `QuestTracker` cùng nghe.

### Bài 13

Tạo class `DoorSystem` có `event Action OnDoorOpened`.

Yêu cầu:

- Khi cửa mở, âm thanh và UI cùng phản ứng.

## Phần D - Bài tập về hủy đăng ký

### Bài 14

Tạo một listener đăng ký vào `CoinWallet.OnGoldChanged`, sau đó hủy đăng ký.

Yêu cầu:

- Kiểm tra rằng listener không còn được gọi sau khi `-=`.

### Bài 15

Giải thích bằng lời:

- Vì sao quên hủy đăng ký event có thể gây lỗi hoặc hành vi khó hiểu?

### Bài 16

Viết ví dụ mà listener bị gọi 2 lần do đăng ký lặp.

Yêu cầu:

- In log để thấy bug.
- Sau đó sửa bug.

### Bài 17

Tưởng tượng trong Unity, object bị disable nhưng chưa hủy đăng ký event.

Hãy mô tả 3 vấn đề có thể xuất hiện.

## Phần E - So sánh polling và event

### Bài 18

Viết đoạn mô tả so sánh hai cách cập nhật UI máu:

- Kiểm tra liên tục trong `Update()`.
- Phát `OnHealthChanged` khi máu đổi.

Yêu cầu:

- Nêu ưu điểm.
- Nêu nhược điểm.
- Nêu khi nào mỗi cách hợp lý hơn.

### Bài 19

Cho 5 tình huống game, hãy chọn dùng polling hay event.

Ví dụ tham khảo:

- Máu thay đổi.
- Đồng hồ đếm ngược mỗi frame.
- Người chơi nhặt item.
- Góc xoay camera mượt theo thời gian.
- Hoàn thành quest.

### Bài 20

Tự giải thích vì sao event thường giúp code “ít dính cứng” hơn.

Gợi ý:

- Hãy nói về publisher và subscriber.

## Phần F - Bài tập thiết kế API

### Bài 21

Đặt tên 10 event theo phong cách rõ ràng.

Ví dụ:

- `OnHealthChanged`
- `OnPlayerDied`

Yêu cầu:

- Tên phải gợi được điều gì đã xảy ra.

### Bài 22

Cho các tên event sau và sửa cho tốt hơn:

- `OnChange`
- `OnUpdate`
- `OnDo`
- `OnData`

### Bài 23

Cho event `OnQuestCompleted`, hãy quyết định tham số nên là gì trong 3 phương án:

- `string questId`
- `int questIndex`
- `QuestData quest`

Yêu cầu:

- Giải thích ưu nhược điểm từng phương án.

### Bài 24

Tạo một class có 3 event khác nhau.

Yêu cầu:

- Một event không tham số.
- Một event có một tham số.
- Một event có hai tham số.

## Phần G - Bài tập code callback

### Bài 25

Viết method `LoadData(Action onCompleted)`.

Yêu cầu:

- In log bắt đầu tải.
- In log hoàn tất.
- Gọi callback khi xong.

### Bài 26

Viết method `PlayAttack(Action onFinished)`.

Yêu cầu:

- Mô phỏng animation xong thì callback chạy.

### Bài 27

Viết method `SpawnEnemy(string enemyName, Action<string> onSpawned)`.

Yêu cầu:

- Sau khi spawn, callback nhận lại tên enemy.

### Bài 28

Giải thích callback khác event ở đâu về mục đích sử dụng.

## Phần H - Tự kiểm tra nhanh

### Câu 1

Delegate lưu dữ liệu gì?

### Câu 2

`Action<int>` nghĩa là gì?

### Câu 3

`event` khác `Action` công khai ở điểm nào?

### Câu 4

Publisher là ai?

### Câu 5

Subscriber là ai?

### Câu 6

`?.Invoke()` giải quyết vấn đề gì?

### Câu 7

Khi nào nên hủy đăng ký event?

### Câu 8

Một event có thể có nhiều listener không?

### Câu 9

Vì sao event hợp với UI?

### Câu 10

Vì sao event hợp với achievement system?

## Phần I - Lỗi thường gặp

### Lỗi 1

Quên hủy đăng ký event.

### Lỗi 2

Đặt tên event quá chung chung.

### Lỗi 3

Nhồi quá nhiều trách nhiệm vào publisher.

### Lỗi 4

Dùng lambda quá dài, khó đọc.

### Lỗi 5

Đăng ký trùng listener nhiều lần.

### Lỗi 6

Nhầm giữa callback một lần và event nhiều nơi cùng nghe.

### Lỗi 7

Lạm dụng event cho bài toán chỉ cần gọi method trực tiếp.

### Lỗi 8

Không log khi nghi ngờ event bị gọi sai số lần.

## Phần J - Gợi ý tự review code

- Publisher có đang biết quá nhiều listener cụ thể không?
- Tên event có nói rõ điều gì xảy ra không?
- Listener có thể tách ra class riêng cho gọn hơn không?
- Có chỗ nào cần `-=` mà bạn chưa viết không?
- Có thể thay polling bằng event ở đâu?
- Có chỗ nào event khiến luồng chạy quá khó theo dõi không?

## Phần K - Mini project

### Mini project 1

Xây hệ thống máu người chơi nhỏ.

Yêu cầu:

- `PlayerHealth` phát `OnHealthChanged`.
- `HealthUI` nghe event.
- `AudioSystem` nghe event.
- `AchievementSystem` nghe event chết.

### Mini project 2

Xây hệ thống ví tiền.

Yêu cầu:

- `CoinWallet`
- `GoldUI`
- `ShopSystem`
- `AudioFeedback`

### Mini project 3

Xây hệ thống quest dùng event.

Yêu cầu:

- Khi giết enemy, phát event.
- Quest tracker nghe event để cập nhật.
- UI quest nghe event để hiển thị tiến trình.

## Phần L - Reflection

Tự trả lời:

1. Bạn thấy delegate dễ hiểu hơn khi nghĩ theo hình ảnh nào?
2. Bạn thấy event gần với hệ thống game nào nhất?
3. Bạn từng viết polling chỗ nào có thể đổi sang event?
4. Bạn còn mơ hồ nhất ở `delegate`, `Action`, hay `event`?
5. Sau bài này, bạn muốn tự làm thêm demo nào?

## Phần M - Checklist hoàn thành

- Tôi đã tự tạo ít nhất 2 delegate hoặc `Action` demo.
- Tôi đã viết ít nhất 3 event khác nhau.
- Tôi đã có ví dụ nhiều listener cùng nghe một event.
- Tôi đã có ví dụ hủy đăng ký bằng `-=`.
- Tôi đã so sánh polling và event.
- Tôi đã làm ít nhất 1 mini project nhỏ.
- Tôi đã tự viết giải thích bằng lời của mình.
