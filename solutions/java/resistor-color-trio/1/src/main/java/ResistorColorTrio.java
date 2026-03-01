import java.util.List;

class ResistorColorTrio {

    private final String LABEL_FORMAT = "%.0f %sohms";

    String label(String[] colors) {
        int base = getBase(colors);
        double magnitude = getMagnitude(colors);

        double value = base * magnitude;

        String prefix = "";

        if (value == 0) {
            return String.format(LABEL_FORMAT, value, prefix);
        }

        if (value % 1_000_000_000 == 0) {
            prefix = "giga";
            value = value / 1_000_000_000;
        } else if (value % 1_000_000 == 0) {
            prefix = "mega";
            value = value / 1_000_000;
        } else if (value % 1_000 == 0) {
            prefix = "kilo";
            value = value / 1_000;
        }

        return String.format(LABEL_FORMAT, value, prefix);
    }

    double getMagnitude(String[] colors) {
        String color = colors[2];

        int numZeros = colorCode(color);

        return Math.pow(10, numZeros);
    }

    int getBase(String[] colors) {
        StringBuilder resistorValue = new StringBuilder();

        int count = 0;

        for (String color : colors) {
            count++;
            if (count > 2) {
                break;
            }
            int value = colorCode(color);

            if (value != -1) {
                resistorValue.append(value);
            }
        }

        return Integer.parseInt(resistorValue.toString(), 10);
    }

    private int colorCode(String color) {
        return colors().indexOf(color);
    }

    private List<String> colors() {
        return List.of(
                "black",
                "brown",
                "red",
                "orange",
                "yellow",
                "green",
                "blue",
                "violet",
                "grey",
                "white");
    }
}
