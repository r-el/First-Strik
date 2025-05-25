using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Entities.Aman
{
    internal class Aman
    {
        public  List<IntelligenceMessages> ListIntelligence { get; set; } = [];
        public void AddIntelligenceMessages(IntelligenceMessages intelligenceMessages)
        {

            ListIntelligence.Add(intelligenceMessages);
        }
        //Printing a temporary string, prints the list of information
        public override string ToString()
        {
            string strListIntelligence = string.Join(", ", ListIntelligence);

            return $"ListIntelligence: {strListIntelligence} ";
        }


    }
}
