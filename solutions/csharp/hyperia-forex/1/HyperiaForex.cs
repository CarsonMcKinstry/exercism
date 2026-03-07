public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }
    
    public static bool operator == (CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Cannot compare different currencies");
        }
        return a.amount == b.amount;
    }
    
    public static bool operator !=(CurrencyAmount a, CurrencyAmount b)
    {
        return !(a == b);
    }
    
    public static bool operator >(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Cannot compare different currencies");
        }

        return a.amount > b.amount;
    }
    
    public static bool operator <(CurrencyAmount a, CurrencyAmount b)
    {
        return !(a > b);
    }


    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Cannot add different currencies");
        }

        return new CurrencyAmount(a.amount + b.amount, a.currency);
    }
    
    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Cannot subtract different currencies");
        }

        return new CurrencyAmount(a.amount - b.amount, a.currency);
    }
    
    public static CurrencyAmount operator *(CurrencyAmount a, decimal multiplier)
    {
        return new CurrencyAmount(a.amount * multiplier, a.currency);
    }
    
    public static CurrencyAmount operator *(decimal multiplier, CurrencyAmount a )
    {
        return a * multiplier;
    }
    
    public static CurrencyAmount operator /(CurrencyAmount a, decimal divisor)
    {
        return new CurrencyAmount(a.amount / divisor, a.currency);
    }
    
    
    public static explicit operator double(CurrencyAmount a)
    {
        return (double)a.amount;
    }

    public static implicit operator decimal(CurrencyAmount a)
    {
        return a.amount;
    }
}
