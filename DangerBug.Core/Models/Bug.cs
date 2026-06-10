namespace DangerBug.Core.Models;

public class Bug
{
    public string Name { get; set; }
    public int Legs { get; set; }
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public bool CanMove { get; set; }
    public string Plague { get; set; }
    public string GoodStuff { get; set; }

    public Risk RiskLevel { get; set; }

    public Bug(string name)
    {
        Name = name;
        Legs = 6;
        CanMove = true;
        Plague = "";
        GoodStuff = "";
        RiskLevel = Risk.Harmless;
    }

    public virtual string Describe()
    {
        string info = $"{Name}\n";
        info += $"  Risk: {RiskText()}\n";
        info += $"  Legs: {Legs}\n";
        info += $"  Can fly: {(CanFly ? "yes" : "no")}\n";
        info += $"  Can bite: {(CanBite ? "yes" : "no")}\n";

        if (Plague != "")
        {
            info += $"  Plague: {Plague}\n";
        }

        if (GoodStuff != "")
        {
            info += $"  Good stuff: {GoodStuff}\n";
        }

        return info;
    }

    private string RiskText()
    {
        switch (RiskLevel)
        {
            case Risk.Dangerous: return "Dangerous";
            case Risk.Nuisance: return "Nuisance";
            default: return "Harmless";
        }
    }
}
