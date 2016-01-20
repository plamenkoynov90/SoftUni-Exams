using System;

class OddAndEvenJumps
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        inputString = inputString.ToLower().Replace(" " ,"");        
        string oddLetters = "";
        string evenLetters = "";

        for (int i = 0; i < inputString.Length; i++)
        {
            char currentLetter = inputString[i];
            if (i % 2 == 0 && char.IsLetter(currentLetter))
            {
                oddLetters += currentLetter;
            }
            else if (i % 2 != 0 && char.IsLetter(currentLetter))
            {
                evenLetters += currentLetter;
            }
        }
        long oddResult = CalculateResults(oddLetters, oddJump);
        long evenResult = CalculateResults(evenLetters, evenJump);
        Console.WriteLine("Odd: {0:X}" , oddResult);
        Console.WriteLine("Even: {0:X}" , evenResult);
    }

    static long CalculateResults(string str , long jump)
    {
        long result = 0;
        for(int i = 0; i < str.Length; i++)
        {
            char currentLetter = str[i];
            if((i + 1) % jump == 0)
            {
                result *= currentLetter;
            }
            else
            {
                result += currentLetter;
            }
        }
        return result;
    }
}