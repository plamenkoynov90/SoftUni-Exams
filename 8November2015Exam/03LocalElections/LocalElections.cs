using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LocalElections
{
    class LocalElections
    {
        static void Main(string[] args)
        {
            int numberOfCandidates = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            char votingSymbol = char.Parse(Console.ReadLine());
            votingSymbol = char.ToLower(votingSymbol);


            for (int i = 0; i < numberOfCandidates; i++)
            {
                if (i + 1 == vote)
                {
                    if(votingSymbol == 'x')
                    {
                        Console.WriteLine(new string('.', 13));
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '+', new string('-', 5));
                        Console.WriteLine("...|.\\./.|...");
                        Console.WriteLine("{0:00}{1}{2}{3}{2}{4}", (i + 1), '.', '|',"..X..", new string('.', 3));
                        Console.WriteLine("...|./.\\.|...");
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '+', new string('-', 5));

                    }
                    else if(votingSymbol == 'v')
                    {
                        Console.WriteLine(new string('.', 13));
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '+', new string('-', 5));
                        Console.WriteLine("...|\\.../|...");
                        Console.WriteLine("{0:00}{1}{2}{3}{2}{4}", (i + 1), '.', '|', ".\\./.", new string('.', 3));
                        Console.WriteLine("...|..V..|...");
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '+', new string('-', 5));
                    }
                }
                else
                {
                    Console.WriteLine(new string('.', 13));
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '+', new string('-', 5));
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '|', new string('.', 5));
                    Console.WriteLine("{0:00}{1}{2}{3}{2}{4}", (i + 1), '.', '|', new string('.', 5), new string('.', 3));
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '|', new string('.', 5));
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), '+', new string('-', 5));
                    
                }
            }
            Console.WriteLine(new string('.', 13));
        }
    }
}
