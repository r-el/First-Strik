using FirstStrike.Entities.StrikeUnits;

namespace FirstStrike.Entities.StrikeUnits
{
    public class Hermes460Drone : StrikeUnitBase
    {
        public override string Name { get; } = "Hermes 460 Drone (Zik)";
        public override int Ammo { get; } = 3;
        public override double Fuel { get; } = 100;
        public override string[] EffectiveAgainst { get; } = ["People", "vehicles"];

        // TODO: Complete rest..

    }
}