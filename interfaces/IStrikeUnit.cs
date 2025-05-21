namespace FirstStrike.Interfaces
{
    /* אפשרות תקיפה */
    public interface IStrikeUnit
    {
        string Name { get; } // שם יחודי
        int Ammo { get; }    // קיבולת תחמושת (מספר תקיפות שנותרו)
        double Fuel { get; } // אספקת דלק
        string[] EffectiveAgainst { get; }   // סוג המטרה שהם יעילים נגדה (למשל, בניינים, אנשים, כלי רכב)
    }
}