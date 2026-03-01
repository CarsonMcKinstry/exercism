
import java.util.HashSet;
import java.util.Set;

class NaturalNumber {

    Classification classification;

    NaturalNumber(int number) {

        if (number <= 0) {
            throw new IllegalArgumentException("You must supply a natural number (positive integer)");
        }

        Set<Integer> divisors = new HashSet<>();
        int half = number / 2;

        for (int i = 1; i <= half; i++) {
            if (number % i == 0) {
                divisors.add(i);
            }
        }

        int sum = 0;

        for (int i : divisors) {
            sum += i;
        }

        if (sum == number) {
            classification = Classification.PERFECT;
        } else if (number < sum) {
            classification = Classification.ABUNDANT;
        } else {
            classification = Classification.DEFICIENT;
        }
    }

    Classification getClassification() {
        return classification;
    }
}
