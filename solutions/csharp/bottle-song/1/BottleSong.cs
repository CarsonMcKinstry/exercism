using System.Collections.Generic;
using System.Text;

public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown) => Enumerable
        .Range(0, takeDown)
        .SelectMany((n) => GetVerse(startBottles - n))
        .SkipLast(1);

    private static string[] GetVerse(int numberOfBottles)
    {
        var curr = NumberToString(numberOfBottles);
        var currPluralEnding = numberOfBottles == 1 ? "" : "s";
        var next = NumberToString(numberOfBottles - 1);
        var nextPluralEnding = numberOfBottles - 1 == 1 ? "" : "s";
        
        return
        [
            $"{Capitalize(curr)} green bottle{currPluralEnding} hanging on the wall,",
            $"{Capitalize(curr)} green bottle{currPluralEnding} hanging on the wall,",
            "And if one green bottle should accidentally fall,",
            $"There'll be {next} green bottle{nextPluralEnding} hanging on the wall.",
            ""
        ];
    }

    private static string NumberToString(int number) => number switch
    {
        0 => "no",
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        5 => "five",
        6 => "six",
        7 => "seven",
        8 => "eight",
        9 => "nine",
        10 => "ten",
        _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
    };

    private static string Capitalize(string str) => char.ToUpper(str.First()) + str.Substring(1).ToLower();
}