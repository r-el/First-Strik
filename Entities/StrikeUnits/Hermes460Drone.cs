using FirstStrike.Interfaces;

public class Hermes460Drone : IStrikeUnit
{
    public string Name { get; } = "Hermes 460 Drone (Zik)";
    public int Ammo { get; private set; } = 3;
    public double Fuel { get; private set; } = 100;
    public string[] EffectiveAgainst { get; } = ["People", "vehicles"];

    // TODO: Complete rest..
    public override string ToString()
    {
        return $"{Name} | Ammo: {Ammo} | Fuel: {Fuel} | Effective Against: {string.Join(", ", EffectiveAgainst)}";
    }
}