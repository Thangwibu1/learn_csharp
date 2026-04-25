# Bài 3: Data Structures và Collections Trong Game

## Mục tiêu

- Hiểu vai trò của `List<T>`, `Dictionary<TKey, TValue>`, `Queue<T>`, `Stack<T>`.
- Biết chọn cấu trúc dữ liệu theo bài toán game thay vì theo thói quen.
- Thấy tác động của collections lên kiến trúc gameplay, UI và hệ thống quản lý.
- Biết các tình huống điển hình như inventory, crafting, object pooling, menu stack.
- Tránh lỗi phổ biến như dùng `List<T>` cho mọi thứ.

## Vì sao bài này đặc biệt quan trọng?

Rất nhiều người mới học code chỉ tập trung vào cú pháp.

Nhưng khi làm game, một phần lớn chất lượng code nằm ở chỗ bạn quản lý dữ liệu như thế nào.

Game thực chất là một hệ thống xử lý và cập nhật dữ liệu liên tục.

Bạn phải quản lý:

- danh sách item trong túi đồ
- tra cứu item theo ID
- hàng chờ spawn hoặc pool object
- lịch sử màn hình UI
- quest đang hoạt động
- danh sách enemy còn sống
- mapping kỹ năng sang cooldown

Nếu chọn sai cấu trúc dữ liệu:

- code có thể chậm hơn cần thiết
- logic trở nên khó hiểu
- class manager bị phình to
- bug thao tác dữ liệu tăng mạnh

## Quy tắc nền tảng

Không có collection nào tốt nhất cho mọi bài toán.

Câu hỏi đúng không phải là:

- collection nào mạnh nhất?

Mà là:

- bài toán của mình cần thao tác nào thường xuyên nhất?

Ví dụ:

- cần duyệt tuần tự?
- cần tra cứu nhanh theo khóa?
- cần vào trước ra trước?
- cần vào sau ra trước?

Trả lời được câu đó, bạn thường sẽ chọn đúng collection hơn rất nhiều.

## 1. `List<T>`

`List<T>` là danh sách có thứ tự, rất linh hoạt và rất phổ biến.

Nó thường là collection đầu tiên bạn dùng khi không có yêu cầu đặc biệt hơn.

Ví dụ:

```csharp
List<string> inventory = new List<string>();
```

## Khi nào `List<T>` phù hợp?

- bạn có một tập phần tử có thứ tự
- bạn hay duyệt toàn bộ danh sách
- bạn truy cập theo chỉ số
- bạn chủ yếu thêm cuối danh sách

## Ứng dụng game điển hình của `List<T>`

- inventory đơn giản
- danh sách quest đang nhận
- danh sách enemy hiện có trong scene
- danh sách skill đang trang bị
- danh sách waypoint

## Ví dụ: inventory

Túi đồ là ví dụ rất tự nhiên cho `List<T>`.

Người chơi mở túi, game duyệt từng ô để hiển thị.

Nếu chỉ cần:

- thêm item
- duyệt item
- truy cập item theo index slot

thì `List<T>` là lựa chọn rất hợp lý.

## Ưu điểm của `List<T>`

- dễ dùng
- cú pháp quen thuộc
- duyệt tuần tự thuận tiện
- truy cập theo index rõ ràng
- hợp với nhiều hệ thống gameplay cơ bản

## Hạn chế của `List<T>`

- tra cứu theo khóa không tối ưu bằng `Dictionary`
- tìm một item theo ID trong list dài có thể tốn duyệt từng phần tử
- xóa ở giữa danh sách có thể làm dịch chuyển phần tử phía sau

## Khi không nên dùng `List<T>`

Nếu tác vụ chính là:

- tra cứu theo ID hoặc tên khóa
- kiểm tra tồn tại rất thường xuyên

thì `Dictionary` thường phù hợp hơn.

## 2. `Dictionary<TKey, TValue>`

`Dictionary` là cấu trúc key-value.

Bạn đưa một khóa vào và lấy ra giá trị tương ứng.

Ví dụ:

```csharp
Dictionary<string, int> itemPrices = new Dictionary<string, int>();
```

## Khi nào `Dictionary` phù hợp?

- khi bạn có khóa rõ ràng
- khi tra cứu nhanh theo khóa là nhu cầu chính
- khi dữ liệu mang bản chất mapping

## Ứng dụng game điển hình của `Dictionary`

