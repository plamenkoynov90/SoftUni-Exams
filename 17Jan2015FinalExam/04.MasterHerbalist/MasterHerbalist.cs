using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayliExpenses = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int totalMoneyMade = 0;
            int totalHerbs = 0;
            int days = 0;
            while(command != "Season Over")
            {
                days++;
                string[] allData = command.Split();
                int hours = int.Parse(allData[0]);
                string path = allData[1];
                int price = int.Parse(allData[2]);

                int index = 0;
                int currentHerbsCount = 0;
                for (int i = 0; i < hours; i++)
                {
                    if(index == path.Length)
                    {
                        index = 0;
                    }
                    char currentLetter = path[index];
                    if(currentLetter == 'H')
                    {
                        currentHerbsCount++;
                        totalHerbs++;
                    }
                    index++;
                }
                totalMoneyMade += currentHerbsCount * price;


                command = Console.ReadLine();
            }
            double averageEarnings = totalMoneyMade / (double)days;
            if (averageEarnings >= dayliExpenses)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:F2}." , (averageEarnings - dayliExpenses));
            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}." , (dayliExpenses * days) - (averageEarnings*days));
            }
        }
    }
}
