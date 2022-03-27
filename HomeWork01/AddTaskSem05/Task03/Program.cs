using System;
class Program
{
    /*
    * Найдите все числа от 1 до 1000000, сумма цифр которых 
    * в три раза меньше их произведений. Подсчитайте их количество.
    */
    static void Main()
    {
        int length = 1000000;
        int count = 0;
        for (int i = 1; i < length; i++)
        {
            if (CheckNumber(i))
            {
                count++;
                //Console.Write(i + " ");
            }
        }
        Console.WriteLine($"\nКоличество чисел сумма цифр, которого в 3 раза меньше их произведения равна {count}");
    }

    static bool CheckNumber(int num)
    {
        int sum = 0;
        int product = 1;
        while (num > 0)
        {
            sum = sum + num % 10;
            product = product * (num % 10);
            num /= 10;
        }
        if (sum * 3 == product) return true;
        return false;
    }
}