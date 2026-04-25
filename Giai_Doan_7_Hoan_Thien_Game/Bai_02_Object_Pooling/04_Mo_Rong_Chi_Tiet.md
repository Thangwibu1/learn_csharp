# Mở rộng chi tiết: Object Pooling

## 1. Pooling là tư duy tái sử dụng

- Thay vì tạo mới và phá hủy liên tục, ta giữ sẵn các object để dùng lại.
- Đây là một mẫu tư duy rất thực dụng trong game.
- Nó không chỉ là tối ưu hiệu năng.
- Nó còn buộc ta suy nghĩ rõ về vòng đời của object.

## 2. Vấn đề của tạo hủy liên tục

- `Instantiate` tạo object mới.
- `Destroy` hủy object cũ.
- Hai thao tác này không phải lúc nào cũng quá đắt, nhưng khi lặp rất nhiều sẽ tạo áp lực không cần thiết.
- Với các object sinh ra dồn dập như đạn, hiệu ứng, popup sát thương, vấn đề lộ ra rõ hơn.

## 3. Vì sao người mới nên học pooling sớm

- Học được tư duy quản lý tài nguyên.
- Học được cách reset trạng thái.
- Học được sự khác nhau giữa object đang sống và object đang chờ tái sử dụng.
- Học được khi nào tối ưu là hợp lý.

## 4. Pooling không phải thần chú

- Không phải cứ thêm pooling là game tự nhanh lên mọi chỗ.
- Pooling cũng tăng độ phức tạp code.
- Nếu dùng sai chỗ, bạn nhận thêm bug mà lợi ích rất ít.

## 5. Ví dụ dễ hiểu nhất là đạn

- Trong game bắn súng, đạn xuất hiện nhiều và sống ngắn.
- Mỗi viên đạn có vòng đời khá giống nhau.
- Điều này làm chúng rất hợp để được tái sử dụng.

## 6. Các thành phần tối thiểu của một pool

- prefab nguồn
- số lượng khởi tạo
- nơi lưu object rảnh
- hàm lấy object
- hàm trả object
- quy tắc mở rộng nếu cần

## 7. `Queue` thường là khởi đầu tốt

- Dễ đọc.
- Dễ giải thích.
- Phù hợp cho object xoay vòng.
- Không phải lựa chọn duy nhất nhưng rất hợp cho người mới.

## 8. Điều khó không nằm ở dequeue

- Việc lấy object ra khỏi queue khá dễ.
- Điều khó là đảm bảo object khi quay lại pool sạch trạng thái cũ.
- Đây là điểm cốt lõi của pooling.

## 9. Tái sử dụng nghĩa là phải quên quá khứ

- Object dùng lần trước có thể đã đổi màu.
- Có thể còn velocity.
- Có thể còn timer.
- Có thể còn trail.
- Có thể còn particle dở dang.
- Có thể còn biến `isActiveLogic` chưa reset.

## 10. Nếu quên reset sẽ xảy ra gì

- Đạn mới vừa sinh ra đã hết thời gian sống.
- Enemy hồi sinh với HP cũ.
- Trail kéo dài từ vị trí cũ sang vị trí mới.
- Hiệu ứng trúng đòn vẫn còn khi không đáng ra phải có.

## 11. Pooling giúp giảm garbage nhưng không xóa hết mọi chi phí

- Vẫn có chi phí update, physics, render.
- Nếu object active quá nhiều cùng lúc, game vẫn nặng.
- Pooling không thay thế cho tối ưu logic hoặc render.

## 12. Vòng đời object pooled

- được tạo lúc khởi tạo pool
- chờ trong trạng thái rảnh
- được lấy ra
- hoạt động trong scene
- hoàn thành công việc hoặc va chạm
- được trả về pool
- quay lại trạng thái chờ

## 13. Thiết kế `Get()` nên nghĩ gì

- Lấy object nào tiếp theo?
- Nếu object null do bị destroy thì sao?
- Nếu pool hết object thì sao?
- Có cho tự mở rộng không?
- Có ghi log cảnh báo không?

## 14. Thiết kế `Return()` nên nghĩ gì

- Có ngăn trả trùng một object không?
- Có reset trạng thái đầy đủ không?
- Có đưa object về parent quản lý không?
- Có giảm bộ đếm active không?

## 15. Pool mở rộng tự động có tốt không

- Tốt khi nhu cầu biến thiên khó đoán.
- Không tốt nếu bạn muốn kiểm soát chặt ngân sách object.
- Có thể che giấu bug cấu hình pool quá nhỏ.

## 16. Prewarm là gì

