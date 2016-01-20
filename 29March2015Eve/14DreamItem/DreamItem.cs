using System;

class DreamItem
{
    static void Main()
    {
        string[] inputData = Console.ReadLine().Split('\\');

        int workingDays = MonthDays(inputData[0]) - 10;
        decimal moneyPerHour = Convert.ToDecimal(inputData[1]);
        int hoursPerDay = Convert.ToInt32(inputData[2]);
        decimal priceItem = Convert.ToDecimal(inputData[3]);

        decimal moneyMake = workingDays * moneyPerHour * hoursPerDay;
        if (moneyMake > 700)
        {
            moneyMake += moneyMake * (decimal)0.10;
        }
        if (moneyMake >= priceItem)
        {
            Console.WriteLine("Money left = {0:F2} leva.", moneyMake - priceItem);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", priceItem - moneyMake);
        }
    }
    static int MonthDays(string month)
    {
        int monthDays = 0;
        switch (month)
        {
            case "Feb": monthDays = 28; break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov": monthDays = 30; break;
            default: monthDays = 31; break;
        }
        return monthDays;
    }
}