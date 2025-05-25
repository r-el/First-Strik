using System;
using System.Collections.Generic;

namespace FirstStrike.Interfaces
{
    public interface ITerrorOrganization
    {
        // תאריך הקמה
        DateTime Formed { get; }
        // מפקד נוכחי
        string Commander { get; }
        // רשימה של מחבלים
        List<Terrorist> Terrorists { get; }
    }
}
