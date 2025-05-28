using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Entities.Aman
{
    public class Location
    {
        // Dictionary<string, string> Terroristlocation = new Dictionary<string, string> { };
        //public  Location(Dictionary<string, string> terroristlocation)

        public string Terroristlocation { get; set; }

        public Location(string terroristlocation)
        {

            Terroristlocation = terroristlocation;
        }
        public override string ToString()
        {
            return $"Terroristlocation: {Terroristlocation} ";
        }
    }
}
