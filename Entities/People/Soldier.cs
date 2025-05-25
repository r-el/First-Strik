using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FirstStrike
{
    public class Soldier : Person
    {
        public int Rank { get; set; }
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
