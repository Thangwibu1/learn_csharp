using System;

class Program
{
    static void Main(string[] args)
    {
        // Tao bien diem co the chua co gia tri.
        int? score = null;

        // Kiem tra score co gia tri hay khong.
        if (score.HasValue)
        {
            // Neu co gia tri thi in ra.
            Console.WriteLine("Diem hien tai: " + score.Value);
        }
        else
        {
            // Neu chua co gia tri thi thong bao.
            Console.WriteLine("Score hien tai dang rong");
        }

        // Gan gia tri cho score.
        score = 150;

        // Dung toan tu ?? de lay gia tri an toan.
        int safeScore = score ?? 0;

        // In gia tri an toan.
        Console.WriteLine("Safe score: " + safeScore);

        // Tao bien id vu khi dang duoc chon.
        int? selectedWeaponId = null;

        // Kiem tra nguoi choi da chon vu khi hay chua.
        if (selectedWeaponId == null)
        {
            Console.WriteLine("Nguoi choi chua chon vu khi");
        }
    }
}
