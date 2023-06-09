using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    public class Kiirendatud
    {
        public static void kiirem()
        {
            int speed = 25;
            Console.Clear();
            Console.SetWindowSize(120, 30);
            //рамка
            Console.ForegroundColor = ConsoleColor.Cyan;
            Walls walls = new Walls(119, 30);
            walls.Draw();

            //Змейка
            Console.ForegroundColor = ConsoleColor.Yellow;
            Point p = new Point(6, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //еда
            Console.ForegroundColor = ConsoleColor.White;
            FoodCreator foodCreator = new FoodCreator(80, 25, '+');
            Point food = foodCreator.CreateFood();
            food.Draw();
            FoodCreator foodCreatormin = new FoodCreator(80, 25, '-');
            Point foodmin = foodCreatormin.CreateFood();
            foodmin.Draw();

            while (true)
            {
                Scores.Statistics(0, 0);
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();

                }
                if (snake.Eatmin(foodmin))//Создаёт минусы
                {
                    foodmin = foodCreatormin.CreateFood();
                    foodmin.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            Gameover.WriteGameOver();

            //Sound mäng = new Sound();
            //ConsoleKeyInfo nupp= new ConsoleKeyInfo();
            //_= mäng.Heli("../../../.mp3")
            //

        }
    }
}
