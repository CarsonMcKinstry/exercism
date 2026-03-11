public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        var left = 0;
        var right = input.Length - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;

            if (value == input[mid])
            {
                return mid;
            }

            if (value < input[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}