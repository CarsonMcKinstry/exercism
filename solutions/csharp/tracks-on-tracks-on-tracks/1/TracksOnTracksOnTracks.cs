public static class Languages
{
    public static List<string> NewList()
    {
        return [];
    }

    public static List<string> GetExistingLanguages()
    {
        return ["C#", "Clojure", "Elm"];
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        return languages.Append(language).ToList();
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        var reversed = new List<string>();

        for (var i = languages.Count - 1; i >= 0; i--)
        {
            reversed.Add(languages[i]);
        }

        return reversed;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) return false;
        
        if (languages.First() == "C#") return true;

        return languages.Count is 2 or 3 && languages[1] == "C#";

    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        return languages.Where(lang => lang != language).ToList();
    }

    public static bool IsUnique(List<string> languages)
    {
        var set = new HashSet<string>(languages);
        
        return set.Count == languages.Count;
    }
}
