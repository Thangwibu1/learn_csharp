# Bai tap Bai 04 - Ke thua va Da hinh

## Muc tieu

1. Hieu quan he cha con trong OOP.
2. Biet khi nao ke thua hop ly.
3. Luyen `virtual` va `override`.
4. Luyen da hinh thong qua bien kieu cha.
5. Luyen tai su dung code chung va tach phan rieng.

## Nguyen tac lam bai

1. Chi dung ke thua khi co quan he `la mot`.
2. Dat nhung thu chung vao class cha.
3. Dat nhung thu dac thu vao class con.
4. Dung `virtual` cho nhung hanh vi co the thay doi.
5. Dung `override` de class con bieu dien cach xu ly rieng.

## Bai co ban

### Bai 1

Tao class cha `Animal`.
Co property `Name`.
Co method `MakeSound()` la `virtual`.
In mot am thanh chung.

### Bai 2

Tao class `Dog` ke thua `Animal`.
Override `MakeSound()` de in tieng sua.
Tao class `Cat` ke thua `Animal`.
Override `MakeSound()` de in tieng meo.

### Bai 3

Tao doi tuong `Dog` va `Cat`.
Goi `MakeSound()` tren tung doi tuong.
Quan sat su khac nhau.
Giai thich vi sao day la da hinh co ban.

### Bai 4

Tao class cha `Character`.
Co property `Name`, `Health`.
Co method `Attack()` la virtual.
Co method `ShowInfo()`.

### Bai 5

Tao class `Warrior` ke thua `Character`.
Override `Attack()`.
Tao class `Mage` ke thua `Character`.
Override `Attack()`.
In cach tan cong rieng cua tung class.

### Bai 6

Tao bien `Character c1 = new Warrior(...)`.
Tao bien `Character c2 = new Mage(...)`.
Goi `Attack()` tren `c1` va `c2`.
Muc tieu la thay da hinh qua bien cha.

### Bai 7

Bo sung method `TakeDamage(int damage)` o class cha `Character`.
Tat ca class con dung lai method nay.
Thu tan cong va giam mau.
Quan sat loi ich tai su dung code.

### Bai 8

Tao class `Archer` ke thua `Character`.
Override `Attack()` de ban ten.
Them vao nhom nhan vat da co.
Goi chung qua bien `Character`.

### Bai 9

Tao mang `Character[]` gom nhieu doi tuong con khac nhau.
Duyet mang va goi `ShowInfo()` va `Attack()`.
Quan sat moi doi tuong phan ung khac nhau.
Day la bai tap quan trong.

### Bai 10

Tao ham `ProcessCharacter(Character character)`.
Trong ham, goi `ShowInfo()` va `Attack()`.
Truyen vao nhieu doi tuong con khac nhau.
Quan sat loi ich cua da hinh.

## Bai trung cap

### Bai 11

Tao class cha `Vehicle`.
Co `Brand`, `Speed`.
Co method `Move()` la virtual.
Tao `Car`, `Bike`, `Boat` override `Move()`.

### Bai 12

Tao class cha `Employee`.
Co `Name` va method `Work()`.
Tao `Developer`, `Designer`, `Tester` override `Work()`.
Goi qua mang `Employee[]`.

### Bai 13

Tao class cha `Notification`.
Co method `Send()` la virtual.
Tao `EmailNotification`, `SmsNotification`, `PushNotification` override `Send()`.
Xu ly chung trong mot ham.

### Bai 14

Tao class cha `Shape`.
Co method `Draw()` va `GetArea()` la virtual.
Tao `Circle` va `Rectangle` override.
In ket qua bang bien `Shape`.

### Bai 15

Tao class cha `PaymentMethod`.
Co method `Pay(decimal amount)`.
Tao `CashPayment`, `CardPayment`, `WalletPayment`.
Override cach thanh toan.

### Bai 16

Tao class cha `Document`.
Co method `PrintInfo()`.
Tao `Invoice`, `Contract`, `Report`.
Moi class in thong tin theo cach rieng.
Goi chung qua danh sach `Document`.

### Bai 17

Tao class cha `Appliance`.
Co method `TurnOn()`.
Tao `Fan`, `AirConditioner`, `Heater` override.
Muc tieu la luyen phan tach hanh vi chung va rieng.

