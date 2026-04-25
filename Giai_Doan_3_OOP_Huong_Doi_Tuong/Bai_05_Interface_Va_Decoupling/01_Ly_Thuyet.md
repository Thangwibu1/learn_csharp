# Bài 5: Interface và Decoupling

## Mục tiêu

- Hiểu interface là gì
- Biết dùng interface để giảm phụ thuộc giữa các class
- Biết áp dụng `IInteractable`, `IDamageable` trong game

## Interface là gì?

Interface là một bản cam kết về hành vi.

Nó nói rằng:

- nếu class hứa thực hiện interface này
- thì class đó phải có những method đã quy định

Ví dụ:

```csharp
interface IDamageable
{
    void TakeDamage(int damage);
}
```

## Decoupling là gì?

Decoupling có thể hiểu đơn giản là giảm phụ thuộc cứng giữa các class.

Ví dụ xấu:

- `Sword` chỉ biết đánh đúng class `Enemy`
- sau này muốn đánh `Crate`, `Boss`, `PlayerTrainingDummy` thì phải sửa code khắp nơi

Ví dụ tốt:

- `Sword` chỉ cần biết đối tượng kia có phải `IDamageable` không
- nếu có, gọi `TakeDamage()`

## Tại sao phải dùng cái này?

Vì game thường có nhiều đối tượng khác nhau nhưng cùng chia sẻ một hành vi.

Ví dụ:

- cửa, rương, NPC đều có thể tương tác
- quái, boss, thùng gỗ đều có thể nhận sát thương

Interface giúp code linh hoạt hơn rất nhiều.

## `IInteractable`

```csharp
interface IInteractable
{
    void Interact();
}
```

Các object như cửa, rương, NPC đều có thể triển khai interface này.

## `IDamageable`

```csharp
interface IDamageable
{
    void TakeDamage(int damage);
}
```

Mọi object nhận sát thương đều có thể dùng chung luật này.

## Lợi ích lớn nhất

- code ít phụ thuộc hơn
- dễ mở rộng hơn
- dễ test hơn
- đúng tinh thần game architecture sạch

## Ví dụ đời thường

Ổ cắm điện không cần biết đang cắm quạt hay nồi cơm.
Nó chỉ cần biết thiết bị đó tuân theo chuẩn cắm điện.

Interface cũng vậy: class dùng hành vi, không cần biết chi tiết loại thật.

## Lỗi sai thường gặp của người mới

### 1. Dùng interface cho mọi thứ dù không cần

### 2. Tạo interface quá to, nhồi quá nhiều trách nhiệm

### 3. Vẫn code phụ thuộc vào class cụ thể dù đã có interface

## Ghi nhớ nhanh

- Interface là hợp đồng hành vi
- Dùng interface để giảm phụ thuộc cứng giữa class
- `IInteractable` và `IDamageable` là mẫu cực hay trong game
