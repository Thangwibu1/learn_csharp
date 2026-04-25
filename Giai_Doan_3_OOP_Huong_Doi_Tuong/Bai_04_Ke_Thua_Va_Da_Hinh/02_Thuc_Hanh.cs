using System;

class Character
{
    // Mau chung cho moi nhan vat.
    public int Health;

    // Ham ao de class con co the ghi de.
    public virtual void Attack()
    {
        Console.WriteLine("Character tan cong co ban");
    }
}

class Player : Character
{
    // Ghi de cach tan cong cua player.
    public override void Attack()
    {
        Console.WriteLine("Player chem kiem");
    }
}

class Enemy : Character
{
    // Ghi de cach tan cong cua enemy.
    public override void Attack()
    {
        Console.WriteLine("Enemy can tan cong");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao cac object khac nhau nhung cung chung kieu cha.
        Character player = new Player();
        Character enemy = new Enemy();

        // Goi cung mot method nhung moi object phan ung khac nhau.
        player.Attack();
        enemy.Attack();
    }
}
