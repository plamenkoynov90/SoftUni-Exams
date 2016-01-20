using System;
using System.Collections.Generic;

class TheFootballStatistician
{
    static void Main()
    {
        double paymentInEuro = double.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        List<string> teams = new List<string>()
        { "Arsenal" , "Chelsea", "Everton", "Liverpool", "ManchesterCity", "ManchesterUnited", "Southampton","Tottenham"};
        List<int> points = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0 };

        double totalPaymentInLeva = 0;

        while (command != "End of the league.")
        {            
            string[] commandArray = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        
            string firstTeam = commandArray[0].Trim();
            string matchOutcome = commandArray[1].Trim();
            string secondTeam = commandArray[2].Trim();

            totalPaymentInLeva += paymentInEuro * 1.94d;
            int teamIndex = 0;

            if (matchOutcome == "1")
            {
                teamIndex = teams.IndexOf(firstTeam);
                points[teamIndex] += 3;
            }
            else if (matchOutcome == "2")
            {
                teamIndex = teams.IndexOf(secondTeam);
                points[teamIndex] += 3;
            }
            else
            {
                teamIndex = teams.IndexOf(firstTeam);
                points[teamIndex]++;

                teamIndex = teams.IndexOf(secondTeam);
                points[teamIndex]++;
            }

            command = Console.ReadLine();
        }
        teams[4] = "Manchester City";
        teams[5] = "Manchester United";

        Console.WriteLine("{0:F2}lv.", totalPaymentInLeva);

        for (int i = 0; i < teams.Count; i++)
        {
            Console.WriteLine("{0:F2} - {1} points.", teams[i], points[i]);
        }
    }
}