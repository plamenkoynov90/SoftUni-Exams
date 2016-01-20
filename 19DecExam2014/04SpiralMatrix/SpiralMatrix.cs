using System;

class SpiralMatrix
{
    static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        string keyword = Console.ReadLine();
        keyword = keyword.ToLower();

        char[,] matrix = new char[matrixSize, matrixSize];
        int index = 0;
        string direction = "right";
        int row = 0;
        int col = 0;
        int startRow = 0;
        int startCol = 0;
        int maxRow = matrixSize;
        int maxCol = matrixSize;
        for (int i = 0; i < matrixSize*matrixSize; i++)
        {
            if (index == keyword.Length)
            {
                index = 0;
            }
            if (direction == "right")
            {
                matrix[col, row] = keyword[index];
                row++;
                index++;
                if(row == maxRow)
                {
                    direction = "down";
                    row--;
                    col++;
                }
            }
            else if(direction == "down")
            {
                matrix[col, row] = keyword[index];
                col++;
                index++;
                if (col == maxCol)
                {
                    direction = "left";
                    row--;
                    col--;
                }
            }
            else if(direction == "left")
            {
                matrix[col, row] = keyword[index];
                row--;
                index++;
                if (row == startRow - 1)
                {
                    direction = "up";
                    row++;
                    col--;
                }
            }
            else if (direction == "up")
            {
                matrix[col, row] = keyword[index];
                col--;
                index++;
                if (col == startCol)
                {
                    direction = "right";
                    startCol++;
                    startRow++;
                    maxCol--;
                    maxRow--;
                    col = startCol;
                    row = startRow; 
                }
            }
        }
        int biggestSum = 0;
        int rowIndex = 0;
        for (int i = 0; i < matrixSize; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < matrixSize; j++)
            {
                rowSum += (matrix[i, j] - 96) * 10;
            }
            if(rowSum > biggestSum)
            {
                biggestSum = rowSum;
                rowIndex = i;
            }            
        }
        Console.WriteLine("{0} - {1}" , rowIndex , biggestSum);
    }
}

