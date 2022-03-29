using System;
class Program
{
    /*
    * Пользователь вводит с клавиатуры M чисел. 
    * Посчитайте, сколько чисел больше 0 ввёл пользователь.
    */
    static void Main()
    {
        int total = 7;
        //int total = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < total; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) count++;
        }
        Console.WriteLine($"Пользователь ввел {count} чисел больше 0");
    }
}