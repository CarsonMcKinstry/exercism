import java.util.stream.Stream;

class Matrix {

    int[][] rows;
    int[][] cols;

    Matrix(String matrixAsString) {

        rows = Stream.of(matrixAsString.split("\\n"))
                .map(row -> buildRow(row))
                .toArray(int[][]::new);

        buildCols();
    }

    private int[] buildRow(String row) {
        return Stream.of(row.split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
    }

    private void buildCols() {
        cols = new int[rows[0].length][rows.length];

        for (int j = 0; j < rows[0].length; j++) {
            for (int i = 0; i < rows.length; i++) {
                cols[j][i] = rows[i][j];
            }
        }
    }

    int[] getRow(int rowNumber) {
        return rows[rowNumber - 1];
    }

    int[] getColumn(int columnNumber) {
        return cols[columnNumber - 1];
    }
}
