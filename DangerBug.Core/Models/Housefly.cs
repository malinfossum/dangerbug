namespace DangerBug.Core.Models;

public class Housefly : Bug
{
    public Housefly() : base("Housefly")
    {
        CanFly = true;
        Plague = "Can spread diseases";
        RiskLevel = Risk.Nuisance;
    }
}
