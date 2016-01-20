using System;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        

        Console.WriteLine("{0}{1}{0}" ,  new string('-' , n / 2 ), new string('*', n + 2));

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}" , new string('-', n / 2 ) , '*' , new string('-', n));
        }
        for (int i = 0 , count = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}" , 
                    new string('-', n / 2 - count) , new string('*',1 + 2*count) , new string('-', n - count*2));
            if ( i < n / 2)
            {
               count++ ;
            }
            else
            {
                count--;
            }
        }
    }
}