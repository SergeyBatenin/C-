using System;
class Program
{
    /*
    *  Даны две матрицы, количество строк и столбцов которых может быть 3 или 4,
    * заполнены числами от -9 до 9. Выполните умножение матриц.
    */

    static void Main()
    {
        int[,] first = FillArray(5, 3);     // Размеры матриц можно менять, проверка сделана в методе
        int[,] second = FillArray(3, 4);    // Должно работать при любых размерах матриц

        PrintArray(first);
        Console.WriteLine();
        PrintArray(second);
        Console.WriteLine();

        int[,] product = ProductMatrix(first, second);
        PrintArray(product);
    }

    static int[,] FillArray(int row, int column)
    {
        int[,] array = new int[row, column];
        Random rnd = new Random();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = rnd.Next(-9, 10);
            }
        }
        return array;
    }

    static int[,] ProductMatrix(int[,] first, int[,] second)
    {
        int firstRow = first.GetLength(0);
        int firstColumn = first.GetLength(1);
        int secondRow = second.GetLength(0);
        int secondColumn = second.GetLength(1);

        if (firstColumn == secondRow)
        {
            int[,] result = new int[firstRow, secondColumn];

            for (int i = 0; i < firstRow; i++)
            {
                for (int j = 0; j < secondColumn; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < firstColumn; k++)
                    {
                        result[i, j] = result[i, j] + first[i, k] * second[k, j];
                    }
                }
            }

            return result;
        }
        else
        {
            int[,] result = new int[0, 0];
            Console.WriteLine("Данные матрицы перемножить нельзя");
            return result;
        }
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
}