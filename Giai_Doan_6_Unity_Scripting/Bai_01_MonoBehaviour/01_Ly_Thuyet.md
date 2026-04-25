# Bài 1: MonoBehaviour

## Mục tiêu

- Hiểu `MonoBehaviour` là gì trong Unity.
- Biết vì sao phần lớn script gameplay cơ bản đều kế thừa từ `MonoBehaviour`.
- Phân biệt được các hàm vòng đời như `Awake`, `Start`, `Update`, `FixedUpdate`, `LateUpdate`.
- Biết khi nào nên đặt logic vào từng hàm.
- Tránh các lỗi nhập môn rất thường gặp khi mới học Unity.
- Có tư duy tổ chức script rõ ràng, dễ đọc, dễ mở rộng.

## Bức tranh tổng quan

Khi mới học Unity, rất nhiều bạn thấy gần như file script nào cũng viết kiểu:

```csharp
public class PlayerController : MonoBehaviour
{
}
```

Điều này không phải ngẫu nhiên.

`MonoBehaviour` là chiếc cầu nối giữa code C# của bạn và hệ thống chạy của Unity.

Nói đơn giản hơn:

- Nếu chỉ viết một class C# bình thường, class đó chưa tự gắn lên GameObject được.
- Nếu kế thừa `MonoBehaviour`, script có thể trở thành component của một GameObject trong scene.
- Khi đó Unity mới biết lúc nào cần gọi `Awake`, `Start`, `Update`, hay các hàm va chạm.

Vì vậy, `MonoBehaviour` là một khái niệm nền móng.

Nếu chưa hiểu nó, bạn sẽ thường viết code theo kiểu thử sai.

Nếu hiểu nó, bạn bắt đầu đọc được cách Unity “nghĩ”.

## Khái niệm

`MonoBehaviour` là class cơ sở mà Unity cung cấp để tạo các script có thể:

- gắn vào `GameObject`
- tham gia vòng đời của scene
- nhận callback từ engine
- thao tác với component khác
- phản ứng với input, vật lý, animation, UI và nhiều hệ thống khác

Hãy tạm hiểu `MonoBehaviour` như một “component có code”.

Một `GameObject` trong Unity thường gồm nhiều component:

- `Transform`
- `SpriteRenderer` hoặc `MeshRenderer`
- `Collider`
- `Rigidbody`
- và các script của bạn kế thừa `MonoBehaviour`

Mỗi component giữ một vai trò riêng.

Script kế thừa `MonoBehaviour` là nơi bạn viết hành vi.

Ví dụ:

- script điều khiển nhân vật
- script quản lý máu
- script mở cửa
- script đếm điểm
- script tự hủy đạn sau 3 giây

## Tại sao phải dùng cái này?

Lý do đầu tiên là tính tương thích với cách Unity vận hành.

Unity không tự động chạy mọi class C# trong dự án.

Unity chỉ gọi những hàm đặc biệt trên các component mà nó quản lý.

`MonoBehaviour` giúp script của bạn đi vào hệ sinh thái đó.

Lý do thứ hai là tốc độ làm game.

Bạn có thể:

- kéo thả script lên object
- kéo thả tham chiếu trong Inspector
- bật tắt component nhanh chóng
- dùng prefab chứa sẵn script
- test nhanh từng hành vi trong scene

Lý do thứ ba là dễ chia nhỏ trách nhiệm.

Thay vì viết một khối code khổng lồ, bạn có thể tách thành nhiều component:

- `PlayerMovement`
- `PlayerHealth`
- `PlayerAttack`
- `PlayerAnimation`

Mỗi script làm một việc rõ ràng.

Đây là cách làm rất phù hợp với tư duy component-based của Unity.

## Liên hệ game thực tế

Hãy tưởng tượng một game platformer đơn giản.

Nhân vật chính có thể:

- chạy trái phải
- nhảy
- mất máu
- nhặt coin
- phát animation
- chết và hồi sinh

Nếu nhìn từ góc độ Unity, nhân vật thường có nhiều script `MonoBehaviour` khác nhau.

Ví dụ:

- `PlayerInputReader`: đọc input
- `PlayerMovement`: xử lý di chuyển
- `PlayerHealth`: quản lý máu
- `PlayerAnimationController`: đổi animation theo trạng thái
- `PlayerRespawn`: hồi sinh ở checkpoint

Mỗi script đều là một component.

