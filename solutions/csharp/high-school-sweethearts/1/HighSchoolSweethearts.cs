using System.Globalization;

public static class HighSchoolSweethearts
{

    private const int LineWidth = 61;
    
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        return $"{studentA,29} ♡ {studentB,-29}";
    }

    public static string DisplayBanner(string studentA, string studentB)
    {
        var banner = @"
******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {0} +  {1}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";

        return string.Format(banner, studentA, studentB);
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        var germanCultureInfo = CultureInfo.GetCultureInfo("de-DE");
        return string.Format
        (
            germanCultureInfo,
            "{0} and {1} have been dating since {2:d} - that's {3:N2} hours",
            studentA,
            studentB,
            start,
            hours
        );
    }
}
