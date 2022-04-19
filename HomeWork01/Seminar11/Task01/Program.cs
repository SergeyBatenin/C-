using System;
class Program
{

    /*
    * На вход подуются два числа n и m, такие, что n<m.
    * Заполните массив случайными числами из промежутка [n, m].
    */

    static void Main()
    {
        int n = 3;
        int m = 10;
        int[] array = GenerateArray(n, m);
        PrintArray(array);
    }

    static int[] GenerateArray(int n, int m)
    {
        Random rnd = new Random();
        int[] result = new int[rnd.Next(n, m)];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = rnd.Next(n, m + 1);
        }
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
}