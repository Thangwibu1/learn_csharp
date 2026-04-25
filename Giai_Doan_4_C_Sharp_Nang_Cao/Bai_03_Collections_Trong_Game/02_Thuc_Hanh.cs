using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List dung lam inventory.
        List<string> inventory = new List<string>();
        inventory.Add("Potion");
        inventory.Add("Sword");
        inventory.Add("Key");

        Console.WriteLine("Inventory:");
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine(inventory[i]);
        }

        // Dictionary dung lam bang tra cuu cong thuc.
        Dictionary<string, string> craftingRecipes = new Dictionary<string, string>();
        craftingRecipes.Add("Wood+Stone", "Axe");
        craftingRecipes.Add("Herb+Bottle", "Potion");

        Console.WriteLine("Crafting result: " + craftingRecipes["Wood+Stone"]);

        // Queue dung cho object pooling.
        Queue<string> bulletPool = new Queue<string>();
        bulletPool.Enqueue("Bullet_1");
        bulletPool.Enqueue("Bullet_2");

        string bullet = bulletPool.Dequeue();
        Console.WriteLine("Lay tu pool: " + bullet);

        // Stack dung cho UI menu.
        Stack<string> menuStack = new Stack<string>();
        menuStack.Push("PauseMenu");
        menuStack.Push("SettingsMenu");

        Console.WriteLine("Menu hien tai: " + menuStack.Peek());
        Console.WriteLine("Dong menu: " + menuStack.Pop());
        Console.WriteLine("Menu con lai: " + menuStack.Peek());

        CollectionsGameDemos.RunAll();
    }
}

class ItemInfo
{
    public string Id;
    public string DisplayName;
    public int Price;

    public ItemInfo(string id, string displayName, int price)
    {
        Id = id;
        DisplayName = displayName;
        Price = price;
    }

    public override string ToString()
    {
        return Id + " | " + DisplayName + " | Gia: " + Price;
    }
}

static class CollectionsGameDemos
{
    public static void RunAll()
    {
        Console.WriteLine("=== Demo List nang cao ===");
        DemoInventoryList();

        Console.WriteLine("=== Demo Dictionary tra cuu nhanh ===");
        DemoItemDatabase();

        Console.WriteLine("=== Demo Queue cho wave spawn ===");
        DemoSpawnQueue();

        Console.WriteLine("=== Demo Stack cho lich su menu ===");
        DemoMenuStack();

        Console.WriteLine("=== Demo ket hop nhieu collection ===");
        DemoCombinedStructures();
    }

    private static void DemoInventoryList()
    {
        List<ItemInfo> inventory = new List<ItemInfo>();
        inventory.Add(new ItemInfo("potion_small", "Binh mau nho", 25));
        inventory.Add(new ItemInfo("sword_iron", "Kiem sat", 120));
        inventory.Add(new ItemInfo("shield_wood", "Khien go", 80));
        inventory.Add(new ItemInfo("key_forest", "Chia khoa rung", 0));

        Console.WriteLine("Inventory hien tai:");

        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine("Slot " + i + ": " + inventory[i]);
        }

