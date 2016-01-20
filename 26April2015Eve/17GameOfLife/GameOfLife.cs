using System;

class GameOfLife
{
    static void Main()
    {
        //How much coordinates you have to enter
        int numberOfCoordinates = int.Parse(Console.ReadLine());

        //Making two boards of zeroes;
        int[,] board = new int[10, 10];
        int[,] boardCopy = new int[10, 10];

        //Input the live bits on the two boards
        for (int i = 0; i < numberOfCoordinates; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            board[x, y] = 1;
            boardCopy[x, y] = 1;
        }
        //Loop trough all bits on the board
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                int currentBit = board[row, col];
                //How many neighbours have the currentBit we checking
                int neighbours = NeighboursCounter(row, col, boardCopy);

                //If neighbours are 2 or 3 and current bit is alive it stays alive(1)
                if ((neighbours == 2 || neighbours == 3) && currentBit == 1)
                {
                    board[row, col] = 1;
                }
                //If neoighbours are fewer than 2 or more than 3 the current bit die so make him 0
                else if ((neighbours <= 2 || neighbours > 3) && currentBit == 1)
                {
                    board[row, col] = 0;
                }
                //If neoighbours are 3 and current bit is dead(0) we make him alive (1)
                else if (neighbours == 3 && currentBit == 0)
                {
                    board[row, col] = 1;
                }
            }
        }
        //Print the next generation board
        for (int row = 0; row < 10; row++)
        {
            for (int col = 9; col >= 0; col--)
            {
                Console.Write(board[row, col]);
            }
            Console.WriteLine();
        }
    }
    //Method for counting how many live neghbours current bit have
    public static int NeighboursCounter(int row, int col, int[,] board)
    {
        int neighboursCount = 0;
        //Checking all eight neighbours if they are alive(1).If they are aive we add them to neighboursCount
        neighboursCount = CheckNeighbour(row + 1, col - 1, neighboursCount, board);
        neighboursCount = CheckNeighbour(row, col - 1, neighboursCount, board);
        neighboursCount = CheckNeighbour(row - 1, col - 1, neighboursCount, board);
        neighboursCount = CheckNeighbour(row + 1, col, neighboursCount, board);
        neighboursCount = CheckNeighbour(row - 1, col, neighboursCount, board);
        neighboursCount = CheckNeighbour(row + 1, col + 1, neighboursCount, board);
        neighboursCount = CheckNeighbour(row, col + 1, neighboursCount, board);
        neighboursCount = CheckNeighbour(row - 1, col + 1, neighboursCount, board);

        return neighboursCount;
    }
    //Method for checking if current neighbour is alive(1) or dead(0)
    public static int CheckNeighbour(int neighbourRow, int neighbourCol, int neighboursCount, int[,] board)
    {
        //Check if neighbour is out of the board
        if ((neighbourRow >= 0 && neighbourRow < 10 && neighbourCol >= 0 && neighbourCol < 10))
        {
            //Check if neighbour is alive(1)
            if (board[neighbourRow, neighbourCol] == 1)
            {
                neighboursCount++;
            }
        }
        return neighboursCount;
    }
}