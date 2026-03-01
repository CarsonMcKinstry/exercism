public class ElonsToyCar {

    private int batteryPercentage = 100;
    private int metersDriven = 0;

    private final int METERS_PER_BATTERY_PERCENT = 20;

    public static ElonsToyCar buy() {
        return new ElonsToyCar();
    }

    public String distanceDisplay() {
        return String.format("Driven %d meters", metersDriven);
    }

    public String batteryDisplay() {
        if (batteryPercentage == 0) {
            return "Battery empty";
        }

        return String.format("Battery at %d%%", batteryPercentage);
    }

    public void drive() {
        if (batteryPercentage != 0) {
            metersDriven += METERS_PER_BATTERY_PERCENT;
            batteryPercentage--;
        }
    }
}
