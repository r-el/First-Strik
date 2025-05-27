using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Entities.Aman;

namespace FirstStrike.Utilities
{
    internal class IntelligenceAnalyzer
    {
        //Function to return the severity of the terrorist - calculate the level of the terrorist * the severity of the weapon.
        //Includes a valorization in case there is no weapon.
        public static int GetTerroristSeverityLevel(Terrorist terrorist)
        {
            if (!terrorist.Weapons.Any())
                return terrorist.Rank;

            int totalSeverity = terrorist.Weapons.Sum(w => w.SeverityLevel);
            return totalSeverity * terrorist.Rank;
        }

        public static Terrorist GetMostDangerousTerrorist(List<Terrorist> terrorisits)
        {
            Terrorist terrorist= terrorisits[0];
            int TerroristSeverity = GetTerroristSeverityLevel(terrorist);
            for (int i = 1; i < terrorisits.Count; i++)
            {
                int j = GetTerroristSeverityLevel(terrorisits[i]);
                if (j > TerroristSeverity)
                {
                    TerroristSeverity = j;
                    terrorist = terrorisits[i];
                }
            }

            return terrorist;
        }
  
        public static IntelligenceMessages GetMostFeaturedTerrorist(List<IntelligenceMessages> intelligenceMessages)
        {
            Dictionary<Terrorist, int> countDict = new Dictionary<Terrorist, int>();

            
            foreach (var im in intelligenceMessages)
            {
                var terrorist = im.NameTerrorist;

                if (countDict.ContainsKey(terrorist))
                    countDict[terrorist]++;
                else
                    countDict[terrorist] = 1;
            }

            Terrorist mostCommon = null;
            int maxCount = 0;

            foreach (var pair in countDict)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostCommon = pair.Key;
                }
            }
            foreach (var msg in intelligenceMessages)
            {
                if (msg.NameTerrorist == mostCommon)
                    return msg;
            }
            return null;

            //return intelligenceMessages.FirstOrDefault(msg => msg.NameTerrorist == mostCommon);
        }



    }
}
