namespace DangerBug.Core.Models;

public class Mosquito : Bug
{
    public Mosquito() : base("Mosquito")
    {
        CanFly = true;
        CanBite = true;
        Plague = "Itch - sucks blood, can cause disease";
        RiskLevel = Risk.Nuisance;
    }
}
