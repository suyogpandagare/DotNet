using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Person:IComparable
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Person temp =(Person)obj;
            if (this.Age > temp.Age)
                return 1;
            if (this.Age < temp.Age)
                return -1;
            else
                return 0;
        }
    }
}
