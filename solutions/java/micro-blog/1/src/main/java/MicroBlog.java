import java.util.stream.Collectors;

class MicroBlog {
    public String truncate(String input) {
        return input
            .codePoints()
            .limit(5)
            .mapToObj(c -> String.valueOf(Character.toChars(c)))
            .collect(Collectors.joining());
    }
}
