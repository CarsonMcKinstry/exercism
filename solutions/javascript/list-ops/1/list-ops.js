//
// This is only a SKELETON file for the 'List - Ops' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class List {
  constructor(values = []) {
    this.values = values;
  }

  append(list) {
    const nextValues = [];

    for(const value of list.values) {
      nextValues.push(value);
    }

    return new List([
      ...this.values,
      ...nextValues
    ]);
  }

  concat(list) {
    let nextList = new List(this.values);

    for(const value of list.values) {
      nextList = nextList.append(value);
    }

    return nextList;
  }

  filter(fn) {
    const nextValues = [];

    for(const value of this.values) {
      if (fn(value)) {
        nextValues.push(value)
      }
    }

    return new List(nextValues);
  }

  map(fn) {
      const nextValues = [];
  
      for(const value of this.values) {
        nextValues.push(fn(value))
      }
  
      return new List(nextValues);
  }

  length() {
    return this.values.length;
  }

  foldl(fn, int) {
    for (const value of this.values) {
      int = fn(int, value);
    }

    return int;
  }

  foldr(fn, int) {
    for (let i = this.values.length - 1; i >= 0; i--) {
      int = fn(int, this.values[i]);
    }
    return int;
  }

  reverse() {
    const nextValues = [];

    for(let i = this.values.length - 1; i >= 0; i--) {
      nextValues.push(this.values[i]);
    }

    return new List(nextValues);
  }
}
