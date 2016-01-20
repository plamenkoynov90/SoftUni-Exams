using System;

class TeleportPoints
{
    static void Main()
    {
        double[] pointA = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        double[] pointB = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        double[] pointC = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        double[] pointD = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        double aX = pointA[0];
        double aY = pointA[1];
        double bX = pointB[0];
        double bY = pointB[1];
        double cX = pointC[0];
        double cY = pointC[1];
        double dX = pointD[0];
        double dY = pointD[1];

        int counter = 0;
        //Check right side
        for (double x = 0; x <= radius; x += step)
        {
            //Check upper quadrant
            for (double y = 0; y <= radius; y += step)
            {
                counter =  CheckTeleportPoint(x, y, radius, counter, aX, bX, cY, bY);
            }
            //Check lower quadrant
            for (double y = -step; y >= -radius; y -= step)
            {
                counter = CheckTeleportPoint(x, y, radius, counter, aX, bX, cY, bY);
            }
        }
        //Check left side
        for (double x = -step; x >= -radius; x -= step)
        {
            //Check upper quadrant
            for (double y = 0; y <= radius; y += step)
            {
                counter = CheckTeleportPoint(x, y, radius, counter, aX, bX, cY, bY);
            }
            //Check lower quadrant
            for (double y = -step; y >= -radius; y -= step)
            {
                counter = CheckTeleportPoint(x, y, radius, counter, aX, bX, cY, bY);
            }
        }
        Console.WriteLine(counter);
    }
    private static int CheckTeleportPoint(double x, double y, double radius, int counter, double aX, double bX, double cY, double bY)
    {
        bool inCircle = (x * x) + (y * y) <= radius * radius;
        bool inRectangle = (x > aX && x < bX) && (y < cY && y > bY);

        if (inCircle && inRectangle)
        {
            counter++;
        }
        return counter;
    }
}