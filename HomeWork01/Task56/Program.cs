using System;
class Program
{
    /*
    * Задайте прямоугольный двумерный массив. Напишите программу,
    * которая будет находить строку с наименьшей суммой элементов.
    */

    static int m, n;
    static void Main()
    {
        m = 4;
        n = 5;
        int[,] array = new int[m,n];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();

        Tuple<int, int> tuple = MinSumRow(array);
        int minSum = tuple.Item1;
        int row = tuple.Item2;
        Console.WriteLine($"Строка под индексом {row} имеет минимальную сумму равную {minSum}");

    }

    static Tuple<int, int> MinSumRow(int[,] array)
    {
        int minSum = int.MaxValue;
        int indexRow = -1;
        for (int i = 0; i < m; i++)
        {
            int sum = 0;

            for (int j = 0; j < n; j++)
            {
                sum += array[i,j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                indexRow = i;
            }
        }
        return Tuple.Create(minSum, indexRow);
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
                array[i, j] = rnd.Next(10);
            }
        }
    }
}
