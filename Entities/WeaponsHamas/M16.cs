using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.interfaces;

namespace FirstStrike.Entities.WeaponsHamas
{
    public record M16 : IWeapons
    {
        public string Name { get; } = "M16";

        public int SeverityLevel { get; } = 3;


        public override string ToString()
        {
            return $"Name: {Name}, SeverityLevel: {SeverityLevel} ";
        }


    }
}

