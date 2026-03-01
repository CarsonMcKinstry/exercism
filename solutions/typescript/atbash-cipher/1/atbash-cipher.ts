function encodeChar(char: string) {
  const zeroIndex = char.charCodeAt(0) - "a".charCodeAt(0);

  const nextLetter = (26 - zeroIndex + 25) % 26;

  return String.fromCharCode(nextLetter + "a".charCodeAt(0));
}

export default class AtbashCipher {
  encode(str: string): string {
    const sanitized = str.toLowerCase().replace(/[\W\s]/g, "");

    let final = "";
    let count = 0;
    for (const char of sanitized) {
      if (!Number.isNaN(parseInt(char))) {
        final += char;
      } else {
        final += encodeChar(char);
      }

      count++;
      if (count === 5) {
        final += " ";
        count = 0;
      }
    }

    return final.trim();
  }

  decode(str: string): string {
    const sanitized = str.replace(/\s/g, "");

    let final = "";

    for (const char of sanitized) {
      if (!Number.isNaN(parseInt(char))) {
        final += char;
      } else {
        final += encodeChar(char);
      }
    }

    return final;
  }
}
