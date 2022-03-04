using System;
class Program
{
    static void Main()
    {
        //Без заданных значений переменным a, b, c ругается компилятор=)

        int a = 3, b = 4, c = 5;
        if (CheckTriangle(a, b, c))
        {
            CheckIsoTriangle(a, b, c);
        }
        else
        {
            Console.WriteLine("Треугольника с такими сторонами не существует");
        }


        bool CheckTriangle(int x, int y, int z)
        {
            //проверка - существует ли такой треугольник вообще
            bool result = x + y > z && x + z > y && y + z > x;
            
            // if (x + y > z && x + z > y && y + z > x)
            // {
            //     result = true;
            // }
            // else
            // {
            //     result = false;
            // }

            return result;
        }


        void CheckIsoTriangle(int x, int y, int z)
        {
            //Треугольник считается равнобедренным
            //если хотя бы 2 стороны равны
            if (x == y || x == z || y == z)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник НЕ является равнобедренным");
            }
        }
    }
}