# Bài 1: Class và Object

## Mục tiêu

- Hiểu `class` là bản thiết kế của dữ liệu và hành vi.
- Hiểu `object` là thực thể cụ thể được tạo từ `class`.
- Phân biệt rõ field, method, constructor, state.
- Thấy vì sao OOP giúp code game đỡ rối hơn khi dự án lớn dần.
- Biết cách nhìn một đối tượng game bằng tư duy mô hình hóa.

## Bức tranh lớn

Khi mới học C#, nhiều người chỉ thấy biến, `if`, `for`, `while` và hàm.

Những thứ đó đủ để giải bài toán nhỏ.

Nhưng khi làm game, bạn nhanh chóng có rất nhiều thực thể:

- người chơi
- quái
- boss
- đạn
- vật phẩm
- nhiệm vụ
- cửa
- rương
- kỹ năng

Nếu mọi thứ chỉ là biến rời rạc trong `Main`, code sẽ phình ra rất nhanh.

Ví dụ kiểu code dễ loạn:

```csharp
string playerName = "Knight";
int playerHealth = 100;
int playerMana = 50;
int enemyHealth = 80;
int enemyDamage = 12;
```

Ban đầu nhìn vẫn ổn.

Nhưng sau đó bạn sẽ cần:

- thêm nhiều người chơi hoặc nhiều quái
- thêm hành vi tấn công
- thêm logic nhận sát thương
- thêm kiểm tra chết
- thêm hiệu ứng trạng thái

Đó là lúc `class` và `object` trở nên cần thiết.

## Class là gì?

`Class` là bản mô tả một kiểu đối tượng.

Nó nói rằng một đối tượng thuộc loại này:

- có dữ liệu gì
- có thể làm gì
- được tạo ra như thế nào

Ví dụ:

```csharp
class Player
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine(Name + " tan cong");
    }
}
```

Class `Player` chưa phải người chơi thật.

Nó chỉ là bản thiết kế nói rằng một người chơi sẽ có:

- tên
- máu
- hành động tấn công

## Object là gì?

`Object` là thực thể được tạo ra từ `class`.

Ví dụ:

```csharp
Player player1 = new Player();
Player player2 = new Player();
```

Lúc này:

- `player1` là một object
- `player2` là một object khác
- cả hai cùng chung bản thiết kế `Player`
- nhưng dữ liệu bên trong có thể khác nhau

Ví dụ gán dữ liệu:

```csharp
player1.Name = "Knight";
player1.Health = 100;

player2.Name = "Mage";
player2.Health = 70;
```

Hai object cùng là `Player`, nhưng trạng thái không giống nhau.

## Cách hiểu bằng ví dụ đời thường

Hãy tưởng tượng `class` là bản thiết kế của xe máy.

Bản thiết kế mô tả:

- xe có bánh
- có động cơ
- có màu
- có thể chạy

Nhưng bản thiết kế không phải chiếc xe thật ngoài đời.

Chiếc xe thật bạn mua và đang đi chính là `object`.

Từ cùng một thiết kế, nhà máy có thể tạo ra nhiều chiếc xe.

Trong code cũng vậy:

- `class` = thiết kế
- `object` = instance thật được tạo ra từ thiết kế

## Tại sao phải học phần này thật kỹ?

Vì gần như mọi kiến trúc game sau này đều xoay quanh việc mô hình hóa đối tượng.

Bạn sẽ liên tục tự hỏi:

- cái này nên là một class riêng không?
- object này nên giữ dữ liệu gì?
- hành vi nào nên nằm trong object?
- object nào chịu trách nhiệm thay đổi state?

Nếu hiểu mơ hồ ngay từ đây, các bài sau như kế thừa, interface, event, singleton sẽ bị học theo kiểu nhớ cú pháp nhưng không hiểu bản chất.

## Thành phần thường gặp trong một class

Một class thường có các phần sau.

## 1. Field

Field là dữ liệu bên trong object.

Ví dụ:

```csharp
public int Health;
public string Name;
```

Trong game, field thường lưu:

- máu
- mana
- level
- tốc độ
- sát thương
- trạng thái sống chết

## 2. Method

Method là hành động mà object có thể làm.

Ví dụ:

```csharp
public void TakeDamage(int damage)
{
    Health -= damage;
}
```

Một object game thường có method như:

- `Attack()`
- `Move()`
- `TakeDamage()`
- `Heal()`
- `Open()`
- `UseItem()`

