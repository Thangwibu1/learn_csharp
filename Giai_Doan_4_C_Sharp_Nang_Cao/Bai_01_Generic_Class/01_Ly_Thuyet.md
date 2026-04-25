# Bài 1: Generic Class

## Mục tiêu

- Hiểu generic là gì ở mức bản chất.
- Biết vì sao generic tốt hơn dùng `object` trong rất nhiều trường hợp.
- Hiểu ý nghĩa của `<T>` và các tên kiểu tổng quát.
- Biết generic giúp tái sử dụng code và giữ type safety như thế nào.
- Thấy vai trò của generic trong code game và architecture.

## Vì sao bài này quan trọng?

Khi dự án còn nhỏ, bạn có thể viết class riêng cho từng kiểu dữ liệu.

Ví dụ:

- hộp chứa `int`
- hộp chứa `string`
- hộp chứa `Player`

Nhưng khi số kiểu dữ liệu tăng, bạn sẽ thấy một vấn đề lớn:

- logic giống nhau
- chỉ khác kiểu dữ liệu

Nếu cứ viết lại nhiều lần, code bị lặp.

Nếu chuyển sang dùng `object`, code lại mất an toàn kiểu.

Generic ra đời để giải bài toán này.

## Generic là gì?

Generic cho phép bạn viết code tổng quát với một kiểu chưa xác định trước.

Sau đó khi sử dụng, bạn gắn kiểu thật vào.

Ví dụ:

```csharp
class Box<T>
{
    public T Value;
}
```

Ở đây `T` là kiểu dữ liệu đại diện.

Khi dùng:

```csharp
Box<int> scoreBox = new Box<int>();
Box<string> nameBox = new Box<string>();
Box<Player> playerBox = new Box<Player>();
```

Ta có một mẫu class duy nhất nhưng dùng cho nhiều kiểu khác nhau.

## Cách hiểu đơn giản

Hãy tưởng tượng bạn có một mẫu hộp thông minh.

Mẫu hộp này không ghi sẵn là chỉ đựng táo hay chỉ đựng sách.

Nó chỉ nói:

- tôi là một cái hộp chứa một loại đồ nào đó

Khi dùng thực tế, bạn quyết định loại đó là gì.

Đó chính là generic.

## Tại sao không chỉ dùng `object`?

Người mới hay hỏi:

- nếu muốn chứa nhiều kiểu, sao không dùng `object` luôn?

Ví dụ:

```csharp
class Box
{
    public object Value;
}
```

Vấn đề là `object` quá chung.

Nó dẫn tới:

- phải ép kiểu thủ công
- dễ sai kiểu ở runtime
- IDE hỗ trợ kém hơn
- code khó đọc hơn

Ví dụ:

```csharp
Box box = new Box();
box.Value = 123;

int number = (int)box.Value;
```

Nếu ai đó lỡ gán string vào rồi vẫn ép về `int`, bạn sẽ gặp lỗi runtime.

Generic tránh điều đó vì compiler biết kiểu từ đầu.

## Type safety là lợi ích cực lớn

Với generic:

```csharp
Box<int> box = new Box<int>();
box.Value = 123;
```

Compiler hiểu rõ `Value` là `int`.

Bạn không thể vô tình gán:

```csharp
box.Value = "abc";
```

Lỗi sẽ được bắt sớm ngay lúc code.

Đây là điều rất quan trọng trong dự án lớn.

## Generic giúp giảm lặp code

Không có generic, bạn rất dễ phải viết các class kiểu:

```csharp
class IntBox
{
    public int Value;
}

class StringBox
{
    public string Value;
}

class PlayerBox
{
    public Player Value;
}
```

Toàn bộ logic giống nhau, chỉ khác kiểu.

Generic giúp gom lại thành một mẫu duy nhất.

## Generic class trong game

Game có rất nhiều cấu trúc có thể dùng generic:

- repository dữ liệu
- object pool
- event bus
- danh sách quản lý object
- cache tài nguyên
- wrapper dữ liệu

Ví dụ repository:

```csharp
class Repository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }
}
```

Ta có thể dùng cho:

- `Repository<ItemData>`
- `Repository<QuestData>`
- `Repository<EnemyData>`

## Generic và collections

Bạn đã thấy generic mỗi ngày dù chưa để ý.

Ví dụ:

- `List<T>`
- `Dictionary<TKey, TValue>`
- `Queue<T>`
- `Stack<T>`

Những collection quen thuộc này chính là ví dụ rất mạnh của generic trong thư viện C#.

Ví dụ:

```csharp
List<int> scores = new List<int>();
List<string> names = new List<string>();
List<Player> players = new List<Player>();
```

Một kiểu danh sách, nhiều kiểu dữ liệu.

## Generic giúp architecture gọn hơn

Hãy tưởng tượng bạn có ba hệ thống gần giống nhau:

- pool cho đạn
- pool cho hiệu ứng nổ
- pool cho enemy nhỏ

Nếu không dùng generic, bạn dễ viết ba pool class gần như giống hệt nhau.

Nếu dùng generic:

```csharp
class ObjectPool<T>
{
    private Queue<T> items = new Queue<T>();

    public void Add(T item)
    {
        items.Enqueue(item);
    }

    public T Get()
    {
        return items.Dequeue();
    }
}
```

Logic chung được tái sử dụng tốt hơn nhiều.

## Generic method

Không chỉ class, method cũng có thể generic.

Ví dụ:

```csharp
T GetFirst<T>(List<T> items)
{
    return items[0];
}
```

