using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FirstStrike
{
    internal class Soldier : Person
    {
        protected int Rank { get; set; }
        public Soldier(string name, int rank, bool isAlive = true) : base(name, isAlive)
        {
            Rank = rank;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Rank: {Rank}, IsAlive: {IsAlive}";
        }
    }
}
