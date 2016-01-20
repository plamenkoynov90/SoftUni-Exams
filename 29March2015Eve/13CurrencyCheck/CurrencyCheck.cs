using System;

class CurrencyCheck
{
    static void Main()
    {
        double rublesPrice = double.Parse(Console.ReadLine());
        double dollarsPrice = double.Parse(Console.ReadLine());
        double euroPrice = double.Parse(Console.ReadLine());
        double levaBStorePrice = double.Parse(Console.ReadLine());
        double levaMStorePrice = double.Parse(Console.ReadLine());

        double rublesInLeva = (rublesPrice / 100) * 3.5;
        double dollarsInLeva = dollarsPrice * 1.5;
        double euroInLeva = euroPrice * 1.95;
        double BStorePrice = levaBStorePrice / 2;
        double MStorePrice = levaMStorePrice;

        double[] allGames = new double[5] { rublesInLeva, dollarsInLeva, euroInLeva, BStorePrice, MStorePrice };
        Array.Sort(allGames);
        double cheapestGame = allGames[0];
        Console.WriteLine("{0:F2}", cheapestGame);
    }
}