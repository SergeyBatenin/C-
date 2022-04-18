using System;
class Program
{
    /*
    * Дано натульное число n > 1. Вывести все простые множители данного числа.
    * 10 >> 5, 2.
    * 12 >> 2, 2, 3.
    */

    static void Main()
    {
        int number = 100;
        Factorization(number);
    }

    static void Factorization(int number, int multiply = 2)
    {
        if (number < multiply) return;

        if (number % multiply == 0)
        {
            Console.WriteLine(multiply + " ");
            Factorization(number/multiply, multiply);
        }
        else Factorization(number, ++multiply);
    }
}