- tra cứu item data theo item ID
- bảng công thức crafting
- map tên skill sang dữ liệu skill
- lưu cooldown theo ability ID
- map quest ID sang trạng thái quest

## Ví dụ game: item database

Giả sử bạn có `itemId` như:

- `potion_small`
- `sword_iron`
- `key_dungeon`

Nếu mỗi lần muốn lấy dữ liệu item mà phải duyệt một `List<ItemData>`, code sẽ vừa dài vừa kém hiệu quả hơn cần thiết.

`Dictionary<string, ItemData>` hợp hơn nhiều.

## Ví dụ game: crafting

Với crafting, bạn thường cần tra cứu nhanh công thức.

Ví dụ:

- khóa là mã công thức
- giá trị là kết quả hoặc dữ liệu recipe

Lúc đó `Dictionary` rất tự nhiên.

## Ưu điểm của `Dictionary`

- rất hợp cho tra cứu theo khóa
- biểu diễn quan hệ key-value rõ ràng
- giúp nhiều hệ thống manager đỡ phải viết vòng lặp tìm thủ công liên tục

## Hạn chế của `Dictionary`

- không phải lựa chọn tốt nhất nếu bạn chỉ cần danh sách tuần tự đơn giản
- thứ tự duyệt không phải lúc nào cũng là điều bạn muốn dựa vào
- nếu không có khóa rõ ràng, bạn đang ép bài toán vào dictionary một cách gượng gạo

## Một bài học kiến trúc quan trọng

`List<T>` nói rằng:

- tôi có một tập phần tử theo thứ tự

`Dictionary<TKey, TValue>` nói rằng:

- tôi có một bảng tra cứu theo khóa

Hai collection này biểu đạt ý đồ thiết kế khác nhau.

Chọn đúng collection làm code tự giải thích tốt hơn.

## 3. `Queue<T>`

`Queue<T>` hoạt động theo nguyên tắc vào trước ra trước.

FIFO = First In, First Out.

Ví dụ:

```csharp
Queue<string> queue = new Queue<string>();
```

## Cách hiểu đời thường

Giống hàng xếp chờ mua vé.

Ai vào trước thì được xử lý trước.

## Ứng dụng game điển hình của `Queue<T>`

- object pooling
- hàng chờ spawn
- xử lý lệnh tuần tự
- enemy wave queue
- sequence các tác vụ nền đơn giản

## Queue trong object pooling

Đây là ví dụ cực thực tế.

Giả sử bạn có pool đạn.

Bạn tạo sẵn một loạt object đạn rồi bỏ vào pool.

Khi cần bắn:

- lấy một object từ pool

Khi dùng xong:

- trả object về pool

`Queue<T>` rất hợp vì nó biểu diễn luồng lấy ra và trả lại theo thứ tự chờ.

Trong bài toán pool cơ bản, đây là lựa chọn rất tự nhiên.

## Queue trong wave spawn

Bạn có thể dùng queue để xếp các enemy hoặc wave đang chờ spawn.

Hệ thống lần lượt lấy ra từng phần tử theo thứ tự đã chuẩn bị.

Điều này giúp luồng xử lý rõ ràng hơn so với việc lẫn lộn nhiều biến đếm rời rạc.

## Ưu điểm của `Queue<T>`

- mô hình hóa rất rõ bài toán chờ theo thứ tự
- tốt cho pool và pipeline đơn giản
- ý nghĩa đọc code rõ ràng hơn là dùng `List<T>` rồi tự quản chỉ số đầu hàng

## Hạn chế của `Queue<T>`

- không hợp nếu bạn cần truy cập ngẫu nhiên theo index
- không hợp nếu bài toán không có tính chất FIFO

## 4. `Stack<T>`

`Stack<T>` hoạt động theo nguyên tắc vào sau ra trước.

LIFO = Last In, First Out.

Ví dụ:

```csharp
Stack<string> menuStack = new Stack<string>();
```

## Cách hiểu đời thường

Giống chồng khay hoặc chồng sách.

Thứ đặt lên trên cùng sẽ được lấy ra trước.

## Ứng dụng game điển hình của `Stack<T>`

- lịch sử menu UI
- điều hướng màn hình chồng lớp
- undo đơn giản
- backtracking hoặc lưu state tạm thời

## Stack trong kiến trúc UI game

Đây là ví dụ rất thực chiến.

Giả sử người chơi đang ở:

- `PauseMenu`
- mở tiếp `SettingsMenu`
- mở tiếp `ConfirmDialog`

