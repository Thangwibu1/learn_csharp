# Bài 2: Struct và Class

## Mục tiêu

- Hiểu `struct` và `class` khác nhau ở bản chất lưu trữ và cách sao chép.
- Biết lúc nào nên chọn `struct`.
- Biết lúc nào nên chọn `class`.
- Thấy tác động của quyết định này lên code game.
- Tránh các lỗi phổ biến khi dùng value type và reference type.

## Vì sao bài này quan trọng?

Người mới thường thấy `struct` và `class` khá giống nhau vì cả hai đều có thể chứa:

- field
- method
- constructor
- property

Nhìn bề ngoài, chúng có vẻ chỉ là hai cú pháp khác tên.

Nhưng thực tế, sự khác biệt giữa chúng ảnh hưởng trực tiếp tới:

- cách dữ liệu được sao chép
- việc sửa dữ liệu có làm đổi object gốc không
- hiệu năng ở những chỗ nhạy cảm
- cách bạn thiết kế entity và data trong game

Nếu hiểu sai, bạn rất dễ gặp bug kiểu:

- sửa một biến tưởng là sửa bản gốc nhưng thực ra chỉ sửa bản copy
- truyền dữ liệu đi rồi không hiểu vì sao object khác không đổi
- dùng `struct` cho thứ quá phức tạp khiến code khó kiểm soát

## Điểm giống nhau

Cả `struct` và `class` đều có thể mô tả dữ liệu và hành vi.

Ví dụ `class`:

```csharp
class Player
{
    public string Name;
    public int Health;
}
```

Ví dụ `struct`:

```csharp
struct Position
{
    public int X;
    public int Y;
}
```

Cả hai đều có vẻ là "một kiểu dữ liệu tự định nghĩa".

Điểm khác nằm ở bản chất của kiểu.

## Khác biệt quan trọng nhất

## `class` là reference type

Điều này nghĩa là biến kiểu `class` thường giữ tham chiếu tới object.

Khi bạn gán biến này sang biến khác, hai biến có thể cùng trỏ tới cùng một object.

Ví dụ:

```csharp
class Enemy
{
    public int Health;
}

Enemy a = new Enemy();
a.Health = 100;

Enemy b = a;
b.Health = 50;
```

Kết quả:

- `a.Health` cũng sẽ là `50`
- vì `a` và `b` đang tham chiếu cùng một object

## `struct` là value type

Điều này nghĩa là khi gán biến này sang biến khác, dữ liệu thường được sao chép theo giá trị.

Ví dụ:

```csharp
struct Position
{
    public int X;
    public int Y;
}

Position p1 = new Position();
p1.X = 10;
p1.Y = 20;

Position p2 = p1;
p2.X = 99;
```

Kết quả:

- `p1.X` vẫn là `10`
- `p2.X` là `99`
- vì `p2` là bản sao của `p1`

Đây là khác biệt cốt lõi cần nhớ.

## Hiểu bằng ví dụ đời thường

Hãy tưởng tượng:

- `class` giống như tờ giấy ghi địa chỉ nhà
- `struct` giống như nguyên cái hộp nhỏ bạn cầm trong tay

Khi đưa tờ giấy địa chỉ cho người khác, cả hai vẫn đang nói về cùng một căn nhà.

Khi đưa nguyên cái hộp cho người khác bằng cách sao chép, người kia có bản riêng.

Trong code:

- `class` thường hành xử như tham chiếu tới cùng đối tượng
- `struct` thường hành xử như một bản dữ liệu độc lập

## Khi nào `class` phù hợp hơn?

`Class` phù hợp khi đối tượng:

- có nhiều state
- có vòng đời rõ ràng
- có danh tính riêng
- có nhiều hành vi phức tạp
- cần được chia sẻ hoặc tham chiếu từ nhiều nơi

Ví dụ trong game:

- `Player`
- `Enemy`
- `Boss`
- `Inventory`
- `Quest`
- `AudioManager`

Những thứ này thường có tính "thực thể".

Ta không chỉ quan tâm dữ liệu của chúng, mà còn quan tâm chính đối tượng đó là ai và đang ở trạng thái nào.

## Khi nào `struct` phù hợp hơn?

`Struct` hợp cho dữ liệu nhỏ, gọn, có ý nghĩa như một giá trị.

