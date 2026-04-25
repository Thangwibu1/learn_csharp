using System;
using System.Collections.Generic;

namespace LearnCSharp.GiaiDoan2.Bai02ThamTriVaThamChieu;

public struct CurrencyPack
{
    public int Gold;
    public int Gem;

    public CurrencyPack(int gold, int gem)
    {
        Gold = gold;
        Gem = gem;
    }

    public override string ToString()
    {
        return $"Gold: {Gold}, Gem: {Gem}";
    }
}

public sealed class QuestReward
{
    public string Title { get; set; }
    public int Exp { get; set; }

    public QuestReward(string title, int exp)
    {
        Title = title;
        Exp = exp;
    }

    public override string ToString()
    {
        return $"{Title} - {Exp} EXP";
    }
}

public sealed class MonsterProfile
{
    public string Name { get; set; }
    public int Health { get; set; }
    public QuestReward Reward { get; set; }

    public MonsterProfile(string name, int health, QuestReward reward)
    {
        Name = name;
        Health = health;
        Reward = reward;
    }

    public override string ToString()
    {
        return $"{Name} | Mau: {Health} | Thuong: {Reward}";
    }
}

public static class ValueAndReferencePractice
{
    private static readonly string[] TheoryNotes =
    {
        "Tham tri la cach nhin vao du lieu duoc copy truc tiep.",
        "Tham chieu la cach nhin vao dia chi tro toi object.",
        "Value type thuong lam viec giong nhu ban chot so lieu tai thoi diem copy.",
        "Reference type phu hop khi nhieu bien can cung thao tac tren mot doi tuong.",
        "Struct co the nam trong object khac, nhung khi copy struct ban van copy du lieu.",
        "Class cho phep mot object duoc chia se qua nhieu bien va nhieu ham.",
        "Khi truyen value type vao ham theo mac dinh, ham nhan mot ban sao.",
        "Khi truyen reference type vao ham theo mac dinh, ham nhan ban sao cua tham chieu.",
        "Ban sao cua tham chieu van tro toi cung mot object.",
        "Neu trong ham ban doi thuoc tinh cua object, ben ngoai se thay doi.",
        "Neu trong ham ban gan tham chieu sang object moi, bien ngoai ham khong tu dong doi.",
        "Muoi loi noi suot bai nay la: copy gia tri khac voi copy kha nang truy cap object."
    };

    private static readonly string[] ReviewQuestions =
    {
        "Tai sao int a = b khong lam b thay doi khi a doi?",
        "Tai sao MonsterProfile b = a lai lam ca hai bien thay doi cung nhau?",
        "Tham so method nhan duoc gi khi ta goi truyen mot class?",
        "Khi nao can tao object moi de tranh sua lan nhau?",
        "Vi sao mot thuoc tinh kieu struct trong class can duoc xem xet ky khi cap nhat?",
        "Ban co the phan biet mutate object voi reassign bien khong?",
        "Neu mot bug xuat hien do chia se du lieu, dau hieu nhan biet som la gi?",
        "Khi doc code, ban nhin dau de doan mot bien la value type hay reference type?",
        "Tai sao clone nong voi clone sau cho ket qua khac nhau?",
        "Ban co the tu viet lai quy tac cho nguoi moi hoc bang 2 cau ngan gon khong?"
    };

    private static readonly string[] Troubleshooting =
    {
        "Neu object doi ngoai y muon, kiem tra xem co bao nhieu bien dang tro toi no.",
        "Neu ham sua xong ma ben ngoai khong doi, xem lai ban da sua object hay chi doi bien cuc bo.",
        "Neu du lieu tam thoi vo tinh anh huong du lieu that, can tach ban sao doc lap.",
        "Neu thay null reference, xac minh object da duoc tao truoc khi truyen hay chua.",
        "Neu struct bi sua ma khong dung cho, kiem tra ban dang thao tac tren ban sao hay ban goc.",
        "Neu logging kho doc, them ToString ro rang cho class va struct.",
        "Neu khong chac chan hanh vi, in gia tri truoc va sau moi buoc de tu xac nhan.",
        "Neu nhieu ham cung sua mot object, hay dat ten ham the hien ro y dinh cap nhat.",
        "Neu can code an toan hon, tach du lieu bat bien va du lieu thay doi.",
        "Neu bai hoc van mo ho, viet lai bang tay mot bang so sanh tham tri va tham chieu."
    };

    public static void Run()
    {
        PrintHeader("THUC HANH THAM TRI VA THAM CHIEU");
        PrintBlock("Ghi nho ly thuyet", TheoryNotes);

        DemoValueTypeAssignment();
        DemoReferenceTypeAssignment();
        DemoPassValueTypeToMethod();
        DemoPassReferenceTypeToMethod();
        DemoReassignInsideMethod();
        DemoNestedReference();
        DemoListOfReferences();
        DemoIndependentCopy();

        PrintBlock("Cau hoi tu on", ReviewQuestions);
        PrintBlock("Xu ly su co", Troubleshooting);
    }

    private static void DemoValueTypeAssignment()
    {
        PrintHeader("1. Gan value type");

        CurrencyPack original = new CurrencyPack(100, 3);
        CurrencyPack copied = original;

        Console.WriteLine($"Truoc khi doi -> original: {original}");
        Console.WriteLine($"Truoc khi doi -> copied: {copied}");

        copied.Gold = 40;
        copied.Gem = 1;

        Console.WriteLine($"Sau khi doi copied -> original: {original}");
        Console.WriteLine($"Sau khi doi copied -> copied: {copied}");
        Console.WriteLine();
    }

