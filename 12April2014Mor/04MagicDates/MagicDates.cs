using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        bool isThereMagicDate = false;

        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            if (SumDate(i, magicWeight) == magicWeight)
            {
                isThereMagicDate = true;
                Console.WriteLine(i.ToString("dd-MM-yyyy"));
            }
        }
        if (!isThereMagicDate)
        {
            Console.WriteLine("No");
        }
    }

    static int SumDate(DateTime date, int magicWeight)
    {
        int sum = 0;
        string dateFormat = "ddMMyyyy";
        string dateString = date.ToString(dateFormat);
        int[] dateNumbers = new int[dateString.Length];
        for (int i = 0; i < dateNumbers.Length; i++)
        {
            dateNumbers[i] = dateString[i] - '0';
        }
        for (int i = 0; i < dateNumbers.Length; i++)
        {
            for (int j = i + 1; j < dateNumbers.Length; j++)
            {
                sum += dateNumbers[i] * dateNumbers[j];
            }
        }
        return sum;
    }
}