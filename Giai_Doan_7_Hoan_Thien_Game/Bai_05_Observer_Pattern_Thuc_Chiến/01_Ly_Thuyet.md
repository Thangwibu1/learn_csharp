# Bài 5: Observer Pattern cho Achievement và UI Máu

## Mục tiêu

- Hiểu Observer Pattern trong ngữ cảnh phát triển game.
- Biết vì sao pattern này rất hữu ích cho UI máu, achievement và nhiều hệ thống phản ứng theo sự kiện.
- Hiểu vai trò của `delegate`, `Action`, và `event` trong C# ở mức ứng dụng thực tế.
- Biết sự khác nhau giữa tư duy polling liên tục và tư duy phản ứng theo sự kiện.
- Tránh các lỗi phổ biến như quên hủy đăng ký event hoặc để UI biết quá sâu về gameplay.
- Có nền tảng để xây hệ thống game bớt phụ thuộc, gọn hơn và dễ mở rộng hơn.

## Bức tranh tổng quan

Trong game, rất nhiều thứ cần phản ứng khi một dữ liệu thay đổi.

Ví dụ:

- người chơi mất máu thì thanh máu phải cập nhật
- người chơi nhặt coin thì UI coin phải đổi số
- người chơi hạ đủ 100 quái thì hệ thống achievement mở thành tựu
- boss chết thì cửa mở, nhạc đổi, màn hình hiển thị thông báo chiến thắng

Người mới thường xử lý theo kiểu polling:

- mỗi frame kiểm tra máu có đổi không
- mỗi frame kiểm tra số quái hạ có đạt mốc không
- mỗi frame kiểm tra cửa có nên mở chưa

Polling không phải lúc nào cũng sai.

Nhưng khi lạm dụng, nó làm code:

- dài dòng
- tốn kiểm tra vô ích
- khó theo dõi luồng phản ứng
- dễ làm nhiều hệ thống phụ thuộc cứng vào nhau

Observer Pattern đưa ra cách nghĩ khác:

Khi dữ liệu đổi, hãy phát tín hiệu.

Ai quan tâm thì nghe và tự phản ứng.

## Khái niệm

Observer Pattern là mẫu thiết kế trong đó một đối tượng phát thông báo khi trạng thái của nó thay đổi, còn các đối tượng quan tâm sẽ đăng ký lắng nghe để phản ứng tương ứng.

Nói dễ hiểu hơn:

- có một nơi phát tin
- có nhiều nơi nghe tin
- khi sự kiện xảy ra, nơi phát tin thông báo
- nơi nghe tự làm phần việc của mình

Trong bối cảnh game:

- `PlayerHealth` có thể là nơi phát tin khi máu đổi
- `HealthBarUI` là nơi nghe để cập nhật thanh máu
- `AchievementSystem` cũng có thể nghe để kiểm tra một số điều kiện

## Ý tưởng chính

Khi dữ liệu đổi, hệ thống phát tín hiệu.

Những nơi quan tâm sẽ tự nghe và phản ứng.

Ví dụ:

- Player mất máu
- UI máu cập nhật ngay
- Achievement system kiểm tra thành tựu ngay

Không cần mỗi frame phải hỏi:

“Máu có đổi chưa?”

Đây chính là điểm mạnh của cách tiếp cận theo sự kiện.

## Tại sao phải dùng cái này?

### 1. Giảm phụ thuộc giữa các hệ thống

Nếu `PlayerHealth` tự đi tìm UI, tự cập nhật achievement, tự gọi âm thanh, tự báo camera rung, class đó sẽ biết quá nhiều thứ.

Observer giúp tách bớt sự dính chặt đó.

### 2. Giảm polling vô ích

Nếu máu chỉ đổi vài lần, không cần mỗi frame đều kiểm tra.

### 3. Code thể hiện đúng ý hơn

Khi đọc code event, bạn hiểu:

- lúc nào sự kiện được phát
- ai đang phản ứng với nó

### 4. Dễ mở rộng thêm phản ứng mới

Ví dụ ban đầu máu đổi chỉ cập nhật UI.

Sau này bạn muốn thêm:

- hiệu ứng đỏ màn hình
- âm thanh trúng đòn
- log analytics

Bạn có thể đăng ký listener mới mà không cần nhồi thêm trách nhiệm vào `PlayerHealth`.

## Liên hệ game thực tế

### UI máu

Khi người chơi nhận sát thương:

- máu đổi
- thanh máu cập nhật
- có thể thêm animation nhấp nháy

Observer Pattern cực kỳ hợp với bài toán này.

### Achievement

Ví dụ thành tựu:

- hạ 100 quái
- không bị trúng đòn trong 1 màn
- thu thập đủ 50 coin

Achievement system thường không nên chui vào từng class gameplay để tự sửa logic.

Thay vào đó, nó nên lắng nghe các sự kiện quan trọng.

### Hệ thống quest

Quest có thể lắng nghe các sự kiện như:

- nhặt item
- nói chuyện NPC
- hạ boss

### Audio và VFX

