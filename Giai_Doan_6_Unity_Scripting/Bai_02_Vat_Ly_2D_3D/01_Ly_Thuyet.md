# Bài 2: Vật Lý 2D và 3D

## Mục tiêu

- Hiểu vật lý trong Unity dùng để làm gì.
- Phân biệt rõ hệ vật lý 2D và hệ vật lý 3D.
- Biết vai trò của `Rigidbody`, `Rigidbody2D`, `Collider`, `Collider2D`, `Trigger`.
- Hiểu khi nào nên để Unity xử lý bằng vật lý, khi nào nên điều khiển bằng code trực tiếp.
- Tránh các lỗi cơ bản làm object không va chạm, không rơi, hoặc hành vi bất ổn.
- Có tư duy thiết kế gameplay phù hợp với 2D và 3D ngay từ đầu.

## Bức tranh tổng quan

Rất nhiều trò chơi cần mô phỏng sự tương tác giữa các vật thể.

Ví dụ:

- nhân vật rơi xuống đất
- đạn bay và chạm mục tiêu
- hộp bị đẩy đi khi có lực tác động
- xe va vào tường
- quả bóng nảy lên

Đó là lúc hệ vật lý phát huy tác dụng.

Trong Unity, vật lý không chỉ là “để vật rơi”.

Nó còn là cách engine giúp bạn giải quyết các bài toán:

- va chạm
- chồng lấn
- lực
- trọng lực
- phát hiện tiếp xúc
- phản ứng khi chạm nhau

Nếu dùng đúng, vật lý giúp bạn làm game nhanh hơn và ổn định hơn.

Nếu dùng sai, game sẽ có cảm giác kỳ lạ, khó debug, và dễ phát sinh bug khó hiểu.

## Khái niệm

Vật lý trong Unity là hệ thống mô phỏng hành vi chuyển động và va chạm giữa các đối tượng.

Unity có hai hệ vật lý riêng:

- vật lý 2D
- vật lý 3D

Điều quan trọng cần nhớ ngay từ đầu:

Hai hệ này tách biệt.

Điều đó có nghĩa là:

- `Rigidbody2D` làm việc với `Collider2D`
- `Rigidbody` làm việc với `Collider`
- callback 2D và 3D cũng khác nhau

Bạn không nên trộn linh tinh.

## Tại sao phải dùng cái này?

Nếu bạn làm game mà có tương tác không gian, gần như chắc chắn bạn sẽ cần hiểu vật lý.

### Lợi ích chính

- Tạo cảm giác chuyển động tự nhiên hơn.
- Giảm số lượng code tự xử lý va chạm bằng tay.
- Dễ phát hiện chạm, đè, rơi, bật nảy.
- Hỗ trợ gameplay như nhảy, đạn, kẻ địch, bẫy, xe cộ.
- Giúp hệ thống hoạt động thống nhất hơn trên toàn dự án.

### Nếu không hiểu vật lý, bạn thường sẽ gặp gì?

- Object đi xuyên tường.
- Đạn bắn ra không trúng gì.
- Nhân vật đứng trên đất nhưng vẫn rung.
- Va chạm lúc có lúc không.
- Code di chuyển và hệ vật lý đánh nhau với nhau.

## Liên hệ game thực tế

### Game platformer 2D

Bạn cần:

- nhân vật rơi bởi trọng lực
- chạm đất để nhảy lại
- đạn va vào kẻ địch
- vật phẩm nhặt được khi chạm vào

Đây là bối cảnh điển hình cho `Rigidbody2D` và `Collider2D`.

### Game bắn súng góc nhìn thứ nhất 3D

Bạn cần:

- nhân vật đi trong không gian 3 chiều
- đạn va vào môi trường
- thùng hàng bị đẩy bật ra
- lựu đạn nổ gây lực lên vật thể gần đó

Đây là bối cảnh phù hợp cho hệ 3D.

### Game puzzle

Bạn cần:

- kéo hộp
- kích hoạt nút bấm khi vật đè lên
- cửa mở khi vật đủ trọng lượng

Lúc này, vật lý không chỉ là hiệu ứng, mà còn là phần lõi của gameplay.

## Phân biệt vật lý 2D và 3D

### Vật lý 2D

Dùng khi game hoạt động trên mặt phẳng 2 chiều.

Ví dụ:

- platformer
- top-down 2D
- bắn máy bay 2D
- puzzle 2D

Component thường gặp:

