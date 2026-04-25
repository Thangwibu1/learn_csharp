using System;

class Program
{
    static void Main(string[] args)
    {
        // Dung vong lap for de in 5 lan.
        for (int i = 1; i <= 5; i++)
        {
            // In so thu tu hien tai.
            Console.WriteLine("Lan lap for thu: " + i);
        }

        // Tao bien dem cho while.
        int enemyCount = 0;

        // Dung while de lap khi so quai con nho hon 3.
        while (enemyCount < 3)
        {
            // In thong bao spawn quai.
            Console.WriteLine("Spawn quai thu: " + enemyCount);

            // Tang bien dem de tranh lap vo han.
            enemyCount++;
        }

        // Duyet qua so dan va bo qua vien dan thu 3.
        for (int bullet = 1; bullet <= 5; bullet++)
        {
            // Neu la vien dan thu 3 thi bo qua.
            if (bullet == 3)
            {
                continue;
            }

            // In ra vien dan da ban.
            Console.WriteLine("Ban vien dan so: " + bullet);
        }
    }
}
