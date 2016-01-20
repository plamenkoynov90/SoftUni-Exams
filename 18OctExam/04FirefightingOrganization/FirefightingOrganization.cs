using System;

class FirefightingOrganization
{
    static void Main()
    {
        int firefighters = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();
        int totalKids = 0;
        int totalAdults = 0;
        int totalSeniors = 0;

        while (command != "rain")
        {
        int totalSaved = 0;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'K' && totalSaved < firefighters)
                {
                    totalKids++;
                    totalSaved++;
                }
            }
            for (int j = 0; j < command.Length; j++)
            { 
                if (command[j] == 'A' && totalSaved < firefighters)
                {
                    totalAdults++;
                    totalSaved++;
                }
            }
            for (int h = 0; h < command.Length; h++)
            {
                if (command[h] == 'S' && totalSaved < firefighters)
                {
                    totalSeniors++;
                    totalSaved++;
                }
            }
            
            command = Console.ReadLine();
        }
        Console.WriteLine("Kids: {0}" , totalKids);
        Console.WriteLine("Adults: {0}" , totalAdults);
        Console.WriteLine("Seniors: {0}" , totalSeniors);
    }
}