public static class Gigasecond
{

    private const int GigaSecond = 1_000_000_000;
    
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(GigaSecond);
    }
}