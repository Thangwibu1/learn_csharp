# Bai tap Bai 05 - Interface va Decoupling

## Muc tieu

1. Hieu interface la hop dong hanh vi.
2. Hieu decoupling la giam phu thuoc chat che giua cac class.
3. Luyen class phu thuoc vao interface thay vi class cu the.
4. Luyen thay doi implementation ma khong sua class su dung.
5. Luyen tu duy `can biet lam duoc gi` thay vi `can biet no la ai`.

## Nguyen tac lam bai

1. Tim phan hanh vi chung giua nhieu class.
2. Dua hanh vi do vao interface.
3. Cho cac class cu the trien khai interface.
4. Cho class service phu thuoc vao interface.
5. Thu thay implementation de thay loi ich decoupling.

## Bai co ban

### Bai 1

Tao interface `IInteractable` voi method `Interact()`.
Tao class `Door` trien khai `IInteractable`.
Tao class `Chest` trien khai `IInteractable`.
Moi class in hanh dong rieng khi interact.

### Bai 2

Tao class `PlayerInteractor` co method `Use(IInteractable target)`.
Goi `target.Interact()` trong method.
Truyen vao `Door` va `Chest`.
Quan sat cung mot method xu ly duoc nhieu doi tuong.

### Bai 3

Tao interface `IDamageable` voi method `TakeDamage(int damage)`.
Tao class `Enemy` trien khai interface.
Tao class `TrainingDummy` trien khai interface.
Moi class xu ly sat thuong theo cach rieng.

### Bai 4

Tao class `Sword` co method `Hit(IDamageable target)`.
Dung `target.TakeDamage(...)`.
Tan cong `Enemy` va `TrainingDummy`.
Khong duoc goi truc tiep class cu the trong `Sword`.

### Bai 5

Tao class `Arrow` cung tan cong qua `IDamageable`.
Thu tan cong nhieu muc tieu khac nhau.
Giai thich vi sao `Arrow` khong can biet muc tieu la class nao.

### Bai 6

Tao mang `IInteractable[]` gom `Door`, `Chest`, `NPC`.
Duyet mang va goi `Interact()`.
Muc tieu la thay da hinh thong qua interface.

### Bai 7

Tao interface `INotifier` voi method `Send(string message)`.
Tao `EmailNotifier` va `SmsNotifier` trien khai `INotifier`.
Moi class in thong bao gui theo kieu rieng.

### Bai 8

Tao class `NotificationService` nhan `INotifier` trong constructor.
Co method gui thong diep chao mung.
Thu tao service voi `EmailNotifier`.
Sau do thu voi `SmsNotifier` ma khong sua service.

### Bai 9

Tao them `PushNotifier` trien khai `INotifier`.
Gan vao `NotificationService`.
Chung minh rang service van chay tot.
Day la bai tap quan trong cho decoupling.

### Bai 10

Viet ham `AttackTwice(IDamageable target)`.
Trong do tan cong 2 lan.
Truyen vao nhieu doi tuong khac nhau.
Quan sat loi ich cua viec nhan interface.

## Bai trung cap

### Bai 11

Tao interface `IPaymentMethod` voi method `Pay(decimal amount)`.
Tao `CashPayment`, `CardPayment`, `WalletPayment`.
Tao class `CheckoutService` chi phu thuoc vao `IPaymentMethod`.
Thu doi cach thanh toan.

### Bai 12

Tao interface `ILogger` voi method `Log(string message)`.
Tao `ConsoleLogger` va `MemoryLogger`.
Tao class `OrderProcessor` nhan `ILogger`.
Log qua nhieu implementation khac nhau.

### Bai 13

Tao interface `IFileExporter` voi method `Export(string content)`.
Tao `PdfExporter`, `CsvExporter`, `TxtExporter`.
Tao service xuat bao cao chi phu thuoc vao interface.

### Bai 14

Tao interface `ISaveGame` voi method `Save()`.
Tao `LocalSave` va `CloudSave`.
Tao class `GameSaveService` nhan `ISaveGame`.
Thu thay doi cach luu.

### Bai 15

Tao interface `IDiscountPolicy` voi method `GetDiscount(decimal subtotal)`.
Tao `VipDiscountPolicy`, `HolidayDiscountPolicy`, `NoDiscountPolicy`.
Tao class `PricingService` tinh tong cuoi cung.

### Bai 16

Tao interface `IPlayable` voi method `Play()`.
Tao `AudioFile`, `VideoFile`.
Tao player chung chi can `IPlayable`.
Muc tieu la luyen abstraction theo hanh vi.

### Bai 17

