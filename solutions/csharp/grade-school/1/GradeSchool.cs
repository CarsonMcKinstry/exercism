public class GradeSchool
{

    private readonly Dictionary<string, int> _roster = new();
    
    public bool Add(string student, int grade) => _roster.TryAdd(student, grade);

    public IEnumerable<string> Roster() => _roster
        .OrderBy(x => x.Value)
        .ThenBy(x => x.Key)
        .Select(pair => pair.Key);

    public IEnumerable<string> Grade(int grade) => _roster
        .Where(pair => pair.Value == grade)
        .Select(pair => pair.Key)
        .OrderBy(name => name);
}