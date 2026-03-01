import java.util.List;

class Acronym {

    private final String phrase;

    Acronym(String phrase) {
        this.phrase = phrase;
    }

    String get() {
        List<String> words = List.of(phrase.split("[\s\\-]"));

        StringBuilder acronymBuilder = new StringBuilder();

        for (String word : words) {
            String deburred = word.replaceAll("[^a-zA-Z]", "");
            if (deburred.length() > 0) {
                acronymBuilder.append(
                        Character.toUpperCase(deburred.charAt(0)));
            }
        }

        return acronymBuilder.toString();
    }

}
