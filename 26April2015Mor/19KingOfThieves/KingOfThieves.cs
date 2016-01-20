using System;

class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        int inside = 1;
        int outside = n / 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-' ,outside), new string(symbol ,inside));
            outside--;
            inside += 2;
        }
        Console.WriteLine(new string(symbol,n));
        outside = 1;
        for (int i = 0; i < n / 2; i++)
        {
            inside -= 2;
            Console.WriteLine("{0}{1}{0}", new string('-', outside), new string(symbol, inside));
            outside++;
        }
    }
}