
class IsbnVerifier {

    private final int CHECK_MOD = 11;

    boolean isValid(String stringToVerify) {

        if (!stringToVerify.matches("([0-9xX]|\\-){0,}")) {
            return false;
        }

        String cleaned = removeNonNumericCharacters(stringToVerify);

        if (!cleaned.matches("[0-9]{9}[0-9X]{1}")) {
            return false;
        }

        int sum = 0;
        for (int i = 0; i < cleaned.length(); i++) {
            int factor = 10 - i;
            char c = cleaned.charAt(i);

            if (c == 'X') {
                sum += 10 * factor;
            } else {
                sum += (c - '0') * factor;
            }
        }

        return sum % CHECK_MOD == 0;

    }

    String removeNonNumericCharacters(String input) {
        return input.replaceAll("[^0-9xX]", "").toUpperCase();
    }

}
