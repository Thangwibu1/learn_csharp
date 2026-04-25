# Bài 2: Tham Trị và Tham Chiếu

## Mục tiêu

- Hiểu value type và reference type khác nhau thế nào
- Hiểu sao chép dữ liệu khác với sao chép đường dẫn tới dữ liệu ra sao

## Tham trị là gì?

Tham trị nghĩa là biến giữ chính giá trị của nó.

Ví dụ:

```csharp
int a = 10;
int b = a;
```

Lúc này `b` lấy một bản sao của `a`.

Nếu đổi `b`, `a` không đổi.

## Tham chiếu là gì?

Tham chiếu nghĩa là biến giữ đường dẫn tới object.

Ví dụ:

```csharp
Player p1 = new Player();
Player p2 = p1;
```

Lúc này `p1` và `p2` thường cùng trỏ tới một object.

Đổi dữ liệu qua `p2` thì `p1` cũng thấy thay đổi.

## Tại sao phải dùng cái này?

Vì nếu không hiểu điểm này, bạn sẽ rất dễ bị lỗi kiểu:

- tưởng là tạo bản sao nhưng thực ra đang dùng chung object
- sửa inventory của NPC A mà NPC B cũng đổi theo
- thay đổi config ở một nơi làm chỗ khác bị ảnh hưởng

## Ví dụ đời thường

### Tham trị

Giống như bạn chép số điện thoại từ giấy A sang giấy B.

- Hai tờ giấy tách biệt
- Sửa B không làm A đổi

### Tham chiếu

Giống như hai người cùng giữ địa chỉ tới cùng một căn nhà.

- Một người sơn lại nhà
- Người kia nhìn vào cũng thấy nhà đã đổi màu

## Lỗi sai thường gặp của người mới

### 1. Nghĩ `class` khi gán sẽ tạo object mới

Không phải. Thường nó chỉ sao chép tham chiếu.

### 2. Không tạo object trước khi dùng

```csharp
Player player;
```

Khai báo như vậy chưa tạo object thật.

### 3. Không hiểu vì sao nhiều biến lại dính nhau

Lý do thường là chúng cùng trỏ về một object.

## Ghi nhớ nhanh

- Value type: sao chép giá trị
- Reference type: sao chép tham chiếu
- Hiểu bài này là nền tảng cực quan trọng trước khi học OOP

## Hiểu sâu hơn: đây là bài cực dễ gây nhầm

Người mới thường thấy hai dòng code nhìn rất giống nhau:

```csharp
int b = a;
Player p2 = p1;
```

Nhưng hành vi của chúng có thể khác nhau rất nhiều.

Đó là lý do bài này rất quan trọng.

Nếu không hiểu rõ, bạn sẽ gặp các lỗi kiểu:

- sửa ở một biến mà biến kia cũng đổi theo
- tưởng đã sao chép object nhưng thực ra chỉ sao chép đường dẫn
- truyền dữ liệu vào hàm và không hiểu vì sao kết quả khác mong đợi

## Tham trị: sao chép giá trị thật

Ví dụ:

```csharp
int a = 10;
int b = a;
b = 20;
```

Kết quả:

- `a` vẫn là `10`
- `b` là `20`

Vì sao?

Vì `b` nhận bản sao của giá trị từ `a`.

Hai biến này độc lập với nhau.

Đây là cách rất dễ hiểu với các kiểu đơn giản như:

- `int`
- `float`
- `bool`

## Tham chiếu: sao chép đường dẫn tới object

Ví dụ:

```csharp
Player p1 = new Player();
Player p2 = p1;
```

Ý nghĩa cơ bản:

- `p1` đang tham chiếu tới một object `Player`
- `p2 = p1` không tạo object `Player` mới
- `p2` chỉ cùng tham chiếu tới object đó

Nếu sau đó:

```csharp
p2.Health = 50;
```

thì khi nhìn qua `p1`, bạn cũng thấy máu đã đổi thành `50`.

Lý do:

- cả `p1` và `p2` đang trỏ tới cùng một object

## Ví dụ đời thực dễ nhớ

### Tham trị giống chép số ra giấy khác

Bạn viết số `10` lên tờ A.

Sau đó chép số `10` sang tờ B.

Nếu sửa tờ B thành `20`, tờ A vẫn là `10`.

### Tham chiếu giống hai người giữ cùng địa chỉ ngôi nhà

Hai người đều cầm cùng một địa chỉ.

Nếu một người đến sơn lại căn nhà, người còn lại nhìn vào cũng thấy ngôi nhà đã đổi màu.

## Vì sao điều này quan trọng trong game?

Game có rất nhiều object dùng chung qua nhiều hệ thống:

- inventory
- player data
- enemy data
- quest data
- settings

Nếu bạn truyền tham chiếu của cùng một object đi nhiều nơi, thì:

- sửa ở menu có thể ảnh hưởng gameplay
- sửa ở NPC A có thể vô tình làm NPC B đổi theo
- sửa dữ liệu tạm có thể làm hỏng dữ liệu gốc

