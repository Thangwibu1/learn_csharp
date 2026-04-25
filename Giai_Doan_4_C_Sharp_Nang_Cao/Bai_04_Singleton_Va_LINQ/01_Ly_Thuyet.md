# Bài 4: Singleton và LINQ Cơ Bản

## Mục tiêu

- Hiểu Singleton Pattern là gì và vì sao người mới rất hay dùng nó.
- Biết khi nào Singleton phù hợp và khi nào nó trở thành vấn đề.
- Hiểu các nguyên tắc dùng singleton an toàn hơn.
- Làm quen với LINQ để lọc, tìm và sắp xếp dữ liệu gọn hơn.
- Thấy mối liên hệ giữa singleton, data access và truy vấn dữ liệu trong game.

## Vì sao ghép Singleton và LINQ trong cùng bài?

Hai chủ đề này khác nhau, nhưng đều liên quan tới cách bạn tổ chức và truy cập dữ liệu trong game.

- Singleton liên quan đến cách truy cập hệ thống toàn cục hoặc gần toàn cục.
- LINQ liên quan đến cách truy vấn dữ liệu trong collections.

Một bên nói về nơi dữ liệu hoặc service nằm ở đâu.

Một bên nói về cách lấy ra phần bạn cần từ dữ liệu đó.

## Singleton là gì?

Singleton là mẫu thiết kế đảm bảo một class chỉ có đúng một instance và cung cấp điểm truy cập tới instance đó.

Ví dụ game hay gặp:

- `GameManager`
- `AudioManager`
- `SaveManager`
- `SceneLoader`

Người mới rất thích singleton vì nó tiện.

Chỉ cần một nơi là có thể truy cập từ nhiều nơi khác.

## Vì sao Singleton hấp dẫn?

## 1. Dễ bắt đầu

Trong dự án nhỏ, việc có một `GameManager.Instance` rất tiện.

## 2. Truy cập nhanh từ nhiều nơi

Bạn không cần truyền tham chiếu qua nhiều lớp.

## 3. Hợp với một số hệ thống thật sự duy nhất

Ví dụ:

- quản lý âm thanh tổng
- quản lý lưu game
- quản lý scene chính

Ở bề mặt, Singleton trông như giải pháp cực đẹp.

## Nhưng vì sao Singleton nguy hiểm nếu lạm dụng?

Vì nó rất dễ biến thành "biến toàn cục mặc vest".

Nghĩa là nhìn có vẻ được tổ chức, nhưng thực chất:

- ai cũng truy cập được
- ai cũng có thể phụ thuộc vào nó
- mọi hệ thống dính vào nó

Hậu quả:

- coupling tăng mạnh
- khó test
- khó thay thế implementation
- khó kiểm soát phụ thuộc
- `GameManager` biến thành nơi chứa mọi thứ

## Dấu hiệu lạm dụng Singleton

- `GameManager` giữ cả score, audio, inventory, quest, save, UI, wave, analytics.
- Class nào cũng gọi `SomeManager.Instance`.
- Logic gameplay cốt lõi không chạy nổi nếu không có singleton toàn cục.
- Muốn test một class nhỏ cũng phải dựng cả đống manager.

Đây là dấu hiệu kiến trúc đang bị phụ thuộc quá nhiều vào truy cập toàn cục.

## Khi nào Singleton hợp lý?

- Hệ thống thật sự chỉ nên có một bản thể.
- Trách nhiệm của nó rõ ràng.
- Vòng đời của nó rõ ràng.
- Nó không bị biến thành trung tâm của mọi logic gameplay.

Ví dụ khá hợp lý:

- `AudioManager` quản lý phát nhạc tổng thể
- `SaveManager` quản lý lưu và tải dữ liệu
- `SceneTransitionManager` điều phối chuyển scene

## Khi nào nên cẩn thận hoặc tránh?

- Khi class đó không thật sự cần duy nhất.
- Khi bạn chỉ dùng singleton vì "tiện gọi từ mọi nơi".
- Khi gameplay core bắt đầu phụ thuộc cứng vào singleton.
- Khi muốn tái sử dụng hoặc test class nhưng bị kéo theo nhiều phụ thuộc ẩn.

## Singleton an toàn hơn nghĩa là gì?

Ở mức học cơ bản, "an toàn hơn" ở đây có hai ý.

## 1. An toàn kiến trúc

Tức là dùng singleton có kỷ luật.

- trách nhiệm nhỏ và rõ
- không nhồi mọi thứ vào một manager khổng lồ
- hạn chế số nơi phụ thuộc trực tiếp nếu có thể

## 2. An toàn khởi tạo

Tức là hạn chế lỗi như:

