using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    public class Gameover
    {
        public static void WriteGameOver()
        {
            int xOffset = 45;
            int yOffset = 9;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("=============================", xOffset, yOffset++);
            WriteText("GAME OVER", xOffset + 10, yOffset++);
            WriteText("=============================", xOffset, yOffset++);
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Program.Main();
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
