using System;
class Program
{
    /*
    * Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    * Напишите программу, которая построчно выведет элементы и их индексы
    */

    static void Main()
    {
        int[,,] array = new int[3, 4, 5];
        FillArray(array);
        PrintArray(array);
    }

    static void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.WriteLine($"Элемент массива под индексом [{i},{j},{k}] равен {array[i, j,k]}");
                }
            }
        }
        Console.WriteLine("-----------------------------------");
    }
    static void FillArray(int[,,] array)
    {
        int value = 10;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = value++;
                }
            }
        }
    }
}