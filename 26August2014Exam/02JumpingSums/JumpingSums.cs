using System;
using System.Collections.Generic;

class JumpingSums
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int jumpsCount = int.Parse(Console.ReadLine());

        List<int> allSums = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int sum = 0;
            int currentIndex = i;
            for (int j = 0; j <= jumpsCount; j++)
            {
                int currentNumber = numbers[currentIndex];
                sum += currentNumber;
                currentIndex = (currentIndex + currentNumber) % numbers.Length  ;
            }
            allSums.Add(sum);
        }
        allSums.Sort();
        Console.WriteLine("max sum = {0}" , allSums[allSums.Count - 1]);
    }
}