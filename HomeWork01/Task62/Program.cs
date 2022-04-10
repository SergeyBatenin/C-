using System;
class Program
{
    /*
    * Заполните спирально массив 4 на 4 числами от 1 до 16.
    */

    static void Main()
    {
        int rows = 5;
        int columns = 5;
        int total = rows * columns;
        int value = 1;
        int[,] array = new int[rows, columns];
        int i = 0;
        int j = 0;

        while (value != total + 1)
        {
            while (j < columns && array[i,j] == 0)
            {
                array[i,j] = value++;
                j++;
            }
            i++;j--;

            while (i < rows && array[i,j] == 0)
            {
                array[i,j] = value++;
                i++;
            }
            i--;j--;

            while (j >=0 && array[i,j] == 0)
            {
                array[i,j] = value++;
                j--;
            }
            i--;j++;

            while (i >= 0 && array[i,j] == 0)
            {
                array[i,j] = value++;
                i--;
            }
            i++;j++;
        }
        
        

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
}