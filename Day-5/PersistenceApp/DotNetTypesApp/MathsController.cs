using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTypesApp
{
    public class MathsController
    {
        public void Add(int num1, int num2)
        {
            int result=num1 + num2;
            Console.WriteLine(result);
        }

        public void Mult(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        public void Divide(int num1, int num2)
        {
            int result = num1 / num2;
        }

        public void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
        }
    }
}
