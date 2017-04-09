using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.SetWindowSize(120, 31);
            Console.SetBufferSize(120, 31);
            
            //точки
            Point p1 = new Point(7, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.UP);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();


            //рамочка
            HorisontalLine upLine = new HorisontalLine(0, 119, 0, '_');
            HorisontalLine downLine = new HorisontalLine(0, 119, 29, '_'); 
            VerticalLine leftLine = new VerticalLine(0, 0, 29, '|');
            VerticalLine rightLine = new VerticalLine(119, 0, 29, '|');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Console.ReadLine();

         /* List< int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

           foreach(int i in numList)
            {
                Console.Write(i);
                Console.ReadLine();
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);*/
        }
    }
}
