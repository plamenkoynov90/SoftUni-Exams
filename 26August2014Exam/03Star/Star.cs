using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n), '*');

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            int outsideDots = (n - 1) - i;
            int insideDots = 1 + (i * 2);
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outsideDots), '*', new string('.', insideDots));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', (n / 2) + 1), new string('.', n - 1));
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            int outsideDots = 1 + i;
            int insideDots = (((n * 2) + 1) - 4) - 2 * i;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outsideDots), '*', new string('.', insideDots));
        }
        Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', n / 2), '*', new string('.', (n / 2) - 1));
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            int outsideDots = ((n / 2) - 1) - i;
            int insideDots = (n / 2) - 1;
            int outsideMiddleDots = 1 + (i * 2);
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', outsideDots), '*', new string('.', insideDots), new string('.', outsideMiddleDots));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', (n / 2) + 1), new string('.', n - 1));
    }
}