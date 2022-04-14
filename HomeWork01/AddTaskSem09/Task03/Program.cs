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
        int a = 5;
        int b = 3;
        //Console.WriteLine(RecursivePow(a, b));
        RecursivePow(a,b);
    }

    static void RecursivePow(int num, int power,int number = 0, int count = 1)
    {
        if (count == power) return;
        
        for (int i = 0; i < num; i++)
        {
            number = number + num;
        }
        Console.WriteLine(number);
        RecursivePow(num, power, number, ++count);
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