Điều này rất hữu ích khi muốn viết logic tổng quát nhưng không cần cả class generic riêng.

## Generic và khả năng đọc code

Nhiều người mới thấy `<T>` là sợ vì trông hơi trừu tượng.

Thực ra generic thường làm code dễ đọc hơn dùng `object`.

Ví dụ:

```csharp
Repository<ItemData>
```

nhìn vào là biết repository này chứa `ItemData`.

So với:

```csharp
RepositoryUsingObject
```

bạn phải vào sâu bên trong mới biết dữ liệu thật là gì.

## Ý nghĩa của tên `T`

`T` chỉ là một tên đại diện cho kiểu.

Bạn cũng có thể thấy:

- `TItem`
- `TKey`
- `TValue`
- `TEntity`

Tên càng rõ, code càng dễ hiểu.

Ví dụ:

```csharp
class DataCache<TKey, TValue>
{
}
```

Tên này dễ đoán hơn nhiều so với viết bừa nhiều ký hiệu.

## Generic constraints là gì?

Đôi khi bạn không muốn `T` là bất kỳ kiểu nào.

Bạn muốn giới hạn nó.

Ví dụ bạn chỉ muốn `T` là class, hoặc phải có constructor rỗng, hoặc phải kế thừa một kiểu nào đó.

Đây là lúc dùng constraints.

Ví dụ ý tưởng:

```csharp
where T : new()
```

Hoặc:

```csharp
where T : IDamageable
```

Với người mới, chưa cần nhớ hết mọi dạng, nhưng cần biết rằng generic không phải lúc nào cũng hoàn toàn tự do.

Bạn có thể đặt luật để generic an toàn và hữu ích hơn.

## Ví dụ game dùng constraint

Giả sử bạn viết một hệ thống chỉ làm việc với object có thể nhận sát thương.

```csharp
class DamageLogger<T> where T : IDamageable
{
}
```

Ý tưởng là class này chỉ chấp nhận các kiểu phù hợp với hành vi cần thiết.

Đây là cách generic và interface phối hợp rất đẹp.

## Generic không có nghĩa là mọi thứ phải tổng quát hóa

Đây là cảnh báo quan trọng.

Người mới học generic đôi khi bị cuốn vào việc generic hóa mọi thứ.

Ví dụ một class chỉ dùng đúng một nơi, rõ ràng, đơn giản, nhưng vẫn cố biến nó thành generic cho "xịn".

Kết quả là code khó đọc hơn mà không có lợi ích thật.

Generic chỉ nên dùng khi:

- logic thật sự giống nhau giữa nhiều kiểu
- bạn muốn tái sử dụng mà vẫn giữ type safety
- việc tổng quát hóa làm code rõ hơn, không phải tối nghĩa hơn

## Ví dụ thực tế: inventory slot tổng quát

Bạn có thể có ý tưởng như:

```csharp
class Slot<T>
{
    public T Item { get; private set; }

    public void SetItem(T item)
    {
        Item = item;
    }
}
```

Sau đó dùng cho:

- `Slot<ItemData>`
- `Slot<SkillData>`

Nếu hai hệ thống thật sự cùng một logic container, generic là lựa chọn tốt.

## Generic và hiệu năng ở mức cơ bản

Ở giai đoạn này, điều quan trọng nhất không phải tối ưu vi mô mà là tránh thiết kế tệ.

Tuy nhiên, generic thường giúp tránh một số vấn đề của việc dùng `object`, đặc biệt liên quan đến boxing/unboxing với value type.

Bạn chưa cần đào quá sâu, nhưng nên nhớ:

- generic không chỉ giúp code gọn
- nó còn giúp code an toàn kiểu và tự nhiên hơn

## Sai lầm thường gặp của người mới

## 1. Thấy `<T>` là sợ

Hãy nhớ:

- `T` chỉ là chỗ giữ chỗ cho kiểu dữ liệu
- không có gì huyền bí ở đây

## 2. Dùng `object` thay cho generic

Điều này làm mất lợi ích type safety và làm code khó bảo trì hơn.

## 3. Generic hóa quá mức

Không phải class nào cũng cần generic.

Nếu bài toán không lặp logic giữa nhiều kiểu, generic có thể là dư thừa.

## 4. Đặt tên generic type mơ hồ

Tên như `X`, `Y`, `Z` trong code nghiệp vụ dễ làm người đọc khó hiểu.

## 5. Không thấy mối liên hệ giữa generic và thư viện chuẩn

Bạn đang dùng generic mỗi ngày qua `List<T>`, `Dictionary<TKey, TValue>`.

Nhận ra điều này giúp generic bớt xa lạ hơn rất nhiều.

## Tư duy quan trọng cần nhớ

- Generic giúp viết một logic cho nhiều kiểu dữ liệu khác nhau.
- Generic tốt hơn `object` khi muốn giữ type safety.
- Generic rất mạnh trong architecture vì giảm lặp code.
- Generic thường kết hợp tốt với interface và collections.
- Chỉ dùng generic khi sự tổng quát hóa mang lại lợi ích thật.

## Ghi nhớ nhanh

- Generic = viết code tổng quát theo kiểu dữ liệu.
- `<T>` = kiểu đại diện sẽ được thay bằng kiểu thật lúc dùng.
- Lợi ích lớn: tái sử dụng code và type safety.
- `List<T>` và `Dictionary<TKey, TValue>` là ví dụ generic quen thuộc nhất.
- Trong game, generic rất hữu ích cho repository, pool, cache và container tổng quát.
