using System;

class Character
{
    public string Name { get; set; }
    public int Health { get; protected set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void Attack()
    {
        Console.WriteLine(Name + " tan cong theo cach co ban.");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Ten: " + Name + ", Mau: " + Health);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }
}

class Warrior : Character
{
    public Warrior(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Console.WriteLine(Name + " chem kiem sat thuong manh.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Warrior - Ten: " + Name + ", Mau: " + Health);
    }
}

class Mage : Character
{
    public Mage(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Console.WriteLine(Name + " tung cau lua.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Mage - Ten: " + Name + ", Mau: " + Health);
    }
}

class Archer : Character
{
    public Archer(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Console.WriteLine(Name + " ban mui ten tu xa.");
    }
}

class Monster : Character
{
    public Monster(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Console.WriteLine(Name + " vo lao can tan cong.");
    }
}

class Animal
{
    public string Species { get; set; }

    public Animal(string species)
    {
        Species = species;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine(Species + " phat ra am thanh chung.");
    }
}

class Dog : Animal
{
    public Dog() : base("Cho")
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Cho sua gau gau.");
    }
}

class Cat : Animal
{
    public Cat() : base("Meo")
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meo keu meo meo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 04 - Ke thua va da hinh");
        DemoKeThuaCoBan();
        DemoOverrideAttack();
        DemoDaHinhQuaBienCha();
        DemoDanhSachNhanVat();
        DemoShowInfo();
        DemoTakeDamageTuClassCha();
        DemoAnimalSound();
        DemoDaHinhTrongHam();
        DemoLoiIchTaiSuDung();
        TongKet();
    }

