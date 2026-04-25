using System;
using System.Collections.Generic;

namespace GiaiDoan3.Bai02StructVaClass
{
    struct ToaDo2D
    {
        public int X;
        public int Y;

        public ToaDo2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DichChuyen(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }

    struct ThongSoDanh
    {
        public int SatThuong;
        public int ChiMang;

        public ThongSoDanh(int satThuong, int chiMang)
        {
            SatThuong = satThuong;
            ChiMang = chiMang;
        }

        public override string ToString()
        {
            return "Sat thuong=" + SatThuong + ", Chi mang=" + ChiMang;
        }
    }

    class TuiDo
    {
        public List<string> VatPham;

        public TuiDo()
        {
            VatPham = new List<string>();
        }

        public void Them(string tenVatPham)
        {
            VatPham.Add(tenVatPham);
        }

        public void HienThi()
        {
            Console.WriteLine("Tui do gom:");

            if (VatPham.Count == 0)
            {
                Console.WriteLine("- Rong");
            }

            for (int i = 0; i < VatPham.Count; i++)
            {
                Console.WriteLine("- " + VatPham[i]);
            }
        }
    }

    class NhanVat
    {
        public string Ten;
        public ToaDo2D ViTri;
        public TuiDo TuiDo;

        public NhanVat(string ten, ToaDo2D viTri)
        {
            Ten = ten;
            ViTri = viTri;
            TuiDo = new TuiDo();
        }

