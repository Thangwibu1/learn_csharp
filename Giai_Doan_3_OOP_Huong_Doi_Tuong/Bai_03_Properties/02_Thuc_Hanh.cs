using System;

class Player
{
    // Ten co the doc va ghi tu ben ngoai.
    public string Name { get; set; }

    // Mau chi duoc sua ben trong class.
    public int Health { get; private set; }

    // Constructor de gan gia tri ban dau.
    public Player(string name, int health)
    {
        Name = name;
        Health = health;
    }

    // Ham nhan sat thuong co kiem soat du lieu.
    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao player va in du lieu property.
        Player player = new Player("Knight", 100);
        Console.WriteLine(player.Name);
        Console.WriteLine(player.Health);

        // Giam mau thong qua method.
        player.TakeDamage(30);
        Console.WriteLine(player.Health);
    }
}
