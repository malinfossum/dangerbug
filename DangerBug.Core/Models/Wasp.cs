namespace DangerBug.Core.Models;

public class Wasp : Bug
{
    public Wasp() : base("Wasp")
    {
        CanFly = true;
        CanBite = true;
        Plague = "Venomous sting";
        GoodStuff = "Pollination";
        RiskLevel = Risk.Dangerous;
    }

    public override string Describe()
    {
        return base.Describe() + "Can be life-threatening if allergic\n";
    }
}
