public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)  {
        var num = r.Numerator;
        var den = r.Denominator;

        return Root(Math.Pow(realNumber, num), den);
    }
    
    private static double Root(double p, double q) => Math.Pow(p, 1.0 / q);
}

public struct RationalNumber(int numerator, int denominator)
{
    public int Numerator { get; private set; } = numerator;
    public int Denominator { get; private set; } = denominator;

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        var a1 = r1.Numerator;
        var a2 = r2.Numerator;
        var b1 = r1.Denominator;
        var b2 = r2.Denominator;

        var num = (a1 * b2 + a2 * b1);
        var den = (b1 * b2);
        
        return new RationalNumber(num, den).Reduce();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        var a1 = r1.Numerator;
        var a2 = r2.Numerator;
        var b1 = r1.Denominator;
        var b2 = r2.Denominator;
        
        var num = (a1 * b2 - a2 * b1);
        var den = (b1 * b2);
        
        return new RationalNumber(num, den).Reduce();
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        var a1 = r1.Numerator;
        var a2 = r2.Numerator;
        var b1 = r1.Denominator;
        var b2 = r2.Denominator;

        var num = a1 * a2;
        var den = b1 * b2;
        
        return new  RationalNumber(num, den).Reduce();
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        var a1 = r1.Numerator;
        var a2 = r2.Numerator;
        var b1 = r1.Denominator;
        var b2 = r2.Denominator;

        var num = (a1 * b2);
        var den = (a2 * b1);
        
        return new RationalNumber(num, den).Reduce();
    }

    public RationalNumber Abs()
    {
        var result = new RationalNumber
        {
            Numerator = Math.Abs(Numerator),
            Denominator = Math.Abs(Denominator)
        };
        
        return result.Reduce();
    }

    public RationalNumber Reduce()
    {
        var num = Math.Abs(Numerator);
        var den = Math.Abs(Denominator);
        
        var gcd =  Gcd(num, den);
        

        var isPos = (Numerator >= 0 && Denominator >= 0) || (Numerator < 0 && Denominator < 0);
        
        Numerator = num / gcd * (isPos ? 1 : -1);
        Denominator = den / gcd;

        return this;
    }

    public RationalNumber Exprational(int power)
    {
        var num = Numerator;
        var den = Denominator;

        if (power > 0)
        {
            return new RationalNumber(
                (int)Math.Pow(num, power),
                (int)Math.Pow(den, power)
                ).Reduce();
        }
        
        return new RationalNumber(
            (int)Math.Pow(den, Math.Abs(power)),
            (int)Math.Pow(num, Math.Abs(power))
        ).Reduce();
    }
    
    private static int Gcd(int a, int b)
    {
        while (true)
        {
            if (b == 0) return a;
            var a1 = a;
            a = b;
            b = a1 % b;
        }
    }
    
}