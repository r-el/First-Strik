using System;
using System.Text;

namespace FirstStrike.Entities
{
    // Handles all user interaction and menu logic for the simulation
    public static class CommanderConsole
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                PrintMenu();
                string input = ReadMenuSelectionFromConsole();
                HandleMenuSelection(int.Parse(input));
                ContinuePrompt();
            }
        }

        private static string ReadMenuSelectionFromConsole()
        {
            string input;
            while (!IsValidMenuOption(input = Console.ReadLine() ?? ""))
            {
            PrintError("בחירה לא חוקית, נסה שוב. (Invalid choice, try again.)");
            Console.Write("בחר פעולה (Select option): ");
            }
            return input;
        }

        private static void PrintMenu()
        {
            var sb = new StringBuilder();
            sb.AppendLine("╔════════════════════════════════════════════════════════════════╗");
            sb.AppendLine("║                  IDF OPERATION: FIRST STRIKE                   ║");
            sb.AppendLine("╠════════════════════════════════════════════════════════════════╣");
            sb.AppendLine("║  ברוך הבא לעמדת מפקד התקיפות של צה\"ל                           ║");
            sb.AppendLine("║  Welcome to the IDF Commander Console                          ║");
            sb.AppendLine("╠════════════════════════════════════════════════════════════════╣");
            sb.AppendLine("║  1. ניתוח מודיעין (Intel Analysis)                             ║");
            sb.AppendLine("║  2. זמינות יחידות תקיפה (Strike Availability)                  ║");
            sb.AppendLine("║  3. דירוג מטרות (Target Prioritization)                        ║");
            sb.AppendLine("║  4. ביצוע תקיפה (Strike Execution)                             ║");
            sb.AppendLine("║  0. יציאה (Exit)                                               ║");
            sb.AppendLine("╚════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(sb.ToString());
            Console.ResetColor();
            Console.Write("\nבחר פעולה (Select option): ");
        }
        private static void HandleMenuSelection(int input)
        {
            switch (input)
            {
                case 1:
                    PrintSection("[ניתוח מודיעין - טרם מומש]", ConsoleColor.Green);
                    break;
                case 2:
                    PrintSection("[זמינות יחידות תקיפה - טרם מומש]", ConsoleColor.Green);
                    break;
                case 3:
                    PrintSection("[דירוג מטרות - טרם מומש]", ConsoleColor.Green);
                    break;
                case 4:
                    PrintSection("[ביצוע תקיפה - טרם מומש]", ConsoleColor.Green);
                    break;
                case 0:
                    PrintSection("להתראות! (Goodbye!)", ConsoleColor.Red);
                    Environment.Exit(0);
                    break;
                default:
                    PrintError("בחירה לא חוקית, נסה שוב. (Invalid choice, try again.)");
                    break;
            }
        }

        /* בדוק האם מחרוזת תואמת לאחד מהאפשרויות בתפריט (0-4) */
        private static bool IsValidMenuOption(string menuOption) =>
            int.TryParse(menuOption, out int val) && val >= 0 && val <= 4;
        private static void PrintSection(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void PrintError(string message)
        {
            PrintSection(message, ConsoleColor.Red);
        }
        private static void ContinuePrompt()
        {
            Console.WriteLine("\nלחץ על מקש כלשהו להמשך...");
            Console.ReadKey();
        }

    }
}
