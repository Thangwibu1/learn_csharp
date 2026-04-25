# Bài tập Bài 2: GameObject và Component

## Mục tiêu của bài tập

- Hiểu `GameObject` là container và `Component` là các mảnh chức năng.
- Tập phân tích một object theo danh sách component thay vì chỉ nhìn tên.
- Tập tư duy tách trách nhiệm khi thiết kế object trong Unity.

## Phần 1: Nhận diện khái niệm

### Bài 1

Viết lại bằng lời của bạn:

- `GameObject` là gì?
- `Component` là gì?
- Vì sao mọi `GameObject` đều có `Transform`?

Yêu cầu:

- Mỗi câu trả lời tối thiểu 3 dòng.
- Không sao chép nguyên câu lý thuyết.

### Bài 2

Chọn 3 object đang có trong scene và liệt kê toàn bộ component của từng object.

Yêu cầu:

- Phải có ít nhất 1 object hiển thị hình ảnh.
- Phải có ít nhất 1 object logic rỗng.
- Phải có ít nhất 1 object có collider hoặc rigidbody.

## Phần 2: Thực hành tạo object có chủ đích

### Bài 3

Tạo một object tên `Coin`.

Yêu cầu:

- Thêm component hiển thị phù hợp.
- Thêm component va chạm phù hợp.
- Ghi ra script hoặc component logic mà coin sẽ cần nếu muốn nhặt được.

### Bài 4

Tạo một object tên `Enemy`.

Yêu cầu:

- Liệt kê tối thiểu 5 component hoặc script mà object này nên có.
- Với mỗi component, ghi 1 dòng mô tả vai trò.

### Bài 5

Tạo một object rỗng tên `GameManager`.

Yêu cầu:

- Giải thích vì sao object này có thể không cần sprite hay mesh.
- Nêu ít nhất 4 trách nhiệm mà `GameManager` có thể giữ.

## Phần 3: Bật tắt component và object

### Bài 6

Bật/tắt renderer của một object.

Yêu cầu:

- Quan sát object trong scene và game.
- Trả lời: object có còn tồn tại không?

### Bài 7

Bật/tắt collider của một object.

Yêu cầu:

- Mô tả sự khác nhau trước và sau khi tắt collider.
- Trả lời: hình ảnh có biến mất không?

### Bài 8

Bật/tắt toàn bộ `GameObject`.

Yêu cầu:

- So sánh với bài 6 và bài 7.
- Viết ra 3 khác biệt rõ nhất.

## Phần 4: Quan hệ cha con

### Bài 9

Tạo cấu trúc sau trong `Hierarchy`:

- `Player`
- `Weapon`
- `WeaponPivot`

Yêu cầu:

- `WeaponPivot` là con của `Player`.
- `Weapon` là con của `WeaponPivot`.
- Di chuyển `Player` và quan sát.

### Bài 10

Tự giải thích vì sao quan hệ cha con rất hữu ích với:

- Vũ khí gắn tay nhân vật
- Camera theo player
- UI nhóm theo panel
- Cụm enemy trong scene

## Phần 5: Phân tích object theo component

### Bài 11

Chọn object `Player` và phân loại component thành 3 nhóm:

- Hiển thị
- Vật lý hoặc va chạm
- Logic

Yêu cầu:

- Mỗi component phải được xếp vào một nhóm.
- Nếu còn nhóm khác, hãy tự thêm nhóm và giải thích.

### Bài 12

Chọn object `Enemy` và trả lời:

- Component nào chịu trách nhiệm cho phần nhìn?
- Component nào chịu trách nhiệm cho tương tác?
- Script nào nên lo máu?
- Script nào nên lo di chuyển?

### Bài 13

Phân tích vì sao một script khổng lồ tên `PlayerEverything` là dấu hiệu chưa tốt.

Yêu cầu:

- Nêu ít nhất 5 vấn đề có thể xảy ra.
- Đề xuất cách tách nhỏ thành nhiều component.

## Phần 6: Bài tập thiết kế component

### Bài 14

Thiết kế một object `Door` có thể mở khi người chơi đến gần.

Liệt kê các thành phần có thể cần:

- Component hiển thị
- Collider
- Trigger
- Script mở cửa
- Animation nếu có

Yêu cầu:

- Viết ra luồng hoạt động từ lúc player đến gần đến lúc cửa mở.

### Bài 15

Thiết kế một object `Checkpoint`.

Yêu cầu:

- Mô tả các component tối thiểu.
- Giải thích vì sao checkpoint nên dùng trigger hơn là collision chặn vật lý.

### Bài 16

Thiết kế một object `Bullet`.

Yêu cầu:

