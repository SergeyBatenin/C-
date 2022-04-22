using System;
class Program
{
    /*
    * Даны два числа a, b. Сложите их, используя
    * только операции инкремента и декремента.
    */

    // Если я правильно понял условие, то вроде так))
    static void Main()
    {
        int firstNumber = -4;
        int secondNumber = 5;
        
        int sum = SumTwoNumbers(firstNumber, secondNumber);

        Console.WriteLine(sum);
    }

    static int SumTwoNumbers(int first, int second)
    {
        if (second > 0)
        {
            while( second > 0)
            {
                first++;
                second--;
            }
        }
        else
        {
            while (second < 0)
            {
                first--;
                second++;
            }
        }

        return first;
    }
}