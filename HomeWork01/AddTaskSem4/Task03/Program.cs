using System;
class Program
{
    /*
    * Массив на 100 элементов задаётся случайными числами от 1 до 99. 
    * Определите самый часто встречающийся элемент в массиве.
    * Если таких элементов несколько, вывести их все.
    */
    static void Main()
    {
        int[] array = new int[100];
        int length = array.Length;
        int[] copy = new int[length+1];
        Random rnd = new Random();

        // Генерация массива и подсчет всех элементов
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(1, 100);
            copy[array[i]]++;
        }

        // Поиск самого часто повторяющегося элемента
        int copyLength = copy.Length;
        int max = int.MinValue;
        int index = -1;        
        for (int i = 0; i < copyLength; i++)
        {
            if (copy[i] > max) 
            {
                max = copy[i];
                index = i;
            }
        }        
        PrintArray(copy);
        System.Console.WriteLine();
        PrintArray(array);

        Console.WriteLine($"Максимально часто встречается элемент со значением {index}. Количество повторений = {max}");
        
        
        // Не знал в каком виде лучше выводить повторные элементы при одинаковом повторении
        // Поэтому два варианта либо в одну строку как сейчас, либо закомментировать строки 45, 50, 54 
        // и расскоментировать строку 51 тогда каждый последующий элемент будет новой строкой
        string s = "";
        for (int i = index + 1; i < copyLength; i++)
        {
            if (copy[i] == max)
            {
                s = s + i + " ";
                //System.Console.WriteLine($"Элемент со значением {i} встречается также часто");
            }
        }
        if (s.Length > 0) Console.WriteLine($"Элементы со значением {s}встречались также часто");
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