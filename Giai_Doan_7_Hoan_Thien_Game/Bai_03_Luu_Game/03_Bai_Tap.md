# Bài tập Bài 3

## Bài 1

Tạo `SaveData` lưu `Gold` và `Level`.

## Bài 2

Lưu dữ liệu bằng `JsonUtility`.

## Bài 3

Thử load dữ liệu khi mở game lại.

## Muc tieu cua bo bai tap nay

- Hieu luong suy nghi khi thiet ke he thong save.
- Phan biet du lieu nao can luu, du lieu nao khong can luu.
- Biet tach runtime object va save data.
- Biet kiem tra save co chay dung khong.
- Biet doc log va debug khi load sai.

## Cach hoc de hieu bai tap nay

- Lam tung bai tu de den kho.
- Sau moi bai, tu giai thich bang loi xem minh vua luu cai gi.
- Neu thay code chay duoc, van phai tu hoi vi sao no chay duoc.
- Dung lam vo cho qua.

## Bai 4: Mo rong SaveData

Tao class `SaveData` chua them cac truong sau:

- `PlayerName`
- `CurrentHealth`
- `MaxHealth`
- `CurrentSceneName`
- `CheckpointX`
- `CheckpointY`
- `HasDoubleJump`

Yeu cau:

- Dat ten truong ro nghia.
- Chon kieu du lieu dung.
- Giai thich vi sao moi truong do can duoc luu.

## Bai 5: Phan loai du lieu

Hay chia cac du lieu sau thanh 2 nhom:

- nen luu
- khong can luu

Danh sach du lieu:

- so vang hien tai
- ten scene hien tai
- tham chieu den `Transform` cua player
- am luong nhac
- so frame da chay
- danh sach item trong tui do
- object pool dang chua bao nhieu vien dan
- level hien tai
- vi tri checkpoint
- log debug tam thoi

Sau khi chia xong, tu giai thich vi sao.

## Bai 6: Luu vi tri checkpoint

Yeu cau:

- Tao du lieu luu checkpoint gom `x`, `y`, `z`.
- Khi player cham checkpoint, cap nhat save data.
- In log ra Console khi da cap nhat checkpoint.

Goi y:

- Co the luu `float checkpointX`, `float checkpointY`, `float checkpointZ`.
- Chua can toi uu.
- Tap trung vao dung luong suy nghi.

## Bai 7: Nut Save thu cong

Hay tu tao mot nut `Save` trong UI.

Yeu cau:

- Khi bam nut, goi ham `Save()`.
- In thong bao `Da luu game` ra Console.
- Sau khi save, tat game va mo lai de kiem tra.

## Bai 8: Nut Load thu cong

Hay tao mot nut `Load` trong UI.

Yeu cau:

- Khi bam nut, goi ham `Load()`.
- Sau khi load, cap nhat lai du lieu tren UI.
- Neu khong co save, hien thong bao phu hop.

## Bai 9: Kiem tra save rong

Yeu cau:

- Neu chua co du lieu save, khong duoc de game bi loi.
- Hien thong bao `Chua co du lieu save`.
- Neu da co save, cho phep load binh thuong.

## Bai 10: Xoa save

Hay them mot ham `DeleteSave()`.

Yeu cau:

- Xoa key save trong `PlayerPrefs`.
- Sau khi xoa, bam `Load` phai hien thong bao khong co save.
- In log xac nhan da xoa save.

## Bai 11: Save settings

Hay luu nhung cai dat sau:

- music volume
- sfx volume
- language

Yeu cau:

- Tao du lieu settings rieng hoac luu chung trong `SaveData`.
- Sau khi doi settings, save lai.
- Lan sau mo game, settings phai duoc khoi phuc.

## Bai 12: Inventory save co ban

Hay mo phong inventory bang mot danh sach ten item.

Yeu cau:

- Luu danh sach item vao save data.
- Sau khi load, in ra tung item.
- Kiem tra xem thu tu item co bi sai khong.

## Bai 13: Quest progress

Hay luu trang thai cua quest.

Vi du:

- da nhan quest chua
- da hoan thanh quest chua
- da nhan thuong chua

Yeu cau:

- Tao du lieu ro rang.
- Khi load lai, trang thai quest phai dung.

## Bai 14: Save theo scene

Hay thiet ke them truong `CurrentSceneName`.

Yeu cau:

- Khi save, luu ten scene hien tai.
- Khi load, in ra xem can vao scene nao.
- Chua can viet he thong chuyen scene day du, chi can luu dung ten scene.

## Bai 15: Save checkpoint cuoi cung

Tinh huong:

