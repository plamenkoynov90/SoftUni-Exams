using System;

class EncryptedMatrix
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        char diagonalType = char.Parse(Console.ReadLine());

        int currentCharCode = 0;
        string[] convertCode = new string[inputText.Length];

        for (int i = 0; i < inputText.Length; i++)
        {
            currentCharCode = inputText[i] % 10;
            convertCode[i] += currentCharCode;
        }
        int[] convertCodeInt = Array.ConvertAll(convertCode, int.Parse);
        string encryptedCode = "";
        for (int i = 0; i < convertCodeInt.Length; i++)
        {
            if(convertCode.Length == 1)
            {
                if (convertCodeInt[i] % 2 != 0)
                {
                    encryptedCode += convertCodeInt[i];
                }
                else if (convertCodeInt[i] % 2 == 0)
                {
                    encryptedCode += convertCodeInt[i] * convertCodeInt[i];
                }
            }
            else if (i == 0)
            {
                if (convertCodeInt[i] % 2 != 0)
                {
                    encryptedCode += convertCodeInt[i] + convertCodeInt[i + 1];
                }
                else if (convertCodeInt[i] % 2 == 0)
                {
                    encryptedCode += convertCodeInt[i] * convertCodeInt[i];
                }
            }
            else if (i == convertCodeInt.Length - 1)
            {
                if (convertCodeInt[i] % 2 != 0)
                {
                    encryptedCode += convertCodeInt[i] + convertCodeInt[i - 1];
                }
                else if (convertCodeInt[i] % 2 == 0)
                {
                    encryptedCode += convertCodeInt[i] * convertCodeInt[i];
                }
            }
            else
            {
                if (convertCodeInt[i] % 2 != 0)
                {
                    encryptedCode += convertCodeInt[i - 1] + convertCodeInt[i] + convertCodeInt[i + 1];
                }
                else if (convertCodeInt[i] % 2 == 0)
                {
                    encryptedCode += convertCodeInt[i] * convertCodeInt[i];
                }
            }
        }
        if (diagonalType == '\\')
        {
            for (int i = 0, counter = 1; i < encryptedCode.Length; i++, counter++)
            {

                string leftZeroes = new string('+', i).Replace("+", "0 ");
                string rightZeroes = new string('+', encryptedCode.Length - counter).Replace("+", "0 ");
                Console.WriteLine("{0}{1} {2}", leftZeroes, encryptedCode[i], rightZeroes);
            }
        }
        else if (diagonalType == '/')
        {
            for (int i = encryptedCode.Length - 1, counter = 1; i >= 0; i--, counter++)
            {
                string leftZeroes = new string('+', encryptedCode.Length - counter).Replace("+", "0 ");
                string rightZeroes = new string('+', counter - 1).Replace("+", "0 ");
                Console.WriteLine("{0}{1} {2}", leftZeroes, encryptedCode[i], rightZeroes);
            }
        }
    }
}