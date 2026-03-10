public static class Grains
{
    public static ulong Square(int n)
    {
        
        if (n is < 1 or > 64)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }
        
        var product = 1UL;

        for (var i = 1; i < n; i++)
        {
            product *= 2;
        };

        return product;
    }

    public static ulong Total()
    {
        var total = 0UL;
        for (var i = 1; i <= 64; i++)
        {
            total += Square(i);
        }
        return total;
    }
}