public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var numbers = phoneNumber.ToCharArray()
            .Where(c => c is >= '0' and <= '9')
            .ToArray();

        if (numbers[0] == '1')
        {
            numbers = numbers.Skip(1).ToArray();
        }
        
        if (numbers.Length != 10 || numbers[0] < '2' || numbers[3] < '2')
        {
            throw new ArgumentException("Not a valid phone number");
        }
        
        return string.Join("",  numbers);
    }
}