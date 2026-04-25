# Bài 4: State Machine cho AI Quái

## Mục tiêu

- Hiểu state machine là gì trong ngữ cảnh AI game.
- Biết vì sao state machine là cách tổ chức rất phổ biến cho hành vi quái.
- Hiểu lợi ích của việc tách hành vi theo trạng thái thay vì nhồi vào một `Update()` khổng lồ.
- Biết cách suy nghĩ về chuyển trạng thái, điều kiện chuyển, và trách nhiệm của từng state.
- Hiểu vì sao đây là một hướng OOP tốt khi làm AI mức cơ bản đến trung cấp.
- Tránh các lỗi phổ biến khi mới xây hệ thống state machine.

## Bức tranh tổng quan

Hãy tưởng tượng bạn làm một con quái đơn giản trong game platformer hoặc action RPG.

Con quái đó có thể:

- đứng canh
- đi tuần
- phát hiện người chơi
- đuổi theo
- tấn công
- bị choáng
- chết

Nếu bạn viết toàn bộ logic đó trong một hàm `Update()` dài hàng trăm dòng với vô số `if`, `else if`, `else`, code ban đầu có thể vẫn chạy.

Nhưng rất nhanh sau đó, bạn sẽ thấy:

- khó đọc
- khó sửa
- khó thêm trạng thái mới
- dễ sinh bug khi một điều kiện vô tình phá điều kiện khác

State machine giúp giải quyết bài toán này bằng một ý tưởng đơn giản:

Tại một thời điểm, AI ở một trạng thái chính rõ ràng.

Mỗi trạng thái có hành vi và điều kiện chuyển riêng.

## Khái niệm

State machine là cách tổ chức hành vi của một đối tượng dựa trên các trạng thái rõ ràng và các quy tắc chuyển đổi giữa chúng.

Ví dụ với quái cơ bản:

- `Idle`
- `Patrol`
- `Chase`
- `Attack`
- `Dead`

Ở mỗi thời điểm, quái thường chỉ ở một trạng thái chính.

Điều đó rất quan trọng vì nó giúp hành vi nhất quán hơn.

Ví dụ:

- nếu đang `Idle`, quái không nên vừa đồng thời là `Attack`
- nếu đã `Dead`, nó không nên tiếp tục `Chase`

Tư duy trạng thái giúp bạn tránh việc nhiều nhánh hành vi xung đột lẫn nhau.

## Tại sao phải dùng cái này?

### 1. Làm logic AI dễ đọc hơn

Khi trạng thái được tách rõ, bạn có thể nhìn vào tên state và hiểu quái đang làm gì.

### 2. Dễ bảo trì hơn

Nếu cần sửa cách quái tấn công, bạn tập trung vào state `Attack`.

Bạn không phải mò trong một khối `if else` khổng lồ.

### 3. Dễ thêm hành vi mới hơn

Ví dụ thêm state:

- `Stunned`
- `ReturnToSpawn`
- `Flee`

Nếu kiến trúc rõ ràng, việc thêm state mới sẽ nhẹ hơn nhiều.

### 4. Giảm xung đột logic

Khi AI chỉ có một trạng thái chính tại một thời điểm, bạn giảm nguy cơ nó vừa đuổi vừa đánh vừa đi tuần một cách lộn xộn.

### 5. Rất hợp với cách nghĩ OOP

Mỗi state có thể là một class riêng, mang trách nhiệm riêng.

Đây là cách tách hành vi rất sạch cho nhiều dự án.

## Liên hệ game thực tế

### Quái canh cổng trong game platformer

Nó có thể:

- đứng yên khi chưa thấy người chơi
- đuổi khi người chơi vào vùng phát hiện
- tấn công khi đủ gần
- quay lại vị trí cũ khi mất dấu

Đây là ví dụ state machine rất điển hình.

### Boss trong game hành động

Boss có thể có nhiều state phức tạp hơn:

- intro
- phase 1 attack
- phase transition
- phase 2 attack
- rage
- death

Nếu không dùng tư duy trạng thái, code boss sẽ cực kỳ rối.

### NPC trong game nhập vai

NPC cũng có thể dùng state machine ở mức đơn giản:

- đứng
- đi tuần
- nói chuyện
- bỏ chạy khi có nguy hiểm

## Tư duy cốt lõi: hành vi theo trạng thái

Khi dùng state machine, bạn không hỏi kiểu chung chung:

“Quái bây giờ nên làm gì trong đống hành vi này?”

Bạn hỏi cụ thể hơn:

“Quái hiện đang ở state nào?”

Từ đó:

- state hiện tại quyết định hành vi chính
- điều kiện rõ ràng quyết định khi nào chuyển state

Đây là một thay đổi tư duy rất lớn và rất hữu ích.

