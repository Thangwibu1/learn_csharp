# Bài 3: Properties

## Mục tiêu

- Hiểu property là gì và vì sao nó tồn tại.
- Phân biệt property với field public.
- Biết dùng `get`, `set`, `private set` đúng chỗ.
- Thấy vai trò của property trong đóng gói dữ liệu.
- Biết cách dùng property để giữ state game hợp lệ.

## Vì sao bài này quan trọng?

Người mới rất thích viết như sau vì nhanh:

```csharp
public int Health;
public int Level;
public int Mana;
```

Ban đầu cách này không gây vấn đề lớn.

Nhưng khi dự án tăng độ phức tạp, dữ liệu gameplay cần được bảo vệ.

Ví dụ:

- máu không được âm
- mana không được vượt ngưỡng tối đa
- level không được tự sửa từ mọi nơi
- trạng thái boss không nên bị code UI đổi bừa

Nếu mọi field đều `public`, bất kỳ đoạn code nào cũng có thể sửa trực tiếp.

Đó là lý do property trở thành công cụ rất quan trọng trong OOP.

## Property là gì?

Property là cơ chế cho phép truy cập dữ liệu theo cách có kiểm soát hơn field public.

Ví dụ cơ bản:

```csharp
public int Health { get; set; }
```

Nó trông giống field, nhưng thực chất là một cặp cơ chế truy cập:

- `get` để đọc
- `set` để ghi

## Cách hiểu đơn giản

Field public giống như để két sắt mở toang.

Ai đi qua cũng có thể đụng vào tiền bên trong.

Property giống như có quầy giao dịch ở trước két.

Người ngoài muốn xem hoặc sửa phải đi qua điểm kiểm soát.

Nhờ đó bạn có thể:

- cho đọc nhưng không cho ghi
- kiểm tra dữ liệu trước khi ghi
- thêm logic phụ khi dữ liệu đổi

## Ví dụ field public và vấn đề của nó

```csharp
class Player
{
    public int Health;
}
```

Lúc này mọi nơi đều có thể làm:

```csharp
player.Health = -999;
player.Health = 100000;
```

Nếu game không cho phép điều đó, object đã bị đưa vào trạng thái sai.

## Ví dụ dùng property tốt hơn

```csharp
class Player
{
    public int Health { get; private set; }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}
```

Lúc này:

- bên ngoài đọc được `Health`
- nhưng không thể tùy ý `set`
- việc đổi máu phải đi qua method hoặc logic được kiểm soát

Đó chính là đóng gói dữ liệu.

## Property gắn chặt với encapsulation

Một trong những ý quan trọng của OOP là `encapsulation`, tức đóng gói và bảo vệ trạng thái bên trong object.

Object nên tự bảo vệ tính hợp lệ của mình.

Ví dụ `Player` biết rằng:

- máu không âm
- máu không vượt quá máu tối đa
- level không nhỏ hơn 1

Thay vì để code ngoài nhớ hết các luật đó, ta để object tự kiểm soát qua property và method.

## Các dạng property thường gặp

## 1. Auto-property

```csharp
public string Name { get; set; }
```

Đây là dạng gọn nhất.

Phù hợp khi:

- dữ liệu đơn giản
- chưa cần logic đặc biệt
- không có ràng buộc phức tạp

## 2. Chỉ cho đọc từ bên ngoài

```csharp
public int Health { get; private set; }
```

Rất hay dùng trong game.

Vì nhiều dữ liệu nên được công khai để nơi khác xem, nhưng không nên cho sửa trực tiếp.

Ví dụ:

- UI cần đọc máu người chơi
- nhưng UI không nên được tự đặt lại máu

## 3. Property có logic trong `set`

```csharp
private int health;

public int Health
{
    get { return health; }
    set
    {
        if (value < 0)
        {
            health = 0;
        }
        else
        {
            health = value;
        }
    }
}
```

Dạng này hữu ích khi cần kiểm soát dữ liệu đầu vào.

## 4. Computed property

Property không nhất thiết lưu dữ liệu riêng.

Nó có thể tính từ dữ liệu khác.

Ví dụ:

```csharp
public bool IsDead
{
    get { return Health <= 0; }
}
```

Ở đây `IsDead` không cần field riêng.

Nó được tính từ `Health`.

Đây là cách làm rất sạch trong nhiều bài toán gameplay.

## Vì sao property tốt hơn public field trong thiết kế game?

## 1. Bảo vệ state

Property giúp object không bị rơi vào trạng thái vô lý.

Ví dụ:

- HP âm
- XP âm
- tốc độ âm
- số item nhỏ hơn 0

## 2. Giảm phụ thuộc vào chi tiết bên trong

Nếu hôm nay bạn dùng field public, sau này muốn thêm kiểm tra dữ liệu sẽ phải sửa nhiều nơi.

Nếu ngay từ đầu dùng property, code ngoài vẫn truy cập cùng cú pháp quen thuộc hơn.

## 3. Dễ mở rộng

Sau này bạn có thể thêm:

- log
- event khi dữ liệu đổi
- clamp giá trị
- validation

Mà không cần đổi cách code ngoài đọc dữ liệu.

## 4. Giúp class tự chịu trách nhiệm

Một object tốt không nên để code ngoài tùy tiện phá luật nội bộ của nó.

Property là một lớp bảo vệ nhẹ nhưng rất hiệu quả.

## Ví dụ thực tế: Health trong game

```csharp
class Player
{
    public int MaxHealth { get; private set; }
    public int Health { get; private set; }

    public Player(int maxHealth)
    {
        MaxHealth = maxHealth;
        Health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
        Health += amount;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }
}
```

Ở đây property giúp đảm bảo:

