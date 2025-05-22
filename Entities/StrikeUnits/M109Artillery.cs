using FirstStrike.Entities.StrikeUnits;

namespace FirstStrike.Entities.StrikeUnits
{
    public class M109Artillery : StrikeUnitBase
    {
        public override string Name { get; } = "M109 Artillery";
        public override int Ammo { get; } = 40;
        public override double Fuel { get; } = 100;
        public override string[] EffectiveAgainst { get; } = ["open area"];

        // TODO: Complete rest..
    }
}