Khi bấm back, màn hình trên cùng nên đóng trước.

Đó chính là hành vi của stack.

Ví dụ luồng:

- push `PauseMenu`
- push `SettingsMenu`
- push `ConfirmDialog`
- pop sẽ ra `ConfirmDialog`
- pop tiếp sẽ ra `SettingsMenu`

Rất tự nhiên.

## Vì sao không nên dùng `List<T>` cho mọi thứ?

Vì khi bạn dùng `List<T>` cho cả queue lẫn stack lẫn lookup, code mất ý nghĩa thiết kế.

Đúng là bạn có thể "làm được" bằng list.

Nhưng:

- code ít tự mô tả hơn
- bạn phải tự quản nhiều luật thao tác
- dễ sai hơn

Một `Stack<T>` nói với người đọc rằng:

- thứ trên cùng là thứ được xử lý đầu tiên

Một `Queue<T>` nói rằng:

- phần tử chờ theo thứ tự vào trước ra trước

Đó là giá trị kiến trúc rất lớn.

## Chọn collection theo bài toán game

### Inventory cơ bản

Thường chọn `List<T>`.

### Item database tra cứu theo ID

Thường chọn `Dictionary<TKey, TValue>`.

### Bullet pool hoặc enemy pool

Thường chọn `Queue<T>`.

### Menu chồng lớp và nút back

Thường chọn `Stack<T>`.

## Ví dụ thiết kế kết hợp

Một game thực tế có thể dùng nhiều collection cùng lúc.

Ví dụ inventory system:

- `List<InventorySlot>` để hiển thị thứ tự ô
- `Dictionary<string, ItemData>` để tra cứu data từ item ID

Ví dụ gameplay manager:

- `Queue<Enemy>` cho wave chờ spawn
- `List<Enemy>` cho enemy đang sống

Ví dụ UI manager:

- `Stack<UIScreen>` cho lịch sử panel

Đây là tư duy kết hợp rất quan trọng.

## Góc nhìn hiệu năng ở mức người mới cần hiểu

Bạn chưa cần học độ phức tạp thuật toán quá sâu để dùng đúng collection ở giai đoạn này.

Điều cần nhớ là:

- dùng sai cấu trúc dữ liệu có thể làm bạn duyệt vòng lặp thừa liên tục
- dùng đúng cấu trúc dữ liệu giúp code vừa rõ vừa hợp mục đích

Ví dụ nếu mỗi frame bạn phải tra item theo ID hàng trăm lần, `Dictionary` thường hợp hơn list duyệt thủ công.

## Sai lầm thường gặp của người mới

## 1. Dùng `List<T>` cho tất cả mọi tình huống

Đây là lỗi phổ biến nhất.

## 2. Dùng `Dictionary` khi không có khóa thật sự rõ ràng

Điều này làm dữ liệu khó hiểu và dễ phát sinh khóa tùy tiện.

## 3. Không nhìn collection như công cụ biểu đạt ý đồ thiết kế

Collection không chỉ là nơi nhét dữ liệu.

Nó còn nói lên cách hệ thống hoạt động.

## 4. Tự giả lập queue hoặc stack bằng list một cách thủ công

Có thể làm được, nhưng thường kém rõ ràng hơn dùng đúng cấu trúc.

## 5. Không tách dữ liệu hiển thị và dữ liệu tra cứu

Rất nhiều hệ thống cần cả list và dictionary cùng lúc.

Nếu chỉ dùng một loại cho mọi nhu cầu, kiến trúc dễ méo mó.

## Tư duy thực chiến cần nhớ

1. Hỏi thao tác chính của dữ liệu là gì.
2. Chọn collection phù hợp với thao tác đó.
3. Dùng collection để làm rõ ý đồ kiến trúc.
4. Không ép mọi bài toán vào `List<T>`.
5. Kết hợp nhiều collection khi hệ thống cần nhiều kiểu thao tác khác nhau.

## Ghi nhớ nhanh

- `List<T>`: danh sách có thứ tự, hợp cho inventory và danh sách đơn giản.
- `Dictionary<TKey, TValue>`: tra cứu nhanh theo khóa, hợp cho database và crafting lookup.
- `Queue<T>`: FIFO, hợp cho object pooling và hàng chờ spawn.
- `Stack<T>`: LIFO, hợp cho UI stack và lịch sử back.
- Chọn đúng collection là một quyết định kiến trúc, không chỉ là cú pháp.
