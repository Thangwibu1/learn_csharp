# Bài 2: Delegate, Action, Event

## Mục tiêu

- Hiểu delegate là gì ở góc nhìn truyền hành vi.
- Hiểu `Action` là delegate viết gọn có sẵn.
- Hiểu `event` là cơ chế phát tín hiệu để nơi khác đăng ký nghe.
- Thấy vì sao event rất hợp với UI, quest, achievement, audio.
- Biết các lỗi thường gặp như quên hủy đăng ký event.

## Vì sao phần này cực kỳ quan trọng trong game?

Game có rất nhiều thứ cần phản ứng với nhau.

Ví dụ khi người chơi mất máu:

- thanh máu phải cập nhật
- âm thanh trúng đòn có thể phát
- màn hình có thể rung
- achievement có thể kiểm tra
- AI đồng minh có thể phản ứng

Nếu `PlayerHealth` gọi trực tiếp từng hệ thống, code sẽ bị dính cứng.

Ví dụ kiểu xấu:

- `PlayerHealth` biết `HealthUI`
- `PlayerHealth` biết `AudioManager`
- `PlayerHealth` biết `AchievementTracker`

Class máu người chơi bỗng ôm quá nhiều phụ thuộc.

Delegate, `Action`, và `event` giúp giải quyết bài toán đó.

## Delegate là gì?

Delegate là một kiểu dữ liệu đại diện cho hàm.

Nói ngắn gọn:

- biến thường lưu số, chữ, object
- delegate lưu tham chiếu tới method

Ví dụ ý tưởng:

```csharp
delegate void SimpleCallback();
```

Biến kiểu delegate này có thể giữ một method phù hợp chữ ký.

## Cách hiểu đời thường

Hãy tưởng tượng delegate như một chiếc remote.

Remote không phải là TV.

Remote cũng không tự phát nội dung.

Nó chỉ giữ cách để gọi đúng hành động ở nơi khác.

Delegate cũng vậy.

Nó cho phép bạn truyền "cái cần gọi" như một dữ liệu.

## Vì sao điều này mạnh?

Vì bạn có thể truyền hành vi vào hàm, lưu nó lại, hoặc gọi nó sau.

Điều này mở ra rất nhiều kiểu thiết kế linh hoạt.

Ví dụ:

- callback sau khi hoàn thành tải dữ liệu
- hành động chạy khi người chơi chết
- logic chạy khi máu thay đổi
- phản ứng khi item được nhặt

## `Action` là gì?

`Action` là delegate viết gọn có sẵn trong C#.

Ví dụ:

```csharp
Action onPlayerDead;
```

Đây là một biến có thể lưu hàm không trả về giá trị.

Ngoài ra còn có:

- `Action<T>`
- `Action<T1, T2>`

Ví dụ:

```csharp
Action<int> onDamageTaken;
```

Hàm được gắn vào sẽ nhận một `int`.

## Tại sao `Action` hay được dùng hơn delegate tự định nghĩa?

Vì nó gọn và rất đủ cho nhiều tình huống phổ biến.

Trừ khi bạn cần đặt tên delegate riêng cho ý nghĩa rõ hơn, `Action` thường rất tiện.

## `event` là gì?

`Event` là cơ chế bao quanh delegate để tạo mô hình publish-subscribe an toàn hơn.

Hiểu đơn giản:

- một nơi phát tín hiệu
- nhiều nơi đăng ký nghe
- khi sự kiện xảy ra, nơi phát báo cho tất cả listener

Ví dụ:

```csharp
public event Action OnPlayerDead;
```

Khi người chơi chết:

```csharp
OnPlayerDead?.Invoke();
```

Những nơi đã đăng ký sẽ được gọi.

## Delegate và event khác nhau ở đâu?

Nhiều người mới hay trộn lẫn hai khái niệm này.

Hiểu đơn giản:

- delegate là nền tảng lưu tham chiếu hàm
- event là cách dùng delegate để phát sự kiện có kiểm soát hơn

`event` phù hợp khi bạn muốn class bên ngoài:

- chỉ được đăng ký hoặc hủy đăng ký
- không được tùy tiện gọi event thay bạn

Đây là lý do event rất hợp cho kiến trúc game.

## Tư duy Observer Pattern

Event rất gần với Observer Pattern.

Observer Pattern nghĩa là:

- có một subject phát thay đổi
- các observer quan tâm sẽ lắng nghe và phản ứng

Ví dụ trong game:

- `PlayerHealth` là subject
- `HealthUI` là observer
- `DamageFlashEffect` là observer
- `AchievementSystem` là observer

Khi máu đổi, `PlayerHealth` phát tín hiệu.

Các bên nghe tự xử lý phần việc của mình.

Điểm quan trọng là `PlayerHealth` không cần biết chi tiết từng nơi đang nghe.

## Ví dụ game: OnHealthChanged

```csharp
class PlayerHealth
{
    public int Health { get; private set; }
    public event Action<int> OnHealthChanged;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }

        OnHealthChanged?.Invoke(Health);
    }
}
```

Lúc này:

- UI có thể đăng ký
- âm thanh có thể đăng ký
- hệ thống khác cũng có thể đăng ký

Mỗi nơi tự phản ứng theo nhu cầu.

## Vì sao tốt hơn kiểm tra trong `Update()`?

Người mới hay làm kiểu này:

- mỗi frame kiểm tra xem máu có đổi không
- nếu đổi thì cập nhật UI

