using System;

class Enemy
{
    // Luu mau cua quai.
    public int Health;
}

class Program
{
    static void Main(string[] args)
    {
        // Vi du value type.
        int originalGold = 100;
        int copiedGold = originalGold;

        // Thay doi ban sao.
        copiedGold = 50;

        // In de thay bien goc khong doi.
        Console.WriteLine("originalGold: " + originalGold);
        Console.WriteLine("copiedGold: " + copiedGold);

        // Vi du reference type.
        Enemy enemyA = new Enemy();
        enemyA.Health = 100;

        // Sao chep tham chieu.
        Enemy enemyB = enemyA;

        // Sua qua enemyB.
        enemyB.Health = 20;

        // In de thay enemyA cung bi doi.
        Console.WriteLine("enemyA health: " + enemyA.Health);
        Console.WriteLine("enemyB health: " + enemyB.Health);
    }
}
