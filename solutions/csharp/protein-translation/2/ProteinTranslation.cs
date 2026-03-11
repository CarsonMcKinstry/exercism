enum AminoAcid
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

static class AminoAcidExtensions
{
    public static AminoAcid FromCodon(string codon) => codon switch
    {
        "AUG" => AminoAcid.Methionine,
        "UUU" or "UUC" => AminoAcid.Phenylalanine,
        "UUA" or "UUG" => AminoAcid.Leucine,
        "UCU" or "UCC" or "UCA" or "UCG" => AminoAcid.Serine,
        "UAU" or "UAC" => AminoAcid.Tyrosine,
        "UGU" or "UGC" => AminoAcid.Cysteine,
        "UGG" => AminoAcid.Tryptophan,
        "UAA" or "UAG" or "UGA" => AminoAcid.Stop,
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
            var protein = AminoAcidExtensions.FromCodon(codon);
            if (protein == AminoAcid.Stop) break;
            
            proteins.Add(protein.ToString());
        }
        
        return proteins.ToArray();
    }
    
}