using System;
using System.Collections.Generic;

class PlayerHealth
{
    // Event phat ra khi mau thay doi.
    public event Action<int> OnHealthChanged;

    // Event phat ra khi nguoi choi chet.
    public event Action OnDied;

    // Mau hien tai.
    public int Health { get; private set; } = 100;

    // Ham nhan sat thuong.
    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }

        // Bao cho moi nguoi nghe biet mau da doi.
        OnHealthChanged?.Invoke(Health);

        // Neu chet thi phat su kien chet.
        if (Health == 0)
        {
            OnDied?.Invoke();
        }
    }
}

class HealthUI
{
    // Ham nay se duoc goi khi mau thay doi.
    public void UpdateBar(int currentHealth)
    {
        Console.WriteLine("UI cap nhat mau: " + currentHealth);
    }
}

class AchievementSystem
{
    // Ham nay duoc goi khi player chet.
    public void OnPlayerDied()
    {
        Console.WriteLine("Achievement check: Player da chet");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao cac he thong.
        PlayerHealth playerHealth = new PlayerHealth();
        HealthUI healthUI = new HealthUI();
        AchievementSystem achievementSystem = new AchievementSystem();

        // Dang ky nghe event.
        playerHealth.OnHealthChanged += healthUI.UpdateBar;
        playerHealth.OnDied += achievementSystem.OnPlayerDied;

        // Gay sat thuong de kich hoat event.
        playerHealth.TakeDamage(30);
        playerHealth.TakeDamage(70);

        // Them cac demo mo rong de thay delegate, Action va event trong nhieu boi canh hon.
        DelegateActionEventDemos.RunAll();
    }
}

delegate void SimpleLog(string message);

class CoinWallet
{
    public event Action<int> OnGoldChanged;
    public int Gold { get; private set; }

    public void AddGold(int amount)
    {
        Gold += amount;
        OnGoldChanged?.Invoke(Gold);
    }

    public void SpendGold(int amount)
    {
        Gold -= amount;

        if (Gold < 0)
        {
            Gold = 0;
        }

        OnGoldChanged?.Invoke(Gold);
    }
}

class GoldUI
{
    public void UpdateGoldText(int currentGold)
    {
        Console.WriteLine("UI vang moi: " + currentGold);
    }
}

class AudioSystem
{
    public void PlayDamageSound(int currentHealth)
    {
        Console.WriteLine("Audio: phat am thanh khi mau con " + currentHealth);
    }

    public void PlayDeathSound()
    {
        Console.WriteLine("Audio: phat am thanh nguoi choi chet");
    }
}

class QuestTracker
{
    public void OnEnemyDefeated(string enemyName)
    {
        Console.WriteLine("Quest cap nhat khi ha muc tieu: " + enemyName);
    }
}

class EnemySpawner
{
    public event Action<string> OnEnemySpawned;

    public void Spawn(string enemyName)
    {
        Console.WriteLine("Spawn enemy: " + enemyName);
        OnEnemySpawned?.Invoke(enemyName);
    }
}

static class DelegateActionEventDemos
{
    public static void RunAll()
    {
        Console.WriteLine("=== Demo delegate co ban ===");
        DemoSimpleDelegate();

        Console.WriteLine("=== Demo Action nhieu listener ===");
        DemoActionChain();

        Console.WriteLine("=== Demo event cho vi vang ===");
        DemoWalletEvent();

        Console.WriteLine("=== Demo event enemy spawn ===");
        DemoEnemySpawnEvent();

        Console.WriteLine("=== Demo unsubscribe ===");
        DemoUnsubscribe();
    }

    private static void DemoSimpleDelegate()
    {
        SimpleLog log = WriteConsoleLog;
        log += WriteConsoleLogUpper;
        log("delegate la bien giu tham chieu toi ham");
    }

    private static void DemoActionChain()
    {
        Action<string> action = PrintMessage;
        action += PrintMessageLength;
        action += PrintMessageDecorated;
        action("Action giup viet gon delegate thong dung");
    }

    private static void DemoWalletEvent()
    {
        CoinWallet wallet = new CoinWallet();
        GoldUI goldUI = new GoldUI();

        wallet.OnGoldChanged += goldUI.UpdateGoldText;
        wallet.OnGoldChanged += currentGold => Console.WriteLine("Log he thong vang: " + currentGold);

        wallet.AddGold(50);
        wallet.AddGold(25);
        wallet.SpendGold(30);
    }

