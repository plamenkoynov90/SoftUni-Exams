using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char startingLetter = char.Parse(Console.ReadLine());
        int dotsMultiplier = 1;
        int dots = 3;


        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dots));
            for (int j = 0; j < 7 - 2*dots; j ++)
            {
                Console.Write(startingLetter);
                startingLetter++;
                    if(startingLetter == 'H')
                {
                    startingLetter = 'A';
                }
            }
            Console.WriteLine(new string('.', dots));
            dots -= dotsMultiplier ;
            if (dots == -1 )
            {
                dots = 1;
                dotsMultiplier *= -1;
            }
            else if ( dots == 4)
            {
                dots = 3;
                dotsMultiplier *= -1;
            }            
        }
    }
}