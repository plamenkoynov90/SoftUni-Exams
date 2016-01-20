using System;

public class Pairs
{
    public static void Main()
    {
        int[] numbersInt = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] sumsArray = new int[numbersInt.Length / 2];
        int[] differencesBetweenSums = new int[sumsArray.Length - 1];
        int counter = 0;
        int sumMin = int.MinValue;
        int sumMax = int.MinValue;

        for (int i = 0; i < sumsArray.Length; i++)
        {
            sumsArray[i] = numbersInt[counter++] + numbersInt[counter++];
        }
        counter = 0;
        for (int i = 0; i < sumsArray.Length - 1; i++)
        {
            differencesBetweenSums[i] = Math.Abs(sumsArray[counter++] - sumsArray[counter++]);
            counter--;
        }
        Array.Sort(sumsArray);
        Array.Sort(differencesBetweenSums);
        sumMin = sumsArray[0];
        sumMax = sumsArray[sumsArray.Length - 1];

        if (sumMax == sumMin)
        {
            Console.WriteLine("Yes, value={0}", sumMax);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", (differencesBetweenSums[differencesBetweenSums.Length-1]));
        }
    }
}