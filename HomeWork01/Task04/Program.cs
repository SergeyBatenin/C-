Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if ( a == b && b == c)
{
    Console.WriteLine("Числа " + a + ", " + b + " и " + c + " равны");
} else if (b >= a && b >= c)
{
    Console.WriteLine("число " + b + " больше чисел " + a + " и " + c);
} else if (c >= a && c >= b)
{
    Console.WriteLine("число " + c + " больше чисел " + a + " и " + b);
} else if (a >= b && a >= c)
{
    Console.WriteLine("число " + a + " больше чисел " + b + " и " + c);
}
        