- Tạo sẵn object trước khi gameplay căng thẳng bắt đầu.
- Ví dụ load scene xong khởi tạo 50 bullet và 20 hit effect.
- Điều này đẩy chi phí tạo object ra giai đoạn an toàn hơn.

## 17. Pooling và prefab

- Prefab giúp đảm bảo mọi instance có cấu hình giống nhau.
- Nếu prefab thay đổi, pool nên được xem lại.
- Nếu thêm component mới như `TrailRenderer`, logic reset có thể phải cập nhật.

## 18. Pooled identity là một ý tưởng hữu ích

- Mỗi object biết pool chủ của mình.
- Khi object hoàn thành công việc, nó tự gọi trả về pool.
- Cách này giúp object và pool giao tiếp rõ hơn.

## 19. Nhưng cũng cần tránh coupling quá mức

- Đừng để object pooled biết quá nhiều về manager lớn hơn mức cần thiết.
- Nó chỉ cần biết cách quay về pool của nó.
- Phần logic game rộng hơn nên ở nơi khác.

## 20. Bullet là ví dụ đơn giản, enemy phức tạp hơn nhiều

- Bullet thường có timer, hướng bay, va chạm.
- Enemy còn có AI state, HP, animation, aggro, drop, path, cooldown.
- Vì vậy pooling cho enemy cần cẩn thận hơn nhiều.

## 21. Pooling cho particle và trail

- Trail rất dễ để lại dấu vết cũ.
- Particle có thể tiếp tục phát dở.
- Một số hiệu ứng cần dừng và xóa sạch trước khi tái sử dụng.

## 22. Pooling cho UI popup

- Damage text popup cũng là ứng viên tốt.
- Chúng xuất hiện nhiều, sống ngắn.
- Nhưng cần reset text, màu, animation, vị trí xuất phát.

## 23. Dùng pooling có thể làm debug khó hơn lúc đầu

- Vì object không biến mất vĩnh viễn.
- Nó chỉ tắt rồi quay lại.
- Người mới có thể nhầm tưởng object đang bị nhân đôi hoặc dùng sai object cũ.

## 24. Vì sao cần báo cáo debug

- Biết tổng số object.
- Biết số object đang active.
- Biết số object đang available.
- Biết lúc nào pool phải mở rộng.
- Biết có object nào không bao giờ được trả về hay không.

## 25. Một dấu hiệu bug rõ ràng

- Active count cứ tăng mà không giảm.
- Điều này thường cho thấy object không trở về pool.
- Khi đó, dù có pooling, bạn vẫn quay lại gần giống tạo mới liên tục.

## 26. Một dấu hiệu bug khác

- Available count vẫn còn nhưng `Get()` lại thất bại.
- Có thể queue chứa tham chiếu null.
- Có thể object đã bị destroy từ nơi khác.

## 27. Không nên vừa dùng pool vừa `Destroy` bừa bãi

- Nếu object thuộc pool nhưng bị `Destroy` trực tiếp, cấu trúc pool có thể còn tham chiếu lỗi.
- Cần quy định rõ object pooled phải được trả về, không hủy trực tiếp trừ trường hợp đặc biệt.

## 28. Tổ chức thư mục cũng quan trọng

- `Scripts/Pooling`
- `Scripts/Weapons`
- `Prefabs/Bullets`
- `Prefabs/Effects`
- `Scenes/PoolingDemo`

## 29. Tư duy test từng bước

- Test pool tạo đúng số lượng.
- Test lấy object.
- Test trả object.
- Test timer trả về.
- Test va chạm trả về.
- Test reset visual.

## 30. Không nên test tất cả cùng một lúc ngay từ đầu

- Nếu vừa thêm rigidbody, trail, damage, target, UI debug cùng lúc, khó biết bug đến từ đâu.
- Hãy xây từng lớp.

## 31. Quan hệ giữa pooling và gameplay feel

- Nếu pooling chuẩn, gameplay thường mượt hơn vì ít giật khung hình hơn.
- Nếu pooling lỗi, gameplay feel lại tệ hơn do object xuất hiện sai trạng thái.

## 32. Tình huống thực chiến 1

Đạn pooled va chạm chính người bắn.

- Có thể spawn trong collider của player.
- Có thể chưa bỏ qua collision giữa layer.
- Có thể fire point đặt sai.

## 33. Tình huống thực chiến 2

Đạn pooled đang bay nhưng bị thu hồi toàn bộ bởi nút reset.

- Đây có thể là hành vi debug đúng.
- Nhưng trong game thật cần cân nhắc tránh ảnh hưởng cảm giác chơi.

## 34. Tình huống thực chiến 3

