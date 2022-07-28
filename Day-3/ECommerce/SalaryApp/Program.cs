using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
namespace SalaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager("Rahul","Pande",
                "sameer.pande@gmail.com","sam",10000,5000,1500,10000,800000
                ,25000);

            //Polymorphism ===>ComputePay() of salesmanager will be called
            Employee employee = salesManager;
            double salary = employee.ComputePay();
            Console.WriteLine("Salary={0}", salary);

            Employee e2 = new SalesEmployee("Rajiv", "Sharma", "rajiv@gmail.com", "raj", 10000, 4000, 1000, 8000);
            double salary2 = employee.ComputePay();
            Console.WriteLine("Salary={0}", salary2);
            
            Console.ReadLine();
        
        
        }
    }
}
