using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool foundMagicNumber = false;
            for (int abc = 111; abc <= 777; abc++)
            {
                int def = abc + diff;
                int ghi = def + diff;
                if (IsAllowedNumber(abc) && IsAllowedNumber(def) && IsAllowedNumber(ghi) && (ghi <= 777) &&
                    sum == SumAllDigits(abc) + SumAllDigits(def) + SumAllDigits(ghi))
                {
                    Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                    foundMagicNumber = true;
                }
            }
            if (!foundMagicNumber)
            {
                Console.WriteLine("No");
            }
        }
        public static int SumAllDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        private static bool IsAllowedNumber(int num)
        {
            string digits = num.ToString();
            foreach (var digit in digits)
            {
                if (digit < '1' || digit > '7')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
