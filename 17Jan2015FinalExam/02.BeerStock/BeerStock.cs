using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong reservedBeers = ulong.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            ulong allBeers = 0;
            while (command != "Exam Over")
            {
                string[] beerData = command.Split();
                ulong ammountShipped = ulong.Parse(beerData[0]);
                string beerType = beerData[1];

                if (beerType == "beers")
                {
                    allBeers += ammountShipped;
                }
                else if (beerType == "sixpacks")
                {
                    allBeers += ammountShipped * 6uL;
                }
                else if (beerType == "cases")
                {
                    allBeers += ammountShipped * 24uL;
                }

                command = Console.ReadLine();
            }
            ulong beersBreak = allBeers / 100;
            allBeers -= beersBreak;
            if (allBeers >= reservedBeers)
            {
                ulong beersLeft = allBeers - reservedBeers;
                ulong casesLeft = beersLeft / 24;
                ulong sixpacksLeft = (beersLeft % 24) / 6;
                ulong bottlesLeft = (beersLeft % 24) % 6;
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, bottlesLeft);
            }
            else
            {
                ulong beersLeft = reservedBeers - allBeers;
                ulong casesLeft = beersLeft / 24;
                ulong sixpacksLeft = (beersLeft % 24) / 6;
                ulong bottlesLeft = (beersLeft % 24) % 6;
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, bottlesLeft);

            }
        }
    }
}
