# Bài tập Bài 5

## Bài 1

Thêm event `OnHealed` khi người chơi được hồi máu.

## Bài 2

Tạo hệ thống âm thanh nghe event `OnPlayerDied` để phát sound.

## Bài 3

Tự giải thích: vì sao cách làm này tốt hơn việc để UI tự kiểm tra trong `Update()`?

## Muc tieu cua bo bai tap

- Hieu observer pattern qua code that.
- Biet phan biet nguon phat su kien va noi nghe su kien.
- Biet dung event cho UI, achievement, sound, quest.
- Biet tranh code polling vo ich trong `Update()`.
- Biet xu ly dang ky va huy dang ky event.

## Cach hoc bai nay

- Lam tung bai, chay thu sau moi buoc.
- Moi lan them listener, in log xem event da duoc goi chua.
- Tu hoi: nguon phat co dang biet qua nhieu ve listener khong?

## Bai 4: Tao event `OnHealthChanged`

Yeu cau:

- Player health phat event moi khi mau doi.
- Event truyen `currentHealth` va `maxHealth`.
- UI nghe event va cap nhat slider.

## Bai 5: Tao event `OnGoldChanged`

Yeu cau:

- He thong wallet co event `OnGoldChanged`.
- Gold UI nghe event nay.
- Khi nhat coin, UI cap nhat ngay.

## Bai 6: Tien hanh so sanh voi cach polling

Hay viet ngan gon:

- neu dung `Update()` de kiem tra gold doi hay chua thi co van de gi?
- event tot hon o diem nao?

## Bai 7: Them `OnHealed`

Yeu cau:

- Khi nguoi choi duoc hoi mau, phat `OnHealed`.
- Sound system nghe event va phat sound heal.
- UI van cap nhat bang `OnHealthChanged`.

## Bai 8: Them `OnPlayerDied`

Yeu cau:

- Khi health = 0, phat `OnPlayerDied`.
- UI hien thong bao.
- Achievement system mo khoa achievement dau tien bi ha.
- Audio system phat sound chet.

## Bai 9: Them `OnEnemyKilled`

Yeu cau:

- Khi enemy bi ha, phat su kien `OnEnemyKilled`.
- Score system nghe event de cong diem.
- Quest system nghe event de tang tien do quest.

## Bai 10: Dang ky va huy dang ky event

Yeu cau:

- Dung `OnEnable` de dang ky.
- Dung `OnDisable` de huy dang ky.

Tu giai thich:

- vi sao neu quên huy dang ky thi de gay loi?

## Bai 11: Event cho pause menu

Hay tao event `OnGamePaused`.

Listener co the la:

- pause UI
- audio manager
- input blocker

## Bai 12: Event cho quest complete

Hay tao event `OnQuestCompleted`.

Yeu cau:

- UI quest nghe event de hien popup.
- reward system nghe event de trao thuong.

## Bai 13: Event cho level up

Hay tao event `OnLevelUp`.

Listener co the la:

- VFX system
- sound system
- stats panel

## Bai 14: Event chain

Tinh huong:

- Player kill enemy.
- Enemy phat `OnEnemyKilled`.
- Score system tang diem.
- Score system dat nguong 1000 diem va phat `OnScoreMilestoneReached`.
- Achievement system nghe su kien do.

Hay ve luong nay bang chu.

## Bai 15: Nguon phat co nen goi truc tiep UI?

Tu tra loi:

- vi sao `PlayerHealth` khong nen tu goi `HealthBarUI.SetValue()` truc tiep trong du an lon?

## Bai 16: Tao listener moi ma khong sua source

Yeu cau:

- Them `LowHealthWarning` nghe `OnHealthChanged`.
- Khong sua logic ben trong `PlayerHealth` de ho tro class moi nay.

Muc tieu:

- Thay duoc loi ich mo rong cua observer.

## Bai 17: Event thong bao hoi sinh

Hay tao `OnRespawned`.

Listener co the la:

- UI reset
- camera reset
- VFX spawn

## Bai 18: Event cho inventory

Yeu cau:

- Inventory phat `OnItemAdded`.
- Inventory UI nghe event de them item vao list.
- Sound system nghe event de phat am thanh nhat do.

## Bai 19: Event cho settings

Yeu cau:

- Settings system phat `OnLanguageChanged`.
- UI text system nghe event de doi ngon ngu.

## Bai 20: Debug event khong chay

Tinh huong:

- Ban chac rang da `Invoke`, nhung UI khong doi.

Hay lap checklist debug:

- listener da dang ky chua
- object listener co dang active khong
- event co null khong
- `Invoke` co duoc goi that khong
- du lieu truyen vao co dung khong

## Bai 21: Tao event static co nen khong?

Hay tu viet ngan gon:

- khi nao event static tien
- khi nao event static nguy hiem

## Bai 22: Observer va decoupling

Hay tu giai thich:

- observer pattern giup giam phu thuoc nhu the nao?
- listener moi duoc them vao ma source co can sua khong?

## Bai 23: Mini project 1

Tao demo health system co:

- player health
- health bar UI
- low health warning
- death popup

Tat ca phai cap nhat bang event.

## Bai 24: Mini project 2

Tao demo achievement co:

- achievement kill 10 enemy
- achievement lan dau chet
- achievement dat 1000 diem

Tat ca phai nghe event.

## Bai 25: Mini project 3

Tao demo inventory event co:

- nhat item
- cap nhat UI
- phat sound
- hien popup item moi

## Bai 26: Bai tap so sanh kien truc

Hay viet ngan gon su khac nhau giua:

- source goi truc tiep UI
- source phat event, UI tu nghe

Theo tieu chi:

- de mo rong
- de test
- do phu thuoc
- kha nang tai su dung

## Bai 27: Bai tap thuc chien voi boss

Tinh huong:

- Boss doi phase o 70% mau va 30% mau.

Hay thiet ke cac event:

- `OnBossPhaseChanged`
- `OnBossDied`

Ai se la listener?

- boss UI
- music system
- VFX system
- quest system

## Bai 28: Bai tap ve memory leak event

Hay giai thich bang loi:

- vi sao quen huy dang ky event trong Unity co the gay loi rat kho tim?

## Bai 29: Bai tap ve thu tu su kien

Tinh huong:

- Player chet.
- Vua can tat input.
- Vua can mo game over UI.
- Vua can phat sound.

Hay de xuat thu tu hop ly.

## Bai 30: Bai tap viet pseudocode

Hay viet pseudocode cho:

- source player health
- health UI listener
- achievement listener

## Cau hoi tu kiem tra

1. Event khac gi viec goi ham truc tiep?
2. Vi sao observer pattern hop voi UI?
3. Vi sao observer pattern hop voi achievement?
4. Vi sao phai huy dang ky event?
5. Event giup giam `Update()` nhu the nao?

## Loi sai thuong gap cua nguoi moi

### 1. Quen huy dang ky event

### 2. Event phat qua nhieu viec khong lien quan

### 3. Dat ten event mo ho

### 4. Source van biet qua nhieu ve listener

### 5. Khong log de debug khi event khong chay

## Thu thach nang cao 1

Tao event bus don gian cho du an nho.

## Thu thach nang cao 2

Them listener analytics nghe cac event quan trong.

## Thu thach nang cao 3

Mo rong observer pattern cho quest system, dialogue system va save trigger.

## Ket luan bai tap

Neu lam duoc bo bai tap nay, ban se thay observer pattern khong phai la mot ly thuyet mo ho.

No la mot cong cu rat thuc te de giu cho project game sach, de mo rong va de bao tri.
