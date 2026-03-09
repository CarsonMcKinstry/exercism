public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var count = new Dictionary<char, int>
        {
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T', 0 },
        };

        foreach (var nucleotide in sequence)
        {
            if (!count.ContainsKey(nucleotide))
            {
                throw new ArgumentException("Malformed sequence");
            }
            count[nucleotide]++;
        }
        
        return count;
    }
}