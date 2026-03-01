defmodule ProteinTranslation do
  @codons %{
    :UGU => "Cysteine",
    :UGC => "Cysteine",
    :UUA => "Leucine",
    :UUG => "Leucine",
    :AUG => "Methionine",
    :UUU => "Phenylalanine",
    :UUC => "Phenylalanine",
    :UCU => "Serine",
    :UCC => "Serine",
    :UCA => "Serine",
    :UCG => "Serine",
    :UGG => "Tryptophan",
    :UAU => "Tyrosine",
    :UAC => "Tyrosine",
    :UAA => "STOP",
    :UAG => "STOP",
    :UGA => "STOP"
  }

  @doc """
  Given an RNA string, return a list of proteins specified by codons, in order.
  """
  @spec of_rna(String.t()) :: {atom, list(String.t())}
  def of_rna(rna) do
    protein_list = for <<codon::binary-3 <- rna>> do
      {:ok, protein} = of_codon codon
      protein
    end
    {:ok, protein_list}
  end

  defp chunk_rna(codon) do
    for <<c::binary-3 <- codon>> do
      {:ok, protein} = of_codon(c)
      protein
    end
  end

  @doc """
  Given a codon, return the corresponding protein

  UGU -> Cysteine
  UGC -> Cysteine
  UUA -> Leucine
  UUG -> Leucine
  AUG -> Methionine
  UUU -> Phenylalanine
  UUC -> Phenylalanine
  UCU -> Serine
  UCC -> Serine
  UCA -> Serine
  UCG -> Serine
  UGG -> Tryptophan
  UAU -> Tyrosine
  UAC -> Tyrosine
  UAA -> STOP
  UAG -> STOP
  UGA -> STOP
  """
  @spec of_codon(String.t()) :: {atom, String.t()}
  def of_codon(codon), do: Map.fetch(@codons, String.to_atom(codon))
end