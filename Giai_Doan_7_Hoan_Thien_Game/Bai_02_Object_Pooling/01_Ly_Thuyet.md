# Bài 2: Object Pooling

## Mục tiêu

- Hiểu object pooling là gì.
- Biết vì sao tạo và hủy object liên tục có thể gây vấn đề trong game.
- Hiểu khi nào nên dùng pooling, khi nào chưa cần.
- Nắm được tư duy tái sử dụng object thay vì cấp phát mới liên tục.
- Biết vai trò của cấu trúc dữ liệu như `Queue<T>` trong bài toán pool.
- Tránh các lỗi phổ biến khi mới áp dụng pooling.

## Bức tranh tổng quan

Khi làm game, có rất nhiều object xuất hiện rồi biến mất liên tục.

Ví dụ:

- đạn
- hiệu ứng nổ
- tia lửa
- kẻ địch nhỏ sinh ra theo đợt
- popup sát thương
- mảnh vỡ

Người mới thường giải quyết theo cách rất tự nhiên:

- cần thì `Instantiate`
- xong thì `Destroy`

Ở mức đơn giản, cách này không sai.

Nhưng khi tần suất cao, đặc biệt trên thiết bị yếu hoặc game có nhịp nhanh, việc tạo hủy liên tục có thể gây:

- tốn chi phí xử lý
- tạo rác bộ nhớ
- tăng áp lực cho garbage collector
- làm game giật khung hình

Object pooling là một cách rất thực tế để giảm các vấn đề đó.

## Khái niệm

Object pooling là kỹ thuật tạo sẵn một nhóm object rồi tái sử dụng chúng nhiều lần, thay vì liên tục tạo mới và hủy đi.

Hãy hình dung thế này:

- thay vì thuê người xây một cái ghế mới mỗi lần cần ngồi rồi đập bỏ sau khi ngồi xong
- bạn chuẩn bị sẵn một chồng ghế
- ai cần thì lấy ra dùng
- dùng xong thì trả về chỗ cũ

Trong game, “ghế” ở đây là object.

Pool là “kho object có thể tái dùng”.

## Tại sao phải dùng cái này?

### 1. Giảm chi phí tạo hủy liên tục

`Instantiate` và `Destroy` không miễn phí.

Chúng có chi phí xử lý, đặc biệt khi diễn ra rất nhiều lần trong thời gian ngắn.

### 2. Giảm rác bộ nhớ

Khi object bị tạo và hủy liên tục, bộ nhớ có thể phát sinh nhiều rác hơn.

Điều đó làm garbage collector phải dọn nhiều hơn.

### 3. Giảm giật khung hình

Trong game hành động nhanh, một nhịp giật nhỏ cũng đủ làm trải nghiệm tệ đi rõ rệt.

Pooling giúp hạn chế một phần nguyên nhân gây ra hiện tượng đó.

### 4. Tăng tính kiểm soát

Khi dùng pool, bạn biết mình có bao nhiêu object đang được chuẩn bị sẵn.

Điều này hữu ích khi cần dự đoán tải hệ thống.

## Liên hệ game thực tế

### Game bắn súng

Đạn là ví dụ kinh điển nhất.

Nếu mỗi viên đạn đều `Instantiate` rồi `Destroy`, game có thể vẫn chạy lúc ít đạn.

Nhưng khi:

- súng bắn nhanh
- nhiều địch bắn cùng lúc
- có thêm hiệu ứng trúng đạn

thì số object ngắn hạn sẽ tăng mạnh.

### Game bullet hell

Đây là thể loại mà pooling gần như trở thành kỹ thuật rất đáng cân nhắc.

Vì số lượng đạn trên màn hình có thể cực lớn.

### Game có hiệu ứng thường xuyên

Ví dụ:

- nổ
- khói
- bụi khi chạy
- popup số sát thương

Đây đều là ứng viên rất tốt cho pooling.

### Game sinh quái theo đợt

Nếu cùng một loại quái xuất hiện lặp đi lặp lại, việc tái sử dụng cũng rất hợp lý.

## Khi nào nên nghĩ tới object pooling?

Không phải cứ biết pooling là áp dụng mọi nơi.

Hãy nghĩ tới pooling khi object có các đặc điểm sau:

- xuất hiện thường xuyên
- sống ngắn
- bị tạo hủy lặp lại nhiều lần
- cùng một loại prefab được dùng lặp đi lặp lại

Ví dụ rất phù hợp:

- đạn
- particle prefab ngắn hạn
- hit effect
- shell văng ra
- coin drop số lượng lớn

Ví dụ có thể chưa cần pooling ngay:

- boss chỉ xuất hiện 1 lần
- cửa chính chỉ tạo 1 lần trong scene
- UI màn hình cài đặt mở cực ít