### Bai 18

Tao class cha `Lesson`.
Co `Title` va method `Study()`.
Tao `VideoLesson`, `QuizLesson`, `ArticleLesson`.
Override `Study()`.

### Bai 19

Tao class cha `Account`.
Co method `Login()`.
Tao `AdminAccount`, `TeacherAccount`, `StudentAccount`.
Override thong bao sau dang nhap.

### Bai 20

Tao class cha `MenuItem`.
Co method `Select()`.
Tao `StartButton`, `SettingButton`, `ExitButton`.
Override `Select()` theo tung chuc nang.

## Bai nang cao vua suc

### Bai 21

Tao class cha `CourseMember`.
Co `Name` va method `GetDashboard()`.
Tao `StudentMember`, `MentorMember`, `AdminMember`.
Goi qua mang `CourseMember[]`.

### Bai 22

Tao class cha `Delivery`.
Co method `CalculateFee()` la virtual.
Tao `StandardDelivery`, `ExpressDelivery`, `SameDayDelivery`.
Moi loai tinh phi khac nhau.

### Bai 23

Tao class cha `MediaFile`.
Co method `Play()`.
Tao `Mp3File`, `Mp4File`, `ImageFile`.
Xu ly chung qua mot ham `OpenMedia(MediaFile file)`.

### Bai 24

Tao class cha `ReportBase`.
Co method `Generate()`.
Tao `DailyReport`, `WeeklyReport`, `MonthlyReport`.
Override cach tao bao cao.

### Bai 25

Tao class cha `GameItem`.
Co property `Name` va method `Use()`.
Tao `Potion`, `Bomb`, `Scroll` override `Use()`.
Cho tat ca vao mang va goi `Use()`.

### Bai 26

Tao class cha `SmartDevice`.
Co method `Connect()`.
Tao `SmartLight`, `SmartLock`, `SmartCamera`.
Override cach ket noi va thong bao.

### Bai 27

Tao class cha `Customer`.
Co method `GetDiscountRate()`.
Tao `RegularCustomer`, `VipCustomer`, `NewCustomer`.
Moi loai tra ve muc giam khac nhau.

### Bai 28

Tao class cha `ExamQuestion`.
Co method `Display()`.
Tao `MultipleChoiceQuestion`, `TrueFalseQuestion`, `EssayQuestion`.
Override cach hien thi.

### Bai 29

Tao class cha `TransportTicket`.
Co method `PrintTicket()`.
Tao `BusTicket`, `TrainTicket`, `FlightTicket`.
Moi loai in thong tin khac nhau.

### Bai 30

Tao class cha `ErrorHandler`.
Co method `Handle()`.
Tao `NetworkErrorHandler`, `ValidationErrorHandler`, `FileErrorHandler`.
Goi chung qua mot danh sach.

## Goi y

1. Dat nhung thu chung vao class cha.
2. Chi override khi class con that su co hanh vi khac.
3. Hay tao bien cha tro den doi tuong con de cam nhan da hinh.
4. Neu thay quan he khong phai `la mot`, hay can nhac composition.
5. Luon nghiem tuc dat ten class cha va class con ro nghia.

## Xu ly loi thuong gap

1. Loi: dua qua nhieu thu rieng vao class cha.
Nguyen nhan: thiet ke cha qua rong.
Huong sua: giu class cha chi chua phan chung.

2. Loi: khong danh dau `virtual` nen khong override duoc.
Nguyen nhan: quen tu khoa.
Huong sua: them `virtual` o class cha va `override` o class con.

3. Loi: dung ke thua cho quan he khong hop ly.
Nguyen nhan: nham `la mot` voi `co mot`.
Huong sua: xem lai mo hinh doi tuong.

## Tu kiem tra

1. Ban co giai thich duoc ke thua la gi khong?
2. Ban co giai thich duoc da hinh la gi khong?
3. Ban co biet khi nao dung `virtual` va `override` khong?
4. Ban co phan biet duoc ke thua va composition khong?
5. Ban co the tu viet them 5 cap class cha con khong?

## Mini project 1

Viet he thong nhan vat game mini.
Co class cha `Character`.
Co nhieu class con nhu warrior, mage, archer, monster.
Dung da hinh de xu ly tan cong chung.

