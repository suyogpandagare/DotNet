using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemoapp
{
    internal class Person
    {
        public Person() { }
        public Person(string fname ,string lname) { 
            this.FirstName = fname;
            this.LastName = lname;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
