using System;
class Program
{
    /*
    * Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    * и возвращает значение этого элемента или же указание, что такого элемента нет
    */
    static int m = 4;
    static int n = 5;

    static void Main()
    {
        Console.Write("Введите номер строки в массиве:  ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца в массиве: ");
        int column = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        int[,] array = new int[m,n];
        array = FillArray(array);
        PrintArray(array);
        if(CheckIndex(row, column)) Console.WriteLine($"Значение элемента в массиве с индексом [{row},{column}] равно {array[row,column]}");
        else Console.WriteLine("В массиве нет элемента с таким индексом");
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
    }

    static bool CheckIndex(int i, int j)
    {
        if ((i >= 0 && i < m) && (j >= 0 && j < n)) return true;
        return false;
    }
}