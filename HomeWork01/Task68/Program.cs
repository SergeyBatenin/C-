using System;
class Program
{
    

    /*
    * Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    * Даны два неотрицательных числа m и n ==> m = 3, n = 2 -> A(m,n) = 29
    */


    static void Main()
    {
        int a = 3;
        int b = 2;
        
        Console.WriteLine(Recursive(a, b));

    }

    static int Recursive(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return Recursive(m - 1, 1);

        return Recursive(m - 1, Recursive(m, n - 1));
    }
}