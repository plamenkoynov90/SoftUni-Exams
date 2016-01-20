using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
            for (int i = 0; i < (n/2) -1 ; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}",'*', new string('/', (n * 2) - 2), new string(' ', n));
            }
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string('|', n));
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string(' ', n));
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
        }
    }
}
