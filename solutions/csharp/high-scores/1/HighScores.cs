public class HighScores(List<int> list)
{
    private List<int> _highScores = list;

    public List<int> Scores()
    {
        return _highScores;
    }

    public int Latest()
    {
        return _highScores.Last();
    }

    public int PersonalBest()
    {
        return _highScores.Max();
    }

    public List<int> PersonalTopThree()
    {
        var copy = new List<int>(_highScores);
        copy.Sort((a, b) => b.CompareTo(a));
        
        return copy.Take(3).ToList();
    }
}