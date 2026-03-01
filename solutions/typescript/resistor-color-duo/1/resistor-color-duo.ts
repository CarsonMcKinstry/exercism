type BandColor = {
  [key: string]: number;
};

const BandColor: BandColor = {
  black: 0,
  brown: 1,
  red: 2,
  orange: 3,
  yellow: 4,
  green: 5,
  blue: 6,
  violet: 7,
  grey: 8,
  white: 9,
};

export class ResistorColor {
  private colors: string[];

  constructor(colors: string[]) {
    this.colors = colors;
    if (this.colors.length < 2) {
      throw new Error("At least two colors need to be present");
    }
  }
  value = (): number => {
    const [bandOne, bandTwo] = this.colors;

    if (bandOne in BandColor && bandTwo in BandColor) {
      return BandColor[bandOne] * 10 + BandColor[bandTwo];
    }
    return 0;
  };
}
