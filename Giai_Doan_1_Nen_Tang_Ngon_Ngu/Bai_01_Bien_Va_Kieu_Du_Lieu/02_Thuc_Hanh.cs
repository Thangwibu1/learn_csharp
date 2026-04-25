using System;

class Program
{
    static void Main(string[] args)
    {
        // In tieu de bai hoc.
        Console.WriteLine("Bai 1: Bien va Kieu Du Lieu");

        // Tao bien luu ten nguoi choi.
        string playerName = "An";

        // Tao bien luu tuoi.
        int age = 20;

        // Tao bien luu toc do di chuyen.
        float moveSpeed = 5.5f;

        // Tao bien luu trang thai song chet.
        bool isAlive = true;

        // Tao bien luu hang xep loai.
        char rank = 'A';

        // In thong tin tung bien.
        Console.WriteLine("Ten: " + playerName);
        Console.WriteLine("Tuoi: " + age);
        Console.WriteLine("Toc do: " + moveSpeed);
        Console.WriteLine("Con song: " + isAlive);
        Console.WriteLine("Hang: " + rank);

        // Tao du lieu gan voi game.
        int playerHealth = 100;
        int coinCount = 25;
        string weaponName = "Sword";

        // In thong tin game ra man hinh.
        Console.WriteLine("Mau: " + playerHealth);
        Console.WriteLine("Vang: " + coinCount);
        Console.WriteLine("Vu khi: " + weaponName);

        // Thay doi gia tri bien de mo phong game dang chay.
        playerHealth = 80;
        coinCount = 30;

        // In lai sau khi thay doi.
        Console.WriteLine("Mau moi: " + playerHealth);
        Console.WriteLine("Vang moi: " + coinCount);
    }
}
