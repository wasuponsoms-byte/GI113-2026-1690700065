/*
* Student ID : 1690700065
* Name       : Lab03
* Section    : 129c
* No.        : 12
* Course     : GI113 Computer Programming (GI)
*/   
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name : {bossName}" +
                $"\nRank : {rank}" +
                $"\nLevel : {level} / {MaxLevel}" +
                $"\nHP : {currentHp} / {maxHp}" +
                $"\nAttack Power : {attackPower}" +
                $"\nCritMultiplier : {critMultiplier}" +
                $"\nIs Boss : {isBoss}");
            //Implicit Convertion int (HP) -->> double
            Console.WriteLine("\n------ Implicit Convertion : HP as double ------");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double) : {currentHpDouble}");

            // Calculate Percentage
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            //Explicit float (attackPower) -->> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            // Cast vs. convert double (critMultiplier) -->> int
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (int convert rounded): {critConvert}");

        }
    }
}
