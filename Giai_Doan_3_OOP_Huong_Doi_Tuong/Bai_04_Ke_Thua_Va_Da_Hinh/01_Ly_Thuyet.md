# Bài 4: Kế Thừa và Đa Hình

## Mục tiêu

- Hiểu kế thừa là gì và dùng để làm gì.
- Hiểu đa hình là gì trong code C#.
- Biết cách dùng `virtual`, `override`, kiểu cha tham chiếu kiểu con.
- Phân biệt tình huống nên dùng inheritance và composition.
- Thấy vì sao Unity và game architecture hiện đại thường ưu tiên composition hơn lạm dụng kế thừa.

## Vì sao bài này là một bước ngoặt?

Đây là bài mà nhiều người mới bắt đầu thấy OOP có vẻ "mạnh" hơn hẳn.

Bạn sẽ học được cách:

- chia sẻ logic chung
- viết code tổng quát hơn
- cho nhiều object phản ứng khác nhau với cùng lời gọi

Nhưng đây cũng là bài mà người mới rất dễ hiểu sai.

Lý do là kế thừa nhìn ban đầu cực tiện.

Chỉ cần một class cha, vài class con, mọi thứ có vẻ gọn ngay.

Sau đó cây kế thừa lớn dần và bắt đầu đau đầu.

Vì vậy bài này không chỉ nói về cú pháp.

Nó nói về quyết định thiết kế.

## Kế thừa là gì?

Kế thừa là cơ chế cho phép class con nhận dữ liệu và hành vi từ class cha.

Ví dụ:

```csharp
class Character
{
    public string Name;
    public int Health;

    public void Move()
    {
        Console.WriteLine(Name + " di chuyen");
    }
}

class Player : Character
{
    public int Level;
}
```

`Player` kế thừa từ `Character`, nên `Player` có sẵn:

- `Name`
- `Health`
- `Move()`

Ngoài ra `Player` còn có thêm `Level`.

## Cách hiểu bằng ngôn ngữ đời thường

Kế thừa phù hợp với quan hệ kiểu:

- là một loại của
- thuộc họ của

Ví dụ hợp lý:

- `Player` là một `Character`
- `Enemy` là một `Character`
- `Boss` là một `Enemy`

Đây là quan hệ "is-a".

Nếu câu nói "A là một B" nghe tự nhiên, kế thừa có thể hợp lý.

## Lợi ích lớn nhất của kế thừa

## 1. Chia sẻ phần chung

Nếu `Player`, `Enemy`, `NPC` đều có:

- tên
- máu
- di chuyển

thì đặt phần chung vào `Character` là hợp lý.

Bạn không phải copy code lặp lại ở nhiều class.

## 2. Tạo một điểm trừu tượng chung

Khi nhiều class cùng là `Character`, code khác có thể làm việc với chúng ở mức chung hơn.

Ví dụ:

```csharp
void PrintHealth(Character character)
{
    Console.WriteLine(character.Health);
}
```

Method này dùng được cho `Player`, `Enemy`, `Boss`.

## 3. Mở đường cho đa hình

Đây là lợi ích quan trọng nhất khi học tiếp.

Ta có thể viết một lời gọi chung nhưng mỗi class con phản ứng khác nhau.

## Đa hình là gì?

Đa hình nghĩa là cùng một lời gọi, nhiều object khác nhau có thể phản ứng khác nhau.

Ví dụ:

```csharp
class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character tan cong");
    }
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player chem kiem");
    }
}

class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Mage tung cau lua");
    }
}
```

Ta có thể viết:

```csharp
Character c1 = new Player();
Character c2 = new Mage();

c1.Attack();
c2.Attack();
```

Kết quả:

- `c1.Attack()` gọi bản của `Player`
- `c2.Attack()` gọi bản của `Mage`

Đó là đa hình.

## Tại sao đa hình mạnh trong game?

Game có rất nhiều object cùng họ nhưng hành vi khác nhau.

Ví dụ tất cả đều là `Enemy`, nhưng:

- slime nhảy cận chiến
- archer bắn xa
- mage bắn phép
- boss gọi lính

Nếu có một danh sách `List<Character>` hoặc `List<Enemy>`, bạn có thể duyệt chung:

```csharp
foreach (Character character in characters)
{
    character.Attack();
}
```

