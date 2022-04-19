using System;
class Program
{
    /*
    * Напишите рекурсивный метод, который принимает номер года
    * и определяет, является ли он високосным или нет.
    */

    static void Main()
    {
        int year = 1700;
        Console.WriteLine(LeapYear(year));
    }

    // Код Дмитрия, свою версию так и не осилил =(
    // Рекурсия по сути высасывается из пальца ()
    static bool LeapYear(int year)
    {
        if (year % 400 == 0) return LeapYear(year / 100);   // на этом месте можно смело было писать true
        else if (year % 100 == 0) return LeapYear(year / 100);  // а на этом false 
        else if (year % 4 == 0) return true;                // и будет аобсолютно также работать
        else return false;                                  // единственное что разобрал для себя
                                                            // это почему именно делить год на 100
        
    }
}