using System;

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 03 - Cau truc if else");
        DemoIfDon();
        DemoIfElseCoBan();
        DemoElseIfNhieuNhanh();
        DemoKiemTraDangNhap();
        DemoXepLoaiHocLuc();
        DemoKiemTraSoChanLe();
        DemoKiemTraTuoi();
        DemoTinhGiaShip();
        DemoKiemTraMauNhanVat();
        DemoKiemTraQuyenTruyCap();
        DemoIfLongNhau();
        DemoDanhGiaDonHang();
        DemoDanhGiaThoiTiet();
        DemoKiemTraKhuyenMai();
        DemoMoKhoaManChoi();
        DemoTinhCuocDienThoai();
        DemoBaoDongPin();
        DemoKetHopDieuKienPhucTap();
        TongKet();
    }

    static void InTieuDe(string noiDung)
    {
        Console.WriteLine(new string('=', 70));
        Console.WriteLine(noiDung);
        Console.WriteLine(new string('=', 70));
    }

    static void InPhan(string tenPhan)
    {
        Console.WriteLine();
        Console.WriteLine("--- " + tenPhan + " ---");
    }

    static void DemoIfDon()
    {
        InPhan("1. if don");

        int score = 95;

        if (score >= 90)
        {
            Console.WriteLine("Ban dat moc xuat sac.");
        }

        Console.WriteLine("Ket thuc vi du if don.");
    }

    static void DemoIfElseCoBan()
    {
        InPhan("2. if else co ban");

        int playerHealth = 35;

        if (playerHealth <= 0)
        {
            Console.WriteLine("Nhan vat da guc.");
        }
        else
        {
            Console.WriteLine("Nhan vat van con song.");
        }
    }

    static void DemoElseIfNhieuNhanh()
    {
        InPhan("3. else if nhieu nhanh");

        int gold = 80;

        if (gold >= 200)
        {
            Console.WriteLine("Co the mua vat pham hiem.");
        }
        else if (gold >= 100)
        {
            Console.WriteLine("Co the mua vat pham trung cap.");
        }
        else if (gold >= 50)
        {
            Console.WriteLine("Co the mua thuoc hoi phuc.");
        }
        else
        {
            Console.WriteLine("Can kiem them vang.");
        }
    }

    static void DemoKiemTraDangNhap()
    {
        InPhan("4. Kiem tra dang nhap");

        bool daNhapDungMatKhau = true;
        bool daNhapDungOtp = false;
        bool dangBiKhoa = false;

        if (dangBiKhoa)
        {
            Console.WriteLine("Tai khoan da bi khoa.");
        }
        else if (daNhapDungMatKhau && daNhapDungOtp)
        {
            Console.WriteLine("Dang nhap thanh cong.");
        }
        else
        {
            Console.WriteLine("Thong tin dang nhap chua day du.");
        }
    }

    static void DemoXepLoaiHocLuc()
    {
        InPhan("5. Xep loai hoc luc");

        double average = 8.4;

        if (average >= 9.0)
        {
            Console.WriteLine("Xep loai Xuat sac.");
        }
        else if (average >= 8.0)
        {
            Console.WriteLine("Xep loai Gioi.");
        }
        else if (average >= 6.5)
        {
            Console.WriteLine("Xep loai Kha.");
        }
        else if (average >= 5.0)
        {
            Console.WriteLine("Xep loai Trung binh.");
        }
        else
        {
            Console.WriteLine("Can co gang them.");
        }
    }

    static void DemoKiemTraSoChanLe()
    {
        InPhan("6. Kiem tra so chan le");

        int number = 27;

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " la so chan.");
        }
        else
        {
            Console.WriteLine(number + " la so le.");
        }
    }

    static void DemoKiemTraTuoi()
    {
        InPhan("7. Kiem tra tuoi");

        int age = 17;

        if (age >= 18)
        {
            Console.WriteLine("Du tuoi dang ky.");
        }
        else
        {
            Console.WriteLine("Chua du tuoi dang ky.");
        }
    }

    static void DemoTinhGiaShip()
    {
        InPhan("8. Tinh gia ship");

        decimal orderTotal = 280000m;
        decimal shippingFee;

        if (orderTotal >= 300000m)
        {
            shippingFee = 0m;
        }
        else if (orderTotal >= 150000m)
        {
            shippingFee = 15000m;
        }
        else
        {
            shippingFee = 30000m;
        }

        Console.WriteLine("Phi ship: " + shippingFee);
    }

    static void DemoKiemTraMauNhanVat()
    {
        InPhan("9. Kiem tra mau nhan vat");

        int hp = 18;

        if (hp <= 0)
        {
            Console.WriteLine("Nhan vat da guc.");
        }
        else if (hp <= 20)
        {
            Console.WriteLine("Canh bao: mau rat thap.");
        }
        else if (hp <= 50)
        {
            Console.WriteLine("Mau dang o muc nguy hiem.");
        }
        else
        {
            Console.WriteLine("Trang thai on dinh.");
        }
    }

    static void DemoKiemTraQuyenTruyCap()
    {
        InPhan("10. Kiem tra quyen truy cap");

        bool isAdmin = false;
        bool isModerator = true;
        bool isSuspended = false;

        if (isSuspended)
        {
            Console.WriteLine("Tai khoan dang tam khoa.");
        }
        else if (isAdmin)
        {
            Console.WriteLine("Cho phep vao khu vuc quan tri.");
        }
        else if (isModerator)
        {
            Console.WriteLine("Cho phep vao khu vuc quan ly noi dung.");
        }
        else
        {
            Console.WriteLine("Chi duoc dung khu vuc thong thuong.");
        }
    }

    static void DemoIfLongNhau()
    {
        InPhan("11. if long nhau");

        bool hasAccount = true;
        bool isVerified = true;
        decimal balance = 120000m;

        if (hasAccount)
        {
            Console.WriteLine("Nguoi dung da co tai khoan.");

            if (isVerified)
            {
                Console.WriteLine("Tai khoan da xac thuc.");

                if (balance >= 100000m)
                {
                    Console.WriteLine("Du dieu kien dang ky goi nang cao.");
                }
                else
                {
                    Console.WriteLine("Can nap them tien de nang cap.");
                }
            }
            else
            {
                Console.WriteLine("Can xac thuc tai khoan truoc.");
            }
        }
        else
        {
            Console.WriteLine("Can tao tai khoan moi.");
        }
    }

    static void DemoDanhGiaDonHang()
    {
        InPhan("12. Danh gia don hang");

        int itemCount = 6;

        if (itemCount == 0)
        {
            Console.WriteLine("Gio hang dang trong.");
        }
        else if (itemCount < 3)
        {
            Console.WriteLine("Don hang nho.");
        }
        else if (itemCount < 8)
        {
            Console.WriteLine("Don hang vua.");
        }
        else
        {
            Console.WriteLine("Don hang lon.");
        }
    }

    static void DemoDanhGiaThoiTiet()
    {
        InPhan("13. Danh gia thoi tiet");

        int temperature = 33;
        bool isRaining = false;

        if (isRaining)
        {
            Console.WriteLine("Nen mang o.");
        }
        else if (temperature >= 35)
        {
            Console.WriteLine("Troi rat nong.");
        }
        else if (temperature >= 28)
        {
            Console.WriteLine("Troi am.");
        }
        else
        {
            Console.WriteLine("Troi mat.");
        }
    }

    static void DemoKiemTraKhuyenMai()
    {
        InPhan("14. Kiem tra khuyen mai");

        decimal amount = 520000m;
        bool isVip = false;

        if (isVip && amount >= 300000m)
        {
            Console.WriteLine("Nhan khuyen mai VIP.");
        }
        else if (amount >= 500000m)
        {
            Console.WriteLine("Nhan voucher mua hang.");
        }
        else
        {
            Console.WriteLine("Chua dat moc khuyen mai.");
        }
    }

    static void DemoMoKhoaManChoi()
    {
        InPhan("15. Mo khoa man choi");

        int completedStars = 28;
        bool clearedBoss = true;

        if (completedStars >= 30)
        {
            Console.WriteLine("Mo khoa man choi moi nhờ du sao.");
        }
        else if (clearedBoss)
        {
            Console.WriteLine("Mo khoa man choi moi nho ha boss.");
        }
        else
        {
            Console.WriteLine("Can tiep tuc choi them.");
        }
    }

    static void DemoTinhCuocDienThoai()
    {
        InPhan("16. Tinh cuoc dien thoai");

        int minutes = 135;
        decimal totalCost;

        if (minutes <= 50)
        {
            totalCost = minutes * 800m;
        }
        else if (minutes <= 100)
        {
            totalCost = 50 * 800m + (minutes - 50) * 700m;
        }
        else
        {
            totalCost = 50 * 800m + 50 * 700m + (minutes - 100) * 600m;
        }

        Console.WriteLine("Tong cuoc: " + totalCost);
    }

    static void DemoBaoDongPin()
    {
        InPhan("17. Bao dong pin");

        int battery = 14;
        bool isCharging = false;

        if (battery <= 5 && !isCharging)
        {
            Console.WriteLine("Pin rat yeu, can sac ngay.");
        }
        else if (battery <= 20 && !isCharging)
        {
            Console.WriteLine("Pin dang thap.");
        }
        else
        {
            Console.WriteLine("Trang thai pin binh thuong.");
        }
    }

    static void DemoKetHopDieuKienPhucTap()
    {
        InPhan("18. Ket hop dieu kien phuc tap");

        int level = 16;
        int power = 2400;
        bool hasGuild = true;
        bool isBanned = false;

        if (!isBanned && ((level >= 15 && power >= 2000) || hasGuild))
        {
            Console.WriteLine("Du dieu kien tham gia su kien.");
        }
        else
        {
            Console.WriteLine("Chua du dieu kien tham gia su kien.");
        }
    }

    static void TongKet()
    {
        InPhan("19. Tong ket");

        Console.WriteLine("if dung khi chi co mot nhanh can thuc hien neu dieu kien dung.");
        Console.WriteLine("if else dung khi co hai huong xu ly ro rang.");
        Console.WriteLine("else if dung khi can nhieu muc phan loai.");
        Console.WriteLine("Hay dat dieu kien tu muc dac biet hoac chat che den muc rong hon.");
        Console.WriteLine("Hay test voi gia tri canh bien de tranh loi logic.");
    }

    /*
    Ghi chu mo rong cho bai if else.
    Dong 01: if la cong cu ra quyet dinh co ban nhat trong lap trinh.
    Dong 02: Moi khi co cau hoi neu...thi..., ban nghieng ve if.
    Dong 03: Dieu kien trong if phai tra ve bool.
    Dong 04: Bool chi co hai gia tri: true va false.
    Dong 05: Ban co the tao bool truc tiep hoac qua phep so sanh.
    Dong 06: if (score >= 5) la mot bieu thuc bool.
    Dong 07: else duoc chay khi dieu kien if la false.
    Dong 08: else if cho phep them nhieu muc phan nhanh.
    Dong 09: Thu tu viet else if rat quan trong.
    Dong 10: Dieu kien rong dat len tren co the che mat dieu kien hep o duoi.
    Dong 11: Vi du neu viet >= 5 truoc >= 8 thi muc >= 8 se khong den duoc.
    Dong 12: Day la loi logic pho bien cua nguoi moi hoc.
    Dong 13: Hay viet muc cao nhat truoc, muc thap hon sau.
    Dong 14: Neu logic khong theo thu tu muc do, hay doc lai de bai ky.
    Dong 15: if long nhau hop khi dieu kien ben trong phu thuoc vao ben ngoai.
    Dong 16: Tuy nhien long qua sau se kho doc.
    Dong 17: Khi can, hay tach thanh bien bool trung gian.
    Dong 18: Bien bool trung gian giup dat ten cho y nghia nghiep vu.
    Dong 19: Vi du canJoinEvent thay cho bieu thuc dai.
    Dong 20: Ban nen test nhieu truong hop du lieu.
    Dong 21: Truong hop 1 la du dieu kien.
    Dong 22: Truong hop 2 la thieu mot dieu kien.
    Dong 23: Truong hop 3 la dung sat moc bien.
    Dong 24: Gia tri canh bien la rat quan trong voi if else.
    Dong 25: Vi du diem 4.9, 5.0, 5.1.
    Dong 26: Vi du pin 20, 21, 19.
    Dong 27: Vi du tuoi 17, 18, 19.
    Dong 28: Cac gia tri nay giup ban tim loi >= hay >.
    Dong 29: Loi pho bien la quen dau ngoac nhon sau if.
    Dong 30: Loi pho bien khac la quen ngoac nhon mo dong lenh.
    Dong 31: O C#, nen giu ngoac nhon day du de code an toan hon.
    Dong 32: Khong nen bo ngoac nhon du chi co mot dong.
    Dong 33: Dieu nay giup tranh loi khi them code ve sau.
    Dong 34: Ten bien trong dieu kien can ro nghia.
    Dong 35: Vi du isLoggedIn de doc hon x.
    Dong 36: Vi du hasPermission de doc hon y.
    Dong 37: Hay doc dieu kien thanh loi noi.
    Dong 38: Vi du if (age >= 18) doc la neu tuoi lon hon hoac bang 18.
    Dong 39: Neu doc khong tron cau, co the bieu thuc dang dat ten bien kem.
    Dong 40: Dieu kien phuc tap nen duoc them ngoac don de ro nhom.
    Dong 41: Mặc du C# co thu tu uu tien logic, ngoac van de doc hon.
    Dong 42: && uu tien hon || trong nhieu ngon ngu.
    Dong 43: Nhung nguoi doc khong nen phai nho tat ca de hieu code cua ban.
    Dong 44: Hay viet theo cach ro nghia nhat, khong chi ngan nhat.
    Dong 45: Bai nay rat quan trong truoc khi hoc switch va vong lap.
    Dong 46: Nhieu game loop, kiem tra phat va UI deu dua tren if else.
    Dong 47: He thong dang nhap, phan quyen, khuyen mai cung vay.
    Dong 48: O thuc te, if else dung o gan moi luong nghiep vu.
    Dong 49: Vi du neu ton kho du thi giao hang, nguoc lai thong bao het hang.
    Dong 50: Vi du neu don hang dat moc thi mien phi ship.
    Dong 51: Vi du neu hoc vien dat diem thi qua mon.
    Dong 52: Khi code sai logic, chuong trinh van co the chay nhung cho ket qua sai.
    Dong 53: Day la ly do can test ky hon loi cu phap.
    Dong 54: Test bang tay la ky nang rat huu ich o giai doan dau.
    Dong 55: Ban co the lap bang voi cot dau vao va cot ket qua mong doi.
    Dong 56: Sau do doi chieu voi ket qua in ra.
    Dong 57: Neu lech, hay xem nhanh nao dang bat nham.
    Dong 58: Console.WriteLine trong moi nhanh la cach debug don gian.
    Dong 59: Tuy nhien trong code that, khong nen de qua nhieu log khong can thiet.
    Dong 60: Bai tap tu luyen 1: xep loai diem rèn luyen.
    Dong 61: Bai tap tu luyen 2: kiem tra du dieu kien nhan hoc bong.
    Dong 62: Bai tap tu luyen 3: tinh phi giao hang theo quan duong.
    Dong 63: Bai tap tu luyen 4: kiem tra xe co du xang di tiep khong.
    Dong 64: Bai tap tu luyen 5: thong bao muc do nghen mang theo toc do internet.
    Dong 65: Bai tap tu luyen 6: danh gia suc khoe dua tren nhip tim.
    Dong 66: Bai tap tu luyen 7: xep loai nhan vien theo KPI.
    Dong 67: Bai tap tu luyen 8: phan loai don hang nho vua lon.
    Dong 68: Bai tap tu luyen 9: kiem tra quyen mo file.
    Dong 69: Bai tap tu luyen 10: phan loai nhiet do phong.
    Dong 70: Hay thu tu viet lai mot bai bang cach dung bien bool trung gian.
    Dong 71: Sau do viet lai bang dieu kien truc tiep.
    Dong 72: So sanh cach nao de doc hon voi ban.
    Dong 73: Khong phai luc nao it dong hon cung la tot hon.
    Dong 74: Code de bao tri can uu tien su ro rang.
    Dong 75: Neu ban can giai thich code qua lau, co the code chua ro.
    Dong 76: Hay dat cau hoi: nguoi khac doc 5 giay co hieu khong?
    Dong 77: Neu khong, hay doi ten bien hoac tach dieu kien.
    Dong 78: Muc tieu cuoi cung la viet dung va de hieu.
    Dong 79: Bai if else tot se la nen tang cho tu duy thuat toan.
    Dong 80: Ket thuc ghi chu mo rong cho bai if else.
    */
}
