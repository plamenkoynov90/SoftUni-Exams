using System;

class GrandTheftExamo
{
    static void Main()
    {
        int escapeAtempts = int.Parse(Console.ReadLine());

        long thievesSlapped = 0;
        long thievesEscaped = 0;
        long totalBeers = 0;

        for (int i = 1; i <= escapeAtempts; i ++)
        {
            long thieves = long.Parse(Console.ReadLine());
            long beers = long.Parse(Console.ReadLine());
            totalBeers += beers;

            if (thieves > 5)
            {                
                thievesEscaped += thieves - 5;
                thievesSlapped += 5;
            }
            else
            {
                thievesSlapped += thieves ;
            }
        }        
        Console.WriteLine("{0} thieves slapped." , thievesSlapped);
        Console.WriteLine("{0} thieves escaped." , thievesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.", totalBeers / 6 , totalBeers % 6);
    }
}