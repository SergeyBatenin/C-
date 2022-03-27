using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Snake;
class Program
{
    static void Main()
    {
        Console.Clear();
        Point p1 = new Point();
        p1.x = 4;
        p1.y = 6;
        p1.sym = '+';
        p1.Draw();
        
        Point p2 = new Point(6, 7, '#');
        p2.Draw();

        HotizontalLine hLine = new HotizontalLine(4, 7, 8, '*');
        hLine.Draw();

        VerticalLine vLine = new VerticalLine(8, 6, 10, '$');
        vLine.Draw();             

    }
}