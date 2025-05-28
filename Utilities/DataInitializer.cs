using System;
using System.Collections.Generic;
using FirstStrike.Entities;
using FirstStrike.Entities.Aman;
using FirstStrike.Entities.StrikeUnits;
using FirstStrike.Entities.TerrorOrganizations;
using FirstStrike.Entities.WeaponsHamas;
using FirstStrike.Interfaces;
using FirstStrike.interfaces;

namespace FirstStrike.Utilities
{
    public static class DataInitializer
    {
        private static readonly Random _rand = new();
        private static readonly string[] TerroristNames =
        [
            "אחמד", "מוחמד", "עלי", "יוסוף", "סמיר", "חאלד", "איברהים", "סאלח", "פאיז", "עבדאללה"
        ];

        // מערך שמחזיק את כל הטיפוסים של מחלקות הנשק, ליצרית נשקים רנדומליים
        // מאפשר להרחיב בקלות את סוגי הנשקים 
        // ע"י הוספה של טיפוס חדש למערך, מבלי לשנות את לוגיקת האתחול.
        // כך הקוד גמיש יותר עומד בעקרון Open/Closed Principle.
        private static readonly Type[] WeaponTypes =
        [
            typeof(Knife), typeof(Gun), typeof(M16), typeof(AK47)
        ];

        public static List<Terrorist> GenerateRandomTerrorists(int count)
        {
            List<Terrorist> terrorists = new(count);
            for (int i = 0; i < count; i++)
            {
                string name = TerroristNames[_rand.Next(TerroristNames.Length)];
                int rank = _rand.Next(1, 6); // 1-5
                List<IWeapons> weapons = GenerateRandomWeapons(_rand.Next(1, 4));
                terrorists.Add(new Terrorist(name, rank, weapons));
            }
            return terrorists;
        }

        public static List<IWeapons> GenerateRandomWeapons(int count)
        {
            List<IWeapons> weapons = [];
            for (int i = 0; i < count; i++)
            {
                Type type = WeaponTypes[_rand.Next(WeaponTypes.Length)];
                weapons.Add((IWeapons)Activator.CreateInstance(type)!);
            }
            return weapons;
        }

        public static List<IntelligenceMessages> GenerateRandomIntelligenceMessages(List<Terrorist> terrorists, int count)
        {
            // TODO: לדאוג שהמיקומים יעבדו עם כלי התקיפה
            string[] locations = ["home", "in a car", "outside", "tunnel", "building"];
            List<IntelligenceMessages> messages = [];
            for (int i = 0; i < count; i++)
            {
                Terrorist terrorist = terrorists[_rand.Next(terrorists.Count)];
                Location location = new(locations[_rand.Next(locations.Length)]);
                DateTime timestamp = DateTime.Now.AddHours(-_rand.Next(0, 48)); // up to 48 hours ago
                messages.Add(new IntelligenceMessages(terrorist, location, timestamp));
            }
            return messages;
        }

        public static List<IStrikeUnit> InitIDFStrikeUnits()
        {
            return [new F16FighterJet(), new Hermes460Drone(), new M109Artillery()];
        }
    }
}
