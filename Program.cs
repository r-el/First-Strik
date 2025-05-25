using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike;
using FirstStrike.Entities;
using FirstStrike.Entities.Aman;
using FirstStrike.Entities.StrikeUnits;
using FirstStrike.Entities.TerrorOrganizations;
using FirstStrike.Entities.WeaponsHamas;
using FirstStrike.interfaces;

// ---------- יחידות תקיפה ---------- //
Console.WriteLine("===== יחידות תקיפה =====");
F16FighterJet f16 = new();
Hermes460Drone hermes = new();
M109Artillery m109 = new();

Console.WriteLine(f16);
Console.WriteLine(hermes);
Console.WriteLine(m109);

// ---------- אנשים ---------- //
Console.WriteLine("===== טרוריסטים =====");
//Terrorist moohamad = new Terrorist("moohamad", 3,[ "coll", "sakin"],true);
//Console.WriteLine(moohamad);

// ---------- IDF ---------- //
IDF idf = IDF.Instance;
idf.Commander = "אייל זמיר";

// הוספת יחידות תקיפה
idf.StrikeUnits.Add(f16);
idf.StrikeUnits.Add(hermes);
idf.StrikeUnits.Add(m109);

Console.WriteLine("===== צה\"ל (ToString) =====");
Console.WriteLine(idf);

// ---------- דוגמה לשימוש ב-Hamas (Singleton) ---------- //
Hamas hamas = Hamas.Instance;
//hamas.Terrorists.Add(new Terrorist("אחמד", 1, new List<string> { "רובה", "סכין" }));
//hamas.Terrorists.Add(new Terrorist("מוחמד", 2, new List<string> { "אקדח" }));

Console.WriteLine(hamas);

// ---------- הודעות מודיעיניות ---------- //
Location locationMoohamad = new Location("home");
List<IWeapons> listweapons = [new AK47()];
Terrorist moohamad = new("moohamad",3, listweapons);

IntelligenceMessages messag1 = new IntelligenceMessages(moohamad, locationMoohamad, DateTime.Now
);
Console.WriteLine(messag1);

Aman aman = new();
aman.AddIntelligenceMessages(messag1);
Console.WriteLine(aman);

// ---------- סוגי נשק חמאס ---------- //
Knife k = new();
Console.WriteLine(k);

// ---------- הפעלת תפריט מפקד ---------- //
// CommanderConsole.Run();