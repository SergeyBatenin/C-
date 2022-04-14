using System;
class Program
{
    /*
    * Дано предложение. Напишите рекурсивный метод,
    * подсчитывающий количество слов в данном предложении.
    * Словом считается последовательность символов без пробелов
    */

    // Не совсем правильный код, если например в данную фразу добавить тире
    // то он будет засчитан за слово
    // буду доделывать

    static void Main()
    {
        string s = "Лето лучшее время года";

        Console.WriteLine($"Данное предложение состоит из {CountWord(s)} слов(а)");
    }

    static int CountWord(string sentence, int length = 0)
    {
        if ( length == sentence.Length) return 1;

        if(sentence[length] == ' ')
        {
            return 1 + CountWord(sentence, ++length);
        }
        else
        {
            return 0 + CountWord(sentence, ++length);
        }
    }
}