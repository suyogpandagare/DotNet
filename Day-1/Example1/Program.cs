using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 20;                //setter will be called
            Console.WriteLine("Student Id is = " + student.Id);  //getter will be called
            Console.ReadLine();
        }
    }
}
