using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            Console.SetWindowSize(120, 30);
            //рамка
            HorizontalLine xline = new HorizontalLine(0,119,0,'#',29);
            xline.Drow();
            VerLine yline = new VerLine(0, 29, 0, '#', 119);
            yline.Drow();

            //Змейка
            Point p = new Point (6, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        snake.direction = Direction.LEFT;
                    }
                }
            }
            
            
            



            //Sound mäng = new Sound();
            //ConsoleKeyInfo nupp= new ConsoleKeyInfo();
            //_= mäng.Heli

            Console.ReadLine();
        }
    }
}