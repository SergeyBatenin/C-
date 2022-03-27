﻿using System;
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
       
        HorizontalLine topBorder = new HorizontalLine(0,78, 0, '#');
        HorizontalLine botBorder = new HorizontalLine(0,78, 24, '#');
        VerticalLine leftLine = new VerticalLine(0, 0, 24, '#');
        VerticalLine rightLine = new VerticalLine(78, 0, 24, '#');
        topBorder.Draw();
        botBorder.Draw();
        leftLine.Draw();
        rightLine.Draw();

        Point p = new Point(20, 10, '█');
        Snake snake = new Snake(p, 4, Direction.RIGHT);
        snake.Draw();
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        
    }
}