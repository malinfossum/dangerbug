namespace DangerBug.Core.Models;

public class Tick : Bug
{
    public Tick() : base("Tick")
    {
        Legs = 8;
        CanBite = true;
        Plague = "Can cause serious illness (Dangerous)";
        RiskLevel = Risk.Dangerous;
    }
}
