namespace DangerBug.Core.Models;

public class Spider : Bug
{
    public Spider() : base("Spider")
    {
        Legs = 8;
        CanBite = true;
        Plague = "Can bite humans, can be toxic";
        GoodStuff = "Eats flies and mites";
        RiskLevel = Risk.Nuisance;
    }
}
