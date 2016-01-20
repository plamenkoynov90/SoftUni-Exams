using System;

class BookOrders
{
    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());

        int totalBooks = 0;
        double totalPrice = 0;
        double discount = 0;

        for (int order = 0; order < numberOfOrders; order++)
        {
            int packetsCount = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());

            if(packetsCount < 10)
            {
                discount = 0;
            }
            else if(packetsCount < 20)
            {
                discount = 5 / 100d;
            }
            else if (packetsCount < 30)
            {
                discount = 6 / 100d;
            }
            else if (packetsCount < 40)
            {
                discount = 7 / 100d;
            }
            else if (packetsCount < 50)
            {
                discount = 8 / 100d;
            }
            else if (packetsCount < 60)
            {
                discount = 9 / 100d;
            }
            else if (packetsCount < 70)
            {
                discount = 10 / 100d;
            }
            else if (packetsCount < 80)
            {
                discount = 11 / 100d;
            }
            else if (packetsCount < 90)
            {
                discount = 12 / 100d;
            }
            else if (packetsCount < 100)
            {
                discount = 13 / 100d;
            }
            else if (packetsCount < 110)
            {
                discount = 14 / 100d;
            }
            else
            {
                discount = 15 / 100d;
            }
            double finalPriceForBook = bookPrice;
            if (discount != 0)
            {
                finalPriceForBook = bookPrice - (bookPrice * discount);
            }
            int totalBooksInOrder = booksPerPacket * packetsCount;
            double totalPriceInOrder = totalBooksInOrder * finalPriceForBook;
            totalBooks += totalBooksInOrder;
            totalPrice += totalPriceInOrder;
        }
        Console.WriteLine(totalBooks);
        Console.WriteLine("{0:0.00}" , totalPrice);
    }
}