using System;

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 02 - Toan tu trong C#");
        DemoToanTuSoHocCoBan();
        DemoThuTuUuTien();
        DemoTangGiam();
        DemoGanKetHop();
        DemoSoSanh();
        DemoLogic();
        DemoKetHopSoSanhVaLogic();
        DemoToanTuBaNgoi();
        DemoChiaSoNguyenVaSoThuc();
        DemoToanTuPhanDu();
        DemoTinhTienTrongGame();
        DemoTinhGiaKhuyenMai();
        DemoKiemTraDangNhap();
        DemoToanTuVoiChuoi();
        DemoTinhDiemTrungBinh();
        DemoCapNhatTaiNguyen();
        DemoKiemTraPhanThuong();
        DemoTinhTocDoDiChuyen();
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

    static void DemoToanTuSoHocCoBan()
    {
        InPhan("1. Toan tu so hoc co ban");

        int a = 20;
        int b = 6;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        // Day la nhom toan tu duoc gap nhieu nhat khi lam viec voi so.
        // Chia so nguyen se cat bo phan thap phan o ket qua.
    }

    static void DemoThuTuUuTien()
    {
        InPhan("2. Thu tu uu tien");

        int ketQua1 = 2 + 3 * 4;
        int ketQua2 = (2 + 3) * 4;
        int ketQua3 = 20 - 8 / 2;
        int ketQua4 = (20 - 8) / 2;

        Console.WriteLine("2 + 3 * 4 = " + ketQua1);
        Console.WriteLine("(2 + 3) * 4 = " + ketQua2);
        Console.WriteLine("20 - 8 / 2 = " + ketQua3);
        Console.WriteLine("(20 - 8) / 2 = " + ketQua4);

        // Nhan va chia duoc tinh truoc cong va tru.
        // Dung ngoac don de code de doc va tranh nham lan.
    }

    static void DemoTangGiam()
    {
        InPhan("3. Toan tu tang giam");

        int level = 1;

        Console.WriteLine("Level ban dau: " + level);
        level++;
        Console.WriteLine("Sau level++: " + level);
        ++level;
        Console.WriteLine("Sau ++level: " + level);
        level--;
        Console.WriteLine("Sau level--: " + level);
        --level;
        Console.WriteLine("Sau --level: " + level);

        // Trong bieu thuc phuc tap, prefix va postfix co khac biet.
        // Trong bai co ban, hay uu tien viet tach rieng tung dong.
    }

    static void DemoGanKetHop()
    {
        InPhan("4. Toan tu gan ket hop");

        int score = 100;

        Console.WriteLine("Diem ban dau: " + score);
        score += 20;
        Console.WriteLine("Sau += 20: " + score);
        score -= 15;
        Console.WriteLine("Sau -= 15: " + score);
        score *= 2;
        Console.WriteLine("Sau *= 2: " + score);
        score /= 3;
        Console.WriteLine("Sau /= 3: " + score);
        score %= 5;
        Console.WriteLine("Sau %= 5: " + score);

        // Toan tu gan ket hop lam code gon hon va de doc hon.
    }

    static void DemoSoSanh()
    {
        InPhan("5. Toan tu so sanh");

        int currentHp = 45;
        int maxHp = 100;

        Console.WriteLine("currentHp == maxHp: " + (currentHp == maxHp));
        Console.WriteLine("currentHp != maxHp: " + (currentHp != maxHp));
        Console.WriteLine("currentHp > 0: " + (currentHp > 0));
        Console.WriteLine("currentHp >= 50: " + (currentHp >= 50));
        Console.WriteLine("currentHp < maxHp: " + (currentHp < maxHp));
        Console.WriteLine("currentHp <= 45: " + (currentHp <= 45));

        // Ket qua cua phep so sanh la bool: true hoac false.
    }

    static void DemoLogic()
    {
        InPhan("6. Toan tu logic");

        bool hasKey = true;
        bool isNearDoor = true;
        bool doorLocked = false;

        Console.WriteLine("hasKey && isNearDoor = " + (hasKey && isNearDoor));
        Console.WriteLine("hasKey && doorLocked = " + (hasKey && doorLocked));
        Console.WriteLine("hasKey || doorLocked = " + (hasKey || doorLocked));
        Console.WriteLine("!doorLocked = " + (!doorLocked));
        Console.WriteLine("!(hasKey && isNearDoor) = " + (!(hasKey && isNearDoor)));

        // && can hai ve deu dung.
        // || chi can mot ve dung.
        // ! dao nguoc gia tri bool.
    }

    static void DemoKetHopSoSanhVaLogic()
    {
        InPhan("7. Ket hop so sanh va logic");

        int level = 12;
        int gold = 180;
        bool hasQuestTicket = true;

        bool duDieuKienNhanNhiemVu = level >= 10 && gold >= 100 && hasQuestTicket;
        bool canBuyPotion = gold >= 50 || level >= 20;

        Console.WriteLine("Du dieu kien nhan nhiem vu: " + duDieuKienNhanNhiemVu);
        Console.WriteLine("Co the mua potion: " + canBuyPotion);

        // Day la kieu bieu thuc rat pho bien trong game va ung dung.
    }

    static void DemoToanTuBaNgoi()
    {
        InPhan("8. Toan tu ba ngoi");

        int age = 19;
        string thongBao = age >= 18 ? "Du tuoi" : "Chua du tuoi";

        Console.WriteLine("Tuoi: " + age);
        Console.WriteLine("Ket qua: " + thongBao);

        int hp = 0;
        string trangThai = hp > 0 ? "Con song" : "Da guc";

        Console.WriteLine("Trang thai nhan vat: " + trangThai);

        // Toan tu ba ngoi hop voi bieu thuc ngan gon.
        // Neu logic dai, nen dung if else de de doc.
    }

    static void DemoChiaSoNguyenVaSoThuc()
    {
        InPhan("9. Chia so nguyen va so thuc");

        int soNguyen1 = 7;
        int soNguyen2 = 2;
        double soThuc1 = 7;
        double soThuc2 = 2;

        Console.WriteLine("7 / 2 voi int = " + (soNguyen1 / soNguyen2));
        Console.WriteLine("7 / 2 voi double = " + (soThuc1 / soThuc2));
        Console.WriteLine("7.0 / 2 = " + (7.0 / 2));
        Console.WriteLine("7 / 2.0 = " + (7 / 2.0));

        // Muon lay ket qua co phan thap phan, hay dung double hoac float.
    }

    static void DemoToanTuPhanDu()
    {
        InPhan("10. Toan tu phan du");

        int tongSoPhanThuong = 53;
        int moiHop = 10;

        int soHopDay = tongSoPhanThuong / moiHop;
        int soPhanThuongLe = tongSoPhanThuong % moiHop;

        Console.WriteLine("So hop day: " + soHopDay);
        Console.WriteLine("So phan thuong le: " + soPhanThuongLe);
        Console.WriteLine("15 % 2 = " + (15 % 2));
        Console.WriteLine("24 % 6 = " + (24 % 6));

        // Phan du thuong duoc dung de kiem tra chan le va chia nhom.
    }

    static void DemoTinhTienTrongGame()
    {
        InPhan("11. Tinh tien trong game");

        int gold = 250;
        int swordPrice = 120;
        int potionPrice = 35;
        int potionCount = 2;

        int totalPotionPrice = potionPrice * potionCount;
        int totalCost = swordPrice + totalPotionPrice;
        int remainingGold = gold - totalCost;

        Console.WriteLine("Vang ban dau: " + gold);
        Console.WriteLine("Tong gia thuoc: " + totalPotionPrice);
        Console.WriteLine("Tong chi phi: " + totalCost);
        Console.WriteLine("Vang con lai: " + remainingGold);

        // Day la vi du dung nhieu toan tu trong mot bai toan thuc te.
    }

    static void DemoTinhGiaKhuyenMai()
    {
        InPhan("12. Tinh gia khuyen mai");

        double giaGoc = 500000;
        double tyLeGiam = 0.2;
        double soTienGiam = giaGoc * tyLeGiam;
        double giaSauGiam = giaGoc - soTienGiam;

        Console.WriteLine("Gia goc: " + giaGoc);
        Console.WriteLine("Ty le giam: " + tyLeGiam);
        Console.WriteLine("So tien giam: " + soTienGiam);
        Console.WriteLine("Gia sau giam: " + giaSauGiam);

        // Khi lam viec voi tien te that, decimal thuong phu hop hon double.
    }

    static void DemoKiemTraDangNhap()
    {
        InPhan("13. Kiem tra dang nhap");

        bool daNhapDungMatKhau = true;
        bool daNhapDungOtp = false;
        bool dangBiKhoa = false;

        bool dangNhapThanhCong = daNhapDungMatKhau && daNhapDungOtp && !dangBiKhoa;
        bool canHienThiLoi = !dangNhapThanhCong || dangBiKhoa;

        Console.WriteLine("Dang nhap thanh cong: " + dangNhapThanhCong);
        Console.WriteLine("Can hien thi loi: " + canHienThiLoi);

        // Logic bool giup viet luat nghiep vu ro rang hon.
    }

    static void DemoToanTuVoiChuoi()
    {
        InPhan("14. Toan tu voi chuoi");

        string ho = "Nguyen";
        string tenDem = "Van";
        string ten = "An";
        string hoTen = ho + " " + tenDem + " " + ten;

        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Xin chao, " + hoTen + "!");
        Console.WriteLine("Do dai chuoi: " + hoTen.Length);

        // Dau + voi string la phep noi chuoi.
    }

    static void DemoTinhDiemTrungBinh()
    {
        InPhan("15. Tinh diem trung binh");

        double diemToan = 8.5;
        double diemLy = 7.5;
        double diemHoa = 9.0;
        double diemTrungBinh = (diemToan + diemLy + diemHoa) / 3;

        Console.WriteLine("Diem toan: " + diemToan);
        Console.WriteLine("Diem ly: " + diemLy);
        Console.WriteLine("Diem hoa: " + diemHoa);
        Console.WriteLine("Diem trung binh: " + diemTrungBinh);

        // Dung ngoac de lam ro mau so va tu so trong cong thuc.
    }

    static void DemoCapNhatTaiNguyen()
    {
        InPhan("16. Cap nhat tai nguyen");

        int wood = 50;
        int stone = 40;
        int iron = 25;

        wood += 15;
        stone -= 5;
        iron *= 2;

        Console.WriteLine("Go hien tai: " + wood);
        Console.WriteLine("Da hien tai: " + stone);
        Console.WriteLine("Sat hien tai: " + iron);

        // Toan tu gan ket hop cuc ky hop cho bai toan cap nhat tai nguyen.
    }

    static void DemoKiemTraPhanThuong()
    {
        InPhan("17. Kiem tra phan thuong");

        int streak = 7;
        bool daDiemDanhHomNay = true;
        bool duocNhanHopQua = streak >= 7 && daDiemDanhHomNay;
        string thongBao = duocNhanHopQua ? "Nhan duoc hop qua tuan" : "Chua du dieu kien";

        Console.WriteLine("Streak: " + streak);
        Console.WriteLine("Da diem danh hom nay: " + daDiemDanhHomNay);
        Console.WriteLine(thongBao);
    }

    static void DemoTinhTocDoDiChuyen()
    {
        InPhan("18. Tinh toc do di chuyen");

        double quangDuong = 150.0;
        double thoiGian = 3.0;
        double tocDo = quangDuong / thoiGian;
        bool tocDoCao = tocDo > 40;

        Console.WriteLine("Quang duong: " + quangDuong);
        Console.WriteLine("Thoi gian: " + thoiGian);
        Console.WriteLine("Toc do: " + tocDo);
        Console.WriteLine("Toc do cao hon 40: " + tocDoCao);
    }

    static void TongKet()
    {
        InPhan("19. Tong ket");

        Console.WriteLine("Toan tu giup xu ly du lieu, so sanh va xay dung dieu kien.");
        Console.WriteLine("Hay uu tien viet bieu thuc ngan, ro va co ngoac khi can.");
        Console.WriteLine("Neu ket qua la bool, hay doc thanh cau hoi dung sai.");
        Console.WriteLine("Neu ket qua la so, hay tu kiem tra bang tinh nham truoc khi chay.");
        Console.WriteLine("Cang luyen nhieu bai nho, ban cang quen mat doan logic.");
    }

    /*
    Ghi chu mo rong cho bai toan tu.
    Dong 01: Cong, tru, nhan, chia la nhom phep tinh nen tang.
    Dong 02: Phep chia so nguyen can than vi no bo di phan le.
    Dong 03: Neu muon ket qua 3.5, dung double hoac float.
    Dong 04: Toan tu phan du rat hop de kiem tra chan le.
    Dong 05: Vi du: x % 2 == 0 nghia la so chan.
    Dong 06: Toan tu so sanh luon tra ve bool.
    Dong 07: Bool la kieu du lieu can ban cho logic dieu kien.
    Dong 08: && yeu cau tat ca dieu kien dung.
    Dong 09: || yeu cau it nhat mot dieu kien dung.
    Dong 10: ! dao nguoc true thanh false va nguoc lai.
    Dong 11: Hay doc bieu thuc bool thanh cau tieng Viet.
    Dong 12: Vi du: gold >= 100 doc la vang lon hon hoac bang 100.
    Dong 13: Toan tu += thuong dung khi cong don.
    Dong 14: Toan tu -= thuong dung khi tru tai nguyen.
    Dong 15: Toan tu *= thuong dung khi nhan thuong theo he so.
    Dong 16: Toan tu /= thuong dung khi tinh trung binh hoac chia nhom.
    Dong 17: Prefix va postfix co the gay roi cho nguoi moi.
    Dong 18: Vi vay hay tach ra nhieu dong rieng trong bai dau.
    Dong 19: Toan tu ba ngoi nen duoc dung cho logic ngan gon.
    Dong 20: Neu bieu thuc dai hon mot dong, hay quay lai if else.
    Dong 21: Thu tu uu tien anh huong truc tiep den ket qua.
    Dong 22: Khi nghi ngo, hay them ngoac tron.
    Dong 23: Ngoac tron giup nguoi doc hieu y do cua ban.
    Dong 24: Trong game, phep tinh diem xuat hien moi noi.
    Dong 25: Trong app ban hang, phep tinh gia cung rat pho bien.
    Dong 26: Trong bai toan luong, phan tram giam gia can than kieu du lieu.
    Dong 27: decimal phu hop hon khi can do chinh xac tien te.
    Dong 28: float va double hop cho do hoa, vat ly, thong ke.
    Dong 29: Tranh dat ten bien qua ngan nhu x, y neu bai toan thuc te.
    Dong 30: Ten ro nghia lam code de doc va de sua.
    Dong 31: Hay dat ten remainingGold thay vi g.
    Dong 32: Hay dat ten totalCost thay vi tc.
    Dong 33: Bai nay nen ket hop voi Console.WriteLine de tu kiem tra.
    Dong 34: Moi khi doi mot gia tri, hay doan ket qua truoc khi chay.
    Dong 35: Ky nang doan ket qua la ky nang rat quan trong.
    Dong 36: Neu doan sai, hay tim lai cho nao hieu nham thu tu uu tien.
    Dong 37: Loi pho bien la nham dau = va ==.
    Dong 38: = la gan gia tri, == la so sanh bang nhau.
    Dong 39: Loi pho bien thu hai la quen ngoac khi noi chuoi va tinh toan.
    Dong 40: Vi du Console.WriteLine("Tong: " + a + b) se khac voi (a + b).
    Dong 41: Hay viet Console.WriteLine("Tong: " + (a + b)).
    Dong 42: Loi pho bien thu ba la chia cho 0.
    Dong 43: Trong code that, can kiem tra mau so truoc khi chia.
    Dong 44: Loi pho bien thu tu la nham kieu du lieu int va double.
    Dong 45: Neu du lieu can phan thap phan, hay dung kieu thich hop ngay tu dau.
    Dong 46: Bai tap tu luyen 1: tinh tong tien hoa don 3 san pham.
    Dong 47: Bai tap tu luyen 2: tinh diem trung binh 5 mon.
    Dong 48: Bai tap tu luyen 3: kiem tra du tuoi dang ky khoa hoc.
    Dong 49: Bai tap tu luyen 4: tinh so hop qua day va so hop qua le.
    Dong 50: Bai tap tu luyen 5: kiem tra nguoi choi co du dieu kien mo cua.
    Dong 51: Bai tap tu luyen 6: tinh luong sau thue don gian.
    Dong 52: Bai tap tu luyen 7: tinh quang duong trung binh moi ngay.
    Dong 53: Bai tap tu luyen 8: cap nhat vang sau nhieu lan mua vat pham.
    Dong 54: Bai tap tu luyen 9: kiem tra hoc vien dat hay truot.
    Dong 55: Bai tap tu luyen 10: tinh phan tram hoan thanh cong viec.
    Dong 56: Khi gap bai moi, hay tach thanh bien dau vao va cong thuc.
    Dong 57: Sau do tinh trung gian, cuoi cung moi in ket qua.
    Dong 58: Cach lam nay giup debug de hon rat nhieu.
    Dong 59: Neu bieu thuc dai, hay chia thanh nhieu bien nho.
    Dong 60: Bien trung gian lam code de test va de giai thich.
    Dong 61: Ban co the tu them nhieu vi du gan voi linh vuc minh thich.
    Dong 62: Vi du bong da, game, ban hang, hoc tap, cham cong.
    Dong 63: Moi chu de deu co the anh xa thanh toan tu co ban.
    Dong 64: Day la ly do bai toan tu can duoc hoc that ky.
    Dong 65: Kien thuc nay se theo ban trong suot qua trinh lap trinh.
    Dong 66: O cac bai sau, if else va vong lap deu dung lai toan tu.
    Dong 67: Neu bai nay chua vung, cac bai sau se kho hon.
    Dong 68: Hay chay lai file va sua tham so nhieu lan.
    Dong 69: Thu doi a, b, gold, score, level va tu doan ket qua.
    Dong 70: Tu hoc theo cach lap lai la cach nhanh nhat.
    Dong 71: Hay viet them mot ham moi de tinh tien taxi.
    Dong 72: Hay viet them mot ham moi de tinh so ngay con lai.
    Dong 73: Hay viet them mot ham moi de kiem tra uu dai thanh vien.
    Dong 74: Tuong tu, hay tu mo rong bai tinh giam gia theo cap do VIP.
    Dong 75: Cang nhieu tinh huong, ban cang nho y nghia toan tu.
    Dong 76: Khi review code, hay nhin ten bien truoc khi nhin cong thuc.
    Dong 77: Ten bien dung se giup ban hieu cong thuc ngay.
    Dong 78: Toan tu la cong cu, ten bien la ngu canh.
    Dong 79: Ket hop ca hai thi code moi trong sang.
    Dong 80: Ket thuc ghi chu mo rong cho bai toan tu.
    */
}
