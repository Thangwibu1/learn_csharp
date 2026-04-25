# Bài 3: Input System

## Mục tiêu

- Hiểu input trong game là gì.
- Biết vì sao input là một hệ thống quan trọng chứ không chỉ là vài dòng đọc phím.
- Phân biệt tư duy đọc input kiểu cũ và tư duy tổ chức input rõ ràng hơn.
- Hiểu khi nào nên đọc input trong `Update`, khi nào nên chuyển dữ liệu sang hệ khác xử lý.
- Biết cách tránh việc code input dính chặt vào gameplay.
- Có nền tảng để học sâu hơn về Unity Input System sau này.

## Bức tranh tổng quan

Người chơi tương tác với game bằng cách gửi lệnh.

Những lệnh đó có thể đến từ:

- bàn phím
- chuột
- tay cầm
- màn hình cảm ứng
- joystick ảo trên điện thoại

Game phải nhận các lệnh này, hiểu chúng, rồi biến chúng thành hành động trong thế giới game.

Ví dụ:

- nhấn `A` thì nhân vật đi trái
- nhấn `Space` thì nhân vật nhảy
- click chuột trái thì bắn
- chạm nút trên màn hình thì mở menu

Nếu không có input, game gần như không chơi được.

Nhưng nếu tổ chức input cẩu thả, bạn sẽ nhanh chóng gặp các vấn đề như:

- code khó mở rộng
- khó đổi sang tay cầm
- khó khóa input khi pause
- logic gameplay bị dính chặt với thiết bị điều khiển

Vì vậy, input không chỉ là “đọc phím”, mà còn là bài toán thiết kế hệ thống.

## Khái niệm

Input là dữ liệu hoặc tín hiệu mà người chơi gửi vào game thông qua thiết bị điều khiển.

Game sẽ:

1. nhận tín hiệu
2. diễn giải tín hiệu đó
3. biến nó thành hành động gameplay hoặc UI

Ví dụ cùng một hành động “nhảy” có thể đến từ nhiều nguồn:

- phím `Space`
- nút `A` trên gamepad
- nút nhảy trên màn hình điện thoại

Điểm quan trọng là:

Người chơi nghĩ theo hành động.

Thiết bị chỉ là cách phát lệnh.

Đây là tư duy rất quan trọng nếu bạn muốn dự án phát triển gọn gàng.

## Tại sao phải dùng cái này?

### 1. Vì game cần nhận lệnh từ người chơi

Đây là lý do hiển nhiên nhất.

Không có input thì game khó mà gọi là trò chơi tương tác.

### 2. Vì input ảnh hưởng trực tiếp tới cảm giác điều khiển

Một game có đồ họa đơn giản nhưng điều khiển mượt vẫn rất cuốn.

Ngược lại, game đẹp nhưng input trễ, khó hiểu, hoặc không nhất quán sẽ làm người chơi rất khó chịu.

### 3. Vì input liên quan đến mở rộng đa nền tảng

Khi dự án lớn hơn, bạn có thể muốn hỗ trợ:

- PC
- mobile
- gamepad
- console

Nếu từ đầu bạn viết input cứng vào từng dòng gameplay, việc mở rộng sẽ cực kỳ mệt.

### 4. Vì input còn liên quan đến trạng thái game

Ví dụ:

- đang chơi thì nhận input di chuyển
- đang pause thì không nên cho nhân vật chạy
- đang mở inventory thì phím có thể mang nghĩa khác

Nói cách khác, input không đứng riêng lẻ.

Nó luôn liên quan tới bối cảnh của game.

## Liên hệ game thực tế

### Game platformer

Người chơi thường có các hành động:

- đi trái
- đi phải
- nhảy
- tấn công
- tương tác

Nếu làm nhập môn, bạn có thể đọc trực tiếp trong `Update`.

Nhưng nếu dự án lớn hơn, bạn nên nghĩ tới việc tách input ra khỏi movement và combat.

### Game bắn súng

Input có thể bao gồm:

- nhìn bằng chuột hoặc cần analog
- bắn
- ngắm
- thay đạn
- chạy nhanh
- ném lựu đạn

