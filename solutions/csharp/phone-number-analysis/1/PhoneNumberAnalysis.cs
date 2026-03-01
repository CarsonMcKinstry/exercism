public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var segments = phoneNumber.Split('-');
        
        var dialingCode = segments[0];
        var prefixCode = segments[1];
        var localNumber = segments[2];

        return (
            dialingCode == "212",
            prefixCode == "555",
            localNumber
        );
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
