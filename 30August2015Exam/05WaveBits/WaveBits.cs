using System;

class WaveBits
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        int bestSequenceLength = 0;
        int endIndex = 0;
        int currentSequenceLength = 1;

        for (int i = 0; i <= 61; i++)
        {

            ulong bitsToCheck = (number >> i) & 7;

            if (bitsToCheck == 5)
            {
                currentSequenceLength += 2;

                if (currentSequenceLength > bestSequenceLength)
                {
                    endIndex = i + 2;
                    bestSequenceLength = currentSequenceLength;
                }
                i++;
            }
            else
            {
                currentSequenceLength = 1;
            }
        }
        
        if(bestSequenceLength == 0)
        {
            Console.WriteLine("No waves found!");
            return;
        }

        int startIndex = (endIndex - bestSequenceLength) + 1;

        int rightMaskCounter = startIndex;
        int leftMaskCounter = endIndex + 1;

        ulong rightSideBits = 0;
        ulong leftSideBits = 0;

        if (rightMaskCounter != 0)
        {
            ulong rightMask = Convert.ToUInt64(new string('1', rightMaskCounter), 2);
            rightSideBits = number & rightMask;
        }
        ulong leftMask = Convert.ToUInt64(new string('0', leftMaskCounter).PadLeft(64,'1'), 2);
        leftSideBits = number & leftMask;

        ulong outputNumber = (leftSideBits >> bestSequenceLength) | rightSideBits;

        Console.WriteLine(outputNumber);
    }
}