using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        Random rnd = new Random();
        int length = rnd.Next( 20);
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(-20, 20);
            if (i % 2 == 1)
            {
                sum += array[i];
            }
        }
        PrintArray(array);
        Console.WriteLine($"Сумма элементов на на нечетных индексах = {sum}");
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