Pool tăng kích thước liên tục dù tưởng rằng đã đủ lớn.

- Có thể object chưa return.
- Có thể lifetime quá dài.
- Có thể cooldown bắn quá thấp.
- Có thể pool size dự đoán ban đầu quá nhỏ.

## 35. Nên tính pool size thế nào

- ước lượng số object tối đa cùng tồn tại
- thêm biên độ an toàn
- quan sát qua profiler và debug
- điều chỉnh theo gameplay thật

## 36. Pooling và profiler

- Pooling không nên chỉ dựa trên cảm giác.
- Có thể dùng profiler để xem instantiate spike, GC và hành vi runtime.
- Với người mới, chỉ cần hiểu rằng công cụ đo là rất quan trọng.

## 37. Khi pooling cho enemy, cần reset gì

- HP
- AI state
- mục tiêu hiện tại
- timer kỹ năng
- vị trí spawn
- animation
- màu vật liệu
- drop flag
- hiệu ứng dính trên người

## 38. Khi pooling cho UI popup, cần reset gì

- text nội dung
- màu
- alpha
- scale
- vị trí bay lên
- thời gian sống

## 39. Mẫu kiến trúc đơn giản dễ học

- `Pool` quản lý object.
- `PooledIdentity` biết đường quay về.
- `PoolableBehaviour` reset khi spawn và return.
- `Spawner` yêu cầu object từ pool.

## 40. Mẫu kiến trúc lớn hơn

- `PoolRegistry` giữ nhiều pool bằng key.
- `SpawnService` yêu cầu object theo loại.
- `EffectSystem` và `WeaponSystem` dùng chung registry.
- Cách này mạnh hơn nhưng khó hơn cho beginner.

## 41. Khi nào không nên nhảy ngay lên registry đa loại

- Khi bạn mới học.
- Khi dự án còn nhỏ.
- Khi một pool riêng cho bullet đã đủ.

## 42. Học pooling cũng là học tính nhất quán

- Cùng một object phải luôn vào và ra theo quy tắc rõ ràng.
- Nếu một số object return, một số khác destroy, code dễ rối.

## 43. Prompt thiết kế 1

Nếu game của bạn có ba loại đạn khác nhau, bạn sẽ:

- dùng ba pool riêng
- hay một manager chung
- vì sao

## 44. Prompt thiết kế 2

Nếu scene chỉ có tối đa 5 missile nhưng mỗi missile rất nặng, bạn có dùng pooling không? Hãy giải thích.

## 45. Prompt kiến trúc 1

Viết sơ đồ luồng:

- PlayerInput
- GunController
- BulletPool
- PooledBullet
- TargetDummy

## 46. Prompt kiến trúc 2

Nếu sau này thêm hit effect pool, bạn sẽ tách script nào để không làm pool bullet gánh quá nhiều trách nhiệm?

## 47. Bài học ngầm từ pooling

- Tối ưu đúng chỗ quan trọng hơn tối ưu cho có.
- Tái sử dụng không miễn phí; nó cần kỷ luật reset.
- Kiến trúc nhỏ nhưng rõ thường tốt hơn hệ thống lớn nhưng mơ hồ.

## 48. Checklist trước khi kết luận pool đã ổn

- Lấy object đúng chưa?
- Trả object đúng chưa?
- Reset đủ chưa?
- Không destroy nhầm chưa?
- Debug count hợp lý chưa?
- Không có object bị kẹt active vĩnh viễn chứ?

## 49. Tổng kết cốt lõi

- Object pooling phù hợp với object xuất hiện nhiều và sống ngắn.
- Giá trị thật sự của pooling nằm ở giảm tạo hủy lặp lại và buộc thiết kế vòng đời rõ ràng.
- Khó nhất là reset trạng thái khi tái sử dụng.
- Nếu làm đúng, đây là công cụ rất mạnh và rất thực tế.

## Câu hỏi ôn tập mở rộng

### Câu 1

Tại sao pooling thường đi cùng với nhu cầu reset state?

### Câu 2

Vì sao `Destroy` trực tiếp object pooled có thể gây bug?

### Câu 3

Khi nào pool tự mở rộng là hợp lý, khi nào lại che giấu vấn đề?

### Câu 4

Nếu object pooled có animation, bạn sẽ reset ra sao?

### Câu 5

Bạn sẽ giải thích pooling cho một bạn mới hoàn toàn bằng ví dụ đời thường nào?

## Bài viết tự phản tư

Viết từ 15 đến 25 dòng về chủ đề:

"Object pooling tưởng là tối ưu hiệu năng, nhưng thực ra còn dạy mình cách thiết kế vòng đời object rõ ràng hơn."
