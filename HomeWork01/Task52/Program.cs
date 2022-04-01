using System;
class Program
{
    /*
    * Задайте двумерный массив из целых чисел.
    * Найдите среднее арифметическое элементов в каждом столбце.
    */
    static int m = 4;
    static int n = 5;
    static void Main()
    {

        int[,] array = new int[m, n];
        array = FillArray(array);
        PrintArray(array);
        PrintAverageColumn(array);
    }

    static int[,] FillArray(int[,] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.Next(-10, 11);
            }
        }
        return array;
    }

    static void PrintArray(int[,] array)
    {   
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-----------------------------------");
    }

    static void PrintAverageColumn(int[,] array)
    {
        double average;

        for (int j = 0; j < n; j++)
        {
            average = 0;
            for (int i = 0; i < m; i++)
            {
                average +=array[i,j];
            }
            Console.Write(average / m + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------------");
    }
}