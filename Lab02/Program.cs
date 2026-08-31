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

            string character02Name = "Arkan";
            char arkanRank = 'A';
            int arkanHp = 1680;
            int arkanPower = 145;
            int arkanDefense = 175;
            float arkanSpeed = 60.5f;

            string character03Name = "Lilia";
            string liliaClass = "Support";
            int liliaHp = 950;
            int liliaPower = 10;
            int liliaMana = 1000;
            float liliaSpeed = 180.5f;

            string character04Name = "Veyron";
            int veyronHp = 2200;
            int veyronPower = 260;
            int veyronDefense = 150;
            float veyronSpeed = 100;
            bool isEnemy = true;

            Console.WriteLine("===== CHARACTERS STATUS: Elara =====");
            Console.WriteLine($"Name: {character01Name}");
            Console.WriteLine($"Rank: {elaraRank}");
            Console.WriteLine($"Hp: {elaraHp}");
            Console.WriteLine($"Magic Power: {elaraPower}");
            Console.WriteLine($"Speed: {elaraSpeed}");
            Console.WriteLine($"Crit Rate: {elara1Critrate}");
            Console.WriteLine();

            Console.WriteLine("===== CHARACTERS STATUS: Arkan =====");
            Console.WriteLine($"Name: {character02Name}");
            Console.WriteLine($"Rank: {arkanRank}");
            Console.WriteLine($"Hp: {arkanHp}");
            Console.WriteLine($"Attack Power: {arkanPower}");
            Console.WriteLine($"Defense Power: {arkanDefense}");
            Console.WriteLine($"Speed: {arkanSpeed}");
            Console.WriteLine();

            Console.WriteLine("===== CHARACTERS: Lilia =====");
            Console.WriteLine($"Name: {character03Name}");
            Console.WriteLine($"Hp: {liliaHp}");
            Console.WriteLine($"Magic Power: {liliaPower}");
            Console.WriteLine($"Mana: {liliaMana}");
            Console.WriteLine($"Speed: {liliaSpeed}");
            Console.WriteLine($"Class: {liliaClass}");
            Console.WriteLine();

            Console.WriteLine("===== CHARACTERS: Veyron =====");
            Console.WriteLine($"Hp: {veyronHp}");
            Console.WriteLine($"Attack Power: {veyronPower}");
            Console.WriteLine($"Defense Power: {veyronDefense}");
            Console.WriteLine($"Speed: {veyronSpeed}");
            Console.WriteLine($"Is Enemy : {isEnemy}");
        }


    }
    
}
