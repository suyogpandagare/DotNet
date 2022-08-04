using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemoApp
{

    internal class Person:IDisposable
    {
        public Person() { }
        public Person(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        ~Person()
        {
            //Clean up logic
            //always called by secondary thread

            Console.WriteLine("Garbage Collector is deinitializing instnace...");
        }


        //Deterministic Finalization
        public void Dispose()
        {
            //dispose is always called by primary thread
            //Clean up logic

            // for resources like file, database connection, 
            // socket etc.
           // GC.SuppressFinalize(this);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
                Person person1 = new Person();
                person1.FirstName = "Raj";
                person1.LastName = "Sharma";

                Person person2 = new Person();
                person2.FirstName = "Raj";
                person2.LastName = "Sharma";

                Person person3 = new Person();
                person3.FirstName = "Raj";
                person3.LastName = "Sharma";

                person3.Dispose();


          
                //GC.Collect();
                //GC.SuppressFinalize(person);
                //GC.WaitForPendingFinalizers();
               


        }
    }
}
