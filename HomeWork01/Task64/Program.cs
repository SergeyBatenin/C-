using System;
class Program
{
    /*
    * Задайте значения M и N. Напишите программу, которая выведет
    * все натуральные числа кратные 3-ём в промежутке от M до N.
    */

    static void Main()
    {
        int m = 1;
        int n = 9;

        RecursiveSum(m, n);
        Console.WriteLine();
    }

    static void RecursiveSum(int m, int n)
    {
        if (m == n + 1) return ;      
        if (m % 3 == 0) Console.Write(m + " ");
        RecursiveSum(m + 1, n);
    }
}