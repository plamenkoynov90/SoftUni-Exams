using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime timeOfDay = DateTime.Parse(Console.ReadLine());

        double sumWattsConsumed = 0;

        if (timeOfDay.Hour >= 0 && timeOfDay.Hour < 9)
        {
            sumWattsConsumed = ((1 * 100.53 + 8 * 125.90) * flats) * floors;
        }
        else if (timeOfDay.Hour >= 14 && timeOfDay.Hour < 19)
        {
            sumWattsConsumed = ((2 * 100.53 + 2 * 125.90) * flats) * floors;
        }
        else if (timeOfDay.Hour >= 19 && timeOfDay.Hour < 24)
        {
            sumWattsConsumed = ((7 * 100.53 + 6 * 125.90) * flats) * floors;
        }

        Console.WriteLine("{0} Watts", (int)sumWattsConsumed);
    }
}