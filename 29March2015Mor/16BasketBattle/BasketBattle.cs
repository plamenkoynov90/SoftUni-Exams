using System;

class BasketBattle
{
    static void Main()
    {
        string startFirst = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());

        int simeonPoints = 0;
        int nakovPoints = 0;
        int winningRound = 0;
        bool winnerBetweenRounds = false;

        for (int i = 0; i < rounds; i++)
        {
            winningRound++;
            int firstShooterAttempt = int.Parse(Console.ReadLine());
            string firstShooterResult = Console.ReadLine();

            if (firstShooterResult == "success")
            {
                if (startFirst == "Simeon")
                {
                    if (i % 2 == 0 && simeonPoints + firstShooterAttempt <= 500)
                    {
                        simeonPoints += firstShooterAttempt;
                    }
                    else if (i % 2 != 0 && nakovPoints + firstShooterAttempt <= 500)
                    {
                        nakovPoints += firstShooterAttempt;
                    }
                }
                else if (startFirst == "Nakov")
                {
                    if (i % 2 == 0 && nakovPoints + firstShooterAttempt <= 500)
                    {
                        nakovPoints += firstShooterAttempt;
                    }
                    else if (i % 2 != 0 && simeonPoints + firstShooterAttempt <= 500)
                    {
                        simeonPoints += firstShooterAttempt;
                    }
                }
            }
            if (simeonPoints == 500)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(winningRound);
                Console.WriteLine(nakovPoints);
                winnerBetweenRounds = true;
                break;
            }
            else if (nakovPoints == 500)
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(winningRound);
                Console.WriteLine(simeonPoints);
                winnerBetweenRounds = true;
                break;
            }
            int secondShooterAttempt = int.Parse(Console.ReadLine());
            string secondShooterResult = Console.ReadLine();

            if (secondShooterResult == "success")
            {
                if (startFirst == "Simeon")
                {
                    if (i % 2 == 0 && nakovPoints + secondShooterAttempt <= 500)
                    {
                        nakovPoints += secondShooterAttempt;
                    }
                    else if (i % 2 != 0 && simeonPoints + secondShooterAttempt <= 500)
                    {
                        simeonPoints += secondShooterAttempt;
                    }
                }
                else if (startFirst == "Nakov")
                {
                    if (i % 2 == 0 && simeonPoints + secondShooterAttempt <= 500)
                    {
                        simeonPoints += secondShooterAttempt;
                    }
                    else if (i % 2 != 0 && nakovPoints + secondShooterAttempt <= 500)
                    {
                        nakovPoints += secondShooterAttempt;
                    }
                }
            }
            if (simeonPoints == 500)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(winningRound);
                Console.WriteLine(nakovPoints);
                winnerBetweenRounds = true;                
            }
            else if (nakovPoints == 500)
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(winningRound);
                Console.WriteLine(simeonPoints);
                winnerBetweenRounds = true;                
            }
        }
        if (!winnerBetweenRounds && simeonPoints == nakovPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(nakovPoints);
        }
        else if (!winnerBetweenRounds && nakovPoints > simeonPoints)
        {
            Console.WriteLine("Nakov");
            Console.WriteLine(nakovPoints - simeonPoints);
        }
        else if (!winnerBetweenRounds && simeonPoints > nakovPoints)
        {
            Console.WriteLine("Simeon");
            Console.WriteLine(simeonPoints - nakovPoints);
        }
    }
}