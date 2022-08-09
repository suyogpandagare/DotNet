using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    public sealed class MathEngine
    {
        public int Result { get; set; }
        public void Addition(int num1, int num2)
        {
            this.Result=num1+ num2;
        }
        public void Subtraction(int num1, int num2)
        {
            this.Result = num1 - num2;
        }
    }
}
