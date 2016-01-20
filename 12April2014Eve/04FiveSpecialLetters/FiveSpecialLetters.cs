using System;
using System.Collections.Generic;

public class FiveSpecialLetters
{
    public static void Main()
    {
        long minWeight = long.Parse(Console.ReadLine());
        long maxWeight = long.Parse(Console.ReadLine());

        char[] allLetters = { 'a', 'b', 'c', 'd', 'e' };
        bool haveSpecialWord = false;
        for (int c1 = 0; c1 < 5; c1++)
        {
            for (int c2 = 0; c2 < 5; c2++)
            {
                for (int c3 = 0; c3 < 5; c3++)
                {
                    for (int c4 = 0; c4 < 5; c4++)
                    {

                        for (int c5 = 0; c5 < 5; c5++)
                        {
                            char[] currentWord = { allLetters[c1], allLetters[c2], allLetters[c3], allLetters[c4], allLetters[c5] };
                            int currentSum = LetterSumator(currentWord);
                            if (minWeight <= currentSum && currentSum <= maxWeight)
                            {
                                Console.Write(new string(currentWord) + " ");
                                haveSpecialWord = true;
                            }
                        }
                    }
                }
            }
        }
        if(!haveSpecialWord)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine();
        }
    }
    public static int LetterSumator(char[] currentWord)
    {
        List<char> newWord = new List<char>();
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            char currentLetter = currentWord[i];
            if (!newWord.Contains(currentLetter))
            {
                newWord.Add(currentLetter);
            }
        }
        for (int i = 0; i < newWord.Count; i++)
        {
            char currentLeter = newWord[i];
            switch (currentLeter)
            {
                case 'a': sum += 5 * (i + 1); break;
                case 'b': sum += -12 * (i + 1); break;
                case 'c': sum += 47 * (i + 1); break;
                case 'd': sum += 7 * (i + 1); break;
                case 'e': sum += -32 * (i + 1); break;
            }
        }

        return sum;
    }

}
