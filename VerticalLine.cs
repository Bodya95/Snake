using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> nList;

        public VerticalLine(int x, int ytop, int ybottom, char sym)
        {
            nList = new List<Point>();

            for (int y = ytop; y <= ybottom; y++)
            {
                Point n = new Point(x, y, sym);
                nList.Add(n);
            }

        }

        public void Drow_y()
        {
            foreach(Point n in nList)
            {
                n.Draw();
            }
        }
    }
}
