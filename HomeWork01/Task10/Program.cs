using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное число"); // Хотя будет работать с числом любой длины
        int number = Convert.ToInt32(Console.ReadLine());
        ReverseNumber(number);

        void ReverseNumber(int num)
        {
            while (num > 0)
            {
                Console.Write(num%10);
                num = num /10;
            }

            Console.WriteLine();
        }
    }
}
