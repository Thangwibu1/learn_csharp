# Bài 4: Kế Thừa và Đa Hình

## Mục tiêu

- Hiểu kế thừa là gì
- Hiểu đa hình là gì
- Biết lợi ích và giới hạn của kế thừa
- Phân tích kỹ Inheritance và Composition

## Kế thừa là gì?

Kế thừa nghĩa là một class con nhận lại đặc điểm và hành vi từ class cha.

```csharp
class Character
{
    public int Health;
}

class Player : Character
{
    public int Level;
}
```

`Player` có thể dùng `Health` vì kế thừa từ `Character`.

## Đa hình là gì?

Đa hình nghĩa là nhiều object khác nhau có thể phản ứng khác nhau cho cùng một lời gọi.

Ví dụ:

```csharp
virtual void Attack()
```

Mỗi class con có thể tự định nghĩa kiểu tấn công riêng.

## Tại sao phải dùng cái này?

Trong game, ta có nhiều đối tượng cùng họ:

- `Character`
- `Player`
- `Enemy`
- `Boss`

Ta muốn chia sẻ phần chung nhưng vẫn cho từng loại hành vi riêng.

## Inheritance vs Composition

Đây là phần cực quan trọng.

### Inheritance

Là quan hệ "là một".

Ví dụ:

- `Player` là một `Character`
- `Boss` là một `Enemy`

Ưu điểm:

- chia sẻ code chung dễ
- phù hợp khi quan hệ cha con thật sự rõ

Nhược điểm:

- cây kế thừa dễ phình to
- class con bị buộc gắn chặt vào class cha
- sửa class cha có thể ảnh hưởng rất rộng

### Composition

Composition là ghép object từ nhiều thành phần nhỏ.

Ví dụ đời thường:

- một chiếc xe không phải "kế thừa" từ bánh xe
- nó được tạo thành từ động cơ, bánh xe, ghế, vô lăng

Trong code game:

- Player có `HealthComponent`
- có `MovementComponent`
- có `InventoryComponent`

Ưu điểm:

- linh hoạt hơn
- dễ thay thế từng phần
- giảm phụ thuộc cứng
- rất hợp cho game có nhiều biến thể đối tượng

### Tại sao Unity ưu tiên Component-based architecture?

Unity xây dựng quanh `GameObject` + `Component` vì:

- dễ ghép tính năng như Lego
- một object có thể có Renderer, Collider, AudioSource, Script cùng lúc
- tránh cây kế thừa khổng lồ kiểu `FlyingShootingPoisonBossEnemyWithShield`
- dễ tái sử dụng module nhỏ

Nói ngắn gọn:

- Inheritance tốt khi quan hệ cha con thật sự ổn định
- Composition tốt khi cần lắp ghép linh hoạt
- Unity nghiêng mạnh về composition

## Lỗi sai thường gặp của người mới

### 1. Lạm dụng kế thừa cho mọi thứ

### 2. Tạo cây class quá sâu

### 3. Không tách phần chung thật sự cần chung

## Ghi nhớ nhanh

- Kế thừa: dùng khi quan hệ cha con hợp lý
- Composition: dùng khi muốn ghép tính năng linh hoạt
- Trong Unity, composition thường là lựa chọn tốt hơn