- có nhiều instance ngoài ý muốn
- instance chưa có mà nơi khác đã gọi
- thứ tự khởi tạo không ổn định

Trong Unity, đây là vấn đề thực tế thường gặp hơn nhiều so với người mới tưởng.

## Những nguyên tắc dùng Singleton an toàn hơn

## 1. Giữ trách nhiệm hẹp

`AudioManager` nên quản lý âm thanh.

Nó không nên kiêm luôn:

- quest
- inventory
- gameplay balance

## 2. Tránh biến `GameManager` thành thùng rác tổng

`GameManager` là cái tên rất nguy hiểm nếu bạn không kiểm soát.

Nó dễ bị thêm đủ mọi thứ chỉ vì "đang tiện có sẵn".

## 3. Rõ vòng đời

Hệ thống singleton sống trong scene nào?

Có xuyên scene không?

Khởi tạo từ lúc nào?

Ai đảm bảo nó sẵn sàng trước khi được dùng?

Đây là câu hỏi thực chiến rất quan trọng.

## 4. Không lạm dụng truy cập toàn cục cho logic gameplay

Ví dụ `Enemy`, `Weapon`, `Quest`, `InventorySlot` nếu chỗ nào cũng gọi singleton để lấy đủ thứ, code sẽ rất dính cứng.

## 5. Nghĩ tới khả năng thay thế về sau

Ở dự án nhỏ, singleton có thể chấp nhận được.

Nhưng hãy giữ cửa cho việc sau này tách thành service hoặc dependency rõ hơn nếu dự án lớn lên.

## Ví dụ thiết kế xấu

```csharp
GameManager.Instance.PlayerHealth -= 10;
GameManager.Instance.PlaySound("hit");
GameManager.Instance.SaveNow();
GameManager.Instance.UpdateQuestProgress();
```

Mọi thứ chui qua cùng một cửa.

Class gọi không chỉ phụ thuộc vào một manager, mà phụ thuộc vào một manager biết làm mọi thứ.

Đây là dấu hiệu rất xấu.

## Ví dụ thiết kế đỡ hơn

Thay vì một `GameManager` khổng lồ, tách rõ hơn:

- `AudioManager`
- `SaveManager`
- `SceneLoader`

Mỗi singleton, nếu thật sự cần, chỉ mang một trách nhiệm rõ hơn.

## Singleton và thread safety

Ở giai đoạn này bạn chưa cần đi sâu đa luồng, nhưng nên biết một ý nền tảng:

- singleton không chỉ là có biến `static`
- cách khởi tạo cũng liên quan tới an toàn nếu môi trường có đa luồng

Trong game beginner hoặc Unity scripting cơ bản, bạn chưa thường xuyên đụng vấn đề này ngay.

Nhưng cụm từ "singleton safety" còn nhắc bạn rằng thiết kế singleton không chỉ là viết vài dòng `Instance`.

Bạn cần nghĩ về:

- số lượng instance
- thời điểm tạo
- nơi truy cập
- vòng đời

## LINQ là gì?

LINQ là bộ công cụ giúp truy vấn dữ liệu trong collections theo cách ngắn gọn và dễ diễn đạt hơn.

Bạn có thể dùng LINQ để:

- lọc dữ liệu
- tìm phần tử
- sắp xếp
- biến đổi danh sách

Ví dụ:

```csharp
var highScores = scores.Where(score => score >= 100);
```

## Vì sao LINQ hữu ích trong game?

Game có rất nhiều collections:

- danh sách item
- danh sách enemy
- quest list
- loot table
- save records

Rất thường xuyên bạn cần:

- tìm enemy còn sống
- lọc item hiếm
- lấy quest chưa hoàn thành
- sắp xếp bảng điểm

Nếu luôn viết vòng `for` hoặc `foreach` dài dòng, code sẽ nhiều phần lặp lại.

LINQ giúp viết ý định rõ hơn.

## Một số thao tác LINQ cơ bản cực hữu ích

## 1. `Where`

Dùng để lọc.

Ví dụ:

```csharp
var aliveEnemies = enemies.Where(enemy => enemy.Health > 0);
```

Ý nghĩa rất rõ:

- lấy các enemy còn sống

## 2. `First` hoặc `FirstOrDefault`

Dùng để lấy phần tử đầu tiên thỏa điều kiện.

Ví dụ:

```csharp
var boss = enemies.FirstOrDefault(enemy => enemy.IsBoss);
```

Rất tiện khi cần tìm một đối tượng thỏa điều kiện nào đó.

## 3. `OrderBy`

Dùng để sắp xếp.

Ví dụ:

```csharp
var sortedScores = scores.OrderBy(score => score);
```

Hoặc bảng điểm giảm dần:

```csharp
var topScores = scores.OrderByDescending(score => score);
```

