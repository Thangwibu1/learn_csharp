# Bài 5: Interface và Decoupling

## Mục tiêu

- Hiểu interface là gì ở góc nhìn thiết kế, không chỉ cú pháp.
- Hiểu decoupling là gì và vì sao nó quan trọng trong game.
- Biết cách dùng interface để giảm phụ thuộc giữa các class.
- Biết áp dụng `IDamageable`, `IInteractable`, `IMovable` trong tình huống thực tế.
- Thấy mối liên hệ giữa interface, composition và architecture sạch.

## Vì sao bài này rất quan trọng?

Khi mới viết code, người ta thường để class gọi thẳng class khác.

Ví dụ:

- `Sword` đánh thẳng `Enemy`
- `DoorButton` mở thẳng `Door`
- `QuestTracker` đọc trực tiếp `PlayerInventory`

Ban đầu điều đó rất tiện.

Nhưng sau này game có thêm:

- boss
- thùng gỗ
- training dummy
- cửa bí mật
- rương
- NPC có thể tương tác

Lúc đó code dễ trở thành một mạng phụ thuộc chằng chịt.

Chỗ nào cũng biết quá rõ về nhau.

Muốn thêm loại object mới lại phải sửa code cũ ở nhiều nơi.

Đó là lý do interface và decoupling cực kỳ quan trọng.

## Interface là gì?

Interface là một bản hợp đồng hành vi.

Nó nói rằng:

- nếu một class khai báo thực hiện interface này
- thì class đó phải cung cấp các method hoặc property đã cam kết

Ví dụ:

```csharp
interface IDamageable
{
    void TakeDamage(int damage);
}
```

Interface không nói object đó là `Enemy`, `Boss` hay `Crate`.

Nó chỉ nói:

- object này biết nhận sát thương

Đó là điều cực mạnh trong thiết kế.

## Cách hiểu đời thường

Ổ cắm điện không cần biết thiết bị đang cắm là:

- quạt
- nồi cơm
- máy sấy

Nó chỉ cần thiết bị tuân theo chuẩn cắm điện phù hợp.

Interface cũng vậy.

Code của bạn không cần biết object thật là gì.

Nó chỉ cần biết object đó có tuân theo hợp đồng hành vi cần thiết hay không.

## Decoupling là gì?

Decoupling là giảm phụ thuộc cứng giữa các phần của chương trình.

Nói dễ hiểu hơn:

- class A không nên biết quá nhiều chi tiết về class B
- class A chỉ nên biết thứ tối thiểu cần thiết để làm việc

Ví dụ xấu:

```csharp
class Sword
{
    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(10);
    }
}
```

Vấn đề là `Sword` chỉ đánh được `Enemy`.

Sau này muốn đánh:

- `Boss`
- `PlayerTrainingDummy`
- `BreakableCrate`

thì bạn phải sửa `Sword`.

Ví dụ tốt hơn:

```csharp
class Sword
{
    public void Hit(IDamageable target)
    {
        target.TakeDamage(10);
    }
}
```

Lúc này `Sword` không quan tâm target là class gì.

Miễn target thực hiện `IDamageable` là đủ.

Đó là decoupling.

## Lợi ích của decoupling trong game

## 1. Dễ mở rộng

Thêm object mới không phải sửa logic cũ quá nhiều.

Ví dụ thêm `Boss` chỉ cần cho `Boss` implement `IDamageable`.

## 2. Dễ tái sử dụng

Một hệ thống dùng interface có thể làm việc với nhiều loại object.

## 3. Dễ test

Bạn có thể tạo object giả hoặc mock đơn giản hơn khi code phụ thuộc vào interface thay vì class cụ thể.

## 4. Giảm hiệu ứng dây chuyền

Thay đổi trong một class cụ thể ít làm rung chuyển các class khác hơn.

## Interface không phải để thay thế mọi class

Đây là chỗ cần hiểu đúng.

Interface không phải thứ dùng cho mọi nơi chỉ để code trông "chuyên nghiệp".

Interface hữu ích khi:

- có nhiều object khác nhau cùng chia sẻ một hành vi
- bạn muốn code làm việc ở mức hành vi chứ không phụ thuộc loại cụ thể
- bạn muốn giảm coupling

Nếu chỉ có đúng một class, một hành vi đơn lẻ, chưa chắc cần interface ngay.

## Ví dụ cốt lõi: `IDamageable`

```csharp
interface IDamageable
{
    void TakeDamage(int damage);
}
```

Các object có thể implement:

- `Enemy`
- `Boss`
- `BreakableCrate`
- `TrainingDummy`

Ví dụ:

```csharp
class Enemy : IDamageable
{
    public int Health;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
```

Với design này, vũ khí hoặc đạn chỉ cần biết `IDamageable`.

## Ví dụ cốt lõi: `IInteractable`

```csharp
interface IInteractable
{
    void Interact();
}
```

Rất hợp cho:

- cửa
- rương
- NPC
- cần gạt
- bảng thông báo

Player khi raycast trúng object có thể chỉ cần hỏi:

- object này có phải `IInteractable` không?

Nếu có, gọi `Interact()`.

Player không cần phân biệt hết từng loại object tương tác cụ thể.

## Ví dụ game: hệ thống tương tác

```csharp
interface IInteractable
{
    void Interact();
}

class Door : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("Mo cua");
    }
}

class Chest : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("Mo ruong");
    }
}

class NPC : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("Bat dau hoi thoai");
    }
}
```

Player có thể viết logic chung:

```csharp
void TryInteract(IInteractable interactable)
{
    interactable.Interact();
}
```

Đây là code sạch hơn nhiều so với một đống `if` kiểm tra từng loại class.

## Interface giúp code theo khả năng thay vì theo loại cụ thể