Âm thanh hoặc hiệu ứng cũng có thể phản ứng theo sự kiện thay vì bị gọi cứng từ mọi nơi.

## Polling và Event khác nhau thế nào?

### Polling

Là cách liên tục hỏi lại xem điều gì đã thay đổi chưa.

Ví dụ:

```csharp
private void Update()
{
    if (playerHealth.CurrentHealth != cachedHealth)
    {
        cachedHealth = playerHealth.CurrentHealth;
        UpdateUI();
    }
}
```

Code này có thể chạy được.

Nhưng nó hỏi đi hỏi lại mỗi frame.

### Event-driven

Là cách phản ứng khi sự kiện thực sự xảy ra.

Ví dụ ý tưởng:

- máu đổi
- phát sự kiện `OnHealthChanged`
- UI nghe sự kiện và cập nhật ngay

Tư duy này thường gọn hơn cho nhiều bài toán phản ứng.

## `delegate`, `Action`, `event` là gì trong ngữ cảnh này?

Bạn không cần quá nặng phần lý thuyết ngôn ngữ lúc đầu.

Hãy hiểu ở mức ứng dụng:

### `delegate`

Là kiểu đại diện cho hàm.

Nó cho phép bạn lưu hoặc truyền tham chiếu tới hàm.

### `Action`

Là một dạng delegate có sẵn, rất tiện cho nhiều trường hợp không cần tự khai báo delegate riêng.

### `event`

Là cách an toàn hơn để công bố rằng một lớp cho phép bên ngoài đăng ký lắng nghe sự kiện.

Trong thực tế Unity C#, bạn sẽ rất hay gặp kiểu:

```csharp
public event Action<int, int> OnHealthChanged;
```

Ý nghĩa có thể là:

- khi máu đổi
- phát ra máu hiện tại và máu tối đa

## Ví dụ tư duy cơ bản: UI máu

Giả sử có class quản lý máu người chơi.

Khi máu thay đổi, thay vì tự gọi thẳng `healthBar.SetValue(...)`, class đó có thể phát sự kiện.

UI máu sẽ lắng nghe sự kiện đó.

Lợi ích:

- `PlayerHealth` không cần biết UI cụ thể nào tồn tại
- sau này thêm UI khác vẫn dễ
- nếu đổi giao diện, gameplay ít bị ảnh hưởng hơn

## Ví dụ mã ý tưởng

```csharp
using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    public event Action<int, int> OnHealthChanged;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth = Mathf.Max(0, currentHealth - damage);
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }
}
```

Một script UI có thể đăng ký nghe event này.

Điều quan trọng là ý tưởng tổ chức, không phải chỉ riêng cú pháp.

## Ví dụ tư duy: Achievement

Giả sử game có achievement “Nhận 100 sát thương tổng cộng”.

Achievement system có thể nghe sự kiện máu đổi hoặc sự kiện người chơi bị thương.

Khi đó:

- `PlayerHealth` chỉ làm đúng việc quản lý máu
- `AchievementSystem` tự quản lý tiến độ thành tựu

Không cần nhét logic achievement vào class máu.

Đây là một ví dụ rất đẹp của việc giảm phụ thuộc.

## Quy trình suy nghĩ khi áp dụng Observer Pattern

### Bước 1: Xác định dữ liệu hoặc hành vi nào là nguồn phát sự kiện

Ví dụ:

- máu thay đổi
- coin thay đổi
- boss chết
- item được nhặt
- quest hoàn thành

### Bước 2: Xác định những hệ thống nào cần phản ứng

Ví dụ:

- UI
- achievement
- audio
- VFX
- quest tracker

### Bước 3: Tự hỏi: bên phát có cần biết trực tiếp từng bên nghe không?

Nếu không cần, observer thường là hướng rất tốt.

### Bước 4: Thiết kế dữ liệu gửi theo sự kiện

Ví dụ:

- chỉ gửi máu hiện tại
- hoặc gửi máu hiện tại và máu tối đa
- hoặc gửi loại item vừa nhặt

### Bước 5: Xử lý vòng đời đăng ký và hủy đăng ký

Trong Unity, đây là bước cực kỳ quan trọng.

## Vì sao `OnEnable` và `OnDisable` thường đi cùng event?

Một pattern rất phổ biến trong Unity là:

- đăng ký lắng nghe ở `OnEnable`
- hủy đăng ký ở `OnDisable`

Lý do:

- object bật thì nghe
- object tắt thì ngừng nghe
- giảm nguy cơ callback gọi vào object không còn hợp lệ

Ví dụ tinh thần:

```csharp
private void OnEnable()
{
    playerHealth.OnHealthChanged += HandleHealthChanged;
}

private void OnDisable()
{
    playerHealth.OnHealthChanged -= HandleHealthChanged;
}
```

## Những lỗi sai thường gặp của người mới

### 1. Quên hủy đăng ký event trong Unity

Đây là lỗi kinh điển.

Hậu quả có thể là:

- listener bị gọi nhiều lần
- object đã tắt vẫn bị gọi callback
- lỗi khó debug

