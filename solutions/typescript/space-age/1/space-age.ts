const EarthOribitalPeriodS = 31557600;

enum PlanetaryPeriod {
  Earth = 1,
  Mercury = 0.2408467,
  Venus = 0.61519726,
  Mars = 1.8808158,
  Jupiter = 11.862615,
  Saturn = 29.447498,
  Uranus = 84.016846,
  Neptune = 164.79132,
}

export default class SpaceAge {
  constructor(public seconds: number) {}

  private getYearsByOrbitalPeriod(seconds: number, period: PlanetaryPeriod) {
    return parseFloat((seconds / (EarthOribitalPeriodS * period)).toFixed(2));
  }

  onEarth(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Earth);
  }

  onMercury(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Mercury);
  }

  onVenus(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Venus);
  }

  onMars(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Mars);
  }

  onJupiter(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Jupiter);
  }

  onSaturn(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Saturn);
  }
  onUranus(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Uranus);
  }
  onNeptune(): number {
    return this.getYearsByOrbitalPeriod(this.seconds, PlanetaryPeriod.Neptune);
  }
}
