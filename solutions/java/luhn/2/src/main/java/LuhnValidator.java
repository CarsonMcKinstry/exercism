
class LuhnValidator {

    boolean isValid(String candidate) {

        String stripped = candidate.replaceAll("\\s", "");

        if (stripped.length() <= 1) {
            return false;
        }

        int parity = stripped.length() % 2;

        int sum = 0;

        for (int i = stripped.length() - 1; i >= 0; i--) {
            char character = stripped.charAt(i);

            if (!Character.isDigit(character)) {
                return false;
            } else {
                int digit = Character.getNumericValue(character);

                if (i % 2 == parity) {
                    digit *= 2;
                    if (digit > 9) {
                        digit -= 9;
                    }
                }

                sum += digit;
            }
        }

        return sum % 10 == 0;
    }

}