Điều đó vừa dư thừa vừa làm code thiếu rõ ràng.

Nếu máu chỉ đổi khi có hành động cụ thể, tốt hơn là phát event đúng thời điểm đổi.

Event giúp chương trình phản ứng theo sự kiện thật, thay vì polling liên tục.

## Các tình huống game rất hợp với event

- máu thay đổi
- người chơi chết
- item được nhặt
- quest hoàn thành
- wave kết thúc
- scene tải xong
- enemy bị tiêu diệt
- điểm số đổi

Những tình huống này đều có bản chất là:

- một điều gì đó xảy ra
- nhiều hệ thống khác có thể cần biết

## Delegate truyền hành vi như dữ liệu

Không chỉ event, delegate còn hữu ích khi bạn muốn truyền hành vi vào method.

Ví dụ ý tưởng:

- một method nhận callback để chạy sau khi xử lý xong
- một hệ thống spawn nhận hành vi cấu hình object sau khi tạo

Điều này làm code linh hoạt hơn rất nhiều.

## `Action` và dữ liệu đi kèm

Event trong game thường không chỉ báo "đã xảy ra" mà còn cần dữ liệu.

Ví dụ:

- máu mới là bao nhiêu
- item nào vừa được nhặt
- quest nào vừa hoàn thành

Khi đó `Action<T>` rất tiện.

Ví dụ:

```csharp
public event Action<string> OnItemCollected;
```

Hoặc:

```csharp
public event Action<int, int> OnHealthChanged;
```

Trong đó có thể truyền `currentHealth` và `maxHealth`.

## Event giúp decoupling như thế nào?

Hãy so sánh.

Thiết kế phụ thuộc cứng:

- `PlayerHealth` gọi trực tiếp `HealthUI.UpdateBar()`
- `PlayerHealth` gọi trực tiếp `AudioManager.PlayHitSound()`

Thiết kế event:

- `PlayerHealth` chỉ phát `OnHealthChanged`
- ai cần thì tự đăng ký

Lợi ích:

- thêm listener mới mà không sửa `PlayerHealth`
- bỏ listener cũ cũng không phải sửa `PlayerHealth`
- class phát sự kiện giữ trách nhiệm gọn hơn

## Event và vòng đời trong Unity

Đây là phần cực quan trọng thực chiến.

Trong Unity, nếu object đăng ký event mà không hủy đăng ký đúng lúc, bạn rất dễ gặp bug:

- object đã bị destroy nhưng vẫn còn listener
- callback gọi vào object không còn hợp lệ
- memory hoặc logic bị giữ ngoài ý muốn

Thói quen tốt là:

- đăng ký ở thời điểm phù hợp
- hủy đăng ký ở `OnDisable()` hoặc `OnDestroy()` tùy kiến trúc

Người mới thường quên bước này.

## Event không nên thay thế mọi lời gọi trực tiếp

Đây là cảnh báo quan trọng.

Không phải cứ có event là tốt hơn.

Nếu logic rất cục bộ, rất trực tiếp, giữa hai class gắn chặt về trách nhiệm, lời gọi trực tiếp có thể rõ hơn.

Event nên dùng khi:

- có nhiều listener
- bạn muốn broadcast thông tin
- bạn muốn giảm coupling

Nếu lạm dụng event cho mọi thứ, luồng chương trình sẽ khó theo dõi.

## Ví dụ nên dùng event

- `PlayerHealth` báo máu đổi cho nhiều hệ thống
- `Enemy` báo chết để cộng điểm, cập nhật quest, thả loot
- `SceneLoader` báo scene sẵn sàng

## Ví dụ không nhất thiết phải dùng event

- `Weapon` tự giảm đạn của chính nó
- `Inventory` tự thêm item vào list nội bộ của chính nó

Những logic nội bộ cục bộ không cần lúc nào cũng biến thành event.

## Sai lầm thường gặp của người mới

## 1. Không hiểu delegate thực ra chỉ là tham chiếu tới hàm

Nếu không nắm chỗ này, phần sau sẽ rất mơ hồ.

## 2. Dùng event nhưng quên hủy đăng ký

Đây là lỗi cực phổ biến trong Unity.

## 3. Dùng event cho mọi thứ

Điều này làm debug khó hơn vì luồng gọi bị phân tán khắp nơi.

## 4. Để class phát sự kiện nhưng cũng ôm luôn logic của mọi listener

Như vậy bạn chưa thật sự decouple.

## 5. Đặt tên event mơ hồ

Tên tốt nên mô tả rõ điều gì đã xảy ra.

Ví dụ tốt:

- `OnHealthChanged`
- `OnPlayerDead`
- `OnQuestCompleted`

## Nguyên tắc thực tế

1. Dùng delegate khi cần lưu hoặc truyền hành vi.
2. Dùng `Action` cho các callback phổ biến để code gọn.
3. Dùng `event` khi cần mô hình publish-subscribe.
4. Đăng ký và hủy đăng ký event có kỷ luật.
5. Chỉ phát event cho các thay đổi mà nhiều nơi thực sự cần quan tâm.

## Ghi nhớ nhanh

- Delegate = kiểu dữ liệu tham chiếu tới hàm.
- `Action` = delegate viết gọn, rất hay dùng.
- `event` = cơ chế phát sự kiện cho listener đăng ký.
- Event rất hợp với UI, quest, achievement, audio và observer pattern.
- Trong Unity, quên hủy đăng ký event là lỗi rất thường gặp.
