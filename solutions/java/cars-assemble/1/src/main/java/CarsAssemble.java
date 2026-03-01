public class CarsAssemble {

    final double producedPerHour = 221;

    double getSuccessRateBySpeed(int speed) {
        if (1 <= speed && speed <= 4) {
            return 1.0;
        } else if (5 <= speed && speed <= 8) {
            return 0.9;
        } else if (speed == 9) {
            return 0.8;
        } else {
            return 0.77;
        }
    }

    public double productionRatePerHour(int speed) {
        double successRate = this.getSuccessRateBySpeed(speed);
        double carsPerHour = this.producedPerHour * speed;

        return carsPerHour * successRate;
    }

    public int workingItemsPerMinute(int speed) {
        int carsPerHour = (int) this.productionRatePerHour(speed);

        return carsPerHour / 60;
    }
}
