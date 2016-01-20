using System;

class LettersSymbolsNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumLetters = 0;
        int sumNumbers = 0;
        int sumSymbols = 0;
        for (int i = 0; i < n; i++)
        {
            string inputString = Console.ReadLine();
            inputString = inputString.ToUpper();

            for (int j = 0; j < inputString.Length; j++)
            {
                char currentChar = inputString[j];
                if (currentChar == '\t' || currentChar == '\r' || currentChar == '\n' || currentChar == ' ')
                {
                    continue;
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    sumLetters += (currentChar - ('A' - 1)) * 10;
                }
                else if (currentChar >= '0' && currentChar <= '9')
                {
                    sumNumbers += (currentChar - '0') * 20;
                }
                else
                {
                    sumSymbols += 200;
                }
            }
        }
        Console.WriteLine(sumLetters);
        Console.WriteLine(sumNumbers);
        Console.WriteLine(sumSymbols);
    }
}