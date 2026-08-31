/*
 * Student ID : 1681401368
 * Name       : Phatnari Mangthes
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */


namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName} \nRank:{rank}\nLevel:{level}/{maxHp}\nHP:{currentHp}/{maxHp}" +
                $"\nAttack Power:{attackPower}\nCrit Multiplier:{critMultiplier}\nIs Boss:{isBoss}");

            Console.WriteLine("\n----Implicit Conversation : HP as double");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP(double):{currentHpDouble}");

            Console.WriteLine("\n---- Exact HP Percent (no integer truncation)----");
            double hpPercent = currentHpDouble*100/ maxHp;
            Console.WriteLine($"HP Percent (exact):{hpPercent}%");

            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast):{attackDisplay}");

            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
