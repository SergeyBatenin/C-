using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int count = 0;
        int length = rnd.Next(20);
        
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(100, 1000);
            if (array[i] % 2 == 0) count++;
        }
        
        PrintArray(array);
        Console.WriteLine($"Количество четных элементов в массиве = {count}");
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();
    }
}