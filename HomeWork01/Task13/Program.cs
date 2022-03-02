using System;
class Program
{
    static void Main()
    {

        System.Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        PrintThirdDigit(number);

        void PrintThirdDigit(int num)
        {
            string str = Convert.ToString(num); //на сколько правильно будет считаться, что мы из строки конвертируем в число в начале кода,
            if (str.Length < 3)                 //А сейчас получается конвертируем обратно. Хотя запрашивать число и заносить в строку тоже не очень корректно
            {
                System.Console.WriteLine("В данном числе третьей цифры нет");
            }
            else
            {
                System.Console.WriteLine(str[2]);
            }
        }
    }
}