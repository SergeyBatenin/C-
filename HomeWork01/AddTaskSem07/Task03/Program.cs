using System;
class Program
{
    /*
    * Двумерный массив размером 5х5 заполнен случайными нулями и единицами.
    * Игрок может ходить только по полям, заполненным единицами.
    * Проверьте, существует ли путь из точки [0, 0] в точку [4, 4] 
    * (эти поля требуется принудительно задать равными единице).
    */

    static int m = 5;
    static int n = 5;

    static void Main()
    {
        int[,] array = new int[m, n];
        FillArray(array);
        PrintArray(array);
        
        Console.WriteLine(FindPath(array, m - 1, n - 1));
    }

    static int[,] FillArray(int[,] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.Next(2);
            }
        }
        array[0, 0] = 1;
        array[array.GetLength(0)- 1, array.GetLength(1) - 1] = 1;
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
    }

    static bool FindPath(int[,] array, int i, int j)
    {
        if (i == 0 && j == 0)
        {
            return true;
        }
        array[i, j] = 0;

        if (i > 0 && array[i - 1, j] == 1)
        {
            bool result = FindPath(array, i - 1, j);
            if (result) return result;
        }

        if (j > 0 && array[i, j - 1] == 1)
        {
            bool result = FindPath(array, i, j - 1);
            if (result) return result;
        }

        if (i < array.GetLength(0) - 1 && array[i + 1, j] == 1)
        {
            bool result = FindPath(array, i + 1, j);
            if (result) return result;
        }

        if (j < array.GetLength(1) - 1 && array[i, j + 1] == 1)
        {
            bool result = FindPath(array, i, j + 1);
            if (result) return result;
        }

        return false;
    }
}