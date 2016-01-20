using System;
using System.Collections.Generic;
using System.Linq;

class OddOrEvenElements
{
    static void Main()
    {
        string numbersString = Console.ReadLine();
        if (numbersString == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }

        else
        {
            decimal[] numbers = Array.ConvertAll(numbersString.Split(' '), decimal.Parse);


            List<decimal> odd = new List<decimal>();
            List<decimal> even = new List<decimal>();


            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd.Add(numbers[i]);

                }
                else
                {
                    even.Add(numbers[i]);
                }
            }
            if ((odd.Count == 0 && even.Count == 0) || numbersString == "")
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            if (even.Count == 0)
            {
                decimal oddSum = odd.Sum();
                decimal oddMin = odd.Min();
                decimal oddMax = odd.Max();
                Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
            }
            else
            {
                decimal oddSum = odd.Sum();
                decimal oddMin = odd.Min();
                decimal oddMax = odd.Max();

                decimal evenSum = even.Sum();
                decimal evenMin = even.Min();
                decimal evenMax = even.Max();

                Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}"
                                            , oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
        }    
    }
}