Tất cả cùng nằm trên một `GameObject` hoặc các object con.

Trong game thật, bạn hiếm khi chỉ có một script duy nhất.

Hiểu `MonoBehaviour` giúp bạn biết cách ghép các mảnh hành vi lại thành một hệ thống hoàn chỉnh.

## MonoBehaviour khác class C# thường ở điểm nào?

Một class C# thường:

- có thể dùng để chứa dữ liệu
- có thể dùng để viết logic thuần
- không bắt buộc gắn với Unity scene
- không có sẵn `Start` hay `Update` được Unity tự gọi

Một class kế thừa `MonoBehaviour`:

- gắn được lên `GameObject`
- xuất hiện trong Inspector
- dùng được nhiều callback của Unity
- có thể dùng `GetComponent`, `transform`, `gameObject`
- chịu ảnh hưởng bởi việc object active hay không

Điều quan trọng cho người mới:

Không phải class nào cũng nên là `MonoBehaviour`.

Chỉ những gì thực sự cần sống trong scene, cần gắn object, hoặc cần callback từ Unity mới nên là `MonoBehaviour`.

## Cách tạo một MonoBehaviour

Ví dụ cơ bản:

```csharp
using UnityEngine;

public class HelloMonoBehaviour : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Xin chao Unity");
    }
}
```

Khi script này được gắn vào một `GameObject` đang hoạt động trong scene, Unity sẽ gọi `Start` ở thời điểm phù hợp.

Muốn script chạy được, thường cần đủ các điều kiện sau:

- file script không lỗi biên dịch
- tên file trùng tên class public
- script kế thừa `MonoBehaviour`
- script được gắn lên một `GameObject`
- object đó đang active trong scene
- component đó đang enabled nếu là loại có thể enable hoặc disable

## Các thành phần thường đi cùng MonoBehaviour

Người mới thường chỉ chú ý vào code.

Nhưng trong Unity, `MonoBehaviour` thường làm việc cùng những khái niệm khác.

### GameObject

Là vật chứa các component.

Ví dụ:

- Player
- Enemy
- Main Camera
- Coin
- Door

### Transform

Hầu như object nào cũng có.

Nó lưu:

- vị trí
- góc quay
- tỉ lệ

Trong `MonoBehaviour`, bạn thường truy cập qua `transform`.

### Component

Mọi thứ gắn trên GameObject đều là component.

Script của bạn cũng là component.

### Inspector

Là nơi cho phép sửa giá trị public hoặc `[SerializeField]` mà không cần sửa code.

Đây là lý do Unity rất thân thiện với quy trình làm game nhanh.

## Vòng đời cơ bản của MonoBehaviour

Đây là phần rất quan trọng.

Người mới hay nhớ tên hàm nhưng không hiểu “nên đặt việc gì ở đâu”.

### `Awake()`

`Awake` thường dùng để khởi tạo sớm.

Nó được gọi khi object được nạp.

Thường dùng để:

- lấy tham chiếu component cùng object
- kiểm tra dữ liệu bắt buộc
- tạo giá trị mặc định nội bộ
- chuẩn bị những thứ không phụ thuộc object khác đã `Start`

Ví dụ:

```csharp
private Rigidbody2D rb;

private void Awake()
{
    rb = GetComponent<Rigidbody2D>();
}
```

Ý tưởng ở đây là:

- `Rigidbody2D` nằm cùng object
- ta muốn lấy nó càng sớm càng tốt
- đây là việc mang tính nội bộ của script

### `OnEnable()`

Hàm này chạy khi component hoặc object được bật.

Nó rất hữu ích khi làm việc với event.

Ví dụ:

- đăng ký lắng nghe sự kiện trong `OnEnable`
- hủy đăng ký trong `OnDisable`

Điều này giúp tránh bug do event gọi vào object đã tắt hoặc đã bị hủy.

### `Start()`

`Start` chạy trước frame đầu tiên, sau `Awake`.

Thường dùng khi:

- cần mọi thứ ban đầu đã sẵn sàng hơn
- cần tham chiếu tới object khác trong scene
- cần gọi logic bắt đầu game

Ví dụ:

```csharp
private void Start()
{
    currentHealth = maxHealth;
    UpdateUI();
}
```

### `Update()`

`Update` chạy mỗi frame.

Đây là nơi thường đặt:

- đọc input tức thời
- xoay camera theo chuột
- kiểm tra điều kiện gameplay diễn ra liên tục
- đếm thời gian bằng `Time.deltaTime`