- `Rigidbody2D`
- `BoxCollider2D`
- `CircleCollider2D`
- `CapsuleCollider2D`
- `PolygonCollider2D`

Callback thường gặp:

- `OnCollisionEnter2D`
- `OnTriggerEnter2D`

### Vật lý 3D

Dùng khi game hoạt động trong không gian 3 chiều.

Ví dụ:

- FPS
- TPS
- game xe 3D
- game phiêu lưu 3D

Component thường gặp:

- `Rigidbody`
- `BoxCollider`
- `SphereCollider`
- `CapsuleCollider`
- `MeshCollider`

Callback thường gặp:

- `OnCollisionEnter`
- `OnTriggerEnter`

### Quy tắc cực kỳ quan trọng

Không trộn lẫn 2D và 3D.

Ví dụ sai:

- object có `Rigidbody2D` nhưng lại gắn `BoxCollider`
- viết `OnCollisionEnter` cho object dùng hệ 2D

Khi sai kiểu như vậy, bạn sẽ thấy game “không có chuyện gì xảy ra”, dù nhìn ngoài tưởng đúng.

## Thành phần cơ bản của hệ vật lý

### 1. Rigidbody hoặc Rigidbody2D

Đây là component cho object tham gia mô phỏng vật lý động.

Nó giúp object có thể:

- chịu trọng lực
- nhận lực
- bị đẩy
- va chạm động
- có vận tốc

Nếu chỉ có collider mà không có rigidbody, object thường đóng vai trò tĩnh hơn trong hệ vật lý.

Người mới nên nhớ thế này:

- Collider nói “hình dạng va chạm của tôi là gì”.
- Rigidbody nói “tôi có tham gia chuyển động vật lý hay không”.

### 2. Collider hoặc Collider2D

Collider xác định vùng hình học dùng để va chạm hoặc trigger.

Ví dụ:

- nhân vật có vùng va chạm thân người
- đạn có vùng va chạm đầu đạn
- coin có vùng trigger để nhặt
- mặt đất có vùng để đứng lên

Không có collider thì Unity không biết dùng hình gì để kiểm tra tiếp xúc.

### 3. Trigger

Collider có thể được đặt thành `Is Trigger`.

Khi đó:

- object không tạo phản ứng va chạm vật lý kiểu chặn đường
- nhưng vẫn có thể phát hiện chồng lấn

Trigger rất phù hợp cho:

- vùng nhặt item
- vùng checkpoint
- vùng phát thoại
- vùng báo động AI
- cổng chuyển scene

### 4. Physics Material hoặc Physics Material 2D

Vật liệu vật lý giúp điều chỉnh cảm giác tiếp xúc.

Ví dụ:

- trơn
- bám
- nảy mạnh
- ít nảy

Đây là cách tốt để tinh chỉnh thay vì viết code chữa cháy cho mọi thứ.

## Các trạng thái thường gặp của Rigidbody

### Dynamic

Đây là dạng thường gặp nhất cho object chuyển động vật lý thực sự.

Ví dụ:

- thùng hàng có thể bị đẩy
- quả bóng rơi và nảy
- địch bị hất bay

### Kinematic

Object không bị lực và trọng lực tác động theo kiểu tự nhiên, nhưng vẫn có thể tương tác ở mức nào đó.

Phù hợp khi:

- bạn muốn tự điều khiển chuyển động bằng code
- object là nền tảng di động
- object có logic di chuyển đặc biệt

### Static

Thường là vật đứng yên như:

- tường
- sàn
- cột
- nền map

Không nên liên tục di chuyển collider tĩnh bằng code nếu có thể tránh, vì điều đó không hợp với mục đích của nó.

## Khi nào nên dùng vật lý, khi nào không?

Đây là phần rất quan trọng cho người mới.

Không phải mọi chuyển động đều nên giao hết cho vật lý.

### Nên cân nhắc vật lý khi:

- cần va chạm tự nhiên
- cần lực đẩy
- cần trọng lực
- cần phản ứng động sau va chạm
- gameplay dựa vào tương tác vật thể

### Nên cân nhắc điều khiển bằng code trực tiếp khi:

- object chỉ trượt theo đường định sẵn
- UI hoặc object trình diễn không cần va chạm thật
- enemy bay theo quỹ đạo đơn giản
- vật trang trí không cần mô phỏng

### Câu hỏi nên tự đặt

“Mình cần cảm giác vật lý thật, hay chỉ cần object đi từ A đến B?”

