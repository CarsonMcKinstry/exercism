import java.util.ArrayList;
import java.util.List;

class ProteinTranslator {

    private final String STOP = "STOP";

    List<String> translate(String rnaSequence) {

        if (rnaSequence.length() < 3) {
            return new ArrayList<>();
        }

        List<String> chunks = splitStringBySize(rnaSequence, 3);

        List<String> proteins = new ArrayList<>();

        for (String chunk : chunks) {
            String protein = toProtein(chunk);

            if (protein.equals(STOP)) {
                break;
            } else {
                proteins.add(protein);
            }
        }

        return proteins;
    }

    private String toProtein(String codon) {

        return switch (codon) {
            case "AUG" -> "Methionine";
            case "UUU", "UUC" -> "Phenylalanine";
            case "UUA", "UUG" -> "Leucine";
            case "UCU", "UCC", "UCA", "UCG" -> "Serine";
            case "UAU", "UAC" -> "Tyrosine";
            case "UGU", "UGC" -> "Cysteine";
            case "UGG" -> "Tryptophan";
            case "UAA", "UAG", "UGA" -> STOP;
            default -> throw new IllegalArgumentException("Invalid codon");
        };
    }

    private List<String> splitStringBySize(String str, int size) {
        ArrayList<String> split = new ArrayList<>();
        for (int i = 0; i <= str.length() / size; i++) {
            String sub = str.substring(i * size, Math.min((i + 1) * size, str.length()));
            if (sub.length() > 0) {
                split.add(sub);
            }
        }
        return split;
    }
}
