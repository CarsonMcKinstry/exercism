public class ExperimentalRemoteControlCar implements RemoteControlCar {

    public int speed = 20;

    public int distanceTravelled = 0;

    @Override
    public void drive() {
        distanceTravelled += speed;
    }

    @Override
    public int getDistanceTravelled() {
        return distanceTravelled;
    }
}