Lúc này bài toán input phức tạp hơn nhiều.

### Game mobile

Input có thể đến từ:

- chạm một lần
- chạm kéo
- joystick ảo
- đa chạm

Nếu bạn viết hệ thống quá cứng theo bàn phím, việc port sang mobile sẽ vất vả.

## Các loại input thường gặp

### Input nhị phân

Đây là loại có hoặc không.

Ví dụ:

- nhấn nút nhảy
- click bắn
- nhấn mở menu

Nó thường mang tính sự kiện hoặc hành động tức thời.

### Input liên tục

Đây là loại có giá trị theo trục hoặc cường độ.

Ví dụ:

- trục ngang trái phải
- trục dọc lên xuống
- analog stick
- rê chuột để nhìn quanh

### Input UI

Dùng cho giao diện.

Ví dụ:

- click nút
- rê thanh kéo
- chọn tab
- xác nhận hộp thoại

### Input theo ngữ cảnh

Cùng một nút nhưng nghĩa khác nhau tùy tình huống.

Ví dụ:

- phím `E` ở ngoài map là tương tác
- phím `E` trong inventory là trang bị
- phím `Esc` khi đang chơi là mở pause
- phím `Esc` khi đang ở menu con là quay lại

Đây là lý do input không nên viết kiểu rời rạc, thiếu tổ chức.

## Cách nghĩ đúng về input

Người mới thường nghĩ:

“Bấm phím nào thì làm ngay hành động đó.”

Điều này đúng ở mức nhập môn.

Nhưng khi game phức tạp hơn, cách nghĩ tốt hơn là:

“Người chơi gửi yêu cầu hành động. Hệ thống gameplay quyết định có thực hiện hay không.”

Ví dụ:

- người chơi bấm nhảy
- nhưng nếu đang chết thì không được nhảy
- nếu đang ở trên menu thì bỏ qua
- nếu đang bị choáng thì có thể không nhận lệnh

Như vậy, input chỉ là đầu vào.

Gameplay mới là nơi ra quyết định cuối cùng.

## Input trong Unity nhập môn

Ở mức cơ bản, người mới thường học các hàm như:

- `Input.GetKey`
- `Input.GetKeyDown`
- `Input.GetKeyUp`
- `Input.GetMouseButtonDown`
- `Input.GetAxis`
- `Input.GetAxisRaw`

Đây là cách học tốt để hiểu bản chất input.

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

Code này dễ hiểu, phù hợp để nhập môn.

Tuy nhiên, nếu dự án lớn lên, cách viết trực tiếp như vậy ở nhiều nơi sẽ gây rối.

## Đọc input trong Update vì sao thường hợp lý?

Input từ người chơi thường gắn với frame hiển thị.

`Update` là nơi Unity cập nhật theo từng frame.

Vì vậy, phần lớn input tức thời thường được đọc ở đây.

Ví dụ:

- bấm phím
- click chuột
- đọc trục điều khiển

Nhưng hãy nhớ:

Đọc input ở `Update` không có nghĩa là mọi hệ thống khác cũng phải xử lý luôn ở đó.

Bạn có thể:

- đọc input trong `Update`
- lưu lại ý định của người chơi
- để movement hoặc physics xử lý ở nơi phù hợp hơn

## Ví dụ 1: Input di chuyển cơ bản

```csharp
using UnityEngine;

public class SimpleInputMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0f, 0f);
        transform.position += direction * speed * Time.deltaTime;
    }
}
```

Đây là ví dụ dễ hiểu cho người mới.

Nhưng nó đang gộp hai việc:

- đọc input
- di chuyển object

Trong dự án nhỏ điều này vẫn ổn.

Trong dự án lớn hơn, bạn nên nghĩ tới tách vai trò.

## Ví dụ 2: Tách input và hành động

```csharp
using UnityEngine;

public class PlayerInputReader : MonoBehaviour
{
    public float MoveX { get; private set; }
    public bool JumpPressed { get; private set; }

    private void Update()
    {
        MoveX = Input.GetAxisRaw("Horizontal");
        JumpPressed = Input.GetKeyDown(KeyCode.Space);
    }

    private void LateUpdate()
    {
        JumpPressed = false;
    }
}
```

