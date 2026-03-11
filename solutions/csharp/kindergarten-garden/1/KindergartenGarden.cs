public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

internal static class PlantExtensions
{
    public static Plant FromString(char value) => value switch
    {
        'G' => Plant.Grass,
        'C' => Plant.Clover,
        'R' => Plant.Radishes,
        'V' => Plant.Violets,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
    };
}

public class KindergartenGarden(string diagram)
{    
    public IEnumerable<Plant> Plants(string student)
    {
        var startIndex = (student.First() - 'A') * 2;

        var rows = diagram.Split('\n');

        return rows
            .SelectMany(row => ProcessRow(row, startIndex))
            .ToArray();
    }

    private static IEnumerable<Plant> ProcessRow(string row, int startIndex)
    {
        var pot1 = row[startIndex];
        var pot2 = row[startIndex + 1];

        yield return PlantExtensions.FromString(pot1);
        yield return PlantExtensions.FromString(pot2);
    }
}