using System;
using System.Collections.Generic;
using FirstStrike.Interfaces;

namespace FirstStrike.Entities.TerrorOrganizations
{
    public class Hamas : ITerrorOrganization // Singleton instance
    {
        private static readonly Hamas _instance = new(new DateTime(1987, 12, 14), "יחיא סינוואר");
        public static Hamas Instance => _instance;

        public DateTime Formed { get; }
        public string Commander { get; private set; }
        public List<Terrorist> Terrorists { get; private set; }

        // Private constructor for singleton
        private Hamas(DateTime formed, string commander)
        {
            Formed = formed;
            Commander = commander;
            Terrorists = [];
        }

        public override string ToString()
        {
            string terroristsList = Terrorists.Count == 0 ? "(אין טרוריסטים)" : string.Join("\n- ", Terrorists);
            return $"חמאס | הוקם: {Formed:dd/MM/yyyy} | מפקד: {Commander}\nטרוריסטים:\n- {terroristsList}";
        }
    }
}
