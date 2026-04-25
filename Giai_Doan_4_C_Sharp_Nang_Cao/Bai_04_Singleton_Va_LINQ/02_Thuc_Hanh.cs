using System;
using System.Collections.Generic;
using System.Linq;

class GameManager
{
    // Bien static giu instance duy nhat.
    private static GameManager instance;

    // Property cho phep doc instance tu ben ngoai.
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }

            return instance;
        }
    }

    // Constructor private de khong cho tao tuy y tu ben ngoai.
    private GameManager()
    {
    }

    // Method don gian.
    public void StartGame()
    {
        Console.WriteLine("Game Started");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Goi singleton.
        GameManager.Instance.StartGame();

        // Tao danh sach diem.
        List<int> scores = new List<int> { 20, 100, 150, 40, 200 };

        // Dung LINQ loc diem cao.
        List<int> highScores = scores.Where(score => score >= 100).ToList();

        // In ket qua sau khi loc.
        foreach (int score in highScores)
        {
            Console.WriteLine("High score: " + score);
        }
    }
}
