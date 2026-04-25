# Bài 1: Unity Editor

## Mục tiêu bài học

- Hiểu Unity Editor là gì.
- Nhận diện đúng các cửa sổ quan trọng trong giao diện Unity.
- Biết mỗi cửa sổ dùng để làm gì trong quy trình tạo game.
- Phân biệt rõ `Scene` và `Game`.
- Biết cách quan sát, chọn, chỉnh và tổ chức đối tượng cơ bản.
- Giảm bối rối khi mới mở Unity lần đầu.

## Unity Editor là gì?

Unity Editor là môi trường làm việc chính của bạn khi tạo game bằng Unity.

Bạn có thể xem nó như một "xưởng làm game".

Trong xưởng đó, bạn không chỉ viết code.

Bạn còn sắp xếp đối tượng, nhập hình ảnh, chỉnh âm thanh, kiểm tra va chạm, chạy thử game và sửa lỗi.

Nói đơn giản hơn, Unity Editor là nơi bạn xây thế giới game và kiểm tra thế giới đó hoạt động ra sao.

Nếu chưa hiểu Editor, người mới thường gặp cảm giác như đang nhìn vào quá nhiều cửa sổ cùng lúc.

Đó là chuyện bình thường.

Mục tiêu đầu tiên không phải là nhớ hết mọi nút.

Mục tiêu đầu tiên là hiểu vai trò của từng khu vực chính.

Khi hiểu vai trò, bạn sẽ biết mắt mình nên nhìn vào đâu khi làm việc.

## Tại sao phải học Unity Editor trước khi học code?

Rất nhiều bạn mới nghĩ rằng làm game chủ yếu là viết script.

Thực tế, script chỉ là một phần.

Nếu không hiểu Editor, bạn sẽ viết code trong trạng thái không rõ object nằm ở đâu, scene đang chứa gì, asset đã được import chưa, hay component đã gắn đúng chưa.

Điều đó khiến bạn khó phân biệt lỗi đến từ code hay lỗi đến từ thao tác trong Editor.

Học Editor trước quan trọng vì:

- Bạn biết nơi tạo và quản lý scene.
- Bạn biết nơi chọn object để chỉnh thông số.
- Bạn biết nơi xem file ảnh, prefab, script và âm thanh.
- Bạn biết nơi chạy thử game.
- Bạn biết nơi quan sát sự khác nhau giữa thế giới đang thiết kế và góc nhìn người chơi.

Nói cách khác, Unity Editor là bản đồ làm việc của bạn.

Không có bản đồ, bạn rất dễ lạc.

## Tư duy đúng khi học giao diện Unity

Đừng cố nhớ giao diện theo kiểu học thuộc lòng từng tên cửa sổ.

Hãy nhớ theo luồng công việc.

Một luồng suy nghĩ đơn giản là:

1. Tôi đang làm việc với đối tượng nào?
2. Đối tượng đó nằm trong scene nào?
3. Tôi chọn nó ở đâu?
4. Tôi chỉnh thuộc tính của nó ở đâu?
5. Tài nguyên liên quan đến nó nằm ở đâu?
6. Tôi chạy thử ở đâu?
7. Tôi đang xem thế giới game bằng góc nhìn thiết kế hay góc nhìn người chơi?

Nếu bạn trả lời được 7 câu hỏi đó, bạn đã bắt đầu hiểu Unity Editor.

## Các cửa sổ quan trọng trong Unity Editor

Trong giai đoạn đầu, bạn nên tập trung vào 5 cửa sổ sau:

- `Hierarchy`
- `Scene`
- `Game`
- `Inspector`
- `Project`

Ngoài ra còn có `Console`, cũng rất quan trọng khi debug.

Chúng ta sẽ đi từng phần thật chậm.

## Hierarchy là gì?

`Hierarchy` là nơi hiển thị danh sách các `GameObject` trong scene hiện tại.

Bạn có thể hiểu nó như cây danh sách mọi thứ đang tồn tại trong màn chơi đang mở.

Nếu scene là một căn phòng, thì `Hierarchy` là bảng liệt kê tất cả đồ vật trong phòng đó.

Ví dụ trong một scene đơn giản, `Hierarchy` có thể chứa:

