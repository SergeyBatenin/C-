using System;
class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int degree = Convert.ToInt32(Console.ReadLine());
        
        // int result = (int)Math.Pow(number, degree);    //через класс Math
        // Console.WriteLine(result);

        int result = 1;
        for (int i = 0; i <degree; i++)     // Через математические действия
        {
            result = result * number;
        }
        Console.WriteLine(result);
    }
}