## 4. `Select`

Dùng để biến đổi dữ liệu.

Ví dụ:

```csharp
var enemyNames = enemies.Select(enemy => enemy.Name);
```

Bạn lấy ra danh sách tên thay vì cả object enemy.

## 5. `Any`

Dùng để kiểm tra có phần tử thỏa điều kiện không.

Ví dụ:

```csharp
bool hasDeadEnemy = enemies.Any(enemy => enemy.Health <= 0);
```

Rất gọn và dễ đọc.

## Ví dụ game thực tế với LINQ

### Lọc item hiếm

```csharp
var rareItems = inventory.Where(item => item.Rarity >= 4);
```

### Tìm quest chưa hoàn thành

```csharp
var activeQuests = quests.Where(quest => !quest.IsCompleted);
```

### Lấy tên của enemy đang sống

```csharp
var aliveEnemyNames = enemies
    .Where(enemy => enemy.Health > 0)
    .Select(enemy => enemy.Name);
```

Đây là kiểu code biểu đạt ý định rất tốt.

## LINQ làm code ngắn hơn, nhưng đừng biến nó thành câu đố

Đây là điểm quan trọng.

Code LINQ quá dài và lồng nhiều tầng có thể trở nên khó đọc.

Nguyên tắc tốt là:

- dùng LINQ khi nó làm ý đồ rõ hơn
- không dùng LINQ chỉ để viết ít dòng hơn bằng mọi giá

Nếu một truy vấn quá phức tạp, tách thành nhiều bước hoặc dùng vòng lặp bình thường có thể dễ hiểu hơn.

## LINQ và hiệu năng

Ở giai đoạn đầu, điều cần quan tâm hơn là dùng LINQ đúng chỗ và đọc được.

Tuy nhiên, đừng nghĩ LINQ là phép màu dùng ở mọi nơi mà không suy nghĩ.

Nếu bạn đang ở đoạn code cực nóng chạy liên tục mỗi frame với dữ liệu lớn, nên cẩn thận hơn và đo đạc nếu cần.

Nguyên tắc thực dụng là:

- gameplay thông thường: LINQ rất hữu ích khi làm code rõ hơn
- chỗ cực nhạy hiệu năng: cần cân nhắc và kiểm tra kỹ hơn

## Mối liên hệ giữa Singleton và LINQ trong game

Giả sử bạn có `ItemDatabase` được quản lý bởi một hệ thống duy nhất.

Bạn có thể truy cập database rồi dùng LINQ để lọc dữ liệu phù hợp cho UI hoặc gameplay.

Điểm cần nhớ là:

- singleton chỉ là cách truy cập hệ thống
- LINQ là cách truy vấn dữ liệu bên trong nó

Đừng để singleton che giấu mọi phụ thuộc.

Và cũng đừng viết truy vấn LINQ rối đến mức khó bảo trì.

## Sai lầm thường gặp của người mới

## 1. Dùng Singleton cho mọi hệ thống chỉ vì tiện

Đây là lỗi rất phổ biến và rất nguy hiểm khi dự án lớn lên.

## 2. Tạo `GameManager` ôm mọi thứ

Đây là con đường nhanh nhất để có class khổng lồ khó bảo trì.

## 3. Không nghĩ về vòng đời singleton

Ví dụ instance chưa sẵn sàng mà code khác đã gọi.

## 4. Dùng LINQ ở mọi nơi mà không hiểu rõ đang làm gì

Nếu bạn không đọc được truy vấn của chính mình, đừng dùng LINQ kiểu đó.

## 5. Viết LINQ quá dài thành khó đọc

Ngắn hơn không phải lúc nào cũng tốt hơn.

## Nguyên tắc thực tế cần nhớ

1. Singleton chỉ dùng cho hệ thống thật sự nên có một bản thể.
2. Giữ singleton nhỏ, rõ trách nhiệm, rõ vòng đời.
3. Tránh biến singleton thành trung tâm của mọi phụ thuộc.
4. Dùng LINQ khi nó làm truy vấn dữ liệu rõ hơn.
5. Nếu truy vấn quá phức tạp hoặc quá nóng về hiệu năng, cân nhắc cách viết khác.

## Ghi nhớ nhanh

- Singleton tiện nhưng dễ bị lạm dụng.
- Singleton an toàn hơn khi trách nhiệm hẹp và vòng đời rõ.
- LINQ giúp lọc, tìm, sắp xếp và biến đổi dữ liệu gọn hơn.
- `Where`, `Select`, `OrderBy`, `FirstOrDefault`, `Any` là các thao tác rất hay dùng.
- Cả singleton lẫn LINQ đều nên dùng có kỷ luật, không dùng theo cảm hứng.
