using System;
using System.Collections.Generic;

class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        int[] lettersValue = new int[] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };

        int firstTwoLetters = 40;
        int count = 0;

        for (int firstLetter = 0; firstLetter < lettersValue.Length; firstLetter++)
        {
            for (int secondLetter = 0; secondLetter < lettersValue.Length; secondLetter++)
            {
                for (int a = 0; a < 10; a++)
                {
                    if ( firstTwoLetters + a + a + a + a + lettersValue[firstLetter] + lettersValue[secondLetter] == magicWeight)
                    {
                        count++;
                    }
                    for (int b = 0; b < 10; b++)
                    {
                        if (a != b)
                        {
                            if (firstTwoLetters + a + b + b + b + lettersValue[firstLetter] + lettersValue[secondLetter] == magicWeight)
                            {
                                count++;
                            }
                            if (firstTwoLetters + a + a + a + b + lettersValue[firstLetter] + lettersValue[secondLetter] == magicWeight)
                            {
                                count++;
                            }
                            if (firstTwoLetters + a + a + b + b + lettersValue[firstLetter] + lettersValue[secondLetter] == magicWeight)
                            {
                                count++;
                            }
                            if (firstTwoLetters + a + b + a + b + lettersValue[firstLetter] + lettersValue[secondLetter] == magicWeight)
                            {
                                count++;
                            }
                            if (firstTwoLetters + a + b + b + a + lettersValue[firstLetter] + lettersValue[secondLetter] == magicWeight)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}