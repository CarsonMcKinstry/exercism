static class AssemblyLine
{

    private const int ProductionRate = 221;
    
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            <= 4 and >= 1 => 1.0,
            <= 8 and >= 5 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0.0
        };
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        var perHour = ProductionRate * speed;
        var successRate = SuccessRate(speed);
        return successRate * perHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var ratePerHour = ProductionRatePerHour(speed);

        return (int)ratePerHour / 60;
    }
}