## Các thành phần cơ bản của một state machine AI

### 1. State hiện tại

Đây là trạng thái AI đang ở thời điểm hiện tại.

Ví dụ:

- `currentState = Idle`

### 2. Tập các state có thể có

Mỗi state đại diện cho một kiểu hành vi rõ ràng.

### 3. Điều kiện chuyển state

Ví dụ:

- nếu thấy người chơi thì từ `Idle` sang `Chase`
- nếu đủ gần thì từ `Chase` sang `Attack`
- nếu người chơi ra xa thì từ `Attack` quay về `Chase`
- nếu mất mục tiêu thì từ `Chase` sang `ReturnToSpawn`

### 4. Logic khi vào state

Ví dụ:

- bật animation phù hợp
- reset timer
- chuẩn bị dữ liệu cần thiết

### 5. Logic khi đang ở state

Ví dụ:

- di chuyển
- kiểm tra khoảng cách
- chờ cooldown

### 6. Logic khi rời state

Ví dụ:

- tắt hiệu ứng
- reset cờ tạm
- dọn dẹp đăng ký sự kiện nếu có

## Mô hình `Enter`, `Update`, `Exit`

Đây là cách tổ chức rất phổ biến cho state.

Mỗi state có thể có ba pha chính:

- `Enter`: khi vừa bước vào state
- `Update`: khi state đang hoạt động
- `Exit`: khi rời state

Ví dụ:

### `AttackState.Enter`

- bật animation đánh
- reset cooldown đòn đánh

### `AttackState.Update`

- kiểm tra khoảng cách với người chơi
- nếu hết tầm thì chuyển state

### `AttackState.Exit`

- dọn các cờ tạm liên quan đòn đánh

Mô hình này rất dễ đọc và dễ mở rộng.

## Ví dụ tư duy đơn giản

Giả sử bạn có một quái với ba state:

- `Idle`
- `Chase`
- `Attack`

Luồng suy nghĩ có thể là:

- đang `Idle`
- nếu thấy người chơi trong bán kính phát hiện thì sang `Chase`
- nếu ở `Chase` và khoảng cách đủ gần thì sang `Attack`
- nếu ở `Attack` mà người chơi chạy ra xa thì quay về `Chase`
- nếu mất dấu hoàn toàn thì về `Idle`

Chỉ riêng việc gọi tên rõ các state như vậy đã giúp code dễ hiểu hơn rất nhiều.

## Vì sao đây là OOP tốt?

OOP không phải cứ tạo nhiều class là tốt.

Điểm hay ở đây là tách trách nhiệm đúng cách.

Nếu mỗi state là một class riêng, bạn có thể đạt được:

- mỗi state chịu trách nhiệm cho hành vi của chính nó
- giảm độ phình của một class quái duy nhất
- dễ thay đổi từng hành vi riêng lẻ
- dễ tái sử dụng ý tưởng cho AI khác

Ví dụ:

- `IdleState`
- `ChaseState`
- `AttackState`

Mỗi class có vai trò rõ hơn so với một file `EnemyAI.cs` dài hàng nghìn dòng.

## Ví dụ mã giả ý tưởng

```csharp
public interface IEnemyState
{
    void Enter();
    void Tick();
    void Exit();
}
```

Mỗi state sẽ cài đặt giao diện này.

Enemy chính sẽ giữ state hiện tại và gọi `Tick` mỗi frame.

Điều quan trọng trong bài lý thuyết này không phải là thuộc lòng cú pháp.

Điều quan trọng là hiểu vì sao tách như vậy lại sạch hơn.

## Quy trình suy nghĩ khi thiết kế state machine cho quái

### Bước 1: Liệt kê các trạng thái thật sự cần có

Đừng tạo quá nhiều state chỉ vì thấy “ngầu”.

Hãy bắt đầu từ các trạng thái cốt lõi.

Ví dụ:

- Idle
- Patrol
- Chase
- Attack
- Dead

### Bước 2: Xác định ranh giới của từng state

Ví dụ:

- `Patrol` chịu trách nhiệm đi tuần
- `Chase` chịu trách nhiệm đuổi mục tiêu
- `Attack` chịu trách nhiệm xử lý hành vi tấn công

Nếu ranh giới mờ, state dễ chồng chéo trách nhiệm.

### Bước 3: Xác định điều kiện chuyển state

Hãy viết rõ ra bằng lời trước.

Ví dụ:

- thấy player thì đổi sang `Chase`
- đủ gần thì sang `Attack`
- player chết thì về `Idle`

### Bước 4: Xác định dữ liệu state cần truy cập

Ví dụ:

- transform của enemy
- transform của player
- tốc độ di chuyển
- tầm phát hiện
- tầm đánh

Không phải state nào cũng cần truy cập mọi thứ.

