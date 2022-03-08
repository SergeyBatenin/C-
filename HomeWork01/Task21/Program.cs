using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты для первой точки в трехмерном пространстве: X, Y, Z");
        double xA = Convert.ToDouble(Console.ReadLine());
        double yA = Convert.ToDouble(Console.ReadLine());
        double zA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты для второй точки в трехмерном пространстве: X, Y, Z");
        double xB = Convert.ToDouble(Console.ReadLine());
        double yB = Convert.ToDouble(Console.ReadLine());
        double zB = Convert.ToDouble(Console.ReadLine());;

        Console.WriteLine(DistanceBetweenPoints(xA, yA, zA, xB, yB, zB));

        double DistanceBetweenPoints (double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double result;
            result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow(z2 - z1, 2));
            return result;
        }
    }
}