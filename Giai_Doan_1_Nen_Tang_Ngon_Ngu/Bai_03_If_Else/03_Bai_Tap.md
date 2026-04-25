# Bai tap Bai 03 - If Else

## Muc tieu

1. Hieu khi nao dung `if`, `if else`, `else if`.
2. Luyen doc dieu kien thanh cau tieng Viet.
3. Luyen sap xep thu tu dieu kien hop ly.
4. Luyen test gia tri canh bien de tranh loi logic.
5. Luyen tach dieu kien phuc tap thanh bien bool trung gian.
6. Luyen viet bai toan thuc te dua tren quy tac ra quyet dinh.

## Nguyen tac lam bai

1. Doc de bai va xac dinh so nhanh xu ly.
2. Neu chi co mot truong hop dac biet, nghieng ve `if`.
3. Neu co dung va sai ro rang, nghieng ve `if else`.
4. Neu co nhieu muc xep loai, nghieng ve `else if`.
5. Dat dieu kien chat che hon truoc, rong hon sau.
6. Sau khi code, hay test bang it nhat 3 gia tri.
7. Dac biet test tai cac moc bien nhu `0`, `1`, `5`, `10`, `18`, `20`, `50`, `100`.

## Bai co ban

### Bai 1

Khai bao `playerHealth`.
Neu `playerHealth <= 0` thi in `Game Over`.
Nguoc lai in `Still Alive`.
Thu voi `0`, `1`, `-5`.

### Bai 2

Khai bao `gold`.
Neu `gold >= 100` thi in `Du mua kiem`.
Nguoc lai in `Chua du mua kiem`.
Thu voi `99`, `100`, `101`.

### Bai 3

Khai bao `score`.
Neu `score >= 90` in `S`.
Else if `score >= 75` in `A`.
Else if `score >= 60` in `B`.
Nguoc lai in `C`.

### Bai 4

Khai bao `age`.
Neu `age >= 18` in `Du tuoi`.
Nguoc lai in `Chua du tuoi`.
Giai thich vi sao 18 la gia tri canh bien.

### Bai 5

Khai bao `number`.
Neu `number % 2 == 0` in `So chan`.
Nguoc lai in `So le`.
Thu voi `8`, `11`, `0`.

### Bai 6

Khai bao `temperature`.
Neu lon hon hoac bang `30` in `Troi nong`.
Nguoc lai in `Troi mat`.
Sau do mo rong them nhanh `Troi rat nong` neu >= `35`.

### Bai 7

Khai bao `battery` va `isCharging`.
Neu `battery <= 20` va khong dang sac thi in `Can sac pin`.
Nguoc lai in `Trang thai on`.
Thu voi nhieu truong hop.

### Bai 8

Khai bao `hasKey` va `doorLocked`.
Neu co chia khoa va cua khong khoa thi in `Mo cua thanh cong`.
Nguoc lai in `Khong mo duoc cua`.
Thu doi tung bien mot lan.

### Bai 9

Khai bao `isLoggedIn`.
Neu da dang nhap thi in `Chao mung quay tro lai`.
Nguoc lai in `Vui long dang nhap`.
Them mot bien `isBanned` de mo rong.

### Bai 10

Khai bao `cartTotal`.
Neu `cartTotal >= 300000` thi in `Mien phi van chuyen`.
Else if `cartTotal >= 150000` thi in `Phi ship uu dai`.
Nguoc lai in `Phi ship tieu chuan`.

## Bai trung cap

### Bai 11

Khai bao diem trung binh `average`.
Xep loai theo cac moc:
`>= 9`: Xuat sac
`>= 8`: Gioi
`>= 6.5`: Kha
`>= 5`: Trung binh
Con lai: Yeu

### Bai 12

Khai bao `minutesLate`.
Neu `0` thi `Di hoc dung gio`.
Neu > `0` va <= `5` thi `Di hoc tre nhe`.
Neu > `5` thi `Di hoc tre nhieu`.
Hay test voi `0`, `5`, `6`.

### Bai 13

Khai bao `stock`.
Neu `stock == 0` thi `Het hang`.
Else if `stock < 5` thi `Sap het hang`.
Nguoc lai `Con hang`.
Giai thich vi sao phai kiem tra `== 0` truoc.

### Bai 14

Khai bao `salary`.
Neu `salary >= 30000000` thi `Thu nhap cao`.
Else if `salary >= 15000000` thi `Thu nhap trung binh kha`.
Nguoc lai `Can cai thien thu nhap`.
Tu them mot muc nua neu muon.

