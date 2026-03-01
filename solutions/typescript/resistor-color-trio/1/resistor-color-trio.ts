const bandValues = {
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
} as const;

type Band = keyof typeof bandValues;

function repeat(str: string, n: number) {
    let result = "";

    for (let i = 0; i < n; i++) {
        result += str;
    }

    return result;
}

export function decodedResistorValue(bands: [Band, Band, Band]) {
    const values = bands.map((band) => bandValues[band]);

    const [first, second, zeros] = values;

    const ohms = Number([first, second, repeat("0", zeros)].join(""));

    if (ohms / 1000 > 1) {
        return ohms / 1000 + " kiloohms";
    }

    return ohms + " ohms";
}