Sau đó một script khác có thể đọc dữ liệu này để xử lý.

Ý nghĩa của cách làm này:

- input được gom về một nơi
- movement không cần biết phím cụ thể
- sau này đổi từ bàn phím sang gamepad dễ hơn

## Ví dụ 3: Input và gameplay không nên dính cứng với nhau

Ví dụ viết quá chặt:

```csharp
private void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        animator.Play("Jump");
        audioSource.PlayOneShot(jumpClip);
        stamina -= 5;
        uiManager.UpdateJumpButtonState();
    }
}
```

Code này chưa chắc sai ngay, nhưng có dấu hiệu quá dính.

Một nút bấm đang kéo theo:

- vật lý
- animation
- âm thanh
- stamina
- UI

Khi hệ thống lớn hơn, kiểu phụ thuộc này sẽ rất khó bảo trì.

## Quy trình suy nghĩ khi thiết kế input

### Bước 1: Liệt kê hành động của người chơi, không phải liệt kê phím

Ví dụ:

- Move
- Jump
- Attack
- Interact
- Pause

Làm vậy giúp bạn tư duy theo gameplay thay vì theo thiết bị.

### Bước 2: Xác định game có những ngữ cảnh nào

Ví dụ:

- gameplay thường
- menu pause
- inventory
- dialog
- game over

Cùng một nút có thể có ý nghĩa khác nhau ở mỗi ngữ cảnh.

### Bước 3: Xác định input nào liên tục, input nào tức thời

Ví dụ:

- `Move` là liên tục
- `Jump` là tức thời
- `Pause` là tức thời

Biết loại input giúp bạn chọn cách lưu và xử lý hợp lý.

### Bước 4: Quyết định nơi đọc input và nơi thực thi logic

Đừng mặc định rằng nơi đọc input cũng là nơi xử lý tất cả.

### Bước 5: Nghĩ tới tương lai hỗ trợ nhiều thiết bị

Ngay cả khi hiện tại bạn chỉ làm PC, việc giữ cấu trúc sạch sẽ vẫn rất đáng giá.

## Liên hệ với Unity Input System mới

Trong Unity hiện đại, bạn có thể dùng gói `Input System` mới.

Nó hỗ trợ tốt hơn cho:

- nhiều thiết bị
- action map
- rebinding
- callback theo hành động

Ở bài lý thuyết nền tảng này, điều quan trọng nhất chưa phải là học hết API.

Điều quan trọng hơn là hiểu tư duy:

- hành động của người chơi là trung tâm
- input không nên dính chặt vào gameplay cụ thể
- nên tổ chức sao cho dễ đổi thiết bị và dễ khóa theo ngữ cảnh

Khi đã hiểu tư duy này, học công cụ mới sẽ nhẹ hơn rất nhiều.

## Tại sao người mới hay viết input dính chặt vào game?

Vì cách đó cho kết quả nhanh.

Ví dụ:

- bấm phím là nhân vật chạy ngay
- bấm chuột là đạn bắn ngay

Điều này rất hấp dẫn ở giai đoạn đầu vì cảm giác “thành công nhanh”.

Nhưng khi game thêm:

- pause
- inventory
- cutscene
- stun
- rebind phím
- gamepad

thì code input dính cứng bắt đầu bộc lộ vấn đề.

## Lỗi sai thường gặp của người mới

### 1. Viết input dính chặt vào mọi hệ thống

Ví dụ script nào cũng tự đi đọc `Input`.

Hậu quả:

- khó kiểm soát
- khó tắt input theo trạng thái
- nhiều nơi xử lý trùng nhau

### 2. Không tách input và movement khi dự án lớn lên

Ban đầu có thể ổn.

Nhưng khi thêm animation, stamina, trạng thái, dash, climb, wall jump, code sẽ rối rất nhanh.

### 3. Dùng `GetKey` thay cho `GetKeyDown` mà không hiểu khác nhau

`GetKey` giữ trạng thái đang nhấn.

`GetKeyDown` chỉ đúng ở frame bắt đầu nhấn.

