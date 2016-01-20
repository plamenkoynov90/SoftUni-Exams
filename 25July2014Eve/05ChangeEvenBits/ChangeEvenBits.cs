using System;

class NumbersCount
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());

        int bitsChanged = 0;
        int[] numbers = new int[numbersCount];
        for (int i = 0; i < numbersCount; i++)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            numbers[i] = inputInteger;
        }
        ulong numberL = ulong.Parse(Console.ReadLine());
        for (int i = 0; i < numbersCount; i++)
        {
            int number = numbers[i];
            int bitsCount = Convert.ToString(number, 2).Length;
            ulong newNumberL = numberL;
            for (int j = 0; j < bitsCount; j++)
            {
                if (((newNumberL >> j * 2) & 1) == 0)
                {
                    bitsChanged++;
                }
                newNumberL |= (ulong)1 << j * 2;
            }
            numberL = newNumberL;
        }
        Console.WriteLine(numberL);
        Console.WriteLine(bitsChanged);
    }
}