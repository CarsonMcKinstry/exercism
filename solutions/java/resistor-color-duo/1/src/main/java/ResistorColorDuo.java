
import java.util.List;

class ResistorColorDuo {
    int value(String[] colors) {
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
