using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BabaTincheAirlines
{
    class BabaTincheAirlines
    {
        static void Main(string[] args)
        {
            int[] firstClassPassengers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] businessClassPassengers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] economyClassPassengers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int firstClassIncome = classIncomeSumator(firstClassPassengers, 7000);
            int businessClassIncome = classIncomeSumator(businessClassPassengers, 3500);
            int economyClassIncome = classIncomeSumator(economyClassPassengers, 1000);

            int totalIncome = firstClassIncome + businessClassIncome + economyClassIncome;
            int maxTotalIncome = (int)(12 * 7000 + 12 * (0.005 * 7000)) + (int)(28 * 3500 + 28 * (0.005 * 3500)) + (int)(50 * 1000 + 50 * (0.005 * 1000));
            int difference = maxTotalIncome - totalIncome;
            Console.WriteLine(totalIncome);
            Console.WriteLine(difference);
        }
        private static int classIncomeSumator(int[] classPassengers, int ticketPrice)
        {
            int classIncome = ((classPassengers[0] - classPassengers[1]) * ticketPrice) +
                              ((int)(classPassengers[1] * (ticketPrice * 0.3))) +
                              (int)(classPassengers[2] * (0.005 * ticketPrice));

            return classIncome;
        }
    }
}