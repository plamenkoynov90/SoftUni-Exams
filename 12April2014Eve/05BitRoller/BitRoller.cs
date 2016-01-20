using System;

public class BitRoller
{

    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int freezePosition = int.Parse(Console.ReadLine());
        int rollCount = int.Parse(Console.ReadLine());
        int lastBit = freezePosition < 18 ? 18 : 17;
        int firstBit = freezePosition > 0 ? 0 : 1;

        for (int i = 0; i < rollCount; i++)
        {
        int newNumber = firstBit == 1 ? inputNumber & 1 : 0;
            for (int j = firstBit; j < 19; j++)
            {
                int currentBit = (inputNumber >> j) & 1;

                if (j == 0)
                {
                    newNumber |= currentBit << lastBit;
                    //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(19, '0'));
                }
                else if (j == freezePosition)
                {
                    newNumber |= currentBit << j;
                    //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(19, '0'));
                }
                else if (j == freezePosition + 1)
                {
                    newNumber |= currentBit << (j - 2);
                    //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(19, '0'));
                }
                else
                {
                    newNumber |= currentBit << (j - 1);
                    //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(19, '0'));
                }
            }
            Console.WriteLine();
            inputNumber = newNumber;
            newNumber = 0;
        }
        Console.WriteLine(inputNumber);
    }
}