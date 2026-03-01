class ProductionRemoteControlCar implements RemoteControlCar, Comparable<RemoteControlCar> {

    public int speed = 10;

    public int distanceTravelled = 0;

    private int victories = 0;

    @Override
    public void drive() {
        distanceTravelled += speed;
    }

    @Override
    public int getDistanceTravelled() {
        return distanceTravelled;
    }

    @Override
    public int compareTo(RemoteControlCar car) {
        return ((ProductionRemoteControlCar) car).getNumberOfVictories() > victories ? 1 : -1;
    }

    public int getNumberOfVictories() {
        return victories;
    }

    public void setNumberOfVictories(int numberOfVictories) {
        victories = numberOfVictories;
    }
}