- Viết ra bộ component cơ bản.
- Phân biệt object nào lo phần hiển thị, object nào lo phần gây sát thương.

## Phần 7: Bài tập debug tư duy

### Bài 17

Giả sử bạn gắn script lên object nhưng script không chạy.

Hãy viết checklist debug gồm ít nhất 8 bước.

Gợi ý:

- Object có đang active không?
- Component script có đang enabled không?
- Có lỗi compile trong console không?
- Script có kế thừa `MonoBehaviour` không?
- Tên file và tên class có khớp không?

### Bài 18

Giả sử object nhìn thấy được nhưng không va chạm.

Viết checklist kiểm tra.

Gợi ý:

- Có collider chưa?
- Có đúng loại 2D/3D không?
- Trigger có bật sai không?
- Layer có chặn nhau không?

### Bài 19

Giả sử object mất hình nhưng logic vẫn chạy.

Hãy giải thích ít nhất 3 khả năng có thể xảy ra.

## Phần 8: Mini scene task

### Bài 20

Tạo mini scene có:

- `Player`
- `Coin`
- `Door`
- `GameManager`

Yêu cầu:

- Mỗi object phải có tên rõ ràng.
- Mỗi object phải có ít nhất 2 component ngoài `Transform` nếu phù hợp.
- Với từng object, viết ngắn 1 dòng: object này tồn tại để làm gì?

### Bài 21

Tạo 3 coin trong scene.

Yêu cầu:

- Các coin dùng cùng một cách cấu hình component.
- Nếu đã biết prefab, thử tạo prefab.
- Nếu chưa biết prefab, mô tả vì sao copy cấu hình thủ công nhiều lần là bất tiện.

### Bài 22

Tạo object `EnemyGroup` và đặt 3 enemy con bên trong.

Yêu cầu:

- Di chuyển object cha.
- Quan sát toàn bộ enemy con.
- Trả lời: object cha có cần sprite không trong tình huống này?

## Phần 9: Câu hỏi phân tích ngắn

### Bài 23

Vì sao Unity ưu tiên tư duy component thay vì ép người học tạo một class kế thừa khổng lồ cho mỗi loại vật thể?

### Bài 24

Trong Unity, câu hỏi tốt hơn là:

- "Object này là loại gì?"
- hay "Object này có những component nào?"

Giải thích.

### Bài 25

Script của bạn có nên vừa đọc input, vừa trừ máu, vừa cập nhật UI, vừa xử lý animation trong cùng một file không? Vì sao?

## Phần 10: Bài tập theo bảng

### Bài 26

Hoàn thành bảng sau bằng cách tự ghi ra giấy hoặc file note:

- Tên object
- Component hiển thị
- Component va chạm
- Component vật lý
- Component logic
- Có cần là con của object nào không

Áp dụng cho:

- Player
- Enemy
- Coin
- Door
- Checkpoint
- Bullet

## Phần 11: Checklist hoàn thành

- Tôi hiểu `GameObject` không tự có nhiều chức năng nếu thiếu component.
- Tôi biết script Unity cũng là một component.
- Tôi biết tắt object và tắt component là hai việc khác nhau.
- Tôi biết quan hệ cha con ảnh hưởng tới object con.
- Tôi có thể mô tả một object bằng danh sách component của nó.
- Tôi đã tập phân tách trách nhiệm thay vì dồn vào một script duy nhất.

## Phần 12: Debug prompt cuối bài

- Nếu một object không hoạt động, tôi sẽ nhìn component nào trước?
- Nếu một object hiển thị sai, tôi nên kiểm tra renderer hay transform?
- Nếu object không va chạm, tôi cần nghĩ tới collider, rigidbody, layer hay callback?
- Nếu code ngày càng rối, tôi có đang cần tách thêm component không?

## Phần 13: Thử thách mở rộng

### Thử thách 1

Lấy một object bất kỳ trong scene và viết lại toàn bộ vai trò của nó chỉ bằng ngôn ngữ component.

### Thử thách 2

Chọn một object bạn đã tạo và đề xuất cách biến nó thành prefab tái sử dụng.

### Thử thách 3

Tự thiết kế một object mới tên `TrapSpike`.

Yêu cầu:

- Viết ra bộ component.
- Viết ra 1 luồng gameplay.
- Viết ra 1 lỗi debug có thể gặp.

## Phần 14: Kết luận ngắn

Khi thật sự hiểu bài này, bạn sẽ bớt hỏi kiểu:

- "Unity bị lỗi gì vậy?"

và bắt đầu hỏi đúng hơn:

- "Object này đang thiếu component nào?"
- "Component nào đang phụ trách phần hành vi này?"
- "Mình có đang nhét quá nhiều trách nhiệm vào một script không?"
