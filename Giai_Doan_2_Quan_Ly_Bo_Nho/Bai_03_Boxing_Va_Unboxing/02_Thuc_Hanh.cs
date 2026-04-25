using System;

class Program
{
    static void Main(string[] args)
    {
        // Tao mot so nguyen thuong.
        int score = 99;

        // Boxing: dua int vao object.
        object boxedScore = score;

        // In object sau khi boxing.
        Console.WriteLine("Boxed score: " + boxedScore);

        // Unboxing: ep object ve lai int.
        int unboxedScore = (int)boxedScore;

        // In gia tri sau khi unboxing.
        Console.WriteLine("Unboxed score: " + unboxedScore);

        // Tao object chua string.
        object text = "Hello";

        // Kiem tra kieu truoc khi ep.
        if (text is string)
        {
            // Ep ve string va in ra.
            string message = (string)text;
            Console.WriteLine(message);
        }
    }
}
