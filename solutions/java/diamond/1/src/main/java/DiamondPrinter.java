import java.util.Arrays;
import java.util.List;

class DiamondPrinter {

    public List<String> printToList(char letter) {
        int n = letter - 'A' + 1;
        int width = 2 * (n - 1) + 1;

        String[] lines = new String[width];
        for (int i = 0; i < width / 2 + 1; i++) {
            char character = (char) ('A' + i);

            char[] buffer = new char[width];
            Arrays.fill(buffer, ' ');

            int leftPosition = width / 2 - i;
            int rightPosition = width - leftPosition - 1;

            buffer[leftPosition] = character;
            buffer[rightPosition] = character;

            String line = new String(buffer);

            lines[i] = line;
            lines[width - 1 - i] = line;
        }
        return Arrays.asList(lines);
    }

}
