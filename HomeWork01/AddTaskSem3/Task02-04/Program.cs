using System;
class Program
{
    static void Main()
    {
        // Координаты точек векторов ab, cd
        //double ax = 1, ay = 1, bx = 7, by = 3, cx = 2, cy = 4, dx = 3, dy = 2;      // Вариант, если не пересекаются
        double ax = 1, ay = 1, bx = 7, by = 3, cx = 2, cy = 4, dx = 5, dy = 1;      // Вариант, если пересекаются
        //double ax = 1, ay = -1, bx = 7, by = 1, cx = 2, cy = 2, dx = 5, dy = -1;    // Вариант, если точка пересечения лежит на оси координат
        //double ax = 1, ay = 1, bx = 7, by = 3, cx = 4, cy = 2, dx = 7, dy = 1;      // Вариант, если точка одного вектора лежит на другом векторе
        
        CheckCrossVectors(ax, ay, bx, by, cx, cy, dx, dy);
        

        void CheckCrossVectors(double ax, double ay, double bx, double by, double cx, double cy, double dx, double dy){

            // Определим координаты векторов
            double xAB = bx - ax;
            double yAB = by - ay;
            double xCD = dx - cx;
            double yCD = dy - cy;
            double xAC = cx - ax;
            double yAC = cy - ay;
            double xAD = dx - ax;
            double yAD = dy - ay;
            double xCA = ax - cx;
            double yCA = ay - cy;
            double xCB = bx - cx;
            double yCB = by - cy;

            // Определим расположение точек одного вектора относительно второго
            // через векторные произведения
            double abac = xAB * yAC - yAB * xAC;
            double abad = xAB * yAD - yAB * xAD;
            double cdca = xCD * yCA - yCD * xCA;
            double cdcb = xCD * yCB - yCD * xCB;

            // А теперь определяем пересекаются ли данные вектора и находим точку пересечения
            // Вектора пересекаются если оба произведения будут меньше 0

            if (abac * abad < 0 && cdca * cdcb < 0)
            {
                double a1 = by - ay;
                double b1 = ax - bx;
                double c1 = ax * (ay - by) + ay * (bx - ax);
                double a2 = dy - cy;
                double b2 = cx - dx;
                double c2 = cx *(cy - dy) + cy *(dx - cx);

                // А теперь находим саму точку пересечения
                double k = a1 * b2 - b1 * a2;
                double kx = -1 * c1 * b2 - b1 * c2 * (-1);
                double ky = a1 * c2 * (-1) - (-1) * c1 * a2;

                // координаты точки пересечения будут равны:
                double coordX = kx / k;
                double coordY = ky / k;

                // Найдем в какой четверти находится точка пересечения
                
                if (coordX > 0 && coordY > 0)
                    Console.WriteLine(" Вектора ab и cd пересекаются в точке с координатами (" + coordX + ", " + coordY + ") которая находится в 1 четверти");
                else if (coordX < 0 && coordY > 0)
                    Console.WriteLine(" Вектора ab и cd пересекаются в точке с координатами (" + coordX + ", " + coordY + ") которая находится во 2 четверти");
                else if (coordX < 0 && coordY < 0)
                    Console.WriteLine(" Вектора ab и cd пересекаются в точке с координатами (" + coordX + ", " + coordY + ") которая находится в 3 четверти");
                else if (coordX > 0 && coordY < 0)
                    Console.WriteLine(" Вектора ab и cd пересекаются в точке с координатами (" + coordX + ", " + coordY + ") которая находится в 4 четверти");
                else if (coordX == 0 || coordY == 0)
                    Console.WriteLine(" Вектора ab и cd пересекаются в точке с координатами (" + coordX + ", " + coordY + ") Однозначно определить четверть невозможно");
                
            }
            else
            {
                Console.WriteLine("Данные вектора не пересекаются");
            }
        }
    }
}