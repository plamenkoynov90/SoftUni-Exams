using System;

class SumOfElements
{
    static void Main()
    {
        int[] numbersArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Array.Sort(numbersArr);

        long sum = 0;
        for (int i = 0; i < numbersArr.Length - 1; i++)
        {
            sum += numbersArr[i];
        }
        if (sum == numbersArr[numbersArr.Length - 1])
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum - numbersArr[numbersArr.Length - 1]));
        }
    }
}