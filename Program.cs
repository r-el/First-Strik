using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike;
using FirstStrike.Entities.Aman;
using FirstStrike.Entities.StrikeUnits;

// ---------- בדיקת יחידות תקיפה ---------- //
F16FighterJet f16 = new F16FighterJet();
Console.WriteLine($"Name: {f16.Name}");
Console.WriteLine($"Ammo: {f16.Ammo}");
Console.WriteLine($"Fuel: {f16.Fuel}");
Console.WriteLine($"Effective Against: {string.Join(", ", f16.EffectiveAgainst)}");

// ---------- בדיקת אנשים ---------- //
Terrorist moohamad = new Terrorist("moohamad", 3,[ "coll", "sakin"],true);
Console.WriteLine(moohamad);
// ---------- בדיקת אנשים ---------- //
List<string> weapons = new List<string> { "coll", "sakin" };
Terrorist moohamad2 = new Terrorist("moohamad", 3, weapons, true);
Console.WriteLine(moohamad);

Location locationMoohamad = new Location("home");

IntelligenceMessages messag1 = new IntelligenceMessages(moohamad, locationMoohamad, DateTime.Now
);
Console.WriteLine(messag1);

Aman aman = new();
aman.AddIntelligenceMessages(messag1);
Console.WriteLine(aman);
