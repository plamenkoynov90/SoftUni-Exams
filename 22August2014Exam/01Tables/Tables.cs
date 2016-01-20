using System;

class Tables
{
    static void Main()
    {
        long bundleOnePackets = long.Parse(Console.ReadLine());
        long bundleTwoPackets = long.Parse(Console.ReadLine());
        long bundleThreePackets = long.Parse(Console.ReadLine());
        long bundleFourPackets = long.Parse(Console.ReadLine());
        int tableTops = int.Parse(Console.ReadLine());
        int tablesToMade = int.Parse(Console.ReadLine());

        long totalTableLegs = (bundleOnePackets * 1) + (bundleTwoPackets * 2) + (bundleThreePackets * 3) + (bundleFourPackets * 4);

        long tablesMade = Math.Min(totalTableLegs / 4, tableTops);

        if (tablesMade == tablesToMade)
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
        else if (tablesMade - tablesToMade > 0)
        {
            long legsLeft = totalTableLegs - (tablesToMade * 4);
            int tableTopsLeft = tableTops - tablesToMade;
            Console.WriteLine("more: {0}", tablesMade - tablesToMade);
            Console.WriteLine("tops left: {0}, legs left: {1}", tableTopsLeft, legsLeft);
        }
        else
        {
            long legsNeeded = totalTableLegs - (tablesToMade * 4) > 0 ? 0 : Math.Abs(totalTableLegs - (tablesToMade * 4));
            int tableTopsNeeded = tablesToMade - tableTops;
            Console.WriteLine("less: {0}", tablesMade - tablesToMade);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", tableTopsNeeded, legsNeeded);
        }
    }
}