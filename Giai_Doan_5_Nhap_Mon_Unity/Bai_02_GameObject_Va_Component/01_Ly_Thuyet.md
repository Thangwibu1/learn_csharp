# Bài 2: GameObject và Component

## Mục tiêu bài học

- Hiểu `GameObject` là gì.
- Hiểu `Component` là gì.
- Biết vì sao Unity dùng cách ghép thành phần thay vì nhồi mọi thứ vào một lớp lớn.
- Nhận ra script của bạn cũng là một `Component`.
- Biết cách suy nghĩ khi tạo một object mới trong Unity.
- Tránh các hiểu lầm rất phổ biến của người mới.

## Ý tưởng cốt lõi của bài

Nếu chỉ nhớ một điều trong bài này, hãy nhớ câu sau:

Trong Unity, `GameObject` là vật chứa.

`Component` là các mảnh chức năng gắn lên vật chứa đó.

Hiểu được ý này, bạn sẽ bớt mơ hồ khi nhìn vào `Inspector`.

Bạn cũng sẽ hiểu vì sao một object có thể di chuyển, hiển thị hình ảnh, va chạm và phát âm thanh cùng lúc.

## GameObject là gì?

`GameObject` là đơn vị cơ bản để tạo nên mọi thứ trong scene.

Bạn có thể coi nó là một thực thể tồn tại trong thế giới game.

Nhưng bản thân `GameObject` không tự động có đầy đủ chức năng.

Nó giống như một cái khung.

Cái khung đó sẽ trở nên hữu ích khi bạn gắn thêm các `Component`.

### Ví dụ về GameObject trong game

Một `GameObject` có thể đại diện cho:

- Nhân vật người chơi.
- Kẻ địch.
- Viên đạn.
- Nền đất.
- Camera.
- Nút bấm UI.
- Cột đèn.
- Cánh cửa.

Điểm chung là tất cả đều là đối tượng trong scene.

## Component là gì?

`Component` là các thành phần chức năng gắn lên `GameObject`.

Mỗi component giải quyết một vai trò cụ thể.

Ví dụ:

- `Transform` lưu vị trí, xoay, tỉ lệ.
- `SpriteRenderer` hiển thị hình ảnh 2D.
- `MeshRenderer` hiển thị hình 3D.
- `Rigidbody` thêm vật lý.
- `Collider` thêm vùng va chạm.
- `AudioSource` phát âm thanh.
- Script C# của bạn điều khiển hành vi riêng.

Khi ghép nhiều component, một object trở nên hoàn chỉnh hơn.

## Hình dung đơn giản nhất

Hãy tưởng tượng `GameObject` là một chiếc điện thoại mới xuất xưởng nhưng chưa cài ứng dụng.

`Component` giống như các ứng dụng và tính năng mà bạn cài vào.

Không có ứng dụng, chiếc điện thoại vẫn tồn tại nhưng rất ít khả năng.

Không có component, `GameObject` cũng vậy.

Nó tồn tại, nhưng hành vi của nó rất hạn chế.

## Vì sao Unity chọn cách ghép thành phần?

Unity đi theo hướng `composition`, tức là ghép từ các thành phần nhỏ.

Điều này quan trọng vì game có rất nhiều loại object khác nhau.

Nếu mọi chức năng đều dồn vào một kiểu object duy nhất, dự án sẽ cứng nhắc và khó mở rộng.

Ghép component giúp bạn linh hoạt hơn.

Ví dụ:

- Muốn object có hình ảnh, thêm renderer.
- Muốn object có vật lý, thêm rigidbody.
- Muốn object phát nhạc, thêm audio.
- Muốn object chạy logic riêng, thêm script.

Bạn chỉ dùng những gì cần.

## Lợi ích của composition với người mới

Ngay cả khi chưa học sâu về kiến trúc phần mềm, bạn vẫn hưởng lợi từ cách này.

Vì:

- Dễ đọc hơn trong `Inspector`.
- Dễ thêm bớt chức năng.
- Dễ thử nghiệm nhanh.
- Dễ tách lỗi hơn.
- Dễ tái sử dụng ý tưởng trên object khác.

Bạn có thể nhìn vào một object và hiểu nó có gì bằng cách xem danh sách component.

## Mọi GameObject đều có Transform

Một điểm rất quan trọng là mọi `GameObject` đều có `Transform`.

Đây là component mặc định và thiết yếu.

Lý do đơn giản là object cần có vị trí trong không gian.

Nếu không có `Transform`, Unity không biết object ở đâu, quay hướng nào và lớn nhỏ ra sao.

Trong bài sau bạn sẽ học kỹ hơn về `Transform`.

Ở bài này chỉ cần nhớ:

`Transform` là component nền tảng nhất.

## Một object trông như thế nào trong Inspector?

