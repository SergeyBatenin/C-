using System;
class Program
{

    /*
    На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи

    Пример:
    341 = 101010101 (является)
    45 = 101101 (является)
    56 = 111000 (Не является)
    */

    static void Main()
    {
        int decNumder = Convert.ToInt32(Console.ReadLine());
        int binNumber = Convert.ToInt32(DecToBin(decNumder));
        Palindrom(binNumber);
    }
    static string DecToBin(int num)
    {
        string binNumber = "";
        if (num <= 0)
        {
            return binNumber;
        }

        while (num != 0)
        {
            binNumber = num % 2 + binNumber;
            num = num / 2;
        }
        return binNumber;
    }
    static void Palindrom(int num)
    {
        //считаем длину числа
        int count = 0;
        int temp = num;
        while (temp > 0)
        {
            temp = temp / 10;
            count++;
        }
        bool test = true; //флаг конечного результата

        for (int i = 0; i < count / 2; i++)
        {
            // Вычисляем цифры попарно и сравниваем их
            int startPow = (int)Math.Pow(10, (count - 1 - i));
            int startDigit = num / startPow % 10;
            int endPow = (int)Math.Pow(10, i);
            int endDigit = num / endPow % 10;

            if (startDigit != endDigit)
            {
                Console.WriteLine($"Число {num}  не является палиндромом");
                test = false;
                break;
            }

        }
        if (test == true) Console.WriteLine($"Число {num} является палиндромом");
    }
}