using System;

class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int nSum = 0;
        bool anyMorseCode = false;
        string[] morseCodes = { "-----", ".----", "..---", "...--", "....-", "....." };

        for (int i = 0; i < 4; i++)
        {
            nSum += n % 10;
            n /= 10;
        }
        for (int c0 = 0; c0 <= 5; c0++)
        {
            for (int c1 = 0; c1 <= 5; c1++)
            {
                for (int c2 = 0; c2 <= 5; c2++)
                {
                    for (int c3 = 0; c3 <= 5; c3++)
                    {
                        for (int c4 = 0; c4 <= 5; c4++)
                        {
                            for (int c5 = 0; c5 <= 5; c5++)
                            {
                                int morseProduct = c0 * c1 * c2 * c3 * c4 * c5;
                                if (morseProduct == nSum)
                                {
                                    anyMorseCode = true;
                                    string morseNumber =
                                        morseCodes[c0] + "|" +
                                        morseCodes[c1] + "|" +
                                        morseCodes[c2] + "|" +
                                        morseCodes[c3] + "|" +
                                        morseCodes[c4] + "|" +
                                        morseCodes[c5] + "|";
                                    Console.WriteLine(morseNumber);
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!anyMorseCode)
        {
            Console.WriteLine("No");
        }
    }
}