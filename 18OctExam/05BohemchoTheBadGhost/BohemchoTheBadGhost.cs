using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BohemchoTheBadGhost
{
    class BohemchoTheBadGhost
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            long score = 0;
            int counterLightsOn = 0;
            while(command != "Stop, God damn it")
            {
                long floor = long.Parse(command);
                int[] apartments = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int i = 0; i < apartments.Length; i++)
                {
                    floor ^= 1L << apartments[i];
                }

                for (int i = 0; i < 32; i++)
                {
                    long bitToCheck = (floor >> i) & 1L;
                    if(bitToCheck == 1)
                    {
                        counterLightsOn++;
                    }
                }
                score += floor;

                command = Console.ReadLine();
            }
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}" , counterLightsOn , score);
        }
    }
}
