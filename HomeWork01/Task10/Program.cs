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
            string s = "";      //  изменил немного код, чтобы на выходе мы все таки получались снова число
            while (num > 0)     //  а не строку
            {
                s = s + num % 10;
                num = num / 10;
            }

            int result = Convert.ToInt32(s);
            Console.WriteLine(result);
        }
    }
}
