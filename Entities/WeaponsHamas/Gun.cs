using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.interfaces;

namespace FirstStrike.Entities.WeaponsHamas
{
    public record Gun : IWeapons
    {
        public string Name { get; } = "Gun";

        public int SeverityLevel { get; } = 2;


        public override string ToString()
        {
            return $"Name: {Name}, SeverityLevel: {SeverityLevel} ";
        }


    }
}