Ví dụ:

```csharp
private void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Jump();
    }
}
```

Nhưng không nên lạm dụng `Update`.

Mọi thứ đưa vào đây sẽ chạy rất nhiều lần.

Nếu logic không cần kiểm tra mỗi frame, đừng nhét vào `Update`.

### `FixedUpdate()`

`FixedUpdate` thường dùng cho vật lý.

Ví dụ:

- thêm lực cho `Rigidbody`
- di chuyển liên quan physics
- xử lý ổn định theo bước thời gian vật lý

Điểm mấu chốt:

- `Update` gắn với frame render
- `FixedUpdate` gắn với nhịp vật lý

Nếu bạn dùng `Rigidbody` mà lại thao tác kiểu vật lý lung tung trong `Update`, hành vi có thể thiếu ổn định.

### `LateUpdate()`

`LateUpdate` chạy sau `Update`.

Nó phù hợp khi một object cần theo sau kết quả cập nhật của object khác.

Ví dụ kinh điển là camera theo nhân vật.

Nếu nhân vật di chuyển ở `Update`, camera có thể cập nhật ở `LateUpdate` để lấy vị trí sau cùng của nhân vật trong frame đó.

### `OnDisable()`

Hàm này chạy khi object hoặc component bị tắt.

Rất thường dùng để:

- hủy đăng ký event
- dừng hiệu ứng tạm thời
- reset trạng thái phụ

### `OnDestroy()`

Hàm này chạy khi object bị hủy.

Thường dùng cho công việc dọn dẹp cuối cùng.

Nhưng đừng phụ thuộc hoàn toàn vào nó cho toàn bộ thiết kế.

Trong thực tế, cặp `OnEnable` và `OnDisable` thường được dùng nhiều hơn cho quản lý event.

## Quy trình suy nghĩ khi viết MonoBehaviour

Người mới hay hỏi:

“Em biết các hàm rồi, nhưng không biết đặt code ở đâu cho đúng.”

Hãy đi theo quy trình suy nghĩ sau.

### Bước 1: Script này đại diện cho trách nhiệm gì?

Ví dụ:

- di chuyển
- máu
- animation
- bắn đạn
- tương tác cửa

Nếu một script trả lời được quá nhiều vai trò, có thể bạn đang gom trách nhiệm quá mức.

### Bước 2: Script này cần gắn lên object không?

Nếu có, và cần tham gia scene, `MonoBehaviour` là ứng viên phù hợp.

Nếu chỉ là logic tính toán thuần, đôi khi class thường tốt hơn.

### Bước 3: Dữ liệu nào cần chỉnh trong Inspector?

Ví dụ:

- tốc độ di chuyển
- lực nhảy
- máu tối đa
- prefab đạn

Những giá trị này thường nên là `SerializeField` để dễ chỉnh mà không sửa code.

### Bước 4: Việc khởi tạo nên diễn ra ở đâu?

Tự hỏi:

- có cần lấy component cùng object không
- có phụ thuộc object khác không
- có cần chờ scene sẵn sàng hơn không

Nếu chỉ lấy component nội bộ, thường đặt ở `Awake`.

Nếu cần logic bắt đầu sau khi hệ thống khởi tạo xong hơn, cân nhắc `Start`.

### Bước 5: Logic này có cần chạy mỗi frame không?

Nếu không, đừng cho vào `Update`.

Ví dụ không cần `Update`:

- cập nhật UI máu khi máu đổi
- mở cửa khi đủ chìa khóa
- tăng điểm khi nhặt coin

Những việc đó nên chạy khi sự kiện xảy ra.

### Bước 6: Logic này có liên quan vật lý không?

Nếu có, nghĩ tới `FixedUpdate`, `Rigidbody`, hay callback va chạm.

### Bước 7: Script này có đang biết quá nhiều không?

Nếu một script vừa đọc input, vừa di chuyển, vừa trừ máu, vừa phát âm thanh, vừa cập nhật UI, đó là tín hiệu nên tách bớt.

## Ví dụ 1: Script di chuyển cơ bản

```csharp
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 moveDirection = new Vector3(horizontal, 0f, 0f);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
```

Phân tích ví dụ:

- Script kế thừa `MonoBehaviour` nên gắn được lên object.
- Tốc độ được chỉnh trong Inspector.
- Input được đọc trong `Update` vì liên quan frame.
- Dùng `Time.deltaTime` để chuyển động ổn định hơn theo thời gian.

