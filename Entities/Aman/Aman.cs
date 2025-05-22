using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Entities.Aman
{
    internal class Aman
    {
        public List<IntelligenceMessages> IntelligenceMessages;
        public Aman(List<IntelligenceMessages> intelligenceMessages)
        {
            IntelligenceMessages = intelligenceMessages;
        }

    }
}
