Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if ( a > b)
{
    Console.WriteLine("число " + a + " больше числа " + b);
} else if (a < b)
{
    Console.WriteLine("число " + b + " больше числа " + a);
} else if (a == b)
 {
    Console.WriteLine("Числа " + a + " и " + b + " равны");
}
        
    
