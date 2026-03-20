public class Anagram
{

    private readonly string _baseWord;
    private readonly Dictionary<char, uint> _baseCharCounts;
    
    public Anagram(string baseWord) {
        _baseWord = baseWord.ToLower();
        _baseCharCounts = GetCharCounts(_baseWord);
    }

    public string[] FindAnagrams(string[] potentialMatches) => potentialMatches
        .Where(IsAnagram)
        .ToArray();

    private bool IsAnagram(string word)
    {

        if (word.ToLower() == _baseWord) return false;
        
        var wordCharCounts =  GetCharCounts(word);

        if (wordCharCounts.Count != _baseCharCounts.Count) return false;
        
        return !_baseCharCounts
            .Except(wordCharCounts)
            .Any();
    }

    private static Dictionary<char, uint> GetCharCounts(string word)
    {
        var result = new Dictionary<char, uint>();

        foreach (var c in word)
        {
            var lowerC = char.ToLower(c);
            result.TryAdd(lowerC, 0);

            result[lowerC]++;
        }
        
        return result;
    } 
}