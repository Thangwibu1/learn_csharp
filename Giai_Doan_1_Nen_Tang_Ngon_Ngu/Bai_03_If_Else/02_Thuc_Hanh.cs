using System;

class Program
{
    static void Main(string[] args)
    {
        // Tao bien mau cua nguoi choi.
        int playerHealth = 35;

        // Kiem tra song chet.
        if (playerHealth <= 0)
        {
            // In thong bao khi nhan vat chet.
            Console.WriteLine("Nhan vat da chet");
        }
        else
        {
            // In thong bao khi nhan vat con song.
            Console.WriteLine("Nhan vat van con song");
        }

        // Tao bien vang.
        int gold = 80;

        // Kiem tra kha nang mua do.
        if (gold >= 100)
        {
            Console.WriteLine("Ban mua duoc giap hiem");
        }
        else if (gold >= 50)
        {
            Console.WriteLine("Ban mua duoc thuoc hoi mau");
        }
        else
        {
            Console.WriteLine("Ban chua mua duoc gi");
        }

        // Tao diem so de xep hang.
        int score = 88;

        // Xep hang theo diem.
        if (score >= 90)
        {
            Console.WriteLine("Hang S");
        }
        else if (score >= 75)
        {
            Console.WriteLine("Hang A");
        }
        else
        {
            Console.WriteLine("Hang B");
        }
    }
}
