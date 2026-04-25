using System;
using System.Collections.Generic;
using System.Linq;

class GameManager
{
    // Bien static giu instance duy nhat.
    private static GameManager instance;

    // Property cho phep doc instance tu ben ngoai.
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }

            return instance;
        }
    }

    // Constructor private de khong cho tao tuy y tu ben ngoai.
    private GameManager()
    {
    }

    // Method don gian.
    public void StartGame()
    {
        Console.WriteLine("Game Started");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Goi singleton.
        GameManager.Instance.StartGame();

        // Tao danh sach diem.
        List<int> scores = new List<int> { 20, 100, 150, 40, 200 };

        // Dung LINQ loc diem cao.
        List<int> highScores = scores.Where(score => score >= 100).ToList();

        // In ket qua sau khi loc.
        foreach (int score in highScores)
        {
            Console.WriteLine("High score: " + score);
        }

        SingletonAndLinqDemos.RunAll();
    }
}

class AudioManager
{
    private static AudioManager instance;

    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AudioManager();
            }

            return instance;
        }
    }

    private AudioManager()
    {
    }

    public void PlayMusic(string trackName)
    {
        Console.WriteLine("Phat nhac: " + trackName);
    }
}

class PlayerScore
{
    public string Name { get; set; }
    public int Score { get; set; }
    public string Rank { get; set; }

    public override string ToString()
    {
        return Name + " | Score=" + Score + " | Rank=" + Rank;
    }
}

static class SingletonAndLinqDemos
{
    public static void RunAll()
    {
        Console.WriteLine("=== Demo singleton voi AudioManager ===");
        DemoAudioManager();

        Console.WriteLine("=== Demo LINQ Where va OrderBy ===");
        DemoScoreQueries();

        Console.WriteLine("=== Demo LINQ Select ===");
        DemoProjection();

        Console.WriteLine("=== Demo LINQ FirstOrDefault ===");
        DemoFindSingleEntry();

        Console.WriteLine("=== Demo LINQ ket hop trong boi canh game ===");
        DemoGameStyleQueries();
    }

    private static void DemoAudioManager()
    {
        AudioManager.Instance.PlayMusic("theme_main");
        AudioManager.Instance.PlayMusic("battle_phase_1");

        bool sameInstance = object.ReferenceEquals(AudioManager.Instance, AudioManager.Instance);
        Console.WriteLine("AudioManager co phai cung mot instance khong? " + sameInstance);
    }

    private static void DemoScoreQueries()
    {
        List<PlayerScore> scores = CreateScoreList();

        List<PlayerScore> topPlayers = scores
            .Where(player => player.Score >= 100)
            .OrderByDescending(player => player.Score)
            .ToList();

        foreach (PlayerScore player in topPlayers)
        {
            Console.WriteLine(player);
        }
    }

    private static void DemoProjection()
    {
        List<PlayerScore> scores = CreateScoreList();

        List<string> names = scores
            .Select(player => player.Name)
            .ToList();

        foreach (string name in names)
        {
            Console.WriteLine("Ten nguoi choi: " + name);
        }
    }

    private static void DemoFindSingleEntry()
    {
        List<PlayerScore> scores = CreateScoreList();

        PlayerScore silverPlayer = scores.FirstOrDefault(player => player.Rank == "Silver");

        if (silverPlayer != null)
        {
            Console.WriteLine("Tim thay nguoi choi bac Silver: " + silverPlayer);
        }
    }

    private static void DemoGameStyleQueries()
    {
        List<string> enemyIds = new List<string>
        {
            "slime_small",
            "orc_brute",
            "slime_king",
            "archer_bandit",
            "orc_captain"
        };

        List<string> orcEnemies = enemyIds
            .Where(enemyId => enemyId.Contains("orc"))
            .OrderBy(enemyId => enemyId)
            .ToList();

        Console.WriteLine("Enemy ho orc:");
        foreach (string enemyId in orcEnemies)
        {
            Console.WriteLine(enemyId);
        }

        int slimeCount = enemyIds.Count(enemyId => enemyId.Contains("slime"));
        Console.WriteLine("So enemy thuoc nhom slime: " + slimeCount);
    }

