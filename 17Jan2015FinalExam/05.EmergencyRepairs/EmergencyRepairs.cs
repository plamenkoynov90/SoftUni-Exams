using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString((long)number,2).PadLeft(64,'0'));
            int emergencyKitsCount = int.Parse(Console.ReadLine());
            int attacksCount = int.Parse(Console.ReadLine());
            int totalKits = emergencyKitsCount;
            for (int i = 0; i < attacksCount; i++)
            {
                int currentAttack = int.Parse(Console.ReadLine());
                number &= ~(1uL << currentAttack);
            }
            //Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));

            ulong newNumber = number;
            for (int i = 1; i < 64; i++)
            {
                ulong currentBit = (newNumber >> i - 1) & 1uL;
                //Console.WriteLine(Convert.ToString((long)currentBit, 2).PadLeft(64, '0'));
                ulong nextBit = (newNumber >> i) & 1uL;
                //Console.WriteLine(Convert.ToString((long)nextBit, 2).PadLeft(64, '0'));

                if (currentBit == 0 && nextBit == 0)
                {
                    number |= 1ul << i - 1;
                    //Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));
                    emergencyKitsCount--;

                    while (emergencyKitsCount > 0 && nextBit == 0)
                    {
                        number |= 1uL << i;
                        emergencyKitsCount--;
                        i++;
                        nextBit = (newNumber >> i) & 1uL;
                        //Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));
                    }
                    if (emergencyKitsCount == 0)
                    {
                        break;
                    }
                }

            }
            if (newNumber >= 0 && totalKits != 0 )
            {
                Console.WriteLine(number);
            }
            else
            {

                Console.WriteLine(newNumber);
            }
        }
    }
}
