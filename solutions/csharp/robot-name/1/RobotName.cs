using System.Text;

public class Robot
{

    public Robot() => Reset();

    private readonly Random _rng = new ();
    
    private static readonly HashSet<string> UsedNamed = [];
    
    public string Name { get; private set; }

    public void Reset() => Name = GenerateName();

    private string GenerateName()
    {
        var name = GetRandomName();

        while (!UsedNamed.Add(name))
        {
            name = GetRandomName();
        }
        
        return name;
    }

    private string GetRandomName() => $"{RandomLetter()}{RandomLetter()}{RandomNumber()}{RandomNumber()}{RandomNumber()}";

    private char RandomLetter() => Convert.ToChar('A' + _rng.Next(0, 26));

    private string RandomNumber() => _rng.Next(0, 10).ToString();
}