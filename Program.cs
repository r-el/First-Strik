using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike;
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