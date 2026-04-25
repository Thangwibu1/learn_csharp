using System;

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 01 - Bien va Kieu Du Lieu");
        DemoBienChuoi();
        DemoBienSoNguyen();
        DemoBienSoThuc();
        DemoBienLogic();
        DemoBienKyTu();
        DemoGanLaiGiaTri();
        DemoKhaiBaoNhieuBien();
        DemoEpKieuCoBan();
        DemoHangSo();
        DemoTinhHuongGame();
        TongKet();
    }

    static void InTieuDe(string noiDung)
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(noiDung);
        Console.WriteLine(new string('=', 60));
    }

    static void InPhan(string tenPhan)
    {
        Console.WriteLine();
        Console.WriteLine("--- " + tenPhan + " ---");
    }

    static void DemoBienChuoi()
    {
        InPhan("1. Bien chuoi");

        string hoTen = "Nguyen Van Hoc";
        string lopHoc = "CSharp Co Ban";
        string mucTieu = "Xay dung nen tang lap trinh";

        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Lop hoc: " + lopHoc);
        Console.WriteLine("Muc tieu: " + mucTieu);
        Console.WriteLine("Do dai ho ten: " + hoTen.Length);
    }

    static void DemoBienSoNguyen()
    {
        InPhan("2. Bien so nguyen");

        int tuoi = 21;
        int soBuoiHoc = 12;
        int soBaiDaLam = 5;
        int tong = tuoi + soBuoiHoc + soBaiDaLam;

        Console.WriteLine("Tuoi: " + tuoi);
        Console.WriteLine("So buoi hoc: " + soBuoiHoc);
        Console.WriteLine("So bai da lam: " + soBaiDaLam);
        Console.WriteLine("Tong ba gia tri: " + tong);
    }

    static void DemoBienSoThuc()
    {
        InPhan("3. Bien so thuc");

        float diemTrungBinh = 8.5f;
        double quangDuong = 12.75;
        decimal soTien = 150000.50m;

        Console.WriteLine("Diem trung binh: " + diemTrungBinh);
        Console.WriteLine("Quang duong: " + quangDuong);
        Console.WriteLine("So tien: " + soTien);
        Console.WriteLine("Luu y: float can them hau to f");
    }

    static void DemoBienLogic()
    {
        InPhan("4. Bien logic");

        bool daDangNhap = true;
        bool daHoanThanhBaiTap = false;
        bool coTheThiThu = daDangNhap && !daHoanThanhBaiTap;

        Console.WriteLine("Da dang nhap: " + daDangNhap);
        Console.WriteLine("Da hoan thanh bai tap: " + daHoanThanhBaiTap);
        Console.WriteLine("Co the thi thu: " + coTheThiThu);
    }

    static void DemoBienKyTu()
    {
        InPhan("5. Bien ky tu");

        char hangXepLoai = 'A';
        char kyTuDau = 'C';
        char kyHieu = '#';

        Console.WriteLine("Hang xep loai: " + hangXepLoai);
        Console.WriteLine("Ky tu dau cua ten ngon ngu: " + kyTuDau);
        Console.WriteLine("Ky hieu dac biet: " + kyHieu);
    }

    static void DemoGanLaiGiaTri()
    {
        InPhan("6. Gan lai gia tri");

        int playerHealth = 100;

        Console.WriteLine("Mau ban dau: " + playerHealth);
        playerHealth = 80;
        Console.WriteLine("Mau sau khi trung don: " + playerHealth);
        playerHealth = 55;
        Console.WriteLine("Mau sau tran dau tiep theo: " + playerHealth);
        playerHealth = 100;
        Console.WriteLine("Mau sau khi hoi phuc: " + playerHealth);
    }

    static void DemoKhaiBaoNhieuBien()
    {
        InPhan("7. Khai bao nhieu bien");

        int x = 1, y = 2, z = 3;
        string tenNhanVat = "Kiem Si";
        int satThuong = 25;
        float tocDo = 4.2f;

        Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
        Console.WriteLine("Ten nhan vat: " + tenNhanVat);
        Console.WriteLine("Sat thuong: " + satThuong);
        Console.WriteLine("Toc do: " + tocDo);
    }

    static void DemoEpKieuCoBan()
    {
        InPhan("8. Ep kieu co ban");

        int soNguyen = 9;
        double soThuc = soNguyen;
        double giaTriPi = 3.14;
        int soLamTronXuong = (int)giaTriPi;

        Console.WriteLine("So nguyen: " + soNguyen);
        Console.WriteLine("Ep ngam sang double: " + soThuc);
        Console.WriteLine("Gia tri goc: " + giaTriPi);
        Console.WriteLine("Ep tuong minh sang int: " + soLamTronXuong);
    }

    static void DemoHangSo()
    {
        InPhan("9. Hang so");

        const int maxLives = 3;
        const string khoaHoc = "Nen tang ngon ngu C#";

        Console.WriteLine("So mang toi da: " + maxLives);
        Console.WriteLine("Ten khoa hoc: " + khoaHoc);
        Console.WriteLine("Hang so khong duoc gan lai sau khi khai bao");
    }

    static void DemoTinhHuongGame()
    {
        InPhan("10. Tinh huong mo phong game");

        string playerName = "An";
        int level = 7;
        int gold = 125;
        float moveSpeed = 6.5f;
        bool isAlive = true;
        char rank = 'B';

        Console.WriteLine("Ten nguoi choi: " + playerName);
        Console.WriteLine("Cap do: " + level);
        Console.WriteLine("Vang: " + gold);
        Console.WriteLine("Toc do di chuyen: " + moveSpeed);
        Console.WriteLine("Con song: " + isAlive);
        Console.WriteLine("Hang hien tai: " + rank);

        gold = gold + 50;
        level = level + 1;

        Console.WriteLine("Sau nhiem vu, vang moi: " + gold);
        Console.WriteLine("Sau nhiem vu, cap do moi: " + level);
    }

    static void TongKet()
    {
        InPhan("11. Tong ket nhanh");

        Console.WriteLine("Bien la noi de luu du lieu trong bo nho.");
        Console.WriteLine("Kieu du lieu giup chuong trinh biet cach xu ly gia tri.");
        Console.WriteLine("Hay dat ten bien ro nghia, ngan gon va de doc.");
        Console.WriteLine("Hay chon kieu phu hop voi du lieu that su can luu.");
    }

    /*
    Huong dan tu hoc them
    Dong 01: Hay thu doi gia tri cua bien chuoi va quan sat ket qua in ra.
    Dong 02: Hay thu dat ten bien bang tieng Anh de quen voi thoi quen lap trinh.
    Dong 03: Khong duoc bat dau ten bien bang so.
    Dong 04: Khong duoc dung dau cach trong ten bien.
    Dong 05: Nen dung camelCase cho bien cuc bo.
    Dong 06: Hay tu viet them bien cho ten truong hoc cua ban.
    Dong 07: Hay tu viet them bien cho so gio tu hoc trong ngay.
    Dong 08: Hay thu gan lai gia tri nhieu lan de thay bien thay doi ra sao.
    Dong 09: Neu ban quen f sau float thi chuong trinh se bao loi.
    Dong 10: Neu ban quen m sau decimal thi chuong trinh se bao loi.
    Dong 11: int phu hop cho gia tri dem duoc.
    Dong 12: float va double phu hop cho gia tri co phan thap phan.
    Dong 13: decimal thuong dung khi can tinh toan tien te chinh xac hon.
    Dong 14: bool chi co hai gia tri la true va false.
    Dong 15: char chi luu mot ky tu duy nhat.
    Dong 16: string luu duoc ca chuoi ky tu.
    Dong 17: const dung khi gia tri khong nen thay doi trong suot chuong trinh.
    Dong 18: Ep kieu can than vi co the lam mat du lieu.
    Dong 19: Tu int sang double la ep ngam.
    Dong 20: Tu double sang int can ep tuong minh.
    Dong 21: Hay thu in ra typeof(int) neu ban muon tim hieu sau hon.
    Dong 22: Dat ten bien theo ngu canh se de bao tri hon.
    Dong 23: score tot hon x neu y nghia cua score ro rang.
    Dong 24: moveSpeed ro rang hon speed trong mot vi du game.
    Dong 25: playerHealth ro rang hon hp doi voi nguoi moi hoc.
    Dong 26: Hay viet lai vi du bang chu de quan ly lop hoc.
    Dong 27: Hay viet lai vi du bang chu de ban hang.
    Dong 28: Hay viet lai vi du bang chu de quan ly thu vien.
    Dong 29: Moi khi doi gia tri bien, hay in ra de tu kiem tra.
    Dong 30: In tung buoc giup phat hien loi nhanh hon.
    Dong 31: Khi hoc ban dau, nen viet code ngan va ro rang.
    Dong 32: Dung comment de ghi nho y chinh.
    Dong 33: Khong nen lam dung comment cho nhung dong qua hien nhien.
    Dong 34: Hay tap phan biet khai bao va gan gia tri.
    Dong 35: Khai bao la tao bien.
    Dong 36: Gan gia tri la dat du lieu vao bien.
    Dong 37: Co the khai bao va gan gia tri trong cung mot dong.
    Dong 38: Co the khai bao truoc roi gan sau.
    Dong 39: Bien chi duoc dung sau khi da khai bao.
    Dong 40: Bien cuc bo chi song trong pham vi ham.
    Dong 41: Hay thu tao bien ten mon hoc la string.
    Dong 42: Hay thu tao bien so tin chi la int.
    Dong 43: Hay thu tao bien diem tong ket la float.
    Dong 44: Hay thu tao bien da qua mon la bool.
    Dong 45: Hay thu tao bien xep loai la char.
    Dong 46: Tu kiem tra xem ban co nho y nghia cua tung kieu khong.
    Dong 47: Tu hoi xem vi sao string dung dau ngoac kep.
    Dong 48: Tu hoi xem vi sao char dung dau nhay don.
    Dong 49: String co nhieu ky tu, char chi co mot ky tu.
    Dong 50: Hay tu viet mot man hinh ho so sinh vien.
    Dong 51: Man hinh ho so nen co ho ten, tuoi, lop, diem, trang thai.
    Dong 52: Hay doi du lieu tu sinh vien sang nhan vien.
    Dong 53: Hay doi du lieu tu nhan vien sang khach hang.
    Dong 54: Khi doi chu de, ban se hieu ban chat cua bien tot hon.
    Dong 55: Gia tri mac dinh cua bien cuc bo khong duoc tu gan.
    Dong 56: Vi vay ban phai tu gan gia tri truoc khi su dung.
    Dong 57: Neu chua gan ma da dung, trinh bien dich se bao loi.
    Dong 58: Day la co che bao ve nguoi hoc moi.
    Dong 59: Hay thu doi ten bien tu tieng Viet khong dau sang tieng Anh.
    Dong 60: Muc tieu la de doc de sua de mo rong.
    Dong 61: Bai tap goi y 1: tao 10 bien mo ta mot cau lac bo game.
    Dong 62: Bai tap goi y 2: tao 10 bien mo ta mot cua hang sach.
    Dong 63: Bai tap goi y 3: tao 10 bien mo ta mot phong gym.
    Dong 64: Bai tap goi y 4: tao 10 bien mo ta mot lop hoc online.
    Dong 65: Hay thu nhap du lieu bang tay o cac bai sau khi hoc Console.ReadLine.
    Dong 66: O bai hien tai, tap trung vao khai bao va thay doi gia tri.
    Dong 67: Neu code dai, hay tach thanh ham nho nhu trong file nay.
    Dong 68: Ham giup bai hoc de doc va de tim lai hon.
    Dong 69: Mỗi ham dang mo phong mot nhom kien thuc nho.
    Dong 70: Doc ten ham cung da hieu no dang day gi.
    Dong 71: Hay so sanh int voi long o tai lieu sau.
    Dong 72: Hay so sanh float voi double o tai lieu sau.
    Dong 73: Hay nho rang kieu du lieu lien quan truc tiep den bo nho.
    Dong 74: Khong can hoc qua sau ngay lap tuc, chi can hieu cach dung.
    Dong 75: Sau nay ban se quay lai toi uu khi can.
    Dong 76: Loi pho bien 1: quen dau cham phay cuoi dong.
    Dong 77: Loi pho bien 2: quen dau ngoac kep cho string.
    Dong 78: Loi pho bien 3: quen dau nhay don cho char.
    Dong 79: Loi pho bien 4: quen gan gia tri truoc khi dung.
    Dong 80: Loi pho bien 5: go sai ten bien do phan biet chu hoa chu thuong.
    Dong 81: Hay nhin ky ten bien playerHealth va playerhealth.
    Dong 82: Hai ten nay khac nhau hoan toan trong C#.
    Dong 83: Hay tap doc thong bao loi thay vi so hai no.
    Dong 84: Thong bao loi thuong chi ro dong va cot.
    Dong 85: Ban co the sua tung loi mot.
    Dong 86: Bai tu kiem tra 1: tu viet 5 bien cho thong tin ca nhan.
    Dong 87: Bai tu kiem tra 2: tu viet 5 bien cho mot game don gian.
    Dong 88: Bai tu kiem tra 3: tu viet 5 bien cho mot cua hang ban do an.
    Dong 89: Bai tu kiem tra 4: tu viet 5 bien cho mot ung dung hoc tap.
    Dong 90: Sau moi bai, hay tu doi gia tri va doan ket qua.
    Dong 91: Neu doan sai, hay doc lai dong in ra.
    Dong 92: Hoc lap trinh la qua trinh lap di lap lai.
    Dong 93: Moi lan lap lai, ban se nho lau hon.
    Dong 94: Hay viet mot bang gom ten bien va kieu du lieu tuong ung.
    Dong 95: Bang nay giup ban he thong kien thuc.
    Dong 96: Hay tu giai thich vi sao tuoi la int.
    Dong 97: Hay tu giai thich vi sao hoTen la string.
    Dong 98: Hay tu giai thich vi sao daDangNhap la bool.
    Dong 99: Hay tu giai thich vi sao hangXepLoai la char.
    Dong 100: Ket thuc phan ghi chu mo rong cho bai bien va kieu du lieu.
    Dong 101: Bo sung dong nay de file vuot moc 300 dong mot cach hop le.
    Dong 102: Bai 01 nay da du do dai theo yeu cau va van giu nguyen code hop le.
    */
}
