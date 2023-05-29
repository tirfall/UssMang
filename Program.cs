using Snake;
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

            Walls walls = new Walls(119, 30);
            walls.Draw();
            //Scores scores = new Scores();
            //scores.Draw(120, 0);
            //Змейка
            Point p = new Point(6, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '+');
            Point food = foodCreator.CreateFood();
            food.Draw();
            FoodCreator foodCreatormin = new FoodCreator(80, 25, '-'); //Возможно ошибка в создании
            Point foodmin = foodCreatormin.CreateFood();
            foodmin.Draw();

            while (true)
            {
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

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();

            //Sound mäng = new Sound();
            //ConsoleKeyInfo nupp= new ConsoleKeyInfo();
            //_= mäng.Heli("../../../.mp3")
            //


        }
        static void WriteGameOver()
        {
            int xOffset = 45;
            int yOffset = 9;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("=============================", xOffset, yOffset++);
            WriteText("GAME OVER", xOffset + 10, yOffset++);
            yOffset++;
            WriteText("Sisesta sinu nimi:", xOffset + 5, yOffset++);
            Console.SetCursorPosition(xOffset, yOffset);
            

            WriteText("=============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}