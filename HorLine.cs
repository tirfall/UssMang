using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym, int y1) 
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++) 
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
                Point pt = new Point(x, y1, sym);
                pList.Add(pt);
            }
        }
    }
}
