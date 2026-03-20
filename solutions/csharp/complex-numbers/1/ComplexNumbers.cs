public struct ComplexNumber
{
    private readonly double _real;
    private readonly double _imaginary;
    
    public ComplexNumber(double real, double imaginary)
    {
        _real = real;
        _imaginary = imaginary;
    }

    public double Real() => _real;

    public double Imaginary() => _imaginary;

    public ComplexNumber Mul(ComplexNumber other)
    {
        var a = (Real() * other.Real() - Imaginary() * other.Imaginary());
        var b = (Imaginary() * other.Real() + Real() * other.Imaginary());
        
        return  new ComplexNumber(a,b);
    }

    public ComplexNumber Mul(double other) => Mul(new  ComplexNumber(other, 0));

    
    public ComplexNumber Add(ComplexNumber other)
    {
        var a = Real() + other.Real();
        var b = Imaginary() + other.Imaginary();
        
        return new ComplexNumber(a,b);
    }

    public ComplexNumber Add(double other) => Add(new  ComplexNumber(other, 0));


    public ComplexNumber Sub(ComplexNumber other)
    {
        var a = (Real() - other.Real());
        var b = (Imaginary() - other.Imaginary());
        
        return  new ComplexNumber(a,b);
    }
    
    public ComplexNumber Sub(double other) => Sub(new  ComplexNumber(other, 0));

    public ComplexNumber Div(ComplexNumber other)
    {
        var aNum = (Real() * other.Real() + Imaginary() * other.Imaginary());
        var aDen = (other.Real() * other.Real() + other.Imaginary() * other.Imaginary());
        
        var a = aNum / aDen;
        
        var bNum = (Imaginary() * other.Real() - Real() * other.Imaginary());
        
        var b = bNum / aDen;
        
        return new ComplexNumber(a,b);
    }

    public ComplexNumber Div(double other) => Div(new  ComplexNumber(other, 0));
    
    public double Abs() => Math.Sqrt(Real()*Real()+Imaginary()*Imaginary());

    public ComplexNumber Conjugate() => new(Real(), -Imaginary());

    public ComplexNumber Exp()
    {
        var a = Math.Cos(Imaginary());
        var b = Math.Sin(Imaginary());

        var mul = Math.Exp(Real());
        
        return new ComplexNumber(a,b).Mul(mul);
    }
}