using System;

class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int xOne = int.Parse(Console.ReadLine());
        int yOne = int.Parse(Console.ReadLine());
        int xTwo = int.Parse(Console.ReadLine());
        int yTwo = int.Parse(Console.ReadLine());
        int xThree = int.Parse(Console.ReadLine());
        int yThree = int.Parse(Console.ReadLine());
        int xFour = int.Parse(Console.ReadLine());
        int yFour = int.Parse(Console.ReadLine());
        int xFive = int.Parse(Console.ReadLine());
        int yFive = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPointInTheBuilding(xOne , yOne , h));
        Console.WriteLine(IsPointInTheBuilding(xTwo , yTwo , h));
        Console.WriteLine(IsPointInTheBuilding(xThree , yThree , h));
        Console.WriteLine(IsPointInTheBuilding(xFour , yFour , h));
        Console.WriteLine(IsPointInTheBuilding(xFive , yFive , h));

    }
    private static string IsPointInTheBuilding(int x, int y, int size)
    {
        bool insideDown =
            (x >= 0) && (x <= 3 * size) && (y >= 0) && (y <= size);
        bool insideUp =
            (x >= size) && (x <= 2 * size) && (y >= size) && (y <= 4 * size);
        bool inside = insideDown | insideUp;
        string result = inside ? "inside" : "outside";
        return result;
    }
}