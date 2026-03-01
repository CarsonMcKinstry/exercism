class ArmstrongNumbers {

    boolean isArmstrongNumber(int numberToCheck) {
        String numberAsString = Integer.toString(numberToCheck);

        if (numberAsString.length() == 1) {
            return true;
        }

        int total = numberAsString.chars()
                .reduce(0, (int a, int b) -> a + pow(b, numberAsString.length()));

        return total == numberToCheck;
    }

    int pow(int a, int b) {
        long result = 1;

        for (int i = 0; i < b; i++) {
            result *= a;
        }

        return (int) result;
    }

}
