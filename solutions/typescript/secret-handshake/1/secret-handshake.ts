const commands: Record<number, string> = {
  4: "wink",
  3: "double blink",
  2: "close your eyes",
  1: "jump",
};

class Handshake {
  private binary: number[];

  constructor(decimal: number) {
    this.binary = decimal
      .toString(2)
      .split("")
      .map((n) => parseInt(n));

    if (this.binary.length !== 5) {
      const length = this.binary.length;
      for (let i = 0; i < 5 - length; i++) {
        this.binary.unshift(0);
      }
    }
  }

  commands() {
    return this.binary.reduceRight((acc: any, val: any, idx) => {
      if (val > 0) {
        if (idx in commands) {
          acc.push(commands[idx]);
        } else if (idx === 0) {
          acc.reverse();
        }
      }

      return acc;
    }, []);
  }
}

export default Handshake;
