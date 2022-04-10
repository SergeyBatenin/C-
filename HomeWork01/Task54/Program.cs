using System;
class Program
{
    /*
    * Задайте двумерный массив. Напишите программу, которая упорядочит
    *  по убыванию элементы каждой строки двумерного массива.
    */

    static int m, n;
    static void Main()
    {
        m = 4;
        n = 5;
        int[,] array = new int[m, n];
        FillArray(array);
        PrintArray(array);
        
        Console.WriteLine();
        Console.WriteLine("Отсортированный массив:");
        SortArray(array);
        PrintArray(array);
    }

    static void SortArray(int[,] array)
    {

        for (int row = 0; row < m; row++)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int max = array[row, i];
                int indexMax = -1;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[row, j] > max)
                    {
                        max = array[row,j];
                        indexMax = j;
                    }
                }
                if (array[row, i] < max)
                {
                    (array[row, i], array[row, indexMax]) = (array[row, indexMax], array[row, i]);
                }
            }
        }
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
    static void FillArray(int[,] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.Next(-50, 50);
            }
        }
    }
}