Nếu dùng sai, bạn có thể bị:

- nhảy liên tục
- mở menu nhiều lần
- bắn quá nhiều phát ngoài ý muốn

### 4. Không khóa input khi pause hoặc mở UI

Người chơi đang mở menu nhưng nhân vật vẫn chạy phía sau là lỗi trải nghiệm rất phổ biến.

### 5. Không nghĩ theo hành động mà nghĩ theo phím cứng

Ví dụ logic game ghi cứng “Space là nhảy”.

Về sau đổi sang gamepad hoặc cho người chơi tùy chỉnh phím sẽ rất khó.

### 6. Dùng input trong nhiều nơi khác nhau mà không có quy ước

Ví dụ một nơi đọc chuột để bắn, nơi khác cũng đọc chuột để tương tác, dẫn đến xung đột.

### 7. Không phân biệt input gameplay và input UI

Hai loại này có bối cảnh và mục tiêu khác nhau.

Nếu trộn lung tung, bạn sẽ gặp rất nhiều hành vi bất ngờ.

## Mẹo thực hành tốt cho người mới

- Bắt đầu đơn giản, nhưng đừng để mọi script tự đọc input.
- Đặt tên hành động rõ ràng theo ý nghĩa gameplay.
- Nếu dự án bắt đầu lớn, gom input về một nơi hoặc một lớp chịu trách nhiệm rõ ràng.
- Test ở các trạng thái: đang chơi, pause, game over, mở menu.
- Tự hỏi: nếu mai phải hỗ trợ gamepad, code này có chịu nổi không?

## Một checklist hữu ích khi code input

- Hành động này là nhấn một lần hay giữ liên tục?
- Hành động này có được phép xảy ra ở mọi trạng thái game không?
- Hệ thống nào nên thực thi hành động sau khi nhận input?
- Có cần chặn input vì stun, pause, cutscene không?
- Có đang đọc cùng một nút ở nhiều nơi gây xung đột không?

## Tóm tắt

- Input là dữ liệu người chơi gửi vào game qua thiết bị điều khiển.
- Input không chỉ là đọc phím, mà còn là bài toán tổ chức hành động và ngữ cảnh.
- Người mới có thể bắt đầu bằng các hàm `Input` cơ bản của Unity để hiểu nguyên lý.
- `Update` thường phù hợp để đọc input tức thời.
- Nơi đọc input không nhất thiết phải là nơi xử lý toàn bộ gameplay.
- Nên nghĩ theo hành động như `Jump`, `Attack`, `Interact` thay vì nghĩ cứng theo phím.
- Cần chú ý trạng thái game như pause, menu, stun, dialog.
- Tách input ra rõ ràng sẽ giúp dự án dễ mở rộng hơn nhiều.

## Tự kiểm tra

1. Input trong game là gì?
2. Vì sao nói input không chỉ là vài dòng đọc phím?
3. Vì sao nên nghĩ theo hành động thay vì nghĩ theo phím cứng?
4. `GetKey` và `GetKeyDown` khác nhau ở điểm nào?
5. Vì sao `Update` thường là nơi phù hợp để đọc input?
6. Nêu 3 ví dụ về input tức thời.
7. Nêu 3 ví dụ về input liên tục.
8. Vì sao không nên để mọi script tự đi đọc input?
9. Hãy nêu 2 tình huống mà game nên bỏ qua input gameplay.
10. Nếu mai game của bạn cần hỗ trợ gamepad, kiến trúc input hiện tại có dễ mở rộng không? Vì sao?

## Bài tập suy nghĩ thêm

- Hãy liệt kê toàn bộ hành động của người chơi trong một game platformer đơn giản.
- Sau đó nhóm chúng thành hai loại: gameplay và UI.
- Tự hỏi hành động nào chỉ nên hoạt động trong ngữ cảnh nhất định.
- Nếu phải hỗ trợ thêm mobile, bạn sẽ muốn giữ phần nào ổn định và chỉ thay phần nào?

Khi bạn hiểu đúng về input, bạn sẽ thấy việc mở rộng gameplay và đa nền tảng trở nên dễ kiểm soát hơn rất nhiều.
