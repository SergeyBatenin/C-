using System;
using System.Diagnostics;
class Program
{
    static string vowels = "аеиоуыэюя";
    static void Main()
    {
        string s = "без труда не выловишь и рыбку из пруда";
        string s1 = "Под лежачий камень вода не течет";
        string s2 = "Интересная ошибка, кстати вылезла во время проверки)) когда проверял через метод contains все считало отлично"
        + "а вот когда переписал через if вот тут то и был сюрприз) вместо 13 букв он считал только 11)) замучался запускать дебагер"
        + "в этом ВС Коде, но когда все таки смог, то заметил что он в слове \"труда\" на букве \"а\" выдает false. Вот тут то и заподозрил"
        + "неладное оказалось, что при копипасте поговорки с гуглдоков там у этой буквы видимо другая кодировка символа и поэтому он не "
        + "проходил проверку и не подсчитывал данную букву";

        /*
        * Почему третью строку он считает по времени быстрее первой хотя она намного длиннее?
        */

        
        var watch = Stopwatch.StartNew();
        Console.WriteLine($"Количество гласных букв в поговорке \"{s}\"  составляет {CountVowels(s)} штук");
        watch.Stop();
        Console.WriteLine("time elapsed: " + watch.Elapsed.TotalMilliseconds * 1000 + " ms");

        watch = Stopwatch.StartNew();
        Console.WriteLine($"Количество гласных букв в поговорке \"{s1}\"  составляет {CountVowels(s1)} штук");
        watch.Stop();
        Console.WriteLine("time elapsed: " + watch.Elapsed.TotalMilliseconds * 1000 + " ms");

        watch = Stopwatch.StartNew();
        Console.WriteLine($"Количество гласных букв в поговорке \"{s2}\"  составляет {CountVowels(s2)} штук");
        watch.Stop();
        Console.WriteLine("time elapsed: " + watch.Elapsed.TotalMilliseconds * 1000 + " ms");
    }

    static int CountVowels(string s, int index = 0)
    {
        if (s.Length == index) return 0;

        /*
        * Интересная ошибка, кстати вылезла во время проверки))
        * когда проверял через метод contains все считало отлично
        * а вот когда переписал через if вот тут то и был сюрприз)
        * вместо 13 букв он считал только 11)) замучался запускать
        * дебагер в этом ВС Коде, но когда все таки смог, то заметил
        * что он в слове "труда" на букве "а" выдает false. Вот тут то и заподозрил неладное
        * оказалось, что при копипасте поговорки с гуглдоков там у этой буквы
        * видимо другая кодировка символа и поэтому он не проходил проверку
        * и не подсчитывал данную букву
        */

        char c = s[index];
        if (c == 'а' || c == 'е' || c == 'и' || c == 'о' || c == 'у' || c == 'ы' || c == 'э' || c == 'ю' || c == 'я')
            //if (vowels.Contains(s[index]))
            return 1 + CountVowels(s, ++index);
        else
            return 0 + CountVowels(s, ++index);
    }
}