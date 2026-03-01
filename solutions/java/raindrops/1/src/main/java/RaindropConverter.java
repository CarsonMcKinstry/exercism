class RaindropConverter {

    String convert(int number) {
        StringBuilder sound = new StringBuilder();

        boolean hasFactor3 = hasFactor(number, 3);
        boolean hasFactor5 = hasFactor(number, 5);
        boolean hasFactor7 = hasFactor(number, 7);

        if (hasFactor3 || hasFactor5 || hasFactor7) {

            if (hasFactor3) {
                sound.append("Pling");
            }

            if (hasFactor5) {
                sound.append("Plang");
            }

            if (hasFactor7) {
                sound.append("Plong");
            }

        } else {
            sound.append(number);
        }

        return sound.toString();
    }

    private boolean hasFactor(int number, int factor) {
        return number % factor == 0;
    }

}
