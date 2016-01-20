using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int skyLeft = n - 1;
        int sail = 1;
        int water = 0;
        int boatBody = n * 2;


        for (int i = 1; i <= n + ((n-1)/2); i++)
        {
            if ( i < (n / 2) + 1)
            {
                Console.WriteLine("{0}{1}{2}" , new string('.' , skyLeft), new string('*' , sail), new string('.' , n));
                skyLeft -= 2;
                sail += 2;
            }
            else if (i <= n)
            {
                Console.WriteLine("{0}{1}{2}", new string('.', skyLeft), new string('*', sail), new string('.', n));
                skyLeft += 2;
                sail -= 2;
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('.' , water) ,new string('*' , boatBody));
                boatBody -= 2;
                water += 1;
            }
        }
    }
}