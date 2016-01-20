using System;

class TicTacToePower
{
    static void Main(string[] args)
    {
        int coordinateX = int.Parse(Console.ReadLine());
        int coordinateY = int.Parse(Console.ReadLine());
        int firstCellValue = int.Parse(Console.ReadLine());

        int number = firstCellValue;
        int counter = 0;
        bool reachValueC = false;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                counter++;
                if (coordinateY == i && coordinateX == j)
                {
                    reachValueC = true;
                    break;
                }
                number++;
            }
            if (reachValueC)
            {
                break;
            }
        }
        long result = (long)Math.Pow(number, counter);
        Console.WriteLine(result);
    }
}