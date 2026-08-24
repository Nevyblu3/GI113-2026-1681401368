/*
 * Student ID : 1681401368
 * Name       : Phatnari Mangthes
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */


using System.Xml.Linq;

namespace Lab02
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
            Console.WriteLine($"Name : {bossName}");
            Console.WriteLine($"Rank : {rank}");
            Console.WriteLine($"Level : {level}");
            Console.WriteLine($"HP : {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power : {attackPower}");
            Console.WriteLine($"Crit Multiplier : {critMultiplier}");
            Console.WriteLine($"Is Boss : {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent:{hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damange!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP : {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent:{hpPercent}%");

            string character01Name = "Elara";
            char elaraRank = 'S';
            int elaraHp = 820;
            int elaraPower = 185;
            float elaraSpeed = 90.5f;
            double elara1Critrate = 20.75;

            Console.WriteLine("===== CHARACTERS STATUS: INITAL =====");
            Console.WriteLine($"Name: {character01Name}");
            Console.WriteLine($"Rank: {elaraRank}");
            Console.WriteLine($"Hp: {elaraHp}");
        }


    }
    
}
