using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02WeirdCombinations
{
    class WeirdCombinations
    {
        static void Main(string[] args)
        {
            string inputSequence = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            string finalSequence = "";
            bool hasResult = false;
            for (int i = 0; i < inputSequence.Length; i++)
            {
                for (int j = 0; j < inputSequence.Length; j++)
                {
                    for (int k = 0; k < inputSequence.Length; k++)
                    {
                        for (int p = 0; p < inputSequence.Length; p++)
                        {
                            for (int r = 0; r < inputSequence.Length; r++)
                            {
                                if (counter == n)
                                {
                                    finalSequence = string.Concat("" + inputSequence[i] +
                                                                  inputSequence[j] +
                                                                  inputSequence[k] +
                                                                  inputSequence[p] +
                                                                  inputSequence[r]);
                                    Console.WriteLine(finalSequence);
                                    hasResult = true;                                  
                                }       
                                                        
                                    counter++;                                
                            }
                        }
                    }
                }
            }
            if(!hasResult)
            {
                Console.WriteLine("No");
            }
        }
    }
}