- `Main Camera`
- `Directional Light`
- `Player`
- `Ground`
- `Enemy`
- `UI`

Khi bạn bấm chọn một object trong `Hierarchy`, Unity sẽ cho bạn chỉnh object đó ở `Inspector`.

Đây là thói quen làm việc rất quan trọng.

`Hierarchy` không phải nơi lưu file.

`Hierarchy` là nơi liệt kê object đang có mặt trong scene đang mở.

### Điều quan trọng cần nhớ về Hierarchy

- Mỗi scene có `Hierarchy` riêng của nó.
- Xóa object trong `Hierarchy` thường là xóa object khỏi scene hiện tại.
- Kéo một object vào bên trong object khác sẽ tạo quan hệ cha con.
- Quan hệ cha con ảnh hưởng đến vị trí, xoay và tổ chức.

### Khi nào bạn nhìn vào Hierarchy?

Bạn nhìn vào `Hierarchy` khi:

- Cần chọn đúng object để chỉnh sửa.
- Cần kiểm tra scene hiện có những gì.
- Cần đổi tên object cho dễ quản lý.
- Cần gom nhóm object theo cha con.
- Cần tìm xem object đã được tạo chưa.

### Lỗi thường gặp với Hierarchy

- Chọn nhầm object có tên giống nhau.
- Không đổi tên object, dẫn tới `GameObject`, `GameObject (1)`, `GameObject (2)` rất khó hiểu.
- Kéo object thành con của object khác mà không để ý.
- Tưởng asset trong thư mục `Project` cũng sẽ xuất hiện trong `Hierarchy` ngay lập tức.

## Scene là gì?

`Scene` là không gian làm việc trực quan để bạn sắp xếp thế giới game.

Ở đây, bạn nhìn object như người thiết kế nhìn vào sân khấu.

Bạn có thể:

- Di chuyển object.
- Xoay object.
- Phóng to thu nhỏ object.
- Quan sát bố cục màn chơi.
- Đặt camera, ánh sáng, nền đất, nhân vật.

`Scene` không nhất thiết là hình ảnh cuối cùng mà người chơi thấy.

Nó là nơi bạn thao tác để xây dựng thế giới.

### Tư duy đúng về Scene

Hãy xem `Scene` là bàn làm việc.

Trên bàn đó, bạn đặt mọi thứ vào đúng vị trí.

Bạn có thể nhìn từ nhiều góc khác nhau.

Bạn có thể phóng to để chỉnh chi tiết nhỏ.

Bạn có thể lùi xa để xem tổng thể.

### Những việc người mới thường làm trong Scene

- Kéo object đến vị trí mong muốn.
- Kiểm tra khoảng cách giữa các object.
- Căn nền đất và nhân vật.
- Đặt chướng ngại vật.
- Chọn object bằng chuột trực tiếp trong khung nhìn.

### Lỗi thường gặp trong Scene

- Chọn sai object vì nhiều object chồng lên nhau.
- Kéo object lệch vị trí ngoài ý muốn.
- Không để ý đang chỉnh theo trục nào.
- Không hiểu mình đang nhìn ở góc nào nên tưởng object biến mất.

## Game là gì?

`Game` là cửa sổ mô phỏng góc nhìn mà người chơi sẽ thấy khi game chạy.

Nếu `Scene` là bàn dựng sân khấu, thì `Game` là khung hình khán giả nhìn thấy.

Đây là khác biệt rất quan trọng.

### Scene và Game khác nhau thế nào?

`Scene`:

- Dành cho nhà phát triển.
- Có thể nhìn từ nhiều góc.
- Dùng để sắp xếp và chỉnh sửa thế giới.

`Game`:

- Dành cho việc xem kết quả khi game chạy.
- Phụ thuộc vào camera.
- Gần với trải nghiệm người chơi hơn.

### Ví dụ dễ hiểu

Bạn đặt một nhân vật trong scene.

Trong `Scene`, bạn có thể nhìn từ trên xuống, từ bên cạnh, hoặc xoay tự do để chỉnh vị trí.

Nhưng trong `Game`, bạn chỉ thấy những gì camera đang ghi lại.

