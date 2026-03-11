enum Protein
{
    Methionine,
    Phenylalanine,
    Leucine,
    Serine,
    Tyrosine,
    Cysteine,
    Tryptophan,
    Stop,
}

static class ProteinExtensions
{
    public static Protein FromCodon(string codon) => codon switch
    {
        "AUG" => Protein.Methionine,
        "UUU" or "UUC" => Protein.Phenylalanine,
        "UUA" or "UUG" => Protein.Leucine,
        "UCU" or "UCC" or "UCA" or "UCG" => Protein.Serine,
        "UAU" or "UAC" => Protein.Tyrosine,
        "UGU" or "UGC" => Protein.Cysteine,
        "UGG" => Protein.Tryptophan,
        "UAA" or "UAG" or "UGA" => Protein.Stop,
        _ => throw new ArgumentException($"Unrecognized codon: {codon}", nameof(codon))
    };
}

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        if (strand.Length % 3 != 0)
        {
            throw new ArgumentException("strand not divisible by 3");
        }

        var codons = strand.Chunk(3).Select(c => new string(c));

        var proteins = new List<string>();

        foreach (var codon in codons)
        {
            var protein = ProteinExtensions.FromCodon(codon);
            if (protein == Protein.Stop) break;
            
            proteins.Add(protein.ToString());
        }
        
        return proteins.ToArray();
    }
    
}