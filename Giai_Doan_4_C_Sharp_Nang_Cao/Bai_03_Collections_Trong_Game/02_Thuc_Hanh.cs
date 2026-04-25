using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List dung lam inventory.
        List<string> inventory = new List<string>();
        inventory.Add("Potion");
        inventory.Add("Sword");
        inventory.Add("Key");

        Console.WriteLine("Inventory:");
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine(inventory[i]);
        }

        // Dictionary dung lam bang tra cuu cong thuc.
        Dictionary<string, string> craftingRecipes = new Dictionary<string, string>();
        craftingRecipes.Add("Wood+Stone", "Axe");
        craftingRecipes.Add("Herb+Bottle", "Potion");

        Console.WriteLine("Crafting result: " + craftingRecipes["Wood+Stone"]);

        // Queue dung cho object pooling.
        Queue<string> bulletPool = new Queue<string>();
        bulletPool.Enqueue("Bullet_1");
        bulletPool.Enqueue("Bullet_2");

        string bullet = bulletPool.Dequeue();
        Console.WriteLine("Lay tu pool: " + bullet);

        // Stack dung cho UI menu.
        Stack<string> menuStack = new Stack<string>();
        menuStack.Push("PauseMenu");
        menuStack.Push("SettingsMenu");

        Console.WriteLine("Menu hien tai: " + menuStack.Peek());
        Console.WriteLine("Dong menu: " + menuStack.Pop());
        Console.WriteLine("Menu con lai: " + menuStack.Peek());
    }
}
