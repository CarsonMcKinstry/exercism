class SimpleCipher {
  #key: number[];

  #aCode: number = "a".charCodeAt(0);
  #zCode: number = "z".charCodeAt(0);

  constructor(key?: string) {
    this.#key = key ? this.toCharCodes(key) : this.generateKey();
  }

  get key() {
    return this.fromCharCodes(this.#key);
  }

  encode(toEncode: string): string {
    let charCodes = this.toCharCodes(toEncode).map((code, offset) => {
      const keyCode = this.getCharCodeAtOffset(offset);

      const charCode = code - this.#aCode + keyCode;

      return this.wrapCharCode(charCode);
    });

    return this.fromCharCodes(charCodes);
  }

  decode(toDecode: string): string {
    const charCodes = this.toCharCodes(toDecode).map((code, offset) => {
      const keyCode = this.getCharCodeAtOffset(offset);

      const charCode = code - keyCode + this.#aCode;

      return this.wrapCharCode(charCode);
    });

    return this.fromCharCodes(charCodes);
  }

  private getCharCodeAtOffset(offset: number): number {
    return this.#key[offset % this.#key.length];
  }

  private generateKey(length: number = 100): number[] {
    return Array.from({ length }, () =>
      Math.floor(Math.random() * (this.#zCode - this.#aCode) + this.#aCode)
    );
  }

  private toCharCodes(str: string): number[] {
    return [...str].map((c) => c.charCodeAt(0));
  }

  private fromCharCodes(codes: number[]): string {
    return String.fromCharCode(...codes);
  }

  private wrapCharCode(charCode: number): number {
    if (charCode > this.#zCode) {
      return charCode - this.#zCode + this.#aCode - 1;
    }

    if (charCode < this.#aCode) {
      return charCode - this.#aCode + this.#zCode + 1;
    }

    return charCode;
  }
}

export default SimpleCipher;
