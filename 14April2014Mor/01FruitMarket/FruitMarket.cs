using System;
using System.Collections.Generic;

class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        double quantity1 = double.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        double quantity2 = double.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        double quantity3 = double.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        double sum = 0;

        Dictionary<string, double> prodPrice = new Dictionary<string, double>()
        {
            {"banana" , 1.80},
            {"cucumber" , 2.75},
            {"tomato" , 3.20},
            {"orange" , 1.60},
            {"apple" , 0.86},
        };
        if (dayOfWeek == "Friday")
        {
            sum = ((prodPrice[product1] * quantity1) + (prodPrice[product2] * quantity2) + (prodPrice[product3] * quantity3));
            sum -= sum * 0.10;
        }
        else if (dayOfWeek == "Sunday")
        {
            sum = ((prodPrice[product1] * quantity1) + (prodPrice[product2] * quantity2) + (prodPrice[product3] * quantity3));
            sum -= sum * 0.05;
        }
        else if (dayOfWeek == "Tuesday")
        {
            prodPrice["banana"] = 1.80 - (1.80 * 0.20);
            prodPrice["orange"] = 1.60 - (1.60 * 0.20);
            prodPrice["apple"] = 0.86 - (0.86 * 0.20);
            sum = ((prodPrice[product1] * quantity1) + (prodPrice[product2] * quantity2) + (prodPrice[product3] * quantity3));
        }
        else if (dayOfWeek == "Wednesday")
        {
            prodPrice["cucumber"] = 2.75 - (2.75 * 0.10);
            prodPrice["tomato"] = 3.20 - (3.20 * 0.10);
            sum = ((prodPrice[product1] * quantity1) + (prodPrice[product2] * quantity2) + (prodPrice[product3] * quantity3));
        }
        else if (dayOfWeek == "Thursday")
        {
            prodPrice["banana"] = 1.80 - (1.80 * 0.30);
            sum = ((prodPrice[product1] * quantity1) + (prodPrice[product2] * quantity2) + (prodPrice[product3] * quantity3));
        }
        else
        {
            sum = ((prodPrice[product1] * quantity1) + (prodPrice[product2] * quantity2) + (prodPrice[product3] * quantity3));
        }
        Console.WriteLine("{0:F2}" , sum);
    }
}