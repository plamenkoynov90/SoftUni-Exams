using System;

class StripedTowel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int towelLenght = (int)Math.Floor(n * 1.5);
        for (int i = 0; i < towelLenght; i++)
        {
            for (int j = 0; j < n; j++)
            {
                char currentChar = (j + i) % 3 == 0 ? '#' : '.';
                Console.Write(currentChar);
            }
            Console.WriteLine();
        }
    }
}