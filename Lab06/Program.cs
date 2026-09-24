using System.Runtime.CompilerServices;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1 - if
            //int lives = 0    ;

            //if (lives <= 0) // ในวงเล็บ ต้องมีค่าเป็น boolean , ใช้ <= จะชัวร์กว่า
            //{
            //    Console.WriteLine("Game Over!");
            //}
            //Console.WriteLine("Continue Running!");

            //// 2 - if else
            //int coins = 80 ;
            //int price = 100;

            //if (coins >= 0)
            //{
            //    Console.WriteLine("Purchased!");
            //}
            //else // จะเขียน else ได้ต้องมี if ก่อน แต่ไม่จำเป็นต้องเขียนเงื่อนไข(เพราะว่าเขียนไปตรง if แล้วไง)
            //{
            //    Console.WriteLine("Not enough coins.");
            //}

            //// 3 - else if มากกว่า 2 เงื่อนไข
            //int score = 75;

            //if (score >= 90) // เช็คลำดับ 1 เท็จ = ไม่รัน
            //{
            //    Console.WriteLine("Rank S");
            //}
            //else if (score >= 60) // เช็คอันดับที่ 2 จริงก็รัน เท็จก็ไม่รัน ไปเช็คอันล่างต่อ
            //{
            //    Console.WriteLine("Rank A");
            //}
            //else // เป็นในกรณีที่ไม่ตรงกับทั้งสองอันด้านบนเลยอันนี้จะรัน แต่ถ้าข้างบนรันแล้วอันนี้จะไม่รัน
            //{ 
            //    Console.WriteLine("Rank D");
            //}

            //// 4 - else if แบบซ้อน
            //bool hasKey = true;
            //Console.Write("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if ( !ok || level < 1 || level > 99 ) // กันผู้เล่นพิมพ์ 0 , 100 ,อย่างอื่นที่ไม่ใช่ตัวเลข (ใส่ผิด) || อันแรกมักจะเขียนกันข้อผิดพลาด
            //{
            //    Console.WriteLine("Invalid level.");
            //}  
            //else if (level >= 10 && hasKey) //ใส่เงื่อนไขกุญแจเพิ่ม
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5)
            //{
            //    Console.WriteLine("The door opens.");
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut");
            //}

            //// 5 - nested if การซ้อน if แบบไม่จำกัด เช่น การซื้อของเหรียญพอไหม สล็อตกระเป๋าพอไหม
            //coins = 150;
            //price = 100;
            //int bagSlots = 0;

            int heroHp = 75;
            int heroAtk = 35;
            int heroDef = 20;
            int monsterHp = 40;
            int monsterAtk = 30;
            int potionHeal = 10;

            Console.WriteLine("====>> Adventure of Brian <<====\n");

            Console.WriteLine("+________________________+");
            Console.WriteLine("|     Current Status     |");
            Console.WriteLine($"| Hero HP: {heroHp}            |");
            Console.WriteLine($"| Hero ATK: {heroAtk}           |");
            Console.WriteLine($"| Hero DEF: {heroDef}           |");
            Console.WriteLine("+________________________+\n");

            Console.WriteLine("==== Monsters Encounter 1 ====");

            Console.WriteLine("Action 1 : ATTACK");
            Console.WriteLine("Action 2 : DEFEND");
            Console.WriteLine("Action 3 : HEAL\n");

            Console.Write("Choose your action(1-3): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputValid || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, Please choose between 1-3");
            }

            if (choice == 1) // ATTACK
            {
                monsterHp -= heroAtk;
                Console.WriteLine($"You attacked the monster! \n >> Monster HP: {monsterHp}");
            }
            else if (choice == 2) // DEFEND
            {
                monsterAtk -= heroDef;
                heroHp -= monsterAtk;
                Console.WriteLine($"You defended against the monster's attack! \n >> Monster attack you {monsterAtk} damage! \n >> Hero HP: {heroHp}");
            }
            else if (choice == 3) // HEAL
            {
                heroHp += potionHeal;
                Console.WriteLine($"You healed yourself! \n >> Hero HP: {heroHp}");
            }
            else
            {
                Console.WriteLine("TIME OUT! you ran out of time.");
            }
        }
         
    }
}
