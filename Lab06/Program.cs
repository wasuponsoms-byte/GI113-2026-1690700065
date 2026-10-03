/*
 * Student ID : 1690700065
 * Name       : Your Name
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial Stats
            int dungeonEnergy = 100;
            int demonKingHp = 150;
            int heroPartyHp = 120;

            Console.WriteLine("=== DEMON LORD: DUNGEON DEFENSE ===");
            Console.WriteLine("A party of brave heroes has entered your Throne Room!");
            Console.WriteLine($"[Demon Lord HP: {demonKingHp}] | [Hero Party HP: {heroPartyHp}] | [Energy: {dungeonEnergy}]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("COMMAND MENU:");
            Console.WriteLine("[A] Summon Skeleton Horde (Area Damage)");
            Console.WriteLine("[B] Cast Dark Shield (Reduce Incoming Damage)");
            Console.WriteLine("[C] Channel Soul Drain (Steal HP from Heroes)");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Choose your defense command (A/B/C): ");

            // Read Input & Validate with char.TryParse
            bool validChar = char.TryParse(Console.ReadLine(), out char commandInput);

            // Convert character to uppercase for easy condition checking
            char command = char.ToUpper(commandInput);

            // Decision Logic using if / else if / else
            if (!validChar)
            {
                Console.WriteLine("Invalid command! You hesitated, and the Heroes struck you freely!");
            }
            else if (command == 'A')
            {
                // Branch 1: Summon Skeleton Horde สุดหล่อเท่
                int damageDealt = 35;
                heroPartyHp -= damageDealt;
                Console.WriteLine($"You summoned a horde of skeletons! Dealt {damageDealt} damage to the Hero Party.");
                Console.WriteLine($"Hero Party HP is now {Math.Max(0, heroPartyHp)}.");
            }
            else if (command == 'B')
            {
                // Branch 2: Cast Dark Shield หนาๆ
                int heroAttack = 25;
                int reducedDamage = heroAttack / 2;
                demonKingHp -= reducedDamage;
                Console.WriteLine($"You raised a Dark Shield! Took reduced damage ({reducedDamage}) from the Hero Party.");
                Console.WriteLine($"Demon Lord HP is now {demonKingHp}.");
            }
            else if (command == 'C')
            {
                // Branch 3: Channel Soul Drain ดูดเลือดจ๊วบๆ
                int drainedHp = 20;
                heroPartyHp -= drainedHp;
                demonKingHp += drainedHp;
                Console.WriteLine($"You channeled Soul Drain! Drained {drainedHp} HP from the Heroes and restored your health.");
                Console.WriteLine($"Demon Lord HP: {demonKingHp} | Hero Party HP: {Math.Max(0, heroPartyHp)}.");
            }
            else
            {
                // Branch 4: Invalid Menu Choice
                Console.WriteLine($"Unknown command '{commandInput}'. Please order your minions with A, B, or C only!");
            }
        }
    }
}