Khi bạn chọn một object, `Inspector` thường hiện:

- Tên object.
- Trạng thái bật tắt.
- Tag và Layer.
- `Transform`.
- Các component khác gắn trên object.

Mỗi component là một khối riêng.

Điều này giúp bạn nhìn rõ object được ghép từ những phần nào.

Đó chính là tư duy component trong thực tế.

## Ví dụ 1: Một viên gạch tĩnh trong game 2D

Bạn muốn tạo một viên gạch đứng yên.

Bạn có thể cần:

- `GameObject` làm thực thể.
- `Transform` để xác định vị trí.
- `SpriteRenderer` để hiển thị hình viên gạch.
- `BoxCollider2D` để nhân vật va vào nó.

Bạn có thể chưa cần:

- `Rigidbody2D`, nếu viên gạch không cần phản ứng vật lý động.
- `AudioSource`, nếu nó không phát âm thanh.
- Script riêng, nếu nó chỉ là nền tĩnh.

Qua ví dụ này, bạn thấy object không phải lúc nào cũng cần thật nhiều component.

Cần gì thì gắn đó.

## Ví dụ 2: Một nhân vật người chơi đơn giản

Một `Player` cơ bản có thể cần:

- `Transform`.
- `SpriteRenderer`.
- `Rigidbody2D`.
- `Collider2D`.
- Script điều khiển di chuyển.

Nếu có animation, bạn có thể thêm:

- `Animator`.

Nếu có âm thanh bước chân, có thể thêm:

- `AudioSource`.

Như vậy, cùng là `GameObject`, nhưng chức năng phụ thuộc vào tập hợp component.

## Ví dụ 3: Camera chính

`Main Camera` cũng là một `GameObject`.

Nhiều người mới quên điều này.

Nó có thể có:

- `Transform`.
- `Camera` component.
- Có thể thêm script bám theo người chơi.

Điều này cho thấy không chỉ nhân vật hay vật thể mới là `GameObject`.

Camera cũng là object trong scene.

## Script của bạn cũng là Component

Đây là một ý rất quan trọng.

Khi bạn viết một script kế thừa từ `MonoBehaviour` và gắn nó lên object, script đó trở thành một component.

Nói cách khác, script không đứng ngoài hệ thống component.

Nó là một phần của hệ thống đó.

### Điều này có ích gì?

Nó giúp bạn hiểu vì sao script xuất hiện trong `Inspector`.

Nó cũng giải thích vì sao bạn có thể:

- Gắn script lên object.
- Gỡ script khỏi object.
- Chỉnh biến public hoặc serialize field trong `Inspector`.
- Dùng script này cho nhiều object khác nhau.

## Tư duy tạo object đúng cho người mới

Khi muốn tạo một object, đừng hỏi ngay:

"Tôi cần viết code gì?"

Hãy hỏi theo thứ tự này:

1. Object này là cái gì trong game?
2. Nó cần xuất hiện như thế nào?
3. Nó cần va chạm không?
4. Nó cần phản ứng vật lý không?
5. Nó cần phát âm thanh không?
6. Nó cần logic riêng không?

Từ đó bạn mới quyết định component cần gắn.

Đây là cách nghĩ đúng với Unity.

## Phân biệt object và chức năng

Người mới thường gom hai ý này làm một.

Ví dụ họ nghĩ:

"Player là thứ có thể chạy và nhảy."

Thực ra nên tách ra:

- `Player` là object.
- Chạy và nhảy là hành vi.
- Hành vi thường nằm trong component hoặc script.

Khi tách được như vậy, bạn sẽ thiết kế hệ thống rõ ràng hơn.

## Component không chỉ để hiển thị

Nhiều bạn mới chỉ nhìn thấy `SpriteRenderer` nên nghĩ component chủ yếu để hiện hình.

Thực ra component có nhiều vai trò:

- Hiển thị.
- Vật lý.
- Va chạm.
- Âm thanh.
- Điều hướng.
- Animation.
- Điều khiển bằng script.
- Tổ chức UI.

Một object mạnh là nhờ tổ hợp component chứ không phải chỉ nhờ hình ảnh.

## Ví dụ phân tích từng trường hợp thực tế

### Trường hợp 1: Cây trang trí

Nếu cây chỉ đứng yên để trang trí, object có thể chỉ cần:

- `Transform`
- `SpriteRenderer` hoặc `MeshRenderer`

Nếu người chơi không va vào cây, có thể chưa cần collider.

### Trường hợp 2: Cửa có thể mở

Cửa có thể cần:

- `Transform`
- Renderer
- Collider
- Script mở cửa
- Có thể thêm âm thanh

### Trường hợp 3: Đạn bay

Đạn có thể cần:

- `Transform`
- Renderer
- Rigidbody
- Collider
- Script điều khiển bay và hủy khi chạm

