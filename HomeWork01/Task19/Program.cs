using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Palindrom(number);

        /*
        Через массив или строки решение, конечно, было бы намного лаконичнее,
        но раз уж говорят, что массивы и строки вычисляются дольше
        и что если есть возможность работать с числом , то надо работать
        с числом, пришлось заморочиться немного =)
        */

        void Palindrom(int num)
        {
            //считаем длину числа
            int count = 0;
            int temp = num;
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }
            bool test = true; //флаг конечного результата

            for (int i = 0; i < count / 2; i++)
            {
                // Вычисляем цифры попарно и сравниваем их
                int startPow = (int)Math.Pow(10, (count - 1 - i));
                int startDigit = num / startPow % 10;
                int endPow = (int)Math.Pow(10, i);
                int endDigit = num / endPow % 10;

                if (startDigit != endDigit)
                {
                    Console.WriteLine("Данное число не является палиндромом");
                    test = false;
                    break;
                }

            }
            if (test == true) Console.WriteLine("Данное число является палиндромом");

        }
    }
}