        inventory.RemoveAt(0);
        Console.WriteLine("Sau khi dung mot potion:");

        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine("Slot " + i + ": " + inventory[i]);
        }
    }

    private static void DemoItemDatabase()
    {
        Dictionary<string, ItemInfo> itemDatabase = new Dictionary<string, ItemInfo>();
        itemDatabase["potion_small"] = new ItemInfo("potion_small", "Binh mau nho", 25);
        itemDatabase["potion_big"] = new ItemInfo("potion_big", "Binh mau lon", 60);
        itemDatabase["bow_basic"] = new ItemInfo("bow_basic", "Cung co ban", 150);
        itemDatabase["armor_leather"] = new ItemInfo("armor_leather", "Giap da", 110);

        string lookupId = "bow_basic";

        if (itemDatabase.ContainsKey(lookupId))
        {
            Console.WriteLine("Tim thay item theo ID: " + itemDatabase[lookupId]);
        }

        Console.WriteLine("Toan bo item trong database:");
        foreach (KeyValuePair<string, ItemInfo> pair in itemDatabase)
        {
            Console.WriteLine(pair.Key + " => " + pair.Value);
        }
    }

    private static void DemoSpawnQueue()
    {
        Queue<string> waveQueue = new Queue<string>();
        waveQueue.Enqueue("Goblin");
        waveQueue.Enqueue("Goblin Archer");
        waveQueue.Enqueue("Orc");
        waveQueue.Enqueue("Orc Captain");

        while (waveQueue.Count > 0)
        {
            string enemy = waveQueue.Dequeue();
            Console.WriteLine("Dang spawn: " + enemy);
        }
    }

    private static void DemoMenuStack()
    {
        Stack<string> menus = new Stack<string>();
        menus.Push("MainMenu");
        menus.Push("PauseMenu");
        menus.Push("SettingsMenu");
        menus.Push("AudioMenu");

        Console.WriteLine("Menu tren cung: " + menus.Peek());

        while (menus.Count > 0)
        {
            Console.WriteLine("Dong menu: " + menus.Pop());
        }
    }

    private static void DemoCombinedStructures()
    {
        List<string> activeQuests = new List<string>();
        activeQuests.Add("quest_find_key");
        activeQuests.Add("quest_open_gate");
        activeQuests.Add("quest_defeat_boss");

        Dictionary<string, int> cooldowns = new Dictionary<string, int>();
        cooldowns["dash"] = 5;
        cooldowns["fireball"] = 12;
        cooldowns["heal"] = 8;

        Queue<string> bulletPool = new Queue<string>();
        bulletPool.Enqueue("Bullet_1");
        bulletPool.Enqueue("Bullet_2");
        bulletPool.Enqueue("Bullet_3");

        Stack<string> screenHistory = new Stack<string>();
        screenHistory.Push("HUD");
        screenHistory.Push("Map");
        screenHistory.Push("QuestPanel");

        Console.WriteLine("Quest dang hoat dong:");
        foreach (string quest in activeQuests)
        {
            Console.WriteLine("- " + quest);
        }

        Console.WriteLine("Cooldown hien tai:");
        foreach (KeyValuePair<string, int> pair in cooldowns)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value + " giay");
        }

        Console.WriteLine("Lay tu bullet pool: " + bulletPool.Dequeue());
        Console.WriteLine("Man hinh gan nhat: " + screenHistory.Peek());
    }
}

