# Bai tap Bai 05 - Nullable Types

## Muc tieu

1. Hieu `null` khac `0` va `false`.
2. Biet khi nao nen dung `int?`, `double?`, `bool?`, `DateTime?`.
3. Luyen `HasValue`, `Value`, `== null`, `!= null`.
4. Luyen toan tu `??` de dat gia tri mac dinh.
5. Luyen mo ta du lieu chua day du mot cach ro rang.

## Nguyen tac lam bai

1. Truoc moi bai, tra loi cau hoi: null co nghia gi?
2. Neu khong co y nghia ro rang, co the chua can nullable.
3. Neu co y nghia `chua biet`, `chua nhap`, `chua ton tai`, nullable rat hop.
4. Chi dung `.Value` sau khi da kiem tra an toan.
5. Dung `??` khi can gia tri mac dinh de tinh toan hay hien thi.

## Bai co ban

### Bai 1

Khai bao `int? playerLevel = null`.
In gia tri cua bien.
Kiem tra `HasValue`.
Neu co gia tri thi in `.Value`.
Nguoc lai in `Chua co level`.

### Bai 2

Khai bao `float? bossHealth = null`.
Sau do gan `250.5f`.
In ra gia tri truoc va sau khi gan.
Kiem tra `HasValue` sau moi buoc.

### Bai 3

Khai bao `int? rewardGold = null`.
Dung `??` de lay gia tri mac dinh `0`.
In ket qua.
Sau do gan `rewardGold = 120` va chay lai.

### Bai 4

Khai bao `int? selectedWeaponId = null`.
Neu bang `null` thi in `Chua chon vu khi`.
Nguoc lai in ma vu khi.
Sau do gan `selectedWeaponId = 5`.

### Bai 5

Khai bao `bool? hasAcceptedRules = null`.
In trang thai luc dau.
Gan `true`, in lai.
Gan `false`, in lai.
Tu giai thich vi sao `bool?` co 3 trang thai.

### Bai 6

Khai bao `double? temperature = null`.
Neu khong co du lieu thi in `Cam bien chua gui ve`.
Sau do gan `36.7` va in lai.
Khong duoc dung `.Value` khi chua kiem tra.

### Bai 7

Khai bao `DateTime? birthday = null`.
Neu co gia tri thi in ngay sinh.
Neu khong co thi in `Chua nhap ngay sinh`.
Sau do gan mot ngay cu the va in lai.

### Bai 8

Khai bao `decimal? discountPrice = null` va `decimal basePrice = 200000m`.
Dung `??` de xac dinh gia cuoi cung.
Sau do gan gia khuyen mai va tinh lai.
Muc tieu la hieu kieu du lieu tuy chon.

### Bai 9

Khai bao `int? bonus = null` va `int salary = 1000`.
Tinh tong thu nhap an toan bang `salary + (bonus ?? 0)`.
Sau do gan `bonus = 300`.
Tinh lai va in ket qua.

### Bai 10

Khai bao `string title = null`.
Dung `??` de hien thi `Chua dat tieu de`.
Sau do gan `Bao cao tuan`.
In lai gia tri hien thi.

## Bai trung cap

### Bai 11

Mo phong thong tin nguoi dung.
Khai bao `int? age`, `double? height`, `double? weight`.
Trong do chi gan gia tri cho mot hoac hai bien.
In thong tin theo kieu `Chua cap nhat` neu null.

### Bai 12

Mo phong trang thai don hang.
Khai bao `int? shipperId = null`.
Neu null thi thong bao `Chua giao cho shipper`.
Neu co gia tri thi in ma shipper.
Sau do gan ma shipper va in lai.

### Bai 13

Mo phong diem danh gia san pham.
Khai bao `double? rating = null`.
Hien thi ra `0` neu chua co danh gia.
Khi rating = `4.6`, hien thi dung diem do.
Tu giai thich vi sao null va 0 khac nhau.

### Bai 14

Mo phong he thong dang ky su kien.
Khai bao `int? seatNumber = null`.
Neu chua co so ghe thi in `Chua sap cho`.
Neu co thi in `So ghe cua ban la ...`.
Sau do gan `seatNumber = 12`.

### Bai 15

Mo phong du lieu hoc tap.
Khai bao `double? midterm`, `double? finalExam`.
Chi cho finalExam gia tri.
Dung `??` de tinh tong tam thoi an toan.
In ket qua va chu thich y nghia.

### Bai 16

Khai bao `bool? isPremium`.
Neu null thi in `Chua xac dinh goi thanh vien`.
Neu true thi in `Tai khoan premium`.
Neu false thi in `Tai khoan thuong`.
Goi y dung `if else` don gian.

### Bai 17

Khai bao `int? warningCount = null`.
Dung `??` de coi nhu `0` khi hien thi.
Sau do tang canh bao bang cach gan gia tri that.
In ket qua sau moi buoc.

### Bai 18

Khai bao `DateTime? deliveryDate = null`.
In thong bao `Dang cho xac nhan lich giao` neu null.
Neu co ngay thi in ra.
Sau do gan mot ngay giao cu the.

### Bai 19

Khai bao `decimal? extraFee = null` va `decimal baseFee = 30000m`.
Tinh phi can thu = `baseFee + (extraFee ?? 0)`.
Sau do gan `extraFee = 15000m`.
Tinh lai.

### Bai 20

Khai bao `int? selectedTab = null`.
Neu null thi mac dinh chon tab `1` bang `??`.
Sau do gan `selectedTab = 3` va lay lai tab hien tai.
Mo ta y nghia cua bai nay trong UI.

## Bai nang cao vua suc

### Bai 21

