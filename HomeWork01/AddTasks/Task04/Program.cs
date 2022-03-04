using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main()
    {
        // Не стал изменять код, засекал время выполнения программы при работе
        // со строкой(массивом) или работе с числами. Даже для лонга время
        // выполнения оказалось одинаковым

        var watch = Stopwatch.StartNew();
        long number = 5647326474768613296;
        //Console.WriteLine("Введите число");
        //int number = Convert.ToInt32(Console.ReadLine());
        ValueLeftDigit(number);
        watch.Stop();
        Console.WriteLine("time elapsed: " + watch.ElapsedMilliseconds + " ms");


        //Option  1
        void ValueLeftDigit(long num)
        {
            string s = Convert.ToString(num);
            int maxIndex = -1;
            int minIndex = -1;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > max)
                {
                    max = s[i];
                    maxIndex = i;
                }
                else if (s[i] < min)
                {
                    min = s[i];
                    minIndex = i;
                }
            }
            if (maxIndex > minIndex)
            {
                Console.WriteLine("У числа " + num + " левее находится минимальная цифра");
            }
            else
            {
                Console.WriteLine("У числа " + num + " левее находится максимальная цифра");
            }
        }

        // Option 2
        // void ValueLeftDigit(long num)
        // {
        //     int i = 0;
        //     long nums = num;
        //     int maxIndex = -1;
        //     int minIndex = -1;
        //     long max = int.MinValue;
        //     long min = int.MaxValue;
        //     while (nums > 0)
        //     {
        //         long temp = nums % 10;
        //         if (temp > max)
        //         {
        //             max = temp;
        //             maxIndex = i;
        //         }
        //         if (temp < min)
        //         {
        //             min = temp;
        //             minIndex = i;
        //         }
        //         nums = nums / 10;
        //         i++;
        //     }     
        //     if (maxIndex > minIndex)
        //     {
        //         Console.WriteLine("У числа " + num + " левее находится максимальная цифра");
        //     }
        //     else
        //     {
        //         Console.WriteLine("У числа " + num + " левее находится минимальная цифра");
        //     }
        // }
    }
}

