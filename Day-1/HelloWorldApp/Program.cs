using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person process is running");

            try
            {
                Person person = new Person();
                //this syntax is taken from VB language

                person.Name = "Suyog Pandagare";
                person.Id = 106;

                string objName = person.Name;  //property on RHS means getter is called
                Console.WriteLine("name is "+objName);
            }
            catch
            {
                Console.WriteLine("Cannot enter null Name");
            }
            finally
            {
                Console.WriteLine("The Code executed properly");
            }

            Console.ReadLine();

        }
    }
}
