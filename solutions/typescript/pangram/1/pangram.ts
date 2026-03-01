export default class Pangram {
  constructor(private value: string) {}

  isPangram(): boolean {
    const deburred = this.value.toLowerCase().replace(/[^a-zA-Z]/g, "");

    const letters = new Set(Array.from(deburred));

    return letters.size === 26;
  }
}
