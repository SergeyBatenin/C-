using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму депозита");
        double deposit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите срок хранения в месяцах");
        double month = Convert.ToDouble(Console.ReadLine());
        double ratio = 1.015;
        Console.WriteLine("Через " + month + " месяца/-ев Вы получите: " + CalculationDeposit(deposit, month, ratio));

        double CalculationDeposit(double depo, double month, double k)
        {
            for (int i = 0; i < month; i++)
            {
                depo = depo * k;
            }
            return depo;
        }
    }
}