public static class ResistorColor
{
    public static int ColorCode(string color) => color switch
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

    public static string[] Colors()
    {
        var colors = new string[10];
        
        return colors
            .Select((_, i) => i switch
            {
                0 => "black",
                1 => "brown",
                2 => "red",
                3 => "orange",
                4 => "yellow",
                5 => "green",
                6 => "blue",
                7 => "violet",
                8 => "grey",
                9 => "white",
                _ => throw new ArgumentOutOfRangeException(nameof(i), i, null)
            })
            .ToArray();
    }
}