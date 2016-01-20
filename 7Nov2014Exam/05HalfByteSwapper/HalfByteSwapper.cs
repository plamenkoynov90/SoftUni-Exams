using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HalfByteSwapper
{
    class HalfByteSwapper
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long fourthNumber = long.Parse(Console.ReadLine());
            string command1 = Console.ReadLine();
            string command2 = Console.ReadLine();

            long[] allNumbers = new long[4] { firstNumber, secondNumber, thirdNumber, fourthNumber };


            while (command1 != "End")
            {
                int[] commandOneNumbers = Array.ConvertAll(command1.Split(), int.Parse);
                int[] commandTwoNumbers = Array.ConvertAll(command2.Split(), int.Parse);

                long firstChoosenNum = allNumbers[commandOneNumbers[0]];
                int firstBitsPosition = commandOneNumbers[1];

                long secondChoosenNum = allNumbers[commandTwoNumbers[0]];
                int secondBitsPosition = commandTwoNumbers[1];

                long mask = 15;

                long firstBits = (firstChoosenNum >> firstBitsPosition * 4) & mask;
                long secondBits = (secondChoosenNum >> secondBitsPosition * 4) & mask;

                long newFirstNumber = allNumbers[commandOneNumbers[0]] & ~(mask << firstBitsPosition * 4);
                allNumbers[commandOneNumbers[0]] = newFirstNumber | (secondBits << firstBitsPosition * 4);

                long newSecondNumber = allNumbers[commandTwoNumbers[0]] & ~(mask << secondBitsPosition * 4);
                allNumbers[commandTwoNumbers[0]] = newSecondNumber | (firstBits << secondBitsPosition * 4);

                command1 = Console.ReadLine();
                if (command1 != "End")
                {
                    command2 = Console.ReadLine();
                }
            }
            foreach (var number in allNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}