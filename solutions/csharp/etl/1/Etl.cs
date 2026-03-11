public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var output = new Dictionary<string, int>();

        foreach (var kv in old)
        {
            foreach (var v in kv.Value)
            {
                output.Add(v.ToLower(), kv.Key);
            }
        }
        
        return output;
    }
}