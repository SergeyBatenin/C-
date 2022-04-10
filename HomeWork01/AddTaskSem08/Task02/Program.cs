using System;
class Program
{
    /*
    * Дан двумерный массив, заполненный случайными числами от -9 до 9.
    * Подсчитать частоту вхождения каждого числа в массив, используя словарь.
    */

    static void Main()
    {
        int[,] array = new int[4, 4];
        FillArray(array);
        PrintArray(array);

        Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
        frequencyDictionary = FrequencyDict(array);
        PrintDictionary(frequencyDictionary);
    }

    static Dictionary<int, int> FrequencyDict(int[,] array)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (!dict.ContainsKey(array[i,j]))
                {
                    dict.Add(array[i,j], 1);
                }
                else
                {
                    dict[array[i,j]]++;
                }
            }
        }
        return dict;
    }

    static void PrintDictionary(Dictionary<int, int> dictionary)
    {
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Элемент \"{pair.Key}\" встречается {pair.Value} раз(а)" );
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
                array[i, j] = rnd.Next(-9, 10);
            }
        }
    }
}