public class PopCount {
    public int eggCount(int number) {
        return Integer.toBinaryString(number)
                .chars()
                .reduce(0, (sum, curr) -> sum + (curr - 48));
    }
}
