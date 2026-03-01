const NAME_REGISTER = new Set<string>();

export default class RobotName {
  public name: string;

  constructor() {
    this.name = this.generateName();
  }

  private randomLetter() {
    const num = Math.floor(Math.random() * 26 + 65);

    return String.fromCharCode(num);
  }

  private randomNumber() {
    return Math.floor(Math.random() * 9);
  }

  private generateName(): string {
    const letters = [
      this.randomLetter(),
      this.randomLetter(),
      this.randomNumber(),
      this.randomNumber(),
      this.randomNumber(),
    ];

    let name = letters.join("");

    if (NAME_REGISTER.has(name)) {
      name = this.generateName();
    }

    NAME_REGISTER.add(name);

    return name;
  }

  public resetName() {
    this.name = this.generateName();
  }
}
