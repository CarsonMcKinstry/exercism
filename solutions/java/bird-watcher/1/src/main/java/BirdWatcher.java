class BirdWatcher {
    private final int[] birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
        return this.birdsPerDay;
    }

    public int getToday() {
        return this.birdsPerDay[this.birdsPerDay.length - 1];
    }

    public void incrementTodaysCount() {
        this.birdsPerDay[this.birdsPerDay.length - 1] += 1;
    }

    public boolean hasDayWithoutBirds() {
        for (int i = 0; i < this.birdsPerDay.length; i++) {
            if (this.birdsPerDay[i] == 0) {
                return true;
            }
        }

        return false;
    }

    public int getCountForFirstDays(int numberOfDays) {
        int total = 0;

        for (int i = 0; i < numberOfDays && i < this.birdsPerDay.length; i++) {
            total += this.birdsPerDay[i];
        }

        return total;
    }

    public int getBusyDays() {
        int busyDays = 0;

        for (int i = 0; i < this.birdsPerDay.length; i++) {
            if (this.birdsPerDay[i] >= 5) {
                busyDays++;
            }
        }

        return busyDays;
    }
}
