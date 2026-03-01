class Clock {
  private _hours!: number;
  private _minutes!: number;

  constructor(hours: number, minutes: number = 0) {
    this.hours = hours;
    this.minutes = minutes;
  }

  public get hours() {
    return this._hours;
  }

  public set hours(value: number) {
    const nextHours = value % 24;

    if (nextHours < 0) {
      this._hours = 24 + nextHours;
    } else {
      this._hours = nextHours;
    }
  }

  public get minutes() {
    return this._minutes;
  }

  public set minutes(value: number) {
    const potentialHours = Math.floor(value / 60);
    const potentialMinutes = value % 60;

    this.hours += potentialHours;

    if (potentialMinutes < 0) {
      this._minutes = 60 + potentialMinutes;
    } else {
      this._minutes = potentialMinutes;
    }
  }

  public plus(minutes: number) {
    this.minutes += minutes;

    return this;
  }

  public minus(minutes: number) {
    this.minutes -= minutes;

    return this;
  }

  public toString() {
    return `${this.formatNumber(this.hours)}:${this.formatNumber(
      this.minutes
    )}`;
  }

  public equals(clock: Clock) {
    return this.minutes === clock.minutes && this.hours === clock.hours;
  }

  private formatNumber(n: number) {
    if (n < 10) {
      return `0${n}`;
    }

    return n;
  }
}

export default Clock;
