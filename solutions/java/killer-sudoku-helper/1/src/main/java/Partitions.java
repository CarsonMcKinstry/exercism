
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Partitions {

    private List<List<Integer>> partitions = new ArrayList<>();

    public Partitions(Integer target, Integer partitionSize) {
        buildPartitions(target, partitionSize, 1, new ArrayList<>());
    }

    public void removeExcludedIntegers(List<Integer> exclude) {
        partitions = partitions
                .stream()
                .filter(partition -> {
                    List<Integer> diff = getDiff(partition, exclude);

                    return diff.size() == partition.size();
                })
                .collect(Collectors.toList());
    }

    public List<List<Integer>> getPartitions() {
        return partitions;
    }

    private List<Integer> getDiff(List<Integer> listA, List<Integer> listB) {
        return listA.stream()
                .filter(element -> !listB.contains(element))
                .collect(Collectors.toList());
    }

    private void buildPartitions(
            Integer target,
            Integer partitionSize,
            Integer start,
            List<Integer> current) {
        if (target == 0 && current.size() == partitionSize) {
            partitions.add(current);
        } else if (target < 0 || current.size() > partitionSize) {
            // noop
        } else {
            for (int i = start; i <= target; i++) {
                List<Integer> newCurrent = new ArrayList<>(current);
                newCurrent.add(i);

                buildPartitions(
                        target - i,
                        partitionSize,
                        i + 1,
                        newCurrent);
            }
        }
    }

}
