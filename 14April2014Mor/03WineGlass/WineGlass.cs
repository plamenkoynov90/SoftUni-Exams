using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());        

        int wine = n - 2;
        for (int i = 0; i < n; i++)
        {
            if (i < n / 2)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', i), '\\', new string('*', wine), '/');
                wine -= 2;
            }
            else if (n < 12 && i < (n / 2) + ((n / 2) - 1))
            {
                int dots = (n / 2) - 1;
                Console.WriteLine("{0}{1}{0}" , new string('.' , dots), "||" );
            }
            else if (n >= 12 && i < (n / 2) + ((n / 2) - 2))
            {
                int dots = (n / 2) - 1;
                Console.WriteLine("{0}{1}{0}", new string('.', dots), "||");
            }
            else
            {
                Console.WriteLine(new string ('-' , n));
            }
        }
    }
}