using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //Print the first line
        string firstLineDots = new string('.', (n * 3) / 2);
        Console.WriteLine(firstLineDots + "*" + firstLineDots);
        //Print top sun beams
        int count = (n * 3) / 2 - 2;
        for (int i = 1; i <= (n - 1); i++)
        {
            string sunBeams = new string('.', i);
            string sunBeamsMiddle = new string('.', count--);
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", sunBeams, '*', sunBeamsMiddle);
        }
        //Print middle of the sun
        for (int i = 1; i <= n; i++)
        {
            if (i <= n / 2)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            else if (i == n / 2 + 1)
            {
                Console.WriteLine("{0}", new string('*', n * 3));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
        }
        //Print bottom sun beams
        count = n - 1; ;
        for (int j = n / 2; j <= (n * 3) / 2 - 2; j++)
        {
            string sunBeams = new string('.', count--);
            string sunBeamsMiddle = new string('.', j);
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", sunBeams, '*', sunBeamsMiddle);
        }
        //Print the last line
        Console.WriteLine(firstLineDots + "*" + firstLineDots);
    }
}