using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}" , new string('.' , n) , new string('#' , n));
            Console.WriteLine("{0}{1}{0}{1}{0}" , new string('.' , n-2), new string ('#' , 3));
            int outsideDots = 0;
            int insideDots = 0;
            for (int i = 0; i < n/2 - 1; i++)
            {
                outsideDots = (n - 4) - (2*i);
                insideDots = 2 + (i * 2);
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", new string('.', outsideDots), new string('#', 2), new string('.', insideDots) ,'#', new string('.' , n-2));
            }
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", new string('.', outsideDots), new string('#', 2), new string('.', insideDots), '#', new string('.', n - 2));
                outsideDots += 2;
                insideDots -=2;
            }

            Console.WriteLine("{0}{1}{0}{1}{0}", new string('.', n - 2), new string('#', 3));
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}
