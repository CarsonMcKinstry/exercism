
class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder cleaner = new StringBuilder();

        boolean camel = false;

        for (int i = 0; i < identifier.length(); i++) {
            char character = identifier.charAt(i);

            if (Character.isISOControl(character)) {
                cleaner.append("CTRL");
            } else if (Character.isWhitespace(character)) {
                cleaner.append("_");
            } else if (character == '-') {
                camel = true;
            } else if (SqueakyClean.isValidLetter(character)) {
                if (camel) {
                    cleaner.append(Character.toUpperCase(character));
                    camel = false;
                } else {
                    cleaner.append(character);
                }
            }
        }

        return cleaner.toString();
    }

    static boolean isValidLetter(char letter) {
        return Character.isLetter(letter) && ('ω' < letter || letter < 'α');
    }
}