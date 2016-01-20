using System;
using System.Collections.Generic;

class CrossingSequences
{
    static void Main()
    {
        int tribonacciFirst = int.Parse(Console.ReadLine());
        int tribonacciSecond = int.Parse(Console.ReadLine());
        int tribonacciThird = int.Parse(Console.ReadLine());
        int spiralStart = int.Parse(Console.ReadLine());
        int spiralSteps = int.Parse(Console.ReadLine());

        int counter = 0;
        int spiralNumber = spiralStart;
        int smallestNumber = 0;

        List<int> tribonacciNumbers = TribonacciNumbers(tribonacciFirst, tribonacciSecond, tribonacciThird);

        for (int i = 1; spiralNumber < 1000000; i++)
        {
            if(tribonacciNumbers.Contains(spiralStart))
            {
                smallestNumber = spiralStart;
                break;
            }
            if (i % 3 == 0)
            {
                counter++;
            }
            else
            {
                spiralNumber += spiralSteps + (spiralSteps * counter);
                if (tribonacciNumbers.Contains(spiralNumber))
                {
                    smallestNumber = spiralNumber;
                    break;
                }
            }
            
        }
        if (smallestNumber == 0 || smallestNumber > 1000000)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(smallestNumber);
        }

    }
    static List<int> TribonacciNumbers(int tribonacciFirst, int tribonacciSecond, int tribonacciThird)
    {
        List<int> tribonacciNumbersList = new List<int>();
        tribonacciNumbersList.Add(tribonacciFirst);
        tribonacciNumbersList.Add(tribonacciSecond);
        tribonacciNumbersList.Add(tribonacciThird);

        int tribonaciFourth = 0;
        for (int i = 0; tribonaciFourth < 1000000; i++)
        {
            tribonaciFourth = tribonacciFirst + tribonacciSecond + tribonacciThird;
            tribonacciFirst = tribonacciSecond;
            tribonacciSecond = tribonacciThird;
            tribonacciThird = tribonaciFourth;
            tribonacciNumbersList.Add(tribonaciFourth);
        }
        return tribonacciNumbersList;
    }
}