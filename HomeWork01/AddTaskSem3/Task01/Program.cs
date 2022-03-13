using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер координатной чертверти");
        int quarter = QuarterCheck();   //Запрашиваем номер четверти и проверяем на корректность

        int xMultiply, yMultiply;
        switch (quarter)        //Задаем коэффициенты для координат точек в зависимости от четверти
        {
            case 1:
                xMultiply = 1;
                yMultiply = 1;
                break;
            case 2:
                xMultiply = -1;
                yMultiply = 1;
                break;
            case 3:
                xMultiply = -1;
                yMultiply = -1;
                break;
            case 4:
                xMultiply = 1;
                yMultiply = -1;
                break;
            default:
                xMultiply = 0;
                yMultiply = 0;
                break;
        }

        Random rnd = new Random();  // Получаем координаты 3 точек

        int xA = xMultiply * rnd.Next(30);
        int yA = yMultiply * rnd.Next(30);

        int xB = xMultiply * rnd.Next(30);
        int yB = yMultiply * rnd.Next(30);

        int xC = xMultiply * rnd.Next(30);
        int yC = xMultiply * rnd.Next(30);

        Console.WriteLine("Координаты точек: A (" + xA + ", " + yA + ")  B (" + xB + ", " + yB + ")  C (" + xC + ", " + yC + ")");

        //Высчитываем возможные расстояния через метод и записываем в массив для удобства работы
        double[] array = new double[6];
        array[0] = distance(xA, yA, 0, 0) + distance(xB, yB, xA, yA) + distance(xC, yC, xB, yB);
        array[1] = distance(xA, yA, 0, 0) + distance(xC, yC, xA, yA) + distance(xB, yB, xC, yC);
        array[2] = distance(xB, yB, 0, 0) + distance(xA, yA, xB, yB) + distance(xC, yC, xA, yA);
        array[3] = distance(xB, yB, 0, 0) + distance(xC, yC, xB, yB) + distance(xA, yA, xC, yC);
        array[4] = distance(xC, yC, 0, 0) + distance(xB, yB, xC, yC) + distance(xA, yA, xB, yB);
        array[5] = distance(xC, yC, 0, 0) + distance(xA, yA, xC, yC) + distance(xB, yB, xA, yA);

        ShortCut(array); // Ищем кратчайший путь и выдает результат с длиной и маршрутом

        
        
        int QuarterCheck()
        {

            int coordQuarter = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (coordQuarter < 1 || coordQuarter > 4)
                {
                    Console.WriteLine("Введен некорректный номер координатной четверти. Повторите ввод");
                    coordQuarter = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            return coordQuarter;
        }

        double distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }


        void ShortCut(double[] arr)
        {
            double minDistance = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (arr[i] < minDistance)
                {
                    minDistance = arr[i];
                    minIndex = i;
                }
            }

            switch(minIndex)
            {
                case 0:
                    Console.WriteLine("Кратчайший путь проходит через последовательность точек A-B-C и занимает расстояние в " + minDistance);
                    break;
                case 1:
                    Console.WriteLine("Кратчайший путь проходит через последовательность точек A-C-B и занимает расстояние в " + minDistance);
                    break;
                case 2:
                    Console.WriteLine("Кратчайший путь проходит через последовательность точек B-A-C и занимает расстояние в " + minDistance);
                    break;
                case 3:
                    Console.WriteLine("Кратчайший путь проходит через последовательность точек B-C-A и занимает расстояние в " + minDistance);
                    break;
                case 4:
                    Console.WriteLine("Кратчайший путь проходит через последовательность точек C-B-A и занимает расстояние в " + minDistance);
                    break;
                case 5:
                    Console.WriteLine("Кратчайший путь проходит через последовательность точек C-A-B и занимает расстояние в " + minDistance);
                    break;
            }
        }
    }
}