using System;
class Program
{
    /*
    * Задайте значения M и N. Напишите программу, которая найдёт
    * сумму натуральных элементов в промежутке от M до N.
    */

    static void Main()
    {
        int m = 4;
        int n = 8;

        Console.WriteLine($"Сумма элементов в диапазоне от {m} до {n} равна {RecursiveSum(m, n)}");
    }

    static int RecursiveSum(int m, int n)
    {
        if (m == n + 1) return 0;      
        
        return m + RecursiveSum(m + 1, n);
    }
}