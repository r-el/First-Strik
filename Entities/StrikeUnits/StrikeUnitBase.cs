using FirstStrike.Interfaces;

namespace FirstStrike.Entities.StrikeUnits
{
    public abstract class StrikeUnitBase : IStrikeUnit
    {
        public abstract string Name { get; }
        public abstract int Ammo { get; }
        public abstract double Fuel { get; }
        public abstract string[] EffectiveAgainst { get; }

        public override string ToString()
        {
            return $"{Name} | Ammo: {Ammo} | Fuel: {Fuel} | Effective Against: {string.Join(", ", EffectiveAgainst)}";
        }
    }
}
