using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    public class Scores
    {
        public Scores()
        {
            
        }
        public static void Statistics(int score, int speed) 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Point point = new Point(1, 27, Convert.ToChar(score));
            point.Draw();
            Point point1 = new Point(1, 28, Convert.ToChar(speed));
            point1.Draw();
            
        }
        
    }
}
