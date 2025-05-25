using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Entities.Aman
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


    }
}