Mỗi object tự làm đúng hành vi của nó.

Code gọi không cần biết chi tiết từng loại.

Đó là điểm rất đẹp của đa hình.

## `virtual` và `override`

Trong C#, muốn class con ghi đè hành vi của class cha, bạn thường dùng:

- `virtual` ở class cha
- `override` ở class con

Ví dụ:

```csharp
class Enemy
{
    public virtual void Die()
    {
        Console.WriteLine("Enemy chet");
    }
}

class Boss : Enemy
{
    public override void Die()
    {
        Console.WriteLine("Boss no ra loot hiem");
    }
}
```

Đây là cơ chế nền tảng của đa hình trong C# hướng đối tượng.

## Ví dụ game thực tế

Hãy tưởng tượng bạn có hệ thống character cơ bản.

```csharp
class Character
{
    public string Name;
    public int Health;

    public virtual void Attack()
    {
        Console.WriteLine(Name + " tan cong co ban");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine(Name + " danh bang vu khi dang trang bi");
    }
}

class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine(Name + " can nguoc doi thu");
    }
}

class Boss : Enemy
{
    public override void Attack()
    {
        Console.WriteLine(Name + " dung don dac biet dien rong");
    }
}
```

Ở đây:

- phần chung nằm ở `Character`
- phần riêng nằm ở từng class con
- code gọi có thể làm việc qua kiểu cha

## Kế thừa rất tốt khi phần chung thật sự ổn định

Nếu mọi loại character đều chắc chắn có:

- tên
- máu
- logic nhận sát thương cơ bản

thì đặt chúng ở class cha thường rất hợp lý.

Kế thừa tốt nhất khi phần chung là bản chất cốt lõi, không phải sự trùng hợp tạm thời.

## Mặt trái của kế thừa

Đây là phần cực kỳ quan trọng.

Người mới thường thấy kế thừa tiện nên dùng cho mọi thứ.

Sau một thời gian, class cha bắt đầu phình to.

Ví dụ `Character` chứa:

- máu
- mana
- stamina
- bay
- bơi
- leo trèo
- bắn súng
- dùng phép
- mở shop
- nói chuyện

Rõ ràng không phải mọi character đều cần hết các khả năng đó.

Đây là dấu hiệu class cha đã trở thành "sọt rác dùng chung".

## Inheritance vs Composition

Đây là phần trọng tâm phải hiểu sâu.

## Inheritance

Inheritance nghĩa là xây cây cha con.

Ví dụ:

- `Character`
- `Enemy : Character`
- `Boss : Enemy`
- `FlyingBoss : Boss`

Ưu điểm:

- chia sẻ code nhanh
- dễ hiểu ở ví dụ nhỏ
- hỗ trợ đa hình rất tự nhiên

Nhược điểm:

- coupling mạnh với class cha
- cây class dễ phình to
- thay đổi ở class cha có thể ảnh hưởng rộng
- khó ghép tính năng linh hoạt

## Composition

Composition nghĩa là object được tạo thành từ nhiều thành phần nhỏ ghép lại.

Ví dụ một enemy có thể có:

- `HealthComponent`
- `MovementComponent`
- `AttackComponent`
- `LootDropComponent`

Đây là quan hệ "has-a".

Ví dụ:

- `Player` có inventory
- `Enemy` có health component
- `Boss` có phase controller

Ưu điểm:

- linh hoạt
- dễ thay thế từng phần
- giảm phụ thuộc cứng
- hợp cho game nhiều biến thể object

Nhược điểm:

- thiết kế ban đầu đòi hỏi tư duy tốt hơn
- có thể nhiều class nhỏ hơn
- ở bài rất nhỏ đôi khi thấy dài hơn kế thừa

## So sánh trực tiếp bằng ví dụ game

Giả sử bạn có nhiều loại enemy:

- biết bay
- biết bắn
- biết nổ
- có khiên

Nếu chỉ dùng kế thừa, bạn dễ rơi vào các class như:

- `FlyingEnemy`
- `ShootingEnemy`
- `FlyingShootingEnemy`
- `ShieldFlyingShootingEnemy`

Cây class sẽ bùng nổ.

Nếu dùng composition, bạn có thể ghép:

- component bay
- component bắn
- component nổ
- component khiên

Rồi lắp theo nhu cầu.

Cách này thường bền hơn với game thật.