Nếu camera không hướng vào nhân vật, `Game` có thể không thấy nhân vật dù `Scene` vẫn thấy rất rõ.

Đây là lý do nhiều người mới tưởng object bị mất.

Thực ra object vẫn ở scene, chỉ là camera không nhìn thấy nó.

## Inspector là gì?

`Inspector` là nơi hiển thị thông tin chi tiết của object hoặc asset đang được chọn.

Nếu `Hierarchy` giúp bạn chọn đúng đối tượng, thì `Inspector` là nơi bạn chỉnh đối tượng đó.

Ví dụ khi chọn một object, bạn có thể thấy trong `Inspector`:

- Tên object.
- Tag.
- Layer.
- `Transform`.
- Các component khác như `SpriteRenderer`, `Rigidbody`, `BoxCollider`, script.

### Vì sao Inspector rất quan trọng?

Vì trong Unity, phần lớn thao tác cấu hình được thực hiện ở đây.

Bạn không chỉ viết script rồi xong.

Bạn thường phải:

- Gắn component.
- Chỉnh giá trị.
- Bật tắt tùy chọn.
- Kéo thả tham chiếu.
- Kiểm tra object hiện đang có component nào.

### Cách nghĩ đơn giản về Inspector

Hãy coi `Inspector` là bảng thông tin và bảng điều khiển của đối tượng đang chọn.

Chọn cái gì, `Inspector` hiện thông tin của cái đó.

Nếu chọn một file ảnh trong `Project`, `Inspector` hiện thông tin import của ảnh.

Nếu chọn một object trong `Hierarchy`, `Inspector` hiện component của object đó.

### Lỗi thường gặp với Inspector

- Tưởng mình đang sửa object A nhưng thực ra đang chọn object B.
- Quên nhấn vào đúng object trước khi sửa.
- Không hiểu component nào đang chịu trách nhiệm cho hành vi nào.
- Sửa nhầm giá trị trong lúc game đang chạy rồi quên rằng có giá trị sẽ không được lưu sau khi dừng play mode.

## Project là gì?

`Project` là nơi chứa các file tài nguyên của dự án.

Đây là nơi bạn quản lý asset.

Asset có thể là:

- Hình ảnh.
- Âm thanh.
- Animation.
- Material.
- Prefab.
- Scene.
- Script.

Hãy hiểu rõ một điều rất cơ bản:

`Project` là kho tài nguyên.

`Hierarchy` là danh sách object đang có trong scene.

Nhiều bạn mới nhầm hai nơi này với nhau.

### Ví dụ để phân biệt Project và Hierarchy

Bạn có một file ảnh nhân vật trong `Project`.

Điều đó chưa có nghĩa là nhân vật đã xuất hiện trong scene.

Muốn nó xuất hiện, bạn cần kéo asset hoặc prefab vào scene hay `Hierarchy`.

Nói cách khác:

- Có trong `Project` chưa chắc có trong scene.
- Có trong scene thường có liên quan tới dữ liệu nào đó trong `Project`.

## Console là gì?

`Console` là nơi Unity hiển thị thông báo, cảnh báo và lỗi.

Đây là cửa sổ cực kỳ quan trọng khi bạn bắt đầu viết code.

Ba loại thông tin phổ biến:

- Log thông thường.
- Cảnh báo.
- Lỗi.

### Vì sao người mới nên tập nhìn Console sớm?

Vì rất nhiều vấn đề không thể đoán chỉ bằng mắt nhìn scene.

Ví dụ:

- Script bị lỗi biên dịch.
- Thiếu tham chiếu đến object.
- Một hàm không chạy như bạn nghĩ.

`Console` là nơi Unity nói cho bạn biết có chuyện gì xảy ra.

Nếu không nhìn `Console`, bạn dễ sửa sai chỗ.

## Thanh công cụ cơ bản

Ngoài các cửa sổ chính, bạn còn thấy thanh công cụ ở phía trên.

Tùy phiên bản Unity, bố cục có thể hơi khác.

Nhưng về ý nghĩa, người mới nên chú ý những phần sau:

