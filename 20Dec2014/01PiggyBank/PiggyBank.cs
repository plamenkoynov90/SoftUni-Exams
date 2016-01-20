using System;

class PiggyBank
{
    static void Main()
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int normalDays = 30 - partyDays;
        int monthlySavings = normalDays * 2;
        int monthlyExpences = partyDays * 5;
        int monthlyBalance = monthlySavings - monthlyExpences;

        
        double monthNeeded = (double)tankPrice / monthlyBalance;
        int result = (int)Math.Ceiling(monthNeeded);
        int years = result / 12;
        int months = result % 12;        

        if (monthlyBalance > 0 )
        {
            Console.WriteLine("{0} years, {1} months" , years , months);
        }
        else
        {
            Console.WriteLine("never");
        }
    }
}