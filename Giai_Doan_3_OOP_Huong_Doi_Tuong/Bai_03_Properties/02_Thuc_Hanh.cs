using System;

class Product
{
    private decimal _price;
    private int _stock;

    public string Name { get; set; }

    public string Category { get; set; }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Gia khong duoc am. Gia se duoc dat ve 0.");
                _price = 0;
            }
            else
            {
                _price = value;
            }
        }
    }

    public int Stock
    {
        get { return _stock; }
        private set
        {
            if (value < 0)
            {
                _stock = 0;
            }
            else
            {
                _stock = value;
            }
        }
    }

    public bool IsAvailable
    {
        get { return Stock > 0; }
    }

    public Product(string name, string category, decimal price, int stock)
    {
        Name = name;
        Category = category;
        Price = price;
        Stock = stock;
    }

    public void AddStock(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("So luong nhap kho phai lon hon 0.");
            return;
        }

        Stock += amount;
    }

    public void Sell(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("So luong ban phai lon hon 0.");
            return;
        }

        if (amount > Stock)
        {
            Console.WriteLine("Khong du ton kho de ban.");
            return;
        }

        Stock -= amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Ten: " + Name);
        Console.WriteLine("Danh muc: " + Category);
        Console.WriteLine("Gia: " + Price);
        Console.WriteLine("Ton kho: " + Stock);
        Console.WriteLine("Co san: " + IsAvailable);
    }
}

class Student
{
    private double _average;

    public string FullName { get; set; }

    public double Average
    {
        get { return _average; }
        set
        {
            if (value < 0)
            {
                _average = 0;
            }
            else if (value > 10)
            {
                _average = 10;
            }
            else
            {
                _average = value;
            }
        }
    }

    public string Rank
    {
        get
        {
            if (Average >= 9)
            {
                return "Xuat sac";
            }

            if (Average >= 8)
            {
                return "Gioi";
            }

            if (Average >= 6.5)
            {
                return "Kha";
            }

            if (Average >= 5)
            {
                return "Trung binh";
            }

            return "Can co gang";
        }
    }

    public Student(string fullName, double average)
    {
        FullName = fullName;
        Average = average;
    }

    public void PrintSummary()
    {
        Console.WriteLine("Hoc vien: " + FullName);
        Console.WriteLine("Diem trung binh: " + Average);
        Console.WriteLine("Xep loai: " + Rank);
    }
}

class BankAccount
{
    public string OwnerName { get; set; }

    public decimal Balance { get; private set; }

    public bool IsActive { get; private set; }

    public BankAccount(string ownerName, decimal openingBalance)
    {
        OwnerName = ownerName;
        Balance = openingBalance < 0 ? 0 : openingBalance;
        IsActive = true;
    }

