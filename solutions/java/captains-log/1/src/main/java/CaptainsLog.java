import java.util.Random;

class CaptainsLog {

    private static final char[] PLANET_CLASSES = new char[] { 'D', 'H', 'J', 'K', 'L', 'M', 'N', 'R', 'T', 'Y' };

    private Random random;

    CaptainsLog(Random random) {
        this.random = random;
    }

    char randomPlanetClass() {
        int randi = random.nextInt(PLANET_CLASSES.length);

        return PLANET_CLASSES[randi];
    }

    String randomShipRegistryNumber() {
        int randi = 1000 + random.nextInt(9000);

        return String.format("NCC-%d", randi);
    }

    double randomStardate() {
        double randd = 41000 + 1000 * random.nextDouble();

        return randd;
    }
}
