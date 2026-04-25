# Bài tập Bài 4

## Bài 1

Tạo singleton `AudioManager` có method `PlayMusic()`.

## Bài 2

Tạo danh sách số và dùng LINQ để lọc ra các số lớn hơn 50.

## Bài 3

Tự giải thích: khi nào nên dùng Singleton, khi nào không nên dùng?

## Phần A - Mục tiêu ôn tập

- Hiểu Singleton là gì và vì sao nó tiện.
- Biết nhận ra rủi ro khi lạm dụng truy cập toàn cục.
- Làm quen với LINQ để lọc, tìm, sắp xếp, biến đổi dữ liệu.
- Áp dụng Singleton và LINQ vào bối cảnh game thực tế.

## Phần B - Bài tập Singleton cơ bản

### Bài 4

Tạo singleton `SaveManager`.

Yêu cầu:

- Constructor private.
- Có property `Instance`.
- Có method `SaveGame()`.

### Bài 5

Tạo singleton `SceneLoader`.

Yêu cầu:

- Có method `LoadScene(string sceneName)`.
- Gọi từ nhiều nơi nhưng vẫn cùng một instance.

### Bài 6

Tạo singleton `AudioManager` có:

- `PlayMusic(string trackName)`
- `PlaySfx(string sfxName)`

### Bài 7

Kiểm tra hai biến tham chiếu đều trỏ về cùng một singleton.

Gợi ý:

- Dùng `ReferenceEquals`.

### Bài 8

Giải thích bằng lời: vì sao constructor singleton thường để `private`.

## Phần C - Phân tích tính hợp lý của Singleton

### Bài 9

Cho các hệ thống sau, hãy đánh giá có nên là singleton không và vì sao:

- AudioManager
- SaveManager
- Inventory của người chơi
- Weapon hiện tại của enemy
- SceneTransitionManager
- QuestProgress của từng save file

### Bài 10

Nêu 5 dấu hiệu cho thấy `GameManager` đang bị nhồi quá nhiều trách nhiệm.

### Bài 11

Viết lại mô tả sau theo hướng tốt hơn:

- `GameManager` vừa lưu quest, vừa phát âm thanh, vừa quản lý inventory, vừa load scene.

### Bài 12

Giải thích vì sao singleton dễ gây coupling ẩn.

### Bài 13

Tự trả lời:

- “Tiện gọi từ mọi nơi” có đủ là lý do tốt để dùng singleton không?

## Phần D - LINQ cơ bản với số

### Bài 14

Tạo danh sách số và dùng LINQ `Where` để lọc số lớn hơn 50.

### Bài 15

Tạo danh sách điểm và dùng `OrderByDescending` để sắp từ cao xuống thấp.

### Bài 16

Dùng `FirstOrDefault` để tìm số đầu tiên lớn hơn 100.

### Bài 17

Dùng `Count` để đếm có bao nhiêu số chẵn.

### Bài 18

Giải thích bằng lời mỗi method sau dùng để làm gì:

- `Where`
- `Select`
- `OrderBy`
- `OrderByDescending`
- `FirstOrDefault`
- `Count`

## Phần E - LINQ với object game

### Bài 19

Tạo class `PlayerScore` có:

- `Name`
- `Score`
- `Rank`

Sau đó dùng LINQ để lọc người chơi có điểm từ 100 trở lên.

### Bài 20

Dùng LINQ để sắp xếp danh sách `PlayerScore` theo điểm giảm dần.

### Bài 21

Dùng LINQ `Select` để lấy ra chỉ danh sách tên người chơi.

### Bài 22

Dùng `FirstOrDefault` để tìm người chơi đầu tiên thuộc rank `Gold`.

### Bài 23

Dùng `Count` để đếm số người chơi rank `Bronze`.

## Phần F - LINQ trong bối cảnh game

### Bài 24

Tạo danh sách `enemyIds` và dùng LINQ để lọc ra những enemy có chứa chữ `orc`.

### Bài 25

Tạo danh sách item và dùng LINQ để lọc item giá trên 100.

### Bài 26

Tạo danh sách quest và dùng LINQ để lấy các quest chưa hoàn thành.

### Bài 27

Tạo danh sách save slot và dùng LINQ để tìm save mới nhất hoặc có level cao nhất.

### Bài 28

Tạo danh sách kỹ năng và dùng LINQ để lấy tên kỹ năng có cooldown dưới 5 giây.

## Phần G - So sánh LINQ và vòng lặp tay

### Bài 29

Viết cùng một bài toán theo hai cách:

- Dùng `foreach`
- Dùng LINQ

Yêu cầu:

- So sánh độ dài code.
- So sánh độ dễ đọc.
- So sánh mức độ dễ giải thích.

### Bài 30

Nêu 3 trường hợp bạn thấy LINQ làm code đẹp hơn.

### Bài 31

