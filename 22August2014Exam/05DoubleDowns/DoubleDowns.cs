using System;

class DoubleDowns
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());

        int[] allNumbers = new int[numbersCount];
        int rightDiagonalCouples = 0;
        int leftDiagonalCouples = 0;
        int verticalCouples = 0;

        for (int index = 0; index < numbersCount; index++)
        {
            int number = int.Parse(Console.ReadLine());
            allNumbers[index] = number;
        }
        for (int index = 1; index < numbersCount; index++)
        {
            int firstNumber = allNumbers[index - 1];
            int secondNumber = allNumbers[index];

            for (int i = 0; i < 32; i++)
            {
                int bitToCheck = (firstNumber >> i) & 1;
                int verticalBit = (secondNumber >> i) & 1;
                if (bitToCheck == 1 && verticalBit == 1)
                {
                    verticalCouples++;
                }
                if (i > 0)
                {
                    int rightDiagonalBit = (secondNumber >> (i - 1)) & 1;
                    if (bitToCheck == 1 && rightDiagonalBit == 1)
                    {
                        rightDiagonalCouples++;
                    }
                }
                if(i < 31)
                {
                    int leftDiagonalBit = (secondNumber >> (i + 1)) & 1;
                    if(bitToCheck == 1 && leftDiagonalBit == 1)
                    {
                        leftDiagonalCouples++;
                    }
                }
            }
        }
        Console.WriteLine(rightDiagonalCouples);
        Console.WriteLine(leftDiagonalCouples);
        Console.WriteLine(verticalCouples);
    }
}