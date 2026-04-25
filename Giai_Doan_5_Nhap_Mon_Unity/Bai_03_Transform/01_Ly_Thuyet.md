# Bài 3: Transform

## Mục tiêu bài học

- Hiểu `Transform` là gì.
- Hiểu ba phần cốt lõi của `Transform`: `Position`, `Rotation`, `Scale`.
- Biết vì sao mọi `GameObject` đều có `Transform`.
- Phân biệt được tương đối giữa tọa độ local và world.
- Biết cách suy nghĩ khi di chuyển, xoay và co giãn object trong Unity.
- Tránh các lỗi rất phổ biến khi làm việc với `Transform`.

## Transform là gì?

`Transform` là component xác định object ở đâu, quay theo hướng nào và lớn nhỏ ra sao.

Đây là một trong những component nền tảng nhất trong Unity.

Mọi `GameObject` đều có `Transform`.

Nếu bài trước bạn đã hiểu `GameObject` và `Component`, thì ở bài này bạn học sâu về component xuất hiện trên gần như mọi object.

## Vì sao Transform quan trọng đến vậy?

Hãy tưởng tượng bạn có một nhân vật trong game.

Nếu không có vị trí, bạn không biết nhân vật đứng ở đâu.

Nếu không có góc xoay, bạn không biết nhân vật đang hướng về đâu.

Nếu không có kích thước, bạn không biết nhân vật to nhỏ thế nào.

Đó chính là lý do `Transform` tồn tại.

Gần như mọi thao tác thị giác đầu tiên trong Unity đều đụng đến `Transform`.

## Ba phần cốt lõi của Transform

`Transform` thường được hiểu qua ba nhóm giá trị:

- `Position`
- `Rotation`
- `Scale`

Bạn có thể xem đây là ba câu hỏi cơ bản về một object:

- Nó ở đâu?
- Nó quay thế nào?
- Nó lớn nhỏ ra sao?

## Position là gì?

`Position` là vị trí của object trong không gian.

Trong Unity, vị trí thường được mô tả bằng các trục tọa độ.

Với game 2D, bạn sẽ gặp chủ yếu trục `X` và `Y`.

Với game 3D, bạn dùng thêm trục `Z`.

### Hiểu đơn giản về các trục

Trong nhiều trường hợp cơ bản:

- `X`: trái và phải.
- `Y`: lên và xuống.
- `Z`: trước và sau.

Tùy ngữ cảnh 2D hay 3D mà cảm nhận về trục có thể khác nhau đôi chút trong cách bạn nhìn scene.

Nhưng ý chính là vị trí được mô tả bằng tọa độ trên các trục.

### Ví dụ về Position

Nếu một object có vị trí:

- `X = 0`
- `Y = 0`
- `Z = 0`

thì nó đang ở gần gốc tọa độ của thế giới.

Nếu bạn đổi `X` từ `0` sang `5`, object sẽ dịch sang một phía theo trục `X`.

Nếu bạn đổi `Y` từ `0` sang `3`, object sẽ đi lên theo trục `Y`.

## Rotation là gì?

`Rotation` là góc xoay của object.

Nó cho biết object đang quay theo hướng nào.

Trong Unity, bạn thường thấy góc xoay thể hiện qua các giá trị trên các trục.

Người mới chưa cần đi sâu vào toán học xoay.

Điều cần nhớ là:

`Rotation` ảnh hưởng đến hướng nhìn hoặc hướng đặt của object.

### Ví dụ về Rotation

Một mũi tên quay sang phải sẽ khác với mũi tên quay lên trên.

Một cánh cửa khi xoay sẽ mở theo hướng khác.

Một camera xoay sai góc có thể khiến `Game` không thấy object bạn muốn.

### Vì sao Rotation quan trọng?

Vì rất nhiều hành vi phụ thuộc vào hướng:

- Nhân vật nhìn trái hay phải.
- Camera hướng vào đâu.
- Đạn bắn theo hướng nào.
- Cửa mở xoay về phía nào.