Tao interface `IAuthenticationProvider`.
Tao `PasswordAuthProvider` va `OtpAuthProvider`.
Tao `LoginService` su dung interface nay.
Thu doi cach xac thuc.

### Bai 18

Tao interface `IShippingCalculator`.
Tao `StandardShippingCalculator` va `ExpressShippingCalculator`.
Tao service tinh phi giao hang.
Khong duoc hard-code loai ship trong service.

### Bai 19

Tao interface `IFormatter` voi method `Format(string text)`.
Tao `UpperCaseFormatter`, `LowerCaseFormatter`, `TitleCaseFormatter`.
Tao `TextPresenter` phu thuoc vao `IFormatter`.

### Bai 20

Tao interface `IReportGenerator`.
Tao `DailyReportGenerator`, `WeeklyReportGenerator`, `MonthlyReportGenerator`.
Tao service xuat bao cao phu thuoc vao interface.

## Bai nang cao vua suc

### Bai 21

Tao interface `IEmailSender` va `ISmsSender` rieng, sau do can nhac hop nhat thanh `INotifier` khi nao hop ly.
Muc tieu la suy nghi thiet ke interface.
Ghi lai nhan xet ngan.

### Bai 22

Tao mot class `Robot` trien khai ca `IDamageable` va `IInteractable`.
Thu dung `Sword` tan cong `Robot`.
Thu dung `PlayerInteractor` tuong tac `Robot`.
Thay suc manh cua nhieu interface.

### Bai 23

Tao interface `IReadable` va `IWritable`.
Tao class `DocumentFile` trien khai ca hai.
Tao hai service rieng, mot service chi doc, mot service chi ghi.
Muc tieu la thay su tach trach nhiem.

### Bai 24

Tao interface `ICache` voi `Get` va `Set` don gian.
Tao `MemoryCache` va `FakeCache`.
Tao service doc du lieu phu thuoc vao `ICache`.
Giai thich loi ich khi test.

### Bai 25

Tao interface `IRandomProvider`.
Tao `RealRandomProvider` va `FixedRandomProvider`.
Tao game mini phu thuoc vao interface nay.
Muc tieu la thay testability tang len.

### Bai 26

Tao interface `ITaxCalculator`.
Tao `NormalTaxCalculator`, `ZeroTaxCalculator`.
Tao service tinh hoa don.
Thu doi implementation theo tinh huong.

### Bai 27

Tao interface `IMessageQueue`.
Tao `ImmediateQueue` va `BufferedQueue`.
Tao `NotificationDispatcher` phu thuoc vao interface.
Khong duoc gan chat vao mot queue cu the.

### Bai 28

Tao interface `IClock` tra ve thoi gian hien tai.
Tao `SystemClock` va `FixedClock`.
Tao class xu ly han ma giam gia dua tren gio.
Muc tieu la thay loi ich trong test theo thoi gian.

### Bai 29

Tao interface `IHealthChecker`.
Tao `DatabaseHealthChecker`, `ApiHealthChecker`, `DiskHealthChecker`.
Tao service duyet danh sach checker va in ket qua.

### Bai 30

Tao interface `IMenuAction` voi method `Execute()`.
Tao `OpenAction`, `SaveAction`, `ExitAction`.
Tao menu xu ly mot mang `IMenuAction`.
Khong phu thuoc vao class cu the.

## Goi y

1. Interface hop khi nhieu class cung co mot kha nang chung.
2. Class su dung nen phu thuoc vao interface, khong phu thuoc vao implementation cu the.
3. Thu thay implementation ma class su dung khong doi la dau hieu tot.
4. Interface rat huu ich cho test va mo rong.
5. Khong can interface cho moi class neu chua co nhu cau.

## Xu ly loi thuong gap

1. Loi: service phu thuoc truc tiep vao class cu the.
Nguyen nhan: khoi tao implementation ngay trong service.
Huong sua: nhan interface qua constructor hoac method.

2. Loi: tao interface qua nhieu, qua som.
Nguyen nhan: ap dung may moc.
Huong sua: chi tao khi co nhu cau thay the, mo rong, hoac test.

3. Loi: interface qua to, class nao cung phai implement thua.
Nguyen nhan: gom qua nhieu trach nhiem vao mot interface.
Huong sua: tach interface nho hon.

## Tu kiem tra

1. Ban co giai thich duoc interface la gi khong?
2. Ban co giai thich duoc decoupling la gi khong?
3. Ban co biet vi sao service nen phu thuoc vao interface khong?
4. Ban co the them implementation moi ma khong sua service cu khong?
5. Ban co the tu viet them 5 interface thuc te khac khong?

## Mini project 1

