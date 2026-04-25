# Bài 3: Lưu Game

## Mục tiêu

- Hiểu lưu game là gì và vì sao nó rất quan trọng với trải nghiệm người chơi.
- Biết dữ liệu nào nên lưu và dữ liệu nào không nhất thiết phải lưu.
- Hiểu sự khác nhau giữa lưu dữ liệu cần thiết và cố lưu mọi thứ một cách máy móc.
- Biết tư duy thiết kế `SaveData` rõ ràng, dễ mở rộng.
- Tránh các lỗi phổ biến của người mới khi làm hệ thống save.
- Có quy trình suy nghĩ đúng trước khi bắt tay viết code lưu game.

## Bức tranh tổng quan

Người chơi dành thời gian cho game để đạt tiến trình.

Tiến trình đó có thể là:

- qua màn
- lên cấp
- mở khóa kỹ năng
- nhặt item quý
- hoàn thành nhiệm vụ
- chỉnh thiết lập theo ý muốn

Nếu game không lưu được những thứ cần thiết, người chơi sẽ rất dễ bực bội.

Hãy tưởng tượng:

- chơi 2 tiếng
- đánh boss xong
- nhặt nhiều vật phẩm hiếm
- thoát game
- vào lại thấy mất sạch

Chỉ một lần như vậy cũng đủ làm người chơi mất niềm tin vào trò chơi.

Vì vậy, lưu game không phải tính năng phụ.

Nó là một phần của chất lượng sản phẩm.

## Khái niệm

Lưu game là quá trình ghi lại dữ liệu cần thiết để lần sau người chơi quay lại, game có thể khôi phục tiến trình và trạng thái phù hợp.

Từ khóa quan trọng ở đây là:

`dữ liệu cần thiết`

Không phải mọi thứ trong scene đều cần lưu.

Điều game cần là lưu đủ để tái tạo lại trải nghiệm đúng.

Ví dụ:

- level hiện tại
- số vàng
- item đã nhặt
- checkpoint gần nhất
- thiết lập âm thanh
- tùy chọn đồ họa
- nhiệm vụ đã hoàn thành

## Tại sao phải dùng cái này?

### 1. Giữ tiến trình cho người chơi

Đây là lý do rõ ràng nhất.

Người chơi cần quay lại và tiếp tục được.

### 2. Tạo cảm giác đầu tư có giá trị

Khi công sức của người chơi được giữ lại, họ có xu hướng gắn bó hơn.

### 3. Hỗ trợ trải nghiệm dài hạn

Game càng dài, hệ thống lưu càng quan trọng.

### 4. Giúp game có cảm giác hoàn chỉnh

Một game không lưu được thường cho cảm giác rất “prototype”.

## Liên hệ game thực tế

### Game platformer theo màn

Có thể cần lưu:

- màn hiện tại
- checkpoint gần nhất
- số coin tổng
- mạng còn lại
- các vật phẩm đã mở khóa

### Game RPG

Có thể cần lưu:

- level nhân vật
- kinh nghiệm
- kỹ năng đã mở
- trang bị
- inventory
- nhiệm vụ
- vị trí hiện tại
- trạng thái thế giới

### Game mobile casual

Có thể cần lưu:

- tiến trình level
- sao đạt được
- tiền mềm, tiền cứng
- skin đã mở khóa
- setting âm thanh

## Dữ liệu nào thường nên lưu?

### Tiến trình chơi

Ví dụ:

- level hiện tại
- màn đã mở khóa
- checkpoint gần nhất
- phần trăm hoàn thành

### Tài nguyên

Ví dụ:

- vàng
- gem
- điểm kỹ năng
- năng lượng

### Trạng thái nhân vật

Ví dụ:

- level
- máu tối đa đã nâng cấp
- kỹ năng đã học
- trang bị đang dùng

### Inventory hoặc item đã sở hữu

Ví dụ:

- kiếm nào đã mở
- số bình máu còn lại
- item nhiệm vụ đã nhặt chưa

### Thiết lập người dùng

Ví dụ:

- âm lượng nhạc
- âm lượng hiệu ứng
- độ nhạy chuột
- chế độ fullscreen
- ngôn ngữ

### Trạng thái thế giới nếu game cần

Ví dụ:

- cửa nào đã mở
- boss nào đã bị đánh bại
- rương nào đã mở
- công tắc nào đã kích hoạt

## Dữ liệu nào không nhất thiết phải lưu nguyên xi?

Đây là điểm người mới rất hay nhầm.

Không phải mọi thứ đang tồn tại trong scene đều cần ghi lại đầy đủ.

Ví dụ không nhất thiết lưu nguyên xi:

