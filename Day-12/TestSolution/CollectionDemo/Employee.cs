using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            int ret=e1.Name.Length.CompareTo(e2.Name.Length);
            return ret;
        }
    }
}
