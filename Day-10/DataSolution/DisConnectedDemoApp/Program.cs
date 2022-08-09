using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using MySql.Data.MySqlClient;


namespace DisConnectedDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = DataManager.GetAll();

            /* var filteredEmployees= from employee in employees
                                    where employee.Salary < 100000
                                    orderby employee.Salary descending
                                    select employee;
*/

             foreach( Employee employee in employees)
             {
                 Console.WriteLine(employee.ID + " " + employee.Name + "  " + employee.Salary);
             }

            Employee emp = new Employee { ID = 756, Name = "Raju Don", Designation = "Developer", Salary =56000 };
             DataManager.Insert(emp);
           //  DataManager.Update(emp);
              Console.WriteLine("After Insertion :");
            List<Employee> employees2 = DataManager.GetAll();
             foreach (Employee employee in employees2)
             {
                 Console.WriteLine(employee.ID + " " + employee.Name + "  " + employee.Designation);
             }
            Console.ReadKey();
        }
    }
}
