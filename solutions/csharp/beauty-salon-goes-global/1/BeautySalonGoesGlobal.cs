using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

static class LocationExtensions
{
    public static string GetTimezoneString(this Location location)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return location switch
            {
                Location.London => "Eastern Standard Time",
                Location.Paris => "GMT Standard Time",
                Location.NewYork => "W. Europe Standard Time",
                _ => throw new ArgumentOutOfRangeException(nameof(location), location, null)
            };
        }

        return location switch
        {
            Location.London => "Europe/London",
            Location.Paris => "Europe/Paris",
            Location.NewYork => "America/New_York",
            _ => throw new ArgumentOutOfRangeException(nameof(location), location, null)
        };
    }

    public static CultureInfo GetCulture(this Location location)
    {
        return location switch
        {
            Location.London => CultureInfo.GetCultureInfo("en-GB"),
            Location.Paris => CultureInfo.GetCultureInfo("fr-FR"),
            Location.NewYork => CultureInfo.GetCultureInfo("en-US"),
            _ => throw new ArgumentOutOfRangeException(nameof(location), location, null)
        };
    }
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

static class AlertLevelExtensions
{
    public static TimeSpan GetAlertSpan(this AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => TimeSpan.FromDays(1),
        AlertLevel.Standard => TimeSpan.FromHours(1.75),
        AlertLevel.Late => TimeSpan.FromMinutes(30),
        _ => throw new ArgumentOutOfRangeException(nameof(alertLevel), alertLevel, null)
    };
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return dtUtc.ToLocalTime();
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var tz = TimeZoneInfo.FindSystemTimeZoneById(location.GetTimezoneString());
        var dateTime = DateTime.Parse(appointmentDateDescription);
        
        return TimeZoneInfo.ConvertTimeToUtc(dateTime, tz);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        return appointment.Subtract(alertLevel.GetAlertSpan());
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var tz = TimeZoneInfo.FindSystemTimeZoneById(location.GetTimezoneString());
        
        return tz.IsDaylightSavingTime(dt) != tz.IsDaylightSavingTime(dt.Subtract(TimeSpan.FromDays(7)));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        var cultureInfo = location.GetCulture();

        if (DateTime.TryParse(dtStr, cultureInfo, DateTimeStyles.None, out var dt))
        {
            return dt;
        }

        return new DateTime
        (
            1,
            1,
            1,
            0,
            0,
            0
        );
    }
}
