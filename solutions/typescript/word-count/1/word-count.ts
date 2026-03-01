export function count(str: string) {
    const result: Record<string, number> = {};

    const onWhiteSpaces = str
        .trim()
        .split(/\s{1,}/)
        .map((p) => p.toLowerCase());

    for (const part of onWhiteSpaces) {
        if (!Object.keys(result).includes(part)) {
            result[part] = 0;
        }

        result[part]++;
    }

    return new Map(Object.entries(result));
}