Nhìn vào ba trường hợp này, bạn thấy mỗi object được lắp theo nhu cầu.

## Thành phần ít chưa chắc là yếu

Một object tốt không phải object có thật nhiều component.

Một object tốt là object có đúng component cần thiết.

Thêm quá nhiều component không dùng tới sẽ làm khó quản lý và dễ gây nhầm lẫn.

Người mới đôi khi thấy object thiếu tính năng nên gắn bừa nhiều thứ.

Đó không phải thói quen tốt.

## Dấu hiệu cho thấy bạn đã hiểu component

Bạn bắt đầu hiểu bài khi có thể nhìn một object và nói:

- Nó là object gì.
- Nó có những chức năng nào.
- Chức năng nào đến từ component nào.
- Chức năng nào chưa có nên cần thêm component hoặc script.

Nếu bạn chưa làm được, không sao.

Đó là kỹ năng sẽ tăng lên sau vài buổi thực hành.

## Quy trình suy nghĩ khi object không hoạt động như mong đợi

Giả sử bạn có object `Player`, nhưng bấm chạy thì nhân vật không di chuyển.

Đừng chỉ chăm chăm vào code.

Hãy kiểm tra theo logic component:

1. Đúng object đã được gắn script chưa?
2. Script có hiện trong `Inspector` không?
3. Có component cần thiết nào còn thiếu không?
4. Có rigidbody hoặc collider cần cho hành vi đó không?
5. `Console` có báo lỗi không?

Đây là cách suy nghĩ rất Unity.

## Mối quan hệ giữa GameObject và Prefab

Ở giai đoạn đầu, bạn chỉ cần hiểu rất đơn giản:

Prefab là mẫu object được lưu lại để tái sử dụng.

Nó vẫn dựa trên ý tưởng `GameObject` cộng với các `Component` của nó.

Nói cách khác, khi học tốt `GameObject` và `Component`, bạn sẽ dễ học `Prefab` hơn rất nhiều.

## Vì sao người mới hay thấy rối khi nhìn Inspector?

Vì họ nhìn component như một danh sách dài lộn xộn.

Thực ra hãy đổi góc nhìn.

Mỗi khối trong `Inspector` đang trả lời một câu hỏi.

Ví dụ:

- `Transform`: object ở đâu?
- Renderer: object trông thế nào?
- Collider: object va chạm ra sao?
- Rigidbody: object chịu vật lý như thế nào?
- Script: object có logic riêng gì?

Khi nhìn theo câu hỏi, `Inspector` sẽ dễ hiểu hơn nhiều.

## Những hiểu lầm rất phổ biến

### 1. Nghĩ rằng GameObject tự có mọi chức năng

Không đúng.

`GameObject` là nền để gắn chức năng.

Chức năng đến từ component.

### 2. Nghĩ script là thứ đặc biệt tách khỏi component

Không đúng.

Script `MonoBehaviour` của bạn cũng là component.

### 3. Nghĩ càng nhiều component càng tốt

Không đúng.

Nên gắn vừa đủ và có mục đích rõ ràng.

### 4. Không hiểu object nào mới đang được chỉnh

Bạn có thể đang nhìn component của object khác nếu chọn nhầm trong `Hierarchy`.

### 5. Nhìn thấy hình ảnh nên tưởng object đã có va chạm

Không đúng.

Hiển thị và va chạm là hai chuyện khác nhau.

Muốn có va chạm, thường cần collider thích hợp.

## Cách học bài này hiệu quả

Thay vì cố đọc nhiều định nghĩa, hãy thực hiện một số thao tác nhỏ:

1. Tạo một object trống.
2. Quan sát nó chỉ có những gì.
3. Thêm một renderer.
4. Quan sát object thay đổi như thế nào.
5. Thêm một collider.
6. Tự hỏi object vừa có thêm khả năng gì.
7. Gắn một script đơn giản.
8. Quan sát script xuất hiện như một component trong `Inspector`.

Bạn sẽ hiểu nhanh hơn rất nhiều khi học bằng mắt.

## Ví dụ workflow Unity cho bài này

Giả sử bạn muốn tạo một đồng xu trong game 2D.

Quy trình suy nghĩ có thể là:

1. Đồng xu là một `GameObject`.
2. Nó cần hiện hình nên cần `SpriteRenderer`.
3. Nó cần phát hiện người chơi chạm vào nên cần `Collider2D`.
4. Nó cần logic cộng điểm và tự biến mất nên cần script riêng.
5. Có thể cần âm thanh khi nhặt nên thêm `AudioSource` hoặc phát âm thanh bằng hệ thống khác.

Bạn thấy không?

Đây là cách thiết kế bằng component.

Không phải bắt đầu bằng một lớp `Coin` chứa mọi thứ trong đầu một cách mơ hồ.

