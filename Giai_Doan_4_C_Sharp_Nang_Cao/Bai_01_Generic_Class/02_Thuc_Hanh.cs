using System;

class Box<T>
{
    // Bien nay co kieu du lieu la T.
    public T Value;
}

class Program
{
    static void Main(string[] args)
    {
        // Tao box chua int.
        Box<int> scoreBox = new Box<int>();
        scoreBox.Value = 100;

        // Tao box chua string.
        Box<string> nameBox = new Box<string>();
        nameBox.Value = "Knight";

        // In ra gia tri.
        Console.WriteLine(scoreBox.Value);
        Console.WriteLine(nameBox.Value);
    }
}
