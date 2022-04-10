using System;
class Program
{
    /*
    * Заполните двумерный массив 3х3 числами от 1 до 9 змейкой
    */

    static void Main()
    {
        int[,] array = new int[4, 5];
        FillArray(array);
        PrintArray(array);

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
        int value = 1;
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int j = 0; j < columns; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    array[i, j] = value++;
                }
            }
            else
            {
                for (int i = rows - 1; i >= 0; i--)
                {
                    array[i, j] = value++;
                }
            }
        }
    }
}