public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3) =>
        IsTriangle(side1, side2, side3)
        && CountUniqueSides(side1, side2, side3) == 3;

    public static bool IsIsosceles(double side1, double side2, double side3) =>
        IsTriangle(side1, side2, side3)
        && CountUniqueSides(side1, side2, side3) <= 2;

    public static bool IsEquilateral(double side1, double side2, double side3) =>
        IsTriangle(side1, side2, side3) 
        && CountUniqueSides(side1, side2, side3) == 1;
    
    private static int CountUniqueSides(double side1, double side2, double side3) => new HashSet<double>
    {
        side1,
        side2,
        side3
    }.Count;

    private static bool IsTriangle(double side1, double side2, double side3)
    {
        var sides = new[] { side1, side2, side3 }
            .OrderDescending()
            .ToArray();

        var longest = sides.First();
        var sumOfOthers = sides.Skip(1).Sum();
        
        return sumOfOthers > longest;
    }
}