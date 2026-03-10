public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("Strands are not of the same length");
        }

        var firstMolecules = firstStrand.ToCharArray();
        var secondMolecules = secondStrand.ToCharArray();

        return firstMolecules
            .Zip(secondMolecules)
            .Count(pair => pair.First != pair.Second);
    }
}