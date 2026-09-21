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

        }
    }
}
