using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int n = rnd.Next(2, 100);


        // Обплевался с этими двумерными массивами в Си Шарпе и с их длинами))
        // В данном варианте вывод в виде квадрата сделан
        /* В виде:
        1   2   3
        2   4   6
        3   6   9
                    Не знал в каком виде надо вывести */


        // int[,] array = new int[n,n];
        
        // for (int i = 0; i < array.GetLength(0); i++)
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {
        //         array[i,j] = (i + 1) * (j +1);
        //         Console.Write(array[i,j] + "\t");
        //     }
        //     Console.WriteLine();
        // }

        
        // Данный вариант выводит в том виде, как на тетрадках в клеточку
        // раньше на оборотной стороне была распечатана таблица умножения
        // Для удобства просмотра в одном "ряду" выводил сразу несколько чисел
        
        int i = 1;
        while (i <= n)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " * " + j + " = " + i*j + "\t" + 
                      (i +1) + " * " + j + " = " + (i +1) * j + "\t" + 
                      (i +2) + " * " + j + " = " + (i +2) * j);
            }
            Console.WriteLine();
            Console.WriteLine();
            i = i +3;
        }
    }
}