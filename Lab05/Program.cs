namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("==== BATTLE MAGE ====");
            Console.WriteLine("Hero vs. Mosters -- Fight Calculator");

            // user input of hero stats
            Console.Write("Hero Health: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            // user input of monster stats
            Console.Write("Monster Health: ");
            bool isMonHp = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool isMonAtk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool isMonDef = int.TryParse(Console.ReadLine(), out int monDef);

            // check if all stats are valid
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonValid = isMonHp && isMonAtk && isMonDef;
            Console.WriteLine($"Stats Valid: Hero={allHeroValid}");
            Console.WriteLine($"Stats Valid: Monster={allMonValid}");

            // Display hero and monster stats
            Console.WriteLine($"\n>>[Hero] HP:{heroHp} ATK:{heroAtk} DEF:{heroDef}");
            Console.WriteLine($">>[Monster] HP:{monHp} ATK:{monAtk} DEF:{monDef}");

            int monsterMaxHp = monHp;

            // before battle : Hero drink potion (compound assignment)
            int potionHeal = 8;
            //  แบบที่ 1 
            // heroHp = heroHp + potionHeal;
            //  แบบที่ 2
            heroHp += potionHeal;
            Console.WriteLine($"\n>>[Hero drinks potion], healing {potionHeal} HP. Health is now {heroHp}");

            // Damage preview 1: Calculate normal attack (Arithmetic + Math.Max)
            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"\nNormal Attack would deal:: {normalDamage} DMG");

            // Damage preview 2: Calculate power attack (Predence)
            int powerDamage = Math.Max(0, heroAtk * 2 - monDef); // ตามลำกับ * มาก่อน
            Console.WriteLine($"Power Attack would deal: {powerDamage} DMG"); 

            // Damage preview 3: Calculate Monster Attack back
            int counterDamage = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Monster Counter afterward would deal: {counterDamage} DMG");

            // Calculate Critical Chance (Random)
            Random rng = new Random(14);
            int roll = rng.Next(1, 101); // Generate a random number between 1 and 100
            bool isCritical = roll <= 50; // 50% chance for critical hit
            int critDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage; // โอกาส 50% ที่จะทำให้เกิด critical damage เลขได้ 1 ไม่ติด ได้ 0 ติด
            Console.WriteLine($"\nCritical Hit roll : {roll}, Critical : {isCritical}");
            Console.WriteLine($"If critical,Normal Attack would deal {critDamage} DMG");

            // สรุปรายงานสอดแนม (comparison + logical operators)
            bool heroHitsHarder = heroAtk > monAtk;
            bool canOneShotWithNormal = normalDamage >= monHp;
            bool monsterCanOneShotHero = counterDamage >= heroHp;
            bool safeTrade = normalDamage > counterDamage && !monsterCanOneShotHero;
            bool luckyOrLethal = isCritical || canOneShotWithNormal;
            Console.WriteLine($"Hero hits harder than Monster: {heroHitsHarder}");
            Console.WriteLine($"Normal Attack can defeat Monster in one hit: {canOneShotWithNormal}");
            Console.WriteLine($"Monster could defeat Hero in one hit back: {monsterCanOneShotHero}");
            Console.WriteLine($"This is a safe trade for Hero: {safeTrade}");
            Console.WriteLine($"This attack is lucky or lethal: {luckyOrLethal}");

            // Hero commits to the Normal Attack (compound assignment: -=)
            monHp -= normalDamage;
            Console.WriteLine($"\n>>[Hero attacks]! Monster HP: {monHp}/{monsterMaxHp}");

            // Result + reward
            bool monsterDefeated = monHp <= 0;
            int goldEarned = (monsterMaxHp - monHp) * 2;
            Console.WriteLine($"\n>>[Monster defeated] : {monsterDefeated}");
            Console.WriteLine($">>[Gold earned] : {goldEarned}");

        }
    }
}
