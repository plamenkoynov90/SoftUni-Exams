using System;

class BitShooter
{
    static void Main()
    {
        ulong inputNumber = ulong.Parse(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {
            string[] shootingData = Console.ReadLine().Split();
            int center = int.Parse(shootingData[0]);
            int shootSize = int.Parse(shootingData[1]);
            int startPoint = center - (shootSize / 2);
            int endPoint = center + (shootSize / 2);
            if (center - (shootSize / 2) < 0)
            {
                startPoint = 0;
            }
            if (center + (shootSize / 2) > 63)
            {
                endPoint = 63;
            }
            shootSize = (endPoint - startPoint) + 1;
            ulong mask = Convert.ToUInt64(new string('1', shootSize), 2);
            inputNumber &= ~(mask << startPoint);
        }
        int leftCounter = 0;
        int rightCounter = 0;
        for (int i = 0; i < 64; i++)
        {
            ulong currentBit = inputNumber & 1uL;
            if (currentBit == 1)
            {
                if (i < 32)
                {
                    rightCounter++;
                }
                else
                {
                    leftCounter++;
                }
            }
            inputNumber >>= 1;
        }
        Console.WriteLine("left: {0}", leftCounter);
        Console.WriteLine("right: {0}", rightCounter);
    }
}
