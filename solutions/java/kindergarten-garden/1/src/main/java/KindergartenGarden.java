import java.util.Arrays;
import java.util.List;

class KindergartenGarden {

    String[] children = new String[] {
            "Alice", "Bob", "Charlie", "David",
            "Eve", "Fred", "Ginny", "Harriet",
            "Ileana", "Joseph", "Kincaid", "Larry"
    };

    String[] garden;

    KindergartenGarden(String garden) {
        this.garden = garden.split("\n");
    }

    List<Plant> getPlantsOfStudent(String student) {
        int childIndex = Arrays.asList(children).indexOf(student);

        if (childIndex == -1) {
            throw new IllegalArgumentException(String.format("Unknown student: %s", student));
        }

        Plant[] plants = new Plant[] {
                Plant.getPlant(top().charAt(2 * childIndex)),
                Plant.getPlant(top().charAt(2 * childIndex + 1)),
                Plant.getPlant(bottom().charAt(2 * childIndex)),
                Plant.getPlant(bottom().charAt(2 * childIndex + 1)),
        };

        return Arrays.asList(plants);
    }

    private String top() {
        return garden[0];
    }

    private String bottom() {
        return garden[1];
    }
}
