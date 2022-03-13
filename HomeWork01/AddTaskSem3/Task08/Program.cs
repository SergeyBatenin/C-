using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите цифру, элементы содержащие которую будут удалены");
        int digit = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        int count = 0;
        count = FillArray(array, digit, count);

        /* 
        В принципе счетчик можно было ввести в методе FillArray и там его считать,
        сам метод FillArray сделать void и в конце метода вызывать уже другой метод
        FinalArray, который принимал бы заполненный массив и счетчик элементов, которые надо удалить 
        */

        // PrintArray(array);
        // Console.WriteLine();

        FinalArray(array, count);

        // Заполняем начальный массив и проверяем на наличие элементов содержащих заданную цифру
        int FillArray(int[] ar, int num, int count)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Random rnd = new Random();
                ar[i] = rnd.Next(100);
                int temp = ar[i];
                while (temp > 0)
                {
                    if (temp % 10 == num)
                    {
                        ar[i] = -1;
                        count++;
                        break;
                    }
                    temp /= 10;
                }
            }
            return count;
        }

        // Заполняем новый массив без элементов содержащих заданную цифру и выводим на печать
        void FinalArray(int[] arr, int count)
        {
            int[] finalArray = new int[arr.Length - count];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    finalArray[j] = arr[i];
                    j++;
                }
            }
            PrintArray(finalArray);
            Console.WriteLine("Всего было удалено " + count + " элементов");

        }

        void PrintArray (int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}