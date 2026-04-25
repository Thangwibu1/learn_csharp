# Mo rong chi tiet: Luu Game

## 1. Luu game khong phai la luu ca scene mot cach may moc

- Muc tieu cua save system la luu thong tin can thiet de phuc hoi tien trinh.
- Dieu can luu la du lieu co y nghia cho gameplay.
- Khong nhat thiet va thuong khong nen co gang luu tat ca object trong scene mot cach nguyen xi.

## 2. Cach nghi dung

- Hay hoi: nguoi choi tat game xong, lan sau quay lai can nhung gi?
- Vi tri checkpoint.
- Man da mo khoa.
- So vang.
- Vat pham da nhat.
- Cai dat am thanh.
- Do la nhung du lieu can luu.

## 3. Save data va runtime object la hai thu khac nhau

- Runtime object la object dang song trong scene.
- Save data la ban tom tat du lieu can giu lai.
- Vi du `PlayerHealth` la component runtime.
- `playerCurrentHealth` trong file save la du lieu luu.
- Tach ro hai tang nay la tu duy rat quan trong.

## 4. SaveData nen la mot class don gian

- Thuong ta tao class hoac struct chi chua du lieu.
- Khong nen nhet logic gameplay vao day.
- Day chi la hop du lieu.
- Cach nay de serialize va de bao tri hon.

## 5. Vi du SaveData don gian

```csharp
[System.Serializable]
public class SaveData
{
    public int coins;
    public int currentLevel;
    public float musicVolume;
    public float sfxVolume;
    public float checkpointX;
    public float checkpointY;
}
```

- Vi du nay giu nhung gia tri can thiet thay vi co gang luu toan bo player object.

## 6. Luu gi va khong luu gi

- Nen luu tien trinh, tai nguyen, cai dat, trang thai mo khoa.
- Khong nen luu cache tam, object pool, tham chieu runtime khong co y nghia ben ngoai phien choi.
- Day giup file save gon va on dinh hon.

## 7. Thoi diem luu

- Khi qua checkpoint.
- Khi qua man.
- Khi bam save trong menu.
- Khi thoat game.
- Khi doi cai dat quan trong.
- Khong can luu moi frame.

## 8. Auto save va manual save

- Auto save giup nguoi choi it mat tien trinh.
- Manual save cho nguoi choi cam giac kiem soat.
- Nhieu game dung ket hop ca hai.
- Voi beginner, co the bat dau bang mot trong hai cach truoc.

## 9. PlayerPrefs va file save

- `PlayerPrefs` hop cho gia tri nho nhu am luong, ngon ngu, do nhay.
- Save file hop cho du lieu phuc tap hon.
- Nguoi moi rat hay dung PlayerPrefs cho moi thu.
- Cach do nhanh nhung khong phai luc nao cung dep.

## 10. JSON la lua chon de hieu

- JSON de doc bang mat.
- JSON de debug.
- JSON phu hop voi beginner vi co the in ra Console va nhin thay du lieu dang o dang nao.
- Khi du an lon hon, ban co the can nhieu cach toi uu hon, nhung voi giai doan hoc thi JSON rat hop.

## 11. Tai sao save system can don gian luc ban dau

- Nguoi moi hay muon lam save system rat hoanh trang tu ngay dau.
- Dieu do thuong dan toi roi tung.
- Save system tot luc ban dau nen dat 3 yeu to:
- de hieu
- de test
- de sua

Neu 3 dieu nay on, ban moi tinh tiep toi chuyen toi uu.

## 12. Save du lieu theo cau hoi thuc te

Hay hoi tung cau:

- Neu tat game bay gio, lan sau quay lai nguoi choi co can biet so vang cu khong?
- Co.
- Nguoi choi co can biet object pool da dang giu may vien dan khong?
- Thuong la khong.
- Nguoi choi co can biet da mo khoa scene nao chua?
- Co.

Day la cach nghi dung.

## 13. Save va game design di cung nhau

- Save system khong ton tai tach biet voi game design.
- Cach game cua ban co checkpoint hay khong se anh huong den save system.
- Game co inventory lon hay nho se anh huong den save data.
- Game co level map, chapter, hay open world cung anh huong den cach luu.

## 14. Save toan cuc va save theo scene

- Save toan cuc la du lieu song xuyen suot game.
- Vi du: vang, item hiem, level nguoi choi, settings.
- Save theo scene la du lieu gan voi man hien tai.
- Vi du: cua da mo trong scene do, puzzle da giai trong scene do.

## 15. Co nen tach nhieu file save khong

