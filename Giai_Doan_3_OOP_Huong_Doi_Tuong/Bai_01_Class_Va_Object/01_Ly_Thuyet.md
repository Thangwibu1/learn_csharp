# Bài 1: Class và Object

## Mục tiêu

- Hiểu class là bản thiết kế
- Hiểu object là vật thể được tạo từ bản thiết kế
- Biết vì sao OOP quan trọng trong game

## Class là gì?

Class giống như bản thiết kế của một ngôi nhà.

- Bản thiết kế nói nhà có gì
- Nhưng bản thiết kế chưa phải là căn nhà thật

Trong C#, class mô tả:

- object có dữ liệu gì
- object có hành động gì

```csharp
class Player
{
    public string Name;
    public int Health;
}
```

## Object là gì?

Object là phiên bản thật được tạo ra từ class.

```csharp
Player player = new Player();
```

Lúc này `player` là object thật.

## Tại sao phải dùng cái này?

Game có rất nhiều thực thể:

- người chơi
- quái
- đạn
- vật phẩm
- NPC

Nếu chỉ dùng biến rời rạc, code sẽ rối rất nhanh. Class gom dữ liệu và hành vi liên quan về cùng một chỗ.

## Field và Method

### Field

Là dữ liệu của object.

```csharp
public int Health;
```

### Method

Là hành động của object.

```csharp
public void TakeDamage(int damage)
{
    Health -= damage;
}
```

## Ví dụ game

```csharp
class Enemy
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine(Name + " tan cong");
    }
}
```

## Lỗi sai thường gặp của người mới

### 1. Nhầm class với object

Class là khuôn mẫu, object là thứ được tạo ra từ khuôn mẫu.

### 2. Tạo class nhưng quên `new`

### 3. Bỏ hết logic vào `Main` thay vì chia vào class

## Ghi nhớ nhanh

- Class = bản thiết kế
- Object = vật thể thật
- OOP giúp tổ chức code game tốt hơn
