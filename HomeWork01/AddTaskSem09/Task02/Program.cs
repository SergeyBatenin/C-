using System;
class Program
{
    /*
    * Известно, что пароль длиной 3 символа состоит из латинских
    * букв строчного регистра и цифр от 0 до 9. Напишите рекурсивный
    * метод, который перебирает все комбинации паролей
    */
    static int n = 1;
    static void Main()
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
        //string alphabet = "0123456789";
        GeneratePassword(alphabet, new char[3]);
    }

    static void GeneratePassword(string alphabet, char[] password, int length = 0)
    {
        if (length == password.Length)
        {
            Console.WriteLine($"{n++, -5} {new String(password)}");
            return;
        }
        
        for (int i = 0; i < alphabet.Length; i++)
        {
            password[length] = alphabet[i];
            GeneratePassword(alphabet, password, length + 1);
        }
        
    }
}