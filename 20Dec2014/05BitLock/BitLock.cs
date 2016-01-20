using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitLock
{
    class BitLock
    {
        static void Main(string[] args)
        {
            long[] allNumbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] allCommands = command.Split();
                if (allCommands[0] == "check")
                {
                    int counter = 0;
                    long mask = 1;
                    int columnToCheck = Convert.ToInt32(allCommands[1]);
                    for (int i = 0; i < allNumbers.Length; i++)
                    {
                        long bitToCheck = (allNumbers[i] >> columnToCheck) & mask;
                        if (bitToCheck == 1)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine(counter);
                }
                else
                {
                    int row = Convert.ToInt32(allCommands[0]);
                    string direction = allCommands[1];
                    int rotations = Convert.ToInt32(allCommands[2]);
                    long numberToRotate = allNumbers[row];
                    if (direction == "right")
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            long currentBit = numberToRotate & 1L;
                            numberToRotate = numberToRotate >> 1;
                            if (currentBit == 1)
                            {
                                numberToRotate |= 1 << 11;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            long currentBit = (numberToRotate >> 11) & 1L;
                            numberToRotate = numberToRotate << 1;
                            if (currentBit == 1)
                            {
                                numberToRotate |= 1L;
                                numberToRotate = numberToRotate & ~(1L << 12);
                            }
                        }
                    }
                    allNumbers[row] = numberToRotate;
                }


                command = Console.ReadLine();
            }
            foreach (var number in allNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
