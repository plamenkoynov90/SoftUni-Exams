using System;

class PlaidTowel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char background = char.Parse(Console.ReadLine());
        char rhombus = char.Parse(Console.ReadLine());


        for (int i = 0; i < 2; i++)
        {

            int outsideBackground = n;
            int insideBackground = (n * 2) - 1;
            int insideRhombBackground = 1;

            int outsideBottomBackground = 1;
            int insideBottomBackground = 1;
            int insideBottomRhombBackground = (n * 2) - 1;

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, outsideBackground), rhombus, new string(background, insideBackground));

            for (int j = 1; j <= n * 2; j++)
            {
                if (j < n)
                {
                    outsideBackground--;
                    insideBackground -= 2;
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, outsideBackground), rhombus, new string(background, insideRhombBackground), new string(background, insideBackground));
                    insideRhombBackground += 2;
                }
                else if (j == n)
                {
                    Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, new string(background, insideRhombBackground));
                }
                else if (j < n * 2)
                {

                    insideBottomRhombBackground -= 2;
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, outsideBottomBackground), rhombus, new string(background, insideBottomRhombBackground), new string(background, insideBottomBackground));
                    outsideBottomBackground++;
                    insideBottomBackground += 2;
                }

            }
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, n), rhombus, new string(background, n * 2 - 1));
    }
}