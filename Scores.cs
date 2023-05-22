using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    class Scores
    {
        public Scores()
        {
            
        }
        public void Draw(int high, int width) 
        {
            Console.SetCursorPosition(high, width);
            Console.WriteLine("Scores: ");
        }
    }
}