## Scale là gì?

`Scale` là độ lớn nhỏ của object.

Nó thường được biểu diễn theo từng trục.

Ví dụ:

- `Scale = (1, 1, 1)` thường là kích thước chuẩn.
- `Scale = (2, 2, 2)` có thể làm object lớn gấp đôi.
- `Scale = (0.5, 0.5, 0.5)` có thể làm object nhỏ đi một nửa.

### Tại sao phải cẩn thận với Scale?

Vì scale không chỉ làm object to nhỏ về mặt nhìn thấy.

Nó còn có thể ảnh hưởng đến:

- Cảm giác bố cục trong scene.
- Va chạm trong một số trường hợp.
- Tính dễ đọc của game.
- Kết quả khi object là con của object khác.

Người mới hay phóng to thu nhỏ tùy tiện rồi sau đó thấy mọi thứ khó kiểm soát.

## Mọi GameObject đều có Transform

Đây là câu cần nhớ chắc.

Không có `Transform`, object không thể được đặt vào thế giới game một cách có ý nghĩa.

Khi tạo object mới, bạn gần như luôn thấy `Transform` trước tiên trong `Inspector`.

Điều này không phải ngẫu nhiên.

Nó phản ánh vai trò nền tảng của component này.

## Local và World là gì?

Đây là chỗ người mới thường nhầm.

Nói ngắn gọn:

- `World` là hệ quy chiếu của toàn bộ thế giới.
- `Local` là hệ quy chi chiếu tương đối so với object cha.

Nếu chưa quen, hãy đọc chậm phần này.

Đây là ý rất đáng học kỹ.

## Hiểu local position bằng ví dụ đời thường

Hãy tưởng tượng một chiếc bàn trong phòng.

Trên bàn có một chiếc cốc.

Nếu bạn nói vị trí chiếc cốc so với cả căn phòng, đó gần với ý `world`.

Nếu bạn nói vị trí chiếc cốc so với cái bàn, đó gần với ý `local`.

Trong Unity cũng vậy.

Nếu object là con của object khác, vị trí local của nó được tính theo object cha.

## Vì sao local position quan trọng?

Vì rất nhiều object được tổ chức theo cha con.

Ví dụ:

- Vũ khí là con của nhân vật.
- Camera là con của một rig hoặc một object theo dõi.
- UI con nằm bên trong UI cha.
- Bánh xe là con của xe.

Khi cha di chuyển, con thường đi theo.

Lúc này local position giúp bạn chỉnh vị trí con tương đối với cha.

## Ví dụ local và world dễ hiểu

Bạn có object `Player` ở vị trí world `(10, 0, 0)`.

Bạn có object `Weapon` là con của `Player`.

Nếu `Weapon` có local position `(1, 0, 0)`, điều đó nghĩa là vũ khí nằm lệch 1 đơn vị so với `Player`.

Nếu `Player` di chuyển sang vị trí khác, `Weapon` vẫn giữ khoảng lệch local đó.

Đây là hành vi rất hữu ích.

## Tại sao người mới hay nhầm local và world?

Vì khi scene đơn giản và chưa có quan hệ cha con, local và world có thể trông khá giống nhau.

Nhưng khi object làm con của object khác, sự khác biệt trở nên rõ rệt.

Nếu không hiểu điều này, bạn sẽ thắc mắc:

- Vì sao object con nhảy vị trí lạ?
- Vì sao chỉnh cha làm con di chuyển theo?
- Vì sao giá trị tọa độ không giống điều mình tưởng?

## Quan hệ cha con ảnh hưởng Transform như thế nào?

Khi một object là con của object khác:

- Vị trí của cha ảnh hưởng vị trí hiển thị cuối cùng của con.
- Xoay của cha ảnh hưởng hướng xoay của con.
- Scale của cha cũng có thể ảnh hưởng scale hiệu dụng của con.

Đây là lý do bạn phải cẩn thận khi tổ chức `Hierarchy`.

Không chỉ để gọn.

Nó còn tác động đến hành vi transform.

