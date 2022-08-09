using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 67,12,87,34,11,76 };
            Array.Sort(numbers);
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("*******************************************************************");
            Person person1 = new Person { Age = 23, Salary = 56000, Location = "Pune", Name = "Raj" };
            Person person2= new Person  { Age = 45, Salary = 88000, Location = "Mumbai", Name = "Radhika" };
            Person person3 = new Person { Age = 33, Salary = 98000, Location = "Shivaji Nagar", Name = "Manisha" };
            Person person4 = new Person { Age = 23, Salary = 12000, Location = "Bangalore", Name = "Ruchira" };
            Person person5 = new Person { Age = 12, Salary = 89000, Location = "Patna", Name = "Jai" };
            Person person6 = new Person { Age = 38, Salary = 53000, Location = "Kolkatta", Name = "Vijay" };
            Person[] people = { person1, person2, person3, person4, person5, person6 };
            Array.Sort(people);

            foreach( Person prn in people)
            {
                Console.WriteLine( prn.Name  + "  "+ prn.Age + "  "+ prn.Salary + " "+ prn.Location);
            }
            Console.WriteLine("*******************************************************************");

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 12, Name = "Shivkumar" });
            employees.Add(new Employee { Id = 13, Name = "Reena" });
            employees.Add(new Employee { Id = 14, Name = "Raj" });
            employees.Add(new Employee { Id = 15, Name = "Ravindranath" });
            employees.Add(new Employee { Id = 16, Name = "Sharan" });

            EmployeeComparer ec=new EmployeeComparer();

            employees.Sort(ec);
            foreach( Employee emp in employees)
            {
                Console.WriteLine(emp.Id + " " + emp.Name);
            }

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Enumerating each person in Team");

            Team indiaTeam = new Team();
            foreach( Person p in indiaTeam)
            {
                Console.WriteLine(p.Name + " " + p.Location +  " "+ p.Age);
            }

            Console.ReadLine();
        }
    }
}
