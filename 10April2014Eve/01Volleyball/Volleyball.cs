using System;

class Volleyball
{
    static void Main()
    {
        string typeYear = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());

        double totalPlays = weekendsHome + ((48 - weekendsHome) * (3.0 / 4)) + (holidays * (2.0 / 3));
        if (typeYear == "leap")
        {
            totalPlays += totalPlays * 0.15;
        }
        Console.WriteLine("{0}", Math.Floor(totalPlays));
    }
}