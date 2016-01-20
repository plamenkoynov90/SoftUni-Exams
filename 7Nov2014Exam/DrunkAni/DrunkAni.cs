using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkAni
{
    class DrunkAni
    {
        static void Main(string[] args)
        {
            long numberOfCabins = long.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            long sumAllSteps = 0;
            long startPositon = 0;
            while(command != "Found a free one!")
            {
                long stepsCount = long.Parse(command);
                long currentPosition = (startPositon + stepsCount) % numberOfCabins;
                long difference = currentPosition - startPositon;
                sumAllSteps += Math.Abs(difference);
                startPositon = currentPosition;
                if(difference > 0 )
                {
                    Console.WriteLine("Go {0} steps to the right, Ani." , difference);
                }
                else if(difference < 0)
                {
                    Console.WriteLine("Go {0} steps to the left, Ani." , Math.Abs(difference));
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Moved a total of {0} steps." , sumAllSteps);
        }
    }
}
