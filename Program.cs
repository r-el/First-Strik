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
using FirstStrike.Utilities;

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
//Location locationMoohamad = new Location("home");
//List<IWeapons> listweapons = [new AK47()];
//Terrorist moohamad = new("moohamad",3, listweapons);

//IntelligenceMessages messag1 = new IntelligenceMessages(moohamad, locationMoohamad, DateTime.Now
//);
//Console.WriteLine(messag1);

//Aman aman = new();
//aman.AddIntelligenceMessages(messag1);
//Console.WriteLine(aman);

//// ---------- סוגי נשק חמאס ---------- //
//Knife k = new();
//Console.WriteLine(k);
//int _int = IntelligenceAnalyzer.GetTerroristSeverityLevel(moohamad);

//Console.WriteLine($"The Terrorist SeverityLevel is: {_int} ");
// ---------- יצירת מיקומים ----------
Location location1 = new("Tunnel");
Location location2 = new("Hideout");
Location location3 = new("Forest");
Location location4 = new("Border");

// ---------- יצירת נשקים ----------
List<IWeapons> weapons1 = new() { new AK47(), new Knife() };           // רמת חומרה בינונית
List<IWeapons> weapons2 = new() { new Gun() };                         // רמת חומרה גבוהה
List<IWeapons> weapons3 = new() { new Knife(), new M16() };    // חומרה מעורבת
List<IWeapons> weapons4 = new() { new M16(), new AK47() };     // חומרה גבוהה

// ---------- יצירת מחבלים ----------
Terrorist terrorist1 = new("Abu Khaled", 2, weapons1);  // דרגה נמוכה, נשק בינוני
Terrorist terrorist2 = new("Ziad", 4, weapons2);        // דרגה גבוהה, נשק בודד חזק
Terrorist terrorist3 = new("Yousef", 3, weapons3);      // דרגת ביניים, שילוב נשקים
Terrorist terrorist4 = new("Moohamad", 5, weapons4);    // דרגה גבוהה, שני כלי נשק מסוכנים

// ---------- יצירת מסרי מודיעין ----------
IntelligenceMessages msg1 = new(terrorist1, location1, DateTime.Now);
IntelligenceMessages msg2 = new(terrorist2, location2, DateTime.Now);
IntelligenceMessages msg3 = new(terrorist3, location3, DateTime.Now);
IntelligenceMessages msg4 = new(terrorist4, location4, DateTime.Now);

// ---------- הכנסת המידע ליחידת אמ"ן ----------
Aman aman = new();
aman.AddIntelligenceMessages(msg1);
aman.AddIntelligenceMessages(msg2);
aman.AddIntelligenceMessages(msg3);
aman.AddIntelligenceMessages(msg4);


// ---------- הדפסת כל ההודעות ----------
Console.WriteLine(msg1);
Console.WriteLine(msg2);
Console.WriteLine(msg3);
Console.WriteLine(msg4);

// ---------- הפעלת הניתוח ----------
Terrorist mostDangerous = IntelligenceAnalyzer.GetMostDangerousTerrorist(
    new List<Terrorist> { terrorist1, terrorist2, terrorist3, terrorist4 }
);

int severity = IntelligenceAnalyzer.GetTerroristSeverityLevel(mostDangerous);

Console.WriteLine($"Most Dangerous Terrorist: {mostDangerous.Name}");
Console.WriteLine($"Severity Level: {severity}");

IntelligenceMessages MostFeaturedTerrorist = IntelligenceAnalyzer.GetMostFeaturedTerrorist(
    new List<IntelligenceMessages> { msg1,msg2, msg2, msg3 }
);
Console.WriteLine($"Most Featured Terrorist: {MostFeaturedTerrorist.NameTerrorist}");

// ---------- סוגי נשק חמאס ---------- //
Knife k = new();
Console.WriteLine(k);

// ---------- הפעלת תפריט מפקד ---------- //
// CommanderConsole.Run();

