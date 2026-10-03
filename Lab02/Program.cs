    /*
* Student ID : 1690700065
* Name       : Lab02
* Section    : 129c
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/  
   

    namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"{bossName} takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            string adventurerName1 = "Aiden";
            char heroRank1 = 'A';
            int vitality1 = 250;
            float physicalAttack1 = 55.5f;
            double magicAttack1 = 5.25;
            bool alive1 = true;

            string adventurerName2 = "Galu";
            char heroRank2 = 'B';
            int vitality2 = 100;
            float physicalAttack2 = 10.5f;
            double magicAttack2 = 25.5;
            bool alive2 = true;

            string adventurerName3 = "Aiden";
            char heroRank3 = 'A';
            int vitality3 = 300;
            float physicalAttack3 = 20.5f;
            double magicAttack3 = 8.25;
            bool alive3 = true;

            string adventurerName4 = "Aiden";
            char heroRank4 = 'A';
            int vitality4 = 120;
            float physicalAttack4 = 12.5f;
            double magicAttack4 = 30.25;
            bool alive4 = true;

            Console.WriteLine("====== ADVENTURER 1 ======");
            Console.WriteLine($"NAME : {adventurerName1}");
            Console.WriteLine($"HERO RANK : {heroRank1}");
            Console.WriteLine($"VITALITY : {vitality1}");
            Console.WriteLine($"PHYSICAL ATTACK : {physicalAttack1}");
            Console.WriteLine($"MAGIC ATTACK : {magicAttack1}");
            Console.WriteLine($"ALIVE : {alive1}");

            Console.WriteLine("====== ADVENTURER 2 ======");
            Console.WriteLine($"NAME : {adventurerName2}");
            Console.WriteLine($"HERO RANK : {heroRank2}");
            Console.WriteLine($"VITALITY : {vitality2}");
            Console.WriteLine($"PHYSICAL ATTACK : {physicalAttack2}");
            Console.WriteLine($"MAGIC ATTACK : {magicAttack2}");
            Console.WriteLine($"ALIVE : {alive2}");

            Console.WriteLine("====== ADVENTURER 3 ======");
            Console.WriteLine($"NAME : {adventurerName3}");
            Console.WriteLine($"HERO RANK : {heroRank3}");
            Console.WriteLine($"VITALITY : {vitality3}");
            Console.WriteLine($"PHYSICAL ATTACK : {physicalAttack3}");
            Console.WriteLine($"MAGIC ATTACK : {magicAttack3}");
            Console.WriteLine($"ALIVE : {alive3}");

            Console.WriteLine("====== ADVENTURER 4 ======");
            Console.WriteLine($"NAME : {adventurerName4}");
            Console.WriteLine($"HERO RANK : {heroRank4}");
            Console.WriteLine($"VITALITY : {vitality4}");
            Console.WriteLine($"PHYSICAL ATTACK : {physicalAttack4}");
            Console.WriteLine($"MAGIC ATTACK : {magicAttack4}");
            Console.WriteLine($"ALIVE : {alive4}");
            

          

        }
    }
}
