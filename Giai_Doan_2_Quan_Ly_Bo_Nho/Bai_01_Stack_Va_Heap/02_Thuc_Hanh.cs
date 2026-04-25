using System;

class Player
{
    // Bien nay la thuoc tinh don gian cua object Player.
    public int Health;
}

class Program
{
    static void Main(string[] args)
    {
        // Tao mot value type.
        int score = 100;

        // Sao chep value type sang bien khac.
        int copiedScore = score;

        // Thay doi bien duoc sao chep.
        copiedScore = 200;

        // In ra de thay bien goc khong doi.
        Console.WriteLine("score: " + score);
        Console.WriteLine("copiedScore: " + copiedScore);

        // Tao mot object tren heap.
        Player playerA = new Player();

        // Gan gia tri cho object.
        playerA.Health = 100;

        // Sao chep tham chieu sang bien khac.
        Player playerB = playerA;

        // Thay doi du lieu qua bien playerB.
        playerB.Health = 50;

        // In ra de thay hai bien dang cung tro toi mot object.
        Console.WriteLine("playerA health: " + playerA.Health);
        Console.WriteLine("playerB health: " + playerB.Health);
    }
}
