class ArmstrongNumbers {

    boolean isArmstrongNumber(int numberToCheck) {
        if (numberToCheck < 10) {
            return true;
        }

        int total = sumOfPowers(numberToCheck);

        return total == numberToCheck;
    }

    int sumOfPowers(int number) {
        String numberAsString = Integer.toString(number);
        int total = 0;

        for (int i = 0; i < numberAsString.length(); i++) {
            total += pow(Character.getNumericValue(numberAsString.charAt(i)), numberAsString.length());
        }

        return total;
    }

    int pow(int a, int b) {
        long result = 1;

        for (int i = 0; i < b; i++) {
            result *= a;
        }

        return (int) result;
    }

}
