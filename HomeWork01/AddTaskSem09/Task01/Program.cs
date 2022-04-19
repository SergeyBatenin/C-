using System;
class Program
{
    /*
    * Дано предложение. Напишите рекурсивный метод,
    * подсчитывающий количество слов в данном предложении.
    * Словом считается последовательность символов без пробелов
    */

    // Вроде бы теперь не считает знаки пунктуации за отдельные слова))

    static void Main()
    {
        string s = "Лето - самое лучшее время года";

        Console.WriteLine($"Данное предложение состоит из {CountWord(s)} слов(а)");
    }

    static int CountWord(string sentence, int length = 0)
    {
        if ( length == sentence.Length) return 1;

        if(sentence[length] == ' ')
        {
            return 1 + CountWord(sentence, ++length);
        }
        /* К сожалению на данный момент ничего, кроме такого костыля в голову не пришло
        * Хотя, возможно, можно было бы как то отформатировать строку и загнать ее в массив строк
        * через сплит и уже считать количество элементов в массиве,но как там расписать тоже все
        * возможные знаки пунктуации в разделители пока тоже не знаю
        */
        else if ((sentence[length] > 33 && sentence[length] < 47) || (sentence[length] > 58 && sentence[length] < 64))
        {
            return -1 + CountWord(sentence, ++length);
        }
        else
        {
            return 0 + CountWord(sentence, ++length);
        }
    }
}