using FirstStrike.Interfaces;

namespace FirstStrike.Entities.StrikeUnits
{
    public class F16FighterJet : IStrikeUnit
    {
        public string Name { get; } = "F16 Fighter Jet";
        public int Ammo { get; private set; } = 8;
        public double Fuel { get; private set; } = 100;
        public string[] EffectiveAgainst { get; } = { "buildings" };

        // TODO: Complete rest..
    }
}