## Mini project 2

Viet he thong thong bao mini.
Co class cha `Notification`.
Co nhieu class con gui email, sms, push.
Mot ham chung gui duoc moi loai thong bao.

## Mini project 3

Viet he thong thanh toan mini.
Co class cha `PaymentMethod`.
Co card, cash, wallet.
Mot ham xu ly don hang chi nhan `PaymentMethod`.

## Tong ket

1. Ke thua va da hinh la hai tru cot rat lon cua OOP.
2. Hieu dung hai bai nay se giup ban thiet ke he thong linh hoat hon.
3. Day cung la cau noi tu OOP co ban sang interface va decoupling.

## Bo sung bai tu luyen nhanh

### Bai 31

Tao class cha `User`.
Co method `ShowDashboard()`.
Tao `StudentUser`, `TeacherUser`, `AdminUser` override method nay.
Goi qua mang `User[]`.

### Bai 32

Tao class cha `Ticket`.
Co method `Print()`.
Tao `MovieTicket`, `BusTicket`, `FlightTicket`.
Moi loai in noi dung khac nhau.

### Bai 33

Tao class cha `MessageSender`.
Co method `SendMessage()`.
Tao `EmailSender`, `SmsSender`, `PushSender`.
Override cach gui.

### Bai 34

Tao class cha `Food`.
Co method `DescribeTaste()`.
Tao `SweetFood`, `SaltyFood`, `SpicyFood`.
Muc tieu la luyen bai vui nhung ro da hinh.

### Bai 35

Tao class cha `CourseContent`.
Co method `Open()`.
Tao `VideoContent`, `PdfContent`, `QuizContent`.
Goi chung qua danh sach `CourseContent`.

### Bai 36

Tao class cha `Sensor`.
Co method `ReadValue()`.
Tao `TemperatureSensor`, `HumiditySensor`, `LightSensor`.
Override cach doc du lieu.

### Bai 37

Tao class cha `PrinterBase`.
Co method `PrintLine()`.
Tao `InvoicePrinter`, `LabelPrinter`, `SummaryPrinter`.
In theo nhieu cach khac nhau.

### Bai 38

Tao class cha `Workout`.
Co method `Start()`.
Tao `CardioWorkout`, `StrengthWorkout`, `StretchWorkout`.
Xu ly chung qua mot ham.

### Bai 39

Tao class cha `Campaign`.
Co method `Launch()`.
Tao `EmailCampaign`, `SocialCampaign`, `AdsCampaign`.
Override mo ta cach chay chien dich.

### Bai 40

Tao class cha `CustomerSupportAction`.
Co method `Execute()`.
Tao `RefundAction`, `ReplaceAction`, `EscalateAction`.
Goi chung trong danh sach.

## Goi y mo rong

1. Moi class cha nen co vai tro ro rang.
2. Moi class con nen thuc su la mot bien the cua class cha.
3. Neu class con khong dung duoc mot method cua class cha, co the thiet ke dang co van de.
4. Hay test da hinh bang cach tao bien cha tro den doi tuong con.
5. Hay them mot ham nhan class cha va truyen nhieu class con vao.
6. Hay ghi ra nhung thu chung va thu rieng truoc khi viet code.
7. Hay can nhac composition neu quan he khong phai `la mot`.

## Cau hoi tu duy

1. Vi sao Warrior la Character nhung Sword khong phai Character?
2. Vi sao Car la Vehicle nhung Engine khong phai Vehicle?
3. Khi nao khong nen dung ke thua?
4. Vi sao da hinh giup code mo rong de hon?
5. Vi sao virtual va override quan trong?
6. Vi sao class cha khong nen qua lon?
7. Ban co the chi ra 3 vi du `la mot` va 3 vi du `co mot` khong?

## Checklist tu danh gia

1. Ban co dat dung nhung phan chung vao class cha khong?
2. Ban co dat phan dac thu vao class con khong?
3. Ban co dung `virtual` cho method can mo rong khong?
4. Ban co goi method qua bien class cha khong?
5. Ban co nhin thay da hinh trong ket qua chay khong?
6. Ban co test voi nhieu class con khac nhau khong?
7. Ban co tranh quan he ke thua sai ban chat khong?
