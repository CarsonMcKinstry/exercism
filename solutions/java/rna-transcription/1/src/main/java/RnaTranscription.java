
class RnaTranscription {

    String transcribe(String dnaStrand) {
        return dnaStrand
                .chars()
                .map(n -> transcribeNucleotide(n))
                .collect(
                        StringBuilder::new,
                        StringBuilder::appendCodePoint,
                        StringBuilder::append)
                .toString();
    }

    private char transcribeNucleotide(int nucleotide) {
        return switch (Character.toUpperCase(nucleotide)) {
            case 'A' -> 'U';
            case 'T' -> 'A';
            case 'G' -> 'C';
            case 'C' -> 'G';
            default -> throw new UnknownError(String.format("Unknown nucleotide '%s'", nucleotide));
        };
    }

}
