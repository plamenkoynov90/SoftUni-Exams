using System;

class DetectiveBoev
{

    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();

        int mask = SumAllCharsValue(secretWord);
        while (mask > 9)
        {
            mask = SumAllDigitsInNumber(mask);
        }
        string decryptedMessage = DecryptTheMessage(encryptedMessage, mask);
        PrintDecryptedMessage(decryptedMessage);
    }
    /// <summary>
    /// Method for reversing the string and print the decrypted message
    /// </summary>
    /// <param name="decryptedMessage"></param>
    private static void PrintDecryptedMessage(string decryptedMessage)
    {
        char[] decryptedMessageArray = decryptedMessage.ToCharArray();
        Array.Reverse(decryptedMessageArray);
        decryptedMessage = new string(decryptedMessageArray);
        Console.WriteLine(decryptedMessage);
    }
    /// <summary>
    /// Method to sum all characthers in the secret word
    /// </summary>
    /// <param name="secretWord"></param>
    /// <returns></returns>
    private static int SumAllCharsValue(string secretWord)
    {
        int sumAllCharsValue = 0;
        for (int index = 0; index < secretWord.Length; index++)
        {
            int currentCharValue = secretWord[index];
            sumAllCharsValue += currentCharValue;
        }
        return sumAllCharsValue;
    }
    /// <summary>
    /// Method to sum all digits in number 
    /// </summary>
    /// <param name="inputNumber"></param>
    /// <returns></returns>
    private static int SumAllDigitsInNumber(int inputNumber)
    {
        int sumAllDigits = 0;
        while (inputNumber > 0)
        {
            int currentDigit = inputNumber % 10;
            sumAllDigits += currentDigit;
            inputNumber /= 10;
        }
        return sumAllDigits;
    }
    /// <summary>
    /// Method for decrypt the message
    /// </summary>
    /// <param name="encryptedMessage"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    private static string DecryptTheMessage(string encryptedMessage, int mask)
    {
        string decryptedMessage = "";
        for (int index = 0; index < encryptedMessage.Length; index++)
        {
            char encryptedChar = encryptedMessage[index];
            char decryptedChar = CheckHowToDecryptChar(encryptedChar, mask);
            decryptedMessage += decryptedChar;
        }
        return decryptedMessage;
    }
    /// <summary>
    /// Method for checking how to decrypt the current character
    /// </summary>
    /// <param name="encryptedChar"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    private static char CheckHowToDecryptChar(char encryptedChar, int mask)
    {
        char decryptedChar = ' ';
        int currentCharValue = encryptedChar;
        if (encryptedChar % mask == 0)
        {
            currentCharValue += mask;
        }
        else
        {
            currentCharValue -= mask;
        }
        decryptedChar =  (char)currentCharValue;
        return decryptedChar;
    }
}