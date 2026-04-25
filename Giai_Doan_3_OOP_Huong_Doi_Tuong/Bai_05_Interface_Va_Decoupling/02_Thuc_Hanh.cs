using System;

interface IDamageable
{
    // Object nao nhan sat thuong phai co ham nay.
    void TakeDamage(int damage);
}

interface IInteractable
{
    // Object nao tuong tac duoc phai co ham nay.
    void Interact();
}

class Enemy : IDamageable
{
    // Mau cua enemy.
    public int Health = 100;

    // Trien khai ham nhan sat thuong theo interface.
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine("Enemy con " + Health + " mau");
    }
}

class Chest : IInteractable
{
    // Trien khai hanh dong tuong tac.
    public void Interact()
    {
        Console.WriteLine("Mo ruong va nhan vat pham");
    }
}

class Sword
{
    // Thanh kiem chi can biet muc tieu co nhan sat thuong duoc khong.
    public void Hit(IDamageable target)
    {
        target.TakeDamage(25);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao object enemy, chest va sword.
        Enemy enemy = new Enemy();
        Chest chest = new Chest();
        Sword sword = new Sword();

        // Tan cong enemy thong qua interface.
        sword.Hit(enemy);

        // Tuong tac voi ruong thong qua method cua class.
        chest.Interact();
    }
}
