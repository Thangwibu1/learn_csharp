using System;
using System.Collections.Generic;

namespace LearnCSharp.GiaiDoan2.Bai01StackVaHeap;

public struct DamageSnapshot
{
    public int HitCount;
    public int TotalDamage;

    public DamageSnapshot(int hitCount, int totalDamage)
    {
        HitCount = hitCount;
        TotalDamage = totalDamage;
    }

    public override string ToString()
    {
        return $"So lan danh: {HitCount}, Tong sat thuong: {TotalDamage}";
    }
}

public sealed class WeaponBag
{
    public string Name { get; set; }
    public int Capacity { get; set; }

    public WeaponBag(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }

    public override string ToString()
    {
        return $"{Name} - suc chua {Capacity}";
    }
}

public sealed class StackHeapPlayer
{
    public string Name { get; set; }
    public int Health { get; set; }
    public WeaponBag Bag { get; set; }

    public StackHeapPlayer(string name, int health, WeaponBag bag)
    {
        Name = name;
        Health = health;
        Bag = bag;
    }

    public override string ToString()
    {
        return $"{Name} | Mau: {Health} | Tui do: {Bag}";
    }
}

public static class StackHeapPractice
{
    private static readonly string[] CoreIdeas =
    {
        "Stack thuong duoc dung cho bien cuc bo va khung ham dang chay.",
        "Heap thuong chua object duoc tao bang tu khoa new.",
        "Value type thuong sao chep du lieu.",
        "Reference type thuong sao chep dia chi tham chieu.",
        "Mot bien class khong chua toan bo object, no thuong chi giu tham chieu.",
        "Khi 2 bien cung tro toi cung object, sua qua bien nao cung thay doi object do.",
        "Struct giup mo ta du lieu nho gon va hanh vi sao chep theo gia tri.",
        "Class phu hop khi can doi tuong co danh tinh va co the duoc chia se.",
        "Mang la reference type, nhung phan tu trong mang co the la value type hoac reference type.",
        "Ham ket thuc thi bien cuc bo cua no het pham vi song.",
        "Rac tren heap can bo thu gom rac xu ly.",
        "Tao qua nhieu object ngan han co the lam tang ap luc GC.",
        "Khong nen hoc stack va heap theo kieu hoc vet, hay quan sat hanh vi copy.",
        "Neu ban thay du lieu doi ngoai y muon, can nghi den viec chia se reference.",
        "Neu ban can ban sao doc lap, can tao object moi thay vi chi gan bang bien cu."
    };

    private static readonly string[] CommonMistakes =
    {
        "Nham rang bien class chua truc tiep toan bo du lieu cua object.",
        "Cho rang sao chep Player playerB = playerA se tao ra 2 object khac nhau.",
        "Nham giua viec doi gia tri thuoc tinh va doi chinh bien tham chieu.",
        "Quen kiem tra null truoc khi truy cap thuoc tinh cua object.",
        "Tao object moi trong vong lap lien tuc ma khong co ly do ro rang.",
        "Nghi rang stack nhanh hon heap trong moi tinh huong ma khong can biet ngu canh.",
        "Khong phan biet struct copy theo gia tri voi class copy theo tham chieu.",
        "Nham giua viec mang la reference type va viec phan tu int trong mang van la value type.",
        "Khong dat ten bien ro rang nen kho theo doi object nao dang bi sua.",
        "Chi doc ly thuyet ma khong in gia tri ra man hinh de tu xac nhan."
    };

    private static readonly string[] SelfChecks =
    {
        "Neu copiedScore thay doi, vi sao score goc khong doi?",
        "Neu playerB.Health doi, vi sao playerA.Health cung doi?",
        "Tai sao gan playerB = new StackHeapPlayer(...) lai khong sua object cu?",
        "Tai sao mang int[] la reference type nhung tung phan tu int van la value type?",
        "Khi mot ham ket thuc, bien cuc bo bien mat nhung object tren heap co bien mat ngay khong?",
        "Luc nao nen can than voi viec tao object tam thoi trong game loop?",
        "Neu can 2 nhan vat doc lap, ban phai copy nhung thanh phan nao?",
        "Tai sao null la trang thai can duoc xu ly som?",
        "Vi sao mot struct nho gon thuong de ly giai hon trong bai toan snapshot?",
        "Ban co the tu mo ta lai bang loi cua minh su khac nhau giua stack va heap khong?"
    };

    public static void Run()
    {
        PrintHeader("THUC HANH STACK VA HEAP");
        PrintLines("Y tuong cot loi", CoreIdeas);

        DemoValueTypeCopy();
        DemoReferenceTypeCopy();
        DemoStructSnapshot();
        DemoArrayReference();
        DemoMethodScope();
        DemoMutationVsReassignment();
        DemoNullHandling();
        DemoObjectCreationPressure();

        PrintLines("Loi thuong gap", CommonMistakes);
        PrintLines("Tu kiem tra", SelfChecks);
    }

    private static void DemoValueTypeCopy()
    {
        PrintHeader("1. Value type copy doc lap");

        int score = 100;
        int copiedScore = score;

        Console.WriteLine($"Ban dau -> score: {score}, copiedScore: {copiedScore}");

        copiedScore = 200;

        Console.WriteLine($"Sau khi sua ban sao -> score: {score}, copiedScore: {copiedScore}");
        Console.WriteLine("Ket luan: int duoc sao chep theo gia tri.");
        Console.WriteLine();
    }

