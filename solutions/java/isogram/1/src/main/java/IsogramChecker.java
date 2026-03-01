import java.util.HashSet;

class IsogramChecker {

    boolean isIsogram(String phrase) {

        HashSet<Character> foundCharacters = new HashSet<>();

        for (int i = 0; i < phrase.length(); i++) {
            char c = Character.toLowerCase(phrase.charAt(i));

            if (Character.isAlphabetic(c)) {

                if (foundCharacters.contains(c)) {
                    return false;
                }

                foundCharacters.add(c);
            }
        }

        return true;
    }

}
