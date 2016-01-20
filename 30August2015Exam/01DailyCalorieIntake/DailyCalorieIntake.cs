using System;

class DailyCalorieIntake
{
    static void Main()
    {
        int weightInPounds = int.Parse(Console.ReadLine());
        int heightInInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workoutsPerWeek = int.Parse(Console.ReadLine());

        double weightInKilograms = weightInPounds / 2.2d;
        double heightInCentimeters = heightInInches * 2.54d;
        double basalMetabolicRate;
        double dailyCalorieIntake;

        if (gender == 'm')
        {
            basalMetabolicRate = 66.5d + (13.75d * weightInKilograms) + (5.003d * heightInCentimeters) - (6.755d * age);
        }
        else
        {
            basalMetabolicRate = 655 + (9.563d * weightInKilograms) + (1.850d * heightInCentimeters) - (4.676d * age);
        }

        if (workoutsPerWeek <= 0)
        {
            dailyCalorieIntake = basalMetabolicRate * 1.2d;
        }
        else if (workoutsPerWeek <= 3)
        {
            dailyCalorieIntake = basalMetabolicRate * 1.375d;
        }
        else if (workoutsPerWeek <= 6)
        {
            dailyCalorieIntake = basalMetabolicRate * 1.55d;
        }
        else if (workoutsPerWeek <= 9)
        {
            dailyCalorieIntake = basalMetabolicRate * 1.725d;
        }
        else
        {
            dailyCalorieIntake = basalMetabolicRate * 1.9d;
        }

        Console.WriteLine(Math.Floor(dailyCalorieIntake));
    }
}