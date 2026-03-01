//
// This is only a SKELETON file for the 'Grains' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

import BigInt from './lib/big-integer';

export class Grains {
  
  _square(n) {
    const i = BigInt(2);

    return i.pow(n - 1);
  }

  _total(n = 64) {
    if (n <= 0) {
      return 0;
    }
    return this._square(n).add(this._total(n - 1));
  }

  square(n) {

    return this._square(n).toString();
  }

  total() {
    // console.log(this._total());
    return this._total().toString();
  }
}