## Ví dụ khác: Nền trời phía sau

Nền trời thường không cần va chạm.

Không cần rigidbody.

Có thể chỉ cần:

- `GameObject`
- `Transform`
- Renderer

Nếu hiểu bài, bạn sẽ không gắn thừa component cho object kiểu này.

## Khi nào nên tạo object rỗng?

Object rỗng vẫn hữu ích.

Nó có thể dùng để:

- Làm điểm mốc vị trí.
- Làm cha để gom nhóm object khác.
- Chứa script điều khiển logic chung.
- Làm spawn point.

Điều này cho thấy một `GameObject` không nhất thiết phải luôn có hình ảnh.

Nó vẫn có giá trị nếu đóng vai trò tổ chức hoặc logic.

## Tự kiểm tra bằng cách mô tả object

Hãy thử mô tả các object sau theo mẫu:

"Đây là một `GameObject` tên là ... Nó cần các component ... vì ..."

Các object để bạn thử:

- Người chơi.
- Kẻ địch đi tuần.
- Cửa thoát màn.
- Viên đạn.
- Đồng xu.
- Nút bấm bắt đầu game.

Nếu bạn mô tả được, nghĩa là bạn đang hiểu `GameObject` và `Component` theo cách thực hành.

## Tóm tắt rất quan trọng

- `GameObject` là thực thể cơ bản trong scene.
- `Component` là mảnh chức năng gắn lên thực thể đó.
- Mọi `GameObject` đều có `Transform`.
- Script của bạn cũng là một `Component` nếu gắn lên object.
- Unity dùng composition để linh hoạt hơn.
- Muốn hiểu một object, hãy xem các component của nó.

## Câu hỏi tự kiểm tra

1. `GameObject` là gì?
2. `Component` là gì?
3. Vì sao `Transform` gần như luôn xuất hiện trên object?
4. Script của bạn có phải component không?
5. Muốn object hiện hình, thường cần component nào?
6. Muốn object có vùng va chạm, thường cần gì?
7. Một object trang trí đứng yên có nhất thiết cần rigidbody không?

## Tự trả lời theo tình huống

### Tình huống 1

Bạn có một object chỉ để làm điểm sinh quái.

Nó có cần renderer không?

Chưa chắc.

Nó có thể chỉ cần `Transform` và có thể là script spawn.

### Tình huống 2

Bạn thấy object có ảnh hiển thị bình thường.

Bạn có thể kết luận nó va chạm được chưa?

Chưa.

Bạn cần xem có collider phù hợp hay không.

### Tình huống 3

Bạn đã viết script điều khiển cửa nhưng cửa không phản ứng.

Một bước kiểm tra đầu tiên là gì?

Kiểm tra script đã được gắn như component lên đúng object chưa.

## Bài tập mini

### Bài tập 1: Quan sát object mặc định

Tạo một object trống.

Chọn nó trong `Hierarchy`.

Quan sát `Inspector`.

Viết ra xem object đó có component nào.

### Bài tập 2: Thêm chức năng từng bước

Thêm lần lượt các component đơn giản phù hợp với loại project bạn đang học.

Sau mỗi lần thêm, tự trả lời:

- Component này thêm khả năng gì?
- Nếu bỏ nó đi, object mất khả năng gì?

### Bài tập 3: Phân tích một object có sẵn

Chọn `Main Camera` hoặc một object có sẵn trong scene.

Liệt kê các component đang có.

Thử giải thích vai trò của từng component.

### Bài tập 4: Thiết kế trên giấy

Không cần mở Unity.

Hãy viết ra 3 object trong game bạn muốn làm.

Mỗi object liệt kê các component có thể cần.

Mục tiêu của bài tập là tập suy nghĩ theo thành phần.

## Checklist sau bài học

- Tôi hiểu `GameObject` là thực thể cơ bản trong scene.
- Tôi hiểu `Component` là nơi chứa chức năng.
- Tôi biết script của mình cũng là component.
- Tôi biết object khác nhau chủ yếu ở tổ hợp component khác nhau.
- Tôi biết không nên gắn component bừa bãi.
- Tôi có thể nhìn `Inspector` và giải thích tương đối object đang có gì.

## Kết luận

Nếu bài trước giúp bạn hiểu giao diện Unity, thì bài này giúp bạn hiểu cách Unity xây đối tượng.

Đây là một trong những ý quan trọng nhất khi học Unity.

Sau này khi học `Transform`, `Physics`, `Prefab`, `Animation`, hay scripting, bạn sẽ luôn quay lại tư duy này:

Object là gì?

Nó cần chức năng nào?

Chức năng đó nên đến từ component nào?

Khi tư duy được như vậy, bạn sẽ học Unity có hệ thống hơn và bớt làm theo kiểu đoán mò.
