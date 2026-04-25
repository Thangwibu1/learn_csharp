# Bài 3: Properties

## Mục tiêu

- Hiểu property là gì
- Biết vì sao property tốt hơn public field trong nhiều trường hợp

## Property là gì?

Property là cách cung cấp quyền đọc hoặc ghi dữ liệu một cách có kiểm soát hơn.

Ví dụ:

```csharp
public int Health { get; private set; }
```

Điều này nghĩa là:

- bên ngoài có thể đọc `Health`
- nhưng không phải ai cũng sửa được trực tiếp

## Tại sao phải dùng cái này?

Vì bạn thường không muốn dữ liệu bị sửa bừa bãi.

Ví dụ:

- máu không nên bị set thành số âm lung tung
- level không nên bị sửa trực tiếp từ mọi nơi

Property giúp bảo vệ dữ liệu.

## Ví dụ đời thường

Giống như tài khoản ngân hàng:

- ai cũng có thể xem số dư nếu được phép
- nhưng không phải ai cũng được quyền sửa số dư

## Auto-property

```csharp
public string Name { get; set; }
```

## Chỉ đọc từ ngoài

```csharp
public int Health { get; private set; }
```

## Lỗi sai thường gặp của người mới

### 1. Public field mọi thứ

### 2. Không kiểm soát dữ liệu đầu vào

### 3. Dùng property nhưng chưa hiểu `get` và `set`

## Ghi nhớ nhanh

- Property giúp bảo vệ dữ liệu tốt hơn field public trực tiếp