- Co the.
- Mot file cho profile.
- Mot file cho settings.
- Mot file cho progression.
- Tuy quy mo du an.

Voi beginner, ban co the bat dau bang mot file save tong hop truoc.

## 16. Save slot la gi

- Save slot la nhieu bo du lieu save doc lap.
- Nguoi choi co the co nhieu lan choi khac nhau.
- Moi slot la mot profile rieng.

## 17. Save va bao mat

- PlayerPrefs khong phai la giai phap bao mat.
- JSON thuong de doc, de sua.
- Neu game can bao mat hon, can them ma hoa hoac xac minh du lieu.
- Voi khoa hoc nhap mon, muc tieu la dung va ro rang truoc.

## 18. Save corruption la gi

- La khi file save bi hong, doc khong duoc, thieu du lieu, hoac sai cau truc.
- Ban can nghi truoc cach xu ly:
- co fallback du lieu mac dinh
- co thong bao cho nguoi choi
- co backup save neu can

## 19. Versioning cho save

- Ve sau, game cap nhat co the thay doi cau truc du lieu save.
- Khi do save cu co the khong con hop le 100%.
- Vi vay du an lon thuong co `saveVersion`.

Vi du:

- version 1: chi co gold va level
- version 2: them inventory
- version 3: them quest state

## 20. Kiem thu save system nhu the nao

- Save khi o trang thai A.
- Tat game.
- Mo game.
- Load.
- So sanh ket qua voi trang thai A.

Day la cach kiem thu thuc te nhat.

## 21. Kiem thu canh bien

- Save khi health = 0.
- Save khi inventory rong.
- Save khi vua qua checkpoint.
- Save khi settings o gia tri cuc tri.

## 22. Save va UI

- UI menu save/load khong nen la noi giu logic save chinh.
- UI chi nen goi vao `SaveSystem`.
- Logic save van nen nam o he thong rieng.

## 23. Save va architecture sach

- Data class chi giu du lieu.
- Save system chi lo serialize, deserialize, doc ghi.
- Game system chi lo chuyen du lieu runtime thanh save data va nguoc lai.

## 24. Sai lam pho bien

- Dung `PlayerPrefs` cho inventory lon.
- Luu ca object runtime.
- Khong kiem tra null khi load.
- Khong co key ro rang.
- Khong viet duoc buoc debug khi loi xay ra.

## 25. Vi du checklist thiet ke save cho game nho

- Luu player progression?
- Luu inventory?
- Luu scene hien tai?
- Luu checkpoint?
- Luu settings?
- Luu quest progress?
- Luu boss defeated?

## 26. Tu duy rat quan trong

Save system that ra la bai toan mapping du lieu.

- runtime -> save data
- save data -> runtime

Ban hieu duoc mapping nay la ban da di dung huong.

## 27. Vi du mapping runtime sang save data

- Player current health -> `saveData.currentHealth`
- Wallet gold -> `saveData.gold`
- Scene active name -> `saveData.sceneName`

## 28. Vi du mapping save data sang runtime

- `saveData.currentHealth` -> set vao player health
- `saveData.gold` -> set vao wallet
- `saveData.sceneName` -> quyet dinh scene can load

## 29. Bai hoc lon rut ra

- Dung du lieu quan trong hon luu nhieu.
- Ro trach nhiem quan trong hon code "ngau".
- Save dung, load dung, debug duoc la muc tieu dau tien.

## 30. Tu kiem tra

1. SaveData co nen chua logic gameplay nang khong?
2. Vi sao save system can duoc test bang cach tat va mo game?
3. Vi sao key save phai on dinh?
4. Vi sao save version huu ich?
5. Vi sao save architecture sach giup du an de mo rong?

- JSON de doc va de debug.
- Du lieu duoc serialize thanh chuoi.
- Chuoi duoc ghi ra file.
- Khi can load, doc file roi parse nguoc lai.
- Day la cach hoc save system rat hop ly cho nguoi moi.

## 11. Vi du save manager don gian

```csharp
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private string SavePath => Path.Combine(Application.persistentDataPath, "save.json");

    public void Save(SaveData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(SavePath, json);
    }

    public SaveData Load()
    {
        if (!File.Exists(SavePath))
        {
            return new SaveData();
        }

        string json = File.ReadAllText(SavePath);
        return JsonUtility.FromJson<SaveData>(json);
    }
}
```

## 12. persistentDataPath la gi

- Day la vi tri an toan Unity danh cho du lieu luu cua ung dung.
- Moi nen tang co duong dan thuc te khac nhau.
- Ban khong can hard code mot duong dan tuy y.

## 13. Load game la buoc phuc hoi

