# Bài 2: Tham Trị và Tham Chiếu

## Mục tiêu

- Hiểu value type và reference type khác nhau thế nào
- Hiểu sao chép dữ liệu khác với sao chép đường dẫn tới dữ liệu ra sao

## Tham trị là gì?

Tham trị nghĩa là biến giữ chính giá trị của nó.

Ví dụ:

```csharp
int a = 10;
int b = a;
```

Lúc này `b` lấy một bản sao của `a`.

Nếu đổi `b`, `a` không đổi.

## Tham chiếu là gì?

Tham chiếu nghĩa là biến giữ đường dẫn tới object.

Ví dụ:

```csharp
Player p1 = new Player();
Player p2 = p1;
```

Lúc này `p1` và `p2` thường cùng trỏ tới một object.

Đổi dữ liệu qua `p2` thì `p1` cũng thấy thay đổi.

## Tại sao phải dùng cái này?

Vì nếu không hiểu điểm này, bạn sẽ rất dễ bị lỗi kiểu:

- tưởng là tạo bản sao nhưng thực ra đang dùng chung object
- sửa inventory của NPC A mà NPC B cũng đổi theo
- thay đổi config ở một nơi làm chỗ khác bị ảnh hưởng

## Ví dụ đời thường

### Tham trị

Giống như bạn chép số điện thoại từ giấy A sang giấy B.

- Hai tờ giấy tách biệt
- Sửa B không làm A đổi

### Tham chiếu

Giống như hai người cùng giữ địa chỉ tới cùng một căn nhà.

- Một người sơn lại nhà
- Người kia nhìn vào cũng thấy nhà đã đổi màu

## Lỗi sai thường gặp của người mới

### 1. Nghĩ `class` khi gán sẽ tạo object mới

Không phải. Thường nó chỉ sao chép tham chiếu.

### 2. Không tạo object trước khi dùng

```csharp
Player player;
```

Khai báo như vậy chưa tạo object thật.

### 3. Không hiểu vì sao nhiều biến lại dính nhau

Lý do thường là chúng cùng trỏ về một object.

## Ghi nhớ nhanh

- Value type: sao chép giá trị
- Reference type: sao chép tham chiếu
- Hiểu bài này là nền tảng cực quan trọng trước khi học OOP
