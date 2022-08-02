using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationDemoApp
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            string str = string.Empty;
            str = string.Format("x={0}, Y={1}", X, Y);
            return str;
        }
    }
}
