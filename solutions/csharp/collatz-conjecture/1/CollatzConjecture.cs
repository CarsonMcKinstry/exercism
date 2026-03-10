public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);

        var steps = 0;

        var n = number;

        while (n > 1)
        {
            steps++;

            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n *= 3;
                n++;
            }
        }
        
        return steps;
    }
}