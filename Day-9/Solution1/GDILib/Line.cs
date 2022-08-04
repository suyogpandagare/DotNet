using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDILib
{
    public  class Line : Shape
    {
        Point StartPoint;
        Point EndPoint;
        public Line()
        {
            this.StartPoint.X = 0;
            this.StartPoint.Y = 0;
            this.EndPoint.X= 0;
            this.EndPoint.Y = 0;
        }

        public Line(Point pt1, Point pt2)
        {
            this.StartPoint = pt1;
            this.EndPoint = pt2;
        }
        public override void Draw()
        {
            Console.WriteLine("Start Point= {0}, {1} , EndPoint= {2}, {3}",
                              StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y);
        }
    }
}
