class Matrix {
  private matrix: number[][];

  constructor(matrix: string) {
    // Your code here
    this.matrix = matrix
      .split("\n")
      .map((n) => n.split(" ").map((n) => parseInt(n)));
  }

  get rows() {
    return this.matrix;
  }

  get columns() {
    return this.matrix.reduce((acc: number[][], val, i) => {
      if (i === 0 && acc.length === 0) {
        acc = Array.from(Array(val.length), () => []);
      }

      for (const idx in val) {
        acc[idx][i] = val[idx];
      }

      return acc;
    }, []);
  }
}

export default Matrix;
