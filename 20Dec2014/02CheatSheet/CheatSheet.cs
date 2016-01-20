using System;

class CheatSheet
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        long verticalStart = long.Parse(Console.ReadLine());
        long horizontalStart = long.Parse(Console.ReadLine());   


        for (long oneRow = verticalStart ; oneRow < rows + verticalStart ; oneRow++)
        {
            for (long oneColumn = horizontalStart ; oneColumn < columns + horizontalStart ; oneColumn++)
            {
                 
                Console.Write(oneRow * oneColumn + " ");
                              
            }
            Console.WriteLine();              
        }
    }
}

