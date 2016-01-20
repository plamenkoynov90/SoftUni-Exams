using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ShuffleBits
{
    class ShuffleBits
    {
        static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            ulong finalNumber = 0;
            int counter = 63;

            if (firstNumber >= secondNumber)
            {
                for (int j = 31; j >= 0; j--)
                {
                    ulong firstNumberBit = firstNumber >> j & 1L;
                    ulong secondNumberBit = secondNumber >> j & 1L;

                    finalNumber |= firstNumberBit << counter;
                    finalNumber |= secondNumberBit << counter - 1;
                    counter -= 2;
                }

            }
            else
            {
                counter = 62;
                for (int j = 30; j >= 0; j -= 2)
                {
                    ulong firstNumberBit = firstNumber >> j & 3L;
                    ulong secondNumberBit = secondNumber >> j & 3L;

                    finalNumber |= firstNumberBit << counter;
                    finalNumber |= secondNumberBit << counter - 2;

                    counter -= 4;
                }
            }
            Console.WriteLine(finalNumber);
        }
    }
}

