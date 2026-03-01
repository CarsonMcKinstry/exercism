import java.util.ArrayList;
import java.util.List;

class PrimeCalculator {

    private final List<Integer> factors = new ArrayList<>();

    int primeCount = 1;
    int candidate = 3;

    int nth(int nth) {
        if (nth == 0) {
            throw new IllegalArgumentException();
        }

        if (nth == 1) {
            return 2;
        }

        if (primeCount >= nth) {
            return factors.get(nth - 1);
        }

        while (primeCount != nth) {
            if (isPrime(candidate)) {
                primeCount++;
                factors.add(candidate);
            }
            candidate += 2;
        }

        return factors.get(factors.size() - 1);
    }

    private boolean isPrime(int num) {
        int limit = (int) Math.sqrt(num);

        int i = 0;

        while (factors.size() > i && factors.get(i) <= limit) {
            if (num % factors.get(i) == 0) {
                return false;
            }

            i++;
        }

        return true;
    }
}