- Công cụ chọn và biến đổi object.
- Nút `Play`.
- Nút `Pause`.
- Nút chạy từng bước khung hình.
- Tùy chọn bố cục giao diện.

## Công cụ biến đổi object

Bạn thường gặp các công cụ như:

- Di chuyển.
- Xoay.
- Co giãn.
- Rect tool trong UI hoặc 2D.

Chúng giúp bạn thao tác trực tiếp trên object trong `Scene`.

Người mới không cần nhớ mọi phím tắt ngay.

Chỉ cần hiểu mỗi công cụ đang thay đổi thuộc tính nào.

Ví dụ:

- Di chuyển làm đổi vị trí.
- Xoay làm đổi góc quay.
- Co giãn làm đổi kích thước.

## Nút Play quan trọng như thế nào?

`Play` là lúc bạn chạy thử game ngay trong Editor.

Đây là bước nối giữa thiết kế và kiểm tra.

Bạn có thể đặt object xong rồi nhấn `Play` để xem:

- Nhân vật có hiện đúng chỗ không.
- Camera có nhìn đúng không.
- Va chạm có hoạt động không.
- Script có chạy không.

### Điều cực kỳ quan trọng về Play Mode

Khi đang ở `Play Mode`, bạn có thể thay đổi một số giá trị để thử nghiệm.

Nhưng nhiều thay đổi chỉ mang tính tạm thời.

Khi dừng chạy game, chúng có thể quay lại như trước.

Người mới rất hay mắc lỗi này.

Bạn chỉnh thấy đúng trong lúc chạy.

Bạn dừng game.

Mọi thứ biến mất.

Không phải Unity hỏng.

Đó là cách hoạt động bình thường của `Play Mode`.

## Quy trình làm việc cơ bản trong Unity Editor

Đây là một quy trình rất thực tế cho người mới:

1. Mở project.
2. Mở scene cần làm.
3. Nhìn `Hierarchy` để xem scene có gì.
4. Chọn object muốn chỉnh.
5. Nhìn `Inspector` để xem các component.
6. Dùng `Scene` để đặt lại vị trí nếu cần.
7. Kiểm tra asset trong `Project` nếu cần hình, âm thanh, script.
8. Nhấn `Play` để chạy thử.
9. Xem `Game` để kiểm tra trải nghiệm người chơi.
10. Nếu có lỗi, mở `Console` để đọc thông báo.

Đây là vòng lặp bạn sẽ dùng lặp đi lặp lại rất nhiều lần.

## Ví dụ workflow 1: Thêm một khối hộp vào scene

Hãy tưởng tượng bạn muốn thêm một khối hộp làm nền đứng.

Luồng suy nghĩ có thể là:

1. Tôi đang ở scene đúng chưa?
2. Trong `Hierarchy`, scene hiện có những object nào?
3. Tôi tạo thêm một object mới.
4. Tôi chọn object đó trong `Hierarchy`.
5. Tôi nhìn `Inspector` để kiểm tra `Transform`.
6. Tôi dùng `Scene` để kéo object đến vị trí mong muốn.
7. Tôi đổi tên object thành `Wall` để dễ hiểu.
8. Tôi nhấn `Play` để xem camera có thấy nó không.
9. Tôi nhìn `Game` để xác nhận kết quả cuối.

Qua ví dụ rất nhỏ này, bạn đã dùng gần như toàn bộ các cửa sổ chính.

## Ví dụ workflow 2: Vì sao nhân vật không hiện trong Game?

Đây là một tình huống cực phổ biến.

Bạn thấy nhân vật trong `Scene` nhưng không thấy trong `Game`.

Quy trình suy nghĩ nên là:

1. Trong `Hierarchy`, nhân vật còn tồn tại không?
2. Trong `Inspector`, object có bị tắt không?
3. Trong `Scene`, nhân vật đang ở vị trí nào?
4. Camera có đang nhìn về phía nhân vật không?
5. Trong `Game`, camera hiển thị gì?
6. Có lỗi nào trong `Console` không?

Từ quy trình này, bạn học được một điều quan trọng:

Đừng kết luận ngay rằng object bị mất.

Hãy kiểm tra theo từng cửa sổ.

## Ví dụ workflow 3: Gắn script nhưng object không hoạt động

