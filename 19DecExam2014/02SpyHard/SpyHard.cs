using System;
using System.Text;

class SpyHard
{
    static void Main(string[] args)
    {
        int keyNumber = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();

        message = message.ToLower();
        Console.Write(keyNumber);
        Console.Write(message.Length);

        int totalSumMessage = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if ( message[i] >  96 && message[i] < 123)
            {
                totalSumMessage += message[i] - 96;
            }
            else
            {
                totalSumMessage += message[i];
            }
        }
        StringBuilder numeralSystemConverter = new StringBuilder();

        while (totalSumMessage > 0)
        {
            numeralSystemConverter.Insert(0, totalSumMessage % keyNumber);
            totalSumMessage /= keyNumber;
        }

        Console.WriteLine(numeralSystemConverter);
    }
}


