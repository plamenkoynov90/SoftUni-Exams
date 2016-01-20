using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int startingDay = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int melons = 0;
        int watermelons = 0;

        for (int i = startingDay; i < startingDay + days; i++)
        {
            switch (i % 7)
            {
                case 1:
                    watermelons++;
                    break;
                case 2:
                    melons += 2;
                    break;
                case 3:
                    watermelons++;
                    melons++;
                    break;
                case 4:
                    watermelons += 2;
                    break;
                case 5:
                    watermelons += 2;
                    melons += 2;
                    break;
                case 6:
                    watermelons++;
                    melons += 2;
                    break;
                default:
                    break;
            }
        }
        if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons", watermelons - melons);
        }
        else if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons", melons - watermelons);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }
    }
}