## 3. Constructor

Constructor là nơi giúp khởi tạo object.

Ví dụ:

```csharp
class Enemy
{
    public string Name;
    public int Health;

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }
}
```

Khi tạo object:

```csharp
Enemy slime = new Enemy("Slime", 30);
```

Constructor giúp object có trạng thái hợp lệ ngay từ lúc sinh ra.

## 4. State

`State` là trạng thái hiện tại của object.

Ví dụ với `Player`, state có thể là:

- máu hiện tại
- mana hiện tại
- vị trí hiện tại
- có đang sống không
- có đang bị choáng không

State rất quan trọng trong game vì gameplay thực chất là trạng thái thay đổi theo thời gian.

## Class giúp gom dữ liệu và hành vi liên quan

Điểm mạnh lớn của OOP là gom thứ liên quan vào cùng một chỗ.

Ví dụ xấu:

```csharp
int playerHealth = 100;

void DamagePlayer(int damage)
{
    playerHealth -= damage;
}
```

Code này không quá sai ở bài nhỏ.

Nhưng nếu có nhiều người chơi, nhiều enemy, nhiều NPC, bạn sẽ cần thêm rất nhiều biến và hàm tách rời.

Ví dụ tốt hơn:

```csharp
class Player
{
    public int Health;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
```

Lúc này:

- dữ liệu máu nằm trong `Player`
- logic trừ máu cũng nằm trong `Player`
- code dễ đọc hơn vì trách nhiệm rõ hơn

## Một ví dụ game đơn giản

```csharp
class Enemy
{
    public string Name;
    public int Health;
    public int Damage;

    public void Attack()
    {
        Console.WriteLine(Name + " gay ra " + Damage + " sat thuong");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine(Name + " con " + Health + " mau");
    }
}
```

Object thực tế:

```csharp
Enemy slime = new Enemy();
slime.Name = "Slime";
slime.Health = 30;
slime.Damage = 5;

Enemy goblin = new Enemy();
goblin.Name = "Goblin";
goblin.Health = 60;
goblin.Damage = 10;
```

Từ một class `Enemy`, bạn tạo được nhiều quái với dữ liệu khác nhau.

## Một class không nhất thiết phải là nhân vật

Người mới hay nghĩ class chỉ dùng cho `Player` hay `Enemy`.

Thực ra class có thể đại diện cho nhiều thứ:

- nhân vật
- vật phẩm
- quest
- kỹ năng
- save data
- bảng cấu hình
- hệ thống quản lý

Ví dụ:

```csharp
class Item
{
    public string Id;
    public string DisplayName;
    public int Price;
}
```

Hoặc:

```csharp
class Quest
{
    public string Title;
    public bool IsCompleted;
}
```

## Mỗi object có vùng dữ liệu riêng

Đây là điểm rất quan trọng.

Nếu bạn có hai object từ cùng một class, mỗi object sẽ giữ dữ liệu của riêng nó.

Ví dụ:

```csharp
Enemy slime = new Enemy();
Enemy goblin = new Enemy();

slime.Health = 30;
goblin.Health = 60;
```

Khi `slime` mất máu, `goblin` không tự mất theo.

Điều này giúp ta mô hình hóa các thực thể độc lập trong game world.

## Class là cách mô hình hóa thế giới game

Lập trình game tốt thường bắt đầu bằng câu hỏi:

- trong game có những đối tượng nào?
- mỗi đối tượng có dữ liệu gì?
- mỗi đối tượng có trách nhiệm gì?

Ví dụ game RPG đơn giản có thể có:

- `Player`
- `Enemy`
- `Weapon`
- `Inventory`
- `Quest`
- `Shop`

Mỗi class nên phản ánh khái niệm thật trong game design.

Đó là lý do OOP rất tự nhiên khi làm game.

## Trách nhiệm của class

Một class tốt thường có trách nhiệm tương đối rõ.

Ví dụ:

- `Player` quản lý trạng thái và hành vi của người chơi
- `Weapon` quản lý thông tin và logic vũ khí
- `Inventory` quản lý danh sách item

Khi một class ôm quá nhiều việc, code bắt đầu có mùi thiết kế xấu.

Ví dụ xấu:

- `Player` vừa đánh nhau
- vừa lưu game
- vừa phát nhạc
- vừa quản lý UI

Đó là dấu hiệu class đang bị nhồi trách nhiệm.

