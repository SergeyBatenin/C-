using System;
class Program
{
    /*
    * Задан массив из случайных цифр на 15 элементов. 
    * На вход подаётся трёхзначное натуральное число. 
    * Напишите программу, которая определяет, есть в массиве 
    * последовательность из трёх элементов, совпадающая с введённым числом.
    */
    static void Main()
    {
        int length = 10;
        int[] array = new int[length];
        Random rnd = new Random();

        // Вариант решения через математику

        int number = Convert.ToInt32(Console.ReadLine());
        int numberLength = LengthNumber(number);
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(10);
        }
        PrintArray(array);
        int count = 0;
        bool flag = false;
        for (int i = 0; i < length; i++)
        {

            int digit = (int)(number / Math.Pow(10, numberLength - 1 - count)) % 10;
            if (array[i] == digit) count++;
            else count = 0;

            if (count == numberLength)
            {
                flag = true;
                break;
            }
        }
        if (flag) Console.WriteLine("Yes");
        else Console.WriteLine("No");



        // Вариант Решения через строку

        // string s = "";
        // string num = Console.ReadLine();
        // for (int i = 0; i < length; i++)
        // {
        //     array[i] = rnd.Next(10);
        //     s = s + (array[i].ToString());
        // }
        // PrintArray(array);
        // Console.WriteLine(s);
        // if (s.IndexOf(num) < 0) Console.WriteLine("Нет");
        // else Console.WriteLine("Да");

    }
    static int LengthNumber(int num)
    {
        int length = 0;
        while (num > 0)
        {
            num /= 10;
            length++;
        }
        return length;
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