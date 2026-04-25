using System;
using System.Collections.Generic;

namespace GiaiDoan3.Bai01ClassVaObject
{
    class VatPham
    {
        public string Ten;
        public string Loai;
        public int GiaTri;
        public int HoiPhuc;

        public VatPham(string ten, string loai, int giaTri, int hoiPhuc)
        {
            Ten = ten;
            Loai = loai;
            GiaTri = giaTri;
            HoiPhuc = hoiPhuc;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("Vat pham: " + Ten);
            Console.WriteLine("Loai: " + Loai);
            Console.WriteLine("Gia tri: " + GiaTri);
            Console.WriteLine("Hoi phuc: " + HoiPhuc);
        }
    }

    class KyNang
    {
        public string Ten;
        public int SatThuong;
        public int TieuHaoNangLuong;
        public string MoTa;

        public KyNang(string ten, int satThuong, int tieuHaoNangLuong, string moTa)
        {
            Ten = ten;
            SatThuong = satThuong;
            TieuHaoNangLuong = tieuHaoNangLuong;
            MoTa = moTa;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("Ky nang: " + Ten);
            Console.WriteLine("Sat thuong: " + SatThuong);
            Console.WriteLine("Tieu hao nang luong: " + TieuHaoNangLuong);
            Console.WriteLine("Mo ta: " + MoTa);
        }
    }

    class NhatKyTranDau
    {
        private readonly List<string> _dongNhatKy = new List<string>();

        public void Ghi(string noiDung)
        {
            _dongNhatKy.Add(noiDung);
            Console.WriteLine("[Log] " + noiDung);
        }

        public void InTongKet()
        {
            Console.WriteLine();
            Console.WriteLine("=== TONG KET NHAT KY ===");

            for (int i = 0; i < _dongNhatKy.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _dongNhatKy[i]);
            }

