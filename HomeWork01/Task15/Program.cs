using System;
class Task15
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели");
        int day = Convert.ToInt32(Console.ReadLine());
        CheckWeekend(day);

        void CheckWeekend(int day)
        {
            if (day % 6 == 0)
            {
                Console.WriteLine("Да здравствует СУББОТА!");
            }
            else if (day % 7 == 0)
            {
                Console.WriteLine("Сегодня воскресенье, но помните завтра на работу=(");
            }
            else 
            Console.WriteLine("Работай негр солнце еще высоко, а выходные далеко)))");
        }

    }
}