    private static void DemoEnemySpawnEvent()
    {
        EnemySpawner spawner = new EnemySpawner();
        QuestTracker tracker = new QuestTracker();

        spawner.OnEnemySpawned += tracker.OnEnemyDefeated;
        spawner.OnEnemySpawned += enemyName => Console.WriteLine("UI thong bao enemy vua xuat hien: " + enemyName);
        spawner.Spawn("Goblin Scout");
        spawner.Spawn("Orc Warrior");
    }

    private static void DemoUnsubscribe()
    {
        CoinWallet wallet = new CoinWallet();
        GoldUI ui = new GoldUI();

        wallet.OnGoldChanged += ui.UpdateGoldText;
        wallet.AddGold(10);

        wallet.OnGoldChanged -= ui.UpdateGoldText;
        wallet.AddGold(10);

        Console.WriteLine("Sau khi huy dang ky, UI khong con nhan event cu nua.");
    }

    private static void WriteConsoleLog(string message)
    {
        Console.WriteLine("LOG: " + message);
    }

    private static void WriteConsoleLogUpper(string message)
    {
        Console.WriteLine("LOG UPPER: " + message.ToUpper());
    }

    private static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    private static void PrintMessageLength(string message)
    {
        Console.WriteLine("Do dai thong diep: " + message.Length);
    }

    private static void PrintMessageDecorated(string message)
    {
        Console.WriteLine("[Decorated] " + message);
    }
}

