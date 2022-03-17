using System;
class Program
{
    static void Main()
    {
        
        int product = 1;
        int player = 2;
        
        while (true)
        {
            if (player == 2) player = 1;
            else player = 2;
            product = product * Player(player);
            if (CheckScore(product, player)) break;
        }


        bool CheckScore(int product, int player)
        {
            if (product >= 1000)
            {
                Console.WriteLine("Игрок №" + player + " победил. Ваш счет - " + product);
                return true;
            }
            else
            {
                Console.WriteLine("Текущее количество очков равно - " + product);
                Console.WriteLine();
                return false;
            }
        }

        int Player(int player)
        {
            Console.WriteLine("Игрок №" + player + " ваш ход");
            Console.WriteLine("Введите ваше число");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num < 2 || num > 9)
            {
                Console.WriteLine("Некорректный ввод");
                Console.WriteLine("Введите число от 2 до 9");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
    }
}