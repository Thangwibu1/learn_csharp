# Bài tập Bài 1: Unity Editor

## Mục tiêu của bộ bài tập

- Làm quen sâu với `Hierarchy`, `Inspector`, `Scene`, `Game`, `Project`, `Console`.
- Tập thói quen quan sát và gọi đúng tên từng cửa sổ trong Unity Editor.
- Biết kiểm tra scene, object, component và asset một cách có hệ thống.
- Tập thao tác lặp lại cho tới khi tay quen thay vì chỉ đọc lý thuyết.

## Chuẩn bị trước khi làm

- Mở Unity Hub.
- Tạo một project mới 2D hoặc 3D tùy ý.
- Đặt tên project rõ ràng, ví dụ `Unity_Editor_Practice`.
- Trong `Assets`, tạo các thư mục: `Scenes`, `Scripts`, `Materials`, `Prefabs`, `Notes`.
- Lưu scene đầu tiên với tên `Lesson01_Editor`.

## Phần 1: Nhận diện giao diện

### Bài 1

Mở project và chỉ ra vị trí của các cửa sổ sau:

- `Hierarchy`
- `Inspector`
- `Scene`
- `Game`
- `Project`
- `Console`

Yêu cầu:

- Viết ra chức năng chính của từng cửa sổ bằng 1 câu.
- Không dùng câu trả lời quá chung chung như "để làm game".

Gợi ý:

- Hãy nhìn xem cửa sổ nào liệt kê object trong scene.
- Hãy xem cửa sổ nào hiển thị file của project.
- Hãy tìm cửa sổ nào hiển thị lỗi và log.

Checklist tự đánh giá:

- Tôi phân biệt được `Project` và `Hierarchy`.
- Tôi phân biệt được `Scene` và `Game`.
- Tôi biết mở `Console` khi cần debug.

### Bài 2

Ẩn một cửa sổ bất kỳ, sau đó tự tìm cách mở lại.

Yêu cầu:

- Ghi lại bạn đã ẩn cửa sổ nào.
- Ghi lại thao tác để mở lại.
- Giải thích vì sao biết cách khôi phục layout là quan trọng.

Gợi ý:

- Hãy khám phá menu `Window`.
- Nếu layout quá rối, hãy tìm cách reset layout.

### Bài 3

Kéo thả lại vị trí của 3 cửa sổ trong editor.

Yêu cầu:

- Chọn một bố cục bạn cảm thấy dễ quan sát.
- Viết ngắn 3 câu về lý do chọn bố cục đó.

Gợi ý:

- Nếu thường sửa object, hãy ưu tiên `Inspector` đủ rộng.
- Nếu thường quan sát console, đừng để `Console` quá nhỏ.

## Phần 2: Làm việc với scene và object

### Bài 4

Tạo một scene mới và lưu vào thư mục `Scenes`.

Yêu cầu:

- Đặt tên scene có ý nghĩa.
- Không dùng tên kiểu `Scene1`, `New Scene`, `Test`.

Checklist:

- Scene được lưu đúng thư mục.
- Tên scene phản ánh mục đích.

### Bài 5

Trong `Hierarchy`, tạo các object sau:

- `Player`
- `Main Camera`
- `Ground`
- `Light` hoặc một object hỗ trợ hiển thị
- `GameManager`

Yêu cầu:

- Mỗi object phải được đổi tên rõ ràng.
- Không để object mang tên mặc định sau khi tạo.

Gợi ý:

- `GameManager` có thể là object rỗng.
- `Ground` có thể là cube, sprite hoặc plane tùy project 2D/3D.

### Bài 6

Chọn từng object vừa tạo và quan sát `Inspector`.

Yêu cầu:

- Ghi ra các component mặc định của từng object.
- Chỉ ra object nào có `Transform`.
- Chỉ ra object nào có thêm renderer hoặc camera component.

Debug prompt:

- Vì sao mọi object đều có `Transform`?
- Vì sao camera có component khác player rỗng?

## Phần 3: Scene view và Game view

### Bài 7

Trong `Scene`, di chuyển camera và thay đổi góc nhìn.

Yêu cầu:

- Mô tả sự khác nhau giữa việc điều hướng trong `Scene` và nội dung thực tế trong `Game`.
- Trả lời: camera của người chơi có thay đổi theo thao tác điều hướng `Scene` không?

### Bài 8

Di chuyển `Main Camera` trong scene và quan sát `Game`.

Yêu cầu:

- Ghi lại ít nhất 3 thay đổi trong `Game` khi camera đổi vị trí.
- Giải thích vì sao object có thể nhìn thấy trong `Scene` nhưng không thấy trong `Game`.

### Bài 9

