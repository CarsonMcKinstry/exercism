public class SpaceAge(int seconds)
{

    private const double EarthYearDays = 365.25f;

    private double _earthAge = seconds / (EarthYearDays * 24 * 60 * 60);

    private const double MercuryOrbitalPeriod =  0.2408467;
    private const double VenusOrbitalPeriod =  0.61519726;
    private const double MarsOrbitalPeriod =  1.8808158;
    private const double JupiterOrbitalPeriod =  11.862615;
    private const double SaturnOrbitalPeriod =  29.447498;
    private const double UranusOrbitalPeriod =  84.016846;
    private const double NeptuneOrbitalPeriod =  164.79132;
    
    public double OnEarth() => _earthAge;

    public double OnMercury() => _earthAge / MercuryOrbitalPeriod;

    public double OnVenus() => _earthAge / VenusOrbitalPeriod;

    public double OnMars() => _earthAge / MarsOrbitalPeriod;

    public double OnJupiter() => _earthAge / JupiterOrbitalPeriod;

    public double OnSaturn() => _earthAge / SaturnOrbitalPeriod;

    public double OnUranus() => _earthAge / UranusOrbitalPeriod;

    public double OnNeptune() => _earthAge / NeptuneOrbitalPeriod;
}