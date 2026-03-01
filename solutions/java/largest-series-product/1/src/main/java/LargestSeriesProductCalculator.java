import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

class LargestSeriesProductCalculator {

    private List<Integer> input = new ArrayList<>();

    LargestSeriesProductCalculator(String inputNumber) {
        if (!inputNumber.matches("\\d{0,}")) {
            throw new IllegalArgumentException("String to search may only contain digits.");
        }

        input = inputNumber.chars()
                .mapToObj(c -> Character.getNumericValue(c))
                .collect(Collectors.toList());
    }

    long calculateLargestProductForSeriesLength(int numberOfDigits) {

        if (numberOfDigits < 1) {
            throw new IllegalArgumentException(
                    "Series length must be non-negative.");
        }

        if (numberOfDigits > input.size()) {
            throw new IllegalArgumentException(
                    "Series length must be less than or equal to the length of the string to search.");
        }

        List<List<Integer>> series = new ArrayList<>();

        for (int i = 0; i < input.size() - numberOfDigits + 1; i++) {
            series.add(input.subList(i, i + numberOfDigits));
        }

        long max = 0;

        for (int i = 0; i < series.size(); i++) {
            long product = productFromSeries(series.get(i));

            max = Math.max(product, max);
        }

        return max;
    }

    private long productFromSeries(List<Integer> series) {
        long product = 1;

        for (int i = 0; i < series.size(); i++) {
            product *= series.get(i);
        }

        return product;
    }
}
