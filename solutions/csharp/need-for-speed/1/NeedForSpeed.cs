class RemoteControlCar(int speed, int batteryDrainRate)
{
    
    
    private int _batteryLevel = 100;
    private int _distanceTravelled;
    
    public bool BatteryDrained()
    {
        return _batteryLevel < batteryDrainRate;
    }

    public int DistanceDriven()
    {
           return _distanceTravelled;
    }

    public void Drive()
    {
        if (BatteryDrained()) return;
        
        _batteryLevel -= batteryDrainRate;
        _distanceTravelled += speed;
    }

    public static RemoteControlCar Nitro()
    {
        return  new RemoteControlCar(50, 4);
    }
}

class RaceTrack(int distance)
{

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        
        return car.DistanceDriven() >= distance;
    }
}