### Bước 5: Xác định điều gì diễn ra khi vào và rời state

Đây là bước người mới hay bỏ qua.

Ví dụ khi vào `Attack`:

- bật animation attack
- reset timer đánh

Ví dụ khi rời `Attack`:

- dọn cờ đang đánh

## Những lỗi sai thường gặp của người mới

### 1. Không tách state thành class riêng khi logic đã đủ lớn

Ban đầu có thể gộp được.

Nhưng nếu AI bắt đầu nhiều hành vi mà vẫn không tách, code sẽ nhanh chóng rất khó bảo trì.

### 2. Cho state truy cập lung tung mọi dữ liệu

State cần dữ liệu để hoạt động, nhưng nếu state muốn gì cũng sờ vào được, thiết kế sẽ lỏng lẻo.

### 3. Không rõ điều kiện chuyển state

Khi điều kiện mơ hồ, bạn dễ gặp:

- nhảy state liên tục
- state này cướp quyền state kia
- AI hành xử thất thường

### 4. Dùng state machine cho mọi thứ một cách quá mức

State machine rất hữu ích, nhưng không phải mọi hành vi nhỏ đều cần kiến trúc nặng.

Một object cực kỳ đơn giản đôi khi chưa cần tách quá sâu.

### 5. Không nghĩ tới `Enter` và `Exit`

Nếu chỉ có `Update` mà không có logic vào hoặc ra state, bạn dễ phải nhét nhiều cờ tạm vào nơi không phù hợp.

### 6. Nhầm lẫn giữa state và dữ liệu cảm biến

Ví dụ “có thấy player không” là dữ liệu hoặc điều kiện.

Nó không nhất thiết phải là một state riêng.

## Mẹo thực hành tốt cho người mới

- Bắt đầu với ít state nhưng rõ nghĩa.
- Viết điều kiện chuyển state bằng lời trước khi code.
- Đặt tên state theo hành vi thật rõ ràng.
- Nếu logic state lớn, hãy tách ra class riêng.
- Suy nghĩ theo `Enter`, `Tick`, `Exit` để luồng hành vi sạch hơn.
- Test từng chuyển trạng thái trong scene đơn giản trước.

## Một checklist hữu ích khi kiểm tra AI state machine

- Quái hiện có bao nhiêu state, có thừa không?
- Mỗi state có trách nhiệm rõ không?
- Điều kiện chuyển state có rõ và không chồng chéo không?
- Có state nào đang biết quá nhiều về hệ thống khác không?
- Khi vào và rời state, có cần reset hay bật tắt gì không?
- Nếu thêm một state mới, kiến trúc hiện tại có chịu nổi không?

## Tóm tắt

- State machine là cách tổ chức hành vi theo các trạng thái rõ ràng và điều kiện chuyển giữa chúng.
- Đây là cách rất phù hợp để làm AI quái trong game.
- Nó giúp code rõ hơn, dễ bảo trì hơn và dễ mở rộng hơn.
- Tại một thời điểm, AI thường chỉ nên có một trạng thái chính.
- Mỗi state có thể được thiết kế với các pha `Enter`, `Update` hoặc `Tick`, và `Exit`.
- Đây là một hướng OOP tốt vì giúp tách trách nhiệm thành các phần rõ ràng.
- Lỗi thường gặp là không tách đủ, điều kiện chuyển mơ hồ, hoặc cho state truy cập quá nhiều dữ liệu.

## Tự kiểm tra

1. State machine là gì?
2. Vì sao state machine phù hợp với AI quái?
3. Nếu nhồi toàn bộ logic AI vào một `Update()` dài, bạn sẽ gặp những vấn đề gì?
4. Hãy nêu 5 state có thể có của một con quái.
5. Vì sao tại một thời điểm quái thường chỉ nên có một trạng thái chính?
6. Ba pha phổ biến của một state là gì?
7. Vì sao nói state machine là một hướng OOP tốt?
8. Khi thiết kế state machine, bạn nên viết rõ điều gì trước khi code?
9. Hãy nêu 3 lỗi phổ biến của người mới khi làm state machine.
10. Nếu muốn thêm state `Stunned`, kiến trúc state machine sẽ giúp bạn dễ hơn ở điểm nào?

## Bài tập suy nghĩ thêm

- Hãy tự thiết kế bằng lời state machine cho một con quái đơn giản.
- Liệt kê ít nhất 4 state.
- Ghi rõ điều kiện chuyển giữa chúng.
- Sau đó tự hỏi state nào đang làm quá nhiều việc và state nào còn chưa rõ ranh giới.

Khi bạn hiểu chắc state machine, bạn sẽ có một nền tảng rất mạnh để làm AI game sạch, rõ và dễ mở rộng hơn nhiều.
