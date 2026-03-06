// TODO implement the IRemoteControlCar interface

public interface IRemoteControlCar: IComparable<IRemoteControlCar>
{
    public void Drive();
    
    public int DistanceTravelled { get; }
}

public class ProductionRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(IRemoteControlCar? other)
    {
        if (other is null)  return 0;

        if (other is ProductionRemoteControlCar productionCar)
        {
            return NumberOfVictories.CompareTo(productionCar.NumberOfVictories);    
        }
        
        return DistanceTravelled.CompareTo(other.DistanceTravelled);
    }

}


public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
    
    public int CompareTo(IRemoteControlCar? other)
    {
        return 0;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var list = new List<ProductionRemoteControlCar>
        {
            prc1,
            prc2
        };

        list.Sort();

        return list;
    }
}
