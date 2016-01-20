using System;

class XBits
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());
        int sixthNumber = int.Parse(Console.ReadLine());
        int seventhNumber = int.Parse(Console.ReadLine());
        int eighthNumber = int.Parse(Console.ReadLine());

        int[] allNumbersArray = new int[8] { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthNumber, seventhNumber, eighthNumber };
        int counter = 0;

        for (int i = 2; i < 8; i++)
        {
            int firstLine = allNumbersArray[i - 2];
            int secondLine = allNumbersArray[i - 1];
            int thirdLine = allNumbersArray[i];
            for (int j = 29; j >= 0; j--)
            {
                int mask = 7;
                int firstBits = (firstLine >> j) & mask;
                int secondBits = (secondLine >> j) & mask;
                int thirdBits = (thirdLine >> j) & mask;
                if(firstBits == 5 && secondBits == 2 && thirdBits == 5 )
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}