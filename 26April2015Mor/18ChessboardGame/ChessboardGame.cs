using System;

class ChessboardGame
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string inputString = Console.ReadLine();

        int blackTeam = 0;
        int whiteTeam = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            char currentChar = inputString[i];
            if(i >= Math.Pow(size , 2))
            {
                break;
            }
            if (char.IsLetterOrDigit(currentChar))
            {
                if (i % 2 == 0 && char.IsUpper(currentChar))
                {
                    whiteTeam += currentChar;
                }
                else if (i % 2 == 0 && char.IsLetterOrDigit(currentChar))
                {
                    blackTeam += currentChar;
                }
                else if (i % 2 != 0 && char.IsUpper(currentChar))
                {
                    blackTeam += currentChar;
                }
                else if (i % 2 != 0 && char.IsLetterOrDigit(currentChar))
                {
                    whiteTeam += currentChar;
                }
            }
        }
        string winner = blackTeam > whiteTeam ? "black" : "white";
        int winnerPoints = blackTeam > whiteTeam || whiteTeam > blackTeam ? Math.Abs(blackTeam - whiteTeam) : blackTeam;
        if (blackTeam == whiteTeam)
        {
            Console.WriteLine("Equal result: {0}", winnerPoints);
        }
        else
        {
            Console.WriteLine("The winner is: {0} team", winner);
            Console.WriteLine(winnerPoints);
        }
    }
}