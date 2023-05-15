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

            FoodCreator foodCreator = new FoodCreator(80, 25, '+');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else { snake.Move(); }
                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }


            //Sound mäng = new Sound();
            //ConsoleKeyInfo nupp= new ConsoleKeyInfo();
            //_= mäng.Heli("../../../.mp3")
            //

            
        }
    }
}