- từng vị trí hạt bụi particle
- từng viên đạn đang bay nếu game không cần khôi phục chính xác khoảnh khắc đó
- trạng thái tạm thời rất ngắn hạn
- dữ liệu có thể tính lại từ nguồn khác

Điều quan trọng là tái tạo kết quả cần thiết, không phải chụp ảnh toàn bộ bộ nhớ một cách mù quáng.

## Sai lầm tư duy phổ biến: cố lưu toàn bộ scene

Nhiều người mới nghĩ:

“Nếu lưu được mọi thứ trong scene thì chắc là tốt nhất.”

Nghe có vẻ hợp lý, nhưng thực tế thường không phải cách khôn ngoan.

Vì sao?

- phức tạp hơn mức cần thiết
- khó mở rộng
- khó debug
- dữ liệu save phình to
- dễ phụ thuộc vào cấu trúc scene hiện tại

Cách nghĩ tốt hơn là:

“Điều tối thiểu nào cần lưu để khôi phục trải nghiệm đúng?”

## Thiết kế `SaveData` là gì?

`SaveData` là một cấu trúc hoặc class chuyên dùng để chứa dữ liệu cần lưu.

Ví dụ:

```csharp
[System.Serializable]
public class SaveData
{
    public int currentLevel;
    public int gold;
    public int playerHealth;
    public float musicVolume;
    public string lastCheckpointId;
}
```

Ý tưởng rất quan trọng:

- gom dữ liệu cần lưu vào một nơi rõ ràng
- tách khỏi logic gameplay đang chạy
- dễ serialize hơn
- dễ kiểm tra và mở rộng hơn

## Tại sao nên tách SaveData riêng?

### 1. Dễ nhìn dữ liệu nào đang được lưu

Nếu dữ liệu save nằm rải rác khắp nơi, bạn sẽ rất khó kiểm soát.

### 2. Dễ serialize và deserialize

Bạn có một cấu trúc đại diện rõ ràng cho file save.

### 3. Dễ thêm hoặc bỏ trường dữ liệu

Khi dự án lớn lên, đây là lợi ích rất quan trọng.

### 4. Dễ test

Bạn có thể in ra, so sánh, hoặc kiểm tra `SaveData` dễ hơn nhiều so với việc dò khắp scene.

## Quy trình suy nghĩ khi làm lưu game

### Bước 1: Xác định người chơi cần quay lại tiếp tục từ đâu

Ví dụ:

- từ đầu màn
- từ checkpoint gần nhất
- từ vị trí đang đứng

Không có một đáp án đúng cho mọi game.

### Bước 2: Liệt kê dữ liệu thực sự cần thiết

Tự hỏi:

- nếu thiếu dữ liệu này, trải nghiệm có sai đi không?
- dữ liệu này có thể tính lại không?
- dữ liệu này có tồn tại dài hạn hay chỉ là tạm thời?

### Bước 3: Tạo cấu trúc dữ liệu lưu rõ ràng

Ví dụ nhóm theo:

- player data
- world data
- settings data

### Bước 4: Quyết định thời điểm save

Ví dụ:

- save khi qua checkpoint
- save khi đổi scene
- save khi bấm nút save
- autosave sau mốc quan trọng

### Bước 5: Quyết định thời điểm load

Ví dụ:

- khi mở game
- khi chọn Continue
- khi vào scene gameplay

### Bước 6: Nghĩ tới dữ liệu mặc định khi chưa có file save

Người mới hay quên trường hợp này.

Game cần biết làm gì khi người chơi mới chơi lần đầu.

## Ví dụ tư duy: game platformer đơn giản

Giả sử game của bạn có:

- 5 màn
- coin
- checkpoint
- âm thanh

Bạn có thể quyết định lưu:

- màn cao nhất đã mở
- số coin tổng
- checkpoint cuối cùng của màn hiện tại
- volume nhạc và hiệu ứng

Bạn không nhất thiết phải lưu:

- từng vị trí của mọi vật trang trí
- từng enemy đang đi ở đâu nếu khi vào lại màn bạn spawn lại theo thiết kế mặc định

## Ví dụ tư duy: game có inventory

Nếu người chơi có túi đồ, bạn cần nghĩ:

- lưu danh sách item theo ID
- lưu số lượng
- lưu item đang trang bị

Đừng chỉ nghĩ “lưu object item trong scene”, vì cách đó thường gắn quá chặt với runtime.

## Hình dung luồng save và load

### Khi save

1. lấy dữ liệu từ các hệ thống liên quan
2. đổ vào `SaveData`
3. serialize ra định dạng lưu trữ
4. ghi ra file hoặc nơi lưu phù hợp

### Khi load

1. đọc file save
2. deserialize thành `SaveData`
3. phân phối dữ liệu về các hệ thống tương ứng
4. khôi phục trạng thái cần thiết