            Console.WriteLine("=== KET THUC NHAT KY ===");
            Console.WriteLine();
        }
    }

    class QuaiVat
    {
        public string Ten;
        public string ChungLoai;
        public int Mau;
        public int SatThuong;

        public QuaiVat(string ten, string chungLoai, int mau, int satThuong)
        {
            Ten = ten;
            ChungLoai = chungLoai;
            Mau = mau;
            SatThuong = satThuong;
        }

        public bool ConSong()
        {
            return Mau > 0;
        }

        public void TanCong(NhanVat nguoiChoi, NhatKyTranDau nhatKy)
        {
            nhatKy.Ghi(Ten + " tan cong " + nguoiChoi.Ten + " voi " + SatThuong + " sat thuong.");
            nguoiChoi.NhanSatThuong(SatThuong, nhatKy);
        }

        public void NhanSatThuong(int satThuong, NhatKyTranDau nhatKy)
        {
            Mau -= satThuong;

            if (Mau < 0)
            {
                Mau = 0;
            }

            nhatKy.Ghi(Ten + " bi mat " + satThuong + " mau. Mau hien tai: " + Mau);
        }

        public void HienThiTrangThai()
        {
            Console.WriteLine("Quai vat: " + Ten);
            Console.WriteLine("Chung loai: " + ChungLoai);
            Console.WriteLine("Mau: " + Mau);
            Console.WriteLine("Sat thuong: " + SatThuong);
        }
    }

    class NhanVat
    {
        public string Ten;
        public string LopNhanVat;
        public int Mau;
        public int NangLuong;
        public int SatThuongCoBan;
        public List<VatPham> TuiDo;
        public List<KyNang> DanhSachKyNang;

        public NhanVat(string ten, string lopNhanVat, int mau, int nangLuong, int satThuongCoBan)
        {
            Ten = ten;
            LopNhanVat = lopNhanVat;
            Mau = mau;
            NangLuong = nangLuong;
            SatThuongCoBan = satThuongCoBan;
            TuiDo = new List<VatPham>();
            DanhSachKyNang = new List<KyNang>();
        }

        public bool ConSong()
        {
            return Mau > 0;
        }

        public void TanCong(QuaiVat mucTieu, NhatKyTranDau nhatKy)
        {
            nhatKy.Ghi(Ten + " dung don tan cong co ban vao " + mucTieu.Ten + ".");
            mucTieu.NhanSatThuong(SatThuongCoBan, nhatKy);
        }

        public void DungKyNang(string tenKyNang, QuaiVat mucTieu, NhatKyTranDau nhatKy)
        {
            KyNang kyNang = null;

            for (int i = 0; i < DanhSachKyNang.Count; i++)
            {
                if (DanhSachKyNang[i].Ten == tenKyNang)
                {
                    kyNang = DanhSachKyNang[i];
                    break;
                }
            }

            if (kyNang == null)
            {
                nhatKy.Ghi(Ten + " khong co ky nang ten la " + tenKyNang + ".");
                return;
            }

            if (NangLuong < kyNang.TieuHaoNangLuong)
            {
                nhatKy.Ghi(Ten + " khong du nang luong de dung ky nang " + kyNang.Ten + ".");
                return;
            }

            NangLuong -= kyNang.TieuHaoNangLuong;
            nhatKy.Ghi(Ten + " su dung ky nang " + kyNang.Ten + " vao " + mucTieu.Ten + ".");
            nhatKy.Ghi("Mo ta ky nang: " + kyNang.MoTa);
            mucTieu.NhanSatThuong(kyNang.SatThuong, nhatKy);
            nhatKy.Ghi("Nang luong con lai cua " + Ten + ": " + NangLuong);
        }

        public void NhanSatThuong(int satThuong, NhatKyTranDau nhatKy)
        {
            Mau -= satThuong;

            if (Mau < 0)
            {
                Mau = 0;
            }

            nhatKy.Ghi(Ten + " nhan " + satThuong + " sat thuong. Mau hien tai: " + Mau);
        }

        public void HoiMau(int soMau, NhatKyTranDau nhatKy)
        {
            Mau += soMau;
            nhatKy.Ghi(Ten + " hoi " + soMau + " mau. Mau hien tai: " + Mau);
        }

        public void ThemVatPham(VatPham vatPham)
        {
            TuiDo.Add(vatPham);
        }

        public void ThemKyNang(KyNang kyNang)
        {
            DanhSachKyNang.Add(kyNang);
        }

        public void HienThiThongTinCoBan()
        {
            Console.WriteLine("Nhan vat: " + Ten);
            Console.WriteLine("Lop: " + LopNhanVat);
            Console.WriteLine("Mau: " + Mau);
            Console.WriteLine("Nang luong: " + NangLuong);
            Console.WriteLine("Sat thuong co ban: " + SatThuongCoBan);
        }

        public void HienThiTuiDo()
        {
            Console.WriteLine("--- Tui do cua " + Ten + " ---");

            if (TuiDo.Count == 0)
            {
                Console.WriteLine("Tui do dang rong.");
            }

            for (int i = 0; i < TuiDo.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + TuiDo[i].Ten + " - Loai: " + TuiDo[i].Loai + " - Gia tri: " + TuiDo[i].GiaTri);
            }

            Console.WriteLine();
        }

        public void HienThiKyNang()
        {
            Console.WriteLine("--- Ky nang cua " + Ten + " ---");

            if (DanhSachKyNang.Count == 0)
            {
                Console.WriteLine("Chua hoc ky nang nao.");
            }

            for (int i = 0; i < DanhSachKyNang.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + DanhSachKyNang[i].Ten + " - ST: " + DanhSachKyNang[i].SatThuong + " - NL: " + DanhSachKyNang[i].TieuHaoNangLuong);
            }

            Console.WriteLine();
        }

        public void SuDungVatPham(string tenVatPham, NhatKyTranDau nhatKy)
        {
            int viTri = -1;

            for (int i = 0; i < TuiDo.Count; i++)
            {
                if (TuiDo[i].Ten == tenVatPham)
                {
                    viTri = i;
                    break;
                }
            }

            if (viTri == -1)
            {
                nhatKy.Ghi(Ten + " khong tim thay vat pham " + tenVatPham + " trong tui do.");
                return;
            }

            VatPham vatPham = TuiDo[viTri];
            nhatKy.Ghi(Ten + " su dung vat pham " + vatPham.Ten + ".");

            if (vatPham.HoiPhuc > 0)
            {
                HoiMau(vatPham.HoiPhuc, nhatKy);
            }
            else
            {
                nhatKy.Ghi(vatPham.Ten + " khong co tac dung hoi phuc.");
            }

            TuiDo.RemoveAt(viTri);
        }

        public void NghiNgoi(int nangLuongHoi, NhatKyTranDau nhatKy)
        {
            NangLuong += nangLuongHoi;
            nhatKy.Ghi(Ten + " nghi ngoi va hoi " + nangLuongHoi + " nang luong. Nang luong hien tai: " + NangLuong);
        }

        public void HienThiTrangThaiDayDu()
        {
            Console.WriteLine("=== TRANG THAI NHAN VAT ===");
            HienThiThongTinCoBan();
            HienThiTuiDo();
            HienThiKyNang();
            Console.WriteLine("=== HET TRANG THAI ===");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void GioiThieuBaiHoc()
        {
            Console.WriteLine("Bai thuc hanh Class va Object");
            Console.WriteLine("Muc tieu:");
            Console.WriteLine("1. Tao class de mo ta vat the.");
            Console.WriteLine("2. Tao object tu class.");
            Console.WriteLine("3. Goi method va doc ghi field.");
            Console.WriteLine("4. Thay moi object co trang thai rieng.");
            Console.WriteLine();
        }

        static NhanVat TaoNhanVatMau()
        {
            NhanVat nhanVat = new NhanVat("Arin", "Kiem Si", 120, 60, 18);

            nhanVat.ThemVatPham(new VatPham("Binh mau nho", "Tieu hao", 25, 20));
            nhanVat.ThemVatPham(new VatPham("Binh mau vua", "Tieu hao", 60, 40));
            nhanVat.ThemVatPham(new VatPham("Da co", "Luu niem", 1, 0));

            nhanVat.ThemKyNang(new KyNang("Chem manh", 30, 10, "Don chem don gian nhung gay sat thuong kha tot."));
            nhanVat.ThemKyNang(new KyNang("Xuyen pha", 45, 20, "Tap trung luc vao mot diem de pha giap doi thu."));
            nhanVat.ThemKyNang(new KyNang("Cuong kich", 60, 35, "Tieu hao nhieu nang luong de gay sat thuong lon."));

            return nhanVat;
        }

        static QuaiVat TaoQuaiVatMau()
        {
            return new QuaiVat("Goblin Chua", "Goblin", 140, 14);
        }

        static void MoPhongLuotDanhCoBan(NhanVat nhanVat, QuaiVat quaiVat, NhatKyTranDau nhatKy)
        {
            Console.WriteLine("--- Luot 1: tan cong co ban ---");
            nhanVat.TanCong(quaiVat, nhatKy);

            if (quaiVat.ConSong())
            {
                quaiVat.TanCong(nhanVat, nhatKy);
            }

            Console.WriteLine();
        }

        static void MoPhongDungKyNang(NhanVat nhanVat, QuaiVat quaiVat, NhatKyTranDau nhatKy)
        {
            Console.WriteLine("--- Luot 2: dung ky nang ---");
            nhanVat.DungKyNang("Chem manh", quaiVat, nhatKy);

            if (quaiVat.ConSong())
            {
                quaiVat.TanCong(nhanVat, nhatKy);
            }

            Console.WriteLine();
        }

        static void MoPhongSuDungVatPham(NhanVat nhanVat, NhatKyTranDau nhatKy)
        {
            Console.WriteLine("--- Luot 3: su dung vat pham ---");
            nhanVat.SuDungVatPham("Binh mau nho", nhatKy);
            nhanVat.NghiNgoi(8, nhatKy);
            Console.WriteLine();
        }

        static void MoPhongKetThucTranDau(NhanVat nhanVat, QuaiVat quaiVat, NhatKyTranDau nhatKy)
        {
            Console.WriteLine("--- Luot 4: ket thuc tran dau ---");

            while (nhanVat.ConSong() && quaiVat.ConSong())
            {
                nhanVat.DungKyNang("Xuyen pha", quaiVat, nhatKy);

                if (!quaiVat.ConSong())
                {
                    break;
                }

                quaiVat.TanCong(nhanVat, nhatKy);

                if (nhanVat.Mau < 35)
                {
                    nhanVat.SuDungVatPham("Binh mau vua", nhatKy);
                }

                if (nhanVat.NangLuong < 20)
                {
                    nhanVat.NghiNgoi(15, nhatKy);
                }
            }

            Console.WriteLine();
        }

        static void TongKet(NhanVat nhanVat, QuaiVat quaiVat)
        {
            Console.WriteLine("=== TONG KET TRAN DAU ===");
            Console.WriteLine("Nhan vat con song: " + nhanVat.ConSong());
            Console.WriteLine("Quai vat con song: " + quaiVat.ConSong());
            Console.WriteLine("Mau nhan vat: " + nhanVat.Mau);
            Console.WriteLine("Nang luong nhan vat: " + nhanVat.NangLuong);
            Console.WriteLine("Mau quai vat: " + quaiVat.Mau);
            Console.WriteLine("=== HET TONG KET ===");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            GioiThieuBaiHoc();

            NhatKyTranDau nhatKy = new NhatKyTranDau();
            NhanVat nhanVat = TaoNhanVatMau();
            QuaiVat quaiVat = TaoQuaiVatMau();

            nhanVat.HienThiTrangThaiDayDu();
            quaiVat.HienThiTrangThai();
            Console.WriteLine();

            MoPhongLuotDanhCoBan(nhanVat, quaiVat, nhatKy);
            MoPhongDungKyNang(nhanVat, quaiVat, nhatKy);
            MoPhongSuDungVatPham(nhanVat, nhatKy);
            MoPhongKetThucTranDau(nhanVat, quaiVat, nhatKy);

            TongKet(nhanVat, quaiVat);
            nhatKy.InTongKet();
            nhanVat.HienThiTrangThaiDayDu();
        }
    }
}