Tạo một object nằm ngoài vùng nhìn của camera.

Yêu cầu:

- Chứng minh object vẫn tồn tại trong scene.
- Chứng minh object không xuất hiện trong `Game`.
- Viết lại 1 câu kết luận về vai trò của camera.

## Phần 4: Project window và asset

### Bài 10

Trong `Project`, tạo các thư mục con:

- `Scenes`
- `Scripts`
- `Sprites` hoặc `Models`
- `Materials`
- `Prefabs`
- `Audio`

Yêu cầu:

- Chụp lại hoặc mô tả bố cục thư mục cuối cùng.
- Giải thích vì sao không nên để mọi file trực tiếp trong `Assets`.

### Bài 11

Tạo một script mới tên `EditorPracticeLogger`.

Yêu cầu:

- Đặt file trong thư mục `Scripts`.
- Chỉ ra file script vừa tạo là một asset hay một object trong scene.
- Giải thích vì sao script có thể tồn tại trong `Project` nhưng chưa hoạt động trong game.

### Bài 12

Nếu project có hình ảnh hoặc model, hãy import thêm một asset đơn giản.

Yêu cầu:

- Kéo asset vào scene.
- Mô tả điều gì thay đổi trong `Hierarchy`.
- Mô tả điều gì thay đổi trong `Project`.

## Phần 5: Inspector và component

### Bài 13

Thêm một component mới vào `Player`.

Yêu cầu:

- Có thể dùng `SpriteRenderer`, `BoxCollider2D`, `Rigidbody2D`, `AudioSource`, hoặc component phù hợp khác.
- Sau khi thêm, giải thích component đó làm gì.

### Bài 14

Bật và tắt một component trong `Inspector`.

Yêu cầu:

- Ghi rõ bạn đã bật/tắt component nào.
- Quan sát thay đổi trong scene hoặc game.

Gợi ý:

- Tắt renderer để thấy object biến mất nhưng vẫn còn tồn tại.

### Bài 15

Bật và tắt cả `GameObject` trong `Hierarchy`.

Yêu cầu:

- So sánh với việc chỉ tắt một component.
- Trả lời: tắt object và tắt component khác nhau ở đâu?

## Phần 6: Console và debug cơ bản

### Bài 16

Gắn script thực hành vào một object.

Yêu cầu:

- Nhấn `Play`.
- Quan sát `Console`.
- Ghi lại các log xuất hiện.

### Bài 17

Chủ động tạo 3 loại log:

- `Debug.Log`
- `Debug.LogWarning`
- `Debug.LogError`

Yêu cầu:

- Viết ra sự khác nhau về mục đích của 3 loại log này.
- Chỉ ra trường hợp nên dùng từng loại.

### Bài 18

Gây ra một lỗi đơn giản rồi đọc thông tin trong `Console`.

Ví dụ:

- Cố ý dùng biến chưa gán trong code.
- Viết sai tên biến.
- Bỏ quên dấu chấm phẩy hoặc đóng ngoặc.

Yêu cầu:

- Mô tả thông báo lỗi.
- Ghi file và dòng mà Unity báo.
- Tự sửa lỗi rồi chạy lại.

Debug checklist:

- Tôi đã đọc đúng tên file.
- Tôi đã đọc đúng số dòng.
- Tôi đã không sửa mò toàn file.

## Phần 7: Thực hành thao tác editor có chủ đích

### Bài 19

Tạo một object rỗng tên `Environment` rồi đặt `Ground` làm con của nó.

Yêu cầu:

- Quan sát mối quan hệ cha con trong `Hierarchy`.
- Di chuyển `Environment` và xem `Ground` có thay đổi không.

### Bài 20

Tạo object rỗng tên `Characters` rồi đặt `Player` làm con.

Yêu cầu:

- Di chuyển object cha.
- Ghi lại điều gì xảy ra với object con.
- Giải thích vì sao quan hệ cha con hữu ích.

### Bài 21

Sao chép `Player` thành thêm 2 bản nữa.

Yêu cầu:

- Đổi tên thành `Player_A`, `Player_B`, `Player_C`.
- Tránh để tên mặc định kiểu `(1)`, `(2)` nếu có thể.
- Sắp xếp lại vị trí các object cho dễ nhìn.

### Bài 22

Tạo một prefab từ một object bất kỳ nếu bạn đã biết thao tác này.

Yêu cầu:

- Nếu chưa biết prefab, hãy chỉ cần ghi lại câu hỏi: prefab giải quyết vấn đề gì?
- Nếu đã tạo được prefab, hãy kéo prefab ra scene thêm một lần nữa.

## Phần 8: Bài tập theo tình huống

### Bài 23: Tình huống mất object

Giả sử bạn nói: "Object của em biến mất rồi".