Đây là câu cực quan trọng.

Thay vì hỏi:

- đây có phải `Door` không?
- đây có phải `Chest` không?
- đây có phải `NPC` không?

Ta hỏi:

- object này có thể tương tác không?
- object này có thể nhận sát thương không?
- object này có thể bị nhặt không?

Đó là cách nghĩ theo `capability`, tức khả năng/hành vi.

Đây là tư duy rất hợp với game và cũng rất hợp với composition.

## Mối quan hệ giữa interface và composition

Interface thường kết hợp rất tốt với composition.

Ví dụ thay vì kế thừa một cây class lớn, bạn có thể có nhiều object khác nhau cùng implement các interface khác nhau:

- `IDamageable`
- `IInteractable`
- `IHealable`
- `IMovable`

Một object có thể implement nhiều interface nếu đúng bản chất.

Ví dụ một `Boss` có thể vừa:

- nhận sát thương
- tương tác để bắt đầu cutscene
- phát tín hiệu khi chết

Interface giúp biểu diễn các khía cạnh hành vi mà không ép mọi thứ vào cùng một cây kế thừa.

## Interface và testability

Khi code phụ thuộc vào interface, bạn dễ viết bản giả để test hơn.

Ví dụ nếu một class vũ khí chỉ cần `IDamageable`, bạn có thể tạo object giả chỉ để kiểm tra xem sát thương có được gọi đúng hay không.

Điều này giúp code dễ kiểm chứng hơn nhiều so với việc vũ khí phụ thuộc trực tiếp vào `Enemy` thật với cả đống logic đi kèm.

## Interface và architecture sạch

Một nguyên tắc rất phổ biến là:

- phụ thuộc vào abstraction thay vì implementation cụ thể

Ở mức cơ bản, abstraction ở đây có thể chính là interface.

Ví dụ:

- `WeaponSystem` phụ thuộc vào `IDamageable`
- `InteractionSystem` phụ thuộc vào `IInteractable`

Nhờ đó, hệ thống bớt dính chặt vào từng class cụ thể.

## Không nên làm interface quá to

Ví dụ xấu:

```csharp
interface IGameObjectEverything
{
    void Move();
    void Attack();
    void Interact();
    void Save();
    void Load();
    void OpenShop();
}
```

Đây là interface ôm quá nhiều trách nhiệm.

Một object chỉ cần tương tác không nên buộc phải có cả `Attack()` hay `Save()`.

Interface tốt thường:

- nhỏ
- rõ ràng
- tập trung vào một khả năng

## Ví dụ interface nhỏ và rõ

```csharp
interface IDamageable
{
    void TakeDamage(int damage);
}

interface IInteractable
{
    void Interact();
}

interface ICollectible
{
    void Collect();
}
```

Thiết kế này linh hoạt hơn nhiều.

## Interface không thay thế hoàn toàn kế thừa

Ta không cần chọn một trong hai tuyệt đối.

Trong game thật, ta thường kết hợp:

- kế thừa cho phần bản chất chung
- interface cho các hành vi chéo giữa nhiều họ object

Ví dụ:

- `Character` là class cha
- `Enemy` và `Player` kế thừa `Character`
- riêng `Enemy`, `Boss`, `Crate` cùng implement `IDamageable`

Như vậy kiến trúc vừa có trục chung, vừa có khả năng mở rộng linh hoạt.

## Khi nào nên thêm interface?

Hãy cân nhắc interface khi:

1. Có nhiều loại object cần cùng một hành vi.
2. Bạn đang viết nhiều `if` theo loại class cụ thể.
3. Bạn muốn hệ thống gọi hành vi mà không biết class thật.
4. Bạn muốn code ít phụ thuộc hơn.

## Khi nào chưa cần interface?

- Mới có một class duy nhất và chưa có nhu cầu mở rộng.
- Quan hệ đang rất cục bộ và rõ ràng.
- Dùng interface chỉ để làm code trông phức tạp hơn mà không có lợi ích thực tế.

Interface là công cụ, không phải nghi thức bắt buộc.

## Sai lầm thường gặp của người mới

## 1. Dùng interface cho mọi thứ

Điều này làm code nhiều lớp abstraction không cần thiết.

## 2. Vẫn phụ thuộc vào class cụ thể dù đã có interface

Ví dụ method nhận `IDamageable` nhưng bên trong lại ép kiểu về `Enemy`.

Như vậy lợi ích decoupling giảm mạnh.

## 3. Tạo interface quá to

Một interface ôm quá nhiều trách nhiệm sẽ làm class implement trở nên nặng nề.

## 4. Không suy nghĩ theo hành vi

Nhiều người vẫn quen hỏi object là loại gì thay vì nó làm được gì.

Đây là khác biệt tư duy cốt lõi.

## 5. Nhầm interface với nơi chứa code dùng chung

Interface không phải nơi để chia sẻ code chung như class cha.

Nó là hợp đồng hành vi.

## Tư duy thiết kế cần nhớ

- Nếu hai object không cùng họ nhưng cùng hành vi, interface rất đáng cân nhắc.
- Nếu hệ thống chỉ cần biết object có thể làm gì, đừng bắt nó biết object là class nào.
- Interface hỗ trợ decoupling mạnh hơn.
- Decoupling giúp code dễ mở rộng, dễ test và dễ bảo trì hơn.

## Ghi nhớ nhanh

- Interface = hợp đồng hành vi.
- Decoupling = giảm phụ thuộc cứng giữa các class.
- `IDamageable` và `IInteractable` là hai ví dụ cực thực tế trong game.
- Hãy code theo khả năng của object, không chỉ theo tên class của object.
- Interface rất hợp khi đi cùng composition và game architecture sạch.
