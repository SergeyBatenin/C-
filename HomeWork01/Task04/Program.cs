Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = int.MinValue;

if ( a == b && b == c)
{
    System.Console.WriteLine("Все три числа равны");
}
if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
System.Console.WriteLine("Максимальное число равно: " + max);