Bạn đã tạo script điều khiển nhân vật.

Bạn nghĩ chỉ cần viết code là xong.

Nhưng khi bấm chạy, không có gì xảy ra.

Lúc này, hãy kiểm tra:

1. Script có xuất hiện dưới dạng component trong `Inspector` không?
2. Object đúng đã được chọn trong `Hierarchy` chưa?
3. `Console` có báo lỗi biên dịch không?
4. Biến public trong script có cần kéo thả tham chiếu không?
5. Bạn đang nhìn kết quả trong `Game` hay chỉ đang đứng ở `Scene`?

Chỉ riêng việc hiểu Editor đã giúp bạn giải quyết được nhiều lỗi kiểu này.

## Cách tổ chức giao diện cho người mới

Nếu cảm thấy giao diện rối, hãy giữ nguyên bố cục mặc định hoặc bố cục rất đơn giản.

Điều quan trọng là mắt bạn biết nhìn vào đâu.

Một cách nhớ dễ là:

- Bên trái: `Hierarchy`.
- Ở giữa: `Scene` và `Game`.
- Bên phải: `Inspector`.
- Bên dưới: `Project` và `Console`.

Không cần bố cục đẹp trước.

Cần bố cục dễ học trước.

## Vì sao đổi tên object là thói quen tốt?

Người mới rất hay để tên mặc định.

Ví dụ:

- `Cube`
- `Cube (1)`
- `Cube (2)`

Lúc scene còn ít, điều này chưa nguy hiểm.

Nhưng khi scene lớn hơn, bạn sẽ không biết object nào là tường, object nào là nền, object nào là chướng ngại vật.

Hãy tập đổi tên rõ nghĩa.

Ví dụ:

- `Player`
- `Ground`
- `SpawnPoint`
- `MainMenuUI`
- `Enemy_Left`

Đây là việc nhỏ nhưng giúp học nhanh hơn rất nhiều.

## Những lỗi người mới thường gặp trong Unity Editor

### 1. Không phân biệt `Scene` và `Game`

Đây là lỗi phổ biến nhất.

Bạn chỉnh object trong `Scene` nhưng lại mong `Game` phản ánh giống hệt ngay cả khi camera không nhìn tới.

Hãy nhớ:

`Scene` là nơi dàn dựng.

`Game` là nơi xem kết quả từ camera.

### 2. Chọn nhầm object

Bạn tưởng đang sửa `Player` nhưng thật ra đang sửa `Ground`.

Hậu quả là giá trị trong `Inspector` thay đổi nhưng không ra kết quả như mong muốn.

### 3. Không nhìn `Console`

Bạn chạy game thấy không đúng và sửa bừa trong scene.

Trong khi `Console` có thể đang báo lỗi rất rõ.

### 4. Không hiểu `Project` khác `Hierarchy`

Bạn import ảnh vào `Project` và nghĩ nó sẽ tự hiện trong scene.

Không phải vậy.

`Project` là nơi chứa tài nguyên.

Muốn dùng trong scene, bạn cần đưa nó vào scene hoặc tạo object từ nó.

### 5. Sửa giá trị khi đang chạy rồi tưởng đã lưu

Bạn chỉnh thấy đẹp trong `Play Mode`.

Bạn dừng game và mất hết.

Đây là lỗi rất nhiều người gặp trong tuần đầu học Unity.

## Cách tự kiểm tra mình đã hiểu bài chưa

Hãy thử tự trả lời các câu sau mà không nhìn tài liệu:

1. `Hierarchy` dùng để làm gì?
2. `Project` dùng để làm gì?
3. `Inspector` hiện thông tin của cái gì?
4. `Scene` khác `Game` ở điểm nào?
5. Nếu object có trong `Hierarchy` nhưng không thấy trong `Game`, bạn nên kiểm tra gì?
6. Nếu script báo lỗi, bạn mở cửa sổ nào để đọc?
7. Nếu muốn chỉnh vị trí object, bạn thường dùng `Scene` kết hợp với phần nào?

Nếu bạn trả lời được phần lớn câu hỏi trên, nền tảng của bạn đã khá ổn.

