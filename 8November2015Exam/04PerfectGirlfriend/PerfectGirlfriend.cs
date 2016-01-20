using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PerfectGirlfriend
{
    class PerfectGirlfriend
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string[] allDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int perfectGirlsCounter = 0;

            while(inputText!= "Enough dates!")
            {
                int sum = 0;
                string[] allData = inputText.Split('\\');
                string girlName = allData[3];
                int dayOfWeekNumber = Array.IndexOf(allDays,allData[0]) + 1;
                string telephoneNumber = allData[1];
                string braSize = allData[2];

                int sumAllDigits = 0;
                for (int i = 0; i < telephoneNumber.Length; i++)
                {
                    int currentDigit = int.Parse(telephoneNumber[i].ToString());
                    sumAllDigits += currentDigit;
                }
                int braSizeNumber = int.Parse(braSize.Substring(0, (braSize.Length - 1)));
                int braSizeLetter = Convert.ToInt32(braSize[braSize.Length-1]);
                int sumBrasize = braSizeNumber * braSizeLetter;
                int firstLetter = Convert.ToInt32(girlName[0]);
                int sumGirlName = firstLetter * girlName.Length;

                sum = (dayOfWeekNumber + sumAllDigits + sumBrasize) - sumGirlName;

                if(sum < 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you." , girlName);
                    
                }
                else
                {
                    Console.WriteLine("{0} is perfect for you." , girlName);
                    perfectGirlsCounter++;
                }

                inputText = Console.ReadLine();
            }
            Console.WriteLine(perfectGirlsCounter);
        }
    }
}