Nói ngắn gọn:

Pooling là công cụ tối ưu có mục tiêu.

Đừng dùng nó chỉ vì “nghe chuyên nghiệp”.

## Quy trình suy nghĩ khi cân nhắc pooling

### Bước 1: Object này có được tạo hủy lặp đi lặp lại không?

Nếu có, đó là tín hiệu đầu tiên.

### Bước 2: Tần suất có đủ cao để đáng quan tâm không?

Một object xuất hiện vài lần mỗi màn có thể chưa đáng.

### Bước 3: Object này có thể tái sử dụng an toàn không?

Ví dụ đạn sau khi hết vai trò có thể tắt đi, reset trạng thái, rồi dùng lại.

### Bước 4: Cần reset những gì khi trả về pool?

Đây là phần rất quan trọng mà người mới hay quên.

Ví dụ cần reset:

- vị trí
- vận tốc
- máu
- timer tự hủy
- particle state
- animation state
- parent tạm thời

### Bước 5: Nếu pool hết object thì làm gì?

Bạn cần quyết định rõ.

Ví dụ:

- tạo thêm
- bỏ qua yêu cầu spawn
- tái sử dụng object cũ nhất

Mỗi lựa chọn phù hợp với bài toán khác nhau.

## Pool hoạt động như thế nào?

Một luồng cơ bản thường là:

1. tạo sẵn N object từ prefab
2. tắt chúng đi
3. cất vào pool
4. khi cần dùng, lấy một object từ pool ra
5. bật object lên, đặt vị trí, reset trạng thái
6. khi dùng xong, không hủy mà trả về pool
7. tắt object lại để chờ lần sau

Ý tưởng này rất dễ hiểu nhưng cực kỳ hiệu quả trong nhiều game.

## Vì sao `Queue<T>` hợp ở đây?

`Queue<T>` là cấu trúc dữ liệu vào trước ra trước.

Nó thường hợp với pool vì tư duy quản lý đơn giản:

- lấy ra một object có sẵn
- dùng xong trả về cuối hàng

Điều này giúp luồng sử dụng khá tự nhiên và dễ cài đặt.

Tất nhiên, không phải pool nào cũng bắt buộc dùng `Queue<T>`.

Nhưng với bài toán nhập môn, `Queue<T>` là lựa chọn dễ hiểu.

## Ví dụ tư duy đơn giản về pool đạn

Giả sử game của bạn có súng bắn liên tục.

Thay vì:

- mỗi lần bắn tạo prefab đạn mới
- đạn bay xong thì hủy

Bạn có thể:

- tạo sẵn 30 viên đạn
- khi bắn lấy 1 viên đang rảnh
- viên đó bay xong tự tắt
- rồi trở lại pool

Khi đó, số lần cấp phát mới giảm đáng kể.

## Ví dụ mã giả đơn giản

```csharp
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int initialSize = 20;

    private Queue<GameObject> pool = new Queue<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < initialSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform);
            bullet.SetActive(false);
            pool.Enqueue(bullet);
        }
    }

    public GameObject Get()
    {
        if (pool.Count == 0)
        {
            return null;
        }

        GameObject bullet = pool.Dequeue();
        bullet.SetActive(true);
        return bullet;
    }

    public void Return(GameObject bullet)
    {
        bullet.SetActive(false);
        pool.Enqueue(bullet);
    }
}
```

Đây chưa phải pool hoàn chỉnh cho mọi trường hợp.

Nhưng nó giúp bạn hiểu cốt lõi:

- tạo sẵn
- lấy ra
- dùng xong trả về

## Điều quan trọng hơn cả code: reset trạng thái

Người mới thường làm được bước lấy object ra.

Nhưng lại quên rằng object tái sử dụng mang theo “ký ức” của lần trước nếu không reset.

Ví dụ viên đạn cũ có thể còn:

- vị trí cũ
- hướng cũ
- vận tốc cũ
- timer cũ
- trail cũ

Nếu không reset đúng, bạn sẽ gặp những bug rất khó chịu.

Ví dụ:

- đạn vừa spawn đã bay lệch
- particle bật ra ở trạng thái dở dang
- enemy tái sinh nhưng còn ít máu từ lần trước

Đây là lý do pooling không chỉ là bài toán “tiết kiệm tạo hủy”, mà còn là bài toán quản lý vòng đời object.

## Pool và trách nhiệm thiết kế

Khi áp dụng pooling, hãy nghĩ rõ trách nhiệm:

- Pool quản lý kho object.
- Object tự biết khi nào nó hết vai trò.
- Có cơ chế trả object về pool an toàn.

Nếu mọi thứ lẫn lộn, code sẽ rối nhanh.

Ví dụ không tốt:

