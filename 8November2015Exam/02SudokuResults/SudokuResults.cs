using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SudokuResults
{
    class SudokuResults
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int totalSeconds = 0;
            int counter = 0;
            while(command != "Quit")
            {
                int[] minutesAndSeconds = Array.ConvertAll(command.Split(':'), int.Parse);
                int minutes = minutesAndSeconds[0];
                int seconds = minutesAndSeconds[1];
                totalSeconds += (minutes * 60) + seconds;
                counter++;

                command = Console.ReadLine();
            }
            string starPrize = "";
            int averageSeconds =(int)Math.Ceiling((double)totalSeconds / counter);
            
            if(averageSeconds < 720)
            {
                starPrize = "Gold";
            }
            else if (averageSeconds < 1440)
            {
                starPrize = "Silver";
            }
            else
            {
                starPrize = "Bronze";
            }

            Console.WriteLine("{0} Star" , starPrize);
            Console.WriteLine("Games - {0} \\ Average seconds - {1}" , counter ,averageSeconds);
        }
    }
}