Mo phong tai khoan game.
Khai bao `int? selectedSkillId`, `int defaultSkillId = 1`.
Neu chua chon ky nang thi dung mac dinh.
Neu da chon thi dung ky nang do.
In ket qua trong ca hai truong hop.

### Bai 22

Mo phong ket qua thi.
Khai bao `double? test1`, `double? test2`, `double? test3`.
Mot bai chua co diem.
Tinh tong tam thoi an toan bang cach thay null thanh 0.
Giai thich han che cua cach tinh nay.

### Bai 23

Khai bao `int? yearOfBirth = null`.
Neu co gia tri thi tinh tuoi du kien dua tren nam hien tai gia lap.
Neu khong thi thong bao khong du thong tin.
Chu y kiem tra null truoc khi tinh.

### Bai 24

Khai bao `bool? hasSubmitted = null`.
Phan loai 3 trang thai:
null: chua thao tac
true: da nop
false: da huy nop
In thong bao tuong ung.

### Bai 25

Khai bao `decimal? finalPrice = null`.
Neu null thi tinh tu `originalPrice - discountAmount`.
Neu khong null thi uu tien dung `finalPrice`.
Day la bai luyen uu tien gia tri da tinh san.

### Bai 26

Mo phong du lieu cam bien.
Khai bao `double? humidity = null`.
Neu null thi dung gia tri du phong `50`.
Sau do gan `68.2` va hien thi lai.
Viet code gon va ro rang.

### Bai 27

Khai bao `int? score = null`.
Neu co gia tri thi xep loai theo if else.
Neu null thi in `Chua co diem`.
Muc tieu la ket hop nullable voi bai if else.

### Bai 28

Mo phong bo loc tim kiem.
Khai bao `int? minPrice = null`, `int? maxPrice = null`.
In thong bao nhung bo loc nao dang duoc ap dung.
Null nghia la khong gioi han.
Giai thich y nghia thuc te.

### Bai 29

Khai bao `DateTime? endDate = null`.
Neu null thi hien `Khong thoi han`.
Neu co gia tri thi hien `Het han vao ...`.
Day la tinh huong rat hay gap trong ma giam gia.

### Bai 30

Khai bao `int? retryCount = null`.
Dung `??` de lay mac dinh `0`.
Sau do mo phong tang so lan thu len 1, 2, 3.
In sau moi lan cap nhat.

## Bai theo tinh huong that

### Bai 31

Thong tin ho so ung vien.
Co `expectedSalary`, `portfolioLink`, `graduationYear`.
Mot vai thong tin co the chua co.
Hay mo ta bang bien nullable hoac chuoi co the null.
In ra ho so than thien voi nguoi doc.

### Bai 32

Thong tin san pham.
Co `flashSalePrice`, `rating`, `reviewCount`.
Flash sale co the chua mo.
Rating co the chua co.
Hay hien thi an toan.

### Bai 33

Thong tin suc khoe.
Co `heartRate`, `temperature`, `oxygenLevel`.
Co the mot cam bien chua gui du lieu.
Hay in thong bao cho tung loai du lieu.
Dung nullable de mo ta.

### Bai 34

Thong tin khoa hoc.
Co `finalProjectScore`, `certificateIssueDate`, `mentorRating`.
Tat ca deu co the chua co o mot thoi diem.
Hay trinh bay du lieu ro rang va an toan.

### Bai 35

Thong tin giao hang.
Co `pickupTime`, `deliveryTime`, `delayMinutes`.
Neu chua bat dau giao thi cac gia tri co the null.
Hay viet code bieu dien hop ly.

## Goi y

1. Null co nghia la `chua co`, khong phai `gia tri bang 0`.
2. Chi dung `.Value` sau khi da xac nhan bien co gia tri.
3. Dung `??` khi can gia tri mac dinh.
4. Dung nullable khi y nghia nghiep vu can phan biet `chua co` va `co gia tri`.
5. Neu khong can phan biet, co the khong can nullable.

## Xu ly loi thuong gap

1. Loi: dung `.Value` khi bien dang null.
Nguyen nhan: khong kiem tra `HasValue`.
Huong sua: check truoc hoac dung `??`.

2. Loi: nham null voi 0.
Nguyen nhan: dat mac dinh qua som.
Huong sua: giu null den luc can hien thi hoac tinh toan.

3. Loi: mat y nghia 3 trang thai cua `bool?`.
Nguyen nhan: chi xu ly true false.
Huong sua: bo sung nhanh cho null.

## Tu kiem tra

1. Ban co giai thich duoc null khac 0 the nao khong?
2. Ban co biet khi nao dung `int?` khong?
3. Ban co nho cach dung `HasValue` va `Value` khong?
4. Ban co biet khi nao dung `??` khong?
5. Ban co the tu dat them 5 tinh huong can nullable khong?

## Mini project 1

Viet chuong trinh hien thi ho so nguoi dung chua day du.
Mot so thong tin co the null.
Can hien thi `Chua cap nhat` neu thieu.
Can in ro rang tung truong.

## Mini project 2

Viet chuong trinh mo phong thong tin san pham thuong mai dien tu.
Co gia thuong, gia sale, diem danh gia, so danh gia.
Gia sale va diem danh gia co the null.
Can hien thi an toan va co y nghia.

## Mini project 3

Viet chuong trinh mo phong form dang ky khoa hoc.
Nam sinh, diem dau vao, ma giam gia, va nguoi gioi thieu deu co the null.
Can phan biet du lieu chua nhap voi du lieu da nhap bang 0.
Can in tom tat form.

## Tong ket

1. Nullable giup code sat voi thuc te du lieu hon.
2. Day la bai rat quan trong cho xu ly form, UI, database va API.
3. Neu hieu sau bai nay, ban se tranh duoc rat nhieu loi ngat chuong trinh vi null.
