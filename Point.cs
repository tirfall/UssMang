using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        private int v1;
        private int v2;
        private string v3;

        public Point(int _x, int _y, char _sym) 
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(int v, Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }


        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public bool IsHit(Point p)
        {
            return p.x== this.x && p.y == this.y;
        }

        public void Draw() 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x+","+y+","+sym;
        }
    }
}
