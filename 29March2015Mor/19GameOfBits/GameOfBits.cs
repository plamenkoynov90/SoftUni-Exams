using System;

class GameOfBits
{
    static void Main()
    {
        uint inputNumber = uint.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        uint currentBit = 0;
        uint extractBits = 0;
        uint mask = 1;
        int counter = 0;
        uint playNumber = inputNumber;        

        while (command != "Game Over!")
        {                        
            for (int i = 0; i < 32; i++)
            {
                if (command == "Odd" && i % 2 == 0)
                {
                    currentBit = playNumber & (mask << i);                    
                    extractBits = extractBits | (currentBit >> counter) ;
                    counter++;
                }
                else if (command == "Even" && i % 2 != 0)
                {
                    currentBit = playNumber & (mask << i);
                    extractBits = extractBits | (currentBit >> counter + 1);
                    counter++;
                }
            }
            playNumber = extractBits;
            extractBits = 0;
            counter = 0;           
                                    
            command = Console.ReadLine();
        }
        currentBit = 0;
        for ( int i = 0; i < 32; i++)
        {
            currentBit = playNumber & (mask << i);
            if (currentBit != 0)
            {
                counter++;
            }
        }
        Console.WriteLine("{0} -> {1}" , playNumber , counter);
    }
}