using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //Print the top of the star
        string starTop = string.Concat(new string('.', (n * 3 + 2) / 2), '*', new string('.', (n * 3 + 2) / 2));
        Console.WriteLine(starTop);
        int inside = 1;
        for (int i = 1; i <= (n / 2 + 1); i++)
        {
            string leftSide = string.Concat(new string('.', ((n * 3 + 2) / 2) - i), '*');
            string middle = new string('.', inside);
            string rightSide = string.Concat('*', new string('.', ((n * 3 + 2) / 2) - i));
            Console.WriteLine("{0}{1}{2}", leftSide, middle, rightSide);
            inside += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));

        //Print the middle of the star
        for (int i = 1; i <= n / 2; i++)
        {
            string leftSide = string.Concat(new string('.', i), '*');
            string middle = new string('.', (3 * n + 2) - (i * 2 + 2));
            string rightSide = string.Concat('*', new string('.', i));
            Console.WriteLine("{0}{1}{2}", leftSide, middle, rightSide);
        }
        //Print the bottom of the star
        int outside = n / 2 - 1;
        for (int i = 0; i < n / 2; i++)
        {
            string leftSide = string.Concat(new string('.', outside - i), '*', new string('.', n / 2), '*', new string('.', i));
            string middle = string.Concat('*', new string('.', n), '*');
            string rightSide = string.Concat(new string('.', i), '*', new string('.', n / 2), '*', new string('.', outside - i));
            Console.WriteLine("{0}{1}{2}", leftSide, middle, rightSide);
        }
        string starBottomLeft = string.Concat(new string('*', n / 2 + 1), new string('.', n / 2));
        string starBottomMiddle = string.Concat('*', new string('.', n), '*');
        string starBottomRight = string.Concat(new string('.', n / 2), new string('*', n / 2 + 1));
        Console.WriteLine("{0}{1}{2}", starBottomLeft, starBottomMiddle, starBottomRight);
        //Print the wand handle 
        for (int i = 0; i < n; i++)
        {
            string wandHandle = string.Concat(new string('.', n), '*', new string('.', n), '*', new string('.', n));
            Console.WriteLine(wandHandle);
        }
        string wandHandleBottom = string.Concat(new string('.', n), new string('*', n + 2), new string('.', n));
        Console.WriteLine(wandHandleBottom);
    }
}