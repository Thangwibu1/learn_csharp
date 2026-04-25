using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnCSharp.GiaiDoan2.Bai03BoxingVaUnboxing;

public readonly struct ScoreRecord
{
    public int Value { get; }

    public ScoreRecord(int value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"Diem: {Value}";
    }
}

public static class BoxingUnboxingPractice
{
    private static readonly string[] Overview =
    {
        "Boxing la dua value type vao mot doi tuong kieu object hoac interface.",
        "Unboxing la ep object tro lai value type goc.",
        "Boxing tao them object boc gia tri, vi vay co chi phi bo nho va hieu nang.",
        "Unboxing sai kieu se gay InvalidCastException.",
        "Dung collection generic thuong giup tranh boxing trong nhieu tinh huong.",
        "Pattern matching giup kiem tra kieu an toan truoc khi ep.",
        "Khong phai moi ep kieu deu la boxing hoac unboxing.",
        "String la reference type, ep object sang string khong phai unboxing.",
        "Neu code chay vong lap lon, boxing lap lai co the tro thanh chi phi dang ke.",
        "Hieu ro boxing giup ban doc code cu va toi uu code moi."
    };

    private static readonly string[] WarningSigns =
    {
        "Dung ArrayList cho so nguyen va ép object ra vao lien tuc.",
        "Tra ve object khi du lieu thuc su chi la int hoac double.",
        "So sanh hieu nang nhung khong de y chi phi boxing trong loop.",
        "Viet API qua chung chung khien moi gia tri deu phai di qua object.",
        "Quen kiem tra kieu truoc khi cast mot object khong chac chan.",
        "Nham giua cast string va unboxing int.",
        "Dua struct vao collection khong generic ma khong y thuc duoc boxing.",
        "Dua value type vao interface roi tuong la khong co cap phat nao.",
        "Khong su dung generic khi da biet ro kieu du lieu.",
        "Khong logging du kieu thuc te cua object khi debug loi cast."
    };

    private static readonly string[] SelfCheck =
    {
        "Tai sao object boxed = 5 la boxing?",
        "Tai sao string name = (string)obj khong phai unboxing neu obj dang giu chuoi?",
        "Dieu gi xay ra neu object value = 5.5 va ban ep (int)value?",
        "Tai sao List<int> thuong tot hon ArrayList neu ban luu nhieu so nguyen?",
        "Khi nao can can than voi interface va struct?",
        "Boxing co luon xau khong hay chi xau khi lap lai qua nhieu?",
        "Ban co the chi ra vi tri boxing bang cach doc kieu bien khong?",
        "Vi sao pattern matching giup code an toan hon?",
        "Neu phai dung API cu tra ve object, ban se bao ve code ra sao?",
        "Ban co the mo ta lai boxing va unboxing trong mot cau ngan gon khong?"
    };

    private static readonly string[] Troubleshooting =
    {
        "Neu cast bi loi, truoc het hay in ra GetType cua object.",
        "Neu API tra ve object, dung pattern matching de tach tung truong hop.",
        "Neu thay ArrayList trong code cu, can nghi den boxing va unboxing.",
        "Neu loop rat lon, can xem co thao tac boxing lap lai khong.",
        "Neu struct di qua interface, hay nho rang boxing co the dang xay ra.",
        "Neu ban khong chac day la unboxing hay cast thuong, hay hoi: object nay co dang chua value type da boxing khong?",
        "Neu chi can mot kieu du lieu ro rang, uu tien generic thay cho object.",
        "Neu can luu da kieu, hay tach ro nhom xu ly de tranh cast mu quang."
    };

    public static void Run()
    {
        PrintHeader("THUC HANH BOXING VA UNBOXING");
        PrintSection("Tong quan", Overview);

        DemoBasicBoxing();
        DemoBasicUnboxing();
        DemoWrongCast();
        DemoArrayListBoxing();
        DemoGenericListAvoidsBoxing();
        DemoPatternMatching();
        DemoInterfaceBoxing();
        DemoStringCast();
        DemoEnumBoxing();
        DemoNullableScenario();
        DemoLoopCostMindset();
        DemoObjectReturningApi();

        PrintSection("Dau hieu can can than", WarningSigns);
        PrintSection("Tu kiem tra", SelfCheck);
        PrintSection("Xu ly su co", Troubleshooting);
    }

    private static void DemoBasicBoxing()
    {
        PrintHeader("1. Boxing co ban");

        int score = 99;
        object boxedScore = score;

        Console.WriteLine($"Gia tri goc: {score}");
        Console.WriteLine($"Sau boxing, object chua: {boxedScore}");
        Console.WriteLine($"Kieu thuc te trong object: {boxedScore.GetType().Name}");
        Console.WriteLine();
    }

    private static void DemoBasicUnboxing()
    {
        PrintHeader("2. Unboxing co ban");

        object boxedLevel = 7;
        int level = (int)boxedLevel;

        Console.WriteLine($"Object truoc khi ep: {boxedLevel}");
        Console.WriteLine($"Gia tri sau unboxing: {level}");
        Console.WriteLine();
    }

    private static void DemoWrongCast()
    {
        PrintHeader("3. Cast sai se that bai");

        object boxedDouble = 12.5;

        try
        {
            int wrong = (int)boxedDouble;
            Console.WriteLine(wrong);
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine("Bat loi cast sai de quan sat hanh vi.");
            Console.WriteLine($"Thong diep: {ex.Message}");
        }

        Console.WriteLine();
    }

