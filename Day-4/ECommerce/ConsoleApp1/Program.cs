using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFeaturesDempApp
{
    internal class Program
    {
        public const double PI = 3.14;//allow to keep constant throughout
        public readonly string Name; //allows to variable initialize at the time of construction

        public Program()
        {
            Name = "Transflower";
        }
        static void Main(string[] args)
        {
            //Annonymous Type
            /*            Console.WriteLine("CSharp Demp App");

                        Program instance = new Program();


                        var instance2 = new { FirstName="Suyog", LastaName="Pandagare" };
                        Console.WriteLine(instance2.FirstName+" "+instance2.LastaName);

                        var flower = new
                        {
                            Id = 23,
                            Title = "Rose",
                            Description = "Wedding Flower",
                            UnitPrice=23,
                            Quantity=6000

                        };

                        int radius = 5;
                        *//*double area = CalculateArea(radius);
                        Console.WriteLine(area);

                        double cicum = CalculateCircumference(radius);
                        Console.WriteLine(cicum);*//*

                        double area=0, circum=0;
                        Console.WriteLine("Before calling Calculate function ");
                        Console.WriteLine(area);
                        Console.WriteLine(circum);

                        Calculate(radius, out area, out circum);  //out going parameter

                        Console.WriteLine("After calling Calculate function ");
                        Console.WriteLine(area);
                        Console.WriteLine(circum);

                        PrintAll("Sunbeam",22,instance);
                        PrintAll("IET", "IACSD", "ACTS",22.7);
                        PrintAll("seed", "transflower");
            */

            /*  int val1 = 65;
              int val2 = 33;
              Swap(ref val1,ref val2);
              Console.WriteLine(val1);
              Console.WriteLine(val2);*/

            //class is a reference type--reference type instances are pushed on heap---ex.class interface delegate event : reference type
            //structure is value type--value type instances are pushed on stack---ex.int float double char boolean : value types
            //we have more heap area than stack so its recommended to use class when we have to play with many objects
            Student s1 = new Student();
            s1.BirthDate = new DateTime(1998, 3, 17);
            s1.Name = "Suyog";
            s1.Location = "Amravati";
            s1.Id = 106;

            Student s2 = new Student();
            s2.BirthDate = new DateTime(1998, 6, 16);
            s2.Name = "Sanket";
            s1.Location = "Amravati";
            s1.Id = 15;

            int count = 56;  //value type
            object obj = count; //Boxing : converting value type to reference type

            int count2 = (int)obj; //Unboxing : converting reference type to value type

            int []numbers = { 23, 23, 34, 45, 56, 65 };
            int[] marks = new int[5] { 23,34,45,56,67 };
            string[] trainers = { "Prachi", "Kishori", "Madhura", "Nilesh", "Amit" };
            Student[] students =
            {
                new Student{BirthDate = new DateTime(1998, 3, 17),
                             Name = "Suyog",
                             Location = "Amravati",
                              Id = 106
                },
                new Student{BirthDate = new DateTime(1998, 3, 17),
                             Name = "Sanket",
                             Location = "Amravati",
                              Id = 10
                },
                              new Student{BirthDate = new DateTime(1998, 3, 17),
                             Name = "Aniket",
                             Location = "Amravati",
                              Id = 16
                              },

            };

            foreach (string s in trainers)
            {
                Console.WriteLine(s);
            }
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " " + student.BirthDate);
            }

            Order order1 = new Order();
            order1.Id = 343;
            order1.OrderDate = new DateTime(2022, 7, 23);
            order1.Customer = "IBM";
            order1.Status = "delivered";

            //object ka reference array jaisa kam kr raha hai
            //object ke ander array hai jo private hai usko access kr rahe
            Books books = new Books();
            books[0] = "Rich Dad Poor Dad";
            books[1] = "Wings of fire";
            books[2] = "Who move my Cheese";
            books[3] = "India Vision 2022";

            string bookTitle = books[1];
            Console.WriteLine(bookTitle);




            Console.ReadLine();


        }

        static double CalculateArea(int radius)
        {
            //area of circle
            double areaOfCircle =PI* radius * radius;
            return areaOfCircle;
        }

        static double CalculateCircumference(int radius)
        {
            //circumference of circle
            double circumferenceOfCircle = 2 * PI * radius;
            return circumferenceOfCircle;
        }

        //using incoming and out parameter we can return multiple values
        static void Calculate(int radius,out double area,out double circum)
        {
            area = PI * radius * radius;

            circum = 2 * PI * radius;
        
        }

        //vairable number of arguments can be accepted
        //only one signature and everything willl work
        //at runtime it can take variable number of parameters
        static void PrintAll(params object [] objects)
        {
            foreach (object o in objects)
            {
                Console.WriteLine(o);
            }
            
        }

        //use ref keyword for pass by reference so that references get swapped and not just values local to the function
        //pass by value only swaps values in local function only the main copy remains as it is 
        //hence to swap values we have to use pass by reference 
        static void Swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

    }
}