- Nguoi choi di qua nhieu checkpoint.
- Game can nho checkpoint moi nhat.

Yeu cau:

- Moi lan qua checkpoint moi, ghi de du lieu cu.
- Khi load, dua player ve checkpoint gan nhat.

## Bai 16: Auto save don gian

Hay auto save khi:

- qua checkpoint
- qua man
- nhat item hiem

Yeu cau:

- Moi lan auto save, in log cho ro.
- Khong goi save moi frame.

## Bai 17: So sanh manual save va auto save

Hay tu viet ngan gon:

- uu diem manual save
- nhuoc diem manual save
- uu diem auto save
- nhuoc diem auto save

## Bai 18: Save du lieu boss

Hay thiet ke save cho boss.

Yeu cau:

- luu boss da bi ha chua
- luu boss con bao nhieu mau neu game cho phep quay lai giua tran

Tu giai thich:

- luc nao nen luu boss health
- luc nao chi can luu boss dead = true

## Bai 19: Debug save sai

Tinh huong:

- Ban bam save, bam load nhung du lieu khong doi.

Hay lap danh sach cac buoc debug:

- co goi ham save that khong
- co goi ham load that khong
- key co dung khong
- json co du lieu khong
- sau load co ap lai len object khong

## Bai 20: Ghi log json

Yeu cau:

- Sau khi `ToJson`, in json ra Console.
- Doc chuoi json bang mat.
- Kiem tra xem no co du du lieu can luu khong.

## Bai 21: Co nen luu Transform truc tiep?

Tu tra loi:

- Vi sao khong nen co gang luu truc tiep ca `Transform` vao file save don gian?
- Vi sao nen luu gia tri `x`, `y`, `z` thay vi tham chieu?

## Bai 22: Tach SaveSystem va SaveData

Hay tu giai thich vai tro:

- `SaveData` dung de lam gi
- `SaveSystem` dung de lam gi

Tai sao khong nen nhet het vao mot class?

## Bai 23: Nhiem vu mini project 1

Hay tu tao mot demo save nho co:

- 1 player co health va gold
- 1 nut save
- 1 nut load
- 1 nut delete save
- 1 text UI hien du lieu hien tai

## Bai 24: Nhiem vu mini project 2

Hay tao mot demo checkpoint:

- scene co 2 checkpoint
- moi checkpoint co vi tri khac nhau
- khi player cham vao, auto save checkpoint moi
- bam load thi player ve dung checkpoint moi nhat

## Bai 25: Nhiem vu mini project 3

Hay tao demo luu settings:

- 2 slider volume
- 1 dropdown language
- 1 nut save settings
- tat game va mo lai van giu duoc cai dat

## Cau hoi tu kiem tra

1. Save data co phai runtime object khong?
2. Vi sao khong nen luu tat ca moi thu trong scene?
3. Vi sao `PlayerPrefs` hop voi du lieu nho?
4. Vi sao can kiem tra co save truoc khi load?
5. Vi sao save system can duoc test bang cach tat mo game?

## Loi sai thuong gap cua nguoi moi

### 1. Luu qua nhieu thu khong can thiet

Ket qua:

- save data roi
- kho bao tri

### 2. Khong ap du lieu load vao game

Nguoi moi hay lam:

- load json thanh cong
- nhung quen gan lai vao UI hoac object

### 3. Dung mot key khac nhau cho save va load

### 4. Khong xu ly truong hop chua co save

### 5. Khong test lai sau khi tat mo game

## Goi y dap an huong suy nghi

- Luu cai co y nghia cho tien trinh.
- Khong luu tham chieu runtime vo nghia.
- Save system can don gian, de test, de debug.
- Moi lan gap loi, in log json ra la cach rat huu ich.

## Thu thach nang cao 1

Them nhieu slot save:

- Slot 1
- Slot 2
- Slot 3

Yeu cau:

- Moi slot co key rieng.
- UI cho phep chon slot.

## Thu thach nang cao 2

Them timestamp vao save:

- ngay luu
- gio luu

Yeu cau:

- Hien thong tin nay trong menu load.

## Thu thach nang cao 3

Hay viet mot bang ke hoach cho save system cua mot game nho gom:

- platformer 2D
- co checkpoint
- co inventory
- co settings
- co 2 boss

Ban se luu nhung gi?

## Ket luan bai tap

Neu lam duoc bo bai tap nay, ban da co tu duy save system o muc co nen tang vung.

Dieu quan trong nhat khong phai la thuoc code mau.

Dieu quan trong nhat la:

- biet data nao can luu
- biet luu vao dau
- biet load ra va ap lai vao game
- biet debug khi co loi
