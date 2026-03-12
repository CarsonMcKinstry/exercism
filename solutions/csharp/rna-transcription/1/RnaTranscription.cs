public static class RnaTranscription
{
    public static string ToRna(string strand) => string.Join(
        "",
        strand.Select(Transcode)
    );

    private static char Transcode(char c) => c switch
    {
        'G' => 'C',
        'C' => 'G',
        'T' => 'A',
        'A' => 'U',
        _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
    };
}