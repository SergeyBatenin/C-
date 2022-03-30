using System;
class Program
{
    /*
    * Написать перевод десятичного числа в двоичное, используя рекурсию.
    */
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(DecToBin(number));
    }

    static string DecToBin(int n)
    {   
        if (n == 0) return "";
        if (n == 1) return "1";
        //string result = n % 2 + "";
        //result = n % 2 + result;          
        
        return DecToBin(n/2) + n % 2 + "";
    }
}