Ví dụ:

- vị trí
- màu sắc
- chỉ số nhỏ
- khoảng giá trị
- tọa độ ô lưới

Ví dụ:

```csharp
struct TilePosition
{
    public int Row;
    public int Column;
}
```

`TilePosition` thường chỉ là một gói dữ liệu nhỏ.

Nó không có danh tính riêng kiểu "đây là object sống lâu trong game world".

## Tư duy chọn lựa: danh tính hay giá trị?

Đây là câu hỏi rất hữu ích.

Hãy tự hỏi:

1. Tôi có đang quan tâm đây là đúng object đó không?
2. Hay tôi chỉ quan tâm dữ liệu bên trong nó?

Nếu bạn quan tâm danh tính và vòng đời, thường `class` phù hợp hơn.

Nếu bạn chỉ quan tâm một gói giá trị nhỏ, thường `struct` hợp hơn.

Ví dụ:

- `Player` là một thực thể cụ thể, nên thường là `class`
- `Vector2Int` hay tọa độ lưới chỉ là dữ liệu vị trí, nên rất hợp kiểu `struct`

## Ví dụ game: Player và Position

```csharp
class Player
{
    public string Name;
    public int Health;
    public Position SpawnPoint;
}

struct Position
{
    public int X;
    public int Y;
}
```

Ở đây:

- `Player` nên là `class`
- `Position` rất hợp là `struct`

Vì `Position` chỉ là một giá trị gồm `X` và `Y`.

## Sai khác khi truyền vào method

Với `class`, nhiều trường hợp khi truyền tham số, method có thể sửa object gốc.

Ví dụ:

```csharp
void DamageEnemy(Enemy enemy)
{
    enemy.Health -= 10;
}
```

Nếu `Enemy` là `class`, object gốc bị đổi.

Với `struct`, thường bạn đang làm việc trên bản sao.

Ví dụ:

```csharp
void Move(Position position)
{
    position.X += 1;
}
```

Nếu `Position` là `struct`, giá trị gốc bên ngoài có thể không đổi vì method nhận bản sao.

Đây là nguồn bug rất thường gặp với người mới.

## Ví dụ bug thực tế

```csharp
struct Stats
{
    public int Attack;
}

void Buff(Stats stats)
{
    stats.Attack += 10;
}
```

Người mới hay nghĩ gọi `Buff(playerStats)` sẽ làm `playerStats` mạnh lên.

Nhưng nếu `Stats` là `struct`, rất có thể bạn chỉ buff trên bản copy.

Muốn sửa thật, bạn phải hiểu rõ cách truyền tham số hoặc thiết kế lại cho hợp lý.

## Vì sao Unity dùng nhiều `struct` cho vector và color?

Trong Unity, các kiểu như `Vector2`, `Vector3`, `Color`, `Quaternion` là những ví dụ rất điển hình của dữ liệu giá trị nhỏ.

Chúng:

- gọn
- dùng cực nhiều
- chủ yếu mang ý nghĩa giá trị
- không cần danh tính riêng như entity game

Đó là lý do việc dùng `struct` ở các kiểu dữ liệu nền tảng là hợp lý.

## Vì sao entity gameplay thường là `class`?

Một `Enemy` trong game thường có:

- AI state
- máu hiện tại
- hiệu ứng trạng thái
- tham chiếu tới animation
- tham chiếu tới target
- vòng đời từ lúc spawn tới lúc chết

Đây là một thực thể có trạng thái phức tạp và danh tính rõ ràng.

Vì thế `class` phù hợp hơn rất nhiều.

## Ưu điểm của `class`

- Hợp với OOP truyền thống.
- Hợp với object có vòng đời dài.
- Dễ biểu diễn quan hệ giữa các object.
- Dễ dùng với kế thừa và đa hình.
- Phù hợp với hầu hết entity gameplay.

## Nhược điểm của `class`

- Dễ tạo phụ thuộc tham chiếu khó theo dõi nếu thiết kế kém.
- Hai biến có thể cùng trỏ tới một object khiến người mới khó đoán bug.
- Nếu lạm dụng object lớn ở khắp nơi, việc kiểm soát state sẽ khó.

## Ưu điểm của `struct`

