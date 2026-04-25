# Bài 1: Stack và Heap

## Mục tiêu

- Hiểu bộ nhớ là nơi dữ liệu sống tạm trong lúc chương trình chạy
- Hiểu khác nhau giữa `stack` và `heap`
- Biết vì sao điều này quan trọng với C# và Unity

## Bộ nhớ là gì?

Khi chương trình chạy, nó cần chỗ để cất dữ liệu. Chỗ đó gọi là bộ nhớ.

Trong C#, người mới thường nghe hai vùng quan trọng:

- `stack`
- `heap`

## Hình dung đơn giản

### Stack

Hãy tưởng tượng một chồng đĩa.

- đặt đĩa mới lên trên cùng
- lấy đĩa cũng lấy từ trên cùng xuống

Stack nhanh, gọn, phù hợp cho dữ liệu nhỏ và ngắn hạn.

### Heap

Hãy tưởng tượng một kho hàng lớn.

- đồ có thể nằm ở nhiều chỗ khác nhau
- linh hoạt hơn
- quản lý phức tạp hơn

Heap thường chứa object, dữ liệu lớn hơn hoặc sống lâu hơn.

## Tại sao phải dùng cái này?

Vì khi học sâu hơn về `class`, `struct`, truyền tham số, tối ưu game, bạn cần biết dữ liệu đang được cất ở đâu và hành vi của nó ra sao.

Trong Unity, hiểu điều này giúp bạn:

- tránh tạo rác bộ nhớ quá nhiều
- hiểu vì sao một số object bị chia sẻ dữ liệu
- hiểu vì sao performance có thể tụt khi tạo hủy object liên tục

## Quy tắc nhớ nhanh

- `value type` thường đi với stack nhiều hơn
- `reference type` thường trỏ tới dữ liệu ở heap

Ví dụ thường gặp:

- `int`, `float`, `bool`, `struct` thường là value type
- `class`, `string`, array thường là reference type

## Ví dụ ý tưởng

```csharp
int hp = 100;
Player player = new Player();
```

- `hp` là dữ liệu giá trị đơn giản
- `player` là biến tham chiếu tới một object

## Garbage Collector

Với heap, C# có bộ dọn rác gọi là Garbage Collector.

Bạn có thể hiểu nó như người dọn kho:

- món nào không còn ai dùng thì dọn đi

Điều này tiện, nhưng nếu tạo rác quá nhiều trong game, đôi khi có thể gây giật khung hình.

## Lỗi sai thường gặp của người mới

### 1. Nghĩ mọi thứ đều hoạt động giống nhau

`int` và `class` không có hành vi sao chép giống nhau.

### 2. Không hiểu vì sao sửa object ở một nơi lại ảnh hưởng nơi khác

Lý do thường đến từ tham chiếu cùng trỏ đến một object trên heap.

### 3. Tối ưu quá sớm

Hiểu stack/heap là tốt, nhưng đừng ám ảnh tối ưu từ ngày đầu.

## Ghi nhớ nhanh

- Stack: nhanh, ngắn hạn, gọn
- Heap: linh hoạt, chứa object, cần dọn rác
- Kiến thức này là nền móng cho OOP và tối ưu Unity