## Ví dụ thực tế về cha con

### Ví dụ 1: Camera theo người chơi

Nếu camera là con của người chơi, khi người chơi di chuyển, camera có thể đi theo.

Điều này tiện trong một số trường hợp.

Nhưng nếu không hiểu local position, bạn có thể đặt camera lệch sai.

### Ví dụ 2: Tay cầm kiếm

Thanh kiếm là con của nhân vật.

Bạn thường không muốn nhập world position mỗi lần nhân vật di chuyển.

Bạn chỉ muốn kiếm luôn ở vị trí tương đối phù hợp với tay.

Lúc này local position rất hữu ích.

### Ví dụ 3: UI nhóm theo panel

Nút bấm là con của panel.

Khi panel di chuyển, các nút đi theo.

Đây là lợi ích rõ ràng của quan hệ cha con.

## Dùng Transform trong Scene View

Bạn không chỉ chỉnh `Transform` bằng số trong `Inspector`.

Bạn còn có thể dùng công cụ trực quan trong `Scene` để:

- Kéo object di chuyển.
- Xoay object bằng tay cầm xoay.
- Co giãn object bằng tay cầm scale.

Người mới nên tập phối hợp hai cách:

- Dùng `Scene` để thao tác nhanh bằng mắt.
- Dùng `Inspector` để nhập giá trị chính xác.

## Khi nào nên chỉnh bằng kéo thả, khi nào nên nhập số?

### Nên kéo thả trong Scene khi:

- Bạn đang căn bố cục bằng mắt.
- Bạn muốn đặt object nhanh.
- Bạn muốn thử vài vị trí khác nhau.

### Nên nhập số trong Inspector khi:

- Cần độ chính xác cao.
- Muốn hai object có cùng giá trị rõ ràng.
- Muốn đặt về đúng gốc hoặc một tọa độ cụ thể.

## Workflow suy nghĩ khi đặt object vào scene

Giả sử bạn thêm một thùng gỗ vào màn chơi.

Bạn nên nghĩ như sau:

1. Object này nên xuất hiện ở đâu?
2. Nó có cần xoay hướng nào không?
3. Kích thước hiện tại có phù hợp không?
4. Nó có là con của object nào không?
5. Nếu là con, tôi đang chỉnh local hay đang nghĩ theo world?

Đây là kiểu suy nghĩ giúp bạn tránh sửa mò.

## Sai lầm phổ biến với Position

### 1. Nhầm trục

Bạn muốn object đi lên nhưng lại sửa `Z` thay vì `Y` trong ngữ cảnh đang làm.

Kết quả là object đi theo hướng không mong muốn.

### 2. Không để ý object đang là con

Bạn nghĩ mình đang đặt object ở vị trí tuyệt đối, nhưng thực ra local position của nó đang phụ thuộc object cha.

### 3. Kéo object trong Scene rồi vô tình lệch nhiều hơn dự định

Đây là lý do đôi khi nên nhập số trực tiếp trong `Inspector`.

## Sai lầm phổ biến với Rotation

### 1. Xoay sai trục

Bạn muốn quay vật thể sang trái phải nhưng lại xoay theo trục khác.

### 2. Không hiểu camera đang nhìn từ đâu

Điều này làm bạn tưởng object xoay đúng nhưng thực ra chỉ đúng ở góc nhìn hiện tại.

### 3. Xoay object con mà quên cha cũng đang xoay

Kết quả cuối cùng có thể khác hẳn kỳ vọng.

## Sai lầm phổ biến với Scale

### 1. Scale quá lớn hoặc quá nhỏ

Khiến tỉ lệ toàn scene mất cân đối.

### 2. Scale không đồng đều ngoài ý muốn

Ví dụ chỉ tăng `X` mà quên `Y`, làm object méo.

### 3. Scale cha rồi quên rằng con bị ảnh hưởng

Đây là lỗi thường gặp khi object có cấu trúc cha con.

## Vì sao nên cẩn thận với scale âm?

Trong một số tình huống, người mới dùng scale âm để lật object.

