using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.interfaces;


namespace FirstStrike
{
    public class Terrorist : Soldier
    {
        protected List<IWeapons> Weapons { get; set; }

        public Terrorist(string name, int rank,List<IWeapons> weapons, bool isAlive = true) : base(name, rank, isAlive)
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
