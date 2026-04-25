# Bai tap Bai 03 - Properties

## Muc tieu

1. Hieu property khac field public nhu the nao.
2. Luyen `get`, `set`, `private set`.
3. Luyen auto property va full property.
4. Luyen computed property.
5. Luyen bao ve du lieu khong hop le ngay trong class.

## Nguyen tac lam bai

1. Truoc khi tao property, hay hoi du lieu nay co can bao ve khong.
2. Neu co, khong nen dung field public.
3. Neu chi can luu va lay don gian, dung auto property.
4. Neu can validate, dung full property.
5. Neu gia tri duoc tinh tu cai khac, dung computed property.

## Bai co ban

### Bai 1

Tao class `Weapon`.
Co property `Name` va `Damage`.
Su dung auto property cho `Name`.
Su dung property day du cho `Damage` neu muon validate >= 0.

### Bai 2

Tao class `Book`.
Co `Title`, `Author`, `Price`.
Khong cho `Price` am.
Neu gia tri am thi dat ve 0.

### Bai 3

Tao class `Player`.
Co `Name` va `Health`.
Ben ngoai doc duoc `Health` nhung khong set truc tiep.
Dung `private set` cho `Health`.

### Bai 4

Trong class `Player`, viet method `TakeDamage(int damage)`.
Giam `Health` nhung khong cho xuong duoi 0.
In ket qua sau khi tru mau.
Muc tieu la thay vai tro cua `private set`.

### Bai 5

Tao class `Student`.
Co property `Average` trong khoang 0 den 10.
Neu nhap sai thi tu dua ve bien an toan.
Co property chi doc `Rank` tinh tu `Average`.

### Bai 6

Tao class `Lamp`.
Co property `IsOn`.
Co method `TurnOn` va `TurnOff`.
In trang thai sau moi thao tac.
Tu quyet dinh co cho set tu ngoai hay khong.

### Bai 7

Tao class `Phone`.
Co property `BatteryLevel`.
Gia tri phai nam trong 0 den 100.
Neu qua nguong, tu chinh lai.
In thu nghiem voi gia tri am va > 100.

### Bai 8

Tao class `Course`.
Co property `Title`, `MaxStudents`, `CurrentStudents`.
`CurrentStudents` chi set ben trong class.
Them method `Enroll()` de tang so hoc vien.

### Bai 9

Tao class `Product`.
Co property chi doc `IsAvailable` tinh tu `Stock > 0`.
Thu thay doi ton kho bang method.
Quan sat `IsAvailable` thay doi theo.

### Bai 10

Tao class `Rectangle`.
Co `Width`, `Height`.
Co property chi doc `Area`.
Khong cho `Width` va `Height` am.

## Bai trung cap

### Bai 11

Tao class `BankAccount`.
Co `OwnerName`, `Balance`, `IsActive`.
`Balance` va `IsActive` chi duoc set ben trong class.
Co method `Deposit`, `Withdraw`, `Close`.

### Bai 12

Tao class `Employee`.
Co property `BaseSalary`, `Bonus`.
Khong cho am.
Co property chi doc `TotalIncome = BaseSalary + Bonus`.
In thong tin nhan vien.

### Bai 13

Tao class `Order`.
Co `Subtotal`, `ShippingFee`, `Discount`.
Co property `FinalTotal` tinh toan tu ba gia tri tren.
Khong cho `Discount` lon hon `Subtotal`.

### Bai 14

Tao class `Room`.
Co `Name`, `Capacity`, `OccupiedSeats`.
`OccupiedSeats` chi tang giam qua method.
Co property `RemainingSeats` chi doc.

### Bai 15

Tao class `Video`.
Co `Title`, `DurationInSeconds`, `CurrentPosition`.
Khong cho `CurrentPosition` vuot qua thoi luong.
Co property `IsFinished` tinh toan.

### Bai 16

Tao class `SavingGoal`.
Co `TargetAmount`, `CurrentAmount`.
Co property `ProgressPercent` tinh toan.
Khong cho `CurrentAmount` am.
In tien do sau moi lan nap tien.

### Bai 17

Tao class `Classroom`.
Co `RoomName`, `StudentCount`, `MaxStudentCount`.
Co property `IsFull` tinh tu so luong.
Tao method them hoc vien.

### Bai 18

