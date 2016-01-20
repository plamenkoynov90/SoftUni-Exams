using System;

class NakovsMatching
{
    private const char DELIMETER = '|';
    static void Main()
    {
        string stringA = Console.ReadLine();
        string stringB = Console.ReadLine();
        int limitNumber = int.Parse(Console.ReadLine());

        bool matchesFound = false;
        for (int i = 1; i < stringA.Length; i++)
        {
            string newStringA = stringA;
            newStringA = newStringA.Insert(i, "|");
            for (int j = 1; j < stringB.Length; j++)
            {
                string newStringB = stringB;
                newStringB = newStringB.Insert(j, "|");
                int nakovW = NakovsWeight(newStringA, newStringB);
                if (nakovW <= limitNumber)
                {
                    matchesFound = true;
                    Console.WriteLine("({0}) matches ({1}) by {2} nakovs", newStringA, newStringB, nakovW);
                }
            }
        }
        if(!matchesFound)
        {
            Console.WriteLine("No");
        }
    }
    static int NakovsWeight(string a, string b)
    {
        string[] strA = a.Split('|');
        string[] strB = b.Split('|');
        string aLeft = strA[0];
        string aRight = strA[1];
        string bLeft = strB[0];
        string bRight = strB[1];
        int aLeftWeight = CalculateWeight(aLeft);
        int aRightWeight = CalculateWeight(aRight);
        int bLeftWeight = CalculateWeight(bLeft);
        int bRightWeight = CalculateWeight(bRight);

        int nakovWeight = Math.Abs((aLeftWeight * bRightWeight) - (aRightWeight * bLeftWeight));
        return nakovWeight;
    }
    static int CalculateWeight(string str)
    {
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char currentLetter = str[i];
            sum += currentLetter;
        }
        return sum;
    }
}