### Bai 15

Khai bao `attendanceRate`.
Neu >= `90` thi `Du dieu kien du thi`.
Neu >= `80` thi `Can xem xet them`.
Nguoc lai `Khong du dieu kien`.
Thu voi `79`, `80`, `90`.

### Bai 16

Khai bao `online`, `hasPermission`, `isSuspended`.
Neu bi khoa thi thong bao loi.
Nguoc lai neu online va co quyen thi cho phep thao tac.
Nguoc lai thong bao khong du dieu kien.
Viet bang `if else` ro rang.

### Bai 17

Khai bao `orderCount`.
Neu = `0` thi `Chua co don`.
Neu < `10` thi `Shop moi`.
Neu < `100` thi `Shop dang phat trien`.
Nguoc lai `Shop dang on dinh`.
Thu voi cac gia tri bien.

### Bai 18

Khai bao `rainLevel` tu 0 den 100.
Neu > `80` thi `Mua to`.
Neu > `40` thi `Mua vua`.
Neu > `0` thi `Mua nhe`.
Nguoc lai `Khong mua`.

### Bai 19

Khai bao `examScore`.
Neu diem nho hon `0` hoac lon hon `10` thi in `Du lieu khong hop le`.
Nguoc lai xep loai theo moc ban tu dat.
Day la bai luyen kiem tra hop le truoc khi xu ly.

### Bai 20

Khai bao `accountBalance`.
Neu so du < `0` thi `Tai khoan am`.
Neu = `0` thi `Tai khoan rong`.
Neu < `50000` thi `So du thap`.
Nguoc lai `So du on dinh`.

## Bai nang cao vua suc

### Bai 21

Khai bao `level`, `power`, `hasGuild`, `isBanned`.
Neu khong bi cam va (`level >= 15` va `power >= 2000`) hoac co guild thi duoc tham gia event.
Nguoc lai thi khong duoc.
Hay them ngoac de code de doc.

### Bai 22

Khai bao `oldIndex` va `newIndex` cho cong to dien.
Neu `newIndex < oldIndex` thi du lieu sai.
Nguoc lai tinh muc su dung va xep loai:
duoi 50: it
duoi 150: vua
con lai: cao

### Bai 23

Khai bao `gpa` va `conductScore`.
Neu `gpa >= 8` va `conductScore >= 80` thi dat hoc bong.
Neu `gpa >= 7` va `conductScore >= 70` thi can xem xet.
Nguoc lai khong dat.
Thu voi 4 truong hop khac nhau.

### Bai 24

Khai bao `vipLevel` va `purchaseAmount`.
Neu `vipLevel >= 3` va `purchaseAmount >= 300000` thi giam 20%.
Else if `purchaseAmount >= 300000` thi giam 10%.
Else if `purchaseAmount >= 100000` thi giam 5%.
Nguoc lai khong giam.

### Bai 25

Khai bao `loginAttempts`.
Neu `loginAttempts >= 5` thi `Tam khoa dang nhap`.
Else if `loginAttempts >= 3` thi `Canh bao nhap sai nhieu lan`.
Nguoc lai `Van con binh thuong`.
Giai thich y nghia thu tu dieu kien.

### Bai 26

Khai bao `yearOfExperience`.
Neu >= `5` thi `Senior`.
Else if >= `2` thi `Middle`.
Else `Junior`.
Sau do bo sung dieu kien `intern` neu < `1`.

### Bai 27

Khai bao `hour`.
Neu < `0` hoac > `23` thi `Gio khong hop le`.
Nguoc lai phan loai sang, chieu, toi theo khoang gio.
Muc tieu la luyen kiem tra du lieu hop le truoc.

### Bai 28

Khai bao `customerAge` va `hasStudentCard`.
Neu tuoi < `6` thi mien phi.
Else if co the hoc sinh thi gia uu dai.
Nguoc lai gia thuong.
Ban tu them bien gia ve de in ket qua hoan chinh.

### Bai 29

Khai bao `cpuUsage`.
Neu > `90` thi `Nguy hiem`.
Else if > `70` thi `Cao`.
Else if > `40` thi `Trung binh`.
Nguoc lai `Thap`.
Thu voi 40, 41, 70, 71, 90, 91.

### Bai 30