- object tự `Destroy`
- nhưng đôi khi lại `SetActive(false)`
- đôi khi manager khác lại cất vào pool

Thiết kế như vậy thiếu nhất quán.

## Lỗi sai thường gặp của người mới

### 1. Tạo pool nhưng vẫn `Instantiate` lung tung

Đây là lỗi rất thường thấy.

Bạn có pool rồi nhưng code ở nơi khác vẫn tiện tay tạo object mới.

Kết quả là lợi ích pooling bị giảm mạnh.

### 2. Không trả object về pool

Nếu object bị tắt mà không quay lại hệ thống pool, kho object sẽ ngày càng không dùng được đúng mục đích.

### 3. Trả object về pool nhưng không reset trạng thái

Đây là lỗi nguy hiểm nhất về mặt hành vi.

### 4. Không xử lý trường hợp pool cạn

Nếu game cần object mà pool không còn gì sẵn, bạn phải biết hệ thống sẽ phản ứng thế nào.

### 5. Dùng pooling cho mọi thứ một cách mù quáng

Pooling là công cụ mạnh, nhưng không phải thuốc chữa bách bệnh.

Nếu object hiếm khi tạo hủy, việc thêm pooling có thể làm code phức tạp hơn mức cần thiết.

### 6. Không tách pool theo loại object rõ ràng

Đạn, hiệu ứng nổ, popup damage thường nên có pool riêng hoặc cơ chế quản lý rõ ràng.

### 7. Không để ý tới quan hệ với parent, transform, và trạng thái active

Nhiều bug phát sinh chỉ vì object trả về pool nhưng vẫn còn parent cũ hoặc còn trạng thái phụ không mong muốn.

## Mẹo thực hành tốt cho người mới

- Áp dụng pooling trước cho các object ngắn hạn, xuất hiện nhiều.
- Bắt đầu từ ví dụ đơn giản như đạn hoặc hiệu ứng trúng đòn.
- Tạo một hàm reset trạng thái rõ ràng cho object tái sử dụng.
- Thống nhất cách object quay về pool.
- Đo hiệu quả thực tế nếu dự án đủ lớn, đừng tối ưu kiểu cảm tính.

## Một checklist hữu ích khi làm pool

- Object này có thật sự tạo hủy thường xuyên không?
- Có cần pool ngay bây giờ không?
- Khi lấy ra, object cần reset những gì?
- Khi trả về, object có cần dọn dẹp gì không?
- Nếu pool hết, hệ thống sẽ làm gì?
- Có nơi nào vẫn đang `Instantiate` trực tiếp object này không?

## Tóm tắt

- Object pooling là kỹ thuật tạo sẵn object rồi tái sử dụng nhiều lần.
- Nó đặc biệt hữu ích với các object xuất hiện thường xuyên và sống ngắn như đạn, hiệu ứng, popup.
- Pooling giúp giảm chi phí tạo hủy, giảm rác bộ nhớ và hạn chế giật khung hình.
- `Queue<T>` là lựa chọn tốt cho nhiều pool nhập môn vì dễ quản lý.
- Điều quan trọng không chỉ là lấy object ra khỏi pool, mà còn phải reset trạng thái khi tái dùng.
- Không nên dùng pooling mù quáng cho mọi object.
- Hãy áp dụng ở nơi vấn đề thật sự tồn tại hoặc có khả năng xuất hiện rõ rệt.

## Tự kiểm tra

1. Object pooling là gì?
2. Vì sao tạo hủy object liên tục có thể gây vấn đề?
3. Hãy nêu 5 loại object rất phù hợp để dùng pooling.
4. Vì sao `Queue<T>` thường hợp với bài toán pool?
5. Khi object quay về pool, điều gì thường cần được reset?
6. Nếu pool hết object, bạn có thể chọn những hướng xử lý nào?
7. Vì sao nói pooling không nên dùng một cách mù quáng?
8. Nếu bạn tạo pool cho đạn nhưng vẫn `Instantiate` đạn ở chỗ khác, vấn đề là gì?
9. Trong game bullet hell, vì sao pooling đặc biệt quan trọng?
10. Pool chịu trách nhiệm gì, còn object dùng pool nên chịu trách nhiệm gì?

## Bài tập suy nghĩ thêm

- Hãy nghĩ về một game bắn súng đơn giản.
- Liệt kê các object có khả năng xuất hiện rất nhiều lần.
- Chọn 2 loại object đầu tiên mà bạn sẽ áp dụng pooling.
- Giải thích vì sao chúng là ứng viên tốt hơn so với boss hoặc cửa chính của màn.

Khi bạn hiểu object pooling đúng bản chất, bạn không chỉ tối ưu game, mà còn học được cách suy nghĩ có hệ thống về vòng đời của object trong runtime.
