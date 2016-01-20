using System;

class FourFactors
{
    static void Main()
    {
        uint fieldGoals = uint.Parse(Console.ReadLine());
        uint fieldGoalAttempts = uint.Parse(Console.ReadLine());
        uint threePouintFieldGoals = uint.Parse(Console.ReadLine());
        uint turnovers = uint.Parse(Console.ReadLine());
        uint offensiveRebounds = uint.Parse(Console.ReadLine());
        uint opponentsDefensiveRebounds = uint.Parse(Console.ReadLine());
        uint freeThrows = uint.Parse(Console.ReadLine());
        uint freeThrowAttempts = uint.Parse(Console.ReadLine());

        //Display the results
        Console.WriteLine("eFG% {0:F3}", EffectiveFieldGoalPercentage(fieldGoals, threePouintFieldGoals, fieldGoalAttempts));
        Console.WriteLine("TOV% {0:F3}", TurnoverPercentage(turnovers, fieldGoalAttempts, freeThrowAttempts));
        Console.WriteLine("ORB% {0:F3}", OffensiveReboundingPercentage(offensiveRebounds, opponentsDefensiveRebounds));
        Console.WriteLine("FT% {0:F3}", FreeThrowPercentage(freeThrows, fieldGoalAttempts));

    }
    /// <summary>
    /// Method for calculating effective field goal percentage
    /// </summary>
    /// <param name="fieldGoals"></param>
    /// <param name="threePouintFiledGoals"></param>
    /// <param name="fieldGoalAttempts"></param>
    /// <returns></returns>
    public static double EffectiveFieldGoalPercentage(uint fieldGoals, uint threePouintFiledGoals, uint fieldGoalAttempts)
    {
        double eFGPercentage = (fieldGoals + (0.5 * threePouintFiledGoals)) / fieldGoalAttempts;
        return eFGPercentage;
    }
    /// <summary>
    /// Method for calculating turnover percentage
    /// </summary>
    /// <param name="turnovers"></param>
    /// <param name="fieldGoalAttempts"></param>
    /// <param name="freeThrowAttempts"></param>
    /// <returns></returns>
    public static double TurnoverPercentage(uint turnovers, uint fieldGoalAttempts, uint freeThrowAttempts)
    {
        double turnoverPercentage = turnovers / (fieldGoalAttempts + 0.44 * freeThrowAttempts + turnovers);
        return turnoverPercentage;
    }
    /// <summary>
    /// Method for calculating offensive rebounding percentage
    /// </summary>
    /// <param name="offensiveRebounds"></param>
    /// <param name="opponentsDefensiveRebounds"></param>
    /// <returns></returns>
    public static double OffensiveReboundingPercentage(uint offensiveRebounds, uint opponentsDefensiveRebounds)
    {
        double oRPercentage = (double)offensiveRebounds / (offensiveRebounds + opponentsDefensiveRebounds);
        return oRPercentage;
    }
    /// <summary>
    /// Method for calculating free throw percentage
    /// </summary>
    /// <param name="freeThrows"></param>
    /// <param name="fieldGoalAttempts"></param>
    /// <returns></returns>
    public static double FreeThrowPercentage(uint freeThrows, uint fieldGoalAttempts)
    {
        double fTPercentage = (double)freeThrows / fieldGoalAttempts;
        return fTPercentage;
    }
}