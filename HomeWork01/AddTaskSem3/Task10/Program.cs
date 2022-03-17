using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Первый игрок введите начальное число от 2 до 9");
        int num = Convert.ToInt32(Console.ReadLine());
        int product = num;
        Console.WriteLine("Текущее количество очков равно - " + product);
        Console.WriteLine();
        while (true)
        {
            product = product * SecondPlayer();
            if (product >= 1000)
            {
                Console.WriteLine("Второй игрок победил. Ваш счет - " + product);
                break;
            }
            else 
            {
                Console.WriteLine("Текущее количество очков равно - " + product);
                Console.WriteLine();
            }
            product = product * FirstPlayer();
            if (product >= 1000)
            {
                Console.WriteLine("Первый игрок победил. Ваш счет - " + product);
                break;
            }
            else
            {
                Console.WriteLine("Текущее количество очков равно - " + product);
                Console.WriteLine();
            }
        }



        int FirstPlayer()
        {
            Console.WriteLine("Первый игрок ваш ход");
            Console.WriteLine("Введите ваше число");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        int SecondPlayer()
        {
            Console.WriteLine("Второй игрок ваш ход");
            Console.WriteLine("Введите ваше число");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }
}