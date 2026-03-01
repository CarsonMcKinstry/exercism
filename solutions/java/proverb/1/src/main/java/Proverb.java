import java.util.ArrayList;
import java.util.List;

class Proverb {

    private List<String[]> pairs;

    Proverb(String[] words) {
        pairs = toPairs(words);
    }

    String recite() {
        StringBuilder proverb = new StringBuilder();

        for (String[] pair : pairs) {
            if (pair.length == 1) {
                proverb.append(
                        String.format("And all for the want of a %s.", pair[0]));
            } else {
                proverb.append(
                        String.format("For want of a %s the %s was lost.\n", pair[0], pair[1]));
            }
        }

        return proverb.toString();
    }

    private List<String[]> toPairs(String[] words) {
        List<String[]> result = new ArrayList<>();

        for (int i = 0; i < words.length; i++) {

            if (i == words.length - 1)
                result.add(
                        new String[] { words[0] });
            else {
                result.add(
                        new String[] {
                                words[i],
                                words[i + 1]
                        });
            }
        }

        return result;
    }

}
