using System;

class BitsSifting
{
    static void Main()
    {
        ulong bitsToSieve = ulong.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());

        ulong finalNumber = bitsToSieve;

        for (int i = 0; i < numberOfSieves; i++)
        {
            ulong sieveNumber = ulong.Parse(Console.ReadLine());
            finalNumber = finalNumber & (~sieveNumber);
        }
        ulong bitsCount = 0;
        while (finalNumber > 0)
        {
            bitsCount += (finalNumber & 1);
            finalNumber = finalNumber >> 1;
        }
        Console.WriteLine(bitsCount);
    }
}