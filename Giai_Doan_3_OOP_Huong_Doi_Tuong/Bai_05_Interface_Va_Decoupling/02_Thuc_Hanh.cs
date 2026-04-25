using System;

interface IDamageable
{
    void TakeDamage(int damage);
}

interface IInteractable
{
    void Interact();
}

interface INotifier
{
    void Send(string message);
}

class Enemy : IDamageable
{
    public string Name { get; }
    public int Health { get; private set; }

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine(Name + " con lai " + Health + " mau.");
    }
}

class TrainingDummy : IDamageable
{
    public void TakeDamage(int damage)
    {
        Console.WriteLine("Bup be tap nhan " + damage + " sat thuong, nhung khong mat mau that.");
    }
}

class Door : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("Mo cua thanh cong.");
    }
}

class Chest : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("Mo ruong va nhan vat pham.");
    }
}

class Npc : IInteractable
{
    public string Name { get; }

    public Npc(string name)
    {
        Name = name;
    }

    public void Interact()
    {
        Console.WriteLine("Tro chuyen voi NPC " + Name + ".");
    }
}

class Sword
{
    public void Hit(IDamageable target)
    {
        Console.WriteLine("Kiem da tan cong muc tieu.");
        target.TakeDamage(25);
    }
}

class Arrow
{
    public void Shoot(IDamageable target)
    {
        Console.WriteLine("Mui ten bay den muc tieu.");
        target.TakeDamage(15);
    }
}

class PlayerInteractor
{
    public void Use(IInteractable target)
    {
        Console.WriteLine("Nguoi choi dang tuong tac...");
        target.Interact();
    }
}

class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Gui email: " + message);
    }
}

class SmsNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Gui SMS: " + message);
    }
}

class PushNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Gui push notification: " + message);
    }
}

