using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Numerology
{
    class Numerology
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split();

            string name = inputData[1];            
            string dateFormat = "dd.MM.yyyy";
            DateTime date = DateTime.ParseExact(inputData[0],dateFormat, System.Globalization.CultureInfo.InvariantCulture);

            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            long dateSum = day * month * year;
            if(month % 2 != 0)
            {
                dateSum *= dateSum;
            }
            long nameSum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                char currentLetter = name[i];
                if (char.IsUpper(currentLetter))
                {
                    nameSum += 2 * (currentLetter - 64);
                }
                else if(char.IsDigit(currentLetter))
                {
                    nameSum += currentLetter - 48;
                }
                else
                {
                    nameSum += currentLetter - 96;
                }
            }
            long currentSum = dateSum + nameSum;
            long finalSum = 0;
            if (currentSum > 13)
            {
                while (currentSum > 0)
                {
                    finalSum += currentSum % 10;
                    currentSum /= 10;
                    if(finalSum < 13 && currentSum <=0)
                    {
                        break;
                    }
                    else if(currentSum <= 0)
                    {
                        currentSum = finalSum;
                        finalSum = 0;
                    }
                }
            }
            Console.WriteLine(finalSum);
        }
    }
}
