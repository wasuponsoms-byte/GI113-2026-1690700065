/*
* Student ID : 1690700065
* Name       : Lab02
* Section    : 129c
* No.        : 12
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game titl,Subtitle
            Console.WriteLine("[=====DemonLord The Defender=====]");
            Console.WriteLine("DemonLord vs Hero Fight Damage calculator\n");

            //DemonLord stats input
            Console.Write("DemonLord HP : ");
            bool demonLordHpOk = int.TryParse(Console.ReadLine(), out int demonLordHp);
            Console.Write("DemonLord ATK : ");
            bool demonLordAtkOk = int.TryParse(Console.ReadLine(), out int demonLordAtk);
            Console.Write("DemonLord DEF : ");
            bool demonLordDefOk = int.TryParse(Console.ReadLine(), out int demonLordDef);
            //Hero stats input
            Console.Write("Hero HP : ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero ATK : ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero DEF : ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);
            //Input valiation
            bool isDemonLordInValid = demonLordHpOk && demonLordAtkOk && demonLordDefOk;
            bool isHeroInValid = heroHpOk && heroAtkOk && heroDefOk;
            Console.WriteLine($"\nDEMONLORD STATS VAILD : {isDemonLordInValid}");
            Console.WriteLine($"HERO STATS VAILD : {isHeroInValid}");

            Console.WriteLine($"[DEMONLORD]HP : {demonLordHp} ATK : {demonLordAtk} DEF : {demonLordDef}");
            Console.WriteLine($"[HERO] HP : {heroHp} ATK : {heroAtk} DEF : {heroDef}");

            //Compound assignment : +=
            int bloodstone = 20;
            demonLordHp += bloodstone;
            Console.WriteLine($"\nDemonLord use a bloodstone, restoring {bloodstone} HP , DemonLord HP now {demonLordHp}");
            //Blood missile + การโจมตีธรรมดา
            int normDmg = Math.Max(0, demonLordAtk - heroDef);
            Console.WriteLine($"\nNormal Attack would deal : {normDmg} DMG");
            //Blood Nuke การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, demonLordAtk * 2 - heroDef);
            Console.WriteLine($"\nNormal Attack would deal : {pwrDmg} DMG");
            //Random, Simple percent of critical chane.
            Random randomSometing = new Random();
            int roll = randomSometing.Next(1, 101);
            bool isCrit = roll <= 10;
            int critDmg = normDmg + Convert.ToInt32(isCrit) * normDmg;
            Console.WriteLine($"\nCritical hit roll : {roll} (Critical : {isCrit}");
            Console.WriteLine($"If critical, normal attack would attakk would intead deal: {critDmg}");
        }
    }
}
