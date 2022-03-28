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
        //Console.SetBufferSize( 80, 25 );
        Console.Clear();

        HorizontalLine topBorder = new HorizontalLine(0, 79, 0, '#');
        HorizontalLine botBorder = new HorizontalLine(0, 79, 24, '#');
        VerticalLine leftLine = new VerticalLine(0, 0, 24, '#');
        VerticalLine rightLine = new VerticalLine(79, 0, 24, '#');
        topBorder.Draw();
        botBorder.Draw();
        leftLine.Draw();
        rightLine.Draw();

        Point p = new Point(20, 10, '█');
        Snake snake = new Snake(p, 4, Direction.RIGHT);
        snake.Draw();

        FoodCreator foodCreator = new FoodCreator(80, 25, '$');
        Point food = foodCreator.CreateFood();
        food.Draw();

        while (true)
        {
            if (snake.Eat(food))
            {
                food = foodCreator.CreateFood();
                food.Draw();
            }
            else
            {
                snake.Move();
            }

            Thread.Sleep(100);
            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.HandleKey(key.Key);
            }
        }

    }
}