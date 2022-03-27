using System;
class Program
{
    /*
    * На вход подаются два числа случайной длины. 
    * Найдите произведение каждого разряда первого числа 
    * на каждый разряд второго. Ответ запишите в массив.
    */
    static void Main()
    {
        // Чтобы охватить больше вариантов решения, я совместил два в одном))
        // одно число принимаю и считаю, как число
        // второе, как строку
        int firstNum = Convert.ToInt32(Console.ReadLine());
        string secondNum = Console.ReadLine();
        int firstLength = LengthNumber(firstNum);
        int secondLength = secondNum.Length;        

        int arrIndex = 0;
        int[] array = new int[firstLength * secondLength];

        // Долго думал как связать индексы чисел и массива
        // Но пока, кроме такого костыля ничего не придумал
        Console.WriteLine(firstLength + ", " + secondLength);

        for (int i = 0; i < firstLength; i++)
        {
            for ( int j = 0; j < secondLength; j++)
            {
                // как оказалось с числом работать даже проще
                // так как при работе со строкой значение цифры 
                // бралось в виде числа из таблицы ASCII
                int first = (firstNum / (int)Math.Pow(10, firstLength - 1 - i)) % 10;
                int second = (int)Char.GetNumericValue(secondNum, j);
                Console.WriteLine(first + " - " + secondNum[j]);
                array[arrIndex] = first * second;
                arrIndex++;
            }
        }

        PrintArray(array);
    }

    static int LengthNumber(int num)
    {
        int length = 0;
        while ( num > 0)
        {
            num /= 10;
            length++;
        }
        return length;
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();
    }
}