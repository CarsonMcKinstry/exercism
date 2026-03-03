class RemoteControlCar
{

    private int _batteryPercentage = 100;
    private int _distanceTraveled = 0;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceTraveled} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryPercentage == 0
            ? "Battery empty"
            : $"Battery at {_batteryPercentage}%";
    }

    public void Drive()
    {
        if (_batteryPercentage <= 0) return;
        
        _distanceTraveled += 20;
        _batteryPercentage--;
    }
}