Hiểu bài này giúp bạn biết khi nào đang "sờ" vào dữ liệu thật, khi nào chỉ đang làm việc với bản sao.

## Ví dụ game: điểm số là tham trị

```csharp
int originalScore = 100;
int copiedScore = originalScore;

copiedScore += 50;
```

Kết quả:

- `originalScore` vẫn là `100`
- `copiedScore` là `150`

Đây là bản chất của sao chép giá trị.

## Ví dụ game: object người chơi là tham chiếu

```csharp
Player mainPlayer = new Player();
Player currentTarget = mainPlayer;
```

Nếu sau đó:

```csharp
currentTarget.Health = 10;
```

thì `mainPlayer` cũng đang có `Health = 10`.

Nguyên nhân không phải vì hai object giống nhau.

Nguyên nhân là vì đây vẫn chỉ là một object.

## Khai báo biến reference không đồng nghĩa với tạo object

Đây là bẫy rất hay gặp:

```csharp
Player player;
```

Dòng này chỉ khai báo biến.

Nó chưa tạo ra object `Player` thật.

Muốn có object, bạn thường cần tạo nó:

```csharp
Player player = new Player();
```

Điểm này cực kỳ quan trọng.

Người mới rất hay nhầm rằng cứ có tên biến là object đã tồn tại.

## Khi nào người mới dễ bị "dính dữ liệu"?

### Tình huống 1: gán object cho biến khác

```csharp
Inventory bag1 = new Inventory();
Inventory bag2 = bag1;
```

Nhiều người tưởng `bag2` là bản sao.

Thực ra thường chỉ là thêm một tham chiếu tới cùng object.

### Tình huống 2: truyền object qua hàm

Nếu hàm nhận tham số là object kiểu class, bạn thường đang truyền tham chiếu.

Hàm đó có thể sửa trực tiếp object gốc.

### Tình huống 3: lưu chung config hoặc data dùng lại

Nếu nhiều nơi cùng dùng một object cấu hình rồi một nơi sửa nó, nơi khác cũng bị ảnh hưởng.

## Làm sao để đọc code và đoán đúng hành vi?

Khi gặp một dòng gán, hãy tự hỏi 2 câu:

1. Đây là kiểu giá trị hay kiểu tham chiếu?
2. Dòng này đang tạo object mới hay chỉ đang trỏ tới object cũ?

Ví dụ:

```csharp
Player p2 = p1;
```

Hãy nghi ngờ ngay rằng:

- có thể chỉ đang dùng chung object

Ví dụ:

```csharp
int b = a;
```

Bạn có thể khá yên tâm rằng:

- đây là sao chép giá trị

## Sai lầm phổ biến

### 1. Nghĩ rằng "gán" luôn có nghĩa là "copy hoàn toàn"

Không đúng.

Với value type và reference type, ý nghĩa của phép gán khác nhau.

### 2. Không phân biệt biến và object

Biến tham chiếu không phải chính object.

Nó là cách để truy cập object.

### 3. Sửa object tạm mà không biết đang sửa object gốc

Đây là lỗi logic rất phổ biến trong code game và UI.

## Tư duy rất quan trọng cho OOP sau này

Sau này khi học `class`, bạn sẽ làm việc với object nhiều hơn.

Lúc đó, bài này trở thành nền móng vì bạn sẽ phải trả lời các câu hỏi như:

- đây là object mới hay object cũ?
- đang truyền bản sao hay đang truyền tham chiếu?
- sửa ở đây có ảnh hưởng chỗ khác không?

## Tóm tắt bài học

- Tham trị sao chép giá trị thật
- Tham chiếu sao chép đường dẫn tới object
- `int`, `float`, `bool` thường dễ hình dung là tham trị
- `class` thường dễ hình dung là tham chiếu
- Gán một biến object cho biến khác thường không tạo object mới
- Hiểu đúng điểm này giúp tránh nhiều lỗi logic khó chịu

## Tự kiểm tra

1. Vì sao `int b = a;` và `Player p2 = p1;` có thể cho hành vi khác nhau?
2. Khi sửa `b`, vì sao `a` không đổi?
3. Khi sửa dữ liệu qua `p2`, vì sao `p1` có thể đổi theo?
4. `Player player;` đã tạo object thật chưa?
5. Trong game, việc nhiều biến cùng tham chiếu một object có thể gây ra lỗi gì?
6. Làm sao để tự đọc một dòng gán và đoán xem nó tạo object mới hay không?
7. Bài này liên hệ thế nào với OOP?

## Gợi ý luyện tập

1. Tự viết ví dụ với `int` để chứng minh sao chép giá trị là độc lập.
2. Tự viết ví dụ với một class `Player` để quan sát hai biến cùng trỏ tới một object.
3. Nghĩ ra 3 tình huống game mà việc dùng chung tham chiếu có thể gây lỗi logic.
4. Viết lại bằng lời sự khác nhau giữa "sao chép giá trị" và "sao chép tham chiếu".
5. Tự đặt câu hỏi: nếu muốn sửa dữ liệu tạm mà không ảnh hưởng dữ liệu gốc, mình cần cẩn thận điều gì?
