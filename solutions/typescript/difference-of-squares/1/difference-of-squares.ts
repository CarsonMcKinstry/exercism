export class Squares {

  nums: number[];
  
  constructor(count: number) {
    this.nums = Array.from({ length: count }, (_, i) => i + 1);
  }

  get sumOfSquares(): number {
    return this.nums
      .map(n => n ** 2)
      .reduce((acc, val) => acc + val, 0);
  }

  get squareOfSum(): number {
    const sum = this.nums.reduce((acc, val) => acc + val, 0);

    return sum ** 2;
  }

  get difference(): number {
    return Math.abs(
      this.sumOfSquares - this.squareOfSum
    )
  }
}
