import java.util.ArrayList;
import java.util.List;

class HighScores {

    private final List<Integer> highScores;

    public HighScores(List<Integer> highScores) {
        this.highScores = highScores;
    }

    List<Integer> scores() {
        return highScores;
    }

    Integer latest() {
        return highScores.get(highScores.size() - 1);
    }

    Integer personalBest() {
        Integer max = 0;
        for (Integer curr : highScores) {
            if (curr > max) {
                max = curr;
            }
        }
        return max;
    }

    List<Integer> personalTopThree() {
        List<Integer> copy = new ArrayList<>(highScores);

        copy.sort((a, b) -> b.compareTo(a));

        return copy.subList(0, Math.min(copy.size(), 3));
    }

}
