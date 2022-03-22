using System;
class Program
{
    /*
    Напишите метод, который заполняет массив случайным количеством (от 1 до 100) 
    нулей и единиц. Размер массива должен совпадать с количеством единиц в нём
    */

    static void Main()
    {
        int[] array;
        array = FillArray();
        PrintArray(array);
    }

    static int[] FillArray()
    {
        Random rnd = new Random();
        string s = string.Empty;
        int count = 0;
        int i = 0;
        bool flag = false;
        while (!flag)
        {
            i++;
            int temp = rnd.Next(2);
            s = s + temp;
            if (temp == 1)
            {
                count++;
            }
            if (count * count == i)
            {
                flag = true;
            }

            /*
            * По сути проверкой ниже мы сразу проверяем условие задачи,
            * массив у нас будет длиной от 1 ДО 100, иначе псевдослучайная
            * генерация массива у нас не удалась и возвращаем пустой массив
            */

            if (count > 9 || i == 100)
            {
                Console.WriteLine("Количество элементов со значением 1 сгенерировалось больше,\n" +
                                "поэтому создать массив под заданные условия не представляется возможным");

                return new int[0];
            }
        }

        int[] array = new int[count * count];
        for (int j = 0; j < array.Length; j++)
        {
            array[j] = Convert.ToInt32(s[j].ToString());
        }
        
        return array;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();
    }
}