/*
Ghi chu event 001: Delegate cho phep luu method nhu du lieu.
Ghi chu event 002: Day la diem bat dau de hieu callback.
Ghi chu event 003: Callback xuat hien khap noi trong lap trinh hien dai.
Ghi chu event 004: Trong game, callback rat hop cho he thong phan ung theo su kien.
Ghi chu event 005: Neu player mat mau, nhieu noi co the can phan ung.
Ghi chu event 006: UI cap nhat thanh mau.
Ghi chu event 007: Audio phat am thanh bi danh.
Ghi chu event 008: Hieu ung man hinh co the rung.
Ghi chu event 009: Achievement system co the kiem tra moc.
Ghi chu event 010: Tat ca nhung phan ung do khong nen bi viet cung cung trong PlayerHealth.
Ghi chu event 011: Neu viet cung, class se bi dinh cung voi qua nhieu he thong.
Ghi chu event 012: Din h cung gay coupling cao.
Ghi chu event 013: Coupling cao lam kho sua va kho test.
Ghi chu event 014: Event la cach tach nguon phat va noi nghe.
Ghi chu event 015: Noi phat chi can noi rang da co su kien xay ra.
Ghi chu event 016: Noi nghe tu quyet dinh can lam gi.
Ghi chu event 017: Day la tu duy observer pattern.
Ghi chu event 018: Action la mot kieu delegate co san.
Ghi chu event 019: Action khong tra ve gia tri.
Ghi chu event 020: Neu can tra ve gia tri, ve sau ban se gap Func.
Ghi chu event 021: O bai nay ta tap trung vao Action va event.
Ghi chu event 022: Event thuong khai bao la public event Action OnSomething;
Ghi chu event 023: Hoac public event Action<int> OnValueChanged;
Ghi chu event 024: Dau hoi cham truoc Invoke giup tranh loi null.
Ghi chu event 025: Neu khong co ai dang ky, event co the bang null.
Ghi chu event 026: Vi vay OnDied?.Invoke() la cu phap rat quen thuoc.
Ghi chu event 027: Delegate co the gom nhieu method trong invocation list.
Ghi chu event 028: Khi goi delegate, tung method dang ky se duoc goi.
Ghi chu event 029: Action chain la vi du don gian cua y tuong nay.
Ghi chu event 030: Nhung voi kien truc ben vung hon, event la lua chon phu hop cho API cong khai.
Ghi chu event 031: Event ngan code ben ngoai tu y gan de lai toan bo danh sach listener.
Ghi chu event 032: Ben ngoai chi co the += hoac -=.
Ghi chu event 033: Day la tinh dong goi huu ich.
Ghi chu event 034: Nguoi moi hay hoi vi sao khong public Action luon.
Ghi chu event 035: Cau tra loi la event cho quyen kiem soat tot hon.
Ghi chu event 036: Ben trong class phat su kien moi la noi co quyen Invoke.
Ghi chu event 037: Day la mot luat thiet ke rat hieu qua.
Ghi chu event 038: Trong Unity, dang ky event thuong xay ra o OnEnable.
Ghi chu event 039: Huy dang ky thuong xay ra o OnDisable.
Ghi chu event 040: Bai nay la C# thuần, nhung tu duy do van rat can.
Ghi chu event 041: Quen huy dang ky la loi kinh dien.
Ghi chu event 042: No co the gay nghe thua, goi trung, hoac memory leak.
Ghi chu event 043: Dac biet khi object listener khong con hop le nua.
Ghi chu event 044: Demo unsubscribe o tren duoc them de nhan manh dieu nay.
Ghi chu event 045: Hay tap thong quen nghi den vong doi object.
Ghi chu event 046: Listener song den bao lau.
Ghi chu event 047: Publisher song den bao lau.
Ghi chu event 048: Ai dang ky, ai huy dang ky.
Ghi chu event 049: Day la cac cau hoi rat thuc chien.
Ghi chu event 050: Delegate co the la method thuong.
Ghi chu event 051: Delegate cung co the la lambda.
Ghi chu event 052: Lambda rat tien khi logic ngan gon.
Ghi chu event 053: Nhung dung lam lambda qua dai kho doc.
Ghi chu event 054: Khi logic phan ung lon hon vai dong, method dat ten ro rang thuong tot hon.
Ghi chu event 055: Vi du healthUI.UpdateBar ro nghia hon mot lambda dai.
Ghi chu event 056: Event dac biet hop voi gameplay event-driven.
Ghi chu event 057: Event-driven nghia la phan ung khi su kien xay ra.
Ghi chu event 058: Nguoc lai voi polling lien tuc trong Update.
Ghi chu event 059: Polling khong phai luc nao cung xau.
Ghi chu event 060: Nhung neu co the phan ung theo su kien, code thuong gon va ro hon.
Ghi chu event 061: Vi du vang chi doi khi nhat do, mua do, ban do.
Ghi chu event 062: Khong can moi frame kiem tra vang co doi khong.
Ghi chu event 063: Event OnGoldChanged hop ly hon.
Ghi chu event 064: Vi du enemy spawn cung la mot su kien ro rang.
Ghi chu event 065: Khi spawn xong, UI, minimap, quest tracker co the dong bo.
Ghi chu event 066: Moi he thong xu ly phan viec rieng.
Ghi chu event 067: Day la cach kien truc mo rong de dang hon.
Ghi chu event 068: Ban them listener moi ma khong can sua nhieu vao publisher.
Ghi chu event 069: Do la loi ich rat lon khi du an lon dan.
Ghi chu event 070: Delegate va event cung giup test de hon neu thiet ke gon.
Ghi chu event 071: Ban co the mo phong event va quan sat listener phan ung.
Ghi chu event 072: Trong bai nang cao hon, ban co the gap EventArgs.
Ghi chu event 073: Hoac custom delegate co y nghia ro hon Action.
Ghi chu event 074: Nhung Action la diem bat dau ngon lanh va gon gang.
Ghi chu event 075: Hay quen mau nhin sau.
Ghi chu event 076: Nguon du lieu thay doi.
Ghi chu event 077: Phat event.
Ghi chu event 078: Nguoi nghe cap nhat.
Ghi chu event 079: Mau nay lap di lap lai trong rat nhieu he thong.
Ghi chu event 080: UI la noi de thay nhat.
Ghi chu event 081: Thanh mau, vang, diem, quest, ammo deu hop.
Ghi chu event 082: Audio cung hop vi no thuong chi can phan ung.
Ghi chu event 083: Achievement cung hop vi no can lang nghe cac moc su kien.
Ghi chu event 084: Analytics cung hop vi no ghi nhan su kien.
Ghi chu event 085: Hieu ung FX cung hop vi no phat khi co trigger.
Ghi chu event 086: Event giup gameplay core khong phai biet tung he thong phu tro.
Ghi chu event 087: Day la cach giam phu thuoc truc tiep.
Ghi chu event 088: Tuy nhien, dung qua nhieu event khong kiem soat cung gay kho theo doi.
Ghi chu event 089: Vi vay can dat ten su kien ro rang.
Ghi chu event 090: Vi du OnHealthChanged ro hon OnChanged.
Ghi chu event 091: Vi du OnGoldChanged ro hon OnUpdate.
Ghi chu event 092: Ten ro rang la mot phan cua thiet ke tot.
Ghi chu event 093: Kieu tham so cung nen ro y nghia.
Ghi chu event 094: OnHealthChanged(int currentHealth) de hieu hon mot object mo ho.
Ghi chu event 095: Trong mot so truong hop, ta can gui nhieu thong tin hon.
Ghi chu event 096: Khi do co the gui hai tham so.
Ghi chu event 097: Hoac dong goi vao mot object event data.
Ghi chu event 098: O muc beginner, mot tham so da rat on.
Ghi chu event 099: Event cung phu hop voi button click va UI menu.
Ghi chu event 100: Khi nguoi choi bam nut, he thong khac co the nghe va phan ung.
Ghi chu event 101: Delegate va event cung giup truyen hanh vi vao ham.
Ghi chu event 102: Vi du mot method nhan Action de quyet dinh viec lam sau khi xong.
Ghi chu event 103: Day la callback pattern.
Ghi chu event 104: Callback rat pho bien khi tai du lieu, cho animation ket thuc, cho enemy bi ha.
Ghi chu event 105: Neu hieu delegate, ban da co nen cho callback.
Ghi chu event 106: Neu hieu event, ban da co nen cho observer.
Ghi chu event 107: Hai y tuong nay xuat hien rat nhieu trong du an thuc.
Ghi chu event 108: Hay tap nhin code theo cau hoi ai phat va ai nghe.
Ghi chu event 109: Cau hoi do giup ban thay luong thong tin trong he thong.
Ghi chu event 110: Luong thong tin ro rang se giup debug nhanh hon.
Ghi chu event 111: Trong log, ban cung co the in ra thoi diem event duoc goi.
Ghi chu event 112: Dieu do huu ich khi nghi ngo event bi goi nhieu lan.
Ghi chu event 113: Event bi goi nhieu lan thuong do dang ky lap.
Ghi chu event 114: Hoac doi tuong bi tao lai nhieu lan.
Ghi chu event 115: Day la loi rat pho bien trong Unity va game scripting.
Ghi chu event 116: Vi vay demo su kien nhieu listener va unsubscribe rat quan trong.
Ghi chu event 117: Ban nen tu viet them mot demo quest complete event.
Ghi chu event 118: Hoac item picked event.
Ghi chu event 119: Hoac ammo changed event.
Ghi chu event 120: Moi demo nho se lam khai niem de hon.
Ghi chu event 121: Khi ban thay su kien nao xay ra ro rang trong game, event thuong la ung vien hop ly.
Ghi chu event 122: Khi thong tin can tra ve la mot ket qua tinh toan, Func co the hop hon.
Ghi chu event 123: Bai nay chua di vao Func nhung nen biet ton tai.
Ghi chu event 124: Delegate la nen chung de hieu ca hai.
Ghi chu event 125: Hay tiep tuc luyen voi bai tap de bien ly thuyet thanh truc giac.
Ghi chu event 126: Muc tieu la khi nhin mot he thong, ban biet cho nao nen event, cho nao nen goi truc tiep.
Ghi chu event 127: Goi truc tiep khong xau khi quan he phu thuoc ro va can thiet.
Ghi chu event 128: Event hieu qua khi muon giam dinh cung va mo rong listener.
Ghi chu event 129: Lua chon phu thuoc vao bai toan, khong phai mot cong cu dung cho moi thu.
Ghi chu event 130: Het phan ghi chu mo rong cho bai 2.
Ghi chu event 131: Ban co the tiep tuc them vi du achievement, quest va analytics.
Ghi chu event 132: Cang gan boi canh game cua ban, kien thuc cang de nho.
Ghi chu event 133: Hay tap dat ten event theo dang OnSomethingHappened.
Ghi chu event 134: Day la convention de doc va doan nghia nhanh hon.
Ghi chu event 135: Convention khong bat buoc tuyet doi, nhung rat huu ich.
Ghi chu event 136: Ban cung nen can nhac kha nang listener nem exception.
Ghi chu event 137: Trong code hoc tap ta de don gian.
Ghi chu event 138: Trong code lon, exception trong listener co the can duoc xu ly can than.
Ghi chu event 139: Day la mot ly do event-driven coding can ky luat.
Ghi chu event 140: Nhung neu dung dung cho, no rat manh va dep.
Ghi chu event 141: Hay tiep tuc voi collections va singleton o cac bai sau.
Ghi chu event 142: Nhieu bai sau se ket hop rat tot voi event.
Ghi chu event 143: Vi du inventory collection phat OnItemAdded.
Ghi chu event 144: Vi du save manager singleton phat OnSaveCompleted.
Ghi chu event 145: Kien thuc dang ket noi voi nhau.
Ghi chu event 146: Day la dau hieu ban dang hoc dung huong.
Ghi chu event 147: Cang hoc, ban cang thay cac khai niem khong tach roi.
Ghi chu event 148: Generic, collections, event, singleton deu co diem giao trong code game that.
Ghi chu event 149: Va day la ly do chuong hoc duoc sap xep nhu hien tai.
Ghi chu event 150: Ket thuc file comment mo rong.
*/
