using System;
class Program
{
    /*
    * Дано число n. Получите число, записанное в обратном порядке.
    */

    static void Main()
    {
        long number = 1234523563636537809;

        DateTime dt = DateTime.Now;
        Console.WriteLine(ReverseNumber(number));   // Время выполнения строкой 11мс
        Console.WriteLine(DateTime.Now.Millisecond - dt.Millisecond);

        dt = DateTime.Now;
        Console.WriteLine(ReverseNum(number));      // Время выполнения через математику 0мс =)
        Console.WriteLine(DateTime.Now.Millisecond - dt.Millisecond);
    }

    static string ReverseNumber(long num)
    {
        if (num == 0) return "";

        string s = "";
        s = s + num % 10;
        return s + ReverseNumber(num/10);
    }

    static long ReverseNum(long num, long reverse = 0)
    {
        if (num > 0)
        {
            return ReverseNum(num/10, (reverse * 10 + num % 10));
        }
        return reverse;
    }
}