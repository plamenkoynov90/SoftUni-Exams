using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 1;

        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), '*');

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n / 2 - i) - 1), '*', new string('.', counter));
            counter += 2;
        }
        Console.WriteLine(new string('*', n));
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n / 2) / 2), '*', new string('.' , n - (((n/2) / 2) * 2) - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', (n / 2) / 2), new string('*' , n - (((n / 2) / 2) * 2)));
    }
}