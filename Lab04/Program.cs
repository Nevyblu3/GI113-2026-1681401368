/*
 * Student ID : 1681401368
 * Name       : Phatnari Mangthes
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("===== NEW ADVENTURE =====");
            //Console.Write("Name your hero:"); // write พิมพ์ต่อ,writeline เว้นบรรทัด
            //string playerName = Console.ReadLine(); 
            //Console.WriteLine($"\nWelcome, {playerName}. Your journey begins...");

            //Console.WriteLine("________________________");
            //Console.WriteLine("Choose Difficulty (1-3)");

            //int difficulty = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($">Difficulty set to :  {difficulty}");

            Console.WriteLine("+________________________+");
            Console.WriteLine("|   CHARACTER CREATION   |");
            Console.WriteLine("+________________________+");
            Console.Write("Name your character:");
            string characterName = Console.ReadLine();
            Console.Write("Choose a class (1-3):");
            bool classValid = int.TryParse(Console.ReadLine(), out int classNumber); // tryparse to chech the input 
            Console.Write("Starting luck (0.0 - 10.0):");
            bool luckValid = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($">>{characterName} the Class {classNumber} adventurer enters the dungeon. Luck : {luck}!");

            Console.WriteLine("+________________________+");
            Console.WriteLine("|        ITEM SHOP       |");
            Console.WriteLine("+________________________+");
            Console.Write("How many potions?  ");
            bool quantityValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($">>Valid input:{quantityValid}");
            Console.WriteLine($">>Quantity:{quantity}");

            Console.WriteLine("+________________________+");
            Console.WriteLine("|       SET VOLUME       |");
            Console.WriteLine("+________________________+");
            Console.Write("Set volume (0.0 - 1.0):");
            bool volumeValid = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($">>Valid input:{volumeValid}");
            Console.WriteLine($">>Volume set to: {volume}");

        }
    }
}
