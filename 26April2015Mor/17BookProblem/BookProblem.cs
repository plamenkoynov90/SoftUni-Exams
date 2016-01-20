using System;

class BookProblem
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int campingDaysInMonth = int.Parse(Console.ReadLine());
        int pagesReadInNormalDay = int.Parse(Console.ReadLine());

        if (30 - campingDaysInMonth <= 0)
        {
            Console.WriteLine("never");
            return;
        }
        int readPagesInMonth = (30 - campingDaysInMonth) * pagesReadInNormalDay;
        int monthsNeed = (int)Math.Ceiling((double)bookPages / readPagesInMonth);
        int years = monthsNeed / 12;
        int months = monthsNeed % 12;

        Console.WriteLine("{0} years {1} months", years, months);
    }
}