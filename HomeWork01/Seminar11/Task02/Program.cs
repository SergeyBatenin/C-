using System;
class Program
{
    /*
    * Двумерный массив заполнен случайными натуральными числами от 1 до 10.
    * Найдите количество элементов, значение которых больше 5, и их сумму.
    */

    static void Main()
    {
        int[,] array = GenerateArray();
        PrintArray(array);
        (int, int) countAndSum = CountAndSum(array);
        Console.WriteLine($"Количество элементов больше 5 равно {countAndSum.Item1}, их сумма равна {countAndSum.Item2}");
    }

    static int[,] GenerateArray()
    {
        Random rnd = new Random();
        int[,] result = new int[rnd.Next(3, 10), rnd.Next(3, 10)];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {                
                result[i,j] = rnd.Next(1, 10);
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
    }

    static (int, int) CountAndSum(int[,] array)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] > 5)
                {
                    count++;
                    sum += array[i,j];
                }
            }
        }
        return (count, sum);
    }
}