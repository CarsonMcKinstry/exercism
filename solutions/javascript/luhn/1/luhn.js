export class Luhn {
  constructor(value) {
    this.digits = value.replace(/\s+/g, '').split('').map(Number).reverse();
  }


  get valid() {

    if (!this.digits.every(v => !Number.isNaN(v))) {
      return false;
    }

    if (this.digits.length <= 1) {
      return false;
    }

    const t = this.digits.reduce((total, value, index) => {
      if (index % 2 !== 0) {
        const next = value * 2;

        return total + (next > 9 ? next - 9 : next);
      }
        return  total + value;
    }, 0)

    return t % 10 === 0;
  }
}
