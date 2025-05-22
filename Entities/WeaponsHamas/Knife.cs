using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.interfaces;

namespace FirstStrike.Entities.WeaponsHamas
{
    public record Knife : IWeapons
    {
        public string Name { get; } = "Knife";

        public int SeverityLevel { get; } = 1;


        public override string ToString()
        {
            return $"Name: {Name}, SeverityLevel: {SeverityLevel} ";
        }


    }
}
