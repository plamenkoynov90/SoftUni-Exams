using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int joins = 0;

        for (int i = 0; i < n; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine(); 
            if ( measure == "meters")
            {
                cableLength *= 100;
            }
            if (cableLength >= 20)
            {
                sum += cableLength;
                joins++;                
            }
        }
        sum -= 3 * (joins - 1);
        int numberOfCables = sum / 504;
        int cableLeft = sum % 504;
        Console.WriteLine(numberOfCables);
        Console.WriteLine(cableLeft);            
    }
}