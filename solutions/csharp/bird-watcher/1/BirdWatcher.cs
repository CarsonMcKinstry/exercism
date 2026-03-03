class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;   
    }

    public bool HasDayWithoutBirds()
    {
        // foreach variant
        // foreach( var numBirds in birdsPerDay )
        // {
        //     if (numBirds == 0) return true;
        // }
        // return false;
        
        // LINQ with dot syntax
        return birdsPerDay.Any(b => b == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {

        // for loop variant
        // var total = 0;
        // for (var i = 0; i < numberOfDays; i++)
        // {
        //     total += birdsPerDay[i];
        // }
        // return total;
        
        // LINQ with dot syntax
        return birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {

        // foreach variant
        // var count = 0;
        // foreach (var birds in birdsPerDay)
        // {
        //     if (birds >= 5)
        //     {
        //         count++;
        //     }
        // }
        // return count;

        // LINQ with dot syntax
        return birdsPerDay.Count(b => b >= 5);
    }
}
