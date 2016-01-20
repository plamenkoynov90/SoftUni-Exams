using System;

class PetarsGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacementString = Console.ReadLine();

        decimal sum = 0;
        string sumString = "";
        //Loop to cycle over all numbers from startNumber to endNumber
        for (ulong i = startNumber; i < endNumber; i++)
        {
            //Check if the current number i can be divided 5 without reminder
            sum = i % 5 == 0 ? sum + i : sum + (i % 5);
        }
        sumString = sum.ToString();
        //Check if the sum is odd or even and replace the correct symbol with the replacementString
        string replacementSymbol = sum % 2 == 0 ? sumString[0].ToString() : sumString[sumString.Length - 1].ToString();
        sumString = sumString.Replace(replacementSymbol, replacementString);

        //Pring the new string 
        Console.WriteLine(sumString);
    }
}