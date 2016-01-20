using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            char yearType = char.Parse(Console.ReadLine());
            int holidaysCount = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());

            double totalPlays = ((52 - hometownWeekends) * (2d / 3)) + (holidaysCount * (1d / 2)) + hometownWeekends;
            if(yearType =='t')
            {
                totalPlays += 3d;
            }
            Console.WriteLine(Math.Floor( totalPlays));
        }
    }
}
