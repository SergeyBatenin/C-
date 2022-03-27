using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Point p in pList)
            {
                p.Draw();
            }
            Console.ResetColor();            
        }        
    }
}