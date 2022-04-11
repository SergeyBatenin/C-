using System;
class Program
{
    /*
    * Найти минимальный по модулю элемент.
    * Удалить столбец и диагонали, содержащие его.
    */

    // Доделано!!

    static void Main()
    {
        int[,] array = new int[4, 5];
        FillArray(array);
        PrintArray(array);

        FindAndRemoveAbsMin(array);
    }

    static void FindAndRemoveAbsMin(int[,] array)
    {
        int min = int.MaxValue;
        int indexJ = -1;
        int indexI = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (Math.Abs(array[i, j]) < Math.Abs(min))
                {
                    min = array[i, j];
                    indexI = i;
                    indexJ = j;
                }
            }
        }

        if (
            (indexI == 0 || indexI == array.GetLength(0) - 1)   // Проверяем, чтобы минимальный элемент находился в первой или последней строке
            && (indexJ + array.GetLength(0) >= array.GetLength(1) && (indexJ - array.GetLength(0) < 0)) // А здесь проверяем чтобы по бокам диагоналей 
            )                                                                                           // не оставались незатронутые столбцы
        {
            Console.WriteLine($"Min element = {min}, his index [{indexI},{indexJ}]");

            int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            int indexRow = 0;
            int indexColumn = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == indexJ) continue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (i == Math.Abs(indexI - Math.Abs(j - indexJ))) continue;
                    result[indexRow, indexColumn] = array[i, j];
                    indexRow++;
                }
                indexColumn++;
                indexRow = 0;

            }
            PrintArray(result);
        }
        else
        {
            Console.WriteLine($"Min element = {min}, his index [{indexI},{indexJ}]");
            Console.WriteLine("Создать новый массив нельзя");
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