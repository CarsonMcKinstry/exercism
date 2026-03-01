import java.util.HashSet;
import java.util.Set;

public class PangramChecker {

    private final Set<Integer> chars = new HashSet<>();

    public boolean isPangram(String input) {
        input
                .replaceAll("[^a-zA-Z]", "")
                .chars().forEach((int c) -> {
                    chars.add(Character.toLowerCase(c));
                });

        return chars.size() == 26;
    }

}