- Rất hợp với dữ liệu nhỏ dạng giá trị.
- Sao chép độc lập, dễ hiểu nếu bài toán cần giá trị tách biệt.
- Tốt cho các kiểu dữ liệu nền tảng như vị trí, màu, chỉ số nhỏ.

## Nhược điểm của `struct`

- Dễ bị copy ngoài ý muốn.
- Nếu struct quá to hoặc quá nhiều state, code sẽ khó kiểm soát.
- Không phù hợp để biểu diễn object gameplay phức tạp.
- Người mới rất dễ nhầm lúc nào đang sửa bản gốc và lúc nào đang sửa bản sao.

## Một nguyên tắc thực tế

Nếu còn phân vân, với object gameplay chính, hãy ưu tiên `class`.

Chỉ chọn `struct` khi bạn thực sự thấy nó là một giá trị nhỏ, rõ ràng, độc lập.

Điều này giúp tránh nhiều bug khó chịu ở giai đoạn đầu học.

## Những dấu hiệu cho thấy bạn đang dùng `struct` sai

- Struct chứa quá nhiều field.
- Struct có quá nhiều method nghiệp vụ.
- Struct đại diện cho entity sống trong game world.
- Bạn liên tục phải giải thích cho bản thân vì sao sửa nó không có tác dụng.
- Bạn cần identity rõ ràng giữa các instance.

Nếu thấy các dấu hiệu này, rất có thể nên chuyển sang `class`.

## Những dấu hiệu cho thấy `struct` là lựa chọn tốt

- Dữ liệu rất nhỏ.
- Không cần danh tính riêng.
- Mang ý nghĩa giá trị.
- Copy ra bản mới là hành vi tự nhiên.
- Dùng nhiều trong tính toán hoặc làm dữ liệu phụ trợ.

## So sánh nhanh theo góc nhìn game

`class` thường dùng cho:

- player
- enemy
- weapon
- quest
- inventory
- manager

`struct` thường dùng cho:

- position
- range nhỏ
- color data
- tile coordinate
- stat snapshot nhỏ

## Lỗi sai thường gặp của người mới

## 1. Dùng `struct` cho object lớn

Ví dụ dùng `struct Enemy` với rất nhiều field và hành vi.

Điều này thường dẫn tới copy ngoài ý muốn và khó kiểm soát state.

## 2. Không hiểu sao chép theo giá trị

Nhiều bug đến từ việc gán `struct` sang biến mới rồi tưởng cả hai còn liên kết.

Chúng không còn liên kết như `class`.

## 3. Nghĩ `struct` nhanh hơn trong mọi trường hợp

Đây là hiểu lầm phổ biến.

Không có quy tắc đơn giản kiểu:

- `struct` luôn tốt hơn
- `class` luôn chậm hơn

Chọn sai mô hình dữ liệu còn hại hơn nhiều so với tối ưu sớm.

## 4. Dùng `class` cho mọi dữ liệu nhỏ mà không suy nghĩ

Không phải bug nghiêm trọng, nhưng đôi khi làm mô hình dữ liệu kém tự nhiên.

## 5. Không phân biệt thực thể và dữ liệu phụ trợ

Đây là kỹ năng thiết kế quan trọng.

`Enemy` là thực thể.

`Position` là dữ liệu phụ trợ.

Hiểu được khác biệt này sẽ giúp bạn chọn đúng kiểu.

## Cách tự hỏi trước khi viết

1. Đây có phải object gameplay chính không?
2. Nó có danh tính riêng không?
3. Nó có cần được chia sẻ ở nhiều nơi không?
4. Nó có phải chỉ là một gói dữ liệu nhỏ không?
5. Việc copy nó có phải hành vi tự nhiên không?

Nếu phần lớn câu trả lời nghiêng về danh tính và vòng đời, chọn `class`.

Nếu phần lớn nghiêng về dữ liệu giá trị nhỏ, chọn `struct`.

## Ghi nhớ nhanh

- `class` = reference type.
- `struct` = value type.
- `class` hợp cho entity phức tạp.
- `struct` hợp cho dữ liệu nhỏ dạng giá trị.
- Hiểu sai cách sao chép là nguồn bug rất phổ biến.
- Trong game, chọn kiểu dựa trên bản chất dữ liệu, không chỉ nhìn cú pháp.
