using System;
class Program
{
    /*
    * Дана последовательность натуральных чисел.
    * Определите значение второго по величине элемента в этой последовательности.
    *  {1, 2, 3, 4, 5} >> 4
    *  {7, 4, 2, 7, 6, 6, 8} >> 7
    */
    static void Main()
    {
        //string sequence = Console.ReadLine()?? "0";  
        string sequence = "7, 4, 2, 9, 6, 6, 8";
        int[] array = StringToArray(sequence);
        PrintArray(array);
        Console.WriteLine($"Вариант №1\nВторой по величине элемент равен {FindSecondMax(array)}\n");
        
        Array.Sort(array);
        PrintArray(array);
        Console.WriteLine();
        Console.WriteLine($"Вариант №2\nВторой по величине элемент в последовательности равен {array[array.Length-2]}");
    }

    static int[] StringToArray(string inputData)
    {
        int[] result = inputData.Replace(',', ' ')
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(Int32.Parse)
                                .ToArray();
        return result;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
    }

    static int FindSecondMax(int[] array)
    {
        int length = array.Length;
        if (length == 0) return -1;
        int max = array[0];
        int secondMax = array[0];

        for (int i = 1; i < length; i++)
        {
            if (array[i] >= max)
            {
                secondMax = max;
                max = array[i];
            }
            else if (array[i] > secondMax) secondMax = array[i];
        }

        return secondMax;
    }
}