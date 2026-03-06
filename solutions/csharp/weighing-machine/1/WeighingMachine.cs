using System.Text;

class WeighingMachine(int precision)
{
    public int Precision { get; } = precision;

    private double _weight;

    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "Weight must be greater than or equal to zero.");
            }
            
            _weight = value;
        }
    }

    public double TareAdjustment = 5.0;

    public string DisplayWeight
    {
        get
        {
            var sb = new StringBuilder();

            sb.Append((_weight - TareAdjustment).ToString($"N{Precision}"));
            sb.Append(" kg");
            
            return sb.ToString();
        }
    }
}
