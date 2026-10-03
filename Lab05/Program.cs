/*
* Student ID : 1690700065
* Name       : Lab02
* Section    : 129c
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game titl,Subtitle
            Console.WriteLine("[=====Starship Warfare=====]");
            Console.WriteLine("Starship Mercury vs Starship Neptrun Fight Damage calculator\n");

            //Mercury stats input
            Console.Write("Mecury HP : ");
            bool mercuryHpOk = int.TryParse(Console.ReadLine(), out int mercuryHp);
            Console.Write("Mecury ATK : ");
            bool mercuryAtkOk = int.TryParse(Console.ReadLine(), out int mercuryAtk);
            Console.Write("Mecury DEF : ");
            bool mercuryDefOk = int.TryParse(Console.ReadLine(), out int mercuryDef);
            //Neptrun stats input
            Console.Write("Neptrun HP : ");
            bool neptrunHpOk = int.TryParse(Console.ReadLine(), out int neptrunHp);
            Console.Write("Neptrun ATK : ");
            bool neptrunAtkOk = int.TryParse(Console.ReadLine(), out int neptrunAtk);
            Console.Write("Neptrun DEF : ");
            bool neptrunDefOk = int.TryParse(Console.ReadLine(), out int neptrunDef);
            //Input valiation
            bool isMercuryInValid = mercuryHpOk && mercuryAtkOk && mercuryDefOk;
            bool isNeptrunInValid = neptrunHpOk && neptrunAtkOk && neptrunDefOk;
            Console.WriteLine($"\nMERCURY STATS VAILD : {isMercuryInValid}");
            Console.WriteLine($"NEPTRUN STATS VAILD : {isNeptrunInValid}");

            Console.WriteLine($"[MERCURY]      HP : {mercuryHp} ATK : {mercuryAtk} DEF : {mercuryDef}");
            Console.WriteLine($"[NEPTRUN]      HP : {neptrunHp} ATK : {neptrunAtk} DEF : {neptrunDef}");

            //Compound assignment : +=
            int repairKit = 20;
            mercuryHp += repairKit;
            Console.WriteLine($"\nMercury use a repairkit, repaoring {repairKit} HP , StarshipMercury HP now {mercuryHp}");
            //Aritmetic + การโจมตีธรรมดา
            int normDmg = Math.Max(0, mercuryAtk - neptrunDef);
            Console.WriteLine($"\nNormal Attack would deal : {normDmg} DMG");
            //Precedence การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, mercuryAtk * 2 - neptrunDef);
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
