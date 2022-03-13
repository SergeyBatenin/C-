using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координату Х точки А");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату У точки А");
        double y = Convert.ToInt32(Console.ReadLine());

        double alfa = Math.Atan2(y, x) * 180 / Math.PI;

        if (alfa == 90)
            Console.WriteLine("Отрезок перпендикулярен к оси Х");
        else if (alfa == 0)
            Console.WriteLine("Отрезок АО совпадает с осью Х");
        else if (alfa < 90)
            Console.WriteLine("Наименьший угол отрезка АО к оси Х равен = " + alfa + " градуса/-ов");
        else
            Console.WriteLine("Наименьший угол отрезка АО к оси Х равен " + (180 - alfa) + " градуса/-ов");
    }
}