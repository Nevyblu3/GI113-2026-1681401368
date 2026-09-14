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

            Console.WriteLine($"[Hero] HP:{heroHp} ATK:{heroAtk} DEF:{heroDef}");
            Console.WriteLine($"[Monster] HP:{monHp} ATK:{monAtk} DEF:{monDef}");

          
            // before battle : Hero drink potion (compound assignment)
            int potionHeal = 10;
            //  แบบที่ 1 
            // heroHp = heroHp + potionHeal;
            //  แบบที่ 2
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drinks potion, healing {potionHeal} HP. Health is now {heroHp}");

            // Calculate damage norlmal attack (Arithmetic + Math.Max)
            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"\nNormal Damage dealt: {normalDamage} DMG");

            // Calculate power attack (Predence)
            int powerDamage = Math.Max(0, heroAtk * 2 - monDef); // ตามลำกับ * มาก่อน
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG"); 

            // Calculate Monster Attack
            int counterDamage = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Monster Counter Attack deal: {counterDamage} DMG");

            // Calculate Critical Chance (Random)
            Random rng = new Random();
            int roll = rng.Next(1, 101); // Generate a random number between 1 and 100
            bool isCritical = roll <= 20; // 20% chance for critical hit
            int critDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage; // โอกาส 20% ที่จะทำให้เกิด critical damage เลขได้ 1 ไม่ติด ได้ 0 ติด
            Console.WriteLine($"\nCritical Hit roll : {roll}% , Critical : {isCritical}");
            Console.WriteLine($"Normal Attack would deal {critDamage} DMG");


        }
    }
}
