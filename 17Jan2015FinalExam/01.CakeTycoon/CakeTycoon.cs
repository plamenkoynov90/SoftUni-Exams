using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cakesWants = ulong.Parse(Console.ReadLine());
            double flourNeededCake = double.Parse(Console.ReadLine());
            ulong flourAvailable = ulong.Parse(Console.ReadLine());
            ulong trufflesAvailable = ulong.Parse(Console.ReadLine());
            ulong priceOneTruffle = ulong.Parse(Console.ReadLine());

            double cakesMake = flourAvailable / flourNeededCake;
            double cakePrice = 0;
            double trufflesCost = 0;
            if (cakesWants <= cakesMake)
            {
                cakesMake -= cakesMake - cakesWants;
                trufflesCost = trufflesAvailable * priceOneTruffle;
                cakePrice = (trufflesCost / cakesMake) * 1.25;
                Console.WriteLine("All products available, price of a cake: {0:F2}" , cakePrice );
            }
            else
            {
                cakesMake = Math.Floor(cakesMake);
                decimal totalFlourRequired = cakesWants * (decimal)flourNeededCake;
                decimal kilogramsNeeded = totalFlourRequired - flourAvailable;
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour" , cakesMake , kilogramsNeeded);
            }

        }
    }
}
