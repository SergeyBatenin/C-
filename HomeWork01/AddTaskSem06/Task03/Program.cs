using System;
using System.Diagnostics;
class Program
{
    /*
    * Дано число N. Используя рекурсию, определите,
    *  что оно является степенью числа M
    */
    static void Main()
    {
        double n = Convert.ToDouble(Console.ReadLine());
        int degree = Convert.ToInt32(Console.ReadLine());

        if (PowThree(n, degree)) Console.WriteLine("Число является степенью тройки");
        else Console.WriteLine("Число НЕ является степенью тройки");
    }
    
    static bool PowThree(double n, int degree)
    {
        if (n == degree) return true;
        else if (n > degree) return PowThree(n / degree, degree);
        else return false;
    }
}