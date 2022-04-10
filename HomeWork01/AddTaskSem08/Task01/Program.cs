using System;
class Program
{
    /*
    * Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали.
    * А элементы последней строки, элементами побочной диагонали.
    */

    static int m = 4, n = 4;

    static void Main()
    {
        int[,] array = new int[m, n];
        FillArray(array);
        PrintArray(array);

        ChangeRows(array);
        PrintArray(array);        
    }

    static void ChangeRows(int[,] array)
    {
        int maxJ = (m < n ? m : n);

        for (int j = 1; j < maxJ; j++)
        {
            if (j == m - 1)
            {
                (array[0, j], array[m - 1, j]) = (array[m - 1, j], array[0, j]);
            }
            else
            {
            array[0, j] = array[j,j];
            array[m - 1, j] = array[m - 1 - j,j];
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
        int value = 1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = value++;
            }
        }
    }
}