### 2. UI biết quá nhiều về class gameplay cụ thể

Ví dụ UI tự đi tìm và điều khiển nội bộ `PlayerHealth` theo cách quá sâu.

UI nên chủ yếu hiển thị và phản ứng, không nên ôm quá nhiều logic gameplay.

### 3. Phát sự kiện ở quá nhiều nơi không nhất quán

Nếu cùng một loại thay đổi mà lúc thì phát event, lúc thì không, hệ thống sẽ khó tin cậy.

### 4. Dùng event cho mọi thứ dù không cần

Observer mạnh, nhưng không phải mọi chỗ đều phải biến thành event.

Nếu dùng quá tay, luồng chương trình có thể khó lần theo.

### 5. Gửi dữ liệu sự kiện quá nghèo hoặc quá dư thừa

Gửi thiếu thì listener phải tự đi hỏi thêm nhiều nơi.

Gửi thừa thì event trở nên nặng và khó kiểm soát.

### 6. Không phân biệt sự kiện gameplay và cập nhật trực tiếp thật sự đơn giản

Có những chỗ rất nhỏ, gọi trực tiếp vẫn ổn.

Điều quan trọng là dùng observer ở nơi nó đem lại lợi ích rõ ràng.

## Khi nào observer đặc biệt đáng dùng?

- Khi có một nguồn dữ liệu thay đổi và nhiều nơi cần phản ứng.
- Khi bạn muốn giảm phụ thuộc giữa gameplay và UI.
- Khi các hệ thống như achievement, quest, analytics, audio cùng cần biết một sự kiện.
- Khi polling mỗi frame là thừa hoặc làm code khó đọc.

## Khi nào chưa nhất thiết phải dùng?

- Logic cực nhỏ, dùng trực tiếp là đủ rõ.
- Chưa có nhiều nơi cùng quan tâm sự kiện đó.
- Hệ thống còn rất đơn giản và event sẽ làm phức tạp quá mức.

Điều quan trọng là dùng đúng chỗ.

## Mẹo thực hành tốt cho người mới

- Bắt đầu từ các trường hợp rất rõ như UI máu hoặc coin.
- Đặt tên event theo ý nghĩa rõ ràng.
- Luôn quản lý đăng ký và hủy đăng ký cẩn thận.
- Đừng để class phát sự kiện phải biết hết mọi listener.
- Tự hỏi event này giúp giảm phụ thuộc hay chỉ thêm phức tạp.

## Một checklist hữu ích khi dùng observer

- Nguồn phát sự kiện là gì?
- Những ai thực sự cần nghe?
- Có cần gửi dữ liệu gì kèm theo?
- Listener đăng ký ở đâu và hủy ở đâu?
- Có đang dùng event ở nơi quá nhỏ, không đáng không?
- Có chỗ nào UI đang biết quá sâu về gameplay không?

## Tóm tắt

- Observer Pattern là cách để một đối tượng phát thông báo khi trạng thái đổi, còn các đối tượng quan tâm sẽ lắng nghe và phản ứng.
- Trong game, pattern này rất hữu ích cho UI máu, achievement, quest, audio, VFX và nhiều hệ thống phản ứng theo sự kiện.
- Nó giúp giảm phụ thuộc, giảm polling vô ích và làm code dễ mở rộng hơn.
- `delegate`, `Action`, và `event` là những công cụ C# thường dùng để hiện thực tư duy này.
- Trong Unity, cần đặc biệt chú ý việc đăng ký và hủy đăng ký event đúng vòng đời.
- Lỗi phổ biến là quên hủy đăng ký, hoặc để UI biết quá nhiều về gameplay cụ thể.

## Tự kiểm tra

1. Observer Pattern là gì?
2. Vì sao pattern này hợp với UI máu?
3. Vì sao pattern này hợp với achievement?
4. Polling khác event-driven ở điểm nào?
5. `Action` và `event` thường giúp ích gì trong bối cảnh Unity C#?
6. Vì sao `PlayerHealth` không nên tự biết chi tiết về tất cả UI và achievement đang tồn tại?
7. Khi nào nên đăng ký và hủy đăng ký event trong Unity?
8. Hãy nêu 3 lỗi phổ biến của người mới khi dùng observer.
9. Hãy nêu 3 trường hợp khác ngoài UI máu mà observer rất hữu ích trong game.
10. Khi nào dùng observer có thể là quá mức cần thiết?

## Bài tập suy nghĩ thêm

- Hãy nghĩ về sự kiện “người chơi nhặt coin”.
- Liệt kê những hệ thống nào có thể muốn phản ứng với sự kiện đó.
- Sau đó thử so sánh hai cách: mọi hệ thống tự kiểm tra trong `Update`, và hệ thống phát một event khi coin được nhặt.
- Tự đánh giá cách nào rõ hơn, dễ mở rộng hơn.

Khi bạn hiểu chắc Observer Pattern, bạn sẽ bắt đầu viết các hệ thống game bớt dính chặt, phản ứng tốt hơn và dễ mở rộng hơn rất nhiều.