Tao class `GameCharacter`.
Co `Name`, `Level`, `Exp`.
Khong cho `Level` < 1.
Co property `Title` tinh theo level.
Vi du level cao thi title cao hon.

### Bai 19

Tao class `LibraryCard`.
Co `Owner`, `BorrowedCount`, `MaxBorrowLimit`.
Khong cho `BorrowedCount` set tu ngoai.
Them method `BorrowBook` va `ReturnBook`.

### Bai 20

Tao class `Thermometer`.
Co property `TemperatureCelsius`.
Co property chi doc `Status`.
Status la `Lanh`, `On`, `Nong` tuy theo nhiet do.

## Bai nang cao vua suc

### Bai 21

Tao class `CartItem`.
Co `ProductName`, `UnitPrice`, `Quantity`.
Khong cho gia am va so luong < 0.
Co property `LineTotal` = `UnitPrice * Quantity`.

### Bai 22

Tao class `ExamResult`.
Co `TheoryScore`, `PracticeScore`.
Khong cho vuot 10.
Co property `AverageScore`.
Co property `Passed` neu trung binh >= 5.

### Bai 23

Tao class `DiscountCampaign`.
Co `Code`, `Percent`, `IsActive`.
Percent trong khoang 0 den 100.
Them method `Deactivate()`.
Khong cho ben ngoai set `IsActive` false true tuy y neu ban muon han che.

### Bai 24

Tao class `Membership`.
Co `Level`, `MonthlyFee`, `Points`.
Co property `CanUpgrade` dua tren muc diem.
Van dung property va method de mo ta nghiep vu.

### Bai 25

Tao class `Shipment`.
Co `Weight`, `BaseFee`, `ExtraFee`.
Co property `TotalFee`.
Khong cho can nang am.
Khong cho phi am.

### Bai 26

Tao class `MovieTicket`.
Co `CustomerName`, `Price`, `SeatNumber`, `IsUsed`.
`IsUsed` chi duoc doi thong qua method `UseTicket()`.
Muc tieu la luyen `private set`.

### Bai 27

Tao class `InventoryItem`.
Co `Code`, `Name`, `Quantity`, `MinimumStock`.
Co property `NeedRestock` tinh toan.
Them method nhap va xuat kho.

### Bai 28

Tao class `TaskProgress`.
Co `Title`, `CompletedSteps`, `TotalSteps`.
Khong cho `CompletedSteps` > `TotalSteps`.
Co property `Percent`.

### Bai 29

Tao class `Subscription`.
Co `PlanName`, `PricePerMonth`, `Months`.
Co property `TotalPrice`.
Khong cho so thang <= 0.

### Bai 30

Tao class `HotelRoom`.
Co `RoomNumber`, `PricePerNight`, `IsBooked`.
Chi cho doi `IsBooked` thong qua `Book()` va `Checkout()`.
Co property `StatusText` chi doc.

## Goi y

1. Property khong chi de doc ghi, ma de bao ve du lieu.
2. Neu field la private, property la cua kiem soat.
3. Neu gia tri duoc tinh tu field khac, dung computed property.
4. Neu ben ngoai khong nen sua, dung `private set` hoac bo setter.
5. Ten property nen la danh tu ro nghia.

## Xu ly loi thuong gap

1. Loi: cho phep set moi thu tu ngoai.
Nguyen nhan: dung `public set` qua rong.
Huong sua: doi sang `private set` neu can.

2. Loi: du lieu khong hop le lot vao class.
Nguyen nhan: khong validate trong setter.
Huong sua: them dieu kien kiem tra.

3. Loi: luu trung lap du lieu dan den sai lech.
Nguyen nhan: luu ca gia tri goc va gia tri suy ra.
Huong sua: dung computed property.

## Tu kiem tra

1. Ban co phan biet duoc field va property khong?
2. Ban co biet khi nao dung auto property khong?
3. Ban co biet khi nao can `private set` khong?
4. Ban co biet khi nao nen tao computed property khong?
5. Ban co the tu viet them 5 class voi property hop ly khong?

## Mini project 1

Viet he thong quan ly san pham mini.
Moi san pham co ten, gia, ton kho, trang thai con hang.
Dung property de bao ve du lieu.
Co method nhap va xuat kho.

## Mini project 2

Viet he thong quan ly hoc vien mini.
Hoc vien co ten, diem trung binh, xep loai.
Khong cho diem vuot khoang hop le.
Xep loai duoc tinh qua property chi doc.

