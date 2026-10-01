/*
 * Student ID : 1681401368
 * Name       : Phatnari Mangthes
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const string Material = "Crystal";
            const double SmeltRate = 0.3;
            const double SalvageRate = 0.5;
            const int MaxBatch = 200;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Welcome to the Forge          |");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($" ▶︎ 💎 {Material} ");
            Console.WriteLine($"Smelting Rate : {SmeltRate} / Salvage Rate : {SalvageRate}\n");
            Console.WriteLine(" ▶︎ Menu ");
            Console.WriteLine("🔥 - Key [S] for Smelt    (Ore -> Ingot)");
            Console.WriteLine("🔨 - Key [B] for Salvage  (Ingot -> Ore)\n");

            Console.Write(" => Select menu: ");
            bool inputValid = char.TryParse(Console.ReadLine(), out char menu);

            Console.Write(" => How much would you like (1-200): ");
            bool amountValid = double.TryParse(Console.ReadLine(), out double amount);
        }
    }
}
