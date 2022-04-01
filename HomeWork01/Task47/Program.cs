using System;
class Program
{
    /*
    * Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    */
    static void Main()
    {
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] array = new double[m,n];
        array = FillArray(array);
        PrintArray(array);
    }

    static double[,] FillArray(double[,] array)
    {
        Random rnd = new Random();
        int k;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                k = rnd.Next(2);
                if (k == 0) array[i, j] = rnd.NextDouble() * (-10);
                else array[i, j] = rnd.NextDouble() * 10;
            }
        }
        return array;
    }

    static void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0:#.####}\t\t", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}