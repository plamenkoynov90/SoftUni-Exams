using System;

class CompoundInterest
{
    static void Main()
    {
        double tvPrice = double.Parse(Console.ReadLine());
        int term = int.Parse(Console.ReadLine());
        double yearlyInterestRate = double.Parse(Console.ReadLine());
        double friendInterestRate = double.Parse(Console.ReadLine());

        //Calculate how much you have to pay if you get money from the bank
        double bankLoan = tvPrice * Math.Pow((1 + yearlyInterestRate), term);
        //Calculate how much you have to pay if you get money from your friend
        double friendLoan = tvPrice * (1 + friendInterestRate);

        //Check which loan is better for you
        double bestLoan = friendLoan <= bankLoan ? friendLoan : bankLoan;
        string bestLoanLender = friendLoan <= bankLoan ? "Friend" : "Bank";

        //Print out the answer
        Console.WriteLine("{0:F2} {1}" , bestLoan , bestLoanLender);
    }
}