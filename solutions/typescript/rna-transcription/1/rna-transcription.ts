const NucleotidePairs: {
  [key: string]: string;
} = {
  C: "G",
  G: "C",
  A: "U",
  T: "A",
};

class Transcriptor {
  toRna(nucleotides: string) {
    if (!/^[GCAT]+$/g.test(nucleotides)) {
      throw new Error("Invalid input DNA.");
    }

    let rnaComplement = "";

    for (const nucleotide of nucleotides) {
      rnaComplement += NucleotidePairs[nucleotide];
    }

    return rnaComplement;
  }
}

export default Transcriptor;
