using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationDemoApp
{
    public class Line : Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public override void Draw()
        {
           Console.WriteLine("Start Point {0},End Point {1},Width={2},Color={3}",
               StartPoint, EndPoint,Width,Color);
        }
    }
}
