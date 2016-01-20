using System;

class ChessQueens
{
    static void Main()
    {
        int widthAndHeight = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());

        bool isValid = false;

        for (int column = 1; column <= widthAndHeight; column++)
        {
            for (int row = 1; row <= widthAndHeight; row++)
            {
                //Horizontal right
                if (row + (distance + 1) <= widthAndHeight)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96), row + (distance + 1));
                    isValid = true;
                }
                //Horizontal left
                if (row - (distance + 1) > 0)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96), row - (distance + 1));
                    isValid = true;
                }
                //Diagonal down left
                if (row - (distance + 1) > 0 && column + (distance + 1) <= widthAndHeight)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96 + (distance + 1)), row - (distance + 1));
                    isValid = true;
                }
                //Vertical up
                if (column - (distance + 1) > 0)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96 - (distance + 1)), row);
                    isValid = true;
                }
                //Vertical down
                if (column + (distance + 1) <= widthAndHeight)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96 + (distance + 1)), row);
                    isValid = true;
                }
                //Diagonal up right
                if (row + (distance + 1) <= widthAndHeight && column - (distance + 1) > 0)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96 - (distance + 1)), row + (distance + 1));
                    isValid = true;
                }
                //Diagonal down right
                if (row + (distance + 1) <= widthAndHeight && column + (distance + 1) <= widthAndHeight)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96 + (distance + 1)), row + (distance + 1));
                    isValid = true;
                }
                //Diagonal up left
                if (row - (distance + 1) > 0 && column - (distance + 1) > 0)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", (char)(column + 96), row, (char)(column + 96 - (distance + 1)), row - (distance + 1));
                    isValid = true;
                }
            }
        }
        if(!isValid)
        {
            Console.WriteLine("No valid positions");
        }
    }
}