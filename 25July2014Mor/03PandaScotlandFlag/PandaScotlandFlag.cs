using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char letter = 'A';
        letter--;
        int counter = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{3}{0}",
                new string('~', i), letter < 'Z' ? ++letter : letter = 'A',
                new string('#', (n - 2) - counter),
                letter < 'Z' ? ++letter : letter = 'A');
            counter += 2;

        }
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), letter < 'Z' ? ++letter : letter = 'A');
        counter = 1;
        for (int i = n / 2; i > 0; i--)
        {

            Console.WriteLine("{0}{1}{2}{3}{0}",
                new string('~', i - 1),
                letter < 'Z' ? ++letter : letter = 'A',
                new string('#', counter),
                letter < 'Z' ? ++letter : letter = 'A');
            counter += 2;
        }
    }
}