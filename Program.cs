// See https://aka.ms/new-console-template for more information
using FirstStrike.Entities;

Console.WriteLine("Hello, World!");

F16FighterJet f16 = new F16FighterJet();
Console.WriteLine($"Name: {f16.Name}");
Console.WriteLine($"Ammo: {f16.Ammo}");
Console.WriteLine($"Fuel: {f16.Fuel}");
Console.WriteLine($"Effective Against: {string.Join(", ", f16.EffectiveAgainst)}");

