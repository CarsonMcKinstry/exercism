public class Clock
{

    private const int HoursPerDay = 24;
    private const int MinutesPerHour = 60;
    private static readonly int MinutesPerDay = MinutesPerHour * HoursPerDay;

    private int _minutes;

    public Clock(int hours, int minutes)
    {
        _minutes = (minutes + (hours % HoursPerDay) * MinutesPerHour) % MinutesPerDay;

        while (_minutes < 0)
        {
            _minutes += MinutesPerDay;
        }
    }
    
    public Clock Add(int minutesToAdd) {
        _minutes += minutesToAdd;
        _minutes %= MinutesPerDay;
        
        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        _minutes -= minutesToSubtract;

        while (_minutes < 0)
        {
            _minutes += MinutesPerDay;
        }

        return this;
    }

    public override string ToString()
    {
        var hours = _minutes / MinutesPerHour;
        var minutes = _minutes % MinutesPerHour;
        
        return $"{hours:D2}:{minutes:D2}";   
    }

    public override bool Equals(object? obj)
    {
        if (obj is Clock clock)
        {
            return _minutes == clock._minutes;
        }

        return false;
    }

    public override int GetHashCode() => _minutes.GetHashCode();
}
