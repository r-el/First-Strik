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
using FirstStrike.Interfaces;
using FirstStrike.Utilities;

// 🇮🇱 IDF Operation - First Strike 🇮🇱
Console.WriteLine("🇮🇱 IDF Operation - First Strike 🇮🇱");
Console.WriteLine("=====================================\n");

// Initialize and run simulation
var (idf, hamas, aman) = InitializeEntities();
aman = InitializeRandomData(idf, hamas, aman);
DisplayFinalResults(idf, hamas, aman);

// ==================== METHODS ====================

/// <summary>
/// Initialize core military entities (IDF, Hamas, Aman)
/// </summary>
static (IDF idf, Hamas hamas, Aman aman) InitializeEntities()
{
    IDF idf = IDF.Instance;
    idf.Commander = "אייל זמיר";

    Hamas hamas = Hamas.Instance;
    Aman aman = new();

    return (idf, hamas, aman);
}

/// <summary>
/// Initialize all entities with random generated data
/// </summary>
static Aman InitializeRandomData(IDF idf, Hamas hamas, Aman aman)
{
    Console.WriteLine("===== Initializing System Data =====\n");

    // Generate random terrorists
    List<Terrorist> terrorists = DataInitializer.GenerateRandomTerrorists(8);
    hamas.Terrorists.Clear();
    hamas.Terrorists.AddRange(terrorists);

    // Initialize IDF strike units
    List<IStrikeUnit> strikeUnits = DataInitializer.InitIDFStrikeUnits();
    idf.StrikeUnits.Clear();
    idf.StrikeUnits.AddRange(strikeUnits.Cast<IStrikeUnit>());

    // Generate intelligence messages
    Aman newAman = new(); // Create fresh Aman instance
    List<IntelligenceMessages> intelMessages = DataInitializer.GenerateRandomIntelligenceMessages(terrorists, 15);
    foreach (IntelligenceMessages msg in intelMessages)
        newAman.AddIntelligenceMessages(msg);

    Console.WriteLine("✅ System data initialized successfully!\n");
    return newAman;
}

/// <summary>
/// Display concise system results
/// </summary>
static void DisplayFinalResults(IDF idf, Hamas hamas, Aman aman)
{
    Console.WriteLine("===== System Status =====\n");
    
    // Show brief Hamas summary
    Console.WriteLine($"📊 Hamas: {hamas.Terrorists.Count} terrorists detected");
    Console.WriteLine($"🎯 Intelligence: {aman.ListIntelligence.Count} reports collected\n");
    
    // Show detailed intelligence summary
    DisplayAman(aman);
}

/// <summary>
/// Display Aman summary (limited to 5 reports)
/// </summary>
static void DisplayAman(Aman aman)
{
    Console.WriteLine("===== אמ\"ן Intelligence Summary =====");
    Console.WriteLine(aman);
    Console.WriteLine();
}