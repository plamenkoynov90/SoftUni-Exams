using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidTowel
{
    class PlaidTowel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(firstChar, n), secondChar, new string(firstChar, (n * 2) - 1));
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int outsideDots = (n - 1) - i;
                    int insideRombDots = 1 + (2 * i);
                    int middleDots = ((n * 2) - 3) - (i * 2);
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(firstChar, outsideDots), secondChar,
                                                                      new string(firstChar, insideRombDots),
                                                                      new string(firstChar, middleDots));
                }
                Console.WriteLine("{0}{1}{0}{1}{0}", secondChar, new string(firstChar, (n * 2) - 1));
                for (int i = 0; i < n - 1; i++)
                {
                    int outsideDots = 1 + i;
                    int insideRombDots = ((n * 2) - 3) - (2 * i);
                    int middleDots = 1 + (2 * i);
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(firstChar, outsideDots), secondChar,
                                                                      new string(firstChar, insideRombDots),
                                                                      new string(firstChar, middleDots));
                }
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(firstChar, n), secondChar, new string(firstChar, (n * 2) - 1));
            }
        }
    }
}