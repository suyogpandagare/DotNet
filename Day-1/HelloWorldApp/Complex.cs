using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    internal class Complex
    {
        int real;
        int imag;

        public Complex()
        {
            real = 0;
            imag = 0;
        }
        public Complex(int num1,int num2)
        {
            this.real = num1;
            this.imag = num2;
        }

        /*static void Main(string[] args)
        {
            int i = 15;
            bool status = true;
            string s = "Suyog";
            Console.WriteLine(s);
            Console.WriteLine(Add(14,54));
            Console.WriteLine(Add(45, 54, 23));

            Complex c1 = new Complex(44,77);
            Complex c2 = new Complex(33, 66);

            Complex c3 = c1 + c2;
            Complex c4 = c1 - c2;

            Console.WriteLine(c3.real + " + " + c3.imag + "i");
            Console.WriteLine(c4.real + " + " + c4.imag + "i");

            Console.ReadLine();
        }*/

        //Function Overloading
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Add(int num1,int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
            c3.real = c1.real + c2.real;    
            c3.imag = c1.imag + c2.imag;
            return c3;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
            c3.real = c1.real - c2.real;
            c3.imag = c1.imag - c2.imag;
            return c3;
        }

    }
}
