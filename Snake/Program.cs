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
        Point p1 = new Point();
        p1.x = 4;
        p1.y = 6;
        p1.sym = '+';
        p1.Draw();
    }    
}