## Tóm tắt theo kiểu rất ngắn gọn

- `Hierarchy`: danh sách object trong scene.
- `Scene`: nơi dàn dựng thế giới game.
- `Game`: nơi xem game qua camera.
- `Inspector`: nơi xem và chỉnh thông số object hoặc asset đang chọn.
- `Project`: kho tài nguyên của dự án.
- `Console`: nơi đọc log, cảnh báo và lỗi.

## Ghi nhớ theo ví dụ đời thường

Bạn có thể hình dung như sau:

- `Project` là nhà kho chứa vật liệu.
- `Hierarchy` là danh sách món đồ đang được đặt trong căn phòng hiện tại.
- `Scene` là căn phòng bạn đang bước vào để kê đồ.
- `Inspector` là phiếu thông tin chi tiết của món đồ đang cầm trên tay.
- `Game` là ảnh chụp từ camera mà người chơi sẽ thấy.
- `Console` là bảng thông báo kỹ thuật.

Ví dụ đời thường giúp bạn nhớ lâu hơn việc học định nghĩa khô khan.

## Câu hỏi tự kiểm tra

### Câu 1

Bạn import một file ảnh vào project.

Ảnh đó đang ở đâu?

Gợi ý: chưa chắc đã ở trong scene.

### Câu 2

Bạn chọn `Player` trong `Hierarchy`.

Bạn muốn đổi vị trí của nó.

Bạn sẽ nhìn chủ yếu vào những cửa sổ nào?

### Câu 3

Bạn nhấn `Play` nhưng nhân vật không xuất hiện trong màn hình chơi.

Bạn nên kiểm tra camera ở cửa sổ nào và kết quả ở cửa sổ nào?

### Câu 4

Unity báo lỗi script màu đỏ.

Bạn mở cửa sổ nào trước tiên?

## Bài tập mini

### Bài tập 1: Làm quen với cửa sổ

Mở Unity.

Chỉ ra bằng mắt vị trí của:

- `Hierarchy`
- `Scene`
- `Game`
- `Inspector`
- `Project`
- `Console`

Sau đó tự nói to vai trò của từng cửa sổ.

### Bài tập 2: Tạo và đổi tên object

Tạo một object đơn giản trong scene.

Đổi tên nó thành một cái tên có nghĩa.

Ví dụ `Ground_Test`.

Chọn object đó trong `Hierarchy`.

Quan sát `Inspector`.

### Bài tập 3: So sánh Scene và Game

Đặt object ở một vị trí dễ thấy trong `Scene`.

Nhấn `Play`.

Quan sát `Game`.

Nếu không thấy object, hãy thử kiểm tra camera.

Mục tiêu không phải là sửa cho đúng ngay.

Mục tiêu là hiểu hai cửa sổ này không giống nhau.

### Bài tập 4: Tập đọc Console

Mở `Console`.

Quan sát xem project hiện có log, cảnh báo hay lỗi nào không.

Nếu chưa có, ghi nhớ vị trí cửa sổ này để dùng trong các bài code sau.

## Checklist sau bài học

Bạn nên chắc rằng mình làm được các việc sau:

- Biết chọn object trong `Hierarchy`.
- Biết xem thông tin object trong `Inspector`.
- Biết dùng `Scene` để quan sát thế giới game.
- Biết `Game` là góc nhìn người chơi.
- Biết `Project` là kho asset.
- Biết `Console` là nơi đọc lỗi.
- Biết `Play Mode` chỉ là chế độ chạy thử.

## Kết luận

Unity Editor có thể làm người mới choáng ngợp trong vài ngày đầu.

Nhưng nếu chia nó thành từng khu vực chức năng, bạn sẽ thấy nó khá logic.

Bạn không cần học mọi thứ cùng lúc.

Bạn chỉ cần luôn tự hỏi:

- Tôi đang chọn cái gì?
- Tôi đang sửa ở đâu?
- Tôi đang xem bằng góc nhìn thiết kế hay góc nhìn người chơi?
- Lỗi có đang được báo trong `Console` không?

Khi trả lời được các câu hỏi đó, bạn đã có nền móng tốt để học tiếp `GameObject`, `Component`, `Transform` và scripting.
