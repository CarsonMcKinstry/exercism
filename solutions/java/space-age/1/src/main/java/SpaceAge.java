class SpaceAge {

    private final double MERCURY_ORBITAL_PERIOD = 0.2408467;
    private final double VENUS_ORBITAL_PERIOD = 0.61519726;
    private final double MARS_ORBITAL_PERIOD = 1.8808158;
    private final double JUPITER_ORBITAL_PERIOD = 11.862615;
    private final double SATURN_ORBITAL_PERIOD = 29.447498;
    private final double URANUS_ORBITAL_PERIOD = 84.016846;
    private final double NEPTUNE_ORBITAL_PERIOD = 164.79132;

    private final double ageInSeconds;

    private final double secondsPerYear = 365.25 * 24 * 60 * 60;

    SpaceAge(double seconds) {
        this.ageInSeconds = seconds;
    }

    double getSeconds() {
        return ageInSeconds;
    }

    double onEarth() {
        return ageInSeconds / secondsPerYear;
    }

    double onMercury() {
        return ageInSeconds / (secondsPerYear * MERCURY_ORBITAL_PERIOD);
    }

    double onVenus() {
        return ageInSeconds / (secondsPerYear * VENUS_ORBITAL_PERIOD);
    }

    double onMars() {
        return ageInSeconds / (secondsPerYear * MARS_ORBITAL_PERIOD);
    }

    double onJupiter() {
        return ageInSeconds / (secondsPerYear * JUPITER_ORBITAL_PERIOD);
    }

    double onSaturn() {
        return ageInSeconds / (secondsPerYear * SATURN_ORBITAL_PERIOD);
    }

    double onUranus() {
        return ageInSeconds / (secondsPerYear * URANUS_ORBITAL_PERIOD);
    }

    double onNeptune() {
        return ageInSeconds / (secondsPerYear * NEPTUNE_ORBITAL_PERIOD);
    }

}
