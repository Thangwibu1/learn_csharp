using System;

class Player
{
    // Ten nguoi choi.
    public string Name;

    // Mau hien tai.
    public int Health;

    // Ham tan cong de mo phong hanh dong.
    public void Attack()
    {
        Console.WriteLine(Name + " dang tan cong");
    }

    // Ham nhan sat thuong.
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine(Name + " mat " + damage + " mau");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao object Player tu class Player.
        Player player = new Player();

        // Gan du lieu cho object.
        player.Name = "Knight";
        player.Health = 100;

        // Goi method cua object.
        player.Attack();
        player.TakeDamage(25);

        // In thong tin hien tai.
        Console.WriteLine("Ten: " + player.Name);
        Console.WriteLine("Mau: " + player.Health);
    }
}
