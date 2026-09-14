namespace Program.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===> BATTLE MAGE <===");
            Console.WriteLine("Hero vs. Monster -- Fight Calculator ");

            //User input for hero stats
            Console.WriteLine("Hero Health: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            //User input of monster stats
            Console.WriteLine("Monster Health: ");
            bool isMonsterHp = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("Monster Attack: ");
            bool isMonsterAtk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("Monster Defense: ");
            bool isMonsterDef = int.TryParse(Console.ReadLine(), out int monsterDef);

            //Check if player input is valid
            bool allHeroStatsValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonsterStatsValid = isMonsterHp && isMonsterAtk && isMonsterDef;
            Console.WriteLine($"stats Validation: Hero ;{allHeroStatsValid}, Monster: {allMonsterStatsValid}");
            Console.WriteLine($"Hero Stats: HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"Monster Stats: HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");

            // Before fighting: Hero drink a Pottion (compound Assignment)
            int potionHeal = 8;
            heroHp += potionHeal;
            Console.WriteLine($"Hero drinks a potion and heals {potionHeal} HP. New Hero HP: {heroHp}");

            int normaldamage = Math.Max(0, heroAtk - monsterDef);
            Console.WriteLine($"Normal Attack deal: {normaldamage} DMG");

            // calculate Power attack (Predence of Operators)
            int powerAttackDamage = Math.Max(0, heroAtk - monsterDef);
            Console.WriteLine($"Power Attack deals: {powerAttackDamage} DMG");

            // calculate Monster Attack
            int counterAttackDamage = Math.Max(0, monsterAtk - heroDef);
            Console.WriteLine($"Monster Counter Attack deals: {counterAttackDamage} DMG");

            // calculate critical chance (Ternary Operator)
            Random rng = new Random();
            int roll = rng.Next(1, 101);
            bool isCriticalHit = roll <= 10; // 10% chance for critical hit
            int criDamage = normaldamage + Convert.ToInt32(isCriticalHit) * normaldamage;
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCriticalHit})");
            Console.WriteLine($"Critical Attack deals: {criDamage} DMG");







        }
    }
}
