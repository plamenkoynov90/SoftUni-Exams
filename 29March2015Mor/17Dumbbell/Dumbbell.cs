using System;

class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //Print the top
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', (n / 2) + 1), new string('.', n));
        for (int i = 1; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                new string('.', n / 2 - i), '&', new string('*', (n / 2 + i) - 1), new string('.', n));
        }

        //Print the middle and handle
        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '&', new string('*', n - 2), new string('=', n));

        //Print the bottom
        for (int i = 1; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                new string('.', i), '&', new string('*', ((n - 2) - i)), new string('.', n));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', (n / 2) + 1), new string('.', n));
    }
}