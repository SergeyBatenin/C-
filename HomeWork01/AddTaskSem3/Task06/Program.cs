using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество символов генерируемого пароля");
        int count = CountCheck();
        Console.WriteLine(GeneratePassword(count));

        // Проверка на длину пароля
        int CountCheck()
        {

            int passwordLength = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (passwordLength <= 4)
                {
                    Console.WriteLine("Длина вашего пароля ненадежна. Повторите ввод");
                    passwordLength = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            return passwordLength;
        }

        
        string GeneratePassword(int length)
        {
            string password = "";
            Random rnd = new Random();
            
                int word = rnd.Next(length);    // Это ключевые значения для выполнения условия, что в пароле
                int digit = rnd.Next(length);   // обязательно должна быть буква, цифра и спецсимвол
                int symbol = rnd.Next(length);  // Когда мы доходим до определенного значения i при генерации пароля
                                                // мы принудительно выбираем, что именно нам надо сгенерировать соответственно
            while (true)
            {
                if (word == digit)
                {
                    digit = rnd.Next(length);   // А здесь собственно проверяем, чтобы ключевые значения
                }
                else if (digit == symbol)       // не совпали друг с другом и не заменили значения при генерации пароля
                {
                    symbol = rnd.Next(length);
                }
                else{
                    break;
                }
            }

            for (int i = 0; i < length; i++)    // Собственно сама генерация пароля через чары по таблице ASCII
            {
                char pass;
                if (i == word)
                {
                    pass = (char)rnd.Next(65, 91);
                    password = password + pass;
                }
                else if (i == digit)
                {
                    pass = (char)rnd.Next(48, 58);
                    password = password + pass;
                }
                else if (i == symbol)
                {
                    pass = (char)rnd.Next(33, 48);
                    password = password + pass;
                }
                else
                {
                    pass = (char)rnd.Next(33, 127);
                    password = password + pass;
                }
            }
            return password;
        }
    }
}