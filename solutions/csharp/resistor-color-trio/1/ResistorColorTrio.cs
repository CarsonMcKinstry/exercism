public static class ResistorColorTrio
{
    
    private const int NumberOfSignicantFigures = 2;
    
    public static string Label(string[] colors)
    {
        if (colors.Length < 3)
        {
            throw new ArgumentException("Not enough bands to determine resistance", nameof(colors) );
        }
        
        var resistance = GetResistance(colors);

        var formatted = FormattingWithPrefix(resistance);

        return $"{formatted.resistance} {formatted.prefix}ohms";
    }
    
    private static long GetResistance(string[] colors)
    {
        var firstTwo = colors
            .Take(NumberOfSignicantFigures)
            .Select((color, index) =>
            {
                var multiplier = (long)Math.Pow(10, NumberOfSignicantFigures - index - 1);
                var resistance = ColorToResistance(color);
                
                return multiplier * resistance;
            })
            .Sum();

        var multiplier = (long)Math.Pow(10, ColorToResistance(colors[2]));
        
        return firstTwo * multiplier;
    }
    
    private static (long resistance, string prefix) FormattingWithPrefix(long resistance) => resistance switch
    {
        0 => (resistance, ""),
        _ when resistance % 1_000_000_000 == 0 => (resistance / 1_000_000_000, "giga"),
        _ when resistance % 1_000_000 == 0 => (resistance / 1_000_000, "mega"),
        _ when resistance % 1_000 == 0 => (resistance / 1_000, "kilo"),
        _ => (resistance, "")
    };

    
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
