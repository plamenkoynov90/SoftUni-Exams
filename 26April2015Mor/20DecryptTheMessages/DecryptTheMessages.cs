using System;

class DecrytTheMessages
{
    static void Main()
    {
        string command = Console.ReadLine();
        while (command != "START" && command != "start")
        {
            command = Console.ReadLine();
        }
        command = Console.ReadLine();

        int countMessages = 0;
        string encrypted = string.Empty;

        while (command != "end" && command != "END")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }
            for (int i = command.Length - 1; i >= 0; i--)
            {
                char currentSymbol = command[i];

                if (('a' <= currentSymbol && 'm' >= currentSymbol) || ('A' <= currentSymbol && 'M' >= currentSymbol))
                {

                    encrypted += (char)(currentSymbol + 13);
                }
                else if (('n' <= currentSymbol && 'z' >= currentSymbol) || ('N' <= currentSymbol && 'Z' >= currentSymbol))
                {

                    encrypted += (char)(currentSymbol - 13);
                }
                else if (('0' <= currentSymbol && '9' >= currentSymbol))
                {

                    encrypted += currentSymbol;
                }
                else
                {
                    switch (currentSymbol)
                    {
                        case '+':
                            encrypted += ' ';
                            break;
                        case '%':
                            encrypted += ',';
                            break;
                        case '&':
                            encrypted += '.';
                            break;
                        case '#':
                            encrypted += '?';
                            break;
                        case '$':
                            encrypted += '!';
                            break;
                    }
                }
            }
            encrypted += Environment.NewLine;
            countMessages++;
            command = Console.ReadLine();
        }
        if (countMessages == 0)
        {
            Console.WriteLine("No message received.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", countMessages);

            Console.Write(encrypted);
        }
    }
}