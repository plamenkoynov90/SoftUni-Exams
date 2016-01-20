using System;

class LightTheTorches
{
    static void Main()
    {
        int numberOfRooms = int.Parse(Console.ReadLine());
        string initialState = Console.ReadLine();

        int currentPosition = numberOfRooms / 2;
        char[] basement = TorchesLitten(initialState, numberOfRooms);
        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] commandArray = command.Split();
            string direction = commandArray[0];
            int steps = int.Parse(commandArray[1]) + 1;
            basement = ChangeTheTorchState(basement, direction, steps, currentPosition);
            currentPosition = RoomToChange(numberOfRooms, direction, currentPosition, steps);

            command = Console.ReadLine();
        }
        FindNumberOfPrays(basement);
    }
    /// <summary>
    /// Method for calculating and print number of prays
    /// </summary>
    /// <param name="basement"></param>
    private static void FindNumberOfPrays(char[] basement)
    {
        int numberOfPrays = 0;
        for (int index = 0; index < basement.Length; index++)
        {
            if (basement[index] == 'D')
            {
                numberOfPrays += 'D';
            }
        }
        Console.WriteLine(numberOfPrays);
    }
    /// <summary>
    /// Method for making the starting state of the basement
    /// </summary>
    /// <param name="initialState"></param>
    /// <param name="numberOfRooms"></param>
    /// <returns></returns>
    private static char[] TorchesLitten(string initialState, int numberOfRooms)
    {
        char[] littenBasement = new char[numberOfRooms];
        for (int room = 0; room < numberOfRooms; room++)
        {
            int index = room % initialState.Length;
            littenBasement[room] = initialState[index];
        }
        return littenBasement;
    }
    /// <summary>
    /// Method for finding how to change the state of the torch
    /// </summary>
    /// <param name="basement"></param>
    /// <param name="direction"></param>
    /// <param name="steps"></param>
    /// <param name="currentPosition"></param>
    /// <returns></returns>
    private static char[] ChangeTheTorchState(char[] basement, string direction, int steps, int currentPosition)
    {
        int rooms = basement.Length;
        int roomToChange = RoomToChange(rooms, direction, currentPosition, steps);
        if (roomToChange != currentPosition)
        {
            basement[roomToChange] = ChangeLights(basement[roomToChange]);
        }
        return basement;
    }
    /// <summary>
    /// Method for finding which room to change state
    /// </summary>
    /// <param name="rooms"></param>
    /// <param name="direction"></param>
    /// <param name="position"></param>
    /// <param name="steps"></param>
    /// <returns></returns>
    private static int RoomToChange(int rooms, string direction, int position, int steps)
    {
        if (direction == "LEFT")
        {
            if (position - steps < 0)
            {
                position = 0;
            }
            else
            {
                position = position - steps;
            }
        }
        else if (direction == "RIGHT")
        {
            if (position + steps > rooms - 1)
            {
                position = rooms - 1;
            }
            else
            {
                position = position + steps;
            }
        }
        return position;
    }
    /// <summary>
    /// Method for changing the state of the room
    /// </summary>
    /// <param name="room"></param>
    /// <returns></returns>
    private static char ChangeLights(char room)
    {
        if (room == 'D')
        {
            room = 'L';
        }
        else if (room == 'L')
        {
            room = 'D';
        }
        return room;
    }
}