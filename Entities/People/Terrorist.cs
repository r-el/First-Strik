using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstStrike
{
    public class Terrorist : Soldier
    {
        // TODO: Change string type to weapon type
        protected List<string> Weapons { get; set; }

        public Terrorist(string name, int rank,List<string> weapons, bool isAlive = true) : base(name, rank, isAlive)
        {
            Weapons = weapons;
        }

        public override string ToString()
        {
            string weaponsList = string.Join(", ", Weapons);
            return $"Name: {Name}, Rank: {Rank}, Weapons: [{weaponsList}], IsAlive: {IsAlive}";
        }
    }

}
