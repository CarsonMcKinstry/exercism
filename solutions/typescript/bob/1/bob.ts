class Bob {
  isYelling(phrase: string): boolean {
    return !!phrase.replace(/[^a-zA-Z]/g, "").match(/^[A-Z]+$/g);
  }

  isQuestion(phrase: string): boolean {
    return phrase.trim().endsWith("?");
  }

  isEmpty(phrase: string): boolean {
    return phrase.trim().length === 0;
  }

  hey(phrase: string): string {
    if (this.isEmpty(phrase)) {
      return "Fine. Be that way!";
    }

    if (this.isQuestion(phrase)) {
      if (this.isYelling(phrase)) {
        return "Calm down, I know what I'm doing!";
      }
      return "Sure.";
    }

    if (this.isYelling(phrase)) {
      return "Whoa, chill out!";
    }

    return "Whatever.";
  }
}

export default Bob;
