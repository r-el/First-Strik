using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Utilities;

namespace FirstStrike.Entities.Aman
{
    internal class IntelligenceMessages
    {
        public Terrorist NameTerrorist { get; set; }
        protected Location Location { get; set; }
        protected DateTime TimeStamp { get; set; }

        protected int EverityLevel;

        public  IntelligenceMessages(Terrorist nameTerrorist, Location location, DateTime timestamp)
        {
            NameTerrorist = nameTerrorist;
            Location = location;
            TimeStamp = timestamp;
            EverityLevel = IntelligenceAnalyzer.GetTerroristSeverityLevel(NameTerrorist);
     }
        public override string ToString()
        {
            
            return $"NameTerrorist: {NameTerrorist}, {Location} , TimeStamp: {TimeStamp}, TerroristSeverityLevel: {EverityLevel} ";
        }
    }
}
