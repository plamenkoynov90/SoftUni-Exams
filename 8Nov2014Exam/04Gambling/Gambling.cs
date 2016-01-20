using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Gambling
{
    class Gambling
    {
        static void Main(string[] args)
        {
            decimal cashAmount = decimal.Parse(Console.ReadLine());
            string[] houseHand = Console.ReadLine().Split();
            string[] allCards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            int houseStrength = CalculateStrenght(houseHand);
            int allPosibleHands = 0;
            int allWinningHands = 0;
            
            for (int c1 = 0; c1 < 13; c1++)
            {
                for (int c2 = 0; c2 < 13; c2++)
                {
                    for (int c3 = 0; c3 < 13; c3++)
                    {
                        int currentHandStrength = 0;
                        for (int c4 = 0; c4 < 13; c4++)
                        {
                            string[] currentHand = { allCards[c1], allCards[c2], allCards[c3], allCards[c4] };
                            currentHandStrength = CalculateStrenght(currentHand);
                            if(houseStrength < currentHandStrength)
                            {
                                allWinningHands++;
                            }
                            allPosibleHands++;
                        }
                    }
                }
            }
            decimal probabillity = (decimal)allWinningHands / allPosibleHands;
            decimal expectedWinnings = (2 * cashAmount) * probabillity;
            if (probabillity* 100 < 50)
            {
                Console.WriteLine("FOLD");
            }
            else
            {
                Console.WriteLine("DRAW");
            }
            Console.WriteLine("{0:F2}" , expectedWinnings);

        }

        public static int CalculateStrenght(string[] hand)
        {
            int strength = 0;
            for (int i = 0; i < hand.Length; i++)
            {
                string currentCard = hand[i];
                switch (currentCard)
                {
                    case "J": strength += 11; break;
                    case "Q": strength += 12; break;
                    case "K": strength += 13; break;
                    case "A": strength += 14; break;
                    default: strength += int.Parse(currentCard); break;
                }
            }
            return strength;
        }
    }
}