## Mối liên hệ giữa object và bộ nhớ

Khi bạn viết:

```csharp
Player player = new Player();
```

Bạn đang yêu cầu chương trình tạo ra một object mới trong bộ nhớ.

Biến `player` giữ tham chiếu tới object đó.

Chi tiết sâu hơn về bộ nhớ sẽ học ở các giai đoạn khác, nhưng ngay lúc này bạn nên nhớ:

- `new` tạo instance mới
- mỗi lần `new` là một object riêng
- object tồn tại để giữ state và thực hiện hành vi

## OOP không chỉ là cú pháp

Người mới thường học OOP theo kiểu:

- nhớ `class`
- nhớ `new`
- nhớ `public`

Nhưng bản chất của OOP không nằm ở chữ khóa.

Bản chất là cách tổ chức chương trình theo đối tượng có state và hành vi.

Nếu bạn chỉ thuộc cú pháp mà không biết nên tạo class nào, đặt trách nhiệm ở đâu, thì chưa thật sự hiểu OOP.

## Một số nguyên tắc thực tế khi tạo class đầu tiên

Khi viết class cho game, hãy tự hỏi:

1. Object này đại diện cho thứ gì trong game?
2. Nó cần giữ dữ liệu gì?
3. Nó cần làm được gì?
4. Có hành vi nào không thuộc trách nhiệm của nó không?

Ví dụ `Enemy` nên có:

- tên
- máu
- sát thương
- nhận sát thương
- tấn công

Nhưng `Enemy` không nhất thiết phải:

- quản lý toàn bộ danh sách quest
- phát nhạc menu
- lưu file save

## Sai lầm thường gặp của người mới

## 1. Nhầm class với object

Đây là lỗi nền tảng nhất.

- `class` là mẫu
- `object` là instance thực tế

Nếu nhầm chỗ này, các bài sau sẽ rất khó hiểu.

## 2. Viết mọi logic vào `Main`

Người mới thường làm thế này vì cảm giác nhanh.

Nhưng khi bài lớn lên, code sẽ:

- dài
- khó tìm lỗi
- khó tái sử dụng
- khó mở rộng

## 3. Tạo class nhưng không cho nó hành vi

Ví dụ chỉ có:

```csharp
class Player
{
    public int Health;
}
```

Rồi toàn bộ logic trừ máu, hồi máu, chết lại nằm ngoài hết.

Khi đó class chỉ là túi dữ liệu thụ động.

Không phải lúc nào cũng sai, nhưng thường chưa tận dụng được OOP.

## 4. Nhồi quá nhiều dữ liệu không liên quan vào một class

Ví dụ `Player` chứa cả:

- máu
- inventory
- save system
- âm thanh game
- logic cửa hàng

Đó là dấu hiệu cần tách class.

## 5. Đặt tên class mơ hồ

Tên như `DataManagerThing` hay `GameStuff` làm code rất khó hiểu.

Tên class nên phản ánh đúng vai trò.

Ví dụ tốt hơn:

- `Player`
- `Enemy`
- `Inventory`
- `QuestTracker`

## Cách tự luyện tư duy class và object

Khi gặp một game mechanic mới, hãy thử mô hình hóa bằng lời trước khi code.

Ví dụ hệ thống rương:

- Rương có trạng thái đóng hay mở
- Rương chứa item
- Rương có thể được mở

Từ đó nghĩ ra class:

```csharp
class Chest
{
    public bool IsOpened;
    public List<string> Items;

    public void Open()
    {
    }
}
```

Việc mô hình hóa rõ ràng trước sẽ giúp code bớt chắp vá.

## Tóm tắt tư duy quan trọng

- `Class` mô tả một loại đối tượng.
- `Object` là thực thể cụ thể của loại đó.
- Class thường chứa dữ liệu và hành vi liên quan.
- Mỗi object có state riêng.
- OOP giúp mô hình hóa game world rõ ràng hơn.
- Tổ chức đúng từ đầu sẽ giúp các bài sau như properties, kế thừa, interface và event dễ hiểu hơn rất nhiều.

## Ghi nhớ nhanh

- Class = bản thiết kế.
- Object = thứ được tạo ra từ bản thiết kế.
- Field = dữ liệu.
- Method = hành vi.
- Constructor = cách khởi tạo.
- State = tình trạng hiện tại của object.
- OOP mạnh vì nó tổ chức thế giới game thành các đối tượng có trách nhiệm rõ ràng.