- Save la ghi du lieu.
- Load la doc va ap du lieu tro lai vao he thong gameplay.
- Vi du sau khi load, can dat lai vang, mau, checkpoint, man choi.
- Neu chi doc file ma khong ap vao object, game van chua phuc hoi that.

## 14. Thu tu khoi tao khi load

- Doi khi save manager co data rat som.
- Nhung player object chua san sang nhan du lieu.
- Vi vay can biet luc nao ap save la phu hop.
- Dieu nay quay lai bai lifecycle `Awake`, `Start`, `OnEnable`.

## 15. Save va scene management

- Game nhieu scene thuong can biet scene nao dang duoc mo khoa hay dang o.
- Save file co the luu ten scene hoac chi so man.
- Khi load, game mo dung scene roi moi phuc hoi du lieu chi tiet.

## 16. Save va UI

- Nut `Save`, `Load`, `Continue`, `New Game` deu la mot phan cua UI.
- UI khong nen tu chua logic luu phuc tap.
- No nen goi `SaveManager` hoac he thong cap cao hon.
- Day la cach tach trach nhiem sach.

## 17. Save va observer pattern

- Khi du lieu quan trong thay doi, game co the phat su kien.
- UI cap nhat theo event.
- Save system co the quyet dinh danh dau du lieu "da thay doi" de luu vao thoi diem phu hop.
- Day la mot huong phat trien dep khi du an lon hon.

## 18. Save va object pooling

- Khong nen luu toan bo doi tuong pooled dang nam trong scene chi vi no dang ton tai tam thoi.
- Thuong chi luu ket qua co y nghia nhu so quai da giet, song dang choi, coin da nhat.
- Pooling la co che runtime, khong phai su that gameplay can giu nguyen 1-1.

## 19. Save va state machine

- AI dang o state nao co can luu khong phu thuoc game.
- Nhieu game chi can luu ket qua lon hon, vi du so enemy song hoac vi tri checkpoint.
- Khong phai moi state tam thoi deu dang de luu.

## 20. Save settings

- Am luong nhac.
- Am luong hieu ung.
- Do phan giai.
- Ngon ngu.
- Do nhay chuot.
- Day la nhung du lieu luu cuc ky pho bien va de kiem thu.

## 21. New game va continue

- `New Game` thuong tao du lieu mac dinh moi.
- `Continue` thuong load du lieu cu neu co.
- Nguoi moi nen xac dinh ro hai luong nay de tranh ghi de save ngoai y muon.

## 22. Loi thuong gap cua nguoi moi

- Co gang luu tat ca object trong scene.
- Khong tach `SaveData` rieng.
- Luu moi frame vo ich.
- Dung PlayerPrefs cho du lieu qua phuc tap.
- Load du lieu nhung khong ap tro lai vao gameplay.
- Khong tinh den truong hop file chua ton tai.

## 23. Checklist khi save khong dung

- File save co duoc tao khong?
- Save path co dung khong?
- Du lieu co duoc ghi ra file khong?
- Luc load co file ton tai khong?
- Sau khi load, du lieu co duoc ap vao object khong?
- Scene da san sang de nhan du lieu chua?

## 24. Bai tap tu hoc

- Luu so coin va man choi hien tai bang JSON.
- Them save cho am luong nhac.
- Tao menu `Continue` chi sang neu da co file save.
- Them checkpoint va luu vi tri hoi sinh.
- Xoa file save de test `New Game`.

## 25. Cau hoi tu kiem tra

- Vi sao khong nen luu ca scene mot cach may moc?
- `SaveData` nen chua gi?
- Khi nao nen dung PlayerPrefs?
- Vi sao load khong chi la doc file?
- Vi sao object pool thuong khong nen luu truc tiep?

## 26. Ket noi voi bai AI va observer

- Khi game lon hon, save system se song cung state machine AI, UI event va menu dieu khien.
- Neu tu duy luu du lieu duoc dat dung ngay tu dau, game se de mo rong hon rat nhieu.

## 27. Nguyen tac can nho khi mo rong sau nay

- Luu du lieu co y nghia, khong luu moi thu thay mat.
- Tach class du lieu khoi class gameplay.
- Chon thoi diem luu hop ly thay vi luu vo toi va.
- Kiem thu truong hop file rong, file khong ton tai va save cu.

## 28. Tong ket nhanh

- Save la ghi du lieu.
- Load la phuc hoi du lieu vao game.
- `SaveData` la hop thong tin.
- `SaveManager` la noi ghi doc.
- UI la noi nguoi choi kich hoat hanh dong save load.
