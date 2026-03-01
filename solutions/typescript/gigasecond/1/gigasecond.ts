export class Gigasecond {
  private moment: Date;
  private gigasecond: Date;

  constructor(startingMoment: Date) {
    this.moment = startingMoment;
    this.gigasecond = new Date(this.moment.valueOf() + 10 ** 12);
  }

  public date() {
    return this.gigasecond;
  }
}
