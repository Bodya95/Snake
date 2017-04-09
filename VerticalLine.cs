using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {    
        public VerticalLine(int x, int ytop, int ybottom, char sym)
        {
            pList = new List<Point>();

            for (int y = ytop; y <= ybottom; y++)
            {
                Point n = new Point(x, y, sym);
                pList.Add(n);
            }

        }
    }
}
