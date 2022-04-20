using System;
class Program
{
    /*
    * Даны натуральные числа a и b. Рекурсивно описать функцию возведения
    * числа a в степень b, используя только операцию инкрементирования (“++”)
    */

    // еще не добил =(( никак не выделю времени

    static void Main()
    {
        int a = 2;
        int b = 7;
        //Console.WriteLine(RecursivePow(a, b));
        RecursivePow(a,b,a);
    }

    static void RecursivePow(int num, int power,int number, int result = 0, int count = 1)
    {
        if (power == 0)
        {
            Console.WriteLine($"Число {num} в степени {power} равно = 1");
            return;
        }
        if (power == 1)
        {
            Console.WriteLine($"Число {num} в степени {power} равно = {num}");
            return;
        }
        if (count == power)
        {
            Console.WriteLine($"Число {num} в степени {power} равно = {number}");
            return;
        }

        int counterAdd = num * number;
        for (int i = 0; i < counterAdd; i++)
        {
            result++;            
        }        
        RecursivePow(num, power, result, 0, ++count);
    }
}
/*
We can calculate power by using repeated addition. 
For example to calculate 5^6. 
1) First 5 times add 5, we get 25. (5^2) 
2) Then 5 times add 25, we get 125. (5^3) 
3) Then 5 times add 125, we get 625 (5^4) 
4) Then 5 times add 625, we get 3125 (5^5) 
5) Then 5 times add 3125, we get 15625 (5^6)
*/
