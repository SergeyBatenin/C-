using System;
class Program
{
    static void Main()
    {

        System.Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        PrintThirdDigit(number);

        // Вариант 1 работаем со строкой (как вариант в основном методе Main переменную "number" можно считывать строкой не переводя в число)
        
        // void PrintThirdDigit(int num)
        // {
        //     string str = Convert.ToString(num); //на сколько правильно будет считаться, что мы из строки конвертируем в число в начале кода,
        //     if (str.Length < 3)                 //А сейчас получается конвертируем обратно. Хотя запрашивать число и заносить в строку тоже не очень корректно
        //     {
        //         System.Console.WriteLine("В данном числе третьей цифры нет");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine(str[2]);
        //     }
        // }

        // Вариант 2 большую часть работаем с числом
        void PrintThirdDigit(int num)
        {
            if (num > 99) // То есть будет трехзначным минимум
            {
                string s = Convert.ToString(num);
                Console.WriteLine(s[2]);
            }
            else
            {
                Console.WriteLine("В данном числе нет третьей цифры");
            }

            // В принципе все тело метода можно записать тернарным оператором))
            // Console.WriteLine(num > 99?num.ToString()[2]:"В данном числе нет третьей цифры");
        }
    }
}