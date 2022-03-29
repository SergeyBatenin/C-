using System;
class Program
{
    /*
    * Напишите программу, которая найдёт точку пересечения двух прямых,
    * заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    * значения b1, k1, b2 и k2 задаются пользователем.
    */
    static void Main()
    {
        double b1 = 2;
        double k1 = 5;
        double b2 = 4;
        double k2 = 9;
        //double b1 = Convert.Todouble(Console.ReadLine());
        //double k1 = Convert.Todouble(Console.ReadLine());
        //double b2 = Convert.Todouble(Console.ReadLine());
        //double k2 = Convert.Todouble(Console.ReadLine());

        double x, y;

        if (k1 == k2)
        {
            if (b1 == b2)
            {
                Console.WriteLine("Прямые совпадают");
            }
            else
            {
                Console.WriteLine("Прямые параллельны");
            }
        }
        else
        {
            /*
            * исходя из условий составим равенство
            * k1 * x + b1 = k2 * x + b2    отсюда
            * k1 * x - k2 * x = b2 - b1
            * (k1 - k2) * x = b2 - b1
            * x = (b2 - b1) / (k1 - k2)
            */
            
            x = (b2 - b1) / (k1 - k2);

            // Соответственно, чтобы найти y подставляем 
            // значение х в одно из уравнений прямой

            y = k1 * x + b1;

            Console.WriteLine($" Прямые заданные данными уравнениями пересекаются в точке с координатами ({x}, {y})");
        }

    }
}