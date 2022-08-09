using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 56, 54, 34, 76, 87, 98, 56, 89 };

            var firstFourNumbers = marks.Take(4);
            foreach( int number in firstFourNumbers)
            {
                Console.WriteLine(number);
            }


            var lastFewNumbers = marks.Skip(4);
            foreach (int number in lastFewNumbers)
            {
                Console.WriteLine(number);
            }


            MathEngine engine = new MathEngine();
            int num1 = 100;
            int num2 = 50;
            engine.Addition(num1, num2);
            Console.WriteLine( "Summation= "+engine.Result);

            engine.Subtraction(num1, num2);
            Console.WriteLine("Subtraction= " + engine.Result);

            engine.Multiplication(num1, num2);
            Console.WriteLine("Multiplication= " + engine.Result);

            engine.Division(num1, num2);
            Console.WriteLine("Division= " + engine.Result);


            string[] students = { "Raj", "Simran", "Amit", "Seeta", "Amarjeet", "Rojer", "Smith" };
            //LINQ
            var result= from student in students 
                        where student.Contains('a')
                         select student;

            foreach ( string student in result)
            {
                Console.WriteLine(student);
            }

            List<Student> dacStudents = new List<Student>();
            dacStudents.Add(new Student { StudentID = 1, Name = "Manisha Shinde", Age = 65});
            dacStudents.Add(new Student { StudentID = 2, Name = "Chitra Patil", Age = 35 });
            dacStudents.Add(new Student { StudentID = 3, Name = "Raveena Sharma", Age = 21 });
            dacStudents.Add(new Student { StudentID = 4, Name = "Sameera Deo", Age = 40 });
            dacStudents.Add(new Student { StudentID = 5, Name = "Raj Kale", Age = 38 });
            dacStudents.Add(new Student { StudentID = 6, Name = "Ganesh Mogarkar", Age = 25 });
            dacStudents.Add(new Student { StudentID = 7, Name = "Sameer Kulkarni", Age = 18 });


            //Business Rule

            Console.WriteLine("After Filter applying , Results shown");

            var filteredStudents = from student in dacStudents where student.Age> 20  && student.Age <45
                                   select student;

            foreach( Student student in filteredStudents )
            {
                Console.WriteLine(student.Name + " " + student.Age);
            }



            string companyName = "Transflower Learning Pvt. Ltd.";
            companyName.ShowString("fdfdf");

            Console.ReadLine();


        }
    }
}
