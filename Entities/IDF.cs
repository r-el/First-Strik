using System;
using System.Collections.Generic;
using FirstStrike.Interfaces;

namespace FirstStrike.Entities
{
    public class IDF // Singleton instance
    {
        private static readonly IDF _instance = new();
        public static IDF Instance => _instance;
        // תאריך הקמה
        public DateTime Established { get; } = new DateTime(1948, 5, 26); // cannot be changed
        // מפקד נוכחי
        public string Commander { get; set; } = string.Empty;
        // יחידות תקיפה
        public List<IStrikeUnit> StrikeUnits { get; set; } = [];
        // מניעת יצירת מופעים נוספים
        private IDF() { /* צה"ל יש רק אחד */ }
    }
}
