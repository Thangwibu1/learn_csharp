using System;

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 04 - Vong lap");
        DemoForCoBan();
        DemoForDemNguoc();
        DemoForBuocNhay();
        DemoWhileCoBan();
        DemoDoWhile();
        DemoTinhTongBangFor();
        DemoTinhTongSoChan();
        DemoBangCuuChuong();
        DemoBreak();
        DemoContinue();
        DemoLongVongLap();
        DemoLapVoiChuoi();
        DemoNhapVaiTroGiaLap();
        DemoTimSoDauTienChiaHet();
        DemoThongKeTienTietKiem();
        DemoMoPhongNapLaiNangLuong();
        DemoInMauSao();
        DemoKiemTraSoNguyenToDonGian();
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

    static void DemoForCoBan()
    {
        InPhan("1. for co ban");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Lan lap thu: " + i);
        }
    }

    static void DemoForDemNguoc()
    {
        InPhan("2. for dem nguoc");

        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine("Dem nguoc: " + i);
        }
    }

    static void DemoForBuocNhay()
    {
        InPhan("3. for buoc nhay");

        for (int i = 0; i <= 10; i += 2)
        {
            Console.WriteLine("So chan: " + i);
        }
    }

    static void DemoWhileCoBan()
    {
        InPhan("4. while co ban");

        int count = 1;

        while (count <= 4)
        {
            Console.WriteLine("while lan: " + count);
            count++;
        }
    }

    static void DemoDoWhile()
    {
        InPhan("5. do while");

        int turn = 1;

        do
        {
            Console.WriteLine("Luot do while: " + turn);
            turn++;
        }
        while (turn <= 3);
    }

    static void DemoTinhTongBangFor()
    {
        InPhan("6. Tinh tong bang for");

        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Console.WriteLine("Sau khi cong " + i + ", tong = " + sum);
        }

        Console.WriteLine("Tong cuoi cung = " + sum);
    }

    static void DemoTinhTongSoChan()
    {
        InPhan("7. Tinh tong so chan");

        int sum = 0;

        for (int i = 2; i <= 20; i += 2)
        {
            sum += i;
        }

        Console.WriteLine("Tong so chan tu 2 den 20 = " + sum);
    }

    static void DemoBangCuuChuong()
    {
        InPhan("8. Bang cuu chuong 5");

        int n = 5;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }

    static void DemoBreak()
    {
        InPhan("9. break");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("Gap moc 6, dung vong lap.");
                break;
            }

            Console.WriteLine("Gia tri truoc khi break: " + i);
        }
    }

    static void DemoContinue()
    {
        InPhan("10. continue");

        for (int i = 1; i <= 7; i++)
        {
            if (i == 4)
            {
                Console.WriteLine("Bo qua so 4.");
                continue;
            }

            Console.WriteLine("In ra so: " + i);
        }
    }

    static void DemoLongVongLap()
    {
        InPhan("11. Long vong lap");

        for (int row = 1; row <= 3; row++)
        {
            for (int col = 1; col <= 4; col++)
            {
                Console.Write("[" + row + "," + col + "] ");
            }

            Console.WriteLine();
        }
    }

    static void DemoLapVoiChuoi()
    {
        InPhan("12. Lap voi chuoi");

        string text = "CSharp";

        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine("Ky tu tai vi tri " + i + " la " + text[i]);
        }
    }

    static void DemoNhapVaiTroGiaLap()
    {
        InPhan("13. Mo phong xu ly nhieu vai tro");

        string[] roles = { "Player", "Enemy", "NPC", "Merchant" };

        for (int i = 0; i < roles.Length; i++)
        {
            Console.WriteLine("Vai tro thu " + (i + 1) + ": " + roles[i]);
        }
    }

    static void DemoTimSoDauTienChiaHet()
    {
        InPhan("14. Tim so dau tien chia het");

        for (int i = 10; i <= 50; i++)
        {
            if (i % 7 == 0)
            {
                Console.WriteLine("So dau tien chia het cho 7 trong khoang la: " + i);
                break;
            }
        }
    }

    static void DemoThongKeTienTietKiem()
    {
        InPhan("15. Thong ke tien tiet kiem");

        decimal total = 0m;

        for (int month = 1; month <= 6; month++)
        {
            total += 500000m;
            Console.WriteLine("Thang " + month + ": tong tiet kiem = " + total);
        }
    }

    static void DemoMoPhongNapLaiNangLuong()
    {
        InPhan("16. Mo phong nap lai nang luong");

        int energy = 0;

        while (energy < 100)
        {
            energy += 25;
            Console.WriteLine("Nang luong hien tai: " + energy);
        }

        Console.WriteLine("Da nap day nang luong.");
    }

    static void DemoInMauSao()
    {
        InPhan("17. In mau sao");

        for (int row = 1; row <= 5; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    static void DemoKiemTraSoNguyenToDonGian()
    {
        InPhan("18. Kiem tra so nguyen to don gian");

        int number = 17;
        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(number + (isPrime ? " la so nguyen to." : " khong phai so nguyen to."));
    }

    static void TongKet()
    {
        InPhan("19. Tong ket");

        Console.WriteLine("Dung for khi biet ro so lan lap.");
        Console.WriteLine("Dung while khi lap cho den khi dieu kien khong con dung.");
        Console.WriteLine("Dung do while khi muon chay it nhat mot lan.");
        Console.WriteLine("Can luon cap nhat bien dem de tranh lap vo han.");
        Console.WriteLine("break dung de thoat som, continue dung de bo qua lan lap hien tai.");
    }

    /*
    Ghi chu mo rong cho bai vong lap.
    Dong 01: Vong lap giup lap lai mot khoi lenh nhieu lan.
    Dong 02: Neu khong co vong lap, ban phai viet lai cung mot lenh rat nhieu lan.
    Dong 03: for hop khi ban biet truoc so lan lap.
    Dong 04: while hop khi ban chi biet dieu kien dung den khi nao.
    Dong 05: do while hop khi muon khoi lenh chay toi thieu mot lan.
    Dong 06: Cau truc for gom khoi tao, dieu kien, va cap nhat.
    Dong 07: Cau truc while chi gom dieu kien, con cap nhat thuong viet trong than vong lap.
    Dong 08: Day la noi de xay ra lap vo han neu quen tang bien dem.
    Dong 09: Lap vo han la mot loi rat pho bien.
    Dong 10: Neu chuong trinh treo, hay kiem tra bien dem co thay doi khong.
    Dong 11: break dung de dung som vong lap khi da tim thay dieu can tim.
    Dong 12: continue dung de bo qua mot lan lap khong phu hop.
    Dong 13: Hai lenh nay rat huu ich nhung khong nen lam roi logic.
    Dong 14: Hay uu tien dieu kien ro rang truoc, break sau.
    Dong 15: Long vong lap co the tao bang, ma tran, mau hinh, lich.
    Dong 16: Tuy nhien long nhieu tang co the tang do phuc tap.
    Dong 17: Ban nen giu ten bien row, col, i, j ro nghia theo ngu canh.
    Dong 18: Vong lap rat hay di cung bien tong.
    Dong 19: Vi du tinh tong, dem so luong, tim gia tri lon nhat.
    Dong 20: Khi tinh tong, hay khoi tao bien sum truoc vong lap.
    Dong 21: Sau do cap nhat sum trong moi lan lap.
    Dong 22: Day la mot mau lap rat pho bien.
    Dong 23: Khi tim phan tu dau tien thoa dieu kien, break la hop ly.
    Dong 24: Khi can xu ly tat ca phan tu, khong nen break som.
    Dong 25: Moi vong lap nen co muc tieu ro rang.
    Dong 26: Neu vua tinh tong vua tim max vua in log, code se kho theo doi.
    Dong 27: Hay tach thanh nhieu vong lap neu can va neu du lieu nho.
    Dong 28: O muc co ban, uu tien su de hieu hon toi uu som.
    Dong 29: Vong lap voi chuoi cho phep truy cap tung ky tu.
    Dong 30: Vong lap voi mang cho phep duyet tung phan tu.
    Dong 31: Sau nay ban se gap foreach, nhung bai nay tap trung vao for va while.
    Dong 32: Kiem tra gioi han canh bien rat quan trong.
    Dong 33: Vi du i <= 5 khac voi i < 5.
    Dong 34: Mot dau = them hoac bot co the lam thieu hoac thua mot lan lap.
    Dong 35: Loi nay goi la off-by-one.
    Dong 36: Day la loi cuc ky pho bien trong vong lap.
    Dong 37: Hay ve ra day so de xac dinh dung sai.
    Dong 38: Vi du tu 1 den 5 nghia la 1,2,3,4,5.
    Dong 39: Vi du tu 0 den n-1 nghia la dung cho chi so mang.
    Dong 40: Dung Console.WriteLine de debug bien dem la cach de nhat.
    Dong 41: Neu thay gia tri lap khong doi, can xem lai cap nhat.
    Dong 42: Neu thay lap qua nhieu, xem lai dieu kien dung.
    Dong 43: Neu thay lap qua it, xem lai dieu kien dung som.
    Dong 44: Bai vong lap can thuc hanh rat nhieu moi quen.
    Dong 45: Moi bai nen thu doi diem bat dau, diem ket thuc, va buoc nhay.
    Dong 46: Vi du dem 1 den 10, 0 den 10, 10 den 1.
    Dong 47: Vi du nhay 1, nhay 2, nhay 5.
    Dong 48: Ban se thay cung mot cong cu nhung rat nhieu cach dung.
    Dong 49: Vong lap giup mo phong thoi gian, luot choi, thang, ngay.
    Dong 50: Vong lap cung giup xu ly danh sach du lieu.
    Dong 51: Trong game, no dung cho update doi tuong, spawn quai, dem thoi gian.
    Dong 52: Trong app, no dung cho duyet danh sach, tao bao cao, tinh tong.
    Dong 53: Moi bai toan lap nen co dieu kien dung hop ly.
    Dong 54: Khong nen phu thuoc vao break neu co the viet dieu kien tot hon.
    Dong 55: Tuy nhien break rat huu ich khi tim thay ket qua dau tien.
    Dong 56: Continue nen duoc dung de bo qua du lieu loi hoac truong hop dac biet.
    Dong 57: Neu dung continue qua nhieu, hay xem lai co nen dao dieu kien khong.
    Dong 58: Vong lap long nhau co the in bang cuu chuong day du.
    Dong 59: Cung co the in hinh tam giac, hinh chu nhat bang dau sao.
    Dong 60: Day la cach luyen rat tot de hieu row va col.
    Dong 61: Bai tap tu luyen 1: tinh tong tu 1 den n.
    Dong 62: Bai tap tu luyen 2: tinh tong so le trong khoang.
    Dong 63: Bai tap tu luyen 3: dem so chia het cho 3.
    Dong 64: Bai tap tu luyen 4: tim so nho nhat lon hon 100 chia het cho 9.
    Dong 65: Bai tap tu luyen 5: in bang cuu chuong 2 den 9.
    Dong 66: Bai tap tu luyen 6: in tam giac nguoc.
    Dong 67: Bai tap tu luyen 7: mo phong tiet kiem moi thang.
    Dong 68: Bai tap tu luyen 8: tim so nguyen to trong khoang nho.
    Dong 69: Bai tap tu luyen 9: in cac ky tu cua mot chuoi dao nguoc.
    Dong 70: Bai tap tu luyen 10: bo qua so chia het cho 4 khi in day.
    Dong 71: Hay viet comment du doan so lan lap truoc khi chay.
    Dong 72: Sau do doi chieu ket qua that.
    Dong 73: Ky nang nay giup ban manh hon rat nhieu o bai thuat toan.
    Dong 74: Neu thay bai kho, hay thu ve du lieu nho hon.
    Dong 75: Vi du thay vi 1000, hay thu 5 hoac 10.
    Dong 76: Khi hieu voi du lieu nho, moi nang len du lieu lon.
    Dong 77: Day la cach debug va hoc cuc ky hieu qua.
    Dong 78: Vong lap la ban than cua su kien tri lap trong may tinh.
    Dong 79: Nam chac bai nay se mo duong cho mang va thuat toan.
    Dong 80: Ket thuc ghi chu mo rong cho bai vong lap.
    */
}
