using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    public static class Helper
    {
        public static void ShowString(this string s, string data)
        {
            Console.WriteLine("This is output from extension method....");
        }
        //Adopted method
        //Extension Methods
        public static   void Multiplication(this MathEngine m,int num1, int num2)
        {
           m.Result = num1 * num2;
        }
        public static   void Division(this MathEngine m,int num1, int num2)
        {
           m.Result = num1 /num2;
        }
    }
}
