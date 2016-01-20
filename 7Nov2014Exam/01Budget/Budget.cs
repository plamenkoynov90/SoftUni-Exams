using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Budget
{
    class Budget
    {
        static void Main(string[] args)
        {
            int amountOfMoney = int.Parse(Console.ReadLine());
            int daysOut = int.Parse(Console.ReadLine());
            int weekendsHometown = int.Parse(Console.ReadLine());

            int totalSpendWeekends = (8 - (weekendsHometown * 2)) * 20;
            int totalSpendPartyDays = daysOut * ((int)Math.Floor((3.0 / 100) * amountOfMoney) + 10);
            int totalSpendWeekdays = ((22 - daysOut) * 10) + totalSpendPartyDays;
            int totalSpend = totalSpendWeekends + totalSpendWeekdays + 150;

            int moneyLeft = amountOfMoney - totalSpend;
            if(moneyLeft < 0)
            {
                Console.WriteLine("No, not enough {0}." , Math.Abs(amountOfMoney - totalSpend));
            }
            else if (moneyLeft > 0)
            {
                Console.WriteLine("Yes, leftover {0}.", moneyLeft);
            }
            else
            {
                Console.WriteLine("Exact Budget.");
            }
        }
    }
}
