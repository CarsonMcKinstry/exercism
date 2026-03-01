class NeedForSpeed {

    public int speed;
    public int batteryDrain;
    private int charge = 100;
    private int distanceDriven = 0;

    public NeedForSpeed(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public boolean batteryDrained() {
        return charge <= 0;
    }

    public int distanceDriven() {
        return distanceDriven;
    }

    public void drive() {
        if (charge > 0) {
            distanceDriven += speed;
            charge -= batteryDrain;
        }

    }

    public static NeedForSpeed nitro() {
        return new NeedForSpeed(50, 4);
    }
}

class RaceTrack {

    private int distance;

    RaceTrack(int distance) {
        this.distance = distance;
    }

    public boolean tryFinishTrack(NeedForSpeed car) {
        int theoreticalDrivingDistance = car.speed * (100 / car.batteryDrain);

        return theoreticalDrivingDistance >= distance;
    }
}
