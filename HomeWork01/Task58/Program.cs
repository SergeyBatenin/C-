using System;
class Program
{
    /*
    *  Задайте две матрицы. Напишите программу,
    * которая будет находить произведение двух матриц.
    */

    static int m,n,c,d;
    static void Main()
    {
        m = 2;
        n = 3;
        c = 3;
        d = 2;
        int[,] first = new int[m,n];
        int[,] second = new int[c,d];
        FillArray(first);
        FillArray(second);
        PrintArray(first);
        System.Console.WriteLine();
        PrintArray(second);
        System.Console.WriteLine();

        // if (n != c) Console.WriteLine("Найти произведение данных матриц невозможно");
        // else result = ProductMatrix(first, second);

        int[,] result = ProductMatrix(first, second);
        PrintArray(result);

    }

    static int[,] ProductMatrix(int[,] first, int[,] second)
    {
        int[,] result = new int[m,d];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < d; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    result[i,j] = result[i,j] + first[i,k] * second[k,j];
                }
            }
        }
        return result;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
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
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(1,10);
            }
        }
    }
}