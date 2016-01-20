using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));

        int outsideDots = 0;
        int insideDots = 0;
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            outsideDots = (n - 1) - i;
            insideDots = n + i * 2;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outsideDots), '*', new string('.', insideDots));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', outsideDots), new string('.', insideDots + 2));
        for (int i = 0; i < (n / 2) - 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", '*', new string('.', (n * 3) - 2));
        }
        Console.WriteLine(new string('*', n * 3));
        for (int i = 0; i < (n / 2) - 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", 
                            new string('.', n / 2), '*', new string('.', n / 2 - 1), new string('.', n- 2));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}" , new string('.', n / 2) , new string('*', n / 2 + 1), new string('.', n - 2));
    }
}