    private static List<PlayerScore> CreateScoreList()
    {
        return new List<PlayerScore>
        {
            new PlayerScore { Name = "Lan", Score = 90, Rank = "Bronze" },
            new PlayerScore { Name = "Minh", Score = 150, Rank = "Gold" },
            new PlayerScore { Name = "Huy", Score = 120, Rank = "Silver" },
            new PlayerScore { Name = "Nhi", Score = 210, Rank = "Platinum" },
            new PlayerScore { Name = "Bao", Score = 60, Rank = "Bronze" }
        };
    }
}

/*
Ghi chu singleton linq 001: Singleton la mau thiet ke dam bao mot instance duy nhat.
Ghi chu singleton linq 002: Ly do nguoi moi thich singleton la vi no tien truy cap.
Ghi chu singleton linq 003: GameManager.Instance nghe rat hap dan khi moi hoc.
Ghi chu singleton linq 004: Nhung su tien nay di kem rui ro coupling.
Ghi chu singleton linq 005: Khi class nao cung goi vao singleton, phu thuoc an tang len.
Ghi chu singleton linq 006: Phu thuoc an gay kho test va kho thay the implementation.
Ghi chu singleton linq 007: Vi vay singleton chi nen dung khi that su can mot instance.
Ghi chu singleton linq 008: AudioManager la vi du hop ly hon GameManager om moi thu.
Ghi chu singleton linq 009: SaveManager cung la vi du hay.
Ghi chu singleton linq 010: SceneTransitionManager cung thuong duoc dung theo kieu nay.
Ghi chu singleton linq 011: Nhung inventory cua tung nguoi choi thuong khong nen la singleton toan cuc.
Ghi chu singleton linq 012: Quest cua tung file save cung vay.
Ghi chu singleton linq 013: Hay phan biet he thong duy nhat va du lieu theo instance.
Ghi chu singleton linq 014: Constructor private la phan can ban cua singleton co dien.
Ghi chu singleton linq 015: Property Instance la diem truy cap toan cuc.
Ghi chu singleton linq 016: Tuy nhien, co diem truy cap toan cuc khong dong nghia voi dung o moi noi.
Ghi chu singleton linq 017: Can ky luat khi su dung.
Ghi chu singleton linq 018: Neu thay GameManager tro thanh thung rac tong, do la dau hieu xau.
Ghi chu singleton linq 019: Luong trach nhiem nen hep va ro.
Ghi chu singleton linq 020: Bai nay nhac lai dieu do qua comment va bai tap.
Ghi chu singleton linq 021: LINQ la mot cong cu truy van du lieu rat manh trong C#.
Ghi chu singleton linq 022: Thay vi viet nhieu vong lap tay, ban co the dien dat y do gon hon.
Ghi chu singleton linq 023: Where dung de loc.
Ghi chu singleton linq 024: Select dung de bien doi.
Ghi chu singleton linq 025: OrderBy va OrderByDescending dung de sap xep.
Ghi chu singleton linq 026: FirstOrDefault dung de tim phan tu dau tien phu hop hoac null.
Ghi chu singleton linq 027: Count cung co the nhan dieu kien de dem co loc.
Ghi chu singleton linq 028: Day la cac thao tac rat thuong dung.
Ghi chu singleton linq 029: LINQ lam code ngan hon khi y do truy van ro rang.
Ghi chu singleton linq 030: Tuy nhien, dung qua nhieu LINQ xep tang phuc tap cung co the kho doc.
Ghi chu singleton linq 031: Hay uu tien ro rang.
Ghi chu singleton linq 032: Neu mot vong lap thuong de doc hon, dung vong lap khong sao.
Ghi chu singleton linq 033: LINQ khong phai muc tieu, no la cong cu.
Ghi chu singleton linq 034: Muc tieu van la code de hieu.
Ghi chu singleton linq 035: Trong game, LINQ hay dung cho loc danh sach item, quest, enemy, score.
Ghi chu singleton linq 036: Vi du loc nhung enemy con song.
Ghi chu singleton linq 037: Vi du sap xep bang xep hang.
Ghi chu singleton linq 038: Vi du tim item dau tien theo dieu kien hiem.
Ghi chu singleton linq 039: Vi du chuyen danh sach Player thanh danh sach ten de hien thi UI.
Ghi chu singleton linq 040: Select rat hop voi bai toan nay.
Ghi chu singleton linq 041: Where rat hop voi bai toan loc.
Ghi chu singleton linq 042: OrderBy rat hop voi bang xep hang va inventory sort.
Ghi chu singleton linq 043: FirstOrDefault rat hop khi tim mot doi tuong duy nhat hoac dau tien.
Ghi chu singleton linq 044: Nhung can kiem tra null sau do.
Ghi chu singleton linq 045: Day la thoi quen quan trong.
Ghi chu singleton linq 046: ToList thuong duoc goi cuoi chuoi de lay ket qua cu the.
Ghi chu singleton linq 047: Neu chua hoc sau ve deferred execution, cu co the hieu don gian la chuyen thanh List de de dung.
Ghi chu singleton linq 048: Bai nay giu LINQ o muc thuc dung co ban.
Ghi chu singleton linq 049: Khong can nhoi qua nhieu toan tu nang cao luc dau.
Ghi chu singleton linq 050: Dieu quan trong la biet no giai bai toan gi.
Ghi chu singleton linq 051: Moi khi dinh viet vong lap loc danh sach, hay tu hoi LINQ co giup code ro hon khong.
Ghi chu singleton linq 052: Neu co, hay dung.
Ghi chu singleton linq 053: Neu khong, vong lap thuong van on.
Ghi chu singleton linq 054: Singleton va LINQ duoc hoc cung bai vi mot ben noi cach truy cap service, mot ben noi cach truy van du lieu.
Ghi chu singleton linq 055: Trong game that, hai y tuong nay thuong gap nhau.
Ghi chu singleton linq 056: Vi du SaveManager singleton quan ly list save slot va dung LINQ de tim save moi nhat.
Ghi chu singleton linq 057: Vi du AudioManager singleton loc playlist theo khu vuc.
Ghi chu singleton linq 058: Vi du item database duoc truy van bang LINQ cho muc dich debug hoac UI.
Ghi chu singleton linq 059: Kien thuc khong tach roi ma lien ket voi nhau.
Ghi chu singleton linq 060: Bai tap hay la tu tao mot service va mot danh sach de truy van.
Ghi chu singleton linq 061: Dung singleton chi vi tien se dan den qua nhieu code goi truc tiep.
Ghi chu singleton linq 062: Dung LINQ chi vi trong hien dai cung co the tao code kho doc.
Ghi chu singleton linq 063: Ca hai deu can tiet che va dung dung cho.
Ghi chu singleton linq 064: Day la diem chung quan trong.
Ghi chu singleton linq 065: AudioManager singleton trong file nay duoc chon co y de trac nhiem hep.
Ghi chu singleton linq 066: No chi phat nhac va am thanh o muc demo.
Ghi chu singleton linq 067: No khong quan ly score, inventory hay quest.
Ghi chu singleton linq 068: Day la huong thiet ke sach hon.
Ghi chu singleton linq 069: Trong LINQ demo, CreateScoreList tach rieng de code de doc hon.
Ghi chu singleton linq 070: Tach nho giup tung demo tap trung vao y nghia truy van.
Ghi chu singleton linq 071: Bai nay khuyen khich ban tu tao them query khac.
Ghi chu singleton linq 072: Vi du Average diem.
Ghi chu singleton linq 073: Vi du Any de kiem tra co player nao dat Gold khong.
Ghi chu singleton linq 074: Vi du All de kiem tra tat ca quest deu complete chua.
Ghi chu singleton linq 075: Nhung de tranh qua tai, file chi tap trung vao nhom can ban nhat.
Ghi chu singleton linq 076: Hay doc query nhu cau noi.
Ghi chu singleton linq 077: scores Where score >= 100 OrderByDescending Score.
Ghi chu singleton linq 078: Neu doc thanh loi duoc, nghia la query da kha ro rang.
Ghi chu singleton linq 079: Neu query qua dai den muc doc thanh loi thay roi, can can nhac tach ra.
Ghi chu singleton linq 080: Day la mot meo thuc dung.
Ghi chu singleton linq 081: LINQ cung rat hop cho debug nhanh trong tool noi bo.
Ghi chu singleton linq 082: Vi du loc item loi, enemy co hp am, quest chua dat ten.
Ghi chu singleton linq 083: Day la gia tri thuc te rat cao.
Ghi chu singleton linq 084: Tuy nhien, khong nen lam moi logic gameplay phuc tap thanh chuoi LINQ kho theo doi.
Ghi chu singleton linq 085: Don gian, ro rang, dung cho la nguyen tac tot.
Ghi chu singleton linq 086: Khi doc singleton, hay hoi class nay co that su can duy nhat khong.
Ghi chu singleton linq 087: Khi doc LINQ, hay hoi query nay co de hieu hon vong lap khong.
Ghi chu singleton linq 088: Hai cau hoi do la bo loc thuc dung rat tot.
Ghi chu singleton linq 089: Ban khong can than thanh singleton.
Ghi chu singleton linq 090: Ban cung khong can than thanh LINQ.
Ghi chu singleton linq 091: Chi can dung no khi giai bai toan tot hon.
Ghi chu singleton linq 092: Day la tu duy ky su phan mem thuc dung.
Ghi chu singleton linq 093: Trong file bai tap, se co nhieu cau hoi ve ranh gioi nay.
Ghi chu singleton linq 094: Muc tieu la giup ban khong chi hoc syntax ma con hoc phan doan thiet ke.
Ghi chu singleton linq 095: Neu lam duoc dieu do, bai hoc nay se rat co gia tri.
Ghi chu singleton linq 096: Tu duy quan trong hon viec nho ten method.
Ghi chu singleton linq 097: Vi ten method co the tra cuu, con phan doan can ren luyen.
Ghi chu singleton linq 098: Hay tu dat cau hoi sau moi vi du.
Ghi chu singleton linq 099: Tai sao day la singleton ma khong phai class thuong.
Ghi chu singleton linq 100: Tai sao day la LINQ ma khong phai vong lap tay.
Ghi chu singleton linq 101: Moi cau tra loi se giup ban tham hon mot chut.
Ghi chu singleton linq 102: Kien thuc phan mem duoc xay bang nhieu chut nhu vay.
Ghi chu singleton linq 103: Khong can voi vang hoc qua nhieu toan tu LINQ nang cao luc nay.
Ghi chu singleton linq 104: Nam chac Where, Select, OrderBy, FirstOrDefault, Count la da rat tot.
Ghi chu singleton linq 105: Tu day ban co the mo rong dan theo nhu cau du an.
Ghi chu singleton linq 106: Singleton cung vay, nam chac ly do dung va ly do tranh la rat quan trong.
Ghi chu singleton linq 107: Nhieu nguoi hoc singleton chi nho cu phap ma quen mat trai.
Ghi chu singleton linq 108: Bai nay co gang can bang ca hai mat.
Ghi chu singleton linq 109: Ve sau, ban co the hoc dependency injection nhu huong thay the sach hon trong nhieu boi canh.
Ghi chu singleton linq 110: Nhung singleton van la mot khai niem can hieu vi no xuat hien rat nhieu trong code cu va code hoc tap.
Ghi chu singleton linq 111: Hieu no de dung va de nhan ra khi nao dang lam dung qua tay.
Ghi chu singleton linq 112: Do la muc tieu thuc dung nhat.
Ghi chu singleton linq 113: File nay duoc keo dai voi comment de phuc vu tu hoc.
Ghi chu singleton linq 114: Ban co the rut gon lai sau khi da hieu.
Ghi chu singleton linq 115: Va khi tu viet lai, hay uu tien su ro rang.
Ghi chu singleton linq 116: Bai hoc thanh cong khi ban co the tu tao vi du moi.
Ghi chu singleton linq 117: Vi du leaderboard, shop inventory, save slot browser, enemy filter.
Ghi chu singleton linq 118: Tat ca deu rat hop de luyen LINQ.
Ghi chu singleton linq 119: Con audio, save, scene transition rat hop de luyen singleton co kiem soat.
Ghi chu singleton linq 120: Ket thuc phan ghi chu mo rong cho bai 4.
Ghi chu singleton linq 121: Hay tiep tuc voi bai tap de bien khai niem thanh ky nang.
Ghi chu singleton linq 122: Nho rang dung cong cu phu hop quan trong hon dung cong cu hot.
Ghi chu singleton linq 123: Day la thong diep lon cua bai.
Ghi chu singleton linq 124: Het.
*/
