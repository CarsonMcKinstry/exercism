class CollatzCalculator {

    int computeStepCount(int start) {

        if (start < 1) {
            throw new IllegalArgumentException("Only positive integers are allowed");
        }

        if (start == 1) {
            return 0;
        }

        int stepCount = 0;
        int current = start;

        while (current != 1) {
            stepCount++;

            if (current % 2 == 0) {
                current /= 2;
            } else {
                current = 3 * current + 1;
            }
        }

        return stepCount;
    }

}
