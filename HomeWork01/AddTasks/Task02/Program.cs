using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите день рождения");
        int bDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер месяца рождения");
        int mDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите год рождения");
        int yDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш возраст сейчас составляет: " + ResultAge(bDay, mDay, yDay));

        int ResultAge(int day, int month, int year)
        {
            int result = 2022 - year;
            if( month > 2 || (month == 2 && day > 1))
            {
                return result -1;
            }
            else
            {
                return result;
            }
        }
    }
}