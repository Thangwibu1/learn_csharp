using System;

class Program
{
    static void Main(string[] args)
    {
        InTieuDe("Bai 05 - Nullable Types");
        DemoNullableIntCoBan();
        DemoHasValueVaValue();
        DemoGanGiaTriSau();
        DemoNullCoalescing();
        DemoSoSanhVoiNull();
        DemoNullableBool();
        DemoNullableDouble();
        DemoThongTinNguoiDung();
        DemoNgaySinhChuaBiet();
        DemoDiemDanhGia();
        DemoGiaSanPhamTuyChon();
        DemoTrangThaiDonHang();
        DemoCapNhatGiaTriNullable();
        DemoTinhToanAnToan();
        DemoGiaTriMacDinh();
        DemoTinhHuongGame();
        DemoTinhHuongFormNhapLieu();
        DemoTongKetKinhNghiem();
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

    static void DemoNullableIntCoBan()
    {
        InPhan("1. Nullable int co ban");

        int? score = null;

        Console.WriteLine("score = " + score);
        Console.WriteLine("score co gia tri khong: " + score.HasValue);
    }

    static void DemoHasValueVaValue()
    {
        InPhan("2. HasValue va Value");

        int? level = 12;

        if (level.HasValue)
        {
            Console.WriteLine("Level hien tai: " + level.Value);
        }
        else
        {
            Console.WriteLine("Chua co level.");
        }
    }

    static void DemoGanGiaTriSau()
    {
        InPhan("3. Gan gia tri sau");

        int? rank = null;
        Console.WriteLine("Rank luc dau: " + rank);

        rank = 5;
        Console.WriteLine("Rank sau khi duoc gan: " + rank);

        rank = null;
        Console.WriteLine("Rank sau khi xoa gia tri: " + rank);
    }

    static void DemoNullCoalescing()
    {
        InPhan("4. Toan tu ??");

        int? rewardGold = null;
        int safeReward = rewardGold ?? 0;

        Console.WriteLine("Phan thuong an toan: " + safeReward);

        rewardGold = 250;
        safeReward = rewardGold ?? 0;

        Console.WriteLine("Phan thuong sau khi co gia tri: " + safeReward);
    }

    static void DemoSoSanhVoiNull()
    {
        InPhan("5. So sanh voi null");

        int? selectedWeaponId = null;

        if (selectedWeaponId == null)
        {
            Console.WriteLine("Chua chon vu khi.");
        }
        else
        {
            Console.WriteLine("Vu khi dang chon: " + selectedWeaponId);
        }

        selectedWeaponId = 101;

        if (selectedWeaponId != null)
        {
            Console.WriteLine("Da chon vu khi co ma: " + selectedWeaponId);
        }
    }

    static void DemoNullableBool()
    {
        InPhan("6. Nullable bool");

        bool? hasAccepted = null;

        Console.WriteLine("Gia tri ban dau: " + hasAccepted);

        hasAccepted = true;
        Console.WriteLine("Sau khi dong y: " + hasAccepted);

        hasAccepted = false;
        Console.WriteLine("Sau khi tu choi: " + hasAccepted);

        // bool? phu hop khi can 3 trang thai: chua biet, dong y, tu choi.
    }

    static void DemoNullableDouble()
    {
        InPhan("7. Nullable double");

        double? temperature = null;

        if (!temperature.HasValue)
        {
            Console.WriteLine("Chua nhan du lieu nhiet do.");
        }

        temperature = 36.5;
        Console.WriteLine("Nhiet do hien tai: " + temperature.Value);
    }

    static void DemoThongTinNguoiDung()
    {
        InPhan("8. Thong tin nguoi dung co the chua day du");

        int? age = null;
        double? height = 1.72;

        Console.WriteLine("Tuoi: " + (age?.ToString() ?? "Chua cung cap"));
        Console.WriteLine("Chieu cao: " + (height?.ToString() ?? "Chua cung cap"));
    }

    static void DemoNgaySinhChuaBiet()
    {
        InPhan("9. Ngay sinh chua biet");

        DateTime? birthDate = null;

        if (birthDate.HasValue)
        {
            Console.WriteLine("Ngay sinh: " + birthDate.Value.ToShortDateString());
        }
        else
        {
            Console.WriteLine("Nguoi dung chua nhap ngay sinh.");
        }

        birthDate = new DateTime(2000, 5, 12);
        Console.WriteLine("Ngay sinh sau khi cap nhat: " + birthDate.Value.ToShortDateString());
    }

    static void DemoDiemDanhGia()
    {
        InPhan("10. Diem danh gia co the chua co");

        double? rating = null;
        double displayRating = rating ?? 0;

        Console.WriteLine("Diem hien thi ban dau: " + displayRating);

        rating = 4.8;
        displayRating = rating ?? 0;
        Console.WriteLine("Diem hien thi sau khi co danh gia: " + displayRating);
    }

    static void DemoGiaSanPhamTuyChon()
    {
        InPhan("11. Gia san pham tuy chon");

        decimal? specialPrice = null;
        decimal basePrice = 150000m;
        decimal finalPrice = specialPrice ?? basePrice;

        Console.WriteLine("Gia cuoi cung luc dau: " + finalPrice);

        specialPrice = 129000m;
        finalPrice = specialPrice ?? basePrice;
        Console.WriteLine("Gia cuoi cung sau khi co gia dac biet: " + finalPrice);
    }

    static void DemoTrangThaiDonHang()
    {
        InPhan("12. Trang thai don hang theo ma shipper");

        int? shipperId = null;

        if (shipperId == null)
        {
            Console.WriteLine("Don hang chua duoc gan cho shipper.");
        }
        else
        {
            Console.WriteLine("Shipper dang giao co ma: " + shipperId);
        }

        shipperId = 27;
        Console.WriteLine("Cap nhat shipperId = " + shipperId);
    }

    static void DemoCapNhatGiaTriNullable()
    {
        InPhan("13. Cap nhat gia tri nullable");

        int? points = null;
        Console.WriteLine("Points: " + points);

        points = 10;
        Console.WriteLine("Points sau khi nhan thuong: " + points);

        points += 5;
        Console.WriteLine("Points sau khi cong them: " + points);

        points = null;
        Console.WriteLine("Points sau khi reset: " + points);
    }

    static void DemoTinhToanAnToan()
    {
        InPhan("14. Tinh toan an toan voi nullable");

        int? bonus = null;
        int salary = 1200;
        int totalIncome = salary + (bonus ?? 0);

        Console.WriteLine("Tong thu nhap khi chua co bonus: " + totalIncome);

        bonus = 300;
        totalIncome = salary + (bonus ?? 0);
        Console.WriteLine("Tong thu nhap khi co bonus: " + totalIncome);
    }

    static void DemoGiaTriMacDinh()
    {
        InPhan("15. Gia tri mac dinh de hien thi");

        string title = null;
        string safeTitle = title ?? "Chua dat tieu de";

        Console.WriteLine("Tieu de hien thi: " + safeTitle);

        title = "Bao cao doanh thu";
        safeTitle = title ?? "Chua dat tieu de";
        Console.WriteLine("Tieu de sau khi co du lieu: " + safeTitle);
    }

    static void DemoTinhHuongGame()
    {
        InPhan("16. Tinh huong game");

        int? selectedSkillId = null;
        int defaultSkillId = 1;
        int skillToUse = selectedSkillId ?? defaultSkillId;

        Console.WriteLine("Ky nang se dung: " + skillToUse);

        selectedSkillId = 8;
        skillToUse = selectedSkillId ?? defaultSkillId;
        Console.WriteLine("Ky nang sau khi chon: " + skillToUse);
    }

    static void DemoTinhHuongFormNhapLieu()
    {
        InPhan("17. Tinh huong form nhap lieu");

        int? yearOfBirth = null;

        if (yearOfBirth.HasValue)
        {
            Console.WriteLine("Nam sinh: " + yearOfBirth.Value);
        }
        else
        {
            Console.WriteLine("Truong nam sinh dang de trong.");
        }

        yearOfBirth = 1998;
        Console.WriteLine("Nam sinh sau khi nhap: " + yearOfBirth);
    }

    static void DemoTongKetKinhNghiem()
    {
        InPhan("18. Tong ket kinh nghiem");

        Console.WriteLine("Nullable phu hop khi gia tri co the chua biet, chua nhap, hoac chua ton tai.");
        Console.WriteLine("0 khong giong null, false khong giong null.");
        Console.WriteLine("Dung ?? de dat gia tri mac dinh an toan.");
        Console.WriteLine("Chi dung .Value khi chac chan bien co gia tri.");
    }

    static void TongKet()
    {
        InPhan("19. Tong ket");

        Console.WriteLine("Nullable giup mo ta du lieu chua co gia tri mot cach tu nhien.");
        Console.WriteLine("No rat huu ich trong form, du lieu tu database, va thong tin tuy chon.");
        Console.WriteLine("Hay uu tien kiem tra HasValue hoac dung ?? truoc khi truy cap.");
        Console.WriteLine("Neu khong chac chan co gia tri, dung .Value la nguy hiem.");
    }

    /*
    Ghi chu mo rong cho bai nullable types.
    Dong 01: Nullable la cach cho phep kieu gia tri co the chua gia tri null.
    Dong 02: Cac kieu gia tri nhu int, double, bool binh thuong khong nhan null.
    Dong 03: Khi them dau ?, ta co int?, double?, bool?.
    Dong 04: Nullable rat huu ich khi du lieu co the chua ton tai.
    Dong 05: Vi du diem danh gia chua co ai cham.
    Dong 06: Vi du ngay sinh chua duoc nguoi dung nhap.
    Dong 07: Vi du ma shipper chua duoc gan.
    Dong 08: Vi du id ky nang chua duoc chon trong game.
    Dong 09: Null khac 0.
    Dong 10: Null nghia la chua co gia tri.
    Dong 11: 0 nghia la co gia tri, va gia tri do bang 0.
    Dong 12: Null cung khac false.
    Dong 13: bool? cho phep 3 trang thai: null, true, false.
    Dong 14: Day la tinh huong thuong gap trong form xac nhan.
    Dong 15: Thuoc tinh HasValue dung de kiem tra co gia tri hay khong.
    Dong 16: Thuoc tinh Value lay gia tri that su ben trong.
    Dong 17: Chi nen dung Value sau khi da kiem tra HasValue.
    Dong 18: Neu dung Value khi null, chuong trinh se loi.
    Dong 19: Toan tu ?? giup dat gia tri mac dinh.
    Dong 20: Vi du rewardGold ?? 0.
    Dong 21: Cach nay gon va an toan hon nhieu if else ngan.
    Dong 22: Khi hien thi UI, nullable rat hay duoc dung.
    Dong 23: Neu khong co du lieu, ta hien `Chua cap nhat`.
    Dong 24: Neu co du lieu, ta hien gia tri that.
    Dong 25: Day la cach trinh bay than thien voi nguoi dung.
    Dong 26: Nullable cung thuong gap khi doc du lieu tu database.
    Dong 27: Nhieu cot co the cho phep rong.
    Dong 28: O lop co ban, ban chua can hoc database de hieu y tuong nay.
    Dong 29: Hay hinh dung du lieu den tu form chua nhap du.
    Dong 30: Day la vi du thuc te rat gan.
    Dong 31: Ban co the gan null lai sau khi da co gia tri.
    Dong 32: Dieu nay co nghia la trang thai co the quay lai `chua biet`.
    Dong 33: Khong phai luc nao gia tri da co thi se ton tai mai mai.
    Dong 34: Toan tu ?. cung rat hay di kem nullable tham chieu.
    Dong 35: Trong file nay co vi du dung `age?.ToString()`.
    Dong 36: Neu age null thi no khong goi ToString ma tra ve null an toan.
    Dong 37: Sau do ta co the tiep tuc dung ?? de thay bang chuoi mac dinh.
    Dong 38: Day la chuoi xu ly an toan va gon.
    Dong 39: Hay nho: nullable khong phai de tranh quyet dinh.
    Dong 40: No la de mo ta du lieu chua co hoac khong ap dung.
    Dong 41: Neu bai toan chi co 0 va 1, co the khong can nullable.
    Dong 42: Nhung neu can phan biet `chua co` va `da co gia tri 0`, nullable la dung.
    Dong 43: Vi du diem danh gia 0 sao va chua co danh gia la hai y nghia khac nhau.
    Dong 44: Day la mot diem rat quan trong.
    Dong 45: Loi pho bien la coi null va 0 la mot.
    Dong 46: Loi pho bien khac la dung Value ma khong check.
    Dong 47: Loi thu ba la dat gia tri mac dinh qua som lam mat y nghia null.
    Dong 48: Vi du vua doc du lieu xong da doi null thanh 0, sau do khong con biet du lieu co that hay khong.
    Dong 49: Hay chi doi sang mac dinh o diem can hien thi hoac tinh toan.
    Dong 50: Giữ y nghia null lau nhat co the trong du lieu goc.
    Dong 51: Nullable la ky nang co ban nhung rat thuc te.
    Dong 52: No se theo ban rat lau trong lap trinh backend va app doanh nghiep.
    Dong 53: Bai tap tu luyen 1: diem thuong co the chua co.
    Dong 54: Bai tap tu luyen 2: ngay giao hang co the chua xac dinh.
    Dong 55: Bai tap tu luyen 3: tuoi nguoi dung co the chua nhap.
    Dong 56: Bai tap tu luyen 4: diem danh gia san pham co the null.
    Dong 57: Bai tap tu luyen 5: ngay ket thuc hop dong co the null.
    Dong 58: Bai tap tu luyen 6: ma giam gia co the khong duoc chon.
    Dong 59: Bai tap tu luyen 7: toa do dich den co the chua duoc dat.
    Dong 60: Bai tap tu luyen 8: shipperId co the chua co.
    Dong 61: Bai tap tu luyen 9: selectedTab co the chua duoc chon.
    Dong 62: Bai tap tu luyen 10: diem thi thu co the vang mat.
    Dong 63: Moi bai nen tu tra loi cau hoi: null co y nghia gi trong ngu canh nay?
    Dong 64: Neu khong tra loi duoc, co the ban chua can nullable.
    Dong 65: Neu tra loi duoc ro rang, nullable la lua chon manh.
    Dong 66: Trong code, hay dat ten bien sao cho doc len biet duoc y nghia.
    Dong 67: Vi du specialPrice de hieu hon p.
    Dong 68: Vi du shipperId de hieu hon x.
    Dong 69: Ten bien giup nguoi doc hieu vi sao null la hop ly.
    Dong 70: Cang ro nghia, cang de bao tri.
    Dong 71: Khi review code, hay hoi: null co duoc xu ly an toan chua?
    Dong 72: Da co duong di cho null va non-null chua?
    Dong 73: Da phan biet duoc du lieu chua co va du lieu bang 0 chua?
    Dong 74: Da tranh dung .Value truc tiep chua?
    Dong 75: Neu co, file cua ban se an toan hon rat nhieu.
    Dong 76: Nullable la bai hoc nho nhung gia tri rat lon.
    Dong 77: No day ban cach nghi ve du lieu thieu, khong chi du lieu dep.
    Dong 78: Day la cach nghi ky su mem can co.
    Dong 79: Hay tiep tuc luyen voi nhieu tinh huong gan thuc te.
    Dong 80: Ket thuc ghi chu mo rong cho bai nullable types.
    */
}
