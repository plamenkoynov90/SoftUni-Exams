using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PaintBall
{
    class PaintBall
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int[] canvas = new int[10];
            for (int i = 0; i < canvas.Length; i++)
            {
                canvas[i] = 1023;
            }
            int sum = 0;
            int counter = 0;
            while (command != "End")
            {
                int[] allData = Array.ConvertAll(command.Split(), int.Parse);
                int row = allData[0];
                int col = allData[1];
                int radius = allData[2];

                int startRow = col - radius < 0 ? 0 : col - radius;
                int startCol = row - radius < 0 ? 0 : row - radius;
                int endRow = col + radius > 9 ? 9 : col + radius; 
                int endCol = row + radius > 9 ? 9 : row + radius; 


                for (int i = startCol; i <= endCol; i++)
                {
                    for (int j = startRow; j <= endRow; j++)
                    {
                        if (counter % 2 == 0)
                        {
                            canvas[i] &= ~(1 << j);
                        }
                        else
                        {
                            canvas[i] |= 1 << j;
                        }
                    }
                }

                command = Console.ReadLine();
                counter++;
            }
            for (int i = 0; i < 10; i++)
            {
                sum += canvas[i];
            }
            Console.WriteLine(sum);
        }
    }
}
