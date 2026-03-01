function isSorted(arr: number[]): boolean {
  return arr.every((v, i, a) => {
    if (a[i + 1]) {
      if (v > a[i + 1]) {
        return false;
      }
    }
    return true;
  });
}

export default class BinarySearch {
  array: number[] | undefined;

  constructor(array: number[]) {
    this.array = isSorted(array) ? array : undefined;
  }

  indexOf(value: number): number {
    if (this.array === undefined) {
      return -1;
    }

    let left = 0;
    let right = this.array.length - 1;

    let curr = Math.floor((left + right) / 2);

    while (left <= right) {
      const v = this.array[curr];

      if (v === value) return curr;

      if (v < value) {
        left = curr + 1;
      }

      if (v > value) {
        right = curr - 1;
      }

      curr = Math.floor((left + right) / 2);
    }

    return -1;
  }
}