Tư duy này rất quan trọng vì nó giúp bạn tách rõ:

- dữ liệu lưu
- logic gameplay runtime

## Những lỗi sai thường gặp của người mới

### 1. Cố lưu toàn bộ scene một cách máy móc

Đây là lỗi rất phổ biến.

Hậu quả:

- phức tạp
- nặng nề
- khó sửa khi game đổi cấu trúc

### 2. Không tách `SaveData` riêng

Khi không có cấu trúc dữ liệu save rõ ràng, hệ thống dễ trở nên chắp vá.

### 3. Lưu dữ liệu runtime thay vì dữ liệu ý nghĩa

Ví dụ lưu trực tiếp những thứ chỉ có ý nghĩa trong một phiên chạy ngắn thay vì lưu thông tin thực sự cần cho người chơi.

### 4. Không nghĩ tới trường hợp người chơi chưa có file save

Game có thể lỗi hoặc load sai giá trị mặc định.

### 5. Không nghĩ tới mở rộng sau này

Ví dụ hôm nay chỉ lưu coin và level.

Mai thêm nhiệm vụ, inventory, kỹ năng nhưng cấu trúc cũ quá rối để mở rộng.

### 6. Lưu quá thường xuyên hoặc quá thiếu kiểm soát

Việc autosave liên tục không suy nghĩ cũng có thể gây tốn kém hoặc khó kiểm soát luồng game.

### 7. Không kiểm tra tính hợp lệ của dữ liệu load

Trong thực tế, dữ liệu có thể thiếu, cũ, hoặc không đúng như kỳ vọng.

## Mẹo thực hành tốt cho người mới

- Bắt đầu từ dữ liệu thật sự tối thiểu nhưng đủ dùng.
- Luôn tạo một class hoặc cấu trúc `SaveData` rõ ràng.
- Tách save tiến trình và save settings nếu thấy hợp lý.
- Đặt tên trường dữ liệu dễ hiểu.
- Ghi chú trong đầu rằng “save là dữ liệu, không phải là scene sống”.
- Test cả trường hợp có save và chưa có save.

## Một checklist hữu ích khi thiết kế save

- Người chơi cần quay lại từ đâu?
- Dữ liệu nào là tối thiểu để khôi phục đúng trải nghiệm?
- Dữ liệu nào có thể tính lại thay vì lưu?
- Có cấu trúc `SaveData` rõ ràng chưa?
- Nếu chưa có file save thì game làm gì?
- Khi thêm tính năng mới, hệ thống save có dễ mở rộng không?

## Tóm tắt

- Lưu game là quá trình ghi lại dữ liệu cần thiết để khôi phục tiến trình và trạng thái phù hợp cho người chơi.
- Điều quan trọng là lưu đủ dữ liệu cần thiết, không phải cố lưu toàn bộ scene.
- Dữ liệu thường nên lưu gồm tiến trình, tài nguyên, trạng thái nhân vật, item, thiết lập và trạng thái thế giới khi cần.
- `SaveData` nên được tách riêng để dễ quản lý, serialize và mở rộng.
- Hệ thống save tốt bắt đầu từ câu hỏi: người chơi cần quay lại như thế nào?
- Lỗi phổ biến là lưu quá máy móc, không nghĩ theo ý nghĩa gameplay, và không chuẩn bị cho trường hợp chưa có file save.

## Tự kiểm tra

1. Lưu game là gì?
2. Vì sao nói từ khóa quan trọng là “dữ liệu cần thiết”?
3. Hãy nêu 5 loại dữ liệu thường nên lưu.
4. Hãy nêu 3 ví dụ dữ liệu không nhất thiết phải lưu nguyên xi.
5. Vì sao không nên cố lưu toàn bộ scene một cách máy móc?
6. `SaveData` là gì và vì sao nên tách riêng?
7. Khi thiết kế save, câu hỏi đầu tiên nên là gì?
8. Nếu game của bạn có checkpoint, bạn nên nghĩ gì về dữ liệu cần lưu?
9. Vì sao cần xử lý trường hợp người chơi chưa có file save?
10. Một hệ thống save tốt cần dễ mở rộng như thế nào khi game thêm tính năng mới?

## Bài tập suy nghĩ thêm

- Hãy tưởng tượng bạn làm một game platformer có coin, checkpoint và 3 loại item đặc biệt.
- Liệt kê dữ liệu tối thiểu bạn sẽ lưu.
- Sau đó liệt kê những thứ bạn quyết định không lưu và giải thích vì sao.
- So sánh hai danh sách đó để luyện tư duy chọn dữ liệu có ý nghĩa.

Khi bạn hiểu đúng về lưu game, bạn không chỉ đang lưu dữ liệu, mà đang bảo vệ công sức và trải nghiệm của người chơi.
