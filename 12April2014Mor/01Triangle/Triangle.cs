using System;

class Triangle
{
    static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double sideA = FindTriangleSidesValue(bX, cX, bY, cY);
        double sideB = FindTriangleSidesValue(aX, cX, aY, cY);
        double sideC = FindTriangleSidesValue(bX, aX, bY, aY);

        if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double areaOfTriangle = Math.Sqrt(
                halfPerimeter * ((halfPerimeter - sideA) * 
                                 (halfPerimeter - sideB) * 
                                 (halfPerimeter - sideC)));
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}" , areaOfTriangle);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", sideC);
        }
    }
    static double FindTriangleSidesValue(int x1, int x2, int y1, int y2)
    {
        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return distance;
    }
}