Viet he thong thong bao mini.
Service gui thong bao chi biet `INotifier`.
Co email, sms, push.
Thu doi implementation nhiu lan.

## Mini project 2

Viet he thong thanh toan mini.
CheckoutService chi nhan `IPaymentMethod`.
Co cash, card, wallet.
Muc tieu la cam nhan decoupling trong nghiep vu thanh toan.

## Mini project 3

Viet he thong luu game mini.
GameSaveService chi nhan `ISaveGame`.
Co local save va cloud save.
Thu doi qua lai ma service khong can sua.

## Tong ket

1. Interface va decoupling la buoc tien rat quan trong tu OOP co ban sang thiet ke he thong tot.
2. Hieu bai nay se giup ban de tiep can SOLID, Dependency Injection, va testing hon.
3. Day la mot trong nhung bai co gia tri dai han nhat trong lap trinh huong doi tuong.

## Bo sung bai tu luyen nhanh

### Bai 31

Tao interface `IExporter`.
Tao `PdfExporter`, `ExcelExporter`, `JsonExporter`.
Tao service xuat du lieu nhan `IExporter`.
Thu doi implementation lien tuc.

### Bai 32

Tao interface `IUploader`.
Tao `LocalUploader`, `CloudUploader`.
Tao `ImageService` phu thuoc vao `IUploader`.
Khong hard-code uploader trong service.

### Bai 33

Tao interface `IWeatherProvider`.
Tao `OnlineWeatherProvider`, `CachedWeatherProvider`.
Tao `WeatherScreen` chi biet interface.
Muc tieu la thay doi nguon du lieu de dang.

### Bai 34

Tao interface `ITheme`.
Tao `LightTheme`, `DarkTheme`.
Tao `UiRenderer` nhan `ITheme`.
Thay giao dien ma khong doi renderer.

### Bai 35

Tao interface `IPriceFormatter`.
Tao `VnPriceFormatter`, `UsPriceFormatter`.
Tao service hien thi gia chi nhan interface.
Thu doi dinh dang gia.

### Bai 36

Tao interface `IBackupStrategy`.
Tao `FullBackupStrategy`, `IncrementalBackupStrategy`.
Tao `BackupService` su dung interface nay.
Thu mo rong them mot strategy moi.

### Bai 37

Tao interface `ISearchEngine`.
Tao `SimpleSearchEngine`, `AdvancedSearchEngine`.
Tao `SearchPage` khong biet engine cu the.
Muc tieu la luyen decoupling trong UI.

### Bai 38

Tao interface `IImageResizer`.
Tao `FastResizer`, `QualityResizer`.
Tao service xu ly anh dung interface.
So sanh loi ich khi thay implementation.

### Bai 39

Tao interface `IReportSaver`.
Tao `FileReportSaver`, `CloudReportSaver`, `MemoryReportSaver`.
Tao `ReportService` chi biet interface.
Thu nhieu cach luu bao cao.

### Bai 40

Tao interface `IStatusPublisher`.
Tao `ConsoleStatusPublisher`, `EmailStatusPublisher`.
Tao `JobRunner` dung interface de xuat thong bao trang thai.
Khong duoc phu thuoc truc tiep vao Console hay Email class cu the.

## Goi y mo rong

1. Mot interface tot mo ta mot kha nang ro rang.
2. Khong nen nhoi qua nhieu trach nhiem vao mot interface.
3. Doi tuong su dung nen nhan interface tu ben ngoai.
4. Neu them implementation moi ma service khong doi, ban dang di dung huong.
5. Hay thu viet mot fake implementation de test bang tay.
6. Hay can nhac interface nho gon va de dat ten.
7. Hay uu tien constructor injection trong cac bai mo rong.

## Cau hoi tu duy

1. Vi sao `NotificationService` nen nhan `INotifier` thay vi `EmailNotifier`?
2. Vi sao `Sword` nen nhan `IDamageable` thay vi `Enemy`?
3. Interface khac class cha o diem nao?
4. Khi nao interface phu hop hon ke thua?
5. Vi sao interface giup test de hon?
6. Vi sao decoupling giup he thong de mo rong hon?
7. Ban co the ke 5 service nen phu thuoc vao interface khong?

## Checklist tu danh gia

1. Ban co de service phu thuoc vao abstraction khong?
2. Ban co tranh khoi tao concrete class ben trong service khong?
3. Ban co thu doi implementation ma service van chay khong?
4. Ban co dat ten interface ro kha nang khong?
5. Ban co tach interface khi no qua to khong?
6. Ban co nhin thay loi ich testing tu bai tap khong?
7. Ban co the tao fake implementation de thu nghiem khong?
