/*
 * Student ID : 1690700065
 * Name       : Assignment01
 * Section    : 129c
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Assignment01
{
    internal class Program
    {
        // แสดงข้อความด้วยสีที่กำหนด
        static void WriteColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        // แสดงเส้นกรอบ
        static void PrintBorder(ConsoleColor color)
        {
            WriteColor("+====================================================================+\n", color);
        }

        // แสดงข้อความตรงกลางในกรอบ
        static void PrintCenter(string text, ConsoleColor color)
        {
            WriteColor("|", ConsoleColor.Magenta);
            WriteColor(text.PadLeft((68 + text.Length) / 2).PadRight(68), color);
            WriteColor("|\n", ConsoleColor.Magenta);
        }

        // แสดงบรรทัดข้อมูลตัวละคร
        static void PrintInfo(string label, string value, ConsoleColor valueColor)
        {
            WriteColor("| ", ConsoleColor.Magenta);
            WriteColor(label.PadRight(23), ConsoleColor.DarkMagenta);
            WriteColor(": ", ConsoleColor.Magenta);
            WriteColor(value.PadRight(41), valueColor);
            WriteColor("|\n", ConsoleColor.Magenta);
        }

        static void Main(string[] args)
        {
            // Character information
            const string gameTitle = "Road To Champion: Start At Academy";

            string characterName = "John Doe";
            string bloodType = "O+";
            double characterWeight = 59.5;     // kilograms
            bool femboy = true;
            char difficultyAffection = 'A';    // A = Easy, B = Medium, C = Hard
            float characterHeight = 1.75f;     // meters
            int characterAge = 25;
            string characterGender = "Male";

            // Convert weight
            int weightTruncated = (int)characterWeight;
            int weightRounded = Convert.ToInt32(characterWeight);

            // Console setting
            Console.Title = "Road To Champion - Character Card";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // Header
            Console.WriteLine();
            PrintBorder(ConsoleColor.Magenta);
            PrintCenter("<3  ROAD TO CHAMPION : CHARACTER CARD  <3", ConsoleColor.Cyan);
            PrintBorder(ConsoleColor.Magenta);

            PrintInfo("Game Title", gameTitle, ConsoleColor.White);

            WriteColor("|--------------------------------------------------------------------|\n", ConsoleColor.DarkCyan);
            PrintCenter("ACADEMY STUDENT ID", ConsoleColor.Yellow);
            WriteColor("|--------------------------------------------------------------------|\n", ConsoleColor.DarkCyan);

            // Character portrait placeholder
            PrintCenter("CHARACTER PORTRAIT", ConsoleColor.Yellow);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor("                    +--------------------------+                    ", ConsoleColor.DarkMagenta);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor("                    |                          |                    ", ConsoleColor.DarkMagenta);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor("                    |          (^_^)           |                    ", ConsoleColor.Cyan);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor("                    |         /  <3  \\         |                    ", ConsoleColor.Cyan);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor("                    |        /______\\        |                    ", ConsoleColor.Cyan);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor($"                    |  {characterName.PadRight(24)}|                    ", ConsoleColor.Yellow);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor("                    |                          |                    ", ConsoleColor.DarkMagenta);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|", ConsoleColor.Magenta);
            WriteColor("                    +--------------------------+                    ", ConsoleColor.DarkMagenta);
            WriteColor("|\n", ConsoleColor.Magenta);

            WriteColor("|--------------------------------------------------------------------|\n", ConsoleColor.DarkCyan);
            PrintCenter("CHARACTER INFORMATION", ConsoleColor.Cyan);
            WriteColor("|--------------------------------------------------------------------|\n", ConsoleColor.DarkCyan);

            // Character details
            PrintInfo("Name", characterName, ConsoleColor.White);
            PrintInfo("Gender", characterGender, ConsoleColor.White);
            PrintInfo("Age", characterAge.ToString(), ConsoleColor.White);
            PrintInfo("Blood Type", bloodType, ConsoleColor.Red);
            PrintInfo("Height", $"{characterHeight} m", ConsoleColor.White);
            PrintInfo("Weight", $"{characterWeight} kg", ConsoleColor.White);
            PrintInfo("Romance Route", femboy ? "Available <3" : "Locked", femboy ? ConsoleColor.Yellow : ConsoleColor.Red);

            WriteColor("|--------------------------------------------------------------------|\n", ConsoleColor.DarkCyan);
            PrintCenter("ROMANCE STATUS", ConsoleColor.Cyan);
            WriteColor("|--------------------------------------------------------------------|\n", ConsoleColor.DarkCyan);

            // Difficulty status
            string difficultyText;
            ConsoleColor difficultyColor;

            if (difficultyAffection == 'A')
            {
                difficultyText = "A - EASY <3";
                difficultyColor = ConsoleColor.Green;
            }
            else if (difficultyAffection == 'B')
            {
                difficultyText = "B - MEDIUM";
                difficultyColor = ConsoleColor.Yellow;
            }
            else
            {
                difficultyText = "C - HARD";
                difficultyColor = ConsoleColor.Red;
            }

            PrintInfo("Affection Difficulty", difficultyText, difficultyColor);
            PrintInfo("Affection Level", "[########--] 80%", ConsoleColor.Red);
            PrintInfo("Weight (Explicit Cast)", $"{weightTruncated} kg", ConsoleColor.White);
            PrintInfo("Weight (Rounded)", $"{weightRounded} kg", ConsoleColor.White);

            PrintBorder(ConsoleColor.Magenta);
            PrintCenter("STATUS : AVAILABLE FOR ROMANCE ROUTE  <3", ConsoleColor.Yellow);
            PrintBorder(ConsoleColor.Magenta);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}