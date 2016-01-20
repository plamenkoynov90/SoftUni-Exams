using System;

class SummertimeForProgrammers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        CapOfTheBottle(n);
        NeckOfTheBottle(n);
        MiddlePartOfTheBottle(n);
        BottomOfTheBottle(n);
    }
    /// <summary>
    /// Method for printing the cap of the bottle
    /// </summary>
    /// <param name="n"></param>
    private static void CapOfTheBottle(int n)
    {
        string emptyArroundTheCap = new string(' ', n / 2);
        string cap = new string('*', n + 1);
        Console.WriteLine("{0}{1}{0}", emptyArroundTheCap, cap);
    }
    /// <summary>
    /// Method for printing the neck of the bottle
    /// </summary>
    /// <param name="n"></param>
    private static void NeckOfTheBottle(int n)
    {
        int emptyCount = n / 2;
        int neckCount = n - 1;
        string emptyArroundTheNeck = new string(' ', emptyCount);
        string neck = string.Concat('*', new string(' ', neckCount), "*");
        for (int counter = 0; counter < (n / 2) + 1; counter++)
        {
            Console.WriteLine("{0}{1}{0}", emptyArroundTheNeck, neck);
        }

        for (int counter = 0; counter < (n / 2) - 1; counter++)
        {
            emptyCount--;
            neckCount += 2;
            emptyArroundTheNeck = new string(' ', emptyCount);
            neck = string.Concat('*', new string(' ', neckCount), "*");
            Console.WriteLine("{0}{1}{0}", emptyArroundTheNeck, neck);

        }

    }
    /// <summary>
    /// Method for printing the middle part of the bottle
    /// </summary>
    /// <param name="n"></param>
    private static void MiddlePartOfTheBottle(int n)
    {
        string middleOfTheBottle = "";
        //Variable for checking if the current part we have to print is empty or filled
        bool isEmptyPart = false;
        for (int counter = 0; counter < n * 2; counter++)
        {
            if (counter < n)
            {
                isEmptyPart = true;
            }
            else
            {
                isEmptyPart = false;
            }
            middleOfTheBottle = string.Concat('*', new string(isEmptyPart ? '.' : '@', (n * 2) - 2), '*');
            Console.WriteLine(middleOfTheBottle);
        }
    }
    /// <summary>
    /// Method for printing the bottom of the bottle
    /// </summary>
    /// <param name="n"></param>
    private static void BottomOfTheBottle(int n)
    {
        string bottom = new string('*', n * 2);
        Console.WriteLine(bottom);
    }
}