Khai bao `progress` tu 0 den 100.
Neu ngoai khoang nay thi `Khong hop le`.
Nguoc lai:
0: Chua bat dau
1-49: Dang thuc hien
50-99: Sap hoan tat
100: Hoan tat

## Bai mo rong theo tinh huong that

### Bai 31

Danh gia ket qua giao hang.
Khai bao `deliveryDays`.
Neu <= `1` thi `Giao sieu toc`.
Neu <= `3` thi `Giao nhanh`.
Neu <= `7` thi `Giao tieu chuan`.
Nguoc lai `Giao cham`.

### Bai 32

Danh gia tinh trang suc khoe theo so gio ngu.
Neu < `5` thi `Thieu ngu nghiem trong`.
Neu < `7` thi `Can nghi ngoi them`.
Neu <= `9` thi `On dinh`.
Nguoc lai `Ngu qua nhieu`.

### Bai 33

Kiem tra ket qua mat khau.
Khai bao `length`, `hasDigit`, `hasUppercase`.
Neu do dai < `8` thi mat khau yeu.
Nguoc lai neu co du chu so va chu hoa thi manh.
Nguoc lai trung binh.

### Bai 34

Xep loai can nang hanh ly.
Neu <= `7` kg thi `Xach tay`.
Neu <= `20` kg thi `Ky gui co ban`.
Nguoc lai `Vuot muc`.
Co the them phi phat neu muon.

### Bai 35

Kiem tra ket noi internet.
Khai bao `speedMbps`.
Neu = `0` thi `Mat mang`.
Neu < `10` thi `Rat cham`.
Neu < `50` thi `Binh thuong`.
Nguoc lai `Nhanh`.

## Goi y

1. Sap xep dieu kien tu chat che den rong hon.
2. Hay nghiem tuc test gia tri canh bien.
3. Dung `Console.WriteLine` tam thoi de biet nhanh nao dang chay.
4. Neu dieu kien dai, tach thanh bien bool trung gian.
5. Neu bieu thuc kho doc, them ngoac.
6. Neu ket qua khong dung, doc lai de bai va kiem tra thu tu `else if`.
7. Moi bai nen duoc test voi du lieu dung va du lieu xau.

## Xu ly loi thuong gap

1. Loi: nhanh sau khong bao gio chay.
Nguyen nhan: nhanh truoc rong hon da bat het truong hop.
Huong sua: doi lai thu tu dieu kien.

2. Loi: ket qua sat moc bi sai.
Nguyen nhan: nham `>` voi `>=`.
Huong sua: test lai cac gia tri bien.

3. Loi: dieu kien qua dai kho doc.
Nguyen nhan: nhoi qua nhieu logic tren mot dong.
Huong sua: tach bien bool trung gian.

4. Loi: xu ly du lieu khong hop le qua muon.
Nguyen nhan: khong kiem tra input truoc.
Huong sua: kiem tra hop le ngay dau.

## Tu kiem tra

1. Ban co biet khi nao dung `if` don khong?
2. Ban co biet khi nao can `else if` khong?
3. Ban co nho phai test gia tri canh bien khong?
4. Ban co biet vi sao thu tu dieu kien quan trong khong?
5. Ban co doc duoc mot bieu thuc bool dai thanh cau noi khong?
6. Ban co the tu dat ten cho bien bool trung gian khong?
7. Ban co the tu viet them 5 bai ra quyet dinh nua khong?

## Mini project 1

Viet chuong trinh xep loai hoc vien.
Nhap san diem bang bien trong code.
Kiem tra du lieu hop le.
Xep loai hoc luc.
Thong bao dat hoc bong neu du dieu kien.

## Mini project 2

Viet chuong trinh mo phong quy tac khuyen mai cua shop.
Can co tong don, cap VIP, va ma giam gia.
Ra quyet dinh muc giam cuoi cung.
In giai thich tai sao duoc hoac khong duoc giam.

## Mini project 3

Viet chuong trinh kiem tra quyen tham gia giai dau game.
Xet level, rank, lich su vi pham, va trang thai dang ky.
Dung nhieu nhanh `else if`.
In thong bao cuoi cung ro rang.

## Tong ket

1. If else la nen tang cua moi logic ra quyet dinh.
2. Bai nay rat quan trong truoc khi hoc switch va vong lap nang cao.
3. Chi can ban de bai thanh dieu kien va nhanh xu ly, bai toan se de hon.
4. Tu duy test gia tri bien la ky nang can luyen som.
