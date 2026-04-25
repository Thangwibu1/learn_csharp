# Bài tập Bài 1

## Bài 1

Tạo generic class `Holder<T>` với field `Data`.

## Bài 2

Tạo `Holder<int>` và `Holder<string>`.

## Bài 3

Tự giải thích: vì sao generic tốt hơn `object` trong nhiều trường hợp?

## Phần B - Bài tập mở rộng theo mức độ

### Bài 4

Tạo class `InventorySlot<T>` lưu một món đồ bất kỳ.

Yêu cầu:

- Có `SlotIndex`.
- Có `Item`.
- Có method `ShowStatus()`.

Gợi ý:

- Nếu ô trống, in thông báo phù hợp.

Tự kiểm tra:

- `InventorySlot<string>` và `InventorySlot<int>` có dùng chung class được không?

### Bài 5

Tạo class `Pair<T1, T2>`.

Yêu cầu:

- Lưu tên thuộc tính và giá trị.
- Tạo một cặp `("Damage", 120)`.
- Tạo một cặp `("Class", "Knight")`.

Gợi ý:

- Hãy thử in ra cả hai thành phần.

### Bài 6

Viết generic method `Swap<T>(ref T a, ref T b)`.

Yêu cầu:

- Thử với `int`.
- Thử với `string`.
- In kết quả trước và sau khi đổi chỗ.

Tự kiểm tra:

- Vì sao một method lại dùng được cho nhiều kiểu?

### Bài 7

Tạo class `Repository<T>` có danh sách bên trong.

Yêu cầu:

- Có method `Add(T item)`.
- Có method `PrintAll()`.
- Tạo `Repository<string>` cho tag game object.
- Tạo `Repository<int>` cho điểm số.

### Bài 8

Tạo `Repository<Player>` với class `Player` tự định nghĩa.

Yêu cầu:

- `Player` có tên và level.
- Override `ToString()` để in đẹp hơn.
- Thêm ít nhất 3 người chơi vào repository.

Gợi ý:

- Đây là bước rất tốt để thấy generic không chỉ dành cho kiểu dựng sẵn.

### Bài 9

Tạo class `RewardBox<T>`.

Yêu cầu:

- Lưu phần thưởng bất kỳ.
- Có method `Open()` trả về dữ liệu.
- Thử với `int`, `string`, và `ItemData`.

### Bài 10

Tạo class `ConfigValue<T>`.

Yêu cầu:

- Dùng cho cấu hình game.
- Ví dụ: `ConfigValue<float>` cho âm lượng.
- Ví dụ: `ConfigValue<bool>` cho fullscreen.

Tự kiểm tra:

- Generic có phù hợp với dữ liệu cấu hình không? Vì sao?

## Phần C - Bài tập phân tích tư duy

### Bài 11

So sánh hai cách làm:

- `Holder<object>`
- `Holder<T>`

Viết 5 ý khác nhau giữa hai hướng tiếp cận này.

Gợi ý:

- Hãy nghĩ về ép kiểu.
- Hãy nghĩ về IDE.
- Hãy nghĩ về runtime error.

### Bài 12

Giải thích bằng lời của bạn:

- `T` là gì?
- Khi nào `T` thành `int`?
- Khi nào `T` thành `string`?

### Bài 13

Cho ví dụ 5 nơi trong game có thể dùng generic.

Gợi ý:

- inventory
- object pool
- event bus
- repository
- cache

### Bài 14

Viết lại một class bạn từng tạo ở giai đoạn trước thành phiên bản generic.

Gợi ý:

- Chọn class có logic giống nhau nhưng chỉ khác kiểu dữ liệu.

### Bài 15

Tự trả lời câu hỏi:

- Khi nào không nên dùng generic?

Gợi ý:

- Nếu chỉ có đúng một kiểu cụ thể.
- Nếu generic làm code khó đọc hơn mức cần thiết.

## Phần D - Chuỗi bài tập theo bối cảnh game

### Bài 16

Tạo class `SaveSlot<T>`.

Yêu cầu:

- Có tên slot.
- Có dữ liệu lưu.
- Có method `PrintInfo()`.

### Bài 17

Tạo class `QuestState` và lưu nó bằng `SaveSlot<QuestState>`.

Yêu cầu:

- Quest có id.
- Quest có trạng thái hoàn thành.

### Bài 18

Tạo class `Stat<T>`.

Yêu cầu:

- Có tên chỉ số.
- Có giá trị.
- Thử với `int` và `float`.

### Bài 19

Tạo class `MessageLog<T>`.

Yêu cầu:

- Có method `Add(T message)`.
- Có method `PrintAll()`.
- Thử với log chuỗi.
- Thử với log object tự tạo.

### Bài 20

Tạo class `Cache<TKey, TValue>` đơn giản.

Yêu cầu:

- Có method `Store`.
- Có method `TryGet`.
- Thử với khóa `string`.
- Thử với khóa `int`.

### Bài 21

Tạo `Cache<string, int>` cho cooldown skill.

