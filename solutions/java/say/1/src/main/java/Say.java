
import java.util.ArrayList;
import java.util.List;

public class Say {
    public String say(long number) {
        if (number < 0 || number > 999_999_999_999L) {
            throw new IllegalArgumentException("Out of bounds");
        }

        if (number == 0) {
            return "zero";
        }

        String asString = Long.toString(number);

        List<String> chunks = chunkNumber(asString, 3);

        StringBuilder out = new StringBuilder();

        while (!chunks.isEmpty()) {
            String chunk = chunks.remove(0);

            out.append(numberToString(chunk));
            out.append(" ");

            if (!chunk.equals("000")) {
                out.append(
                        switch (chunks.size()) {
                            case 3 -> "billion ";
                            case 2 -> "million ";
                            case 1 -> "thousand ";
                            default -> " ";
                        });
            }

        }

        return out.toString().trim();
    }

    private List<String> chunkNumber(String number, int size) {
        List<String> chunks = new ArrayList<>();
        int n = number.length() % size;

        if (n != 0) {
            chunks.add(
                    number.substring(0, n));
        }

        for (int i = 0; i < (number.length() - n) / size; i++) {
            String chunk = number.substring(
                    i * size + n,
                    (i + 1) * size + n);
            chunks.add(chunk);
        }

        return chunks;
    }

    private String numberToString(String number) {
        int num = Integer.parseInt(number, 10);

        if (num < 20) {
            return digitAsWord(num);
        } else {

            StringBuilder numberStringBuilder = new StringBuilder();

            // hundreds place
            int hundreds = num / 100;
            int tens = (num % 100) / 10;
            int ones = (num % 10);

            if (hundreds > 0) {
                numberStringBuilder.append(
                        digitAsWord(hundreds));
                numberStringBuilder.append(
                        " hundred ");
            }

            if (tens > 0) {
                numberStringBuilder.append(
                        tensAsWord(tens));
                if (ones > 0) {
                    numberStringBuilder.append("-");
                }
            }

            if (ones > 0) {
                numberStringBuilder.append(digitAsWord(ones));
            }

            return numberStringBuilder.toString();
        }
    }

    private String digitAsWord(int n) {
        return switch (n) {
            case 1 -> "one";
            case 2 -> "two";
            case 3 -> "three";
            case 4 -> "four";
            case 5 -> "five";
            case 6 -> "six";
            case 7 -> "seven";
            case 8 -> "eight";
            case 9 -> "nine";
            case 10 -> "ten";
            case 11 -> "eleven";
            case 12 -> "twelve";
            case 13 -> "thirteen";
            case 14 -> "fourteen";
            case 15 -> "fifteen";
            case 16 -> "sixteen";
            case 17 -> "seventeen";
            case 18 -> "eighteen";
            case 19 -> "nineteen";
            default -> " ";
        };
    }

    private String tensAsWord(int n) {
        return switch (n) {
            case 2 -> "twenty";
            case 3 -> "thirty";
            case 4 -> "forty";
            case 5 -> "fifty";
            case 6 -> "sixty";
            case 7 -> "seventy";
            case 8 -> "eighty";
            case 9 -> "ninety";
            default -> " ";
        };
    }
}
