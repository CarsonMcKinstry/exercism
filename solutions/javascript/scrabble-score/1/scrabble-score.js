//
// This is only a SKELETON file for the 'Scrabble Score' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const getLetterScore = (letter) => {
  switch(letter) {
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
    case 'l':
    case 'n':
    case 'r':
    case 's':
    case 't':
        return 1;
    case 'd':
    case 'g':
        return 2;
    case 'b':
    case 'c':
    case 'm':
    case 'p':
        return 3;
    case 'f':
    case 'h':
    case 'v':
    case 'w':
    case 'y':
        return 4;
    case 'k':
        return 5;
    case 'j':
    case 'x':
        return 8
    case 'q':
    case 'z':
        return 10;
    default:
      return 0;

  }
}

export const score = (letters) => {
  return letters.toLowerCase().split('').reduce((total, letter) => total + getLetterScore(letter), 0);
};