Nếu chỉ cần từ A đến B, đôi khi dùng vật lý là quá tay.

## Update, FixedUpdate và vật lý

Một lỗi nhập môn rất phổ biến là không biết logic vật lý nên đặt ở đâu.

### `Update`

Thường dùng cho:

- đọc input
- xử lý phụ thuộc frame render
- đếm thời gian hiển thị

### `FixedUpdate`

Thường dùng cho:

- thêm lực
- cập nhật chuyển động vật lý đều đặn
- làm việc với `Rigidbody` hoặc `Rigidbody2D`

Ví dụ tư duy phổ biến:

- đọc nút nhảy trong `Update`
- áp lực nhảy hoặc vận tốc trong `FixedUpdate`

Điều này giúp đồng bộ tốt hơn với nhịp của engine vật lý.

## Ví dụ 1: Nhân vật 2D rơi và nhảy

```csharp
using UnityEngine;

public class PlayerJump2D : MonoBehaviour
{
    [SerializeField] private float jumpForce = 8f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}
```

Điểm cốt lõi của ví dụ:

- cần `Rigidbody2D`
- thường cũng cần `Collider2D`
- mặt đất cần collider để nhân vật không rơi xuyên qua

Nếu thiếu một trong các mảnh ghép cơ bản, hành vi sẽ không đúng.

## Ví dụ 2: Coin dùng Trigger

```csharp
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
```

Tư duy ở đây là:

- coin không cần chặn đường người chơi
- coin chỉ cần biết khi người chơi đi vào vùng của nó
- vậy `Is Trigger` là hợp lý hơn va chạm cứng

## Ví dụ 3: Đạn 3D va vào tường

```csharp
using UnityEngine;

public class Bullet3D : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
```

Muốn ví dụ này chạy đúng, bạn cần kiểm tra:

- object dùng hệ 3D hay chưa
- có collider chưa
- có rigidbody ở một trong các bên liên quan chưa
- có nhầm callback 2D không

## Quy trình suy nghĩ khi thiết kế vật lý

### Bước 1: Game của bạn là 2D hay 3D?

Nghe đơn giản nhưng rất quan trọng.

Chọn sai từ đầu sẽ kéo theo dùng sai component và sai callback.

### Bước 2: Object này có cần tham gia va chạm không?

Nếu không cần, có thể không cần collider.

Nếu cần phát hiện chạm hoặc chồng lấn, collider gần như là bắt buộc.

### Bước 3: Object này có cần chuyển động vật lý động không?

Nếu có, nghĩ tới rigidbody.

Nếu chỉ đứng yên làm nền, collider có thể là đủ.

### Bước 4: Đây là va chạm cứng hay trigger mềm?

Tự hỏi:

- người chơi có cần bị chặn bởi object này không?
- hay chỉ cần nhận biết đi vào vùng?

### Bước 5: Logic này có nên đi qua `FixedUpdate` không?

Nếu bạn đang thêm lực, chỉnh vận tốc, hoặc làm việc sát với rigidbody, câu trả lời thường là có.

### Bước 6: Có đang để code và vật lý giành quyền điều khiển object không?

Ví dụ tình huống xấu:

- một mặt bạn đổi `transform.position` liên tục
- mặt khác rigidbody cũng đang mô phỏng

Kết quả có thể là rung, xuyên, hoặc cảm giác rất “sai”.

## Va chạm và trigger khác nhau ra sao?

### Va chạm thường

Đặc điểm:

- object có thể chặn nhau
- có phản ứng vật lý tùy cấu hình
- dùng callback `OnCollision...`

Phù hợp cho:

- tường
- sàn
- thùng hàng
- xe cộ

### Trigger

Đặc điểm:

- không chặn nhau theo kiểu vật lý cứng
- dùng callback `OnTrigger...`
- tốt cho vùng phát hiện

Phù hợp cho:

- nhặt item
- checkpoint
- vùng hội thoại
- cạm bẫy phát hiện người chơi

## Những lỗi sai thường gặp của người mới

### 1. Trộn component 2D và 3D

Đây là lỗi số một.

Ví dụ:

- dùng `BoxCollider` với `Rigidbody2D`
- viết `OnTriggerEnter` thay vì `OnTriggerEnter2D`

Kết quả là không có va chạm như mong đợi.

### 2. Quên collider

Nhiều bạn thêm rigidbody nhưng quên collider.

Object có thể rơi, nhưng không va chạm đúng với thế giới.

