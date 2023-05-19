using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UssMang;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Отрисовка рамочки
            HorizontalLine horlines = new HorizontalLine(0, 119, 0, '#', 26);
            VerLine verlines = new VerLine(0, 26, 0, '#', 119);
            horlines.Draw();
            verlines.Draw();

            wallList.Add(horlines);
            wallList.Add(verlines);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}