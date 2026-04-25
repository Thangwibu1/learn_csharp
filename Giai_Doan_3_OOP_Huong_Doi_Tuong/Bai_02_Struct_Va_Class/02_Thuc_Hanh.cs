using System;

struct DamageInfo
{
    // So sat thuong.
    public int Amount;
}

class Enemy
{
    // Ten quai vat.
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        // Tao struct dau tien.
        DamageInfo hitA = new DamageInfo();
        hitA.Amount = 10;

        // Sao chep struct qua bien khac.
        DamageInfo hitB = hitA;
        hitB.Amount = 50;

        // In ra de thay sao chep theo gia tri.
        Console.WriteLine("hitA: " + hitA.Amount);
        Console.WriteLine("hitB: " + hitB.Amount);

        // Tao class dau tien.
        Enemy enemyA = new Enemy();
        enemyA.Name = "Slime";

        // Sao chep tham chieu.
        Enemy enemyB = enemyA;
        enemyB.Name = "Goblin";

        // In ra de thay hai bien cung tro mot object.
        Console.WriteLine("enemyA: " + enemyA.Name);
        Console.WriteLine("enemyB: " + enemyB.Name);
    }
}
