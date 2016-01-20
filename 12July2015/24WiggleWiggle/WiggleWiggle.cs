using System;

class WiggleWiggle
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        for (int index = 0; index < input.Length - 1; index += 2)
        {
            ulong firstNumber = Convert.ToUInt64(input[index]);
            ulong secondNumber = Convert.ToUInt64(input[index + 1]);
            
            ulong newFirstNumber = BitsChanger(firstNumber, secondNumber);
            ulong newSecondNumber = BitsChanger(secondNumber, firstNumber);

            //Reverse the new numbers bitwise
            newFirstNumber = ~newFirstNumber;
            newSecondNumber = ~newSecondNumber;

            //Remove the sign of the number
            newFirstNumber ^= 1ul << 63;
            newSecondNumber ^= 1ul << 63;

            Console.WriteLine("{0} {1}", newFirstNumber, Convert.ToString((long)newFirstNumber, 2).PadLeft(63, '0'));
            Console.WriteLine("{0} {1}", newSecondNumber, Convert.ToString((long)newSecondNumber, 2).PadLeft(63, '0'));
        }
    }
    /// <summary>
    /// Method for changing the bits according to the problem conditions
    /// </summary>
    /// <param name="numberToChange"></param>
    /// <param name="numberToCompare"></param>
    /// <returns></returns>
    private static ulong BitsChanger(ulong numberToChange, ulong numberToCompare)
    {
        for (int position = 0; position < 64; position += 2)
        {
            ulong bitToChange = numberToChange & (1uL << position);
            ulong bitToCompare = numberToCompare & (1uL << position);
            if (bitToChange != bitToCompare)
            {
                numberToChange ^= 1uL << position;
            }
        }
        return numberToChange;
    }
}