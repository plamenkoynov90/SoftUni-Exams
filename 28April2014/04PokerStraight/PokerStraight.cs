using System;

class PokerStraight
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());

        int totalWeight = 0;
        int counter = 0;

        for (int face = 0; face < 10; face++)
        {
            for (int s1 = 0; s1 < 4; s1++)
            {
                for (int s2 = 0; s2 < 4; s2++)
                {
                    for (int s3 = 0; s3 < 4; s3++)
                    {
                        for (int s4 = 0; s4 < 4; s4++)
                        {
                            for (int s5 = 0; s5 < 4; s5++)
                            {
                                totalWeight = ((10 * (face + 1)) + s1 + 1) +
                                              ((20 * (face + 2)) + s2 + 1) +
                                              ((30 * (face + 3)) + s3 + 1) +
                                              ((40 * (face + 4)) + s4 + 1) +
                                              ((50 * (face + 5)) + s5 + 1);
                                if (totalWeight == weight)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}