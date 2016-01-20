using System;

class TorrentPirate
{
    static void Main()
    {
        int downloadData = int.Parse(Console.ReadLine());
        int priceOneMovie = int.Parse(Console.ReadLine());
        int wifeSpendPerHour = int.Parse(Console.ReadLine());

        double downloadTime = (double)downloadData / 2 / 60 / 60;
        double priceForDownload = downloadTime * wifeSpendPerHour;
        double moviesDownloaded = (double)downloadData / 1500;
        double totalCinemaPrice = moviesDownloaded * priceOneMovie;

        if (totalCinemaPrice < priceForDownload)
        {
            Console.WriteLine("cinema -> {0:0.00}lv" , totalCinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:0.00}lv", priceForDownload);
        }
    }
}