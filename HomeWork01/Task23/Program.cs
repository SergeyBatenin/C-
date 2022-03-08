using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите границу диапазона");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(n + " -> ");
        CubeNumbers (n);

        void CubeNumbers( int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(Math.Pow(i, 3) + " ");
            }
            Console.WriteLine();
        }
    }
}