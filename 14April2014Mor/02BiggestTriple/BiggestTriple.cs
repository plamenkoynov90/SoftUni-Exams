using System;

class BiggestTriple
{
    static void Main()
    {
        string numbers = Console.ReadLine();

        string[] numbersString = numbers.Split(' ');
        int[] numbersInt = Array.ConvertAll(numbersString, int.Parse);

        int biggestSum = Int32.MinValue;
        int index = 0;
        int sumLeft = 0;
        bool isThereSumLeft = false;

        if (numbersInt.Length < 3)
        {
            for (int i = 0; i < numbersInt.Length; i++)
            {
                Console.Write(numbersInt[i] + " ");
            }
        }
        else
        {
            for (int i = 0; i < numbersInt.Length;)
            {
                int sum3numbers = numbersInt[i] + numbersInt[i + 1] + numbersInt[i + 2];
                if (sum3numbers > biggestSum)
                {
                    biggestSum = sum3numbers;
                    index = i;
                }
                i += 3;
                if (numbersInt.Length - (numbersInt.Length % 3) == i)
                {
                    break;
                }

            }
            if (numbersInt.Length % 3 != 0)
            {
                int sumLeftStartIndex = numbersInt.Length - numbersInt.Length % 3;
                for (int j = sumLeftStartIndex; j < numbersInt.Length; j++)
                {
                    sumLeft += numbersInt[j];
                }
                isThereSumLeft = true;
            }
            if (biggestSum >= sumLeft || !isThereSumLeft)
            {
                for (int i = index; i < index + 3; i++)
                {
                    Console.Write(numbersInt[i] + " ");
                }
            }
            else
            {
                for (int i = numbersInt.Length - numbersInt.Length % 3; i < numbersInt.Length; i++)
                {
                    Console.Write(numbersInt[i] + " ");
                }
            }
        }
        Console.WriteLine();
    }
}