## Khi nào nên dùng inheritance?

- Khi quan hệ cha con thật sự rõ và ổn định.
- Khi phần chung là cốt lõi chứ không phải ngẫu nhiên giống nhau.
- Khi cần đa hình tự nhiên trên một họ đối tượng.
- Khi số nhánh chưa quá phức tạp.

Ví dụ hợp lý:

- `Character` và các biến thể trực tiếp của nó
- `Item` và một vài nhóm item đơn giản

## Khi nào nên nghiêng về composition?

- Khi object có nhiều khả năng có thể ghép lắp.
- Khi số biến thể rất lớn.
- Khi bạn muốn tái sử dụng tính năng theo module.
- Khi game phát triển lâu dài và mechanic thay đổi thường xuyên.

Đây là lý do Unity nổi tiếng với hướng component-based.

## Vì sao Unity ưu tiên composition?

Unity xây dựng quanh `GameObject` và `Component`.

Một object có thể có:

- `Transform`
- `Renderer`
- `Collider`
- `AudioSource`
- script điều khiển

Ta không cần một cây kế thừa khổng lồ để biểu diễn mọi biến thể object.

Điều này cực hợp với game vì:

- object game hay thay đổi tính năng liên tục
- designer muốn lắp ghép nhanh
- gameplay thường có nhiều trạng thái và tổ hợp khả năng

## Sai lầm phổ biến khi dùng kế thừa

## 1. Lạm dụng kế thừa cho mọi thứ

Nhiều người nghĩ dùng OOP là phải dùng kế thừa càng nhiều càng tốt.

Đây là hiểu nhầm rất lớn.

Kế thừa chỉ là một công cụ.

## 2. Cây class quá sâu

Ví dụ:

- `Entity`
- `Character`
- `Enemy`
- `GroundEnemy`
- `RangedGroundEnemy`
- `FireRangedGroundEnemy`

Chỉ cần nhìn tên class đã thấy mệt.

## 3. Class cha ôm quá nhiều trách nhiệm

Khi class cha cố gắng phục vụ mọi class con, nó thường trở thành nơi chứa đủ thứ không liên quan.

## 4. Ghi đè lung tung nhưng không có quy ước rõ

Nếu method nào cũng `virtual`, class con nào cũng `override`, code sẽ khó đoán hành vi thực sự.

## 5. Dùng kế thừa khi quan hệ không phải "is-a"

Ví dụ `Inventory` kế thừa `Player` là vô lý.

Nếu câu "Inventory là một Player" nghe không đúng, rất có thể thiết kế sai.

## Một quy tắc thực tế rất hữu ích

Hãy tự hỏi hai câu:

1. Quan hệ này có thật sự là "là một" không?
2. Tôi có đang cố dùng kế thừa chỉ để tái sử dụng code không?

Nếu câu 2 đúng, hãy dừng lại và cân nhắc composition.

Tái sử dụng code không phải lúc nào cũng nên giải bằng cây cha con.

## Kết hợp inheritance và composition như thế nào?

Trong game thật, ta thường không chọn một trong hai tuyệt đối.

Ta thường dùng:

- một lớp inheritance vừa phải cho khái niệm nền
- composition cho các khả năng ghép lắp

Ví dụ:

- `Character` là class cha chung
- mỗi character có thêm các component như `WeaponHandler`, `BuffController`, `Inventory`

Đây thường là hướng cân bằng tốt.

## Tóm tắt tư duy thiết kế

- Dùng kế thừa để mô tả họ đối tượng có bản chất chung thật sự.
- Dùng đa hình để viết code chung mà vẫn hành xử khác nhau.
- Đừng dùng kế thừa chỉ vì muốn bớt copy code.
- Khi số biến thể tăng nhanh, composition thường bền hơn.
- Unity và nhiều kiến trúc game hiện đại nghiêng mạnh về composition.

## Ghi nhớ nhanh

- Inheritance = quan hệ cha con, "is-a".
- Polymorphism = cùng lời gọi, hành vi khác nhau theo object thật.
- `virtual` và `override` là công cụ quan trọng.
- Inheritance mạnh nhưng dễ bị lạm dụng.
- Composition linh hoạt hơn khi game có nhiều biến thể.
- Với game thật, thường dùng cả hai, nhưng ưu tiên composition khi cần mở rộng dài hạn.
