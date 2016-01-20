using System;

class WinningNumbers
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        inputText = inputText.ToLower();
        int sumAllLetters = 0;
        bool noWinningNumbers = true;
        for (int i = 0; i < inputText.Length; i++)
        {
            sumAllLetters += inputText[i] - 96;
        }

        for (int i = 100; i < 999; i++)
        {
            for (int j = 100; j < 999; j++)
            {
                int firstDigitsProduct = AllDigitsProduct(i);
                int secondDigitsProduct = AllDigitsProduct(j);
                if (firstDigitsProduct == secondDigitsProduct && firstDigitsProduct == sumAllLetters)
                {
                    noWinningNumbers = false;
                    Console.WriteLine("{0}-{1}", i, j);
                }
            }
        }
        if (noWinningNumbers)
        {
            Console.WriteLine("No");
        }
    }

    private static int AllDigitsProduct(int number)
    {
        int sum = 1;
        while (number > 0)
        {
            sum *= number % 10;
            number /= 10;
        }
        return sum;
    }
}
