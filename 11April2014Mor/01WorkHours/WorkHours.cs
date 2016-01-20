using System;

class WorkHours
{
    static void Main()
    {
        int hoursRequired = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int productivity = int.Parse(Console.ReadLine());

        double efficientWorkHours = ((days - (days * 0.10)) * 12);
        efficientWorkHours = efficientWorkHours * ((double)productivity / 100);
        efficientWorkHours = Math.Floor(efficientWorkHours);

        int difference = (int)efficientWorkHours - hoursRequired;
        if (difference < 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
        Console.WriteLine(difference);
    }
}