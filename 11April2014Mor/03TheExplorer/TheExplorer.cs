using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outsideDiamond = n / 2;

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), '*');
        for (int i = 0, counter = -1; i < n - 2; i++)
        {
            if (i < n / 2)
            {
                outsideDiamond--;
                counter += 2;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outsideDiamond), '*', new string('-', counter));
            }
            else
            {
                outsideDiamond++;
                counter -= 2;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outsideDiamond), '*', new string('-', counter));
            }
        }
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), '*');
    }
}