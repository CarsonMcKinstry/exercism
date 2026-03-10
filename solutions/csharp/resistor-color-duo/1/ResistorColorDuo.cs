public static class ResistorColorDuo
{

    private const int ResistorLength = 2;
    
    public static int Value(string[] colors)
    {
        if (colors.Length < 2)
        {
            throw new ArgumentException("Not enough bands to determine resistance", nameof(colors) );
        }

        return colors
            .Take(ResistorLength)
            .Select((color, index) =>
            {
                var multiplier = (int)Math.Pow(10, ResistorLength - index - 1);
                var resistance = ColorToResistance(color);
                
                return multiplier * resistance;
            })
            .Sum();
    }

    private static int ColorToResistance(string color) => color.ToLower() switch
    {
        "black" => 0,
        "brown" => 1,
        "red" => 2,
        "orange" => 3,
        "yellow" => 4,
        "green" => 5,
        "blue" => 6,
        "violet" => 7,
        "grey" => 8,
        "white" => 9,
        _ => throw new ArgumentOutOfRangeException(nameof(color), color, null)
    };
    
}
