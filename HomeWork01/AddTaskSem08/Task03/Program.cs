using System;
class Program
{
    /*
    * Найти минимальный по модулю элемент.
    * Удалить столбец и диагонали, содержащие его.
    */

    // Еще не доделана!!!

    static void Main()
    {
        int[,] array = new int[4, 4];
        FillArray(array);
        PrintArray(array);

        int[,] result = FindAndRemoveAbsMin(array);
        //PrintArray(result);
    }

    static int[,] FindAndRemoveAbsMin(int[,] array)
    {
        int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

        int min = int.MaxValue;
        int indexJ = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (Math.Abs(array[i,j]) < Math.Abs(min))
                {
                    min = array[i,j];
                    indexJ = j;
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
                array[i, j] = rnd.Next(-20, 20);
            }
        }
    }
}