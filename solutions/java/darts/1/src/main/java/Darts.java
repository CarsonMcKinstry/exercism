class Darts {
    int score(double xOfDart, double yOfDart) {
        double distance = Math.sqrt(xOfDart * xOfDart + yOfDart * yOfDart);

        if (distance > 10) {
            return 0;
        }

        if (distance <= 10 && distance > 5) {
            return 1;
        }

        if (distance <= 5 && distance > 1) {
            return 5;
        }

        return 10;
    }

}
