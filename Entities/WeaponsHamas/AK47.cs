using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.interfaces;

namespace FirstStrike.Entities.WeaponsHamas
{
    public record AK47 : IWeapons
    {
        public string Name { get; } = "AK47";

        public int SeverityLevel { get; } = 3;


        public override string ToString()
        {
            return $"Name: {Name}, SeverityLevel: {SeverityLevel} ";
        }


    }
}

