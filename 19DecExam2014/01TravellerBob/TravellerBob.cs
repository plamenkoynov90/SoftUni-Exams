using System;

class TravellerBob
{
    static void Main()
    {
        string typeYear = Console.ReadLine();

        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());

        int otherMonths = 12 - (contractMonths + familyMonths);

        int totalContractsTravels = (4 * 3) * contractMonths;
        int totalFamilyTravels = (2 * 2) * familyMonths;
        double otherMonthsTravels = (otherMonths * 12) * 0.60;

        double totalTravels = totalContractsTravels + totalFamilyTravels + otherMonthsTravels;
        if (typeYear == "leap")
        {
            totalTravels += totalTravels * 0.05;
            totalTravels = Math.Floor(totalTravels);
            Console.WriteLine(totalTravels);
        }
        else
        {
            totalTravels = Math.Floor(totalTravels);
            Console.WriteLine(totalTravels);
        }
    }
}