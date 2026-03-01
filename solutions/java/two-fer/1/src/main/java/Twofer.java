public class Twofer {
    public String twofer(String name) {
        if (name == null || name.length() == 0) {
            return "One for you, one for me.";
        }

        return String.format("One for %s, one for me.", name);
    }
}
