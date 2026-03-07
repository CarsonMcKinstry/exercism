public class RemoteControlCar
{
    public ITelemetry Telemetry { get; }
    public string CurrentSponsor { get; private set; }

    private Speed currentSpeed;

    public RemoteControlCar()
    {
        Telemetry = new TelemetryImpl(this);
    }
    
    // // TODO encapsulate the methods suffixed with "_Telemetry" in their own class
    // // dropping the suffix from the method name
    // public void Calibrate_Telemetry()
    // {
    //
    // }
    //
    // public bool SelfTest_Telemetry()
    // {
    //     return true;
    // }

    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    private void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }

    public interface ITelemetry
    {
        public void Calibrate();
        public bool SelfTest();
        public void ShowSponsor(string sponsorName);
        public void SetSpeed(decimal amount, string unitsString);
    }
    
    private class TelemetryImpl(RemoteControlCar car) : ITelemetry
    {

        private RemoteControlCar _car = car;
        
        public void Calibrate()
        {
            throw new NotImplementedException();
        }
        
        public bool SelfTest()
        {
            return true;
        }
        
        public void ShowSponsor(string sponsorName)
        {
            _car.SetSponsor(sponsorName);
        }
        
        public void SetSpeed(decimal amount, string unitsString)
        {
            _car.SetSpeed(new Speed(amount, unitsString));
        }
    }
    
    private enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }

    private struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }

        public Speed(decimal amount, SpeedUnits speedUnits)
        {
            Amount = amount;
            SpeedUnits = speedUnits;
        }

        public Speed(decimal amount, string unitsString)
        {
            Amount = amount;
            SpeedUnits = unitsString switch
            {
                "cps" => SpeedUnits.CentimetersPerSecond,
                _ => SpeedUnits.MetersPerSecond
            };


        }

        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            {
                unitsString = "centimeters per second";
            }

            return Amount + " " + unitsString;
        }
    }

}

