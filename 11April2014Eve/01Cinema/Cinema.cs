using System;

class Cinema
{
    static void Main()
    {
        string typeOfProjection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        double ticketPrize = 0;

        switch (typeOfProjection)
        {
            case "Premiere":
                ticketPrize = 12;
                break;
            case "Normal":
                ticketPrize = 7.50;
                break;
            case "Discount":
                ticketPrize = 5;
                break;
        }
        double totalIncomes = (rows * cols) * ticketPrize;
        Console.WriteLine("{0:0.00} leva" , totalIncomes);
    }
}