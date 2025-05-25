using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Entities.Aman
{
    public class IntelligenceMessages
    {
        protected Terrorist NameTerrorist { get; set; }
        protected Location Location { get; set; }
        protected DateTime TimeStamp { get; set; }
    
    public  IntelligenceMessages(Terrorist nameTerrorist, Location location, DateTime timestamp)
        {
            NameTerrorist = nameTerrorist;
            Location = location;
            TimeStamp = timestamp;
     }
        public override string ToString()
        {
            
            return $"NameTerrorist: {NameTerrorist}, {Location} , TimeStamp: {TimeStamp} ";
        }
    }
}