Điều này có thể hữu ích trong vài trường hợp 2D.

Tuy nhiên nó cũng có thể gây khó hiểu về hướng, collider hoặc các hệ quả khác tùy hệ thống.

Nếu chưa chắc, hãy dùng cách đơn giản và nhất quán trong project.

## Transform và gameplay liên quan thế nào?

Rất nhiều hành vi gameplay xoay quanh `Transform`.

Ví dụ:

- Di chuyển nhân vật là thay đổi vị trí.
- Quay súng theo chuột là thay đổi rotation.
- Phóng to vật phẩm khi nhặt là thay đổi scale.
- Tạo object ở điểm sinh là dùng vị trí của transform khác.

Nếu hiểu `Transform`, bạn sẽ học script dễ hơn.

## Ví dụ workflow 1: Đặt nhân vật lên mặt đất

Bạn kéo `Player` vào scene.

Nhân vật đang lơ lửng hoặc chìm dưới đất.

Luồng suy nghĩ nên là:

1. Chọn `Player` trong `Hierarchy`.
2. Nhìn `Transform` trong `Inspector`.
3. Dùng `Scene` để kéo vị trí hoặc nhập lại giá trị `Position`.
4. Kiểm tra trục nào đang biểu diễn chiều cao trong ngữ cảnh của bạn.
5. Nhấn `Play` để xem kết quả trong `Game`.

Đây là ví dụ cực thực tế của `Transform` trong công việc hàng ngày.

## Ví dụ workflow 2: Gắn vũ khí vào tay nhân vật

Bạn làm `Weapon` thành con của `Player` hoặc con của object tay.

Sau đó bạn chỉnh local position của `Weapon` để nó nằm đúng nơi mong muốn.

Bạn có thể cần:

- Chỉnh local position.
- Chỉnh local rotation.
- Chỉnh local scale nếu model chưa vừa.

Nếu không hiểu local transform, bài toán này rất dễ gây bối rối.

## Ví dụ workflow 3: Camera không thấy object

Object vẫn có trong scene.

Nhưng `Game` không hiển thị đúng.

Một phần nguyên nhân có thể là `Transform` của camera hoặc object chưa hợp lý.

Bạn cần kiểm tra:

- Vị trí camera.
- Hướng xoay camera.
- Vị trí object.
- Khoảng cách giữa camera và object.

Đây là lúc `Transform` không còn là lý thuyết khô khan nữa.

Nó ảnh hưởng trực tiếp đến việc bạn có nhìn thấy game đúng hay không.

## Transform và script

Trong lập trình Unity, bạn sẽ truy cập `transform` rất thường xuyên.

Lý do là nhiều hành vi cơ bản đều thao tác trên nó.

Ví dụ ý tưởng bằng lời:

- Tăng `position` để object di chuyển.
- Đổi `rotation` để object quay.
- Sửa `scale` để object lớn lên hoặc nhỏ đi.

Ngay cả trước khi viết code, hiểu ý nghĩa của các giá trị này đã rất quan trọng.

## Cách học Transform không bị rối

Hãy học theo thứ tự sau:

1. Học `Position` trước.
2. Sau đó học `Rotation`.
3. Cuối cùng học `Scale`.
4. Khi đã quen, mới ghép thêm local và world.
5. Sau đó mới kết hợp với cha con phức tạp hơn.

Nếu nhảy vào tất cả cùng lúc, người mới thường bị quá tải.

## Dấu hiệu cho thấy bạn đã hiểu khá tốt

Bạn có thể trả lời được:

- Vì sao object đang ở vị trí này?
- Vì sao nó quay theo hướng đó?
- Vì sao nó to nhỏ bất thường?
- Nó là con của ai?
- Giá trị đang thấy là local hay đang nghĩ theo world?

Nếu bạn trả lời được phần lớn, nghĩa là nền tảng đã tốt.

## Tóm tắt ngắn gọn nhưng quan trọng

