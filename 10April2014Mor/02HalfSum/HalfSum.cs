using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine()) * 2;

            long firstNumbersSum = 0;
            long secondNumbersSum = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < numbersCount / 2)
                {
                    firstNumbersSum += number;
                }
                else
                {
                    secondNumbersSum += number;
                }
            }
            if (firstNumbersSum == secondNumbersSum)
            {
                Console.WriteLine("Yes, sum={0}", firstNumbersSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(firstNumbersSum - secondNumbersSum));
            }
        }
    }
}
