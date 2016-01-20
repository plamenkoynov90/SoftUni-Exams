using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}" , new string('.' , n / 2) , new string('#' , n) );
        for (int i = 0; i < n - 2; i ++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), '#' ,  new string('.', n - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('#', (n / 2) + 1), new string('.', n - 2));
        for (int i = 0; i < n- 2; i ++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", 
                new string('.', i + 1), '#', new string('.', ((n * 2)-3) - (i + 1) * 2) );
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n - 1 ),'#');
    }
}

