
class RotationalCipher {

    int shiftKey;

    RotationalCipher(int shiftKey) {
        this.shiftKey = shiftKey;
    }

    String rotate(String data) {

        StringBuilder rotated = new StringBuilder();

        data.chars().forEach(c -> {
            rotated.append(
                    rotateCharacter(c));
        });

        return rotated.toString();
    }

    char rotateCharacter(int c) {

        if (Character.isAlphabetic(c)) {
            char base = Character.isUpperCase(c) ? 'A' : 'a';

            return (char) ((((c - base) + shiftKey) % 26) + base);
        }

        return (char) c;

    }

}
