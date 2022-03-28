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

        int count = 0;

        Wall mapBorder = new Wall(80, 25);
        mapBorder.Draw();

        Point p = new Point(20, 10, '█');
        Snake snake = new Snake(p, 4, Direction.RIGHT);
        snake.Draw();

        FoodCreator foodCreator = new FoodCreator(80, 25, '$');
        Point food = foodCreator.CreateFood();
        food.Draw();

        while (true)
        {
            if (mapBorder.isHit(snake) || snake.isHitTail())
            {
                Console.Clear();
                Console.WriteLine("Game over");
                Console.WriteLine($"Your score = {count}");
                break;
            }
            if (snake.Eat(food))
            {
                food = foodCreator.CreateFood();
                food.Draw();
                count++;
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
    static void Draw( Figure figure )
    {
        figure.Draw();
    }
}