    private static void DemoReferenceTypeCopy()
    {
        PrintHeader("2. Reference type cung tro toi mot object");

        WeaponBag starterBag = new WeaponBag("Tui khoi dau", 3);
        StackHeapPlayer playerA = new StackHeapPlayer("An", 100, starterBag);
        StackHeapPlayer playerB = playerA;

        Console.WriteLine("Trang thai truoc khi sua:");
        Console.WriteLine(playerA);
        Console.WriteLine(playerB);

        playerB.Health = 55;
        playerB.Bag.Capacity = 5;

        Console.WriteLine("Trang thai sau khi sua qua playerB:");
        Console.WriteLine(playerA);
        Console.WriteLine(playerB);
        Console.WriteLine("Ket luan: playerA va playerB dang dung chung mot object tren heap.");
        Console.WriteLine();
    }

    private static void DemoStructSnapshot()
    {
        PrintHeader("3. Struct snapshot phuc vu luu nhanh trang thai");

        DamageSnapshot first = new DamageSnapshot(3, 75);
        DamageSnapshot second = first;

        Console.WriteLine($"Ban dau -> first: {first}");
        Console.WriteLine($"Ban dau -> second: {second}");

        second.TotalDamage = 120;
        second.HitCount = 4;

        Console.WriteLine($"Sau khi sua second -> first: {first}");
        Console.WriteLine($"Sau khi sua second -> second: {second}");
        Console.WriteLine("Ket luan: struct thuong giup copy du lieu nho gon theo gia tri.");
        Console.WriteLine();
    }

    private static void DemoArrayReference()
    {
        PrintHeader("4. Mang la reference type");

        int[] scoresA = { 10, 20, 30 };
        int[] scoresB = scoresA;

        Console.WriteLine($"Mang truoc khi doi: {string.Join(", ", scoresA)}");

        scoresB[1] = 999;

        Console.WriteLine($"scoresA sau khi sua qua scoresB: {string.Join(", ", scoresA)}");
        Console.WriteLine($"scoresB sau khi sua: {string.Join(", ", scoresB)}");
        Console.WriteLine("Ket luan: bien mang cung sao chep tham chieu.");
        Console.WriteLine();
    }

    private static void DemoMethodScope()
    {
        PrintHeader("5. Bien cuc bo song trong pham vi ham");

        int result = CalculateCriticalDamage(40, 2);

        Console.WriteLine($"Sat thuong chi mang ra ngoai ket qua cuoi cung: {result}");
        Console.WriteLine("Bien cuc bo ben trong ham chi ton tai trong luc ham dang chay.");
        Console.WriteLine();
    }

    private static int CalculateCriticalDamage(int baseDamage, int multiplier)
    {
        int previewDamage = baseDamage * multiplier;
        int safeDamage = previewDamage + 5;
        return safeDamage;
    }

    private static void DemoMutationVsReassignment()
    {
        PrintHeader("6. Sua object khac voi doi bien tham chieu");

        StackHeapPlayer original = new StackHeapPlayer("Binh", 120, new WeaponBag("Tui do chinh", 4));
        StackHeapPlayer alias = original;

        alias.Health = 80;

        Console.WriteLine("Sau khi sua Health qua alias:");
        Console.WriteLine($"original: {original}");
        Console.WriteLine($"alias: {alias}");

        alias = new StackHeapPlayer("Cuong", 90, new WeaponBag("Tui do phu", 2));

        Console.WriteLine("Sau khi alias tro sang object moi:");
        Console.WriteLine($"original: {original}");
        Console.WriteLine($"alias: {alias}");
        Console.WriteLine("Ket luan: doi du lieu cua object va doi bien tro toi object la hai viec khac nhau.");
        Console.WriteLine();
    }

    private static void DemoNullHandling()
    {
        PrintHeader("7. Can than voi null");

        StackHeapPlayer? unknown = null;

        Console.WriteLine("Neu object chua duoc tao, bien co the la null.");

        if (unknown is null)
        {
            Console.WriteLine("unknown dang la null, can tao object truoc khi dung.");
            unknown = new StackHeapPlayer("Du phong", 70, new WeaponBag("Tui tam", 1));
        }

        Console.WriteLine($"Object sau khi khoi tao: {unknown}");
        Console.WriteLine();
    }

    private static void DemoObjectCreationPressure()
    {
        PrintHeader("8. Tao object hang loat de hieu ap luc cap phat");

        List<StackHeapPlayer> party = new List<StackHeapPlayer>();

        for (int i = 1; i <= 5; i++)
        {
            StackHeapPlayer member = new StackHeapPlayer(
                $"Thanh vien {i}",
                100 + i,
                new WeaponBag($"Tui {i}", i));

            party.Add(member);
        }

        foreach (StackHeapPlayer member in party)
        {
            Console.WriteLine(member);
        }

        Console.WriteLine("Vi du nho nay khong gay van de, nhung trong game loop lon can tranh tao object vo toi va.");
        Console.WriteLine();
    }

    private static void PrintHeader(string title)
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 60));
    }

    private static void PrintLines(string title, IEnumerable<string> lines)
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