- `Transform` lưu vị trí, xoay và tỉ lệ của object.
- Mọi `GameObject` đều có `Transform`.
- `Position` trả lời object ở đâu.
- `Rotation` trả lời object quay thế nào.
- `Scale` trả lời object lớn nhỏ ra sao.
- Quan hệ cha con làm local transform trở nên quan trọng.
- Nhiều lỗi của người mới đến từ nhầm local và world.

## Câu hỏi tự kiểm tra

1. `Transform` dùng để làm gì?
2. Ba phần quan trọng nhất của `Transform` là gì?
3. `Position` khác `Rotation` ra sao?
4. `Scale` ảnh hưởng điều gì?
5. Vì sao mọi object đều có `Transform`?
6. `Local position` là vị trí so với cái gì?
7. Vì sao object con thay đổi khi object cha di chuyển?

## Tự kiểm tra bằng tình huống

### Tình huống 1

Bạn có một thanh kiếm là con của nhân vật.

Bạn muốn kiếm luôn nằm bên phải tay nhân vật.

Bạn nên nghĩ nhiều đến local position hay world position?

Gợi ý: local position thường phù hợp hơn.

### Tình huống 2

Bạn muốn một object to gấp đôi nhưng vẫn giữ nguyên vị trí.

Bạn nên thay đổi phần nào của `Transform`?

Gợi ý: `Scale`.

### Tình huống 3

Bạn thấy object xuất hiện sai hướng.

Bạn nên kiểm tra phần nào của `Transform`?

Gợi ý: `Rotation`.

### Tình huống 4

Object hiển thị ở nơi rất lạ sau khi bạn kéo nó thành con của object khác.

Bạn nên nghĩ đến khái niệm nào?

Gợi ý: local và world.

## Bài tập mini

### Bài tập 1: Quan sát Transform

Chọn vài object khác nhau trong scene.

Quan sát `Transform` của từng object.

Ghi nhận:

- Vị trí có khác nhau không?
- Xoay có khác nhau không?
- Scale có khác nhau không?

### Bài tập 2: Thử thay đổi Position

Chọn một object đơn giản.

Đổi một giá trị vị trí nhỏ.

Quan sát object di chuyển theo hướng nào.

Mục tiêu là kết nối số liệu với chuyển động thật trong `Scene`.

### Bài tập 3: Thử thay đổi Rotation

Chọn object dễ nhìn hướng.

Đổi một giá trị xoay.

Quan sát sự khác nhau trước và sau.

### Bài tập 4: Thử thay đổi Scale

Chọn object.

Tăng scale đồng đều.

Sau đó thử tăng riêng một trục.

Quan sát khi nào object bị méo.

### Bài tập 5: Thử cha con

Tạo hai object.

Cho một object làm con của object còn lại.

Di chuyển object cha.

Quan sát object con.

Sau đó thử chỉnh vị trí local của object con.

Bài tập này rất đáng làm vì nó giúp bạn cảm nhận local transform bằng mắt.

## Checklist sau bài học

- Tôi hiểu `Transform` là component nền tảng.
- Tôi hiểu `Position`, `Rotation`, `Scale` là ba phần chính.
- Tôi biết mọi object đều có `Transform`.
- Tôi biết local và world không giống nhau.
- Tôi biết cha con ảnh hưởng đến transform.
- Tôi biết nên kiểm tra `Transform` khi object xuất hiện sai vị trí hoặc sai hướng.

## Kết luận

`Transform` là một trong những khái niệm nhỏ nhưng đi cùng bạn suốt quá trình học Unity.

Lúc mới học, nó chỉ là vài ô số trong `Inspector`.

Nhưng càng làm game, bạn càng thấy gần như mọi thứ đều liên quan đến vị trí, hướng và kích thước.

Nếu nắm chắc `Transform`, bạn sẽ dễ học hơn rất nhiều ở các phần sau như di chuyển, camera, vật lý, animation và lập trình điều khiển object.

Hãy nhớ câu chốt của bài:

Muốn điều khiển object tốt, trước hết phải hiểu `Transform` của nó.