    static void InTieuDe(string title)
    {
        Console.WriteLine(new string('=', 70));
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 70));
    }

    static void InPhan(string section)
    {
        Console.WriteLine();
        Console.WriteLine("--- " + section + " ---");
    }

    static void DemoKeThuaCoBan()
    {
        InPhan("1. Ke thua co ban");

        Warrior warrior = new Warrior("Kiem Si", 150);
        warrior.ShowInfo();
    }

    static void DemoOverrideAttack()
    {
        InPhan("2. Override Attack");

        Warrior warrior = new Warrior("Leon", 140);
        Mage mage = new Mage("Iris", 90);
        Archer archer = new Archer("Robin", 100);

        warrior.Attack();
        mage.Attack();
        archer.Attack();
    }

    static void DemoDaHinhQuaBienCha()
    {
        InPhan("3. Da hinh qua bien cha");

        Character c1 = new Warrior("Ares", 160);
        Character c2 = new Mage("Luna", 85);
        Character c3 = new Archer("Kai", 95);

        c1.Attack();
        c2.Attack();
        c3.Attack();
    }

    static void DemoDanhSachNhanVat()
    {
        InPhan("4. Duyet nhieu nhan vat cung kieu cha");

        Character[] team =
        {
            new Warrior("Tank", 200),
            new Mage("Wizard", 80),
            new Archer("Sniper", 110),
            new Monster("Goblin", 60)
        };

        for (int i = 0; i < team.Length; i++)
        {
            team[i].ShowInfo();
            team[i].Attack();
        }
    }

    static void DemoShowInfo()
    {
        InPhan("5. Override ShowInfo");

        Character warrior = new Warrior("Brave", 170);
        Character mage = new Mage("Nova", 75);

        warrior.ShowInfo();
        mage.ShowInfo();
    }

    static void DemoTakeDamageTuClassCha()
    {
        InPhan("6. Tai su dung method tu class cha");

        Warrior warrior = new Warrior("Steel", 180);
        warrior.ShowInfo();
        warrior.TakeDamage(35);
        warrior.ShowInfo();
    }

    static void DemoAnimalSound()
    {
        InPhan("7. Vi du them ve dong vat");

        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound();
        cat.MakeSound();
    }

    static void DemoDaHinhTrongHam()
    {
        InPhan("8. Da hinh trong ham");

        Character warrior = new Warrior("Atlas", 190);
        Character mage = new Mage("Mira", 88);

        ProcessCharacter(warrior);
        ProcessCharacter(mage);
    }

    static void DemoLoiIchTaiSuDung()
    {
        InPhan("9. Loi ich tai su dung");

        Console.WriteLine("Class cha giu nhung thu chung nhu Name, Health, TakeDamage.");
        Console.WriteLine("Class con chi can them phan rieng nhu cach tan cong.");
        Console.WriteLine("Nho vay code gon hon, it lap lai hon, va de mo rong hon.");
    }

    static void ProcessCharacter(Character character)
    {
        character.ShowInfo();
        character.Attack();
    }

    static void TongKet()
    {
        InPhan("10. Tong ket");

        Console.WriteLine("Ke thua giup class con nhan lai du lieu va hanh vi chung tu class cha.");
        Console.WriteLine("Da hinh giup cung mot lenh goi nhung moi doi tuong phan ung khac nhau.");
        Console.WriteLine("Hai y tuong nay giup code OOP co cau truc ro rang va de mo rong.");
    }

    /*
    Ghi chu mo rong cho bai ke thua va da hinh.
    Dong 01: Ke thua la co che cho phep class con tai su dung tu class cha.
    Dong 02: Day la cach gom nhung diem chung vao mot noi.
    Dong 03: Vi du nhieu nhan vat deu co ten, mau, va kha nang nhan sat thuong.
    Dong 04: Ta dua cac thu chung nay vao Character.
    Dong 05: Sau do Warrior, Mage, Archer chi can them phan rieng.
    Dong 06: Day giup tranh lap code.
    Dong 07: Day cung giup su dong nhat trong he thong.
    Dong 08: Neu thay doi cach xu ly mau, class cha co the la noi trung tam.
    Dong 09: Tu khoa virtual cho phep class con ghi de hanh vi.
    Dong 10: Tu khoa override dung trong class con de thay doi hanh vi do.
    Dong 11: Day la nen tang cua da hinh.
    Dong 12: Da hinh nghia la cung mot kieu tham chieu cha, nhung doi tuong that su co the la nhieu loai con.
    Dong 13: Khi goi method virtual, chuong trinh se chon phien ban dung theo doi tuong that.
    Dong 14: Vi du Character c = new Mage(...); c.Attack() se goi Attack cua Mage.
    Dong 15: Day la diem rat manh cua OOP.
    Dong 16: Nho da hinh, ta co the viet ham ProcessCharacter(Character c).
    Dong 17: Ham nay xu ly duoc Warrior, Mage, Archer, Monster ma khong can biet tung loai cu the.
    Dong 18: Day giup giam phu thuoc vao class cu the.
    Dong 19: Day cung la tien de de hoc interface va decoupling.
    Dong 20: Ke thua khong phai luc nao cung la lua chon tot nhat.
    Dong 21: Chi dung ke thua khi giua hai lop co quan he `la mot` rat ro.
    Dong 22: Warrior la mot Character.
    Dong 23: Dog la mot Animal.
    Dong 24: Day la quan he hop ly cho ke thua.
    Dong 25: Neu quan he la `co mot`, thuong composition hop hon.
    Dong 26: Vi du Car co Engine, khong phai la Engine.
    Dong 27: Day la phan biet quan trong trong thiet ke OOP.
    Dong 28: Trong bai nay, ta tap trung vao truong hop ke thua dung cho tai su dung va da hinh.
    Dong 29: Class cha nen chua nhung gi that su chung.
    Dong 30: Neu nhieu class con khong can mot thu gi do, co the no khong nen nam o class cha.
    Dong 31: Day la ky nang thiet ke can luyen dan.
    Dong 32: Method khong can ghi de thi khong nhat thiet phai virtual.
    Dong 33: Virtual chi nen dung cho diem mo rong that su can thiet.
    Dong 34: Neu moi thu deu virtual, class cha se de bi phan tan trach nhiem.
    Dong 35: Trong bai nay, Attack va ShowInfo hop ly de cho ghi de.
    Dong 36: TakeDamage co the de o class cha vi logic dung chung.
    Dong 37: Nhu vay ta vua tai su dung duoc, vua giu he thong gon.
    Dong 38: Bai nay se rat de thay trong game va mo hinh doi tuong.
    Dong 39: Cung mot he thong co the co nhieu loai nhan vat, quai, dong vat, phuong tien.
    Dong 40: Da hinh giup ta xu ly chung qua mot kieu tong quat.
    Dong 41: Loi pho bien la lam class cha qua lon.
    Dong 42: Nhieu nguoi moi hoc dua qua nhieu thu vao class cha vi nghi de dung chung.
    Dong 43: Ket qua la class cha tro nen kho bao tri.
    Dong 44: Hay giu class cha gon, dung muc dich.
    Dong 45: Loi pho bien khac la ghi de method nhung khong thay doi y nghia.
    Dong 46: Neu method giong het class cha, co the khong can override.
    Dong 47: O muc do ban dau, dieu quan trong la hieu duoc dong chay cua da hinh.
    Dong 48: Ban hay thu them mot class con moi va dua vao mang Character.
    Dong 49: Chay lai va xem Attack nao duoc goi.
    Dong 50: Bai tap nay se lam da hinh tro nen rat ro rang.
    Dong 51: Bai tap tu luyen 1: Vehicle, Car, Bike.
    Dong 52: Bai tap tu luyen 2: Employee, Developer, Designer.
    Dong 53: Bai tap tu luyen 3: Shape, Circle, Rectangle.
    Dong 54: Bai tap tu luyen 4: Animal, Bird, Fish.
    Dong 55: Bai tap tu luyen 5: Notification, Email, Sms.
    Dong 56: Moi bai nen co method virtual chung va class con override.
    Dong 57: Sau do hay tao bien cha va gan doi tuong con.
    Dong 58: Goi method qua bien cha de quan sat da hinh.
    Dong 59: Day la bai tap cot loi nhat.
    Dong 60: Khi hieu no, ban se de hoc interface hon nhieu.
    Dong 61: Da hinh khong chi la khai niem ly thuyet.
    Dong 62: No giup he thong de mo rong ma it phai sua code cu.
    Dong 63: Them class con moi thuong khong can doi nhieu cho da co san.
    Dong 64: Day la mot loi ich thiet ke rat lon.
    Dong 65: Ke thua va da hinh cung giup code de doc hon neu to chuc dung.
    Dong 66: Nguoi doc chi can nhin class cha de hieu phan chung.
    Dong 67: Sau do nhin class con de biet diem khac biet.
    Dong 68: Day la cach trinh bay ma nguoi doc code rat de tiep nhan.
    Dong 69: Hay tiep tuc luyen voi nhieu vi du thuc te hon.
    Dong 70: Ket thuc ghi chu mo rong cho bai ke thua va da hinh.
    */
}
