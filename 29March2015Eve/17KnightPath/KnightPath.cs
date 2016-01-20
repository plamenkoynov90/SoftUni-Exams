using System;

class KnightPath
{
    static void Main()
    {
        string command = Console.ReadLine();

        int[,] chessBoard = new int[8, 8];
        int row = 0;
        int col = 0;
        chessBoard[0, 0] = 1;

        while (command != "stop")
        {
            int[] path = KnightMovement(command, row, col);
            int addRow = path[0];
            int addCol = path[1];
            if ((addRow != 0 && addCol != 0) && KnightIsOnChessboard(row, col, addRow, addCol))
            {
                row += addRow;
                col += addCol;
                chessBoard[row, col] ^= 1;
            }
            command = Console.ReadLine();
        }

        bool AllZeroes = true;
        for (int rows = 0; rows <= 7; rows++)
        {
            string numberStr = "";
            for (int cols = 7; cols >= 0; cols--)
            {
                numberStr += Convert.ToString(chessBoard[rows, cols]);
            }
            int numberInt = Convert.ToInt32(numberStr, 2);
            if (numberInt != 0)
            {
                AllZeroes = false;
                Console.WriteLine(numberInt);
            }
        }
        if (AllZeroes)
        {
            Console.WriteLine("[Board is empty]");
        }
    }

    static int[] KnightMovement(string command, int row, int col)
    {
        int addRow = 0;
        int addCol = 0;
        switch (command)
        {
            case "left up":
                addRow = -1;
                addCol = 2;
                break;
            case "left down":
                addRow = 1;
                addCol = 2;
                break;
            case "right up":
                addRow = -1;
                addCol = -2;
                break;
            case "right down":
                addRow = 1;
                addCol = -2;
                break;
            case "down left":
                addRow = 2;
                addCol = 1;
                break;
            case "down right":
                addRow = 2;
                addCol = -1;
                break;
            case "up left":
                addRow = -2;
                addCol = 1;
                break;
            case "up right":
                addRow = -2;
                addCol = -1;
                break;
            default:
                break;
        }
        int[] path = new int[2] { addRow, addCol };
        if (KnightIsOnChessboard(row, col, addRow, addCol))
        {
            return path;
        }
        return path;
    }

    static bool KnightIsOnChessboard(int row, int col, int addRow, int addCol)
    {
        if ((row + addRow >= 0 && row + addRow <= 7) && (col + addCol >= 0 && col + addCol <= 7))
        {
            return true;
        }
        return false;
    }
}