using System;

class SequenceOfKNumbers
{
    static void Main()
    {
        int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int k = int.Parse(Console.ReadLine());

        int previousNumber = inputNumbers[0];
        Array.Resize(ref inputNumbers, inputNumbers.Length + 1);
        inputNumbers[inputNumbers.Length - 1] = int.MaxValue;
        int counter = 1;

        for (int i = 1; i < inputNumbers.Length; i++)
        {
            int currentNumber = inputNumbers[i];
            if (previousNumber == currentNumber)
            {
                counter++;
            }
            else
            {
                for (int j = 0; j < counter % k; j++)
                {
                    Console.Write("{0} ", previousNumber);
                }
                counter = 1;
            }
            previousNumber = currentNumber;
        }
    }
}