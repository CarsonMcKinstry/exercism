//
// This is only a SKELETON file for the 'Isogram' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isIsogram = (possibleIsogram) => {
  const toCheck = Object.values(possibleIsogram
    .toLowerCase()
    .replace(/[\s\-]/g, '')
    .split('')
    .reduce((letters, letter) => {
      if (!letters[letter]) {
        letters[letter] = 0;
      }

      letters[letter]++;

      return letters;
    }, {}));

    return toCheck.every(v => v === 1);
};
