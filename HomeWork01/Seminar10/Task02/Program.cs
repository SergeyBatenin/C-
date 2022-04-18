using System;
class Program
{
    /*
    * Дана монотонная последовательность, в которой
    * каждое натуральное число n встречается ровно
    * n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ...
    * Дано число m. Выведите первые m членов этой последовательности.
    * m = 5 >> 1, 2, 2, 3, 3
    */

    static void Main()
    {
        int m = 22;
        MonoSequence(m);
    }

    static void MonoSequence(int total, int start = 1, int count = 0, int countStart = 0)
    {
        if (total == count)
        {
            Console.WriteLine();
            return;
        }

        // Вариант 1
        // Для работы блока убрать из аргументов countStart
        // for (int i = 0; i < start; i++)
        // {
        //     Console.Write(start + " ");
        //     count++;
        // }
        // MonoSequence(total, ++start, count);


        // Вариант 2
        if (countStart < start)
        {
            Console.Write(start + " ");
            count++;
            countStart++;
        }
        else
        {
            start++;
            countStart = 0;
        }
        MonoSequence(total, start, count, countStart);
    }
}