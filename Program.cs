using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike;
using FirstStrike.Entities.StrikeUnits;

// ---------- בדיקת יחידות תקיפה ---------- //
F16FighterJet f16 = new F16FighterJet();
Console.WriteLine(f16);

Hermes460Drone hermes = new Hermes460Drone();
Console.WriteLine(hermes);

// ---------- בדיקת אנשים ---------- //
Terrorist moohamad = new Terrorist("moohamad", 3,[ "coll", "sakin"],true);
Console.WriteLine(moohamad);