    private static void DemoArrayListBoxing()
    {
        PrintHeader("4. Collection khong generic gay boxing");

        ArrayList scores = new ArrayList();
        scores.Add(10);
        scores.Add(20);
        scores.Add(30);

        int sum = 0;

        foreach (object item in scores)
        {
            sum += (int)item;
            Console.WriteLine($"Lay ra phan tu: {item} | Kieu: {item.GetType().Name}");
        }

        Console.WriteLine($"Tong diem: {sum}");
        Console.WriteLine();
    }

    private static void DemoGenericListAvoidsBoxing()
    {
        PrintHeader("5. Generic List<int> tranh boxing thong thuong");

        List<int> scores = new List<int> { 10, 20, 30 };
        int sum = 0;

        foreach (int item in scores)
        {
            sum += item;
            Console.WriteLine($"Phan tu generic: {item}");
        }

        Console.WriteLine($"Tong diem: {sum}");
        Console.WriteLine("Ket luan: generic giup giu kieu du lieu ro rang hon.");
        Console.WriteLine();
    }

    private static void DemoPatternMatching()
    {
        PrintHeader("6. Pattern matching truoc khi cast");

        object maybeScore = 55;
        object maybeText = "xin chao";

        if (maybeScore is int safeScore)
        {
            Console.WriteLine($"Lay diem an toan: {safeScore}");
        }

        if (maybeText is string text)
        {
            Console.WriteLine($"Lay chuoi an toan: {text}");
        }

        Console.WriteLine();
    }

    private static void DemoInterfaceBoxing()
    {
        PrintHeader("7. Struct qua interface co the boxing");

        ScoreRecord record = new ScoreRecord(88);
        IFormattable formattable = record;

        Console.WriteLine(record.ToString());
        Console.WriteLine(formattable.ToString(null, null));
        Console.WriteLine("Can nho: khi value type di qua object hoac interface, boxing co the xay ra.");
        Console.WriteLine();
    }

    private static void DemoStringCast()
    {
        PrintHeader("8. Cast string khong phai unboxing");

        object message = "Hoc C# co he thong";

        if (message is string text)
        {
            Console.WriteLine($"Chuoi sau khi cast: {text}");
        }

        Console.WriteLine("Day la cast reference type, khong phai unboxing value type.");
        Console.WriteLine();
    }

    private static void DemoEnumBoxing()
    {
        PrintHeader("9. Boxing voi enum");

        BattleRank rank = BattleRank.Gold;
        object boxedRank = rank;

        Console.WriteLine($"Enum goc: {rank}");
        Console.WriteLine($"Sau boxing: {boxedRank}");
        Console.WriteLine($"Kieu thuc te: {boxedRank.GetType().Name}");

        BattleRank unboxedRank = (BattleRank)boxedRank;
        Console.WriteLine($"Sau unboxing: {unboxedRank}");
        Console.WriteLine();
    }

    private static void DemoNullableScenario()
    {
        PrintHeader("10. Tinh huong voi nullable");

        int? maybeScore = 42;
        object boxedNullable = maybeScore!;

        Console.WriteLine($"Gia tri nullable truoc boxing: {maybeScore}");
        Console.WriteLine($"Object sau boxing tu nullable co kieu: {boxedNullable.GetType().Name}");

        if (boxedNullable is int safeValue)
        {
            Console.WriteLine($"Lay lai gia tri an toan: {safeValue}");
        }

        int? emptyScore = null;
        object? boxedEmpty = emptyScore;
        Console.WriteLine($"Nullable null khi boxing se cho ket qua null: {boxedEmpty is null}");
        Console.WriteLine();
    }

    private static void DemoLoopCostMindset()
    {
        PrintHeader("11. Tu duy ve chi phi boxing trong loop");

        ArrayList values = new ArrayList();

        for (int i = 1; i <= 5; i++)
        {
            values.Add(i * 10);
        }

        int total = 0;

        foreach (object value in values)
        {
            int score = (int)value;
            total += score;
            Console.WriteLine($"Doc gia tri {score} tu ArrayList");
        }

        Console.WriteLine($"Tong trong loop: {total}");
        Console.WriteLine("Voi 5 phan tu thi khong dang ke, nhung tu duy nay quan trong khi du lieu lon va lap lai lien tuc.");
        Console.WriteLine();
    }

    private static void DemoObjectReturningApi()
    {
        PrintHeader("12. API tra ve object va cach xu ly an toan");

        object first = GetLegacyValue(1);
        object second = GetLegacyValue(2);
        object third = GetLegacyValue(3);

        PrintLegacyValue(first);
        PrintLegacyValue(second);
        PrintLegacyValue(third);
        Console.WriteLine();
    }

    private static object GetLegacyValue(int mode)
    {
        return mode switch
        {
            1 => 123,
            2 => 45.6,
            _ => "du lieu cu"
        };
    }

    private static void PrintLegacyValue(object value)
    {
        switch (value)
        {
            case int number:
                Console.WriteLine($"Nhan int: {number}, binh phuong: {number * number}");
                break;
            case double real:
                Console.WriteLine($"Nhan double: {real}, lam tron: {Math.Round(real, 1)}");
                break;
            case string text:
                Console.WriteLine($"Nhan string: {text}, do dai: {text.Length}");
                break;
            default:
                Console.WriteLine("Kieu khong ho tro.");
                break;
        }
    }

    private static void PrintHeader(string title)
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 60));
    }

    private static void PrintSection(string title, IEnumerable<string> lines)
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

    private enum BattleRank
    {
        Bronze,
        Silver,
        Gold,
        Diamond
    }
}
