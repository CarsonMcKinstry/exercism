//
// This is only a SKELETON file for the 'Nucleotide-Count' exercise. It's been provided as a
// convenience to get you started writing code faster.
//


export class NucleotideCounts {
  static parse(strand) {
    const {A, T, G, C} = NucleotideCounts.count(strand);

    return `${A} ${C} ${G} ${T}`;
  }

  static count(strand) {
    return strand.split('').reduce((nucleotideCount, nucleotide) => {
      if (nucleotide in nucleotideCount) {
        return {
          ...nucleotideCount,
          [nucleotide]: nucleotideCount[nucleotide] + 1
        }
      } else {
        throw new Error('Invalid nucleotide in strand');
      }
    }, { A: 0, T: 0, G: 0, C: 0})
  }
  
}