    public void Deposit(decimal amount)
    {
        if (!IsActive)
        {
            Console.WriteLine("Tai khoan da khoa.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("So tien nap khong hop le.");
            return;
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (!IsActive)
        {
            Console.WriteLine("Tai khoan da khoa.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("So tien rut khong hop le.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("So du khong du.");
            return;
        }

        Balance -= amount;
    }

    public void Close()
    {
        IsActive = false;
    }

    public void PrintStatus()
    {
        Console.WriteLine("Chu tai khoan: " + OwnerName);
        Console.WriteLine("So du: " + Balance);
        Console.WriteLine("Trang thai hoat dong: " + IsActive);
    }
}

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 03 - Properties");
        DemoAutoProperty();
        DemoPropertyKiemTraGiaTri();
        DemoPropertyChiDoc();
        DemoPropertyPrivateSet();
        DemoComputedProperty();
        DemoTinhHuongProduct();
        DemoTinhHuongStudent();
        DemoTinhHuongBankAccount();
        DemoSoSanhFieldVaProperty();
        TongKet();
    }

    static void InTieuDe(string title)
    {
        Console.WriteLine(new string('=', 70));
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 70));
    }

    static void InPhan(string name)
    {
        Console.WriteLine();
        Console.WriteLine("--- " + name + " ---");
    }

    static void DemoAutoProperty()
    {
        InPhan("1. Auto property");

        Product mouse = new Product("Chuot khong day", "Phu kien", 350000m, 12);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Category);
    }

    static void DemoPropertyKiemTraGiaTri()
    {
        InPhan("2. Property kiem tra gia tri");

        Product keyboard = new Product("Ban phim", "Phu kien", -50000m, 5);
        Console.WriteLine("Gia sau khi qua property: " + keyboard.Price);

        keyboard.Price = 790000m;
        Console.WriteLine("Gia hop le moi: " + keyboard.Price);
    }

    static void DemoPropertyChiDoc()
    {
        InPhan("3. Property chi doc tinh toan");

        Product book = new Product("Sach C#", "Sach", 120000m, 0);
        Console.WriteLine("Co san khong: " + book.IsAvailable);

        book.AddStock(7);
        Console.WriteLine("Co san sau khi nhap kho: " + book.IsAvailable);
    }

    static void DemoPropertyPrivateSet()
    {
        InPhan("4. Property private set");

        Product usb = new Product("USB 64GB", "Luu tru", 220000m, 10);
        Console.WriteLine("Ton kho ban dau: " + usb.Stock);

        usb.Sell(3);
        Console.WriteLine("Ton kho sau khi ban: " + usb.Stock);

        usb.AddStock(5);
        Console.WriteLine("Ton kho sau khi nhap them: " + usb.Stock);
    }

    static void DemoComputedProperty()
    {
        InPhan("5. Computed property");

        Student student = new Student("Tran Minh Anh", 8.7);
        student.PrintSummary();

        student.Average = 9.3;
        Console.WriteLine("Xep loai sau khi cap nhat diem: " + student.Rank);
    }

    static void DemoTinhHuongProduct()
    {
        InPhan("6. Tinh huong product");

        Product laptop = new Product("Laptop hoc lap trinh", "May tinh", 16500000m, 4);
        laptop.PrintInfo();
        laptop.Sell(1);
        laptop.PrintInfo();
    }

    static void DemoTinhHuongStudent()
    {
        InPhan("7. Tinh huong student");

        Student student = new Student("Le Bao Ngoc", 11.5);
        student.PrintSummary();
    }

    static void DemoTinhHuongBankAccount()
    {
        InPhan("8. Tinh huong bank account");

        BankAccount account = new BankAccount("Pham Quoc Viet", 5000000m);
        account.PrintStatus();
        account.Deposit(1500000m);
        account.Withdraw(2000000m);
        account.PrintStatus();
        account.Close();
        account.Deposit(100000m);
        account.PrintStatus();
    }

    static void DemoSoSanhFieldVaProperty()
    {
        InPhan("9. So sanh field va property");

        Console.WriteLine("Field la bien trong class.");
        Console.WriteLine("Property la cach truy cap co kiem soat vao du lieu.");
        Console.WriteLine("Property cho phep them rang buoc ma khong doi cach goi ben ngoai.");
        Console.WriteLine("Day la ly do property duoc uu tien hon field public.");
    }

    static void TongKet()
    {
        InPhan("10. Tong ket");

        Console.WriteLine("Property giup bao ve du lieu va giu class hop le.");
        Console.WriteLine("Auto property hop cho du lieu don gian.");
        Console.WriteLine("Property day du hop cho du lieu can kiem tra, tinh toan, hoac han che set.");
        Console.WriteLine("Hay uu tien property thay vi field public trong OOP.");
    }

    /*
    Ghi chu mo rong cho bai properties.
    Dong 01: Property la cau noi giua du lieu ben trong class va ben ngoai.
    Dong 02: No giong nhu mot cua ra vao co kiem soat.
    Dong 03: Neu dung field public truc tiep, moi noi deu sua duoc khong kiem soat.
    Dong 04: Day de dan den du lieu khong hop le.
    Dong 05: Vi du gia am, ton kho am, diem vuot 10.
    Dong 06: Property cho phep chan cac gia tri sai nay.
    Dong 07: Auto property la dang ngan gon cua property.
    Dong 08: Vi du public string Name { get; set; }.
    Dong 09: Day la lua chon tot khi chua can logic dac biet.
    Dong 10: Khi can logic, ta viet property day du voi field nen.
    Dong 11: Field nen la bien private dung de luu gia tri that.
    Dong 12: Getter tra ve gia tri.
    Dong 13: Setter xu ly du lieu truoc khi luu.
    Dong 14: private set cho phep doc ben ngoai nhung chi sua ben trong class.
    Dong 15: Day la cach rat hay de bao ve tinh nhat quan.
    Dong 16: Vi du so du chi duoc doi thong qua ham nap rut.
    Dong 17: Vi du ton kho chi duoc doi thong qua nhap kho va ban hang.
    Dong 18: Day la y tuong encapsulation trong OOP.
    Dong 19: Computed property la property khong luu truc tiep ma tinh tu du lieu khac.
    Dong 20: Vi du Rank duoc tinh tu Average.
    Dong 21: IsAvailable duoc tinh tu Stock.
    Dong 22: Cach nay giup tranh trung lap du lieu.
    Dong 23: Neu luu ca Stock va IsAvailable, co the chung mau thuan nhau.
    Dong 24: Neu tinh tu Stock, ta luon co ket qua nhat quan.
    Dong 25: Property giup class de mo rong ve sau.
    Dong 26: Hom nay Name la auto property, ngay mai co the them validate ma code ben ngoai khong doi.
    Dong 27: Day la loi ich lon cua abstraction.
    Dong 28: Nguoi dung class chi can biet cach goi, khong can biet ben trong.
    Dong 29: Trong bai nay, Product cho thay gia tri cua property rat thuc te.
    Dong 30: Gia va ton kho can duoc bao ve nghiem tuc.
    Dong 31: Student cho thay computed property danh cho xep loai.
    Dong 32: BankAccount cho thay private set rat hop voi he thong tai chinh.
    Dong 33: Property khong chi de du lieu dep, ma de mo hinh nghiep vu dung.
    Dong 34: Hay hoi: ben ngoai co nen set truong nay tu do khong?
    Dong 35: Neu cau tra loi la khong, hay dung private set hoac bo setter.
    Dong 36: Hay hoi tiep: gia tri nay co can rang buoc khong?
    Dong 37: Neu co, hay viet setter co validate.
    Dong 38: Hay hoi tiep: gia tri nay co tinh tu cai khac khong?
    Dong 39: Neu co, hay nghi den computed property.
    Dong 40: Day la 3 cau hoi quan trong khi thiet ke property.
    Dong 41: Loi pho bien la dat public set cho moi thu vi cho nhanh.
    Dong 42: Ve sau no lam class rat de bi sua sai.
    Dong 43: Loi pho bien khac la validate qua manh tay va im lang.
    Dong 44: Trong he thong that, ta co the throw exception hoac tra ve ket qua that bai.
    Dong 45: O bai co ban, in thong bao la du de hieu.
    Dong 46: Property cung co the ket hop voi constructor.
    Dong 47: Constructor co the dung property de tai su dung logic validate.
    Dong 48: Do la ly do file nay gan Price va Stock thong qua property trong constructor.
    Dong 49: Neu validate dat o setter, hay dung setter thay vi gan truc tiep field khi khoi tao.
    Dong 50: Nhu vay logic duoc nhat quan.
    Dong 51: Property la mot trong nhung vien gach quan trong nhat cua OOP C#.
    Dong 52: Khi hoc framework, ban se gap property o khap noi.
    Dong 53: Vi du model, entity, DTO, view model, settings.
    Dong 54: Do do can hoc chac tu bai nay.
    Dong 55: Bai tap tu luyen 1: tao class Book co Title, Price, Stock.
    Dong 56: Bai tap tu luyen 2: tao class Employee co Salary khong am.
    Dong 57: Bai tap tu luyen 3: tao class Course co property IsOpen tinh tu Slot.
    Dong 58: Bai tap tu luyen 4: tao class Phone co BatteryLevel tu 0 den 100.
    Dong 59: Bai tap tu luyen 5: tao class Room co Capacity chi doc tu ben ngoai.
    Dong 60: Moi bai hay tu hoi property nao can get, set, private set, hay chi doc.
    Dong 61: Day la cach ren tu duy thiet ke.
    Dong 62: Ten property nen la danh tu ro nghia.
    Dong 63: Ten method nen la dong tu mo ta hanh dong.
    Dong 64: Vi du Stock la property, Sell la method.
    Dong 65: Day la cach dat ten dung tinh than OOP.
    Dong 66: Neu du lieu thay doi do hanh dong nghiep vu, hay nghi den method.
    Dong 67: Neu du lieu chi can truy cap va co the co rang buoc, hay nghi den property.
    Dong 68: Day la ranh gioi ban nen luyen nhan ra.
    Dong 69: Cang hieu ro property, ban cang viet class chat che hon.
    Dong 70: Ket thuc ghi chu mo rong cho bai properties.
    */
}
