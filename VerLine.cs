using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    class VerLine : Figure
    {
        public VerLine(int yUp, int yDown, int x, char sym, int x1)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
                Point pt = new Point(x1, y, sym);
                pList.Add(pt);
            }
        }
    }
}