## Mini project 3

Viet he thong vi dien tu mini.
Tai khoan co chu so huu, so du, trang thai khoa mo.
So du chi thay doi qua method nap rut.
Trang thai chi thay doi qua method khoa mo.

## Tong ket

1. Property la mot phan rat quan trong cua OOP trong C#.
2. Hieu property se giup ban thiet ke class sach va an toan hon.
3. Day la nen tang rat quan trong truoc khi hoc entity, model va cac framework.

## Bo sung bai tu luyen nhanh

### Bai 31

Tao class `WarehouseItem`.
Co `Code`, `Name`, `ImportPrice`, `SellPrice`, `Quantity`.
Khong cho gia am.
Co property `EstimatedValue` = `SellPrice * Quantity`.

### Bai 32

Tao class `GymMember`.
Co `FullName`, `Weight`, `Height`.
Khong cho `Weight` va `Height` am.
Co property chi doc `BmiApprox` neu ban muon tinh them.

### Bai 33

Tao class `Laptop`.
Co `Brand`, `RamGb`, `StorageGb`, `BatteryLevel`.
`BatteryLevel` nam trong 0 den 100.
Them method `Charge(int amount)`.

### Bai 34

Tao class `CinemaSeat`.
Co `SeatCode`, `Price`, `IsBooked`.
Chi doi `IsBooked` qua method `Book()` va `Cancel()`.
Co property `StatusText` chi doc.

### Bai 35

Tao class `OnlineOrder`.
Co `Subtotal`, `Tax`, `Shipping`, `Discount`.
Co property `GrandTotal`.
Khong cho `Discount` lon hon tong tam tinh.

### Bai 36

Tao class `BatteryPack`.
Co `Capacity`, `CurrentCharge`.
Khong cho vuot muc.
Co property `IsEmpty` va `IsFull`.
Thu cap nhat nhieu gia tri.

### Bai 37

Tao class `MusicTrack`.
Co `Title`, `Artist`, `DurationSeconds`, `CurrentSeconds`.
Khong cho `CurrentSeconds` am hoac vuot qua tong thoi luong.
Co property `ProgressPercent`.

### Bai 38

Tao class `Assignment`.
Co `Title`, `TotalPoints`, `EarnedPoints`.
Khong cho `EarnedPoints` > `TotalPoints`.
Co property `Passed` neu dat tu 50%.

### Bai 39

Tao class `Motorbike`.
Co `PlateNumber`, `FuelLevel`, `MaxFuelLevel`.
Co property `NeedRefuel`.
Dung property de chan du lieu bat hop le.

### Bai 40

Tao class `Coupon`.
Co `Code`, `Percent`, `UsageCount`, `MaxUsage`.
Co property `CanUse`.
Chi cho tang `UsageCount` bang method.

## Goi y mo rong

1. Moi class nen co ten property ro nghia.
2. Khong nen bo qua validate chi vi bai nho.
3. Hay viet them method de thay doi state thay vi mo setter qua rong.
4. Khi co du lieu suy ra duoc, uu tien property chi doc.
5. Hay test voi gia tri am, gia tri 0, gia tri sat moc, va gia tri vuot nguong.
6. Hay thu doi setter thanh `private set` va xem class co chat che hon khong.
7. Hay tu hoi ben ngoai co that su can set property nay khong.
8. Hay dat ngu canh thuc te cho class de de thiet ke hon.

## Cau hoi tu duy

1. Vi sao `Balance` khong nen co `public set`?
2. Vi sao `Rank` nen la computed property?
3. Khi nao auto property la du tot?
4. Khi nao can full property co field nen?
5. Khi nao method phu hop hon setter?
6. Vi sao property giup doi implementation sau nay de hon?
7. Vi sao ten property can ro nghia?
8. Ban co the tim ra 5 field public nen doi thanh property khong?

## Checklist tu danh gia

1. Ban co validate tat ca gia tri can validate khong?
2. Ban co dung `private set` cho state nhay cam khong?
3. Ban co tranh luu trung lap du lieu suy ra khong?
4. Ban co dat ten property la danh tu khong?
5. Ban co dat ten method la dong tu khong?
6. Ban co test voi du lieu xau khong?
7. Ban co de class giu tinh hop le ben trong no khong?
