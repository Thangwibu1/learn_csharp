using System;

class Program
{
    static void Main(string[] args)
    {
        // Tao hai bien so nguyen de tinh toan.
        int a = 10;
        int b = 3;

        // In ket qua cac phep toan so hoc.
        Console.WriteLine("Cong: " + (a + b));
        Console.WriteLine("Tru: " + (a - b));
        Console.WriteLine("Nhan: " + (a * b));
        Console.WriteLine("Chia: " + (a / b));
        Console.WriteLine("Chia lay du: " + (a % b));

        // Tao bien diem va cap nhat diem.
        int score = 0;
        score += 10;
        score += 5;
        score -= 3;

        // In diem hien tai.
        Console.WriteLine("Diem: " + score);

        // Tao bien vang va kiem tra du tien mua do khong.
        int gold = 40;
        bool canBuyPotion = gold >= 25;

        // In ket qua so sanh.
        Console.WriteLine("Co du vang mua potion khong: " + canBuyPotion);

        // Tao hai dieu kien logic.
        bool hasKey = true;
        bool isNearDoor = false;

        // Kiem tra co mo cua duoc khong.
        bool canOpenDoor = hasKey && isNearDoor;

        // In ket qua.
        Console.WriteLine("Mo cua duoc khong: " + canOpenDoor);
    }
}
