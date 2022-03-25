using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {            
        }

        public Point(int xCoord, int yCoord, char symbol)
        {
            x = xCoord;
            y = yCoord;
            sym = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}