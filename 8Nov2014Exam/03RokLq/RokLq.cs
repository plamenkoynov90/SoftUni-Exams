using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RokLq
{
    class RokLq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            for (int i = 0; i < n / 2; i++)
            {
                int outsideDots = (n - 2) - (2 * i);
                int insideDots = (n + 2) + (4 * i);
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outsideDots), '*', new string('.', insideDots));
            }
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('.', n - 2), new string('.', n));

            int insideDotsSleeves = (n - 4);
            int outsideDotsSleeves = 1;
            while (insideDotsSleeves > 0)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", '*', new string('.', insideDotsSleeves), new string('.', outsideDotsSleeves), new string('.', n));
                insideDotsSleeves -= 2;
                outsideDotsSleeves += 2;
            }
            for (int i = 0; i < n - 1; i++)
            {
                int outsideDots = (n - 1) - i;
                int insideDots = n + (i * 2);
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outsideDots), '*', new string('.', insideDots));
            }
            Console.WriteLine(new string('*', n * 3));
        }
    }
}
