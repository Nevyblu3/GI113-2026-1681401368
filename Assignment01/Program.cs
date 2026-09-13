using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            string gameTitle = "Honkai: Star Rail";

            var characterName = "Phainon";
            var characterTier = 'S';
            const string CharacterElement = "Physical";
            const string CharacterPaths = "Destruction";
            int characterHp = 3684;
            int characterAtk = 2785;
            int characterDef = 1574;
            int characterSpeed = 99;
            float critDmg = 205.0f;
            double critRate = 38.7;
            bool isPlayable = true;

            float characterAtkAsFloat = characterAtk;
            int critRateTruncated = (int)critRate;
            int critRateRounnded = Convert.ToInt32(critRate);

            gameTitle = "                         __              _          \r\n |_|  _  ._  |   _. o   (_ _|_  _. ._   |_)  _. o | \r\n | | (_) | | |< (_| |   __) |_ (_| |    | \\ (_| | | \r\n                                                    ";
            Console.WriteLine($"{gameTitle}");

            Console.WriteLine($"+-------------------------------------+");
            Console.WriteLine($"| ＣＨＡＲＡＣＴＥＲ   ＤＥＴＡＩＬＳ |");
            Console.WriteLine($"+-------------------------------------+");
            Console.WriteLine($"| ▸ 𝙽𝚊𝚖𝚎 : {characterName}                    |");
            Console.WriteLine($"| ▸ 𝚃𝚒𝚎𝚛 : {characterTier}                          |");
            Console.WriteLine($"| ▸ 𝙴𝚕𝚎𝚖𝚎𝚗𝚝 : {CharacterElement}                |");
            Console.WriteLine($"| ▸ 𝙿𝚊𝚝𝚑𝚜 : {CharacterPaths}               |");
            Console.WriteLine($"| ▸ 𝙷𝙿 : {characterHp}                         |");
            Console.WriteLine($"| ▸ 𝙰𝚃𝙺 : {characterAtk}                        |");
            Console.WriteLine($"| ▸ 𝙳𝙴𝙵 : {characterDef}                        |");
            Console.WriteLine($"| ▸ 𝚂𝚙𝚎𝚎𝚍 : {characterSpeed}                        |");
            Console.WriteLine($"| ▸ 𝙲𝚛𝚒𝚝 𝚁𝚊𝚝𝚎 : {critRate}                  |");
            Console.WriteLine($"| ▸ 𝙲𝚛𝚒𝚝 𝙳𝙼𝙶 : {critDmg}                    |");
            Console.WriteLine($"| ▸ 𝙿𝚕𝚊𝚢𝚊𝚋𝚕𝚎 : {isPlayable}                   |");
            Console.WriteLine($"|-------------------------------------|");
            Console.WriteLine($"|  +------------------------------+   |");
            Console.WriteLine($"|  |   ▼ 𝙼𝚘𝚛𝚎                     |   |");
            Console.WriteLine($"|  |------------------------------|   |");
            Console.WriteLine($"|  | ▸ 𝙰𝚃𝙺 (Float) : {characterAtkAsFloat}         |   | ");
            Console.WriteLine($"|  | ▸ Crit Rate (Truncated) : {critRateTruncated} |   |");
            Console.WriteLine($"|  | ▸ Crit Rate (Rounded) : {critRateRounnded}   |   |");
            Console.WriteLine($"|  +------------------------------+   |");
            Console.WriteLine($"+-------------------------------------+");

            // ไม่แน่ใจว่าสามารถใช้ insideWidth,PrintLine,border ได้เลยหรือเปล่า เลยเลือกใช้ Console.WriteLine และกด spacebar แทน


        }
    }
}