Yêu cầu:

- Lưu ít nhất 4 skill.
- In cooldown từng skill.

### Bài 22

Tạo `Cache<int, string>` cho mapping level sang rank.

Yêu cầu:

- Level 1 -> Bronze.
- Level 10 -> Silver.
- Level 20 -> Gold.

### Bài 23

Tạo class `FactoryResult<T>`.

Yêu cầu:

- Lưu sản phẩm tạo ra.
- Lưu số lượng.
- In kết quả crafting.

### Bài 24

Tạo class `WaveEntry<T>`.

Yêu cầu:

- Lưu dữ liệu enemy bất kỳ.
- Lưu số lượng spawn.

### Bài 25

Tạo class `SpawnRequest<T>`.

Yêu cầu:

- Lưu prefab hoặc mã enemy.
- Lưu vị trí hoặc tên điểm spawn.

## Phần E - Constraint cơ bản

### Bài 26

Tạo interface `IGameData` có method `GetSummary()`.

### Bài 27

Tạo class `PlayerData` và `ItemData` implement `IGameData`.

### Bài 28

Tạo class `DataPrinter<T> where T : IGameData`.

Yêu cầu:

- Có method `Print(T data)`.
- In được summary.

### Bài 29

Giải thích vì sao constraint giúp generic vừa linh hoạt vừa có kiểm soát.

### Bài 30

Tự viết 3 ví dụ khác có thể dùng `where T : ...`.

Gợi ý:

- `class`
- `new()`
- interface tự tạo

## Phần F - Tự kiểm tra nhanh

### Câu 1

`List<int>` có phải generic không?

### Câu 2

`Dictionary<string, int>` có bao nhiêu tham số kiểu?

### Câu 3

Vì sao `object` không thay thế hoàn toàn cho generic?

### Câu 4

Generic class khác generic method ở đâu?

### Câu 5

Khi nào compiler biết `T` là kiểu gì?

### Câu 6

`Box<int>` và `Box<string>` có dùng chung cùng một khuôn class không?

### Câu 7

Type safety mang lại lợi ích gì trong dự án lớn?

### Câu 8

Một ví dụ game rất hợp với generic là gì?

### Câu 9

Một ví dụ game không nhất thiết phải generic là gì?

### Câu 10

Đặt tên `T`, `TItem`, `TKey`, `TValue` khác nhau ở ý nghĩa nào?

## Phần G - Lỗi thường gặp

### Lỗi 1

Dùng generic nhưng tên class quá mơ hồ.

Cách tránh:

- Đặt tên theo nghiệp vụ.

### Lỗi 2

Dùng `object` vì thấy nhanh hơn.

Cách tránh:

- So sánh trước về ép kiểu và an toàn kiểu.

### Lỗi 3

Lạm dụng generic cho bài toán chỉ có một kiểu cố định.

Cách tránh:

- Ưu tiên sự rõ ràng.

### Lỗi 4

Không hiểu khác biệt giữa generic class và generic method.

Cách tránh:

- Tự viết ví dụ cho từng loại.

### Lỗi 5

Không tự tạo ví dụ bằng class riêng.

Cách tránh:

- Thử với `Player`, `Enemy`, `ItemData`.

## Phần H - Mini project

### Mini project 1

Xây một hệ thống túi đồ nhỏ dùng generic cho slot.

Yêu cầu:

- Có class item.
- Có slot generic.
- Có ít nhất 5 ô.
- Có thao tác đặt và xóa item.

### Mini project 2

Xây một repository dữ liệu game generic.

Yêu cầu:

- Lưu player.
- Lưu item.
- Lưu enemy.
- Dùng cùng một khuôn repository.

### Mini project 3

Xây một hệ thống cache generic cho dữ liệu tạm.

Yêu cầu:

- Cache cooldown.
- Cache dữ liệu nhân vật.
- In thử toàn bộ dữ liệu.

## Phần I - Reflection

Tự trả lời ngắn gọn:

1. Điều gì về generic làm bạn dễ hiểu nhất?
2. Điều gì còn mơ hồ nhất?
3. Bạn thấy generic gần với ví dụ game nào nhất?
4. Bạn sẽ dùng generic trong file nào của dự án riêng?
5. Khi nào bạn sẽ cố ý không dùng generic?

## Phần J - Checklist hoàn thành bài

- Tôi đã tự tạo ít nhất 3 generic class.
- Tôi đã tự tạo ít nhất 1 generic method.
- Tôi đã thử generic với kiểu dựng sẵn.
- Tôi đã thử generic với class tự tạo.
- Tôi đã viết ít nhất 1 ví dụ so sánh với `object`.
- Tôi đã tự giải thích được type safety.
- Tôi đã làm ít nhất 1 mini project nhỏ.
- Tôi đã đọc lại code và đổi tên cho rõ nghĩa.
- Tôi đã tự thêm comment ở chỗ mình chưa chắc.
- Tôi đã chạy thử chương trình sau khi sửa.
