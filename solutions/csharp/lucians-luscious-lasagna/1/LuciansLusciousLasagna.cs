class Lasagna
{

    private const int TimePerLayer = 2;
    
    private int _expectedMinutesInOven = 40;
    
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return _expectedMinutesInOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int timeElapsed)
    {
        return _expectedMinutesInOven - timeElapsed;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int layers)
    {
        return TimePerLayer * layers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    
    public int ElapsedTimeInMinutes(int layers, int timeElapsed)
    {
        return PreparationTimeInMinutes(layers) + timeElapsed;
    }
}
