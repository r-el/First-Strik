using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Entities.Aman
{
    internal class Aman
    {
        public List<IntelligenceMessages> ListIntelligence { get; set; } = [];
        public void AddIntelligenceMessages(IntelligenceMessages intelligenceMessages)
        {
            ListIntelligence.Add(intelligenceMessages);
        }
        /// <summary>
        /// Returns a user-friendly formatted string representation of Aman intelligence data for console display
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("═════════════════════════════════════════════════════");
            sb.AppendLine("                   AMAN INTELLIGENCE UNIT             ");
            sb.AppendLine("═════════════════════════════════════════════════════");

            if (ListIntelligence == null || ListIntelligence.Count == 0)
            {
                sb.AppendLine("No intelligence messages available.");
                return sb.ToString();
            }

            sb.AppendLine($"Total Intelligence Messages: {ListIntelligence.Count}");
            sb.AppendLine();

            // Display only first 5 intelligence reports
            int displayCount = Math.Min(5, ListIntelligence.Count);

            for (int i = 0; i < displayCount; i++)
            {
                sb.AppendLine($"── Intelligence Report #{i + 1} ──");
                sb.AppendLine(ListIntelligence[i].ToString());

                if (i < displayCount - 1)
                    sb.AppendLine(); // Add spacing between messages
            }

            // Show indicator if there are more reports
            if (ListIntelligence.Count > 5)
            {
                sb.AppendLine();
                sb.AppendLine($"⚠️  And {ListIntelligence.Count - 5} more intelligence reports...");
                sb.AppendLine("   (Use detailed view to see all reports)");
            }

            sb.AppendLine("═════════════════════════════════════════════════════");

            return sb.ToString();
        }
    }
}
