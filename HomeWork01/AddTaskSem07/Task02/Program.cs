using System;
class Program
{
    /*
    * Двумерный массив размером 3х4 заполнен числами от 100 до 9999.
    * Найдите в этом массиве и сохраните в одномерный массив все числа,
    * сумма цифр которых больше их произведения. Выведите оба массива.
    */

    static int m = 3;
    static int n = 4;
    static void Main()
    {
        int[,] array = new int[m, n];
        array = FillArray(array);
        PrintTwoDimArray(array);

        Console.WriteLine();

        int[] result;
        result = SumDigitMoreProduct(array);
        PrintArray(result);
    }

    static int[,] FillArray(int[,] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.Next(100, 10000);
            }
        }
        return array;
    }

    static void PrintTwoDimArray(int[,] array)
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

    static int[] SumDigitMoreProduct(int[,] array)
    {
        string s = "";
        int count = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (DigitCheck(array[i, j]))
                {
                    count++;
                    s = s + array[i, j] + " ";
                }
            }
        }
        int[] result = s.Split(" ", count).Select(Int32.Parse).ToArray();
        return result;
    }

    static bool DigitCheck(int num)
    {
        int sum = 0;
        int product = 1;

        while (num > 0)
        {
            sum += num % 10;
            product *= num % 10;
            num /= 10;
        }
        if (sum > product) return true;
        return false;
    }

    static void PrintArray(int[] array)
    {
        int length = array.Length;
        Console.Write("[");
        for (int j = 0; j < length; j++)
        {
            Console.Write((j != length - 1) ? (array[j] + ", ") : (array[j] + "]"));
        }
        Console.WriteLine();
    }
}