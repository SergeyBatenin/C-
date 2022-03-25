using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int length = rnd.Next(5, 20);
        double min = int.MaxValue;
        double max = int.MinValue;

        double[] array = new double[length];
        for (int i = 0; i < length; i++)
        {
            // Стало неприятной неожиданностью, что nextDouble() генерируется только от 0 до 1))
            // поэтому пришлось исхитриться, чтобы отрицательные числа тоже генерировались))
            // Если есть какой то вариант попроще, буду рад наводке в какую сторону копнуть надо))
            int k = rnd.Next(2);    
            if (k == 0) array[i] = rnd.NextDouble() * 10.0;
            else array[i] = rnd.NextDouble() * (-10.0);

            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }
        
        PrintArray(array);
        Console.WriteLine($"Разница между максимальным {max} и минимальным {min} значениями элементов массива = {max-min}");
    }
    static void PrintArray(double[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();
    }
}