class Scrabble {

    private int score = 0;

    Scrabble(String word) {
        score = word
                .chars()
                .map(letter -> letterToValue(letter))
                .reduce(0, (total, curr) -> total + curr);
    }

    int getScore() {
        return score;
    }

    int letterToValue(int letter) {
        return switch (Character.toUpperCase(letter)) {
            case 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' -> 1;
            case 'D', 'G' -> 2;
            case 'B', 'C', 'M', 'P' -> 3;
            case 'F', 'H', 'V', 'W', 'Y' -> 4;
            case 'K' -> 5;
            case 'J', 'X' -> 8;
            case 'Q', 'Z' -> 10;
            default -> 0;
        };
    }
}