Nêu 3 trường hợp bạn thấy vòng lặp tay dễ hiểu hơn LINQ.

### Bài 32

Giải thích: LINQ là công cụ hay mục tiêu?

## Phần H - Kết hợp Singleton và LINQ

### Bài 33

Tạo singleton `LeaderboardManager` chứa danh sách điểm.

Yêu cầu:

- Có method thêm điểm.
- Có method dùng LINQ lấy top 3.

### Bài 34

Tạo singleton `ItemDatabase` chứa danh sách item.

Yêu cầu:

- Có method lọc item đắt tiền bằng LINQ.
- Có method tìm item theo id.

### Bài 35

Tạo singleton `SaveBrowser` chứa danh sách save slot.

Yêu cầu:

- Dùng LINQ sắp xếp save theo level.

### Bài 36

Phân tích rủi ro của việc để mọi nơi trong game gọi trực tiếp `LeaderboardManager.Instance`.

## Phần I - Tự kiểm tra nhanh

### Câu 1

Singleton đảm bảo điều gì?

### Câu 2

Vì sao constructor thường là `private`?

### Câu 3

Tên nào hợp làm singleton hơn: `AudioManager` hay `PlayerWeapon`?

### Câu 4

`Where` dùng để làm gì?

### Câu 5

`Select` dùng để làm gì?

### Câu 6

`FirstOrDefault` có thể trả về gì nếu không tìm thấy?

### Câu 7

`OrderByDescending` thường hợp với bài toán nào?

### Câu 8

`Count` có thể đếm theo điều kiện không?

### Câu 9

Vì sao lạm dụng singleton làm code khó test hơn?

### Câu 10

Vì sao lạm dụng LINQ có thể làm query khó đọc hơn?

## Phần J - Common mistakes

### Lỗi 1

Dùng singleton chỉ vì “gọi tiện”.

### Lỗi 2

Nhồi mọi thứ vào `GameManager`.

### Lỗi 3

Quên rằng singleton tạo ra điểm truy cập toàn cục.

### Lỗi 4

Viết chuỗi LINQ quá dài và khó hiểu.

### Lỗi 5

Không kiểm tra `null` sau `FirstOrDefault`.

### Lỗi 6

Dùng LINQ khi vòng lặp tay sẽ rõ ràng hơn.

### Lỗi 7

Không tự hỏi class đó có thật sự cần duy nhất một instance không.

## Phần K - Gợi ý tự review

- Class này có thật sự nên là singleton không?
- Nó có đang ôm quá nhiều trách nhiệm không?
- Dùng LINQ ở đây có giúp đọc nhanh hơn không?
- Query có thể tách nhỏ để dễ hiểu hơn không?
- Có chỗ nào `FirstOrDefault` cần kiểm tra null mà bạn chưa làm?
- Có chỗ nào truy cập `Instance` quá sâu không?

## Phần L - Mini project

### Mini project 1

Xây `LeaderboardManager` singleton.

Yêu cầu:

- Lưu danh sách người chơi.
- Dùng LINQ lấy top 5.
- In bảng xếp hạng.

### Mini project 2

Xây `ShopDatabase` singleton.

Yêu cầu:

- Lưu danh sách item.
- Lọc item theo giá.
- Sắp xếp item theo giá tăng dần.

### Mini project 3

Xây `SaveManager` singleton.

Yêu cầu:

- Lưu nhiều save slot.
- Dùng LINQ tìm save có level cao nhất.
- Dùng LINQ lấy tất cả save của class nhân vật cụ thể.

### Mini project 4

Xây `AudioPlaylistManager` singleton.

Yêu cầu:

- Lưu playlist.
- Dùng LINQ lọc track battle.
- Dùng LINQ lấy tên track để hiển thị menu.

## Phần M - Reflection

Tự trả lời:

1. Bạn thấy Singleton hấp dẫn nhất ở điểm nào?
2. Bạn thấy rủi ro lớn nhất của Singleton là gì?
3. Bạn thấy toán tử LINQ nào dễ dùng nhất?
4. Bạn thấy toán tử LINQ nào còn chưa tự tin?
5. Bạn có thể kể 3 hệ thống game nên cẩn thận trước khi biến thành singleton không?

## Phần N - Checklist hoàn thành

- Tôi đã tự viết ít nhất 2 singleton.
- Tôi đã tự kiểm tra 2 biến cùng trỏ về một instance.
- Tôi đã dùng LINQ để lọc dữ liệu.
- Tôi đã dùng LINQ để sắp xếp dữ liệu.
- Tôi đã dùng LINQ để tìm một phần tử cụ thể.
- Tôi đã dùng LINQ để biến đổi dữ liệu bằng `Select`.
- Tôi đã suy nghĩ về mặt lợi và hại của singleton.
- Tôi đã làm ít nhất 1 mini project nhỏ.
