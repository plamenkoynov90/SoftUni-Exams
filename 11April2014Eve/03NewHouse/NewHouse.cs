using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 1;

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', ((n / 2) - i)), new string('*', counter));
            counter += 2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", '|', new string('*', n - 2));
        }
    }
}