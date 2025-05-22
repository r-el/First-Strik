using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike;
using FirstStrike.Entities;
using FirstStrike.Entities.StrikeUnits;
using FirstStrike.Entities.TerrorOrganizations;

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
Terrorist moohamad = new Terrorist("moohamad", 3,[ "coll", "sakin"],true);
Console.WriteLine(moohamad);

// ---------- IDF ---------- //
IDF idf = IDF.Instance;
idf.Commander = "אייל זמיר";

// הוספת יחידות תקיפה
idf.StrikeUnits.Add(f16);
idf.StrikeUnits.Add(hermes);
idf.StrikeUnits.Add(m109);

Console.WriteLine("===== צה\"ל =====");
Console.WriteLine($"הוקם: {idf.Established:dd/MM/yyyy}");
Console.WriteLine($"מפקד: {idf.Commander}");
Console.WriteLine("יחידות תקיפה:");
foreach (var unit in idf.StrikeUnits)
    Console.WriteLine("- " + unit);

// ---------- דוגמה לשימוש ב-Hamas (Singleton) ---------- //
Hamas hamas = Hamas.Instance;
hamas.Terrorists.Add(new Terrorist("אחמד", 1, new List<string> { "רובה", "סכין" }));
hamas.Terrorists.Add(new Terrorist("מוחמד", 2, new List<string> { "אקדח" }));

Console.WriteLine(hamas);
