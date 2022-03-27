using System;
class Program
{
    /*
    * Дан массив массивов, состоящих из натуральных чисел, размер которого 5. 
    * Для каждого элемента-массива определить найти сумму его элементов и 
    * вывести массив с наибольшей суммой. 
    * Если таких массивов несколько, вывести массив с наименьшим индексом.
    */
    static void Main()
    {
        int length = 5;
        int[][] array = new int[5][];
        int[] summary = new int[length];

        Random rnd = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = new int[length];
            Console.Write($"array[{i}] = ");
            int sum = 0;

            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = rnd.Next(10);
                sum += array[i][j];
                Console.Write($"{array[i][j]} ");
            }
            summary[i] = sum;
            Console.WriteLine();
        }

        int max = int.MinValue;
        int index = -1;
        for (int i = 0; i < length; i++)
        {
            if (summary[i] > max) 
            {
                max = summary[i];
                index = i;
            }
        }
        Console.WriteLine($"Максимальная сумма элементов находится в массиве под индексом {index} и равняется = {max}");


    }
}