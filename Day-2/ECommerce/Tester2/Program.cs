using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
using Banking;
using ProjectManagement;
namespace Tester2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2022, 8, 1);
            DateTime endDate = new DateTime(2022, 8, 18);

            Project onlineShoppingProj = new Project("Online Shopping Solution","Vijay Sales ECommerce Solution",startDate,endDate);
            Console.WriteLine(onlineShoppingProj);
            Console.ReadLine();
        }
    }
}