Hãy viết quy trình kiểm tra gồm ít nhất 8 bước.

Gợi ý hướng kiểm tra:

- Object có còn trong `Hierarchy` không?
- Object có đang bị tắt không?
- Renderer có đang tắt không?
- Camera có nhìn tới object không?
- Object có bị scale quá nhỏ không?
- Object có nằm quá xa không?
- Có lỗi trong `Console` không?
- Có đang ở sai scene không?

### Bài 24: Tình huống sửa xong nhưng mất

Bạn kéo object trong lúc `Play`, thấy đẹp, nhưng tắt `Play` thì mất.

Yêu cầu:

- Giải thích điều gì đã xảy ra.
- Viết lại 3 nguyên tắc để tránh lỗi này.

### Bài 25: Tình huống project lộn xộn

Giả sử thư mục `Assets` có 40 file lẫn lộn.

Yêu cầu:

- Đề xuất cách tổ chức lại.
- Viết ra 6 thư mục bạn sẽ tạo.
- Giải thích cách đặt tên để cả team dễ tìm file.

## Phần 9: Mini scene task

### Bài 26

Tạo một mini scene trình diễn editor gồm:

- Một player
- Một ground
- Một camera nhìn thấy player
- Một object trang trí
- Một object manager rỗng

Yêu cầu:

- Scene phải được lưu.
- Object phải được đặt tên rõ ràng.
- Thư mục `Assets` phải có cấu trúc cơ bản.

### Bài 27

Thêm script vào `GameManager` để in ra câu chào khi `Play`.

Yêu cầu:

- Log phải xuất hiện trong `Console`.
- Bạn phải chỉ ra script nằm ở đâu trong `Project`.
- Bạn phải chỉ ra component nằm ở đâu trong `Inspector`.

### Bài 28

Tạo một camera thứ hai và đổi góc nhìn.

Yêu cầu:

- So sánh `Game` khi camera chính đổi vị trí.
- Nếu cả hai camera cùng hoạt động, quan sát xem điều gì xảy ra.

## Phần 10: Câu hỏi tự luận ngắn

### Bài 29

Phân biệt:

- `Hierarchy` và `Project`
- `Scene` và `Game`
- `GameObject` và asset
- Bật/tắt object và bật/tắt component

### Bài 30

Vì sao thói quen nhìn `Console` thường xuyên lại quan trọng?

### Bài 31

Vì sao đặt tên object tốt giúp tiết kiệm thời gian khi dự án lớn dần?

### Bài 32

Nếu một bạn mới học chỉ biết viết code mà không biết editor, bạn sẽ khuyên bạn ấy học gì trước trong Unity?

## Phần 11: Checklist hoàn thành bài

- Tôi đã tạo và lưu ít nhất 1 scene.
- Tôi đã nhận diện được 6 cửa sổ quan trọng.
- Tôi đã tạo object trong `Hierarchy`.
- Tôi đã xem component trong `Inspector`.
- Tôi đã gắn ít nhất 1 script vào object.
- Tôi đã mở `Console` và đọc log.
- Tôi đã biết khác nhau giữa `Project` và `Hierarchy`.
- Tôi đã biết thay đổi trong `Play Mode` có thể không được lưu.

## Phần 12: Debug prompt cuối bài

Trước khi sang bài tiếp theo, hãy tự hỏi:

- Khi tôi không thấy object, tôi sẽ kiểm tra gì trước?
- Khi log không xuất hiện, tôi sẽ nhìn đâu?
- Khi project rối, tôi sẽ tổ chức thư mục ra sao?
- Khi tôi chọn một object, tôi mong thấy gì trong `Inspector`?
- Khi tôi nhấn `Play`, tôi kỳ vọng thay đổi nào là tạm thời, thay đổi nào là thật?

## Phần 13: Thử thách mở rộng

### Thử thách 1

Tự mô tả toàn bộ một vòng làm việc ngắn trong Unity Editor từ lúc mở project đến lúc chạy thử scene.

### Thử thách 2

Tạo một video hoặc ghi chú từng bước cho người mới khác, giải thích editor bằng ngôn ngữ đơn giản.

### Thử thách 3

Trong 10 phút, không nhìn tài liệu, hãy chỉ vào từng vùng trong editor và nói to tên cùng chức năng của nó.

## Phần 14: Tổng kết thực hành

Nếu hoàn thành tốt bộ bài tập này, bạn đã có nền tảng rất quan trọng:

- Không còn sợ giao diện Unity.
- Biết nơi cần nhìn khi có lỗi.
- Biết object sống ở đâu và file sống ở đâu.
- Biết editor không phải phần phụ, mà là nơi lắp ráp toàn bộ game.