/*
Ghi chu collections 001: Collection la noi luu va quan ly nhieu phan tu.
Ghi chu collections 002: Chon dung collection la mot quyet dinh thiet ke quan trong.
Ghi chu collections 003: Rat nhieu nguoi moi dung List cho moi bai toan.
Ghi chu collections 004: List rat huu ich nhung khong phai luc nao cung tot nhat.
Ghi chu collections 005: List hop khi du lieu co thu tu va hay duyet tuan tu.
Ghi chu collections 006: Inventory co slot thu tu la vi du tu nhien.
Ghi chu collections 007: Danh sach enemy trong scene cung thuong dung List.
Ghi chu collections 008: Danh sach waypoint cung hop voi List.
Ghi chu collections 009: Dictionary hop khi can tra cuu nhanh theo khoa.
Ghi chu collections 010: ID item la khoa rat pho bien trong game.
Ghi chu collections 011: Ability id, quest id, enemy id cung la khoa tot.
Ghi chu collections 012: Neu moi lan can item ma phai duyet ca List, code se kem tu nhien hon.
Ghi chu collections 013: Queue hop voi thu tu vao truoc ra truoc.
Ghi chu collections 014: Wave spawn la mot vi du rat ro.
Ghi chu collections 015: Danh sach yeu cau xu ly theo hang cho cung la vi du hay.
Ghi chu collections 016: Stack hop voi vao sau ra truoc.
Ghi chu collections 017: UI menu chong lop la vi du cuc ky de hieu.
Ghi chu collections 018: Man hinh mo sau cung thuong dong truoc.
Ghi chu collections 019: Day la ban chat LIFO.
Ghi chu collections 020: Khi chon collection, hay hoi thao tac chinh la gi.
Ghi chu collections 021: Them cuoi danh sach.
Ghi chu collections 022: Tra cuu theo khoa.
Ghi chu collections 023: Lay ra theo thu tu FIFO.
Ghi chu collections 024: Lay ra theo thu tu LIFO.
Ghi chu collections 025: Cau tra loi se dan ban toi collection hop ly hon.
Ghi chu collections 026: Code ro y do hon khi collection phan anh dung bai toan.
Ghi chu collections 027: Nhin Dictionary, nguoi doc hieu ngay co mapping key-value.
Ghi chu collections 028: Nhin Queue, nguoi doc hieu ngay co thu tu xu ly.
Ghi chu collections 029: Nhin Stack, nguoi doc hieu ngay co lich su lop tren cung.
Ghi chu collections 030: Collection khong chi la hieu nang ma con la cach dien dat y do.
Ghi chu collections 031: Tuy nhien, hieu nang van la ly do quan trong.
Ghi chu collections 032: Tra cuu sai collection co the lam code cham hon khong can thiet.
Ghi chu collections 033: Trong game nho co the chua thay ro.
Ghi chu collections 034: Trong game lon hon, no tich lai thanh van de dang ke.
Ghi chu collections 035: Inventory thuong can vua hien thi theo thu tu vua tra cuu theo id.
Ghi chu collections 036: Luc do co the can ket hop List va Dictionary.
Ghi chu collections 037: Day la ly do demo combined structures duoc them.
Ghi chu collections 038: Nhieu bai toan khong chi dung mot collection.
Ghi chu collections 039: Co the mot collection phuc vu UI.
Ghi chu collections 040: Mot collection khac phuc vu lookup nhanh.
Ghi chu collections 041: Day la cach can bang nhu cau khac nhau.
Ghi chu collections 042: Chon collection tot giup code manager nho hon.
Ghi chu collections 043: Ban giam duoc vong lap tim thu cong khap noi.
Ghi chu collections 044: Ban cung giam bug lien quan den du lieu lech nhau.
Ghi chu collections 045: Dac biet neu dat ten bien theo y nghia.
Ghi chu collections 046: itemDatabase ro hon itemList trong bai toan lookup.
Ghi chu collections 047: activeQuests ro hon data1.
Ghi chu collections 048: screenHistory ro hon screens.
Ghi chu collections 049: Ten bien ro cung quan trong nhu chon dung collection.
Ghi chu collections 050: Queue thuong di kem Enqueue va Dequeue.
Ghi chu collections 051: Stack thuong di kem Push, Pop, Peek.
Ghi chu collections 052: List thuong di kem Add, RemoveAt, Count, index.
Ghi chu collections 053: Dictionary thuong di kem ContainsKey, TryGetValue, indexer.
Ghi chu collections 054: Hieu ten method giup ban doan duoc hanh vi cua collection.
Ghi chu collections 055: Day la ky nang doc API co ban nhung rat huu ich.
Ghi chu collections 056: Trong game, object pooling cung lien quan den Queue.
Ghi chu collections 057: Ban dua object chua dung vao hang cho.
Ghi chu collections 058: Khi can, lay mot object ra de tai su dung.
Ghi chu collections 059: Bai nay mo ta o muc co ban de ban thay mo hinh.
Ghi chu collections 060: Voi Stack, undo system cung la vi du tot.
Ghi chu collections 061: Hanh dong moi duoc Push vao stack.
Ghi chu collections 062: Khi undo, Pop hanh dong gan nhat.
Ghi chu collections 063: Day la y tuong rat tu nhien.
Ghi chu collections 064: Voi Dictionary, save data theo key cung rat hop.
Ghi chu collections 065: Vi du key la ten setting, value la muc cau hinh.
Ghi chu collections 066: Vi du key la ten stage, value la so sao dat duoc.
Ghi chu collections 067: List va Dictionary la cap doi rat pho bien.
Ghi chu collections 068: Queue va Stack it duoc nguoi moi dung hon nhung cuc ky huu ich.
Ghi chu collections 069: Ban nen chu dong tim bai toan de ap dung chung.
Ghi chu collections 070: Neu khong dung, kien thuc se rat nhanh quen.
Ghi chu collections 071: Dung voi boi canh game se nho lau hon hoc ly thuyet tron.
Ghi chu collections 072: Hay tu hoi inventory cua ban can truy cap theo slot hay theo id.
Ghi chu collections 073: Hay tu hoi wave spawn cua ban co can dung Queue khong.
Ghi chu collections 074: Hay tu hoi UI menu cua ban co can Stack khong.
Ghi chu collections 075: Cau hoi dung quan trong hon viec hoc thuoc dinh nghia.
Ghi chu collections 076: List khong co nghia la xau neu dung lookup it.
Ghi chu collections 077: Dictionary khong co nghia la dung moi luc neu khong co khoa ro rang.
Ghi chu collections 078: Queue khong hop neu ban can lay ngau nhien phan tu giua.
Ghi chu collections 079: Stack khong hop neu ban can duyet theo thu tu ban dau.
Ghi chu collections 080: Moi collection co trade-off rieng.
Ghi chu collections 081: Hieu trade-off la muc tieu cua bai nay.
Ghi chu collections 082: Thu xoa giua List va quan sat index dich chuyen.
Ghi chu collections 083: Thu tra cuu item co ton tai trong Dictionary.
Ghi chu collections 084: Thu goi Peek truoc khi Pop tren Stack.
Ghi chu collections 085: Thu lap Dequeue den khi Queue rong.
Ghi chu collections 086: Moi thao tac nho se giup ban quen API nhanh hon.
Ghi chu collections 087: Trong C#, collections generic giu type safety nhu bai generic da hoc.
Ghi chu collections 088: List<string> chi chua string.
Ghi chu collections 089: Queue<int> chi chua int.
Ghi chu collections 090: Day tiep tuc la loi ich cua generic trong thu vien nen.
Ghi chu collections 091: Moi lan ban viet List<T>, ban dang dung generic.
Ghi chu collections 092: Moi lan ban viet Dictionary<TKey, TValue>, ban dang dung generic.
Ghi chu collections 093: Kien thuc bai generic va bai collections dang noi voi nhau.
Ghi chu collections 094: Cang hoc, ban cang thay cac khai niem ket noi.
Ghi chu collections 095: Dung collection dung con giup code review de hon.
Ghi chu collections 096: Reviewer nhin cau truc du lieu se hieu nhanh y do thiet ke.
Ghi chu collections 097: Neu thay List duoc dung nhu map, do la dau hieu can xem lai.
Ghi chu collections 098: Neu thay Stack duoc dung cho thu tu FIFO, do la dau hieu sai mo hinh.
Ghi chu collections 099: Lua chon cau truc du lieu la mot phan cua truyen dat y do bang code.
Ghi chu collections 100: Hay nhin no nhu ngon ngu cua nguoi lap trinh.
Ghi chu collections 101: File nay duoc mo rong de ban co nhieu vi du gan game hon.
Ghi chu collections 102: Ban co the them crafting system dua tren Dictionary.
Ghi chu collections 103: Ban co the them quest log dua tren List.
Ghi chu collections 104: Ban co the them bullet pool dua tren Queue.
Ghi chu collections 105: Ban co the them popup history dua tren Stack.
Ghi chu collections 106: Cang gan du an rieng, cang de tham.
Ghi chu collections 107: Hay tap dat ten bien phan anh collection.
Ghi chu collections 108: inventoryItems, itemDatabase, spawnQueue, menuStack la cac ten de hieu.
Ghi chu collections 109: Dat ten ro giup ban nhin code va doan logic nhanh hon.
Ghi chu collections 110: Bai tap o file markdown se day ban luyen them phan nay.
Ghi chu collections 111: Dung ngai viet nhieu demo nho trong qua trinh hoc.
Ghi chu collections 112: Collection la cong cu can lap di lap lai de thanh thuoc.
Ghi chu collections 113: Muc tieu sau bai nay la ban khong con vo thuc dung List cho tat ca.
Ghi chu collections 114: Thay vao do, ban se hoi bai toan can gi truoc.
Ghi chu collections 115: Day la buoc chuyen tu hoc syntax sang hoc thiet ke du lieu.
Ghi chu collections 116: Do la buoc tien rat quan trong.
Ghi chu collections 117: Khi code game lon hon, collection dung se giup ban dung manager dung kich thuoc hon.
Ghi chu collections 118: Collection sai thuong buoc manager phai bo sung logic tim, doi, xoa phuc tap hon.
Ghi chu collections 119: Thiet ke tu dau tot se tien loi ve sau.
Ghi chu collections 120: Het phan ghi chu mo rong cho bai collections.
Ghi chu collections 121: Neu muon, hay bo sung HashSet vao bai tu hoc nang cao.
Ghi chu collections 122: HashSet rat hop cho kiem tra ton tai khong trung lap.
Ghi chu collections 123: Nhung de giu bai nay dung pham vi, ta tam tap trung vao bon collection chinh.
Ghi chu collections 124: Ban co the ghi nho bo bon nay bang bai toan tieu bieu.
Ghi chu collections 125: List = danh sach theo thu tu.
Ghi chu collections 126: Dictionary = bang tra cuu theo khoa.
Ghi chu collections 127: Queue = hang cho FIFO.
Ghi chu collections 128: Stack = ngan xep LIFO.
Ghi chu collections 129: Nho duoc bo tu khoa nay se giup quyet dinh nhanh hon.
Ghi chu collections 130: Ket thuc file comment mo rong.
*/
