using System;

class BitsUp
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;
        for (int i = 0; i < numberCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int pos = 7; pos >= 0; pos--)
            {
                if ((index > 0 && step == 1 )|| index % step == 1)
                {
                    number = number | (1 << pos);
                }
                index++;
            }
            Console.WriteLine(number);
        }
    }
}