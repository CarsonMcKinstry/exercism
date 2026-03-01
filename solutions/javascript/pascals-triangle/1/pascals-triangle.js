//
// This is only a SKELETON file for the 'Pascals Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Triangle {
    constructor(n) {
        this.n = n;
    }

    get lastRow() {
      return this.rows[this.n - 1]
    }

    get rows() {
        return this.recurse(this.n, [[1]]);
    }

    recurse(n, a) {
        if (n < 2) return a;

        const prevRow = a[a.length - 1];
        var curRow = [1];

        for (let i = 1; i < prevRow.length; i++) {
            curRow[i] = prevRow[i] + prevRow[i - 1];
        }

        curRow.push(1);
        a.push(curRow);

        return this.recurse(n - 1, a);
    }
}
