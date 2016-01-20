using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outsideRoof = n - 1;
        int insideRoof = 1;
        Console.WriteLine("{0}{1}{0}", new string('.', outsideRoof), '*');

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outsideRoof - i), '*', new string('.', insideRoof));
            insideRoof += 2;
        }
        Console.WriteLine("{0}", new string('*', (n * 2) - 1));
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("{0}{1}{0}", '*', new string('.', (n * 2) - 3));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", '*', new string('.', n / 2), new string('*', ((n * 2) - 3) - n));
        }
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("{0}{1}{0}", '*', new string('.', (n * 2) - 3));
        }
        Console.WriteLine("{0}", new string('*', (n * 2) - 1));
    }
}