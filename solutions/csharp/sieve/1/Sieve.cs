public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2) return [];

        var composites = Enumerable.Repeat(false, limit + 1).ToArray();

        for (var i = 2; i * i <= limit; i++)
        {
            if (composites[i])
            {
                continue;
            }
            
            for (var j = i * i; j <= limit; j += i)
            {
                composites[j] = true;
            }
        }

        var primes = new List<int>();

        for (var i = 2; i <= limit; i++)
        {
            if (!composites[i])
            {
                primes.Add(i);
            }
        }
        
        return primes.ToArray();
    }
}