- máu không âm
- máu không vượt trần
- nơi ngoài chỉ xem chứ không ghi trực tiếp

## Property và UI

UI thường chỉ cần đọc dữ liệu.

Ví dụ thanh máu chỉ cần biết `player.Health` là bao nhiêu.

UI không nên là nơi đổi logic máu.

Thiết kế tốt là:

- gameplay code đổi máu
- property công khai giá trị để UI đọc
- nếu cần, event báo UI cập nhật

Điều này làm luồng dữ liệu sạch hơn.

## Property và save data

Không phải lúc nào property cũng phải có logic phức tạp.

Với những object thuần dữ liệu lưu file, auto-property cũng rất hữu ích.

Ví dụ:

```csharp
class PlayerSaveData
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Gold { get; set; }
}
```

Ở đây mục tiêu là dữ liệu gọn, dễ serialize.

Tức là property vẫn hữu ích ngay cả khi logic validation không nhiều.

## Không phải lúc nào field public cũng sai tuyệt đối

Với bài tập cực nhỏ hoặc dữ liệu rất đơn giản, field public có thể chấp nhận được để học nhanh.

Nhưng nếu mục tiêu là viết code có thể mở rộng, property là thói quen tốt hơn nhiều.

Đặc biệt trong game, state thay đổi liên tục nên việc kiểm soát dữ liệu rất quan trọng.

## Khi nào nên dùng `private set`?

`private set` là lựa chọn cực thực dụng khi:

- bạn muốn nơi khác đọc được
- nhưng chỉ chính class đó được quyền sửa

Ví dụ rất điển hình:

- `Health`
- `Mana`
- `Level`
- `CurrentAmmo`
- `IsDead`

Đây là cách cân bằng giữa tính công khai và tính an toàn.

## Khi nào nên dùng property chỉ đọc?

Ví dụ:

```csharp
public bool IsDead
{
    get { return Health <= 0; }
}
```

Trường hợp này không cần `set` vì đây là dữ liệu suy ra.

Đây là phong cách thiết kế tốt vì tránh trùng lặp state.

Nếu đã có `Health`, nhiều khi không cần thêm field `IsDead` riêng trừ khi có lý do cụ thể.

## Khi nào nên thêm logic vào `set`?

Hãy thêm logic trong `set` khi bản thân việc ghi dữ liệu cần luật.

Ví dụ:

- clamp giá trị từ 0 đến max
- cấm giá trị âm
- phát event khi đổi
- ghi log debug

Tuy nhiên không nên nhồi logic quá nặng vào property.

Nếu xử lý quá nhiều bước, method riêng sẽ dễ đọc hơn.

## Property không thay thế hoàn toàn method

Đây là chỗ nhiều người mới nhầm.

Property tốt cho việc biểu diễn dữ liệu hoặc truy cập dữ liệu có kiểm soát.

Nhưng hành động nghiệp vụ rõ ràng vẫn nên là method.

Ví dụ tốt:

- `Health { get; private set; }`
- `TakeDamage(int damage)`
- `Heal(int amount)`

Ví dụ ít tốt hơn:

- cho phép `Health` set trực tiếp từ ngoài rồi hy vọng mọi nơi tự nhớ clamp

Method làm ý đồ rõ hơn.

## Ví dụ game: ammo

```csharp
class Weapon
{
    public int MaxAmmo { get; private set; }
    public int CurrentAmmo { get; private set; }

    public Weapon(int maxAmmo)
    {
        MaxAmmo = maxAmmo;
        CurrentAmmo = maxAmmo;
    }

    public void Shoot()
    {
        if (CurrentAmmo <= 0)
        {
            return;
        }

        CurrentAmmo--;
    }

    public void Reload()
    {
        CurrentAmmo = MaxAmmo;
    }
}
```

Thiết kế này rõ hơn nhiều so với để code ngoài tự tăng giảm `CurrentAmmo` lung tung.

## Sai lầm thường gặp của người mới

## 1. Public field cho mọi thứ

Đây là lỗi phổ biến nhất.

Hậu quả là bất kỳ chỗ nào cũng có thể đưa object vào trạng thái sai.

## 2. Dùng property nhưng vẫn `set` public vô tội vạ

Nếu `Health` vẫn `public set`, lợi ích bảo vệ dữ liệu giảm đi nhiều.

## 3. Không phân biệt dữ liệu và hành vi

Property không nên gánh hết logic gameplay.

Hành vi như nhận sát thương, hồi máu, lên cấp nên có method rõ ràng.

## 4. Viết `set` quá phức tạp

Nếu trong `set` có quá nhiều nhánh xử lý, gọi hệ thống khác, phát âm thanh, cập nhật quest, code sẽ khó theo dõi.

Hãy giữ property gọn và rõ.

## 5. Trùng lặp state

Ví dụ vừa có `Health`, vừa có field `IsDead`, nhưng lại không đồng bộ chúng.

Nhiều trường hợp nên dùng property tính toán thay vì lưu hai nơi.

## Nguyên tắc thực tế

1. Mặc định đừng public field nếu dữ liệu quan trọng.
2. Nếu cần nơi khác đọc nhưng không sửa, dùng `get; private set;`.
3. Nếu dữ liệu suy ra từ dữ liệu khác, cân nhắc computed property.
4. Hành vi nghiệp vụ nên là method rõ ràng.
5. Property là công cụ để object tự bảo vệ trạng thái của nó.

## Ghi nhớ nhanh

- Property giúp truy cập dữ liệu có kiểm soát.
- `get` để đọc, `set` để ghi.
- `private set` rất hữu ích trong code game.
- Property hỗ trợ encapsulation.
- Dùng property để giữ state hợp lệ.
- Method vẫn là nơi nên đặt hành vi gameplay quan trọng.