### 3. Quên rigidbody ở đối tượng cần thiết

Tùy tình huống, ít nhất một bên trong tương tác cần có rigidbody để callback hoạt động như mong muốn.

### 4. Di chuyển rigidbody bằng cách sửa `transform` lung tung

Điều này dễ làm hệ vật lý mất ổn định.

Hãy cân nhắc cách di chuyển phù hợp với loại gameplay.

### 5. Không phân biệt va chạm cứng với trigger

Ví dụ coin mà để collider thường có thể chặn đường người chơi, gây cảm giác sai.

### 6. Không chỉnh layer collision matrix

Đôi khi mọi thứ tưởng đúng nhưng hai layer đang bị tắt va chạm với nhau trong project settings.

### 7. Dùng collider quá phức tạp khi chưa cần

Người mới thường thích dùng `MeshCollider` mọi nơi.

Nhưng nhiều lúc `BoxCollider` hoặc `CapsuleCollider` đơn giản hơn, dễ kiểm soát hơn, và đủ tốt hơn.

### 8. Không hiểu trọng lực và mass ảnh hưởng cảm giác gameplay

Nếu chỉ để mặc định mọi thứ, game có thể chạy được nhưng cảm giác rất thiếu tinh chỉnh.

## Mẹo thực hành tốt cho người mới

- Chọn 2D hoặc 3D thật rõ ngay từ đầu.
- Dùng collider đơn giản trước, chỉ tăng độ phức tạp khi cần.
- Test từng object một trong scene nhỏ.
- Dùng Gizmos hoặc nhìn collider trong Scene view để kiểm tra vùng chạm.
- Viết log khi học callback va chạm để hiểu lúc nào nó được gọi.
- Nếu object không phản ứng, kiểm tra lần lượt: component, layer, trigger, rigidbody, callback.

## Một checklist debug rất hữu ích

Khi va chạm không hoạt động, hãy tự hỏi:

- Đây là hệ 2D hay 3D?
- Collider đã gắn đúng chưa?
- Có nhầm giữa trigger và collision không?
- Callback viết đúng tên chưa?
- Có đúng hậu tố `2D` không?
- Object có đang active không?
- Layer có cho phép va chạm không?
- Có rigidbody ở bên phù hợp chưa?

Checklist này tưởng đơn giản nhưng giúp tiết kiệm rất nhiều thời gian.

## Tóm tắt

- Unity có hai hệ vật lý tách biệt: 2D và 3D.
- `Rigidbody` và `Rigidbody2D` giúp object tham gia chuyển động vật lý.
- `Collider` và `Collider2D` xác định vùng va chạm.
- `Trigger` dùng để phát hiện chồng lấn mà không chặn vật thể.
- Không nên trộn component và callback của 2D với 3D.
- Logic vật lý thường phù hợp với `FixedUpdate` hơn là `Update`.
- Không phải object nào cũng cần rigidbody hay vật lý thật.
- Chọn đúng công cụ sẽ giúp gameplay ổn định và dễ mở rộng hơn.

## Tự kiểm tra

1. Unity có mấy hệ vật lý chính, và chúng có tách biệt nhau không?
2. `Rigidbody2D` khác `Collider2D` ở vai trò nào?
3. Khi nào nên dùng trigger thay vì va chạm cứng?
4. Vì sao không nên trộn `Collider` 3D với `Rigidbody2D`?
5. `FixedUpdate` thường phù hợp với dạng logic nào?
6. Hãy nêu 3 ví dụ object nên dùng trigger.
7. Hãy nêu 3 ví dụ object nên dùng va chạm cứng.
8. Nếu đạn 2D không chạm kẻ địch, bạn sẽ kiểm tra những gì đầu tiên?
9. Vì sao không phải lúc nào cũng nên dùng vật lý cho mọi chuyển động?
10. Trong game platformer 2D, những component vật lý cơ bản nào thường có trên nhân vật?

## Bài tập suy nghĩ thêm

- Hãy thử tạo một scene nhỏ gồm sàn, nhân vật và coin.
- Làm cho nhân vật rơi xuống sàn bằng trọng lực.
- Làm cho coin biến mất khi người chơi chạm vào bằng trigger.
- Sau đó tự giải thích vì sao sàn nên là collider thường còn coin nên là trigger.

Khi bạn hiểu chắc vật lý 2D và 3D, bạn sẽ thấy rất nhiều cơ chế gameplay trở nên dễ xây dựng hơn nhiều.
