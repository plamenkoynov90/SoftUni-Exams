using System;

class Illuminati
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        inputText = inputText.ToUpper();

        int sumAllVowels = 0;
        int numberOfVowels = 0;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == 'A' || inputText[i] == 'E' || 
                inputText[i] == 'I' || inputText[i] == 'O' || inputText[i] == 'U')
            {
                sumAllVowels += inputText[i];
                numberOfVowels++;
            }
        }        
        Console.WriteLine(numberOfVowels);
        Console.WriteLine(sumAllVowels);
    }
}