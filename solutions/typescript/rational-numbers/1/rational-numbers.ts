export default class Rational {
  a: number;
  b: number;

  constructor(a: number, b: number) {
    this.a = a;
    this.b = b;
  }
  /**
   * The sum of two rational numbers r1 = a1/b1 and r2 = a2/b2 is
   * r1 + r2 = a1/b1 + a2/b2 = (a1 * b2 + a2 * b1) / (b1 * b2).
   */
  add(other: Rational): Rational {
    const num = this.a * other.b + other.a * this.b;
    const den = this.b * other.b;

    return new Rational(num, den).reduce();
  }

  /**
   * The difference of two rational numbers r1 = a1/b1 and r2 = a2/b2 is
   * r1 - r2 = a1/b1 - a2/b2 = (a1 * b2 - a2 * b1) / (b1 * b2
   */
  sub(other: Rational): Rational {
    const num = this.a * other.b - other.a * this.b;
    const den = this.b * other.b;

    return new Rational(num, den).reduce();
  }

  /**
   * The product (multiplication) of two rational numbers r1 = a1/b1 and r2 = a2/b2
   * is r1 * r2 = (a1 * a2) / (b1 * b2)
   */
  mul(other: Rational): Rational {
    const num = this.a * other.a;
    const den = this.b * other.b;

    return new Rational(num, den).reduce();
  }

  /**
   * Dividing a rational number r1 = a1/b1 by another r2 = a2/b2 is
   * r1 / r2 = (a1 * b2) / (a2 * b1) if a2 * b1 is not zero.
   */
  div(other: Rational): Rational {
    let num = this.a * other.b;
    let den = other.a * this.b;

    return new Rational(num, den).reduce();
  }

  abs(): Rational {
    const num = this.a < 0 ? this.a * -1 : this.a;
    const den = this.b < 0 ? this.b * -1 : this.b;

    return new Rational(num, den).reduce();
  }

  exprational(exp: number): Rational {
    const num = this.a ** exp;
    const den = this.b ** exp;

    return new Rational(num, den).reduce();
  }

  expreal(value: number): number {
    const exp = this.a / this.b;

    return value ** exp;
  }

  reduce(): Rational {
    const div = gcd(this.a, this.b);

    let num = this.a / div;
    let den = this.b / div;

    if (den < 1) {
      num *= -1;
      den *= -1;
    }

    return new Rational(num, den);
  }
}

function gcd(a: number, b: number): number {
  if (b === 0) {
    return a;
  }

  return gcd(b, a % b);
}
