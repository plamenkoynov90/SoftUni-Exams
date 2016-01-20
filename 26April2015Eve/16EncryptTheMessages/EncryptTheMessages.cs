using System;

class EncryptTheMessages
{
    static void Main()
    {
        string command = Console.ReadLine();
        //Loop to check if you start the program
        while (command != "start" && command != "START")
        {
            command = Console.ReadLine();
        }
        command = Console.ReadLine();

        int countMessages = 0;
        string encryptMessages = string.Empty;
        //Loop to check if you stop the program
        while (command != "end" && command != "END")
        {
            //Chech if command is null or white space(" ")
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }
            //Cycle trough all the characters in the message and encrypt them
            for (int i = command.Length - 1; i >= 0; i--)
            {
                char currentCharacther = command[i];
                //Check if currentCharacther is letter and encrypt them the right way
                if ('a' <= currentCharacther && currentCharacther <= 'm' || 'A' <= currentCharacther && currentCharacther <= 'M')
                {
                    encryptMessages += (char)(currentCharacther + 13);
                }
                else if ('n' <= currentCharacther && currentCharacther <= 'z' || 'N' <= currentCharacther && currentCharacther <= 'Z')
                {
                    encryptMessages += (char)(currentCharacther - 13);
                }
                //Check if currentCharacther is digit and encrypt them the right way
                else if ('0' <= currentCharacther && currentCharacther <= '9')
                {
                    encryptMessages += currentCharacther;
                }
                //Check if currentCharacther is symbol and encrypt them the right way
                else
                {
                    switch (currentCharacther)
                    {
                        case ' ':
                            encryptMessages += '+';
                            break;
                        case ',':
                            encryptMessages += '%';
                            break;
                        case '.':
                            encryptMessages += '&';
                            break;
                        case '?':
                            encryptMessages += '#';
                            break;
                        case '!':
                            encryptMessages += '$';
                            break;
                    }
                }
            }
            encryptMessages += Environment.NewLine;
            //Count how much messages you send
            countMessages++;

            command = Console.ReadLine();
        }
        //Check if you have messages send and print the write result
        if (countMessages == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}" , countMessages);
            Console.WriteLine(encryptMessages);
        }
    }
}