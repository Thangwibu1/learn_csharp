# Bài 3: Data Structures và Collections Trong Game

## Mục tiêu

- Hiểu vai trò của `List<T>`, `Dictionary<TKey, TValue>`, `Queue<T>`, `Stack<T>`
- Biết ứng dụng thực tế trong game
- Biết so sánh hiệu năng ở mức người mới cần hiểu

## Tại sao phải học phần này thật kỹ?

Vì game không chỉ là vẽ nhân vật và bấm chạy. Game còn là quản lý dữ liệu.

Bạn sẽ phải quản lý:

- túi đồ
- công thức ghép đồ
- hàng chờ sinh object
- lịch sử menu UI

Chọn sai cấu trúc dữ liệu có thể làm code vừa chậm vừa khó bảo trì.

## 1. `List<T>`

`List<T>` giống như một danh sách có thứ tự.

### Khi nào hợp?

- inventory
- danh sách quest
- danh sách enemy hiện có

### Ưu điểm

- thêm cuối khá tiện
- duyệt tuần tự dễ
- truy cập theo chỉ số dễ

### Nhược điểm

- tìm kiếm theo tên không nhanh bằng dictionary
- xóa ở giữa có thể tốn hơn vì phải dồn phần tử

### Ứng dụng game: Inventory

Túi đồ thường là một danh sách item. Người chơi mở túi đồ và game duyệt từng ô để hiển thị.

## 2. `Dictionary<TKey, TValue>`

`Dictionary` giống như cuốn sổ tra cứu:

- bạn đưa khóa vào
- nó trả lại giá trị rất nhanh

### Khi nào hợp?

- tra cứu item data theo ID
- crafting recipe
- map tên skill -> dữ liệu skill

### Ưu điểm

- tra cứu nhanh theo khóa
- hợp cho dữ liệu dạng key-value

### Nhược điểm

- không phù hợp nếu bạn chỉ cần duyệt tuần tự đơn giản
- không nên dùng nếu khóa không rõ ràng

### Ứng dụng game: Crafting

Ví dụ khóa là mã công thức, giá trị là kết quả ghép. Khi người chơi ghép đồ, game tra cứu nhanh công thức.

## 3. `Queue<T>`

`Queue` hoạt động theo kiểu vào trước ra trước.

### Hình dung đời thường

Xếp hàng mua vé.

- ai vào trước được phục vụ trước

### Ứng dụng game: Object Pooling

Rất hợp để quản lý pool đạn, hiệu ứng, quái nhỏ.

Bạn lấy object rảnh ra dùng, xài xong trả về hàng chờ.

## 4. `Stack<T>`

`Stack` hoạt động theo kiểu vào sau ra trước.

### Hình dung đời thường

Chồng khay.

- đặt sau cùng thì lấy ra trước

### Ứng dụng game: UI Stack

Rất hợp để quản lý menu chồng nhau:

- mở Settings trên Pause
- mở Confirm trên Settings
- bấm Back thì đóng màn trên cùng trước

## So sánh nhanh

- `List<T>`: danh sách có thứ tự
- `Dictionary<TKey, TValue>`: tra cứu nhanh theo khóa
- `Queue<T>`: hàng đợi vào trước ra trước
- `Stack<T>`: chồng dữ liệu vào sau ra trước

## Lỗi sai thường gặp của người mới

### 1. Dùng `List<T>` cho mọi thứ

### 2. Dùng `Dictionary` khi thật ra chỉ cần danh sách đơn giản

### 3. Không chọn cấu trúc theo bài toán thực tế

## Ghi nhớ nhanh

- Inventory: thường dùng `List<T>`
- Crafting lookup: thường dùng `Dictionary`
- Object pooling: thường dùng `Queue<T>`
- UI history/menu stack: thường dùng `Stack<T>`