    private static void DemoReferenceTypeAssignment()
    {
        PrintHeader("2. Gan reference type");

        MonsterProfile monsterA = new MonsterProfile("Slime", 60, new QuestReward("Thuong co ban", 10));
        MonsterProfile monsterB = monsterA;

        Console.WriteLine($"Truoc khi doi -> monsterA: {monsterA}");
        Console.WriteLine($"Truoc khi doi -> monsterB: {monsterB}");

        monsterB.Health = 10;
        monsterB.Reward.Exp = 99;

        Console.WriteLine($"Sau khi doi -> monsterA: {monsterA}");
        Console.WriteLine($"Sau khi doi -> monsterB: {monsterB}");
        Console.WriteLine();
    }

    private static void DemoPassValueTypeToMethod()
    {
        PrintHeader("3. Truyen value type vao ham");

        CurrencyPack wallet = new CurrencyPack(200, 4);

        Console.WriteLine($"Truoc khi goi ham: {wallet}");
        DiscountWallet(wallet);
        Console.WriteLine($"Sau khi goi ham: {wallet}");
        Console.WriteLine("Ket luan: ham sua tren ban sao, bien ben ngoai giu nguyen.");
        Console.WriteLine();
    }

    private static void DiscountWallet(CurrencyPack wallet)
    {
        wallet.Gold -= 50;
        wallet.Gem -= 1;
        Console.WriteLine($"Ben trong ham sau khi giam: {wallet}");
    }

    private static void DemoPassReferenceTypeToMethod()
    {
        PrintHeader("4. Truyen reference type vao ham");

        MonsterProfile boss = new MonsterProfile("Ogre", 300, new QuestReward("Ruong bac", 70));

        Console.WriteLine($"Truoc khi goi ham: {boss}");
        DamageMonster(boss);
        Console.WriteLine($"Sau khi goi ham: {boss}");
        Console.WriteLine("Ket luan: ham nhan ban sao tham chieu nhung van tro toi cung object.");
        Console.WriteLine();
    }

    private static void DamageMonster(MonsterProfile target)
    {
        target.Health -= 80;
        target.Reward.Title = "Ruong bac nang cap";
        Console.WriteLine($"Ben trong ham sau khi tan cong: {target}");
    }

    private static void DemoReassignInsideMethod()
    {
        PrintHeader("5. Doi bien tham chieu trong ham");

        MonsterProfile miniBoss = new MonsterProfile("Goblin King", 150, new QuestReward("Vuong mien go", 30));

        Console.WriteLine($"Truoc khi goi ham: {miniBoss}");
        ReplaceReferenceLocally(miniBoss);
        Console.WriteLine($"Sau khi goi ham: {miniBoss}");
        Console.WriteLine("Ket luan: doi bien cuc bo trong ham khong doi bien goc ben ngoai.");
        Console.WriteLine();
    }

    private static void ReplaceReferenceLocally(MonsterProfile target)
    {
        target = new MonsterProfile("Shadow Copy", 1, new QuestReward("Ao anh", 0));
        Console.WriteLine($"Ben trong ham sau khi doi tham chieu: {target}");
    }

    private static void DemoNestedReference()
    {
        PrintHeader("6. Object long object");

        MonsterProfile enemy = new MonsterProfile("Skeleton", 90, new QuestReward("Xuong kho", 15));
        MonsterProfile alias = enemy;

        alias.Reward = new QuestReward("Kiem set", 45);

        Console.WriteLine($"enemy sau khi alias doi Reward: {enemy}");
        Console.WriteLine($"alias sau khi doi Reward: {alias}");

        alias.Reward.Exp = 80;

        Console.WriteLine($"enemy sau khi doi tiep Exp: {enemy}");
        Console.WriteLine($"alias sau khi doi tiep Exp: {alias}");
        Console.WriteLine();
    }

    private static void DemoListOfReferences()
    {
        PrintHeader("7. Danh sach chua reference");

        MonsterProfile shared = new MonsterProfile("Wolf", 70, new QuestReward("Rang nanh", 12));
        List<MonsterProfile> monsters = new List<MonsterProfile> { shared, shared };

        monsters[1].Health = 25;

        for (int i = 0; i < monsters.Count; i++)
        {
            Console.WriteLine($"Vi tri {i}: {monsters[i]}");
        }

        Console.WriteLine("Ket luan: 2 o trong danh sach co the van tro toi mot object duy nhat.");
        Console.WriteLine();
    }

    private static void DemoIndependentCopy()
    {
        PrintHeader("8. Tao ban sao doc lap");

        MonsterProfile template = new MonsterProfile("Mage", 80, new QuestReward("Sach co", 20));
        MonsterProfile clone = CloneMonster(template);

        clone.Name = "Mage ban sao";
        clone.Health = 10;
        clone.Reward.Exp = 999;

        Console.WriteLine($"template: {template}");
        Console.WriteLine($"clone: {clone}");
        Console.WriteLine("Ket luan: muon doc lap, phai tao class moi va sao chep phan du lieu can thiet.");
        Console.WriteLine();
    }

    private static MonsterProfile CloneMonster(MonsterProfile source)
    {
        return new MonsterProfile(
            source.Name,
            source.Health,
            new QuestReward(source.Reward.Title, source.Reward.Exp));
    }

    private static void PrintHeader(string title)
    {
        Console.WriteLine(new string('-', 60));
        Console.WriteLine(title);
        Console.WriteLine(new string('-', 60));
    }

    private static void PrintBlock(string title, IEnumerable<string> lines)
    {
        PrintHeader(title);

        int index = 1;

        foreach (string line in lines)
        {
            Console.WriteLine($"{index}. {line}");
            index++;
        }

        Console.WriteLine();
    }
}