class NotificationService
{
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void SendWelcome()
    {
        _notifier.Send("Chao mung ban den voi khoa hoc C#.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 05 - Interface va Decoupling");
        DemoIDamageable();
        DemoNhieuLoaiMucTieu();
        DemoIInteractable();
        DemoNhieuLoaiTuongTac();
        DemoDecouplingVoiNotifier();
        DemoDoiCachTrienKhaiKhongSuaService();
        DemoMangInterface();
        DemoHamNhanInterface();
        DemoLoiIchDecoupling();
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

    static void DemoIDamageable()
    {
        InPhan("1. IDamageable co ban");

        Enemy enemy = new Enemy("Goblin", 100);
        Sword sword = new Sword();

        sword.Hit(enemy);
    }

    static void DemoNhieuLoaiMucTieu()
    {
        InPhan("2. Nhieu loai muc tieu cung nhan sat thuong");

        Sword sword = new Sword();
        Arrow arrow = new Arrow();
        Enemy enemy = new Enemy("Orc", 120);
        TrainingDummy dummy = new TrainingDummy();

        sword.Hit(enemy);
        arrow.Shoot(enemy);
        sword.Hit(dummy);
    }

    static void DemoIInteractable()
    {
        InPhan("3. IInteractable co ban");

        PlayerInteractor interactor = new PlayerInteractor();
        Door door = new Door();

        interactor.Use(door);
    }

    static void DemoNhieuLoaiTuongTac()
    {
        InPhan("4. Nhieu loai doi tuong tuong tac");

        PlayerInteractor interactor = new PlayerInteractor();
        Chest chest = new Chest();
        Npc npc = new Npc("Ong gia trong lang");

        interactor.Use(chest);
        interactor.Use(npc);
    }

    static void DemoDecouplingVoiNotifier()
    {
        InPhan("5. Decoupling voi notifier");

        NotificationService service = new NotificationService(new EmailNotifier());
        service.SendWelcome();
    }

    static void DemoDoiCachTrienKhaiKhongSuaService()
    {
        InPhan("6. Doi cach trien khai ma khong sua service");

        NotificationService smsService = new NotificationService(new SmsNotifier());
        NotificationService pushService = new NotificationService(new PushNotifier());

        smsService.SendWelcome();
        pushService.SendWelcome();
    }

    static void DemoMangInterface()
    {
        InPhan("7. Mang interface");

        IInteractable[] objects =
        {
            new Door(),
            new Chest(),
            new Npc("Thu thu vien")
        };

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].Interact();
        }
    }

    static void DemoHamNhanInterface()
    {
        InPhan("8. Ham nhan interface");

        AttackTwice(new Enemy("Slime", 40));
        AttackTwice(new TrainingDummy());

        InteractTwice(new Door());
        InteractTwice(new Npc("Huong dan vien"));
    }

    static void DemoLoiIchDecoupling()
    {
        InPhan("9. Loi ich decoupling");

        Console.WriteLine("Class Sword khong can biet doi tuong cu the la Enemy hay TrainingDummy.");
        Console.WriteLine("No chi can biet muc tieu nhan sat thuong duoc qua IDamageable.");
        Console.WriteLine("NotificationService khong can biet dang gui email, sms hay push.");
        Console.WriteLine("No chi phu thuoc vao INotifier, day la decoupling.");
    }

    static void AttackTwice(IDamageable target)
    {
        Sword sword = new Sword();
        sword.Hit(target);
        sword.Hit(target);
    }

    static void InteractTwice(IInteractable target)
    {
        PlayerInteractor interactor = new PlayerInteractor();
        interactor.Use(target);
        interactor.Use(target);
    }

    static void TongKet()
    {
        InPhan("10. Tong ket");

        Console.WriteLine("Interface mo ta hop dong hanh vi ma class phai thuc hien.");
        Console.WriteLine("Lap trinh huong interface giup class it phu thuoc vao nhau hon.");
        Console.WriteLine("Nho vay he thong de thay doi, de test, va de mo rong hon.");
    }

    /*
    Ghi chu mo rong cho bai interface va decoupling.
    Dong 01: Interface la ban hop dong cho hanh vi.
    Dong 02: No noi rang doi tuong nao trien khai interface thi phai co nhung method nay.
    Dong 03: Interface khong quan tam class do la ai.
    Dong 04: No chi quan tam class do lam duoc gi.
    Dong 05: Day la cach nghi rat quan trong trong OOP hien dai.
    Dong 06: Vi du Sword khong can biet muc tieu co phai la Enemy khong.
    Dong 07: No chi can biet muc tieu nhan sat thuong duoc.
    Dong 08: Vi the ta dung IDamageable.
    Dong 09: Nho vay mai sau them Boss, Tower, TrainingDummy van dung duoc.
    Dong 10: Sword khong can sua.
    Dong 11: Day chinh la giam phu thuoc truc tiep vao class cu the.
    Dong 12: Do chinh la decoupling.
    Dong 13: Decoupling nghia la tach phu thuoc chat che giua cac thanh phan.
    Dong 14: Khi it phu thuoc, thay doi mot noi se it anh huong noi khac.
    Dong 15: Day la loi ich rat lon trong du an lon.
    Dong 16: Interface cung rat hop voi testing.
    Dong 17: Ban co the thay EmailNotifier bang FakeNotifier trong test.
    Dong 18: Service van chay ma khong can gui that.
    Dong 19: Day la mot suc manh thuc te cua lap trinh huong abstraction.
    Dong 20: Khac voi ke thua, interface tap trung vao hanh vi hon la du lieu chung.
    Dong 21: Ke thua mo ta quan he cha con.
    Dong 22: Interface mo ta kha nang ma nhieu class khac nhau co the cung so huu.
    Dong 23: Door va Chest khong cung mot class cha nghiep vu sau sac, nhung deu co the Interact.
    Dong 24: Vi the IInteractable la hop ly.
    Dong 25: Enemy va TrainingDummy khong giong nhau, nhung deu TakeDamage duoc.
    Dong 26: Vi the IDamageable la hop ly.
    Dong 27: Ban nen dat ten interface bang I + danh tu/ tinh tu mo ta kha nang.
    Dong 28: Vi du IInteractable, IDamageable, INotifier.
    Dong 29: Ten nay giup nguoi doc hieu nhanh y do.
    Dong 30: Class su dung interface nen phu thuoc vao interface trong constructor hoac method.
    Dong 31: NotificationService nhan INotifier thay vi EmailNotifier cu the.
    Dong 32: Nho do co the thay bang SmsNotifier hoac PushNotifier ma khong doi service.
    Dong 33: Day la mot trong nhung vi du kinh dien nhat cua decoupling.
    Dong 34: Loi pho bien la tao interface qua som cho moi class.
    Dong 35: Khong phai luc nao cung can interface.
    Dong 36: Hay dung khi co nhieu cach trien khai, can thay the, can test, hoac can giam phu thuoc.
    Dong 37: Neu he thong rat nho va chua co nhu cau nay, interface co the la qua tay.
    Dong 38: Tuy nhien o bai hoc, ta chu dong luyen de quen tu duy.
    Dong 39: Interface khong luu state nhu field instance thong thuong.
    Dong 40: No chu yeu mo ta method, property, event can co.
    Dong 41: Trong bai co ban, hay tap trung vao method.
    Dong 42: Sau nay ban co the hoc them interface voi property.
    Dong 43: Decoupling giup he thong mo rong tot hon.
    Dong 44: Khi them PushNotifier, service cu khong doi.
    Dong 45: Khi them Boss : IDamageable, sword cu khong doi.
    Dong 46: Do la dau hieu cua thiet ke mem deo.
    Dong 47: Goc nhin quan trong la `phu thuoc vao abstraction, khong phu thuoc vao concrete`.
    Dong 48: Cau nay rat noi tieng trong OOP va SOLID.
    Dong 49: Bai nay la cua ngo de hoc DIP va Dependency Injection sau nay.
    Dong 50: Ban chua can hoc sau ngay, chi can nho y tuong cot loi.
    Dong 51: Mot class chi nen biet dung kha nang nao, khong nen biet qua ro ai thuc hien no.
    Dong 52: Cang biet it ve chi tiet cu the, cang linh hoat.
    Dong 53: Bai tap tu luyen 1: IPayable voi CashPayment va CardPayment.
    Dong 54: Bai tap tu luyen 2: ILogger voi ConsoleLogger va FileLogger.
    Dong 55: Bai tap tu luyen 3: IPlayable voi Mp3Player va VideoPlayer.
    Dong 56: Bai tap tu luyen 4: ISaveable voi LocalSave va CloudSave.
    Dong 57: Bai tap tu luyen 5: IDiscountPolicy voi nhieu quy tac giam gia.
    Dong 58: Moi bai nen co mot class service phu thuoc vao interface.
    Dong 59: Sau do doi implementation ma service khong doi.
    Dong 60: Neu lam duoc bai nay, ban da cam nhan duoc decoupling.
    Dong 61: Interface cung ket hop rat tot voi mang va danh sach.
    Dong 62: Ban co the tao mang IInteractable va goi Interact cho tat ca.
    Dong 63: Day la mot dang da hinh thong qua interface.
    Dong 64: No giong da hinh qua class cha, nhung linh hoat hon vi khong bi gioi han boi mot cay ke thua.
    Dong 65: Mot class co the trien khai nhieu interface.
    Dong 66: Day la diem manh so voi ke thua class chi co mot cha.
    Dong 67: Vi du mot Robot co the vua IDamageable vua IInteractable.
    Dong 68: Khi hieu ro bai nay, ban se thiet ke he thong ro rang hon rat nhieu.
    Dong 69: Day la ky nang thuoc nhom seniority rat quan trong.
    Dong 70: Ket thuc ghi chu mo rong cho bai interface va decoupling.
    */
}