        public void HienThi()
        {
            Console.WriteLine("Nhan vat: " + Ten);
            Console.WriteLine("Vi tri: " + ViTri);
            TuiDo.HienThi();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void GioiThieu()
        {
            Console.WriteLine("Bai thuc hanh Struct va Class");
            Console.WriteLine("Noi dung se tap trung vao su khac nhau giua sao chep theo gia tri va theo tham chieu.");
            Console.WriteLine();
        }

        static void ViDuSaoChepStruct()
        {
            Console.WriteLine("=== VI DU 1: SAO CHEP STRUCT ===");

            ToaDo2D a = new ToaDo2D(2, 3);
            ToaDo2D b = a;

            Console.WriteLine("Ban dau:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            b.DichChuyen(10, 20);

            Console.WriteLine("Sau khi dich chuyen b:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Nhan xet: a khong doi, vi struct duoc sao chep theo gia tri.");
            Console.WriteLine();
        }

        static void ViDuSaoChepStructVoiThongSo()
        {
            Console.WriteLine("=== VI DU 2: STRUCT VOI NHIEU FIELD ===");

            ThongSoDanh chiSo1 = new ThongSoDanh(15, 5);
            ThongSoDanh chiSo2 = chiSo1;

            Console.WriteLine("chiSo1 = " + chiSo1);
            Console.WriteLine("chiSo2 = " + chiSo2);

            chiSo2.SatThuong = 80;
            chiSo2.ChiMang = 25;

            Console.WriteLine("Sau khi doi chiSo2:");
            Console.WriteLine("chiSo1 = " + chiSo1);
            Console.WriteLine("chiSo2 = " + chiSo2);
            Console.WriteLine();
        }

        static void ViDuSaoChepClass()
        {
            Console.WriteLine("=== VI DU 3: SAO CHEP CLASS ===");

            NhanVat arin = new NhanVat("Arin", new ToaDo2D(1, 1));
            arin.TuiDo.Them("Kiem go");

            NhanVat banSao = arin;

            Console.WriteLine("Ban dau:");
            arin.HienThi();
            banSao.HienThi();

            banSao.Ten = "Arin Ban Sao";
            banSao.ViTri = new ToaDo2D(7, 9);
            banSao.TuiDo.Them("Khien da");

            Console.WriteLine("Sau khi doi du lieu thong qua bien banSao:");
            arin.HienThi();
            banSao.HienThi();
            Console.WriteLine("Nhan xet: Ten va TuiDo thay doi tren ca hai bien vi cung tro toi mot object class.");
            Console.WriteLine("Vi tri cung doi tren object do, vi banSao va arin la cung mot tham chieu.");
            Console.WriteLine();
        }

        static void TruyenStructTheoGiaTri(ToaDo2D toaDo)
        {
            Console.WriteLine("Trong ham TruyenStructTheoGiaTri truoc khi doi: " + toaDo);
            toaDo.DichChuyen(100, 100);
            Console.WriteLine("Trong ham TruyenStructTheoGiaTri sau khi doi: " + toaDo);
        }

        static void TruyenStructTheoRef(ref ToaDo2D toaDo)
        {
            Console.WriteLine("Trong ham TruyenStructTheoRef truoc khi doi: " + toaDo);
            toaDo.DichChuyen(200, 200);
            Console.WriteLine("Trong ham TruyenStructTheoRef sau khi doi: " + toaDo);
        }

        static void ViDuTruyenStructVaoHam()
        {
            Console.WriteLine("=== VI DU 4: STRUCT TRUYEN VAO HAM ===");

            ToaDo2D toaDo = new ToaDo2D(5, 5);
            Console.WriteLine("Ngoai ham truoc khi goi: " + toaDo);
            TruyenStructTheoGiaTri(toaDo);
            Console.WriteLine("Ngoai ham sau khi goi theo gia tri: " + toaDo);
            TruyenStructTheoRef(ref toaDo);
            Console.WriteLine("Ngoai ham sau khi goi theo ref: " + toaDo);
            Console.WriteLine();
        }

        static void TruyenClassVaoHam(NhanVat nhanVat)
        {
            Console.WriteLine("Trong ham TruyenClassVaoHam truoc khi doi: " + nhanVat.Ten + " - " + nhanVat.ViTri);
            nhanVat.Ten = "Nhan vat da doi ten trong ham";
            nhanVat.ViTri = new ToaDo2D(99, 99);
            nhanVat.TuiDo.Them("Ngoc xanh");
            Console.WriteLine("Trong ham TruyenClassVaoHam sau khi doi: " + nhanVat.Ten + " - " + nhanVat.ViTri);
        }

        static void DoiBienThamChieuTheoGiaTri(NhanVat nhanVat)
        {
            Console.WriteLine("Trong ham DoiBienThamChieuTheoGiaTri truoc khi gan object moi: " + nhanVat.Ten);
            nhanVat = new NhanVat("Object moi trong ham", new ToaDo2D(-1, -1));
            nhanVat.TuiDo.Them("Vat pham trong object moi");
            Console.WriteLine("Trong ham DoiBienThamChieuTheoGiaTri sau khi gan object moi: " + nhanVat.Ten);
        }

        static void DoiBienThamChieuTheoRef(ref NhanVat nhanVat)
        {
            Console.WriteLine("Trong ham DoiBienThamChieuTheoRef truoc khi gan object moi: " + nhanVat.Ten);
            nhanVat = new NhanVat("Object moi bang ref", new ToaDo2D(500, 500));
            nhanVat.TuiDo.Them("Kiem anh sang");
            Console.WriteLine("Trong ham DoiBienThamChieuTheoRef sau khi gan object moi: " + nhanVat.Ten);
        }

        static void ViDuTruyenClassVaoHam()
        {
            Console.WriteLine("=== VI DU 5: CLASS TRUYEN VAO HAM ===");

            NhanVat nhanVat = new NhanVat("Luna", new ToaDo2D(4, 4));
            nhanVat.TuiDo.Them("Cung go");

            Console.WriteLine("Truoc khi goi ham:");
            nhanVat.HienThi();

            TruyenClassVaoHam(nhanVat);

            Console.WriteLine("Sau khi goi TruyenClassVaoHam:");
            nhanVat.HienThi();

            DoiBienThamChieuTheoGiaTri(nhanVat);

            Console.WriteLine("Sau khi goi DoiBienThamChieuTheoGiaTri:");
            nhanVat.HienThi();

            DoiBienThamChieuTheoRef(ref nhanVat);

            Console.WriteLine("Sau khi goi DoiBienThamChieuTheoRef:");
            nhanVat.HienThi();

            Console.WriteLine();
        }

        static void ViDuStructNamTrongClass()
        {
            Console.WriteLine("=== VI DU 6: STRUCT NAM TRONG CLASS ===");

            NhanVat a = new NhanVat("Kiro", new ToaDo2D(10, 10));
            NhanVat b = new NhanVat("Mina", a.ViTri);

            Console.WriteLine("Ban dau:");
            a.HienThi();
            b.HienThi();

            b.ViTri.DichChuyen(3, 3);

            Console.WriteLine("Sau khi doi vi tri cua b:");
            a.HienThi();
            b.HienThi();
            Console.WriteLine("Nhan xet: Vi tri la struct. Khi truyen a.ViTri vao constructor cua b, du lieu duoc sao chep theo gia tri.");
            Console.WriteLine();
        }

        static void ViDuDanhSachStruct()
        {
            Console.WriteLine("=== VI DU 7: DANH SACH STRUCT ===");

            List<ToaDo2D> duongDi = new List<ToaDo2D>();
            duongDi.Add(new ToaDo2D(0, 0));
            duongDi.Add(new ToaDo2D(1, 0));
            duongDi.Add(new ToaDo2D(1, 1));

            for (int i = 0; i < duongDi.Count; i++)
            {
                Console.WriteLine("Moc " + i + ": " + duongDi[i]);
            }

            ToaDo2D diemTam = duongDi[1];
            diemTam.DichChuyen(50, 50);

            Console.WriteLine("Sau khi doi bien tam lay ra tu list:");

            for (int i = 0; i < duongDi.Count; i++)
            {
                Console.WriteLine("Moc " + i + ": " + duongDi[i]);
            }

            Console.WriteLine("Nhan xet: struct lay ra tu list la ban sao. Doi tren bien tam khong sua truc tiep phan tu trong list.");
            Console.WriteLine();
        }

        static void ViDuDanhSachClass()
        {
            Console.WriteLine("=== VI DU 8: DANH SACH CLASS ===");

            List<NhanVat> toDoi = new List<NhanVat>();
            toDoi.Add(new NhanVat("A", new ToaDo2D(0, 1)));
            toDoi.Add(new NhanVat("B", new ToaDo2D(2, 3)));
            toDoi.Add(new NhanVat("C", new ToaDo2D(4, 5)));

            NhanVat nguoiThuHai = toDoi[1];
            nguoiThuHai.Ten = "B da doi ten";
            nguoiThuHai.TuiDo.Them("Thuoc xanh");

            for (int i = 0; i < toDoi.Count; i++)
            {
                Console.WriteLine("Thanh vien " + i + ": " + toDoi[i].Ten + " - " + toDoi[i].ViTri);
                toDoi[i].TuiDo.HienThi();
            }

            Console.WriteLine("Nhan xet: lay class tu list ra bien khac van tro toi cung object.");
            Console.WriteLine();
        }

        static void TongKet()
        {
            Console.WriteLine("=== TONG KET ===");
            Console.WriteLine("1. Struct thuong phu hop cho du lieu nho, gon, mang tinh gia tri.");
            Console.WriteLine("2. Class thuong phu hop cho doi tuong co danh tinh, trang thai, va hanh vi phong phu.");
            Console.WriteLine("3. Gan struct sang bien moi se tao ban sao doc lap.");
            Console.WriteLine("4. Gan class sang bien moi se sao chep tham chieu.");
            Console.WriteLine("5. Truyen struct vao ham mac dinh la theo gia tri.");
            Console.WriteLine("6. Truyen class vao ham cho phep sua noi dung object.");
            Console.WriteLine("7. Muon doi chinh bien tham chieu class, can can nhac dung ref.");
            Console.WriteLine("8. Khi nghi ve thiet ke, hay hoi: day la gia tri hay day la doi tuong? ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            GioiThieu();
            ViDuSaoChepStruct();
            ViDuSaoChepStructVoiThongSo();
            ViDuSaoChepClass();
            ViDuTruyenStructVaoHam();
            ViDuTruyenClassVaoHam();
            ViDuStructNamTrongClass();
            ViDuDanhSachStruct();
            ViDuDanhSachClass();
            TongKet();
        }
    }
}