Đây là ví dụ nhập môn tốt vì dễ nhìn.

Nhưng ở dự án lớn hơn, ta có thể tách đọc input và di chuyển thành hai phần riêng.

## Ví dụ 2: Lấy component trong Awake

```csharp
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 7f;

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

Điều cần học từ ví dụ này không chỉ là code.

Điều quan trọng là cách suy nghĩ:

- `Rigidbody2D` là thành phần bắt buộc của object này.
- Nó nằm cùng object.
- Vậy lấy nó ở `Awake` là hợp lý.

## Ví dụ 3: Dùng SerializeField thay vì public tràn lan

Người mới thường viết:

```csharp
public float speed;
public int maxHealth;
public GameObject bulletPrefab;
```

Không phải lúc nào `public` cũng sai.

Nhưng nếu chỉ muốn hiện trên Inspector mà không muốn class khác sửa bừa, hãy dùng:

```csharp
[SerializeField] private float speed = 5f;
[SerializeField] private int maxHealth = 100;
[SerializeField] private GameObject bulletPrefab;
```

Lợi ích:

- vẫn chỉnh được trong Inspector
- giảm mức độ lộ dữ liệu không cần thiết
- giữ tính đóng gói tốt hơn

## Những câu hỏi thực tế người mới thường gặp

### Có phải script Unity nào cũng cần `Update` không?

Không.

Rất nhiều script không cần `Update`.

Ví dụ:

- script dữ liệu tĩnh
- script lắng nghe event
- script chỉ chạy lúc khởi tạo
- script phản ứng khi va chạm

### Có phải cứ khởi tạo là cho vào `Start`?

Không.

Hãy hỏi xem nó có phải việc nội bộ, độc lập không.

Nếu có, `Awake` thường phù hợp.

### Có nên gọi `GetComponent` liên tục trong `Update`?

Thường là không nên.

Hãy cache tham chiếu nếu dùng thường xuyên.

Ví dụ nên làm:

- lấy một lần ở `Awake`
- lưu vào biến private
- dùng lại ở các frame sau

## Lỗi sai thường gặp của người mới

### 1. Nhồi mọi thứ vào một script duy nhất

Hậu quả:

- code dài
- khó đọc
- khó sửa
- dễ phát sinh lỗi dây chuyền

### 2. Nhồi quá nhiều việc vào `Update`

Đây là lỗi rất phổ biến.

Người mới thường thấy `Update` dễ dùng nên cho hết mọi logic vào đó.

Hậu quả:

- tốn tài nguyên không cần thiết
- khó theo dõi luồng chạy
- về sau tối ưu rất mệt

### 3. Không hiểu khác nhau giữa `Awake` và `Start`

Khi không hiểu, bạn sẽ gặp bug kiểu:

- object A cần object B đã khởi tạo xong
- nhưng lại đọc dữ liệu quá sớm
- dẫn tới `null` hoặc giá trị chưa đúng

### 4. Dùng `public` cho mọi biến

Việc này làm class khác có thể sửa bừa dữ liệu.

Lâu dài code khó kiểm soát hơn.

### 5. Gọi `GetComponent` lặp lại quá nhiều

Ví dụ sai thường thấy:

```csharp
private void Update()
{
    GetComponent<SpriteRenderer>().flipX = true;
}
```

Nên cache trước nếu dùng liên tục.

### 6. Không kiểm tra object tham chiếu trong Inspector

Ví dụ:

- quên kéo thả UI
- quên kéo thả prefab
- quên gắn camera hoặc target

Kết quả là lỗi `NullReferenceException`.

### 7. Không tôn trọng trách nhiệm của component

Ví dụ:

- script máu tự điều khiển di chuyển
- script camera tự xử lý sát thương

Đó là dấu hiệu thiết kế đang lẫn vai trò.

## Mẹo học MonoBehaviour hiệu quả

- Đọc code và tự hỏi script này đang làm đúng một việc hay nhiều việc.
- Khi viết hàm mới, tự hỏi nó nên sống ở `Awake`, `Start`, `Update` hay do event kích hoạt.
- Tập thói quen cache component ở `Awake`.
- Tập thói quen dùng `[SerializeField] private`.
- Khi script dài bất thường, thử tách trách nhiệm.
- Luôn test bằng scene nhỏ trước khi đưa vào dự án lớn.

## Cách tự kiểm tra một MonoBehaviour của bạn đã ổn chưa

Hãy tự trả lời các câu sau:

- Script này có tên nói rõ nhiệm vụ không?
- Script này có quá nhiều lý do để thay đổi không?
- Biến nào thực sự cần hiện trên Inspector?
- Có chỗ nào đang phụ thuộc quá mức vào object khác không?
- Có logic nào đang bị nhét vô cớ vào `Update` không?
- Có component bắt buộc nào nên lấy sớm ở `Awake` không?
- Có nguy cơ `null` vì quên gán tham chiếu không?

Nếu trả lời tốt các câu này, chất lượng script của bạn sẽ tiến bộ rất nhanh.

## Khi nào không nên dùng MonoBehaviour?

Đây là điểm rất đáng học sớm.

Không phải cái gì trong game cũng nên là component gắn scene.

Ví dụ không nhất thiết phải là `MonoBehaviour`:

- class tính sát thương thuần
- class dữ liệu item
- class công thức nâng cấp
- class tiện ích chuyển đổi dữ liệu
- class save data

Những thứ này đôi khi nên là:

- class C# thường
- `ScriptableObject` nếu cần dữ liệu cấu hình
- struct hoặc record nếu chỉ chứa dữ liệu đơn giản

Biết giới hạn của `MonoBehaviour` là bước đầu để viết kiến trúc sạch hơn.

## Một mô hình tư duy đơn giản cho người mới

Hãy ghi nhớ câu sau:

`MonoBehaviour` không phải nơi để nhét mọi code, mà là nơi để một hành vi trong scene giao tiếp với Unity đúng cách.

Khi nghĩ như vậy, bạn sẽ bắt đầu:

- tách code rõ hơn
- dùng callback hợp lý hơn
- ít phụ thuộc lung tung hơn
- dễ mở rộng dự án hơn

## Tóm tắt

- `MonoBehaviour` là class nền để script của bạn hoạt động như một component trong Unity.
- Nó cho phép gắn script lên `GameObject`.
- Nó giúp Unity gọi các hàm vòng đời như `Awake`, `Start`, `Update`.
- `Awake` thường dùng cho khởi tạo sớm và lấy component nội bộ.
- `Start` thường dùng cho logic bắt đầu khi scene sẵn sàng hơn.
- `Update` dùng cho việc cần chạy mỗi frame, nhưng không nên lạm dụng.
- `FixedUpdate` phù hợp hơn với vật lý.
- `LateUpdate` phù hợp cho logic cần chạy sau `Update`, ví dụ camera theo nhân vật.
- Script tốt là script có trách nhiệm rõ ràng.
- Không phải class nào trong game cũng nên kế thừa `MonoBehaviour`.

## Tự kiểm tra

1. `MonoBehaviour` khác class C# thường ở những điểm nào?
2. Vì sao Unity không tự gọi `Update` của một class C# bình thường?
3. Khi nào nên dùng `Awake` thay vì `Start`?
4. Vì sao không nên đưa mọi logic vào `Update`?
5. `FixedUpdate` thường liên quan tới loại hệ thống nào?
6. Vì sao nên dùng `[SerializeField] private` trong nhiều trường hợp?
7. Hãy nêu 3 ví dụ script rất phù hợp để viết dưới dạng `MonoBehaviour`.
8. Hãy nêu 3 ví dụ class không nhất thiết phải là `MonoBehaviour`.
9. Nếu một script vừa đọc input, vừa cập nhật UI, vừa điều khiển animation, bạn nên nghĩ tới vấn đề gì?
10. Trong game platformer, camera theo nhân vật thường hợp với `Update` hay `LateUpdate` hơn, và vì sao?

## Bài tập suy nghĩ thêm

- Hãy mở một prefab nhân vật và liệt kê các component mà bạn nghĩ nên tách riêng.
- Hãy viết thử một script chỉ có trách nhiệm mở cửa khi người chơi lại gần.
- Hãy viết thử một script khác chỉ có trách nhiệm hiển thị dòng chữ hướng dẫn khi lại gần cửa.
- So sánh hai script đó và tự hỏi vì sao tách ra lại dễ bảo trì hơn.

Khi bạn hiểu chắc `MonoBehaviour`, bạn đã nắm được một trong những viên gạch nền quan trọng nhất của Unity scripting.
