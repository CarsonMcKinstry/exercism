import java.util.List;

public class KillerSudokuHelper {

    List<List<Integer>> combinationsInCage(Integer cageSum, Integer cageSize, List<Integer> exclude) {
        Partitions cages = new Partitions(cageSum, cageSize);

        cages.removeExcludedIntegers(exclude);

        return cages.getPartitions();
    }

    List<List<Integer>> combinationsInCage(Integer cageSum, Integer cageSize) {
        Partitions cages = new Partitions(cageSum, cageSize);

        return cages.getPartitions();
    }
}
