using FirstStrike.Interfaces;

namespace FirstStrike.Entities.StrikeUnits
{
    public class F16FighterJet : StrikeUnitBase
    {
        public override string Name { get; } = "F16 Fighter Jet";
        public override int Ammo { get; } = 8;
        public override double Fuel { get; } = 100;
        public override string[] EffectiveAgainst { get; } = { "buildings" };
        
        // TODO: Complete rest..
    }
}